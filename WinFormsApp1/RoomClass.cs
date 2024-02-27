//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace WinFormsApp1
//{
//    public class RoomClass
//    {
//        private server server;
//        private client creatorClient;
//        private client joinerClient;
//        private List<client> watcherClients;

//        private object roomLock = new object();
//        private bool isFull = false;

//        public RoomClass()
//        {
//            server = new server();
//            creatorClient = null; // Initially, no creator
//            joinerClient = null;  // Initially, no joiner
//            watcherClients = new List<client>();
//        }

//        public void StartRoom()
//        {
//            server.StartServer();
//        }

//        public bool ConnectCreator()
//        {
//            lock (roomLock)
//            {
//                if (creatorClient == null)
//                {
//                    creatorClient = new client();
//                    creatorClient.ConnectToServer();
//                    return true;
//                }
//                return false; // Room already has a creator
//            }
//        }

//        public bool ConnectJoiner()
//        {
//            lock (roomLock)
//            {
//                if (joinerClient == null && creatorClient != null)
//                {
//                    joinerClient = new client();
//                    joinerClient.ConnectToServer();
//                    isFull = true; // Room is full after the joiner joins
//                    return true;
//                }
//                return false; // Room is already full or no creator
//            }
//        }

//        public void ConnectWatcher()
//        {
//            lock (roomLock)
//            {
//                if (!isFull)
//                {
//                    var watcherClient = new client();
//                    watcherClient.ConnectToServer();
//                    watcherClients.Add(watcherClient);
//                }
//            }
//        }

//        public void DisconnectRoom()
//        {
//            lock (roomLock)
//            {
//                creatorClient?.DisconnectFromServer();
//                joinerClient?.DisconnectFromServer();

//                foreach (var watcherClient in watcherClients)
//                {
//                    watcherClient.DisconnectFromServer();
//                }

//                server.DisconnectServer();
//                ResetRoom();
//            }
//        }

//        public void ExitRoom()
//        {
//            lock (roomLock)
//            {
//                creatorClient?.DisconnectFromServer();
//                ResetRoom();
//            }
//        }

//        private void ResetRoom()
//        {
//            creatorClient = null;
//            joinerClient = null;
//            watcherClients.Clear();
//            isFull = false;
//        }

//        public bool IsRoomFull()
//        {
//            lock (roomLock)
//            {
//                return isFull;
//            }
//        }

//        public void SendMessageToRoom(string message)
//        {
//            // You can implement logic to send messages to different types of clients
//            server.SendMessageToClients(message);
//        }

//        public void SendMessageToCreator(string message)
//        {
//            creatorClient?.SendMessageToServer(message);
//        }

//        public void SendMessageToJoiner(string message)
//        {
//            joinerClient?.SendMessageToServer(message);
//        }

//        public void SendMessageToWatchers(string message)
//        {
//            foreach (var watcherClient in watcherClients)
//            {
//                watcherClient.SendMessageToServer(message);
//            }
//        }
//    }

//}