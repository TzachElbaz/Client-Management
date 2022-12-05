using System;
using System.Collections.Generic;
using System.Text;

namespace client_management
{
    interface IClient
    {
        public List<Client> getAllClients();
        public void addClient(Client c);
        public void updateData(string selectedClient, int indexToUpdate, string newValue);
        public void deleteClient(string phoneNumber);
    }
}
