﻿class BVCM_bytes
{
    public static byte[] standby_bv = { 0x02, 0x00, 0x20, 0x58, 0xa7, 0x40, 0x1D, 0x03 };
    public static byte[] standby_cm = { 0x02, 0x00, 0x20, 0x60, 0xA6, 0xDC, 0x03 };
    public static byte[] start_bv = { 0x02, 0x00, 0x20, 0x5B, 0x7D, 0xE3, 0x10, 0x31, 0x00, 0x22, 0xEF, 0x3E, 0x03 };
    public static byte[] start_cm = { 0x02, 0x00, 0x20, 0x63, 0x7D, 0xE2, 0x00, 0x01, 0x7D, 0xE3, 0xDD, 0xF2, 0x03 };
    public static byte[] inhibit_bv = { 0x02, 0x00, 0x20, 0x5B, 0x7D, 0xE3, 0x10, 0x00, 0x00, 0x13, 0x3B, 0xD9, 0x03 };
    public static byte[] inhibit_cm = { 0x02, 0x00, 0x20, 0x63, 0x7D, 0xE2, 0x00, 0x00, 0x7D, 0xE2, 0xFE, 0xE2, 0x03 };
    public static byte[] insertclear_bv = { 0x02, 0x00, 0x20, 0x5B, 0x7D, 0xE3, 0x10, 0x33, 0x00, 0x20, 0xA1, 0x1C, 0x03 };
    public static byte[] insertclear_cm = { 0x02, 0x00, 0x20, 0x63, 0x7D, 0xE2, 0x00, 0x7D, 0xE2, 0x00, 0xB8, 0xC2, 0x03 };
    public static byte[] inreq_cm = { 0x02, 0x00, 0x20, 0x62, 0x86, 0x9E, 0x03 };
    public static byte[] inreq_bv = { 0x02, 0x00, 0x20, 0x5a, 0xa5, 0x06, 0x3d, 0x03 };
    public static byte[] bill_return_1000 = { 0x02, 0x00, 0x20, 0x5B, 0x05, 0x11, 0x00, 0x10, 0x00, 0x00, 0x04, 0x26, 0xAE, 0x03 };
    public static byte[] bill_return_2000 = { 0x02, 0x00, 0x20, 0x5B, 0x05, 0x11, 0x00, 0x20, 0x00, 0x00, 0x34, 0x3C, 0x14, 0x03 };
    public static byte[] reset = { 0x02, 0x00, 0x20, 0xff, 0xd4, 0x8a, 0x03 };
}