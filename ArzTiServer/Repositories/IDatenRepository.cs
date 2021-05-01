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
		IQueryable<ErSenderezepteEmuster16> GetMRezeptQueryable();
		List<ErSenderezepteEmuster16> GetMRezeptList();
		List<ErSenderezepteEmuster16> GetOffeneMRezeptList(String apoik, int MaxNum);

		IQueryable<ErSenderezeptePrezept> GetPRezeptQueryable();
		List<ErSenderezeptePrezept> GetPRezeptList();
		List<ErSenderezeptePrezept> GetOffenePRezeptList(String apoik, int MaxNum);

		IQueryable<ErSenderezepteErezept> GetERezeptQueryable();
		List<ErSenderezepteErezept> GetERezeptList();
		List<ErSenderezepteErezept> GetOffeneERezeptList(String apoik, int MaxNum);
	}
}
