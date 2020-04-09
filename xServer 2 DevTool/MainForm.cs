using Newtonsoft.Json;
using Ptv.XServer.Controls.Map;
using Ptv.XServer.Controls.Map.Layers.Shapes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Windows.Forms;
using System.Windows.Media;

using xS2Development.xRouteWSService;

namespace xS2Development
{
    public partial class MainForm : Form
    {
        private XRouteClient xRouteClient = new XRouteClient();

        private System.Windows.Point mapCoordStart;
        private System.Windows.Point mapCoordVia;
        private System.Windows.Point mapCoordDest;
        //private ShapeLayer zoomToLayer = null;

        private ShapeLayer routingLayer = null;
        private ShapeLayer reachablePointsLayer = null;
        private ShapeLayer violatedPointsLayer = null;

        private xRouteWSService.RouteOptions routeOptions = null;
        private xRouteWSService.RouteRequest routeRequest = null;
        private xRouteWSService.RouteResponse routeResponse = null;
        public xRouteWSService.Theme truckAttributesTheme = null;
        public xRouteWSService.Theme generalTruckRestrictionsTheme = null;
        public xRouteWSService.Theme trafficIncidentsTheme = null;
        public xRouteWSService.Theme speedPatternsTheme = null;

        //private List<xDimaWSService.OnRoadRouteLocation> locationsList;
        //private List<xDimaWSService.OnRoadRouteLocation> violatedLocationsList;

        private string fileLocation;
        //private int waypointCount;

        //private List<string> idList;
        //private List<string> violatedIdList;
        public List<int> nC;

        public MainForm()
        {
            InitializeComponent();
            setConfigurationForMapTool(null);
            lbxMapFeatureLayer.SetSelected(0, true);
            setTokensForEndpoints();
            SetEnums();
        }

