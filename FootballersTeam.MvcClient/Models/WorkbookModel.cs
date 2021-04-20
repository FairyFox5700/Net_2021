using System.Collections.Generic;

namespace FootballersTeam.MvcClient.Models
{
    public class WorkbookModel
    {
        public string SelectedFormat { get; set; }
        public IList<FootballerViewModel> Items { get; set; }
    }
}