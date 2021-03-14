using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopWine_BLL.Infrastructure.Provider;
using ShopWine_Core.Context;
using ShopWine_Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWine_BLL.Infrastructure
{
    public static class BllConfiguration
    {
        public static void Configuration(IServiceCollection collection, string dbConnection)
        {
            collection.AddDbContext<ShopWineContext>(x => x.UseSqlServer(dbConnection));
            collection.AddIdentity<User, Role>()
                .AddEntityFrameworkStores<ShopWineContext>().AddDefaultTokenProviders()/*.AddTokenProvider<EmailConfirmationTokenProvider<User>>("emailconfirmation")*/;
        }
    }
}