        public void CalcRoute()
        {
            dynMap.Layers.Remove(routingLayer);
            setFeatureLayerConfiguration();
            lbxTollSummary.Items.Clear();
            tbxRouteResultTime.Clear();
            tbxRouteResultDistance.Clear();
            tbxRouteResultViolations.Clear();

            List<xRouteWSService.InputWaypoint> wayPointList = new List<xRouteWSService.InputWaypoint>();
            xRouteWSService.InputWaypoint[] ipw = null;

            routeRequest = new xRouteWSService.RouteRequest
            {
                coordinateFormat = cbxCoordFormat.Text,//"EPSG:76131",
                storedProfile = cbxStoredProfile.Text,
            };
            var emissionOptionsSet = new xRouteWSService.EmissionValueScenario[] { };

            if (cbxEmissions.Checked == true)
            {
                emissionOptionsSet = new xRouteWSService.EmissionValueScenario[]
                    {
                    new xRouteWSService.EmissionValueScenario_HBEFA_3_2()
                    {
                        scenarios = new xRouteWSService.EmissionValueScenarioType_HBEFA_3_2[] {xRouteWSService.EmissionValueScenarioType_HBEFA_3_2.CURRENT_ROUTE}
                    }
                    };
            }
            else
            {
                emissionOptionsSet = null;
            }

            routeRequest.routeOptions = new xRouteWSService.RouteOptions()
            {
                emissionOptions = new xRouteWSService.EmissionOptions
                {
                    valueScenarios = emissionOptionsSet,
                }
            };

            string nCList = tbxNetworkClassPenalties.Text;
            List<int> nCs = nCList.Split(',').Select(int.Parse).ToList();

            routeRequest.requestProfile = new xRouteWSService.RequestProfile()
            {
                featureLayerProfile = new xRouteWSService.FeatureLayerProfile()
                {
                    themes = new xRouteWSService.Theme[]
                    {
                        truckAttributesTheme,
                        generalTruckRestrictionsTheme,
                        trafficIncidentsTheme,
                        speedPatternsTheme
                    },
                },
                routingProfile = new xRouteWSService.RoutingProfile()
                {
                    linking = new xRouteWSService.Linking()
                    {
                        maximumDistanceToSegmentSpecified = true,
                        maximumDistanceToSegment = double.Parse(tbxMaximumDistanceToSegment.Text),
                    },
                    course = new xRouteWSService.Course()
                    {
                        distanceTimeWeightingSpecified = true,
                        distanceTimeWeighting = double.Parse(tbxDistanceTimeWeighting.Text.Replace(".", ",")),

                        violations = new xRouteWSService.Violations()
                        {
                            enabledSpecified = true,
                            enabled = Boolean.Parse(tbxViolationsEnabled.Text),
                            costSpecified = true,
                            cost = int.Parse(tbxViolationsCost.Text)
                        },
                        specialAreas = new xRouteWSService.SpecialAreas()
                        {
                            residentsOnlyPenaltySpecified = true,
                            residentsOnlyPenalty = int.Parse(tbxResidentsOnlyPenalty.Text),
                            urbanPenaltySpecified = true,
                            urbanPenalty = int.Parse(tbxUrbanPenalty.Text),
                            minimumUrbanNetworkClassSpecified = true,
                            minimumUrbanNetworkClass = int.Parse(tbxMinimumUrbanNetworkClass.Text),
                            forbiddenLowEmissionZonePenaltySpecified = true,
                            forbiddenLowEmissionZonePenalty = int.Parse(tbxForbiddenLEZPenal.Text),
                            deliveryOnlyPenaltySpecified = true,
                            deliveryOnlyPenalty = int.Parse(tbxDeliveryOnlyPenalty.Text),
                            deliveryOnlyGateCostSpecified = true,
                            deliveryOnlyGateCost = int.Parse(tbxDeliveryOnlyGateCost.Text),
                        },
                        toll = new xRouteWSService.Toll()
                        {
                            tollPenaltySpecified = true,
                            tollPenalty = int.Parse(tbxTollPenalty.Text),
                        },
                        network = new xRouteWSService.Network()
                        {
                            rampPenaltySpecified = true,
                            rampPenalty = 10,
                            penaltiesByNetworkClass = new xRouteWSService.PenaltiesByNetworkClass()
                            {
                                penalties = nCs.ToArray()
                                //penalties = new int[8] { 2500, 2500, 2500, 2500, 15, 50, 100, 100 }
                            }
                        },
                    },
                },

                vehicleProfile = new xRouteWSService.VehicleProfile()
                {
                    engine = new xRouteWSService.Engine()
                    {
                        cylinderCapacitySpecified = true,
                        cylinderCapacity = int.Parse(textBoxCylinderCapacity.Text),
                        fuelTypeSpecified = true,
                        fuelType = (xRouteWSService.FuelType)System.Enum.Parse(typeof(xRouteWSService.FuelType), cbxFuelType.Text),
                        emissionTechnologySpecified = true,
                        emissionTechnology = (xRouteWSService.EmissionTechnology)System.Enum.Parse(typeof(xRouteWSService.EmissionTechnology), cbxEmissionTechnology.Text),
                        fuelConsumptionSpecified = true,
                        fuelConsumption = double.Parse(textBoxFuelConsumption.Text),
                        bioFuelRatioSpecified = true,
                        bioFuelRatio = double.Parse(textBoxBioFuelRatio.Text),
                        emissionStandardEUSpecified = true,
                        emissionStandardEU = (xRouteWSService.EmissionStandardEU)System.Enum.Parse(typeof(xRouteWSService.EmissionStandardEU), cbxEmissionStandardEU.Text),
                    },
                    weight = new xRouteWSService.Weight()
                    {
                        emptyWeightSpecified = true,
                        emptyWeight = double.Parse(tbxEmptyWeight.Text),
                        totalPermittedWeightSpecified = true,
                        totalPermittedWeight = double.Parse(tbxTotalPermWeight.Text),
                        loadWeightSpecified = true,
                        loadWeight = double.Parse(tbxLoadWeight.Text),
                    },
                    dimensions = new xRouteWSService.Dimensions()
                    {
                        heightSpecified = true,
                        height = double.Parse(tbxHeight.Text),
                        widthSpecified = true,
                        width = double.Parse(tbxWidth.Text),
                        lengthSpecified = true,
                        length = double.Parse(tbxLength.Text),
                    },
                    load = new xRouteWSService.Load()
                    {
                        loadTypeSpecified = true,
                        loadType = (xRouteWSService.LoadType)System.Enum.Parse(typeof(xRouteWSService.LoadType), cbxLoadType.Text),
                        hazardousGoodsTypes = cbxHazardousGoodsType.Text,
                        tunnelRestrictionCodeSpecified = true,
                        tunnelRestrictionCode = (xRouteWSService.TunnelRestrictionCode)System.Enum.Parse(typeof(xRouteWSService.TunnelRestrictionCode), cbxTunnelRestrictionCode.Text),
                    },
                    legalCondition = new xRouteWSService.LegalCondition()
                    {
                        isDeliverySpecified = true,
                        isDelivery = cbxIsDelivery.Checked,
                        isEmergencySpecified = true,
                        isEmergency = cbxIsEmergency.Checked,
                    }
                }
            };

            if (tbxStartX.Text != "")
            {
                //var bla = (xRouteWSService.InputWaypoint)System.Enum.Parse(typeof(xRouteWSService.InputWaypoint), cbxWptTypeDest.Text);
                var wptStart = new xRouteWSService.OffRoadWaypoint()
                {
                    name = "Start",
                    location = new xRouteWSService.OffRoadRouteLocation()
                    {
                        offRoadCoordinate = new xRouteWSService.Coordinate()
                        {
                            x = double.Parse(tbxStartX.Text.Replace(".", ",")),
                            y = double.Parse(tbxStartY.Text.Replace(".", ","))
                        }
                    }
                };
                wayPointList.Add(wptStart);

                if (cbxManipulateWpt.Checked == true)
                {
                    var wptVia = new xRouteWSService.ManipulateRouteWaypoint()
                    {
                        name = "Via",
                        radiusSpecified = true,
                        radius = double.Parse(tbxRadiusValue.Text),
                        coordinate = new xRouteWSService.Coordinate()
                        {
                            x = double.Parse(tbxViaX.Text.Replace(".", ",")),
                            y = double.Parse(tbxViaY.Text.Replace(".", ","))
                        }
                    };
                    wayPointList.Add(wptVia);
                }

                var wptDest = new xRouteWSService.OffRoadWaypoint()
                {
                    name = "Destination",
                    location = new xRouteWSService.OffRoadRouteLocation()
                    {
                        offRoadCoordinate = new xRouteWSService.Coordinate()
                        {
                            x = double.Parse(tbxDestX.Text.Replace(".", ",")),
                            y = double.Parse(tbxDestY.Text.Replace(".", ","))
                        }
                    }
                };

                wayPointList.Add(wptDest);
            }
            else
            {
                MessageBox.Show("Not enough waypoints!");
                return;
            }

            ipw = wayPointList.ToArray();
            routeRequest.waypoints = ipw; //verwijs hier naar een array van het type inputwaypoint

            routeRequest.resultFields = new xRouteWSService.ResultFields()
            {
                legs = new xRouteWSService.LegResultFields()
                {
                    enabledSpecified = true,
                    enabled = cbxLegs.Checked,
                },
                segments = new xRouteWSService.SegmentResultFields()
                {
                    enabledSpecified = true,
                    enabled = cbxSegments.Checked,
                    //polylineSpecified = true,
                    //polyline = true,
                    descriptorsSpecified = true,
                    descriptors = cbxDescriptors.Checked,
                    //emissionsSpecified = true,
                    //emissions = true,
                    roadAttributesSpecified = true,
                    roadAttributes = cbxRoadAttributes.Checked,
                    //featureThemeIds = new
                },
                polyline = cbxPolyline.Checked,
                polylineSpecified = true,

                toll = new xRouteWSService.TollResultFields()
                {
                    enabledSpecified = true,
                    enabled = cbxTollCalculation.Checked,
                    sectionsSpecified = true,
                    sections = cbxTollSections.Checked,
                    systemsSpecified = true,
                    systems = cbxTollSystems.Checked,
                },
                emissionsSpecified = true,
                emissions = cbxEmissions.Checked,
            };

            try
            {
                routeResponse = xRouteClient.calculateRoute(routeRequest);
            }
            catch (System.Web.Services.Protocols.SoapException soapException)
            {
                System.Windows.Forms.MessageBox.Show(soapException.Detail.InnerXml.Replace(">", ">\r\n"));
                return;
            }
            catch (System.ServiceModel.FaultException faultException)
            {
                System.Windows.Forms.MessageBox.Show("Error when trying to calculate the route" + "\r\n" + faultException.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            tbxRouteResultTime.Text = Math.Round((routeResponse.travelTime / 3600.0), 2).ToString();
            tbxRouteResultDistance.Text = Math.Round((routeResponse.distance / 1000.0), 2).ToString();
            tbxRouteResultViolations.Text = routeResponse.violated.ToString();
            if (routeResponse.toll.summary != null)
            {
                foreach (xRouteWSService.Cost cost in routeResponse.toll.summary.costs)
                {
                    lbxTollSummary.Items.Add(cost.currency + " - " + cost.amount);
                }
            }
            
            if (cbxSegments.Checked == true)
            {             
                dataGridRouteSegments.AutoResizeColumns();
                dataGridRouteSegments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                foreach (var item in routeResponse.segments)
                {
                    segmentBindingSource.Add(item);
                }
            }
            //EXPERIMENTAL UNTIL EMISSIONS WORKS
            /*/if (cbxEmissions.Checked == true)
            {
                DataTable transposedTable = GenerateTransposedTable(ToDataTable<xRouteWSService.EmissionValues_HBEFA_3_2>(routeResponse.emissions.values.Select(e => e as xRouteWSService.EmissionValues_HBEFA_3_2).ToList()));

                dataGridViewEmissions.DataSource = GenerateTransposedTable(ToDataTable<xRouteWSService.EmissionValues_HBEFA_3_2>(routeResponse.emissions.values.Select(e => e as xRouteWSService.EmissionValues_HBEFA_3_2).ToList())) as DataTable;
            }/*/


            ShowRouteInDynMap();
        }

        /*/public void CalcDima(RootObject daveRequestJson)
        {
            List<xDimaWSService.RouteLocation> dimaWayPointList = new List<xDimaWSService.RouteLocation>();
            xDimaWSService.RouteLocation[] dipw = null;

            var violatedLocationsList = new List<xDimaWSService.OnRoadRouteLocation>();
            violatedIdList = new List<string>();
            idList = new List<string>();

            var drr = new xDimaWSService.CreateAndGetDistanceMatrixRequest
            {
                coordinateFormat = "EPSG:4326",
                storedProfile = cbxStoredProfile.Text
            };

            var dimaTaTheme = new xDimaWSService.Theme
            {
                id = "PTV_TruckAttributes",
                enabledSpecified = true
            };

            dimaTaTheme.enabled = false;

            if (cbxFLTruckAttributes.Checked == true)
            {
                dimaTaTheme.enabled = true;
            }

            drr.requestProfile = new xDimaWSService.RequestProfile()
            {
                featureLayerProfile = new xDimaWSService.FeatureLayerProfile()
                {
                    themes = new xDimaWSService.Theme[]
                    {
                        dimaTaTheme
                    },
                },
            };

            if (daveRequestJson.stops.Count >= 2)
            {
                foreach (var stop in daveRequestJson.stops)
                {
                    var wpt = new xDimaWSService.OnRoadRouteLocation()
                    {
                        coordinate = new xDimaWSService.Coordinate()
                        {
                            x = stop.coordinate.locationX,
                            y = stop.coordinate.locationY
                        }
                    };
                    dimaWayPointList.Add(wpt);
                }
            }
            else
            {
                MessageBox.Show("Not enough waypoints!");
                return;
            }

            foreach (var scemId in daveRequestJson.stops)
            {
                idList.Add(scemId.scemid.ToString());
            }

            dipw = dimaWayPointList.ToArray();
            drr.startLocations = dipw;
            var locationsList = dipw.OfType<xDimaWSService.OnRoadRouteLocation>().ToList();
            drr.resultFields = new xDimaWSService.DistanceMatrixContentsResultFields()
            {
                distances = true,
                distancesSpecified = true,
                violated = true,
                violatedSpecified = true,
                estimatedByDirectDistance = true,
                estimatedByDirectDistanceSpecified = true
            };

            try
            {
                dimaResponse = xDimaClient.createDistanceMatrix(drr);
            }
            catch (System.Web.Services.Protocols.SoapException soapException)
            {
                System.Windows.Forms.MessageBox.Show(soapException.Detail.InnerXml.Replace(">", ">\r\n"));
                return;
            }
            catch (System.ServiceModel.FaultException faultException)
            {
                System.Windows.Forms.MessageBox.Show("Error when trying to calculate the dima" + "\r\n" + faultException.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            waypointCount = dimaResponse.summary.numberOfStartLocations;
            distanceMatrixResponseContents = dimaResponse.contents as xDimaWSService.DistanceMatrixContentsArrays;

            for (int i = 0; i < dimaResponse.summary.numberOfStartLocations; i++)
            {
                var numberOfViolations = 0;
                for (int j = 0; j < dimaResponse.summary.numberOfStartLocations; j++)
                {
                    if (distanceMatrixResponseContents.violated[i * dimaResponse.summary.numberOfStartLocations + j])
                    {
                        numberOfViolations++;
                    }
                }
                if (numberOfViolations >= waypointCount - 1)
                {
                    violatedLocationsList.Add(locationsList[i]);
                }
            }

            ShowDimaInDynMap(idList, locationsList, violatedLocationsList);
            waypointCount = 0;
        }
        /*/

        public void ShowRouteInDynMap()
        {
            var mapCoordFormat = "";
            if (cbxCoordFormat.Text == "EPSG:76131")
            {
                routingLayer = new ShapeLayer("Route") { SpatialReferenceId = "PTV_MERCATOR" };
                mapCoordFormat = "PTV_MERCATOR";
            }
            else if (cbxCoordFormat.Text == "EPSG:4326")
            {
                routingLayer = new ShapeLayer("Route") { SpatialReferenceId = "EPSG:4326" };
                mapCoordFormat = "EPSG:4326";
            }
            else if (cbxCoordFormat.Text == "EPSG:3857")
            {
                routingLayer = new ShapeLayer("Route") { SpatialReferenceId = "EPSG:3857" };
                mapCoordFormat = "EPSG:3857";
            }

            if (routeResponse.polyline != null)
            {
                var routePoly = routeResponse.polyline.plain as xRouteWSService.Polyline;

                var points = new PointCollection();

                foreach (xRouteWSService.Coordinate p in routePoly.polyline)
                    points.Add(new System.Windows.Point(p.x, p.y));

                MapPolyline mapPolyLine = new MapPolyline()
                {
                    Points = points,
                    Stroke = new SolidColorBrush(Colors.Blue),
                    MapStrokeThickness = 10,
                    Opacity = 1.0,
                    ScaleFactor = 0.2
                };

                (routingLayer as ShapeLayer).Shapes.Add(mapPolyLine);
                mapPolyLine.ToolTip = string.Format("{0:0,0.0}km\n{1}", Math.Round(routeResponse.distance / 1000.0, 2), TimeSpan.FromSeconds(routeResponse.travelTime));
            }
            else
            {
                MessageBox.Show("Error while calculating route");
                return;
            }

            var markerStart = new Ptv.XServer.Controls.Map.Symbols.Ball
            {
                Color = Colors.Green
            };
            var markerVia = new Ptv.XServer.Controls.Map.Symbols.Ball
            {
                Color = Colors.Yellow
            };
            var markerDest = new Ptv.XServer.Controls.Map.Symbols.Ball
            {
                Color = Colors.Red
            };
            mapCoordStart = new System.Windows.Point(double.Parse(tbxStartX.Text.Replace(".", ",")), double.Parse(tbxStartY.Text.Replace(".", ",")));
            mapCoordDest = new System.Windows.Point(double.Parse(tbxDestX.Text.Replace(".", ",")), double.Parse(tbxDestY.Text.Replace(".", ",")));
            ShapeCanvas.SetLocation(markerStart, mapCoordStart);
            ShapeCanvas.SetLocation(markerDest, mapCoordDest);
            markerStart.Width = markerStart.Height = markerDest.Height = markerDest.Width = markerVia.Height = markerVia.Width = 10;
            markerStart.ToolTip = "Start";
            markerDest.ToolTip = "Destination";

            if (cbxManipulateWpt.Checked == true)
            {
                mapCoordVia = new System.Windows.Point(double.Parse(tbxViaX.Text.Replace(".", ",")), double.Parse(tbxViaY.Text.Replace(".", ",")));
                ShapeCanvas.SetLocation(markerVia, mapCoordVia);
                markerVia.ToolTip = "Via";
                routingLayer.Shapes.Add(markerVia);
            }

            routingLayer.Shapes.Add(markerStart);
            routingLayer.Shapes.Add(markerDest);

            dynMap.Layers.Add(routingLayer);

            //zoom to contain route
            MapRectangle mergedRoutesRectangle = new MapRectangle();
            var polyLine = routeResponse.polyline.plain as xRouteWSService.Polyline;

            var winPoints = from coord in polyLine.polyline
                            select new System.Windows.Point(coord.x, coord.y);

            mergedRoutesRectangle |= new MapRectangle(winPoints);

            dynMap.SetEnvelope(mergedRoutesRectangle.Inflate(1.2), mapCoordFormat);

            routingLayer.Refresh();
        }

        public void setFeatureLayerConfiguration()
        {
            truckAttributesTheme = new xRouteWSService.Theme
            {
                id = "PTV_TruckAttributes",
                enabledSpecified = true,
                enabled = cbxFLTruckAttributes.Checked
            };
            generalTruckRestrictionsTheme = new xRouteWSService.Theme
            {
                id = "PTV_GeneralTruckRestrictions",
                enabledSpecified = true,
                enabled = cbxFLGenTruckRestr.Checked
            };
            trafficIncidentsTheme = new xRouteWSService.Theme
            {
                id = "PTV_TrafficIncidents",
                enabledSpecified = true,
                enabled = cbxFLTrafficIncidents.Checked
            };
            speedPatternsTheme = new xRouteWSService.Theme
            {
                id = "PTV_SpeedPatterns",
                enabledSpecified = true,
                enabled = cbxFLSpeedPatterns.Checked
            };
        }

        public void setTokensForEndpoints()
        {
            var routeBinding = new BasicHttpBinding { MaxReceivedMessageSize = 2147483647 };
            routeBinding.Security.Mode = BasicHttpSecurityMode.Transport;
            routeBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
            xRouteClient.Endpoint.Binding = routeBinding;

            xRouteClient.ClientCredentials.UserName.UserName = "xtok";
            xRouteClient.ClientCredentials.UserName.Password = "282b6346-451d-4ad5-bee9-3c3b7710b0ff";
            /*/
            var dimaBinding = new BasicHttpBinding { MaxReceivedMessageSize = 2147483647 };
            dimaBinding.Security.Mode = BasicHttpSecurityMode.Transport;
            dimaBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
            xDimaClient.Endpoint.Binding = dimaBinding;

            xDimaClient.ClientCredentials.UserName.UserName = "xtok";
            xDimaClient.ClientCredentials.UserName.Password = "282b6346-451d-4ad5-bee9-3c3b7710b0ff";

            var locateBinding = new BasicHttpBinding { MaxReceivedMessageSize = 2147483647 };
            locateBinding.Security.Mode = BasicHttpSecurityMode.Transport;
            locateBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
            xLocateClient.Endpoint.Binding = locateBinding;

            var tourBinding = new BasicHttpBinding { MaxReceivedMessageSize = 2147483647 };
            tourBinding.Security.Mode = BasicHttpSecurityMode.Transport;
            tourBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
            xTourClient.Endpoint.Binding = tourBinding;
            xLocateClient.ClientCredentials.UserName.UserName = "xtok";
            xLocateClient.ClientCredentials.UserName.Password = "282b6346-451d-4ad5-bee9-3c3b7710b0ff";

            xTourClient.ClientCredentials.UserName.UserName = "xtok";
            xTourClient.ClientCredentials.UserName.Password = "282b6346-451d-4ad5-bee9-3c3b7710b0ff";

            xRuntimeClient.ClientCredentials.UserName.UserName = "xtok";
            xRuntimeClient.ClientCredentials.UserName.Password = "282b6346-451d-4ad5-bee9-3c3b7710b0ff";
            /*/
        }

        public void setConfigurationForMapTool(string flLayer)
        {
            if (flLayer == null)
            {
                dynMap.Layers.Add(new Ptv.XServer.Controls.Map.Layers.Tiled.TiledLayer("Background")
                {
                    TiledProvider = new Ptv.XServer.Controls.Map.TileProviders.RemoteTiledProvider
                    {
                        MinZoom = 0,
                        MaxZoom = 22,
                        RequestBuilderDelegate = (x, y, z) =>
                        //string.Format("http://localhost:50000/services/rest/XMap/tile/{0}/{1}/{2}/{3}", z, x, y, "silkysand"),
                        //https://s03-xserver2-europe-test.cloud.ptvgroup.com/services/rest/XMap/tile/5/16/10?storedProfile=gravelpit&xtok=282b6346-451d-4ad5-bee9-3c3b7710b0ff
                        string.Format("https://s0{0}-xserver2-europe-test.cloud.ptvgroup.com/services/rest/XMap/tile/{1}/{2}/{3}?storedProfile={6}&layers=labels,transport,background,{5}&xtok={4}&timeConsideration=SNAPSHOT&referenceTime={7}&showOnlyRelevantByTime=false", "1234"[(x ^ y) % 4], z, x, y, "282b6346-451d-4ad5-bee9-3c3b7710b0ff", "PTV_TruckAttributes", "silkysand", (System.DateTime.Now.ToString("o")).Substring(0, 19)),
                    },
                    IsBaseMapLayer = true, // set to the basemap category -> cannot be moved on top of overlays
                    Icon = Ptv.XServer.Controls.Map.Tools.ResourceHelper.LoadBitmapFromResource("Ptv.XServer.Controls.Map;component/Resources/Background.png"),
                    Caption = Ptv.XServer.Controls.Map.Localization.MapLocalizer.GetString(Ptv.XServer.Controls.Map.Localization.MapStringId.Background),
                    Copyright = "PTV, HERE"
                });

                dynMap.ZoomLevel = 9;
                dynMap.Center = new System.Windows.Point() { X = 4.89064, Y = 52.37317 };
            }
            else
            {
                var mapProfile = cbxMapProfile.Text;
                dynMap.Layers.RemoveAt(0);
                dynMap.Layers.Add(new Ptv.XServer.Controls.Map.Layers.Tiled.TiledLayer("Background")
                {
                    TiledProvider = new Ptv.XServer.Controls.Map.TileProviders.RemoteTiledProvider
                    {
                        MinZoom = 0,
                        MaxZoom = 22,
                        RequestBuilderDelegate = (x, y, z) =>
                        string.Format("https://s0{0}-xserver2-europe-test.cloud.ptvgroup.com/services/rest/XMap/tile/{1}/{2}/{3}?storedProfile={6}&layers=labels,transport,background,{5}&xtok={4}&timeConsideration=SNAPSHOT&referenceTime={7}&showOnlyRelevantByTime=false", "1234"[(x ^ y) % 4], z, x, y, "282b6346-451d-4ad5-bee9-3c3b7710b0ff", flLayer, mapProfile, (System.DateTime.Now.ToString("o")).Substring(0, 19)),
                    },
                    IsBaseMapLayer = true, // set to the basemap category -> cannot be moved on top of overlays
                    Icon = Ptv.XServer.Controls.Map.Tools.ResourceHelper.LoadBitmapFromResource("Ptv.XServer.Controls.Map;component/Resources/Background.png"),
                    Caption = Ptv.XServer.Controls.Map.Localization.MapLocalizer.GetString(Ptv.XServer.Controls.Map.Localization.MapStringId.Background),
                    Copyright = "PTV, HERE"
                });
                //dynMap.Refresh();
            }
        }

        private void SetEnums()
        {
            foreach (xRouteWSService.FuelType ft in System.Enum.GetValues(typeof(xRouteWSService.FuelType)))
            {
                cbxFuelType.Items.Add(ft.ToString());
            }
            foreach (xRouteWSService.EmissionTechnology et in System.Enum.GetValues(typeof(xRouteWSService.EmissionTechnology)))
            {
                cbxEmissionTechnology.Items.Add(et.ToString());
            }
            foreach (xRouteWSService.EmissionStandardEU esEU in System.Enum.GetValues(typeof(xRouteWSService.EmissionStandardEU)))
            {
                cbxEmissionStandardEU.Items.Add(esEU.ToString());
            }
            foreach (xRouteWSService.LoadType loadType in System.Enum.GetValues(typeof(xRouteWSService.FuelType)))
            {
                cbxLoadType.Items.Add(loadType.ToString());
            }
            foreach (xRouteWSService.TunnelRestrictionCode tunnelCode in System.Enum.GetValues(typeof(xRouteWSService.TunnelRestrictionCode)))
            {
                cbxTunnelRestrictionCode.Items.Add(tunnelCode.ToString());
            }
        }

        public void ShowDimaInDynMap(dynamic idList, dynamic locationsList, dynamic violatedLocationsList)
        {
            var dimaPointsLayer = new List<System.Windows.Point>();
            reachablePointsLayer = new ShapeLayer("Reachable") { SpatialReferenceId = "EPSG:4326" };
            int i = 0;
            foreach (var reachWaypoint in locationsList)
            {
                i++;
                System.Windows.Point reachableDimaPoint;
                var markerBlue = new Ptv.XServer.Controls.Map.Symbols.Ball
                {
                    Color = System.Windows.Media.Colors.Blue
                };
                reachableDimaPoint = new System.Windows.Point(reachWaypoint.coordinate.x, reachWaypoint.coordinate.y);
                ShapeCanvas.SetLocation(markerBlue, reachableDimaPoint);
                markerBlue.Width = markerBlue.Height = 20;
                markerBlue.ToolTip = i + " - " + idList[i - 1];

                reachablePointsLayer.Shapes.Add(markerBlue);
                reachablePointsLayer.Refresh();
                dimaPointsLayer.Add(reachableDimaPoint);
            }

            violatedPointsLayer = new ShapeLayer("Violated") { SpatialReferenceId = "EPSG:4326" };
            int j = 0;
            foreach (var reachWaypoint in violatedLocationsList)
            {
                j++;
                System.Windows.Point reachableDimaPoint;
                var markerBlue = new Ptv.XServer.Controls.Map.Symbols.Ball
                {
                    Color = System.Windows.Media.Colors.Red
                };
                reachableDimaPoint = new System.Windows.Point(reachWaypoint.coordinate.x, reachWaypoint.coordinate.y);
                ShapeCanvas.SetLocation(markerBlue, reachableDimaPoint);
                markerBlue.Width = markerBlue.Height = 13;
                //markerBlue.ToolTip = i + " - " + idList[i - 1];

                reachablePointsLayer.Shapes.Add(markerBlue);
                reachablePointsLayer.Refresh();
                dimaPointsLayer.Add(reachableDimaPoint);
            }

            dynMap.Layers.Add(reachablePointsLayer);
            dynMap.Layers.Add(violatedPointsLayer);
            reachablePointsLayer.Refresh();
            violatedPointsLayer.Refresh();
            dynMap.SetEnvelope(new Ptv.XServer.Controls.Map.MapRectangle(dimaPointsLayer).Inflate(1.1, 1.1), "EPSG:4326");
            dynMap.Focus();
        }

        private void btnCalcRoute_Click(object sender, EventArgs e)
        {
            CalcRoute();
            dynMap.Focus();
        }

        private void btnRender_Click(object sender, EventArgs e)
        {
            string featureLayer = lbxMapFeatureLayer.GetItemText(lbxMapFeatureLayer.SelectedItem);
            setConfigurationForMapTool(featureLayer);
        }

        private void btnCalcDima_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse JSON Request files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "json",
                Filter = "JSON files (*.json)|*.json",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            //try
            //{
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileLocation = openFileDialog1.FileName;
            }

            var daveRequestJson = JsonConvert.DeserializeObject<RootObject>(System.IO.File.ReadAllText(fileLocation));

            //CalcDima(daveRequestJson);
            //}
            //catch
            //{
            //    MessageBox.Show("DAVE Request file not present.");
            //    return;
            //}
        }

        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Defining type of data column gives proper data table
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        private DataTable GenerateTransposedTable(DataTable inputTable)
        {
            DataTable outputTable = new DataTable();

            // Add columns by looping rows

            // Header row's first column is same as in inputTable
            outputTable.Columns.Add(inputTable.Columns[0].ColumnName.ToString());

            // Header row's second column onwards, 'inputTable's first column taken
            foreach (DataRow inRow in inputTable.Rows)
            {
                string newColName = inRow[0].ToString();
                outputTable.Columns.Add(newColName);
            }

            // Add rows by looping columns
            for (int rCount = 1; rCount <= inputTable.Columns.Count - 1; rCount++)
            {
                DataRow newRow = outputTable.NewRow();

                // First column is inputTable's Header row's second column
                newRow[0] = inputTable.Columns[rCount].ColumnName.ToString();
                for (int cCount = 0; cCount <= inputTable.Rows.Count - 1; cCount++)
                {
                    string colValue = inputTable.Rows[cCount][rCount].ToString();
                    newRow[cCount + 1] = colValue;
                }
                outputTable.Rows.Add(newRow);
            }

            return outputTable;
        }

