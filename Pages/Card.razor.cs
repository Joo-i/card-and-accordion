using Microsoft.AspNetCore.Components;

namespace bootstrapwetry.Pages
{
    public partial class Card
    {
        const string cardName = "cardDivName";

        [Parameter] public string firstText { get; set; } = "The Chasm";

        [Parameter] public string header { get; set; } = "THE ABYSS WAS HERE!";
        [Parameter] public string imageUrl { get; set; } = "Screenshot (132).png";
        [Parameter] public string title { get; set; } = "Scara In The Chasm!!";
        [Parameter] public string subtitle { get; set; } = "found a wired script!";
        [Parameter] public string description { get; set; } = "left by the abyss";

        [Parameter] public string sectionOne { get; set; } = "WE GO FOR ONE.";
        [Parameter] public string sectionOneTxt { get; set; } = "blessed one one.";
        [Parameter] public string sectionTwo { get; set; } = "WE GO FOR TWO.";
        [Parameter] public string sectionTwoTxt { get; set; } = "blessed one two.";

        [Parameter] public string buttonOne { get; set; } = "Counter";
        [Parameter] public string buttonOneLink { get; set; } = "/counter";
        [Parameter] public string buttonTwo { get; set; } = "Weather";
        [Parameter] public string buttonTwoLink { get; set; } = "/weather";


    }
}