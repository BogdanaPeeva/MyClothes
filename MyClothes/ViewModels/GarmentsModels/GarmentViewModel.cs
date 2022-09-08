using MyClothes.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClothes.ViewModels.GarmentsModels
{
    public class GarmentViewModel
    {
        public string GarmentId { get; set; }
        public string ImageUrl { get; set; }
        public string? CategoryName { get; set; }
        public string? SeasonName { get; set; }
        public string? ColourName { get; set; }

        public string Description { get => $"Category: {this.CategoryName ?? "none"} <br> Season: {this.SeasonName ?? "none"} <br> Colour: {this.ColourName ?? "none"}"; }



    }
}
