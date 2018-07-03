using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hopcoms.DataCollection
{
    public static partial class NativeMethods
    {

        /// Return Type: int
        [System.Runtime.InteropServices.DllImportAttribute("MFS100Dll.dll")]
        public static extern int MFS100Init(System.IntPtr serialno);


        /// Return Type: int
        [System.Runtime.InteropServices.DllImportAttribute("MFS100Dll.dll")]
        public static extern int MFS100Uninit();

        /// Return Type: int
        [System.Runtime.InteropServices.DllImportAttribute("MFS100Dll.dll")]
        public static extern int MFS100GetWidth();

        /// Return Type: int
        [System.Runtime.InteropServices.DllImportAttribute("MFS100Dll.dll")]
        public static extern int MFS100GetHeight();

        /// Return Type: void
        [System.Runtime.InteropServices.DllImportAttribute("MFS100Dll.dll")]
        public static extern int MFS100StartXcan();


        /// Return Type: void
        [System.Runtime.InteropServices.DllImportAttribute("MFS100Dll.dll")]
        public static extern int MFS100StopXcan();

        /// Return Type: int
        [System.Runtime.InteropServices.DllImportAttribute("MFS100Dll.dll")]
        public static extern int MFS100DeviceConnected();

        
        /// Return Type: void
        ///FinalFrame500DPI: unsigned char*
        [System.Runtime.InteropServices.DllImportAttribute("MFS100Dll.dll")]
        public static extern int MFS100GetFrame(System.IntPtr FinalFrame500DPI);

        //[System.Runtime.InteropServices.DllImportAttribute("MFS100Dll.dll")]
        //public static extern int MFS100ReadSerial(System.IntPtr serialno);

        [System.Runtime.InteropServices.DllImportAttribute("MFS100Dll.dll")]
        public static extern void MFS100RotateImage(int Direction);


        //Extrator Functions
        
        [System.Runtime.InteropServices.DllImportAttribute("MFS100Dll.dll")]
        public static extern int MFS100GetQuality(System.IntPtr RawImage, ref int Quality,ref int Contrast,ref int NFIQ);

        [System.Runtime.InteropServices.DllImportAttribute("MFS100Dll.dll")]
        public static extern int MFS100ExtractISOTemplate(System.IntPtr RawImage,System.IntPtr Iso_19794_2_Template,ref int TemplateLength);

        [System.Runtime.InteropServices.DllImportAttribute("MFS100Dll.dll")]
        public static extern int MFS100ExtractANSITemplate(System.IntPtr RawImage,System.IntPtr Ansi_19794_2_Template,ref int TemplateLength);

        [System.Runtime.InteropServices.DllImportAttribute("MFS100Dll.dll")]
        public static extern int MFS100ExtractISOImage(System.IntPtr RawImage,System.IntPtr ISOImage,ref int ISOImageSize, byte FingerPosition);

        [System.Runtime.InteropServices.DllImportAttribute("MFS100Dll.dll")]
        public static extern int MFS100MatchISO(System.IntPtr probeTemplate,System.IntPtr galleryTemplate,int maxRotation, ref int score);

        [System.Runtime.InteropServices.DllImportAttribute("MFS100Dll.dll")]
        public static extern int MFS100MatchANSI(System.IntPtr probeTemplate,System.IntPtr galleryTemplate,int maxRotation, ref int score);


        //int MFS100ExtractISOImage(unsigned char* RawImage,unsigned char *ISOImage, int *ISOImageSize, unsigned char FingerPosition);

        public const int MFS100_E_SUCCESS = 0;		//No error. (Success)
        public const int MFS100_E_LOAD_SCANNER_LIBRARY = 1301; 	//Error on loading scanner Library
        public const int MFS100_E_CAPTURE_FAILED = 1302; 	//Capturing is timeout or Aborted
        public const int MFS100_E_EXTRACTION_FAILED= 1303; 	//Extraction is failed
        public const int  MFS100_E_NOT_GOOD_IMAGE 	=	1304; 	//Input image is not good
        public const int  MFS100_E_SPOOF_FINGER 	=		1305; 	//latent finger found
        public const int  MFS100_E_ALREADY_INITIALIZED =           1306;	//Already Initialized	
        public const int  MFS100_E_NO_DEVICE	=		1307;	//Device Not Found
        public const int  MFS100_E_ALREADY_START_STOP	=	1308;	//Device Already Started or Already Stopped
        public const int  MFS100_E_NOT_INITIALIZED	=	1309;	//Device Not Initialized
        public const int  MFS100_E_OTHER_DEVICE_ERROR	=	1310;	//Other Device Related Error			
        public const int  MFS100_E_ALREADY_UNINITIALIZED    =      1311;	//Already Initialized	
        public const int  MFS100_E_UNHANDLED_EXCEPTIONS    =       1312;	//unhandled Exceptions
        public const int  MFS100_E_NO_SERIAL              =        1313;	//no Serial no in device
        public const int  MFS100_E_CORRUPT_SERIAL        =         1314;	//serial no corrupted
        public const int  MFS100_E_INVALIDPARAM 		=	1315; 	//invalid parameters
        public const int  MFS100_E_LATENT_FINGER 		=	1316; 	//latent finger found
        public const int  MFS100_E_LOAD_FIRMWARE_FAILED	=	1317; 	//load firmware failed

        public const int  MFS100_E_NOFINGERPRINT =			1102; 	//User structure contains no fingerprints (void user).
        public const int  MFS100_E_BLANKIMAGE 	=		1114; 	//Image is blank or contains non-recognizable fingerprint.
        public const int  MFS100_E_BADIMAGE 	=		1115; 	//Invalid image or unsupported image format.
        public const int  MFS100_E_ERROR_FILE	=		1117;	//cannot read/write to file
        public const int  MFS100_E_BADINDEX 	=		1119; 	//Fingerprint index is not valid.
        public const int  MFS100_E_MEMORY 		=	1120; 	//Memory allocation failed.
        public const int  MFS100_E_NULLPARAM 	=		1121; 	//Null input parameter provided
        public const int  MFS100_E_OTHER 		=		1122; 	//Other unspecified error.
        public const int  MFS100_E_NOIMAGE 		=	1123; 	//Image not available.
        public const int  MFS100_E_INTERNAL 	=		1124; 	//Unspecified internal error occurred.
        public const int  MFS100_E_BADLICENSE 	=		1129; 	//License is not valid, or no license was found.
        public const int  MFS100_E_EXPIREDLICENSE= 		1130; 	//License has expired.
        public const int  MFS100_E_MISSINGDLL 	=		1131; 	//At least one required DLL could not be loaded.
        public const int  MFS100_E_BADFORMAT 	=		1132; 	//Unsupported format.
        public const int  MFS100_E_BADVALUE 	=		1133; 	//Invalid value provided.
        public const int  MFS100_E_NOT_IMPLEMENTED	=	1134; 	//Function Not Implemented.
        public const int  MFS100_E_INVALID_TEMPLATE=		1135; 	//Invalid tempalte.
        public const int  MFS100_E_READ_ONLY	=		1136;	//value cannot be modified.
        public const int  MFS100_E_NOT_DEFINED	=		1137;	//value is not defined
        public const int  MFS100_E_NULL_TEMPLATE=		1138;	//tempalte is null

        public static string  PrintErrorMsg(int errorno)
        {
            string mes = "";
            switch (errorno)
            {
                case MFS100_E_LOAD_SCANNER_LIBRARY:
                    mes = "Cannot Load Scanner library\n"; break;
                case MFS100_E_CAPTURE_FAILED:
                    mes = "Capturing is Aborted or Timeout\n"; break;
                case MFS100_E_EXTRACTION_FAILED:
                    mes = "Extraction is Failed\n"; break;
                case MFS100_E_NOT_GOOD_IMAGE:
                    mes = "Input Image is not Good\n"; break;
                case MFS100_E_ALREADY_INITIALIZED:
                    mes = "MFS100 Already Initialized\n"; break;
                case MFS100_E_NO_DEVICE:
                    mes = "MFS100 not Found\n"; break;
                case MFS100_E_ALREADY_START_STOP:
                    mes = "MFS100 already started or already stopped\n"; break;
                case MFS100_E_NOT_INITIALIZED:
                    mes = "MFS100 not initialized\n"; break;
                case MFS100_E_OTHER_DEVICE_ERROR:
                    mes = "MFS100 other device related Error\n"; break;
                case MFS100_E_ALREADY_UNINITIALIZED:
                    mes = "MFS100 already uninitialized\n"; break;
                case MFS100_E_UNHANDLED_EXCEPTIONS:
                    mes = "Some unhandled exceptions\n"; break;
                case MFS100_E_NO_SERIAL:
                    mes = "Device does not have serial No.\n"; break;
                case MFS100_E_CORRUPT_SERIAL:
                    mes = "Serial no is corrupted\n"; break;
                case MFS100_E_INVALIDPARAM:
                    mes = "Invalid Function parameter\n"; break;
                case MFS100_E_LATENT_FINGER:
                    mes = "Latent Finger on device, clean and then initialize\n"; break;
                case MFS100_E_LOAD_FIRMWARE_FAILED:
                    mes = "Firmware cannot load on device, try again or check security setting at udev\n"; break;
                case MFS100_E_NOFINGERPRINT:
                    mes = "User structure contains no fingerprints (void user)\n"; break;
                case MFS100_E_BLANKIMAGE:
                    mes = "Invalid image or unsupported image format\n"; break;
                case MFS100_E_BADIMAGE:
                    mes = "Invalid image or unsupported image format\n"; break;
                case MFS100_E_ERROR_FILE:
                    mes = "cannot read/write to file\n"; break;
                case MFS100_E_BADINDEX:
                    mes = "Fingerprint index is not valid\n"; break;
                case MFS100_E_MEMORY:
                    mes = "Null input parameter provided\n"; break;
                case MFS100_E_OTHER:
                    mes = "Other unspecified Error\n"; break;
                case MFS100_E_NOIMAGE:
                    mes = "Image not available\n"; break;
                case MFS100_E_INTERNAL:
                    mes = "Unspecified internal error occurred\n"; break;
                case MFS100_E_BADLICENSE:
                    mes = "License is not valid, or no license was found\n"; break;
                case MFS100_E_EXPIREDLICENSE:
                    mes = "License has expired\n"; break;
                case MFS100_E_MISSINGDLL:
                    mes = "At least one required DLL could not be loaded\n"; break;
                case MFS100_E_BADFORMAT:
                    mes = "Unsupported format\n"; break;
                case MFS100_E_BADVALUE:
                    mes = "Invalid value provided\n"; break;
                case MFS100_E_NOT_IMPLEMENTED:
                    mes = "Function Not Implemented\n"; break;
                case MFS100_E_INVALID_TEMPLATE:
                    mes = "Invalid Template\n"; break;
                case MFS100_E_READ_ONLY:
                    mes = "value cannot be modified\n"; break;
                case MFS100_E_NOT_DEFINED:
                    mes = "value is not defined\n"; break;
                case MFS100_E_NULL_TEMPLATE:
                    mes = "template is null\n"; break;
            }
            return mes;
        }
    }
}

