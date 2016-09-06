﻿// Copyright 2016 by Samsung Electronics, Inc.
//
// This software is the confidential and proprietary information
// of Samsung Electronics, Inc. ("Confidential Information"). You
// shall not disclose such Confidential Information and shall use
// it only in accordance with the terms of the license agreement
// you entered into with Samsung.

using System;
using System.Runtime.InteropServices;

/// <summary>
/// Partial Interop Class
/// </summary>
internal static partial class Interop
{
    /// <summary>
    /// Network Interop Class
    /// </summary>
    internal static partial class Network
    {
        [DllImport(Libraries.Telephony, EntryPoint = "telephony_network_get_lac")]
        internal static extern Telephony.TelephonyError GetLac(IntPtr handle, out int lac);

        [DllImport(Libraries.Telephony, EntryPoint = "telephony_network_get_cell_id")]
        internal static extern Telephony.TelephonyError GetCellId(IntPtr handle, out int cellId);

        [DllImport(Libraries.Telephony, EntryPoint = "telephony_network_get_rssi")]
        internal static extern Telephony.TelephonyError GetRssi(IntPtr handle, out Tizen.Telephony.Network.Rssi rssi);

        [DllImport(Libraries.Telephony, EntryPoint = "telephony_network_get_roaming_status")]
        internal static extern Telephony.TelephonyError GetRoamingStatus(IntPtr handle, out bool status);

        [DllImport(Libraries.Telephony, EntryPoint = "telephony_network_get_mcc")]
        internal static extern Telephony.TelephonyError GetMcc(IntPtr handle, out string mcc);

        [DllImport(Libraries.Telephony, EntryPoint = "telephony_network_get_mnc")]
        internal static extern Telephony.TelephonyError GetMnc(IntPtr handle, out string mnc);

        [DllImport(Libraries.Telephony, EntryPoint = "telephony_network_get_network_name")]
        internal static extern Telephony.TelephonyError GetNetworkName(IntPtr handle, out string networkName);

        [DllImport(Libraries.Telephony, EntryPoint = "telephony_network_get_type")]
        internal static extern Telephony.TelephonyError GetType(IntPtr handle, out Tizen.Telephony.Network.Type networkType);

        [DllImport(Libraries.Telephony, EntryPoint = "telephony_network_get_ps_type")]
        internal static extern Telephony.TelephonyError GetPsType(IntPtr handle, out Tizen.Telephony.Network.PsType psType);

        [DllImport(Libraries.Telephony, EntryPoint = "telephony_network_get_network_name_option")]
        internal static extern Telephony.TelephonyError GetNetworkNameOption(IntPtr handle, out Tizen.Telephony.Network.NameOption networkNameOption);

        [DllImport(Libraries.Telephony, EntryPoint = "telephony_network_get_service_state")]
        internal static extern Telephony.TelephonyError GetServiceState(IntPtr handle, out Tizen.Telephony.Network.ServiceState networkServiceState);

        [DllImport(Libraries.Telephony, EntryPoint = "telephony_network_get_default_data_subscription")]
        internal static extern Telephony.TelephonyError GetDefaultDataSubscription(IntPtr handle, out Tizen.Telephony.Network.DefaultDataSubscription defaultSub);

        [DllImport(Libraries.Telephony, EntryPoint = "telephony_network_get_default_subscription")]
        internal static extern Telephony.TelephonyError GetDefaultSubscription(IntPtr handle, out Tizen.Telephony.Network.DefaultSubscription defaultSub);

        [DllImport(Libraries.Telephony, EntryPoint = "telephony_network_get_selection_mode")]
        internal static extern Telephony.TelephonyError GetSelectionMode(IntPtr handle, out Tizen.Telephony.Network.SelectionMode mode);

        [DllImport(Libraries.Telephony, EntryPoint = "telephony_network_get_tac")]
        internal static extern Telephony.TelephonyError GetTac(IntPtr handle, out int tac);

        [DllImport(Libraries.Telephony, EntryPoint = "telephony_network_get_system_id")]
        internal static extern Telephony.TelephonyError GetSystemId(IntPtr handle, out int sid);

        [DllImport(Libraries.Telephony, EntryPoint = "telephony_network_get_network_id")]
        internal static extern Telephony.TelephonyError GetNetworkId(IntPtr handle, out int nid);

        [DllImport(Libraries.Telephony, EntryPoint = "telephony_network_get_base_station_id")]
        internal static extern Telephony.TelephonyError GetBaseStationId(IntPtr handle, out int bsId);

        [DllImport(Libraries.Telephony, EntryPoint = "telephony_network_get_base_station_latitude")]
        internal static extern Telephony.TelephonyError GetBaseStationLatitude(IntPtr handle, out int bsLatitude);

        [DllImport(Libraries.Telephony, EntryPoint = "telephony_network_get_base_station_longitude")]
        internal static extern Telephony.TelephonyError GetBaseStationLongitude(IntPtr handle, out int bsLongitude);
    }
}
