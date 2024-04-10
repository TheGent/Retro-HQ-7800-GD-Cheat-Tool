﻿Imports System.IO

Public Class CRC_A78

    '////////////////////////////////////////////////////////////////////////////////
    '//
    '// CRC table
    '//
    '////////////////////////////////////////////////////////////////////////////////

    ReadOnly crc32_table() =
    {
      &H0, &H4C11DB7, &H9823B6E, &HD4326D9,
      &H130476DC, &H17C56B6B, &H1A864DB2, &H1E475005,
      &H2608EDB8, &H22C9F00F, &H2F8AD6D6, &H2B4BCB61,
      &H350C9B64, &H31CD86D3, &H3C8EA00A, &H384FBDBD,
      &H4C11DB70, &H48D0C6C7, &H4593E01E, &H4152FDA9,
      &H5F15ADAC, &H5BD4B01B, &H569796C2, &H52568B75,
      &H6A1936C8, &H6ED82B7F, &H639B0DA6, &H675A1011,
      &H791D4014, &H7DDC5DA3, &H709F7B7A, &H745E66CD,
      &H9823B6E0, &H9CE2AB57, &H91A18D8E, &H95609039,
      &H8B27C03C, &H8FE6DD8B, &H82A5FB52, &H8664E6E5,
      &HBE2B5B58, &HBAEA46EF, &HB7A96036, &HB3687D81,
      &HAD2F2D84, &HA9EE3033, &HA4AD16EA, &HA06C0B5D,
      &HD4326D90, &HD0F37027, &HDDB056FE, &HD9714B49,
      &HC7361B4C, &HC3F706FB, &HCEB42022, &HCA753D95,
      &HF23A8028, &HF6FB9D9F, &HFBB8BB46, &HFF79A6F1,
      &HE13EF6F4, &HE5FFEB43, &HE8BCCD9A, &HEC7DD02D,
      &H34867077, &H30476DC0, &H3D044B19, &H39C556AE,
      &H278206AB, &H23431B1C, &H2E003DC5, &H2AC12072,
      &H128E9DCF, &H164F8078, &H1B0CA6A1, &H1FCDBB16,
      &H18AEB13, &H54BF6A4, &H808D07D, &HCC9CDCA,
      &H7897AB07, &H7C56B6B0, &H71159069, &H75D48DDE,
      &H6B93DDDB, &H6F52C06C, &H6211E6B5, &H66D0FB02,
      &H5E9F46BF, &H5A5E5B08, &H571D7DD1, &H53DC6066,
      &H4D9B3063, &H495A2DD4, &H44190B0D, &H40D816BA,
      &HACA5C697, &HA864DB20, &HA527FDF9, &HA1E6E04E,
      &HBFA1B04B, &HBB60ADFC, &HB6238B25, &HB2E29692,
      &H8AAD2B2F, &H8E6C3698, &H832F1041, &H87EE0DF6,
      &H99A95DF3, &H9D684044, &H902B669D, &H94EA7B2A,
      &HE0B41DE7, &HE4750050, &HE9362689, &HEDF73B3E,
      &HF3B06B3B, &HF771768C, &HFA325055, &HFEF34DE2,
      &HC6BCF05F, &HC27DEDE8, &HCF3ECB31, &HCBFFD686,
      &HD5B88683, &HD1799B34, &HDC3ABDED, &HD8FBA05A,
      &H690CE0EE, &H6DCDFD59, &H608EDB80, &H644FC637,
      &H7A089632, &H7EC98B85, &H738AAD5C, &H774BB0EB,
      &H4F040D56, &H4BC510E1, &H46863638, &H42472B8F,
      &H5C007B8A, &H58C1663D, &H558240E4, &H51435D53,
      &H251D3B9E, &H21DC2629, &H2C9F00F0, &H285E1D47,
      &H36194D42, &H32D850F5, &H3F9B762C, &H3B5A6B9B,
      &H315D626, &H7D4CB91, &HA97ED48, &HE56F0FF,
      &H1011A0FA, &H14D0BD4D, &H19939B94, &H1D528623,
      &HF12F560E, &HF5EE4BB9, &HF8AD6D60, &HFC6C70D7,
      &HE22B20D2, &HE6EA3D65, &HEBA91BBC, &HEF68060B,
      &HD727BBB6, &HD3E6A601, &HDEA580D8, &HDA649D6F,
      &HC423CD6A, &HC0E2D0DD, &HCDA1F604, &HC960EBB3,
      &HBD3E8D7E, &HB9FF90C9, &HB4BCB610, &HB07DABA7,
      &HAE3AFBA2, &HAAFBE615, &HA7B8C0CC, &HA379DD7B,
      &H9B3660C6, &H9FF77D71, &H92B45BA8, &H9675461F,
      &H8832161A, &H8CF30BAD, &H81B02D74, &H857130C3,
      &H5D8A9099, &H594B8D2E, &H5408ABF7, &H50C9B640,
      &H4E8EE645, &H4A4FFBF2, &H470CDD2B, &H43CDC09C,
      &H7B827D21, &H7F436096, &H7200464F, &H76C15BF8,
      &H68860BFD, &H6C47164A, &H61043093, &H65C52D24,
      &H119B4BE9, &H155A565E, &H18197087, &H1CD86D30,
      &H29F3D35, &H65E2082, &HB1D065B, &HFDC1BEC,
      &H3793A651, &H3352BBE6, &H3E119D3F, &H3AD08088,
      &H2497D08D, &H2056CD3A, &H2D15EBE3, &H29D4F654,
      &HC5A92679, &HC1683BCE, &HCC2B1D17, &HC8EA00A0,
      &HD6AD50A5, &HD26C4D12, &HDF2F6BCB, &HDBEE767C,
      &HE3A1CBC1, &HE760D676, &HEA23F0AF, &HEEE2ED18,
      &HF0A5BD1D, &HF464A0AA, &HF9278673, &HFDE69BC4,
      &H89B8FD09, &H8D79E0BE, &H803AC667, &H84FBDBD0,
      &H9ABC8BD5, &H9E7D9662, &H933EB0BB, &H97FFAD0C,
      &HAFB010B1, &HAB710D06, &HA6322BDF, &HA2F33668,
      &HBCB4666D, &HB8757BDA, &HB5365D03, &HB1F740B4
    }

    '////////////////////////////////////////////////////////////////////////////////
    '//
    '// Generate CRC for A78 file, making sure the file Is (roughly) valid
    '//
    '////////////////////////////////////////////////////////////////////////////////

    Public Sub GenerateA78CRC(Filename As String, ByRef Name As String, ByRef CRC As String)

        '// see if we can open the file
        Dim File As FileStream

        File = New FileStream(Filename, FileMode.Open)

        Dim aHeader(128) As Byte
        Dim Rom(File.Length - 129) As Byte

        'printf("%s : unable to open for reading.\n", pFilename);
        'Return
        'End If

        '// read in header And check it looks right
        Dim bytesread = File.Read(aHeader, 0, 128)
        For i = 1 To 16
            If (aHeader(i) = 0) Then aHeader(i) = 32
        Next
        Dim strHeader = System.Text.Encoding.UTF8.GetString(aHeader, 1, 16).Trim()
        Name = System.Text.Encoding.UTF8.GetString(aHeader, 17, 32).Trim()

        If bytesread <> 128 Or Not (strHeader.Equals("ATARI7800")) Then
            File.Close()
            MessageBox.Show(Filename & " : invalid A78 file.\n", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        bytesread = File.Read(Rom, 0, Rom.Length)

        '// file looks good, crc the actual ROM data following the header
        Dim tCRC As Int32 = 0
        Dim iCRC As Int32 = 0

        For Each tByte As Byte In Rom
            iCRC = (tCRC >> 24) And 255
            tCRC = (tCRC << 8) Xor crc32_table((iCRC Xor tByte) And 255)
        Next

        File.Close()

        CRC = "$" + tCRC.ToString("X8")

        'printf("$" %s : $%08x\n", pFilename, CRC);
    End Sub


End Class
