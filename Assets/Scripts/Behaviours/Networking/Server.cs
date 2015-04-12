﻿using System;
using System.Collections.Generic;
using Facepunch.Networking;
using ProtoBuf;
using ProtoBuf.Player;

namespace SanAndreasUnity.Behaviours.Networking
{
    public class Server : Facepunch.Networking.Server
    {

#if PROTOBUF

        package ProtoBuf;

        //:baseclass = INetworkMessage
        message PlayerConnected
        {
            optional ProtoBuf.Player.PlayerInfo Player = 1;
        }

        //:baseclass = INetworkMessage
        message PlayerDisconnected
        {
            optional ProtoBuf.Player.PlayerInfo Player = 1;
            optional string Reason = 2;
        }

        //:baseclass = INetworkMessage
        message ServerChat
        {
            optional string Message = 1;
        }

#endif

        private readonly Dictionary<IRemote, Player> _players;
        private readonly Random _random = new Random();

        public List<UnityEngine.Transform> PlayerSpawns = new List<UnityEngine.Transform>();

        public Server()
        {
            _players = new Dictionary<IRemote,Player>();
        }

        protected override void OnAcceptClient(Facepunch.Networking.IRemote client, ConnectRequest request)
        {
            base.OnAcceptClient(client, request);

            var data = ConnectRequestData.Deserialize(request.Data);

            var plyr = Networkable.SpawnFromPrefab<Player>();

            plyr.ServerSideInit(client, request.UserId, request.Username, data.ModelId);

            if (PlayerSpawns.Count > 0) {
                plyr.Position = PlayerSpawns[_random.Next(PlayerSpawns.Count)].position;
            }

            _players.Add(client, plyr);

            client.Disconnected += (sender, reason) => {
                if (_players.ContainsKey(sender)) _players.Remove(sender);
                if (_players.Count == 0) return;

                var playerDisconnected = new PlayerDisconnected {
                    Player = new PlayerInfo {
                        UserId = plyr.UserId,
                        Username = plyr.Username,
                        Modelid = data.ModelId
                    },
                    Reason = reason,
                };

                Net.SendMessage(playerDisconnected, GlobalGroup.Subscribers, DeliveryMethod.ReliableOrdered, 1);
            };

            GlobalGroup.Add(plyr);
            GlobalGroup.AddSubscriber(client);

            var playerConnected = new PlayerConnected {
                Player = new PlayerInfo {
                    UserId = plyr.UserId,
                    Username = plyr.Username
                },
            };

            Net.SendMessage(playerConnected, GlobalGroup.Subscribers, DeliveryMethod.ReliableOrdered, 1);
        }
    }
}