        private void tbxStartX_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbxStartX.Text = "4,90502";
        }

        private void tbxStartY_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbxStartY.Text = "52,41852";
        }

        private void tbxDestX_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbxDestX.Text = "5,92989";
        }

        private void tbxDestY_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbxDestY.Text = "43,12542";
        }

        private void btnClearCoordinates_Click(object sender, EventArgs e)
        {
            tbxStartX.Clear();
            tbxStartY.Clear();
            tbxDestX.Clear();
            tbxDestY.Clear();
        }

        private void tbxViaX_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbxViaX.Text = "8,40847";
            tbxViaY.Text = "49,01095";
        }

        private void btnSwitchStartDest_Click(object sender, EventArgs e)
        {
            var startX = tbxStartX.Text;
            var startY = tbxStartY.Text;
            var destX = tbxDestX.Text;
            var destY = tbxDestY.Text;
            tbxStartX.Text = destX;
            tbxStartY.Text = destY;
            tbxDestX.Text = startX;
            tbxDestY.Text = startY;
        }

        public class Coordinate
        {
            public double locationX { get; set; }
            public double locationY { get; set; }
        }

        public class Stop
        {
            public Coordinate coordinate { get; set; }
            public DateTime earliestArrivalTime { get; set; }
            public DateTime latestDepartureTime { get; set; }
            public int serviceTimeAtStop { get; set; }
            public bool useServicePeriodForRecreation { get; set; }
            public int weightWhenLeavingStop { get; set; }
            public int stopPositionInTour { get; set; }
            public string scemid { get; set; }
            public string source { get; set; }
        }

        public class Vehicle
        {
            public string vehicleProfileID { get; set; }
        }

        public class RootObject
        {
            public List<Stop> stops { get; set; }
            public Vehicle vehicle { get; set; }
            public string scemid { get; set; }
            public string source { get; set; }
        }


    }
}