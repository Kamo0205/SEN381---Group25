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

        List<Client> searchClientByEmail(string email, serviceLevel serviceLevel)
        {
            try
            {
                DataTable clientData = db.GetClientByEmail(email: email);

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
                MessageBox.Show("ClientBusinessLogic : searchClientByEmail ERROR:" + e.Message);
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
