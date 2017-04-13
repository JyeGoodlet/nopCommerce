﻿using Microsoft.AspNetCore.Http;

namespace Nop.Core
{
    /// <summary>
    /// Represents HTTP context
    /// </summary>
    public static class HttpContext
    {
        #region Fields

        private static IHttpContextAccessor _contextAccessor;

        #endregion

        #region Methods

        public static void Configure(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Get current HttpContext
        /// </summary>
        public static Microsoft.AspNetCore.Http.HttpContext Current => _contextAccessor.HttpContext;

        #endregion
    }
}
