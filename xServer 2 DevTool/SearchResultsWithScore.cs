using System.Windows.Forms;

namespace xS2Development
{
    public partial class SearchResultsWithScore : Form
    {
        /*/public SearchResultsWithScore(int index, xLocateWSService.LocationsResponse locateResponse)
        {
            InitializeComponent();

            dataGridViewFieldScores.Rows[0].Cells[0].Value = locateResponse.results[index].matchQuality.addressScores.country;
            dataGridViewFieldScores.Rows[0].Cells[1].Value = locateResponse.results[index].matchQuality.addressScores.state;
            dataGridViewFieldScores.Rows[0].Cells[2].Value = locateResponse.results[index].matchQuality.addressScores.postalCode;
            dataGridViewFieldScores.Rows[0].Cells[3].Value = locateResponse.results[index].matchQuality.addressScores.city;
            dataGridViewFieldScores.Rows[0].Cells[4].Value = locateResponse.results[index].matchQuality.addressScores.street;
            dataGridViewFieldScores.Rows[0].Cells[5].Value = locateResponse.results[index].matchQuality.addressScores.houseNumber;
        }/*/
    }
}