using System;
using System.Collections.Generic;
using System.Text;

namespace BarelyGambling.Core.Models
{
    public class TournamentResourceParameters
    {
        const int maxPageSize = 20;
        public int PageNumber { get; set; } = 1;

        private int _pageSize= maxPageSize;
        public int PageSize
        {
            get { return _pageSize; }
            set {
                _pageSize = (value > maxPageSize) ? maxPageSize : value;
            }
        }

    }
}
