using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.GurkansSandBox.CommandPattern.RemoteControl
{
    public class PlayWithRemote : MonoBehaviour
    {
        IElectronicDevice _device = TVRemote.GetDevice();

        [ContextMenu("TurnOn")]
        private void TurnOnCommand()
        {
            TurnTVOn _onCommand = new TurnTVOn(_device);

            DeviceButton onPressed = new DeviceButton(_onCommand);

            onPressed.Press();
        }
        [ContextMenu("TurnOff")]
        private void TurnOffCommand()
        {
            TurnTVOff _onCommand = new TurnTVOff(_device);

            DeviceButton onPressed = new DeviceButton(_onCommand);

            onPressed.Press();
        }
        [ContextMenu("VolumeUp")]
        private void TurnVolumeUpCommand()
        {
            TVVolumeUp _onCommand = new TVVolumeUp(_device);

            DeviceButton onPressed = new DeviceButton(_onCommand);

            onPressed.Press();
        }
        [ContextMenu("VolumeDown")]
        private void TurnVolumeDownCommand()
        {
            TVVolumeUp _onCommand = new TVVolumeUp(_device);

            DeviceButton onPressed = new DeviceButton(_onCommand);

            onPressed.PressUndo();
        }
    }
}
