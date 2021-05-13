using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Business_Logic_Layer
{
    public enum serviceLevel
    {
        bronze,
        silver,
        premium
    }

    public enum clientSearchParameter
    {
        email,
        address,
        phone,
        contractID
    }

    public class ClientBusinessLogic
    {
        DBAccess db = new DBAccess();

        private List<Client> clients = new List<Client>();
        

        void deleteClient(string id)
        {
            try
            {
                db.DeleteClient(id: id);
            }
            catch (Exception e)
            {
                MessageBox.Show("ClientBusinessLogic : deleteClient ERROR:" + e.Message);
                throw;
            }
        }

        public List<Client> searchClientByParameter(clientSearchParameter parameter,string query, serviceLevel serviceLevel)
        {
            try
            {
                DataTable clientData = new DataTable();

                switch (parameter)
                {
                    case clientSearchParameter.email:
                        clientData = db.GetClientByEmail(email: query);
                        break;
                    case clientSearchParameter.address:
                        clientData = db.GetClientByAddress(address: query);
                        break;
                    case clientSearchParameter.phone:
                        clientData = db.GetClientByContactNumber(number: query);
                        break;
                    case clientSearchParameter.contractID:
                        clientData = db.GetClientByContractID(id: query);
                        break;
                    default:
                        break;
                }

                if (clientData != null || clientData.IsInitialized)
                {
                    for (int i = 0; i < clientData.Rows.Count; i++)
                    {
                        switch (serviceLevel)
                        {
                            case serviceLevel.bronze:
                                clients.Add(new Bronze(data: clientData, i: i));
                                break;
                            case serviceLevel.silver:
                                clients.Add(new Silver(data: clientData, i: i));
                                break;
                            case serviceLevel.premium:
                                clients.Add(new Premium(data: clientData, i: i));
                                break;
                            default:
                                break;
                        }

                    }
                    return clients;
                }
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show("ClientBusinessLogic : searchClientByParameter ERROR:" + e.Message);
                throw;
            }
        }

        public void updateClient(Client client)
        {
            try
            {
                db.UpdateClient(client: client);
            }
            catch (Exception e)
            {
                MessageBox.Show("ClientBusinessLogic : updateClient ERROR:" + e.Message);
                throw;
            }
        }

        public void createClient(Client client)
        {
            try
            {
                db.CreateClient(client);
            }
            catch (Exception e)
            {
                MessageBox.Show("ClientBusinessLogic : createClient ERROR:" + e.Message);
                throw;
            }
        }
    }
}
