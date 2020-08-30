using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Serenity.Data;
namespace BaseServer
{
    public class ChatHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            try
            {
                string ip = Context.Request.Environment["server.RemoteIpAddress"].ToString();
                var connection = SqlConnections.NewByKey("Default");
                connection.Query($"Insert into Chat (Ip,DateTime,Name,Msj) values('{ip}','{DateTime.Now.ToString("yyyyMMdd hh:mm:ss")}','{name}','{message}')");               

            }
            catch (Exception e) { 
            
            }
           
            Clients.All.broadcastMessage(name, message);
        }
    }
}