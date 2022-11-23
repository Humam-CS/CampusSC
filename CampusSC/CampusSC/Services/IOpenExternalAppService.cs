using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CampusSC.Services
{
    public interface IOpenExternalAppService
    {
        Task<bool> LaunchApp(string uri);
    }
}
