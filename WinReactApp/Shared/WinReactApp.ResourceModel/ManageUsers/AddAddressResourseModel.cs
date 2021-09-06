﻿//-----------------------------------------------------------------------
// <copyright file="AddAddressResourseModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// <author>Keerthi</author>
//-----------------------------------------------------------------------
namespace WinReactApp.ResourceModel.ManageUsers
{
    using System.ComponentModel.DataAnnotations;

    public class AddAddressResourseModel
    {
        public long UserId { get; set; }

        public int AddressTypeId { get; set; }

        public int CountryId { get; set; }

        public string AddressName { get; set; }

        public string MobileNumber { get; set; }

        public string Pincode { get; set; }

        public string HouseNumber { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string Landmark { get; set; }

        public string TownOrCityName { get; set; }

        public string StateName { get; set; }
    }
}