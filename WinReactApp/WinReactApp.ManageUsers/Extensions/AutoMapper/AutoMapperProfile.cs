﻿//-----------------------------------------------------------------------
// <copyright file="AutoMapperProfile.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// <author>Keerthi</author>
//-----------------------------------------------------------------------
namespace WinReactApp.ManageUsers.Extensions.AutoMapper
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Threading.Tasks;
    using global::AutoMapper;
    using WinReactApp.ManageUsers.Models;
    using WinReactApp.ManageUsers.ResourseModel;

    [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1126:PrefixCallsCorrectly", Justification = "Reviewed.")]
    [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1101:Prefix local calls with this", Justification = "Reviewed")]
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "Reviewed")]
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            AllowNullDestinationValues = true;

            #region Authentication

            CreateMap<RegisterUserResourseModel, User>().ReverseMap();

            #endregion Authentication

            #region Address

            CreateMap<AddAddressResourseModel, UserAddress>().ReverseMap();

            #endregion Address
        }
    }
}