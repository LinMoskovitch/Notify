﻿using System.Collections.ObjectModel;

namespace Notify.Models
{
    public class RaceEventResultsModel
    {
        public ObservableCollection<RaceResultModel> RaceResults { get; set; }
        public ObservableCollection<QualifyingResultModel> QualifyingResults { get; set; }
        public ObservableCollection<RaceResultModel> SprintResults { get; set; }
    }
}
