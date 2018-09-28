//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BoardGamesDirectory.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Game
    {
        public int GameId { get; set; }
        [Display(Name = "Name")]
        public string GameName { get; set; }
        [Display(Name = "Description")]
        public string GameDescription { get; set; }
        [Display(Name = "Year Published")]
        public Nullable<int> Published { get; set; }
        [Display(Name = "Maximum Players")]
        public Nullable<int> MaxPlayers { get; set; }
        [Display(Name = "Minimum Players")]
        public Nullable<int> MinPlayers { get; set; }
        [Display(Name = "Maximum Age")]
        public Nullable<int> MaxAge { get; set; }
        [Display(Name = "Minimum Age")]
        public Nullable<int> MinAge { get; set; }
        [Display(Name = "Official Website")]
        public string WebLink { get; set; }
        [Display(Name = "Cover Image")]
        public string CoverImg { get; set; }
        [Display(Name = "Gallery Image One")]
        public string GmplayImgOne { get; set; }
        [Display(Name = "Gallery Image Two")]
        public string GmplayImgTwo { get; set; }
        [Display(Name = "Gallery Image Three")]
        public string GmplayImgThree { get; set; }
        public int PublisherId { get; set; }
        public int CategoryId { get; set; }
        public int SpeedId { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Publisher Publisher { get; set; }
        public virtual Speed Speed { get; set; }
    }
}
