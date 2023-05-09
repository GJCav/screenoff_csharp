using System;
using System.Runtime.InteropServices;

[DllImport("User32.dll")]
static extern bool LockWorkStation();

[DllImport("User32.dll")]
static extern int PostMessage(int hWnd, int hMsg, int wParam, int lParam);


LockWorkStation();
PostMessage(-1, 0x0112, 0xF170, 2);

/**
 * WM_SYSCOMMAND    0x0112
 * SC_MONITORPOWER  0xF170
 * lParam
 *   * -1 is powering on
 *   * 1  going to low power
 *   * 2  shut off
 */