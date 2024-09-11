using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;

namespace UpandDownBananaOS
{
        public class photonmoddedcheck : MonoBehaviourPunCallbacks
        {
            public static photonmoddedcheck modcheck;
            public object gameMode;
            public void Start()
            {
                modcheck = this;
            }
            public bool IsModded()
            {
                if (!PhotonNetwork.InRoom)
                    return false;
                return gameMode.ToString().Contains("MODDED");
            }

            public override void OnJoinedRoom() => PhotonNetwork.CurrentRoom.CustomProperties.TryGetValue("gameMode", out gameMode);
        }
}
