﻿namespace FearServer.Models.Params
{
    public class RegisterParams
    {
        public string Pseudo { get; set; }
        public string NormalizedPseudo => Pseudo?.Trim();
    }
}
