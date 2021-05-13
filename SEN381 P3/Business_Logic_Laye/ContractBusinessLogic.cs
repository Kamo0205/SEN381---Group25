using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Business_Logic_Layer
{
    public class ContractBusinessLogic
    {
        private DBAccess db = new DBAccess();

        public List<Contract> searchContractsByID(String id)
        {
            List<Contract> contracts = new List<Contract>();
            try
            {
                DataTable contractData = db.GetContractByID(id);

                if (contractData != null || contractData.IsInitialized)
                {
                    for (int i = 0; i < contractData.Rows.Count; i++)
                    {
                        contracts.Add(new Contract(data: contractData, i: i));
                    }
                    return contracts;
                }
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show("ContractBusinessLogic : searchContractsByID ERROR:" + e.Message);
                throw;
            }
        }

        public void deleteContract(string id)
        {
            try
            {
                db.DeleteContract(id);
            }
            catch (Exception e)
            {
                MessageBox.Show("ContractBusinessLogic : deleteContract ERROR:" + e.Message);
                throw;
            }
        }

        public void updateContract(Contract contract)
        {
            try
            {
                db.UpdateContract(contract: contract);
            }
            catch (Exception e)
            {
                MessageBox.Show("ContractBusinessLogic : updateContract ERROR:" + e.Message);
                throw;
            }
        }

        public void createContract(Contract contract)
        {
            try
            {
                db.CreateContract(contract: contract);
            }
            catch (Exception e)
            {
                MessageBox.Show("ContractBusinessLogic : createContract ERROR:" + e.Message);
                throw;
            }
        }
    }
}
