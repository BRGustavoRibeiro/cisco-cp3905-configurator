using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CiscoCP3905Configurator
{
    public class Config
    {
        [Category("Phone Setup")]
        [DisplayName("Device Protocol")]
        public string deviceProtocol { get; set; } = "SIP";
        [Category("Phone Setup")]
        [DisplayName("Firmware Version")]
        public string loadInformation { get; set; } = "CP3905.9-4-1SR3";
        [Category("Phone Setup")]
        [DisplayName("SSH User ID")]
        public string sshUserID { get; set; } = "cisco";
        [Category("Phone Setup")]
        [DisplayName("SSH Password")]
        public string sshPassword { get; set; } = "cisco";
        [Category("Phone Setup")]
        [DisplayName("Ethernet Phone Port")]
        public string ports_ethernetPhonePort { get; set; } = "2000";
        [Category("Phone Setup")]
        [DisplayName("Device Security Mode")]
        public string deviceSecurityMode { get; set; } = "1";
        [Category("Phone Setup")]
        [DisplayName("Authentication URL")]
        public string authenticationURL { get; set; }
        [Category("Phone Setup")]
        [DisplayName("Directory URL")]
        public string directoryURL { get; set; }
        [Category("Phone Setup")]
        [DisplayName("Services URL")]
        public string servicesURL { get; set; }
        [Category("Phone Setup")]
        [DisplayName("Idle URL")]
        public string idleURL { get; set; }
        [Category("Phone Setup")]
        [DisplayName("Information URL")]
        public string informationURL { get; set; }
        [Category("Phone Setup")]
        [DisplayName("Messages URL")]
        public string messagesURL { get; set; }
        [Category("Phone Setup")]
        [DisplayName("Proxy Server URL")]
        public string proxyServerURL { get; set; }
        [Category("Phone Setup")]
        [DisplayName("DSCP For SCCP Phone Config")]
        public string dscpForSCCPPhoneConfig { get; set; } = "96";
        [Category("Phone Setup")]
        [DisplayName("DSCP For SCCP Phone Services")]
        public string dscpForSCCPPhoneServices { get; set; } = "0";
        [Category("Phone Setup")]
        [DisplayName("DSCP for CM2Dvce")]
        public string dscpForCm2Dvce { get; set; } = "96";
        [Category("Phone Setup")]
        [DisplayName("Transport Layer Protocol")]
        public string transportLayerProtocol { get; set; } = "2";
        [Category("Phone Setup")]
        [DisplayName("Cert Hash")]
        public string certHash { get; set; }

        [Category("Date/Time")]
        [DisplayName("Date Format")]
        public string dateTemplate { get; set; } = "D/M/Y";
        [Category("Date/Time")]
        [DisplayName("Time Zone")]
        public string timeZone { get; set; } = "SA Eastern Standard Time";
        [Category("Date/Time")]
        [DisplayName("NTP IP")]
        public string ntp_name { get; set; } = "201.49.148.135";
        [Category("Date/Time")]
        [DisplayName("NTP Mode")]
        public string ntp_ntpMode { get; set; } = "Unicast";

        [Category("SIP")]
        [DisplayName("SIP Port")]
        public string ports_sipPort { get; set; } = "5060";
        [Category("SIP")]
        [DisplayName("Secured SIP Port")]
        public string ports_securedSipPort { get; set; } = "5061";
        [Category("SIP")]
        [DisplayName("SIP Registering IP / Hostname")]
        public string callManager_processNodeName { get; set; }

        [Category("SIP Proxies")]
        [DisplayName("Backup Proxy")]
        public string sip_backupProxy { get; set; }
        [Category("SIP Proxies")]
        [DisplayName("Backup Proxy Port")]
        public string sip_backupProxyPort { get; set; } = "5060";
        [Category("SIP Proxies")]
        [DisplayName("Emergency Proxy")]
        public string sip_emergencyProxy { get; set; }
        [Category("SIP Proxies")]
        [DisplayName("Emergency Proxy Port")]
        public string sip_emergencyProxyPort { get; set; }
        [Category("SIP Proxies")]
        [DisplayName("Outbound Proxy")]
        public string sip_outboundProxy { get; set; }
        [Category("SIP Proxies")]
        [DisplayName("Outbound Proxy Port")]
        public string sip_outboundProxyPort { get; set; }
        [Category("SIP Proxies")]
        [DisplayName("Register With Proxy")]
        public string sip_registerWithProxy { get; set; } = "true";

        [Category("SIP Call Features")]
        [DisplayName("CNF Join Enabled")]
        public string sipcf_cnfJoinEnabled { get; set; } = "true";
        [Category("SIP Call Features")]
        [DisplayName("Call Forward URI")]
        public string sipcf_callForwardURI { get; set; } = "x-serviceuri-cfwdall";
        [Category("SIP Call Features")]
        [DisplayName("Call Pickup URI")]
        public string sipcf_callPickupURI { get; set; } = "x-cisco-serviceuri-pickup";
        [Category("SIP Call Features")]
        [DisplayName("Call Pickup List URI")]
        public string sipcf_callPickupListURI { get; set; } = "x-cisco-serviceuri-opickup";
        [Category("SIP Call Features")]
        [DisplayName("Call Pickup Group URI")]
        public string sipcf_callPickupGroupURI { get; set; } = "x-cisco-serviceuri-gpickup";
        [Category("SIP Call Features")]
        [DisplayName("MeetMe Service URI")]
        public string sipcf_meetMeServiceURI { get; set; } = "x-cisco-serviceuri-meetme";
        [Category("SIP Call Features")]
        [DisplayName("Abbreviated Dial URI")]
        public string sipcf_abbreviatedDialURI { get; set; } = "x-cisco-serviceuri-abbrdial";
        [Category("SIP Call Features")]
        [DisplayName("RFC2543 Hold")]
        public string sipcf_rfc2543Hold { get; set; } = "false";
        [Category("SIP Call Features")]
        [DisplayName("Call Hold Ringback")]
        public string sipcf_callHoldRingback { get; set; } = "2";
        [Category("SIP Call Features")]
        [DisplayName("Local CFWD Enable")]
        public string sipcf_localCfwdEnable { get; set; } = "true";
        [Category("SIP Call Features")]
        [DisplayName("Semi Attended Transfer")]
        public string sipcf_semiAttendedTransfer { get; set; } = "true";
        [Category("SIP Call Features")]
        [DisplayName("Anonymous Call Block")]
        public string sipcf_anonymousCallBlock { get; set; } = "2";
        [Category("SIP Call Features")]
        [DisplayName("Caller ID Blocking")]
        public string sipcf_callerIdBlocking { get; set; } = "2";
        [Category("SIP Call Features")]
        [DisplayName("DND Control")]
        public string sipcf_dndControl { get; set; } = "0";
        [Category("SIP Call Features")]
        [DisplayName("Remote CC Enable")]
        public string sipcf_remoteCcEnable { get; set; } = "true";

        [Category("SIP Stack")]
        [DisplayName("SIP Invite Retx")]
        public string sips_sipInviteRetx { get; set; } = "true";
        [Category("SIP Stack")]
        [DisplayName("SIP Retx")]
        public string sips_sipRetx { get; set; } = "10";
        [Category("SIP Stack")]
        [DisplayName("Timer Invite Expires")]
        public string sips_timerInviteExpires { get; set; } = "180";
        [Category("SIP Stack")]
        [DisplayName("Timer Register Expires")]
        public string sips_timerRegisterExpires { get; set; } = "120";
        [Category("SIP Stack")]
        [DisplayName("Timer Register Delta")]
        public string sips_timerRegisterDelta { get; set; } = "5";
        [Category("SIP Stack")]
        [DisplayName("Timer Keep Alive Expires")]
        public string sips_timerKeepAliveExpires { get; set; } = "120";
        [Category("SIP Stack")]
        [DisplayName("Timer Subscribe Expires")]
        public string sips_timerSubscribeExpires { get; set; } = "120";
        [Category("SIP Stack")]
        [DisplayName("Timer Subscribe Delta")]
        public string sips_timerSubscribeDelta { get; set; } = "5";
        [Category("SIP Stack")]
        [DisplayName("Timer T1")]
        public string sips_timerT1 { get; set; } = "500";
        [Category("SIP Stack")]
        [DisplayName("Timer T2")]
        public string sips_timerT2 { get; set; } = "4000";
        [Category("SIP Stack")]
        [DisplayName("Max Redirects")]
        public string sips_maxRedirects { get; set; } = "70";
        [Category("SIP Stack")]
        [DisplayName("Remote Party ID")]
        public string sips_remotePartyID { get; set; } = "false";
        [Category("SIP Stack")]
        [DisplayName("User Info")]
        public string sips_userInfo { get; set; } = "None";

        [Category("SIP Profile")]
        [DisplayName("Auto Answer Timer")]
        public string sipp_autoAnswerTimer { get; set; } = "1";
        [Category("SIP Profile")]
        [DisplayName("Auto Answer Alt Behavior")]
        public string sipp_autoAnswerAltBehavior { get; set; } = "false";
        [Category("SIP Profile")]
        [DisplayName("Auto Answer Override")]
        public string sipp_autoAnswerOverride { get; set; } = "true";
        [Category("SIP Profile")]
        [DisplayName("Transfer Onhook Enabled")]
        public string sipp_transferOnhookEnabled { get; set; } = "false";
        [Category("SIP Profile")]
        [DisplayName("Enable Vad")]
        public string sipp_enableVad { get; set; } = "false";
        [Category("SIP Profile")]
        [DisplayName("DTMF AVT Payload")]
        public string sipp_dtmfAvtPayload { get; set; } = "101";
        [Category("SIP Profile")]
        [DisplayName("DTMF DB Level")]
        public string sipp_dtmfDbLevel { get; set; } = "3";
        [Category("SIP Profile")]
        [DisplayName("DTMF Out of Band")]
        public string sipp_dtmfOutofBand { get; set; } = "avt";
        [Category("SIP Profile")]
        [DisplayName("Always Use Prime Line")]
        public string sipp_alwaysUsePrimeLine { get; set; } = "false";
        [Category("SIP Profile")]
        [DisplayName("Always Use Prime Line VoiceMail")]
        public string sipp_alwaysUsePrimeLineVoiceMail { get; set; } = "false";
        [Category("SIP Profile")]
        [DisplayName("KPML")]
        public string sipp_kpml { get; set; } = "3";
        [Category("SIP Profile")]
        [DisplayName("Stutter Message Waiting")]
        public string sipp_stutterMsgWaiting { get; set; } = "1";
        [Category("SIP Profile")]
        [DisplayName("Call Stats")]
        public string sipp_callStats { get; set; } = "false";
        [Category("SIP Profile")]
        [DisplayName("Silent Period Between Call Waiting Bursts")]
        public string sipp_silentPeriodBetweenCallWaitingBursts { get; set; } = "10";
        [Category("SIP Profile")]
        [DisplayName("Disable Local Speed Dial Config")]
        public string sipp_disableLocalSpeedDialConfig { get; set; } = "false";
        [Category("SIP Profile")]
        [DisplayName("Phone Label")]
        public string sipp_phoneLabel { get; set; }
        [Category("SIP Profile")]
        [DisplayName("VOIP Control Port")]
        public string sipp_voipControlPort { get; set; } = "5060";
        [Category("SIP Profile")]
        [DisplayName("Start Media Port")]
        public string sipp_startMediaPort { get; set; } = "9000";
        [Category("SIP Profile")]
        [DisplayName("Stop Media Port")]
        public string sipp_stopMediaPort { get; set; } = "21000";
        [Category("SIP Profile")]
        [DisplayName("DSCP For Audio")]
        public string sipp_dscpForAudio { get; set; } = "184";
        [Category("SIP Profile")]
        [DisplayName("Ring Setting Busy Station Policy")]
        public string sipp_ringSettingBusyStationPolicy { get; set; } = "0";
        [Category("SIP Profile")]
        [DisplayName("Dial Template")]
        public string sipp_dialTemplate { get; set; } = "dialplan.xml";
        [Category("SIP Profile")]
        [DisplayName("Soft Key File")]
        public string sipp_softKeyFile { get; set; }

        [Category("User Profile / Line")]
        [DisplayName("Feature ID")]
        public string sipl_featureID { get; set; } = "9";
        [Category("User Profile / Line")]
        [DisplayName("SIP Registering IP/FQDN")]
        public string sipl_proxy { get; set; }
        [Category("User Profile / Line")]
        [DisplayName("Port")]
        public string sipl_port { get; set; } = "5060";
        [Category("User Profile / Line")]
        [DisplayName("Feature Label")]
        public string sipl_featureLabel { get; set; }
        [Category("User Profile / Line")]
        [DisplayName("Display Name")]
        public string sipl_displayName { get; set; }
        [Category("User Profile / Line")]
        [DisplayName("SIP Username")]
        public string sipl_name { get; set; }
        [Category("User Profile / Line")]
        [DisplayName("SIP Authname")]
        public string sipl_authName { get; set; }
        [Category("User Profile / Line")]
        [DisplayName("SIP Password")]
        public string sipl_authPassword { get; set; }
        [Category("User Profile / Line")]
        [DisplayName("Auto Answer Enabled")]
        public string sipl_autoAnswerEnabled { get; set; } = "2";
        [Category("User Profile / Line")]
        [DisplayName("Call Waiting")]
        public string sipl_callWaiting { get; set; } = "3";
        [Category("User Profile / Line")]
        [DisplayName("Shared Line")]
        public string sipl_sharedLine { get; set; } = "false";
        [Category("User Profile / Line")]
        [DisplayName("Message Waiting Lamp Policy")]
        public string sipl_messageWaitingLampPolicy { get; set; } = "1";
        [Category("User Profile / Line")]
        [DisplayName("Messages Number")]
        public string sipl_messagesNumber { get; set; } = "*97";
        [Category("User Profile / Line")]
        [DisplayName("Ring Setting Idle")]
        public string sipl_ringSettingIdle { get; set; } = "4";
        [Category("User Profile / Line")]
        [DisplayName("Ring Setting Active")]
        public string sipl_ringSettingActive { get; set; } = "5";
        [Category("User Profile / Line")]
        [DisplayName("Show Caller Name")]
        public string sipl_callerName { get; set; } = "true";
        [Category("User Profile / Line")]
        [DisplayName("Show Caller Number")]
        public string sipl_callerNumber { get; set; } = "false";
        [Category("User Profile / Line")]
        [DisplayName("Show Redirected Number")]
        public string sipl_redirectedNumber { get; set; } = "false";
        [Category("User Profile / Line")]
        [DisplayName("Show Dialed Number")]
        public string sipl_dialedNumber { get; set; } = "true";

        [Category("Common Profile")]
        [DisplayName("Phone Password")]
        public string cmnpfl_phonePassword { get; set; }
        [Category("Common Profile")]
        [DisplayName("Background Image Access")]
        public string cmnpfl_backgroundImageAccess { get; set; } = "true";
        [Category("Common Profile")]
        [DisplayName("Call Log Blf Enabled")]
        public string cmnpfl_callLogBflEnabled { get; set; } = "2";

        [Category("Vendor Config")]
        [DisplayName("Disable Speaker")]
        public string vc_disableSpeaker { get; set; } = "false";
        [Category("Vendor Config")]
        [DisplayName("Disable Speaker and Headset")]
        public string vc_disableSpeakerAndHeadset { get; set; } = "false";
        [Category("Vendor Config")]
        [DisplayName("PC Port")]
        public string vc_pcPort { get; set; } = "0";
        [Category("Vendor Config")]
        [DisplayName("Settings Access")]
        public string vc_settingsAccess { get; set; } = "1";
        [Category("Vendor Config")]
        [DisplayName("Garp")]
        public string vc_garp { get; set; } = "0";
        [Category("Vendor Config")]
        [DisplayName("Voice Vlan Access")]
        public string vc_voiceVlanAccess { get; set; } = "0";
        [Category("Vendor Config")]
        [DisplayName("Video Capability")]
        public string vc_videoCapability { get; set; } = "0";
        [Category("Vendor Config")]
        [DisplayName("Auto Select Line Enable")]
        public string vc_autoSelectLineEnable { get; set; } = "0";
        [Category("Vendor Config")]
        [DisplayName("Web Access")]
        public string vc_webAccess { get; set; } = "1";
        [Category("Vendor Config")]
        [DisplayName("Days Display Not Active")]
        public string vc_daysDisplayNotActive { get; set; } = "1,2,3,4,5,6,7";
        [Category("Vendor Config")]
        [DisplayName("Display On Time")]
        public string vc_displayOnTime { get; set; } = "00:00";
        [Category("Vendor Config")]
        [DisplayName("Display On Duration")]
        public string vc_displayOnDuration { get; set; } = "00:00";
        [Category("Vendor Config")]
        [DisplayName("Disable Idle Timeout")]
        public string vc_displayIdleTimeout { get; set; } = "00:00";
        [Category("Vendor Config")]
        [DisplayName("Span to PC Port")]
        public string vc_spanToPCPort { get; set; } = "1";
        [Category("Vendor Config")]
        [DisplayName("Logging Display")]
        public string vc_loggingDisplay { get; set; } = "1";
        [Category("Vendor Config")]
        [DisplayName("Load Server")]
        public string vc_loadServer { get; set; }

        [Category("User Locale")]
        [DisplayName("Name")]
        public string ul_name { get; set; }
        [Category("User Locale")]
        [DisplayName("UID")]
        public string ul_uid { get; set; }
        [Category("User Locale")]
        [DisplayName("Language Code")]
        public string ul_langCode { get; set; } = "Brazil";
        [Category("User Locale")]
        [DisplayName("Version")]
        public string ul_version { get; set; } = "1.0.0.0-1";
        [Category("User Locale")]
        [DisplayName("Win Charset")]
        public string ul_winCharSet { get; set; } = "iso-8859-1";

        [Category("Network Locale")]
        [DisplayName("Network Locale")]
        public string nl { get; set; } = "Brazil";
        [Category("Network Locale")]
        [DisplayName("Name")]
        public string nl_name { get; set; } = "Brazil";
        [Category("Network Locale")]
        [DisplayName("UID")]
        public string nl_uid { get; set; }
        [Category("Network Locale")]
        [DisplayName("Version")]
        public string nl_version { get; set; } = "1.0.0.0-1";

        [Category("Capf List")]
        [DisplayName("Phone Port")]
        public string capf_phonePort { get; set; } = "3804";
        [Category("Capf List")]
        [DisplayName("Capf Auth Mode")]
        public string capfAuthMode { get; set; } = "0";
    }
}
