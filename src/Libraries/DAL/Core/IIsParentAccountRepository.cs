// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IIsParentAccountRepository
    {

        long Parent { get; set; }
        long Child { get; set; }

        /// <summary>
        /// Prepares and executes IIsParentAccountRepository.
        /// </summary>
        bool Execute();
    }
}