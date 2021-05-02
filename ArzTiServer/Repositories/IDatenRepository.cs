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
		Task<List<ErSenderezepteEmuster16>> GetMRezeptList();
		Task<List<ErSenderezepteEmuster16>> GetOffeneMRezeptList(String apoik, int MaxNum);

		Task<List<ErSenderezeptePrezept>> GetPRezeptList();
		Task<List<ErSenderezeptePrezept>> GetOffenePRezeptList(String apoik, int MaxNum);

		List<ErSenderezepteErezept> GetERezeptList();
		Task<List<ErSenderezepteErezept>> GetOffeneERezeptList(String apoik, int MaxNum);
		Task<List<ErSenderezepteErezept>> GetERezeptIdListByStatusAsync(string apoik, string zeitraum);
		Task<List<ErSenderezepteErezept>> GetERezeptIdListByTransferAsync(string apoik, string zeitraum);
		Task<ErSenderezepteErezept> DeleteERezeptIdAsync(string apoik, string rezid);
		Task<ErSenderezepteErezept> GetERezeptIdAsync(string apoik, string rezid);
		List<ErSenderezepteErezept> GetERezeptIdListAsync(string apoik, int? maxnum, string zeitraum);
		Task<ErSenderezepteErezept> DeleteERezeptUIdAsync(string ruid);
		Task<ErSenderezepteErezept> GetERezeptIdStatusAsync(string apoik, string rezid);
	}
}
