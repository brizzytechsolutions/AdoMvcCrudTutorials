﻿using System;
using System.Collections.Generic;

namespace AdoCrudTutorials.Models
{
    public partial class DimSalesTerritory
    {
        public DimSalesTerritory()
        {
            DimEmployee = new HashSet<DimEmployee>();
            DimGeography = new HashSet<DimGeography>();
            FactInternetSales = new HashSet<FactInternetSales>();
            FactResellerSales = new HashSet<FactResellerSales>();
        }

        public int SalesTerritoryKey { get; set; }
        public int? SalesTerritoryAlternateKey { get; set; }
        public string SalesTerritoryRegion { get; set; }
        public string SalesTerritoryCountry { get; set; }
        public string SalesTerritoryGroup { get; set; }
        public byte[] SalesTerritoryImage { get; set; }

        public virtual ICollection<DimEmployee> DimEmployee { get; set; }
        public virtual ICollection<DimGeography> DimGeography { get; set; }
        public virtual ICollection<FactInternetSales> FactInternetSales { get; set; }
        public virtual ICollection<FactResellerSales> FactResellerSales { get; set; }
    }
}
