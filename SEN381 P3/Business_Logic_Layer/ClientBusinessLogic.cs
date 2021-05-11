using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Business_Logic_Layer
{
    enum serviceLevel
    {
        bronze,
        silver,
        premium
    }

    enum clientSearchParameter
    {
        id,
        email,
        address,
        phone,
        contractID
    }

    class ClientBusinessLogic
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

        List<Client> searchClientByParameter(clientSearchParameter parameter,string query, serviceLevel serviceLevel)
        {
            try
            {
                DataTable clientData = new DataTable();

                switch (parameter)
                {
                    case clientSearchParameter.id:
                        clientData = db.GetClientByID(id: query);
                        break;
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

                if (clientData != null || clientData!.IsInitialized)
                {
                    if (serviceLevel.Equals(serviceLevel.bronze))
                    {
                        for (int i = 0; i < clientData.Rows.Count; i++)
                        {
                            clients.Add(new Bronze(data: clientData, i: i));
                        }
                        return clients;
                    }
                    else if (serviceLevel.Equals(serviceLevel.silver))
                    {
                        for (int i = 0; i < clientData.Rows.Count; i++)
                        {
                            clients.Add(new Silver(data: clientData, i: i));
                        }
                        return clients;
                    }
                    else
                    {
                        for (int i = 0; i < clientData.Rows.Count; i++)
                        {
                            clients.Add(new Premium(data: clientData, i: i));
                        }
                        return clients;
                    }
                }
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show("ClientBusinessLogic : searchClientByParameter ERROR:" + e.Message);
                throw;
            }
        }

        void updateClient(Client client)
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

        void createClient(Client client)
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
