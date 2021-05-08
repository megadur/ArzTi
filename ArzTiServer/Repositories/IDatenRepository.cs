using ArzTiServer.ArzTiService;
using ArzTiServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzTiServer.Repositories
{
	public interface IDatenRepository
	{
        Task<ErSenderezepteErezept> DeleteERezeptIdAsync(string apoik, string rezid);

        Task<ErSenderezepteErezept> DeleteERezeptUIdAsync(string ruid);

        Task<ErSenderezepteErezept> GetERezeptIdAsync(string apoik, string rezid);

        Task<List<ErSenderezepteErezept>> GetERezeptIdListAsync(string apoik, int? maxnum, string zeitraum);

        Task<List<ErSenderezepteErezept>> GetERezeptIdListByStatusAsync(string apoik, string zeitraum);

        Task<List<ErSenderezepteErezept>> GetERezeptIdListByTransferAsync(string apoik, string zeitraum);

        Task<ErSenderezepteErezept> GetERezeptIdStatusAsync(string apoik, string rezid);

        Task<List<ErSenderezepteErezept>> GetERezeptList();

        Task<List<ErSenderezepteErezept>> GetERezeptListOffen(String apoik, int MaxNum);

        Task<List<ErSenderezepteEmuster16>> GetMRezeptList();
        Task<List<ErSenderezepteEmuster16>> GetMRezeptListOffen(String apoik, int MaxNum);

		Task<List<ErSenderezeptePrezept>> GetPRezeptList();
		Task<List<ErSenderezeptePrezept>> GetPRezeptListOffen(String apoik, int MaxNum);
	}
}
