using System.Collections.Generic;
namespace IconPacks.Feather
{
	public static class IconKindExtensions
	{
		public static string GetData(this IconKind kind)
		{
			switch (kind)
			{
				case IconKind.Activity:
					return "M22,12 18,12 15,21 9,3 6,12 2,12z";
				case IconKind.Airplay:
					return "M12,15 17,21 7,21 12,15z M5 17 H4 a2 2 0 0 1 -2 -2 V5 a2 2 0 0 1 2 -2 h16 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-1";
				case IconKind.AlertCircle:
					return "M12,16 H 12.01 M12,8 V 12 M2,12a10,10 0 1,0 20,0a10,10 0 1,0 -20,0";
				case IconKind.AlertOctagon:
					return "M12,16 H 12.01 M12,8 V 12 M7.86,2 16.14,2 22,7.86 22,16.14 16.14,22 7.86,22 2,16.14 2,7.86 7.86,2z";
				case IconKind.AlertTriangle:
					return "M12,17 H 12.01 M12,9 V 13 M10.29 3.86 L1.82 18 a2 2 0 0 0 1.71 3 h16.94 a2 2 0 0 0 1.71 -3 L13.71 3.86 a2 2 0 0 0 -3.42 0 z";
				case IconKind.AlignCenter:
					return "M18,18 H 6 M21,14 H 3 M21,6 H 3 M18,10 H 6";
				case IconKind.AlignJustify:
					return "M21,18 H 3 M21,14 H 3 M21,6 H 3 M21,10 H 3";
				case IconKind.AlignLeft:
					return "M17,18 H 3 M21,14 H 3 M21,6 H 3 M17,10 H 3";
				case IconKind.AlignRight:
					return "M21,18 H 7 M21,14 H 3 M21,6 H 3 M21,10 H 7";
				case IconKind.Anchor:
					return "M5 12 H2 a10 10 0 0 0 20 0 h-3 M12,22 V 8 M9,5a3,3 0 1,0 6,0a3,3 0 1,0 -6,0";
				case IconKind.Aperture:
					return "M16.62,12 H 10.88 M14.31,16 H 2.83 M9.69,16 H 3.95 M7.38,12 H 13.12 M9.69,8 H 21.17 M14.31,8 H 20.05 M2,12a10,10 0 1,0 20,0a10,10 0 1,0 -20,0";
				case IconKind.Archive:
					return "M10,12 H 14 M1,3L23,3 23, 8 1,8z M21,8 21,21 3,21 3,8z";
				case IconKind.ArrowDownCircle:
					return "M12,8 V 16 M8,12 12,16 16,12z M2,12a10,10 0 1,0 20,0a10,10 0 1,0 -20,0";
				case IconKind.ArrowDownLeft:
					return "M17,17 7,17 7,7z M17,7 H 7";
				case IconKind.ArrowDownRight:
					return "M17,7 17,17 7,17z M7,7 H 17";
				case IconKind.ArrowDown:
					return "M19,12 12,19 5,12z M12,5 V 19";
				case IconKind.ArrowLeftCircle:
					return "M16,12 H 8 M12,8 8,12 12,16z M2,12a10,10 0 1,0 20,0a10,10 0 1,0 -20,0";
				case IconKind.ArrowLeft:
					return "M12,19 5,12 12,5z M19,12 H 5";
				case IconKind.ArrowRightCircle:
					return "M8,12 H 16 M12,16 16,12 12,8z M2,12a10,10 0 1,0 20,0a10,10 0 1,0 -20,0";
				case IconKind.ArrowRight:
					return "M12,5 19,12 12,19z M5,12 H 19";
				case IconKind.ArrowUpCircle:
					return "M12,16 V 8 M16,12 12,8 8,12z M2,12a10,10 0 1,0 20,0a10,10 0 1,0 -20,0";
				case IconKind.ArrowUpLeft:
					return "M7,17 7,7 17,7z M17,17 H 7";
				case IconKind.ArrowUpRight:
					return "M7,7 17,7 17,17z M7,17 H 17";
				case IconKind.ArrowUp:
					return "M5,12 12,5 19,12z M12,19 V 5";
				case IconKind.AtSign:
					return "M16 8 v5 a3 3 0 0 0 6 0 v-1 a10 10 0 1 0 -3.92 7.94 M8,12a4,4 0 1,0 8,0a4,4 0 1,0 -8,0";
				case IconKind.Award:
					return "M8.21,13.89 7,23 12,20 17,23 15.79,13.88z M5,8a7,7 0 1,0 14,0a7,7 0 1,0 -14,0";
				case IconKind.BarChart2:
					return "M6,20 V 14 M12,20 V 4 M18,20 V 10";
				case IconKind.BarChart:
					return "M6,20 V 16 M18,20 V 4 M12,20 V 10";
				case IconKind.BatteryCharging:
					return "M11,6 7,12 13,12 9,18z M23,13 V 11 M5 18 H3 a2 2 0 0 1 -2 -2 V8 a2 2 0 0 1 2 -2 h3.19 M15 6 h2 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-3.19";
				case IconKind.Battery:
					return "M23,13 V 11 M1,6L19,6 19, 18 1,18z";
				case IconKind.BellOff:
					return "M1,1 H 23 M18 8 a6 6 0 0 0 -9.33 -5 M6.26 6.26 A5.86 5.86 0 0 0 6 8 c0 7 -3 9 -3 9 h14 M18.63 13 A17.89 17.89 0 0 1 18 8 M13.73 21 a2 2 0 0 1 -3.46 0";
				case IconKind.Bell:
					return "M13.73 21 a2 2 0 0 1 -3.46 0 M18 8 A6 6 0 0 0 6 8 c0 7 -3 9 -3 9 h18 s-3 -2 -3 -9";
				case IconKind.Bluetooth:
					return "M6.5,6.5 17.5,17.5 12,23 12,1 17.5,6.5 6.5,17.5z";
				case IconKind.Bold:
					return "M6 12 h9 a4 4 0 0 1 4 4 a4 4 0 0 1 -4 4 H6 z M6 4 h8 a4 4 0 0 1 4 4 a4 4 0 0 1 -4 4 H6 z";
				case IconKind.BookOpen:
					return "M22 3 h-6 a4 4 0 0 0 -4 4 v14 a3 3 0 0 1 3 -3 h7 z M2 3 h6 a4 4 0 0 1 4 4 v14 a3 3 0 0 0 -3 -3 H2 z";
				case IconKind.Book:
					return "M6.5 2 H20 v20 H6.5 A2.5 2.5 0 0 1 4 19.5 v-15 A2.5 2.5 0 0 1 6.5 2 z M4 19.5 A2.5 2.5 0 0 1 6.5 17 H20";
				case IconKind.Bookmark:
					return "M19 21 l-7 -5 l-7 5 V5 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 z";
				case IconKind.Box:
					return "M12,22.08 V 12 M3.27,6.96 12,12.01 20.73,6.96z M21 16 V8 a2 2 0 0 0 -1 -1.73 l-7 -4 a2 2 0 0 0 -2 0 l-7 4 A2 2 0 0 0 3 8 v8 a2 2 0 0 0 1 1.73 l7 4 a2 2 0 0 0 2 0 l7 -4 A2 2 0 0 0 21 16 z";
				case IconKind.Briefcase:
					return "M16 21 V5 a2 2 0 0 0 -2 -2 h-4 a2 2 0 0 0 -2 2 v16 M2,7L22,7 22, 21 2,21z";
				case IconKind.Calendar:
					return "M3,10 H 21 M8,2 V 6 M16,2 V 6 M3,4L21,4 21, 22 3,22z";
				case IconKind.CameraOff:
					return "M21 21 H3 a2 2 0 0 1 -2 -2 V8 a2 2 0 0 1 2 -2 h3 m3 -3 h6 l2 3 h4 a2 2 0 0 1 2 2 v9.34 m-7.72 -2.06 a4 4 0 1 1 -5.56 -5.56 M1,1 H 23";
				case IconKind.Camera:
					return "M8,13a4,4 0 1,0 8,0a4,4 0 1,0 -8,0 M23 19 a2 2 0 0 1 -2 2 H3 a2 2 0 0 1 -2 -2 V8 a2 2 0 0 1 2 -2 h4 l2 -3 h6 l2 3 h4 a2 2 0 0 1 2 2 z";
				case IconKind.Cast:
					return "M2,20 H 2.01 M2 16.1 A5 5 0 0 1 5.9 20 M2 12.05 A9 9 0 0 1 9.95 20 M2 8 V6 a2 2 0 0 1 2 -2 h16 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-6";
				case IconKind.CheckCircle:
					return "M22,4 12,14.01 9,11.01z M22 11.08 V12 a10 10 0 1 1 -5.93 -9.14";
				case IconKind.CheckSquare:
					return "M21 12 v7 a2 2 0 0 1 -2 2 H5 a2 2 0 0 1 -2 -2 V5 a2 2 0 0 1 2 -2 h11 M9,11 12,14 22,4z";
				case IconKind.Check:
					return "M20,6 9,17 4,12z";
				case IconKind.ChevronDown:
					return "M6,9 12,15 18,9z";
				case IconKind.ChevronLeft:
					return "M15,18 9,12 15,6z";
				case IconKind.ChevronRight:
					return "M9,18 15,12 9,6z";
				case IconKind.ChevronUp:
					return "M18,15 12,9 6,15z";
				case IconKind.ChevronsDown:
					return "M7,6 12,11 17,6z M7,13 12,18 17,13z";
				case IconKind.ChevronsLeft:
					return "M18,17 13,12 18,7z M11,17 6,12 11,7z";
				case IconKind.ChevronsRight:
					return "M6,17 11,12 6,7z M13,17 18,12 13,7z";
				case IconKind.ChevronsUp:
					return "M17,18 12,13 7,18z M17,11 12,6 7,11z";
				case IconKind.Chrome:
					return "M10.88,21.94 H 15.46 M3.95,6.06 H 8.54 M21.17,8 H 12 M8,12a4,4 0 1,0 8,0a4,4 0 1,0 -8,0 M2,12a10,10 0 1,0 20,0a10,10 0 1,0 -20,0";
				case IconKind.Circle:
					return "M2,12a10,10 0 1,0 20,0a10,10 0 1,0 -20,0";
				case IconKind.Clipboard:
					return "M8,2L16,2 16, 6 8,6z M16 4 h2 a2 2 0 0 1 2 2 v14 a2 2 0 0 1 -2 2 H6 a2 2 0 0 1 -2 -2 V6 a2 2 0 0 1 2 -2 h2";
				case IconKind.Clock:
					return "M12,6 12,12 16,14z M2,12a10,10 0 1,0 20,0a10,10 0 1,0 -20,0";
				case IconKind.CloudDrizzle:
					return "M20 16.58 A5 5 0 0 0 18 7 h-1.26 A8 8 0 1 0 4 15.25 M12,15 V 17 M12,21 V 23 M16,13 V 15 M16,19 V 21 M8,13 V 15 M8,19 V 21";
				case IconKind.CloudLightning:
					return "M13,11 9,17 15,17 11,23z M19 16.9 A5 5 0 0 0 18 7 h-1.26 a8 8 0 1 0 -11.62 9";
				case IconKind.CloudOff:
					return "M1,1 H 23 M22.61 16.95 A5 5 0 0 0 18 10 h-1.26 a8 8 0 0 0 -7.05 -6 M5 5 a8 8 0 0 0 4 15 h9 a5 5 0 0 0 1.7 -0.3";
				case IconKind.CloudRain:
					return "M20 16.58 A5 5 0 0 0 18 7 h-1.26 A8 8 0 1 0 4 15.25 M12,15 V 23 M8,13 V 21 M16,13 V 21";
				case IconKind.CloudSnow:
					return "M16,20 H 16.01 M16,16 H 16.01 M12,22 H 12.01 M12,18 H 12.01 M8,20 H 8.01 M8,16 H 8.01 M20 17.58 A5 5 0 0 0 18 8 h-1.26 A8 8 0 1 0 4 16.25";
				case IconKind.Cloud:
					return "M18 10 h-1.26 A8 8 0 1 0 9 20 h9 a5 5 0 0 0 0 -10 z";
				case IconKind.Code:
					return "M8,6 2,12 8,18z M16,18 22,12 16,6z";
				case IconKind.Codepen:
					return "M12,2 V 8.5 M2,15.5 12,8.5 22,15.5z M22,8.5 12,15.5 2,8.5z M12,22 V 15.5 M12,2 22,8.5 22,15.5 12,22 2,15.5 2,8.5 12,2z";
				case IconKind.Codesandbox:
					return "M12,22.08 V 12 M3.27,6.96 12,12.01 20.73,6.96z M21,12 16.5,14.6 16.5,19.79z M7.5,19.79 7.5,14.6 3,12z M7.5,4.21 12,6.81 16.5,4.21z M21 16 V8 a2 2 0 0 0 -1 -1.73 l-7 -4 a2 2 0 0 0 -2 0 l-7 4 A2 2 0 0 0 3 8 v8 a2 2 0 0 0 1 1.73 l7 4 a2 2 0 0 0 2 0 l7 -4 A2 2 0 0 0 21 16 z";
				case IconKind.Coffee:
					return "M14,1 V 4 M10,1 V 4 M6,1 V 4 M2 8 h16 v9 a4 4 0 0 1 -4 4 H6 a4 4 0 0 1 -4 -4 V8 z M18 8 h1 a4 4 0 0 1 0 8 h-1";
				case IconKind.Columns:
					return "M12 3 h7 a2 2 0 0 1 2 2 v14 a2 2 0 0 1 -2 2 h-7 m0 -18 H5 a2 2 0 0 0 -2 2 v14 a2 2 0 0 0 2 2 h7 m0 -18 v18";
				case IconKind.Command:
					return "M18 3 a3 3 0 0 0 -3 3 v12 a3 3 0 0 0 3 3 a3 3 0 0 0 3 -3 a3 3 0 0 0 -3 -3 H6 a3 3 0 0 0 -3 3 a3 3 0 0 0 3 3 a3 3 0 0 0 3 -3 V6 a3 3 0 0 0 -3 -3 a3 3 0 0 0 -3 3 a3 3 0 0 0 3 3 h12 a3 3 0 0 0 3 -3 a3 3 0 0 0 -3 -3 z";
				case IconKind.Compass:
					return "M16.24,7.76 14.12,14.12 7.76,16.24 9.88,9.88 16.24,7.76z M2,12a10,10 0 1,0 20,0a10,10 0 1,0 -20,0";
				case IconKind.Copy:
					return "M5 15 H4 a2 2 0 0 1 -2 -2 V4 a2 2 0 0 1 2 -2 h9 a2 2 0 0 1 2 2 v1 M9,9L22,9 22, 22 9,22z";
				case IconKind.CornerDownLeft:
					return "M20 4 v7 a4 4 0 0 1 -4 4 H4 M9,10 4,15 9,20z";
				case IconKind.CornerDownRight:
					return "M4 4 v7 a4 4 0 0 0 4 4 h12 M15,10 20,15 15,20z";
				case IconKind.CornerLeftDown:
					return "M20 4 h-7 a4 4 0 0 0 -4 4 v12 M14,15 9,20 4,15z";
				case IconKind.CornerLeftUp:
					return "M20 20 h-7 a4 4 0 0 1 -4 -4 V4 M14,9 9,4 4,9z";
				case IconKind.CornerRightDown:
					return "M4 4 h7 a4 4 0 0 1 4 4 v12 M10,15 15,20 20,15z";
				case IconKind.CornerRightUp:
					return "M4 20 h7 a4 4 0 0 0 4 -4 V4 M10,9 15,4 20,9z";
				case IconKind.CornerUpLeft:
					return "M20 20 v-7 a4 4 0 0 0 -4 -4 H4 M9,14 4,9 9,4z";
				case IconKind.CornerUpRight:
					return "M4 20 v-7 a4 4 0 0 1 4 -4 h12 M15,14 20,9 15,4z";
				case IconKind.Cpu:
					return "M1,14 H 4 M1,9 H 4 M20,14 H 23 M20,9 H 23 M15,20 V 23 M9,20 V 23 M15,1 V 4 M9,1 V 4 M9,9L15,9 15, 15 9,15z M4,4L20,4 20, 20 4,20z";
				case IconKind.CreditCard:
					return "M1,10 H 23 M1,4L23,4 23, 20 1,20z";
				case IconKind.Crop:
					return "M1 6.13 L16 6 a2 2 0 0 1 2 2 v15 M6.13 1 L6 16 a2 2 0 0 0 2 2 h15";
				case IconKind.Crosshair:
					return "M12,22 V 18 M12,6 V 2 M6,12 H 2 M22,12 H 18 M2,12a10,10 0 1,0 20,0a10,10 0 1,0 -20,0";
				case IconKind.Database:
					return "M3 5 v14 c0 1.66 4 3 9 3 s9 -1.34 9 -3 V5 M21 12 c0 1.66 -4 3 -9 3 s-9 -1.34 -9 -3 M3,5a9,3 0 1,0 18,0a9,3 0 1,0 -18,0";
				case IconKind.Delete:
					return "M12,9 H 18 M18,9 H 12 M21 4 H8 l-7 8 l7 8 h13 a2 2 0 0 0 2 -2 V6 a2 2 0 0 0 -2 -2 z";
				case IconKind.Disc:
					return "M9,12a3,3 0 1,0 6,0a3,3 0 1,0 -6,0 M2,12a10,10 0 1,0 20,0a10,10 0 1,0 -20,0";
				case IconKind.DivideCircle:
					return "M2,12a10,10 0 1,0 20,0a10,10 0 1,0 -20,0 M12,8 V 8 M12,16 V 16 M8,12 H 16";
				case IconKind.DivideSquare:
					return "M12,8 V 8 M12,16 V 16 M8,12 H 16 M3,3L21,3 21, 21 3,21z";
				case IconKind.Divide:
					return "M10,18a2,2 0 1,0 4,0a2,2 0 1,0 -4,0 M5,12 H 19 M10,6a2,2 0 1,0 4,0a2,2 0 1,0 -4,0";
				case IconKind.DollarSign:
					return "M17 5 H9.5 a3.5 3.5 0 0 0 0 7 h5 a3.5 3.5 0 0 1 0 7 H6 M12,1 V 23";
				case IconKind.DownloadCloud:
					return "M20.88 18.09 A5 5 0 0 0 18 9 h-1.26 A8 8 0 1 0 3 16.29 M12,12 V 21 M8,17 12,21 16,17z";
				case IconKind.Download:
					return "M12,15 V 3 M7,10 12,15 17,10z M21 15 v4 a2 2 0 0 1 -2 2 H5 a2 2 0 0 1 -2 -2 v-4";
				case IconKind.Dribbble:
					return "M8.56 2.75 c4.37 6.03 6.02 9.42 8.03 17.72 m2.54 -15.38 c-3.72 4.35 -8.94 5.66 -16.88 5.85 m19.5 1.9 c-3.5 -0.93 -6.63 -0.82 -8.94 0 c-2.58 0.92 -5.01 2.86 -7.44 6.32 M2,12a10,10 0 1,0 20,0a10,10 0 1,0 -20,0";
				case IconKind.Droplet:
					return "M12 2.69 l5.66 5.66 a8 8 0 1 1 -11.31 0 z";
				case IconKind.Edit2:
					return "M17 3 a2.828 2.828 0 1 1 4 4 L7.5 20.5 L2 22 l1.5 -5.5 L17 3 z";
				case IconKind.Edit3:
					return "M16.5 3.5 a2.121 2.121 0 0 1 3 3 L7 19 l-4 1 l1 -4 L16.5 3.5 z M12 20 h9";
				case IconKind.Edit:
					return "M18.5 2.5 a2.121 2.121 0 0 1 3 3 L12 15 l-4 1 l1 -4 l9.5 -9.5 z M11 4 H4 a2 2 0 0 0 -2 2 v14 a2 2 0 0 0 2 2 h14 a2 2 0 0 0 2 -2 v-7";
				case IconKind.ExternalLink:
					return "M10,14 H 21 M15,3 21,3 21,9z M18 13 v6 a2 2 0 0 1 -2 2 H5 a2 2 0 0 1 -2 -2 V8 a2 2 0 0 1 2 -2 h6";
				case IconKind.EyeOff:
					return "M1,1 H 23 M17.94 17.94 A10.07 10.07 0 0 1 12 20 c-7 0 -11 -8 -11 -8 a18.45 18.45 0 0 1 5.06 -5.94 M9.9 4.24 A9.12 9.12 0 0 1 12 4 c7 0 11 8 11 8 a18.5 18.5 0 0 1 -2.16 3.19 m-6.72 -1.07 a3 3 0 1 1 -4.24 -4.24";
				case IconKind.Eye:
					return "M9,12a3,3 0 1,0 6,0a3,3 0 1,0 -6,0 M1 12 s4 -8 11 -8 s11 8 11 8 s-4 8 -11 8 s-11 -8 -11 -8 z";
				case IconKind.Facebook:
					return "M18 2 h-3 a5 5 0 0 0 -5 5 v3 H7 v4 h3 v8 h4 v-8 h3 l1 -4 h-4 V7 a1 1 0 0 1 1 -1 h3 z";
				case IconKind.FastForward:
					return "M2,19 11,12 2,5 2,19z M13,19 22,12 13,5 13,19z";
				case IconKind.Feather:
					return "M17.5,15 H 9 M16,8 H 2 M20.24 12.24 a6 6 0 0 0 -8.49 -8.49 L5 10.5 V19 h8.5 z";
				case IconKind.Figma:
					return "M5 12.5 A3.5 3.5 0 0 1 8.5 9 H12 v7 H8.5 A3.5 3.5 0 0 1 5 12.5 z M5 19.5 A3.5 3.5 0 0 1 8.5 16 H12 v3.5 a3.5 3.5 0 1 1 -7 0 z M12 12.5 a3.5 3.5 0 1 1 7 0 a3.5 3.5 0 1 1 -7 0 z M12 2 h3.5 a3.5 3.5 0 1 1 0 7 H12 V2 z M5 5.5 A3.5 3.5 0 0 1 8.5 2 H12 v7 H8.5 A3.5 3.5 0 0 1 5 5.5 z";
				case IconKind.FileMinus:
					return "M9,15 H 15 M14,2 14,8 20,8z M14 2 H6 a2 2 0 0 0 -2 2 v16 a2 2 0 0 0 2 2 h12 a2 2 0 0 0 2 -2 V8 z";
				case IconKind.FilePlus:
					return "M9,15 H 15 M12,18 V 12 M14,2 14,8 20,8z M14 2 H6 a2 2 0 0 0 -2 2 v16 a2 2 0 0 0 2 2 h12 a2 2 0 0 0 2 -2 V8 z";
				case IconKind.FileText:
					return "M10,9 9,9 8,9z M16,17 H 8 M16,13 H 8 M14,2 14,8 20,8z M14 2 H6 a2 2 0 0 0 -2 2 v16 a2 2 0 0 0 2 2 h12 a2 2 0 0 0 2 -2 V8 z";
				case IconKind.File:
					return "M13,2 13,9 20,9z M13 2 H6 a2 2 0 0 0 -2 2 v16 a2 2 0 0 0 2 2 h12 a2 2 0 0 0 2 -2 V9 z";
				case IconKind.Film:
					return "M17,7 H 22 M17,17 H 22 M2,17 H 7 M2,7 H 7 M2,12 H 22 M17,2 V 22 M7,2 V 22 M2,2L22,2 22, 22 2,22z";
				case IconKind.Filter:
					return "M22,3 2,3 10,12.46 10,19 14,21 14,12.46 22,3z";
				case IconKind.Flag:
					return "M4,22 V 15 M4 15 s1 -1 4 -1 s5 2 8 2 s4 -1 4 -1 V3 s-1 1 -4 1 s-5 -2 -8 -2 s-4 1 -4 1 z";
				case IconKind.FolderMinus:
					return "M9,14 H 15 M22 19 a2 2 0 0 1 -2 2 H4 a2 2 0 0 1 -2 -2 V5 a2 2 0 0 1 2 -2 h5 l2 3 h9 a2 2 0 0 1 2 2 z";
				case IconKind.FolderPlus:
					return "M9,14 H 15 M12,11 V 17 M22 19 a2 2 0 0 1 -2 2 H4 a2 2 0 0 1 -2 -2 V5 a2 2 0 0 1 2 -2 h5 l2 3 h9 a2 2 0 0 1 2 2 z";
				case IconKind.Folder:
					return "M22 19 a2 2 0 0 1 -2 2 H4 a2 2 0 0 1 -2 -2 V5 a2 2 0 0 1 2 -2 h5 l2 3 h9 a2 2 0 0 1 2 2 z";
				case IconKind.Framer:
					return "M5 16 V9 h14 V2 H5 l14 14 h-7 m-7 0 l7 7 v-7 m-7 0 h7";
				case IconKind.Frown:
					return "M15,9 H 15.01 M9,9 H 9.01 M16 16 s-1.5 -2 -4 -2 s-4 2 -4 2 M2,12a10,10 0 1,0 20,0a10,10 0 1,0 -20,0";
				case IconKind.Gift:
					return "M12 7 h4.5 a2.5 2.5 0 0 0 0 -5 C13 2 12 7 12 7 z M12 7 H7.5 a2.5 2.5 0 0 1 0 -5 C11 2 12 7 12 7 z M12,22 V 7 M2,7L22,7 22, 12 2,12z M20,12 20,22 4,22 4,12z";
				case IconKind.GitBranch:
					return "M18 9 a9 9 0 0 1 -9 9 M3,18a3,3 0 1,0 6,0a3,3 0 1,0 -6,0 M15,6a3,3 0 1,0 6,0a3,3 0 1,0 -6,0 M6,3 V 15";
				case IconKind.GitCommit:
					return "M17.01,12 H 22.96 M1.05,12 H 7 M8,12a4,4 0 1,0 8,0a4,4 0 1,0 -8,0";
				case IconKind.GitMerge:
					return "M6 21 V9 a9 9 0 0 0 9 9 M3,6a3,3 0 1,0 6,0a3,3 0 1,0 -6,0 M15,18a3,3 0 1,0 6,0a3,3 0 1,0 -6,0";
				case IconKind.GitPullRequest:
					return "M6,9 V 21 M13 6 h3 a2 2 0 0 1 2 2 v7 M3,6a3,3 0 1,0 6,0a3,3 0 1,0 -6,0 M15,18a3,3 0 1,0 6,0a3,3 0 1,0 -6,0";
				case IconKind.Github:
					return "M9 19 c-5 1.5 -5 -2.5 -7 -3 m14 6 v-3.87 a3.37 3.37 0 0 0 -0.94 -2.61 c3.14 -0.35 6.44 -1.54 6.44 -7 A5.44 5.44 0 0 0 20 4.77 A5.07 5.07 0 0 0 19.91 1 S18.73 0.65 16 2.48 a13.38 13.38 0 0 0 -7 0 C6.27 0.65 5.09 1 5.09 1 A5.07 5.07 0 0 0 5 4.77 a5.44 5.44 0 0 0 -1.5 3.78 c0 5.42 3.3 6.61 6.44 7 A3.37 3.37 0 0 0 9 18.13 V22";
				case IconKind.Gitlab:
					return "M22.65 14.39 L12 22.13 L1.35 14.39 a0.84 0.84 0 0 1 -0.3 -0.94 l1.22 -3.78 l2.44 -7.51 A0.42 0.42 0 0 1 4.82 2 a0.43 0.43 0 0 1 0.58 0 a0.42 0.42 0 0 1 0.11 0.18 l2.44 7.49 h8.1 l2.44 -7.51 A0.42 0.42 0 0 1 18.6 2 a0.43 0.43 0 0 1 0.58 0 a0.42 0.42 0 0 1 0.11 0.18 l2.44 7.51 L23 13.45 a0.84 0.84 0 0 1 -0.35 0.94 z";
				case IconKind.Globe:
					return "M12 2 a15.3 15.3 0 0 1 4 10 a15.3 15.3 0 0 1 -4 10 a15.3 15.3 0 0 1 -4 -10 a15.3 15.3 0 0 1 4 -10 z M2,12 H 22 M2,12a10,10 0 1,0 20,0a10,10 0 1,0 -20,0";
				case IconKind.Grid:
					return "M3,14L10,14 10, 21 3,21z M14,14L21,14 21, 21 14,21z M14,3L21,3 21, 10 14,10z M3,3L10,3 10, 10 3,10z";
				case IconKind.HardDrive:
					return "M10,16 H 10.01 M6,16 H 6.01 M5.45 5.11 L2 12 v6 a2 2 0 0 0 2 2 h16 a2 2 0 0 0 2 -2 v-6 l-3.45 -6.89 A2 2 0 0 0 16.76 4 H7.24 a2 2 0 0 0 -1.79 1.11 z M22,12 H 2";
				case IconKind.Hash:
					return "M16,3 H 14 M10,3 H 8 M4,15 H 20 M4,9 H 20";
				case IconKind.Headphones:
					return "M21 19 a2 2 0 0 1 -2 2 h-1 a2 2 0 0 1 -2 -2 v-3 a2 2 0 0 1 2 -2 h3 z M3 19 a2 2 0 0 0 2 2 h1 a2 2 0 0 0 2 -2 v-3 a2 2 0 0 0 -2 -2 H3 z M3 18 v-6 a9 9 0 0 1 18 0 v6";
				case IconKind.Heart:
					return "M20.84 4.61 a5.5 5.5 0 0 0 -7.78 0 L12 5.67 l-1.06 -1.06 a5.5 5.5 0 0 0 -7.78 7.78 l1.06 1.06 L12 21.23 l7.78 -7.78 l1.06 -1.06 a5.5 5.5 0 0 0 0 -7.78 z";
				case IconKind.HelpCircle:
					return "M12,17 H 12.01 M9.09 9 a3 3 0 0 1 5.83 1 c0 2 -3 3 -3 3 M2,12a10,10 0 1,0 20,0a10,10 0 1,0 -20,0";
				case IconKind.Hexagon:
					return "M21 16 V8 a2 2 0 0 0 -1 -1.73 l-7 -4 a2 2 0 0 0 -2 0 l-7 4 A2 2 0 0 0 3 8 v8 a2 2 0 0 0 1 1.73 l7 4 a2 2 0 0 0 2 0 l7 -4 A2 2 0 0 0 21 16 z";
				case IconKind.Home:
					return "M9,22 9,12 15,12 15,22z M3 9 l9 -7 l9 7 v11 a2 2 0 0 1 -2 2 H5 a2 2 0 0 1 -2 -2 z";
				case IconKind.Image:
					return "M21,15 16,10 5,21z M7,8.5a1.5,1.5 0 1,0 3,0a1.5,1.5 0 1,0 -3,0 M3,3L21,3 21, 21 3,21z";
				case IconKind.Inbox:
					return "M5.45 5.11 L2 12 v6 a2 2 0 0 0 2 2 h16 a2 2 0 0 0 2 -2 v-6 l-3.45 -6.89 A2 2 0 0 0 16.76 4 H7.24 a2 2 0 0 0 -1.79 1.11 z M22,12 16,12 14,15 10,15 8,12 2,12z";
				case IconKind.Info:
					return "M12,8 H 12.01 M12,16 V 12 M2,12a10,10 0 1,0 20,0a10,10 0 1,0 -20,0";
				case IconKind.Instagram:
					return "M17.5,6.5 H 17.51 M16 11.37 A4 4 0 1 1 12.63 8 A4 4 0 0 1 16 11.37 z M2,2L22,2 22, 22 2,22z";
				case IconKind.Italic:
					return "M15,4 H 9 M14,20 H 5 M19,4 H 10";
				case IconKind.Key:
					return "M21 2 l-2 2 m-7.61 7.61 a5.5 5.5 0 1 1 -7.778 7.778 a5.5 5.5 0 0 1 7.777 -7.777 z m0 0 L15.5 7.5 m0 0 l3 3 L22 7 l-3 -3 m-3.5 3.5 L19 4";
				case IconKind.Layers:
					return "M2,12 12,17 22,12z M2,17 12,22 22,17z M12,2 2,7 12,12 22,7 12,2z";
				case IconKind.Layout:
					return "M9,21 V 9 M3,9 H 21 M3,3L21,3 21, 21 3,21z";
				case IconKind.LifeBuoy:
					return "M4.93,19.07 H 9.17 M14.83,9.17 H 18.36 M14.83,9.17 H 19.07 M14.83,14.83 H 19.07 M4.93,4.93 H 9.17 M8,12a4,4 0 1,0 8,0a4,4 0 1,0 -8,0 M2,12a10,10 0 1,0 20,0a10,10 0 1,0 -20,0";
				case IconKind.Link2:
					return "M8,12 H 16 M15 7 h3 a5 5 0 0 1 5 5 a5 5 0 0 1 -5 5 h-3 m-6 0 H6 a5 5 0 0 1 -5 -5 a5 5 0 0 1 5 -5 h3";
				case IconKind.Link:
					return "M14 11 a5 5 0 0 0 -7.54 -0.54 l-3 3 a5 5 0 0 0 7.07 7.07 l1.71 -1.71 M10 13 a5 5 0 0 0 7.54 0.54 l3 -3 a5 5 0 0 0 -7.07 -7.07 l-1.72 1.71";
				case IconKind.Linkedin:
					return "M2,4a2,2 0 1,0 4,0a2,2 0 1,0 -4,0 M2,9L6,9 6, 21 2,21z M16 8 a6 6 0 0 1 6 6 v7 h-4 v-7 a2 2 0 0 0 -2 -2 a2 2 0 0 0 -2 2 v7 h-4 v-7 a6 6 0 0 1 6 -6 z";
				case IconKind.List:
					return "M3,18 H 3.01 M3,12 H 3.01 M3,6 H 3.01 M8,18 H 21 M8,12 H 21 M8,6 H 21";
				case IconKind.Loader:
					return "M16.24,7.76 H 19.07 M4.93,19.07 H 7.76 M18,12 H 22 M2,12 H 6 M16.24,16.24 H 19.07 M4.93,4.93 H 7.76 M12,18 V 22 M12,2 V 6";
				case IconKind.Lock:
					return "M7 11 V7 a5 5 0 0 1 10 0 v4 M3,11L21,11 21, 22 3,22z";
				case IconKind.LogIn:
					return "M15,12 H 3 M10,17 15,12 10,7z M15 3 h4 a2 2 0 0 1 2 2 v14 a2 2 0 0 1 -2 2 h-4";
				case IconKind.LogOut:
					return "M21,12 H 9 M16,17 21,12 16,7z M9 21 H5 a2 2 0 0 1 -2 -2 V5 a2 2 0 0 1 2 -2 h4";
				case IconKind.Mail:
					return "M22,6 12,13 2,6z M4 4 h16 c1.1 0 2 0.9 2 2 v12 c0 1.1 -0.9 2 -2 2 H4 c-1.1 0 -2 -0.9 -2 -2 V6 c0 -1.1 0.9 -2 2 -2 z";
				case IconKind.MapPin:
					return "M9,10a3,3 0 1,0 6,0a3,3 0 1,0 -6,0 M21 10 c0 7 -9 13 -9 13 s-9 -6 -9 -13 a9 9 0 0 1 18 0 z";
				case IconKind.Map:
					return "M16,6 V 22 M8,2 V 18 M1,6 1,22 8,18 16,22 23,18 23,2 16,6 8,2 1,6z";
				case IconKind.Maximize2:
					return "M3,21 H 10 M21,3 H 14 M9,21 3,21 3,15z M15,3 21,3 21,9z";
				case IconKind.Maximize:
					return "M8 3 H5 a2 2 0 0 0 -2 2 v3 m18 0 V5 a2 2 0 0 0 -2 -2 h-3 m0 18 h3 a2 2 0 0 0 2 -2 v-3 M3 16 v3 a2 2 0 0 0 2 2 h3";
				case IconKind.Meh:
					return "M15,9 H 15.01 M9,9 H 9.01 M8,15 H 16 M2,12a10,10 0 1,0 20,0a10,10 0 1,0 -20,0";
				case IconKind.Menu:
					return "M3,18 H 21 M3,6 H 21 M3,12 H 21";
				case IconKind.MessageCircle:
					return "M21 11.5 a8.38 8.38 0 0 1 -0.9 3.8 a8.5 8.5 0 0 1 -7.6 4.7 a8.38 8.38 0 0 1 -3.8 -0.9 L3 21 l1.9 -5.7 a8.38 8.38 0 0 1 -0.9 -3.8 a8.5 8.5 0 0 1 4.7 -7.6 a8.38 8.38 0 0 1 3.8 -0.9 h0.5 a8.48 8.48 0 0 1 8 8 v0.5 z";
				case IconKind.MessageSquare:
					return "M21 15 a2 2 0 0 1 -2 2 H7 l-4 4 V5 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 z";
				case IconKind.MicOff:
					return "M8,23 H 16 M12,19 V 23 M17 16.95 A7 7 0 0 1 5 12 v-2 m14 0 v2 a7 7 0 0 1 -0.11 1.23 M9 9 v3 a3 3 0 0 0 5.12 2.12 M15 9.34 V4 a3 3 0 0 0 -5.94 -0.6 M1,1 H 23";
				case IconKind.Mic:
					return "M8,23 H 16 M12,19 V 23 M19 10 v2 a7 7 0 0 1 -14 0 v-2 M12 1 a3 3 0 0 0 -3 3 v8 a3 3 0 0 0 6 0 V4 a3 3 0 0 0 -3 -3 z";
				case IconKind.Minimize2:
					return "M3,21 H 10 M14,10 H 21 M20,10 14,10 14,4z M4,14 10,14 10,20z";
				case IconKind.Minimize:
					return "M8 3 v3 a2 2 0 0 1 -2 2 H3 m18 0 h-3 a2 2 0 0 1 -2 -2 V3 m0 18 v-3 a2 2 0 0 1 2 -2 h3 M3 16 h3 a2 2 0 0 1 2 2 v3";
				case IconKind.MinusCircle:
					return "M8,12 H 16 M2,12a10,10 0 1,0 20,0a10,10 0 1,0 -20,0";
				case IconKind.MinusSquare:
					return "M8,12 H 16 M3,3L21,3 21, 21 3,21z";
				case IconKind.Minus:
					return "M5,12 H 19";
				case IconKind.Monitor:
					return "M12,17 V 21 M8,21 H 16 M2,3L22,3 22, 17 2,17z";
				case IconKind.Moon:
					return "M21 12.79 A9 9 0 1 1 11.21 3 A7 7 0 0 0 21 12.79 z";
				case IconKind.MoreHorizontal:
					return "M4,12a1,1 0 1,0 2,0a1,1 0 1,0 -2,0 M18,12a1,1 0 1,0 2,0a1,1 0 1,0 -2,0 M11,12a1,1 0 1,0 2,0a1,1 0 1,0 -2,0";
				case IconKind.MoreVertical:
					return "M11,19a1,1 0 1,0 2,0a1,1 0 1,0 -2,0 M11,5a1,1 0 1,0 2,0a1,1 0 1,0 -2,0 M11,12a1,1 0 1,0 2,0a1,1 0 1,0 -2,0";
				case IconKind.MousePointer:
					return "M13 13 l6 6 M3 3 l7.07 16.97 l2.51 -7.39 l7.39 -2.51 L3 3 z";
				case IconKind.Move:
					return "M12,2 V 22 M2,12 H 22 M19,9 22,12 19,15z M15,19 12,22 9,19z M9,5 12,2 15,5z M5,9 2,12 5,15z";
				case IconKind.Music:
					return "M15,16a3,3 0 1,0 6,0a3,3 0 1,0 -6,0 M3,18a3,3 0 1,0 6,0a3,3 0 1,0 -6,0 M9 18 V5 l12 -2 v13";
				case IconKind.Navigation2:
					return "M12,2 19,21 12,17 5,21 12,2z";
				case IconKind.Navigation:
					return "M3,11 22,2 13,21 11,13 3,11z";
				case IconKind.Octagon:
					return "M7.86,2 16.14,2 22,7.86 22,16.14 16.14,22 7.86,22 2,16.14 2,7.86 7.86,2z";
				case IconKind.Package:
					return "M12,22.08 V 12 M3.27,6.96 12,12.01 20.73,6.96z M21 16 V8 a2 2 0 0 0 -1 -1.73 l-7 -4 a2 2 0 0 0 -2 0 l-7 4 A2 2 0 0 0 3 8 v8 a2 2 0 0 0 1 1.73 l7 4 a2 2 0 0 0 2 0 l7 -4 A2 2 0 0 0 21 16 z M16.5,9.4 H 7.5";
				case IconKind.Paperclip:
					return "M21.44 11.05 l-9.19 9.19 a6 6 0 0 1 -8.49 -8.49 l9.19 -9.19 a4 4 0 0 1 5.66 5.66 l-9.2 9.19 a2 2 0 0 1 -2.83 -2.83 l8.49 -8.48";
				case IconKind.PauseCircle:
					return "M14,15 V 9 M10,15 V 9 M2,12a10,10 0 1,0 20,0a10,10 0 1,0 -20,0";
				case IconKind.Pause:
					return "M14,4L18,4 18, 20 14,20z M6,4L10,4 10, 20 6,20z";
				case IconKind.PenTool:
					return "M9,11a2,2 0 1,0 4,0a2,2 0 1,0 -4,0 M2 2 l7.586 7.586 M18 13 l-1.5 -7.5 L2 2 l3.5 14.5 L13 18 l5 -5 z M12 19 l7 -7 l3 3 l-7 7 l-3 -3 z";
				case IconKind.Percent:
					return "M15,17.5a2.5,2.5 0 1,0 5,0a2.5,2.5 0 1,0 -5,0 M4,6.5a2.5,2.5 0 1,0 5,0a2.5,2.5 0 1,0 -5,0 M19,5 H 5";
				case IconKind.PhoneCall:
					return "M15.05 5 A5 5 0 0 1 19 8.95 M15.05 1 A9 9 0 0 1 23 8.94 m-1 7.98 v3 a2 2 0 0 1 -2.18 2 a19.79 19.79 0 0 1 -8.63 -3.07 a19.5 19.5 0 0 1 -6 -6 a19.79 19.79 0 0 1 -3.07 -8.67 A2 2 0 0 1 4.11 2 h3 a2 2 0 0 1 2 1.72 a12.84 12.84 0 0 0 0.7 2.81 a2 2 0 0 1 -0.45 2.11 L8.09 9.91 a16 16 0 0 0 6 6 l1.27 -1.27 a2 2 0 0 1 2.11 -0.45 a12.84 12.84 0 0 0 2.81 0.7 A2 2 0 0 1 22 16.92 z";
				case IconKind.PhoneForwarded:
					return "M22 16.92 v3 a2 2 0 0 1 -2.18 2 a19.79 19.79 0 0 1 -8.63 -3.07 a19.5 19.5 0 0 1 -6 -6 a19.79 19.79 0 0 1 -3.07 -8.67 A2 2 0 0 1 4.11 2 h3 a2 2 0 0 1 2 1.72 a12.84 12.84 0 0 0 0.7 2.81 a2 2 0 0 1 -0.45 2.11 L8.09 9.91 a16 16 0 0 0 6 6 l1.27 -1.27 a2 2 0 0 1 2.11 -0.45 a12.84 12.84 0 0 0 2.81 0.7 A2 2 0 0 1 22 16.92 z M15,5 H 23 M19,1 23,5 19,9z";
				case IconKind.PhoneIncoming:
					return "M22 16.92 v3 a2 2 0 0 1 -2.18 2 a19.79 19.79 0 0 1 -8.63 -3.07 a19.5 19.5 0 0 1 -6 -6 a19.79 19.79 0 0 1 -3.07 -8.67 A2 2 0 0 1 4.11 2 h3 a2 2 0 0 1 2 1.72 a12.84 12.84 0 0 0 0.7 2.81 a2 2 0 0 1 -0.45 2.11 L8.09 9.91 a16 16 0 0 0 6 6 l1.27 -1.27 a2 2 0 0 1 2.11 -0.45 a12.84 12.84 0 0 0 2.81 0.7 A2 2 0 0 1 22 16.92 z M23,1 H 16 M16,2 16,8 22,8z";
				case IconKind.PhoneMissed:
					return "M22 16.92 v3 a2 2 0 0 1 -2.18 2 a19.79 19.79 0 0 1 -8.63 -3.07 a19.5 19.5 0 0 1 -6 -6 a19.79 19.79 0 0 1 -3.07 -8.67 A2 2 0 0 1 4.11 2 h3 a2 2 0 0 1 2 1.72 a12.84 12.84 0 0 0 0.7 2.81 a2 2 0 0 1 -0.45 2.11 L8.09 9.91 a16 16 0 0 0 6 6 l1.27 -1.27 a2 2 0 0 1 2.11 -0.45 a12.84 12.84 0 0 0 2.81 0.7 A2 2 0 0 1 22 16.92 z M17,1 H 23 M23,1 H 17";
				case IconKind.PhoneOff:
					return "M23,1 H 1 M10.68 13.31 a16 16 0 0 0 3.41 2.6 l1.27 -1.27 a2 2 0 0 1 2.11 -0.45 a12.84 12.84 0 0 0 2.81 0.7 a2 2 0 0 1 1.72 2 v3 a2 2 0 0 1 -2.18 2 a19.79 19.79 0 0 1 -8.63 -3.07 a19.42 19.42 0 0 1 -3.33 -2.67 m-2.67 -3.34 a19.79 19.79 0 0 1 -3.07 -8.63 A2 2 0 0 1 4.11 2 h3 a2 2 0 0 1 2 1.72 a12.84 12.84 0 0 0 0.7 2.81 a2 2 0 0 1 -0.45 2.11 L8.09 9.91";
				case IconKind.PhoneOutgoing:
					return "M22 16.92 v3 a2 2 0 0 1 -2.18 2 a19.79 19.79 0 0 1 -8.63 -3.07 a19.5 19.5 0 0 1 -6 -6 a19.79 19.79 0 0 1 -3.07 -8.67 A2 2 0 0 1 4.11 2 h3 a2 2 0 0 1 2 1.72 a12.84 12.84 0 0 0 0.7 2.81 a2 2 0 0 1 -0.45 2.11 L8.09 9.91 a16 16 0 0 0 6 6 l1.27 -1.27 a2 2 0 0 1 2.11 -0.45 a12.84 12.84 0 0 0 2.81 0.7 A2 2 0 0 1 22 16.92 z M16,8 H 23 M23,7 23,1 17,1z";
				case IconKind.Phone:
					return "M22 16.92 v3 a2 2 0 0 1 -2.18 2 a19.79 19.79 0 0 1 -8.63 -3.07 a19.5 19.5 0 0 1 -6 -6 a19.79 19.79 0 0 1 -3.07 -8.67 A2 2 0 0 1 4.11 2 h3 a2 2 0 0 1 2 1.72 a12.84 12.84 0 0 0 0.7 2.81 a2 2 0 0 1 -0.45 2.11 L8.09 9.91 a16 16 0 0 0 6 6 l1.27 -1.27 a2 2 0 0 1 2.11 -0.45 a12.84 12.84 0 0 0 2.81 0.7 A2 2 0 0 1 22 16.92 z";
				case IconKind.PieChart:
					return "M22 12 A10 10 0 0 0 12 2 v10 z M21.21 15.89 A10 10 0 1 1 8 2.83";
				case IconKind.PlayCircle:
					return "M10,8 16,12 10,16 10,8z M2,12a10,10 0 1,0 20,0a10,10 0 1,0 -20,0";
				case IconKind.Play:
					return "M5,3 19,12 5,21 5,3z";
				case IconKind.PlusCircle:
					return "M8,12 H 16 M12,8 V 16 M2,12a10,10 0 1,0 20,0a10,10 0 1,0 -20,0";
				case IconKind.PlusSquare:
					return "M8,12 H 16 M12,8 V 16 M3,3L21,3 21, 21 3,21z";
				case IconKind.Plus:
					return "M5,12 H 19 M12,5 V 19";
				case IconKind.Pocket:
					return "M8,10 12,14 16,10z M4 3 h16 a2 2 0 0 1 2 2 v6 a10 10 0 0 1 -10 10 A10 10 0 0 1 2 11 V5 a2 2 0 0 1 2 -2 z";
				case IconKind.Power:
					return "M12,2 V 12 M18.36 6.64 a9 9 0 1 1 -12.73 0";
				case IconKind.Printer:
					return "M6,14L18,14 18, 22 6,22z M6 18 H4 a2 2 0 0 1 -2 -2 v-5 a2 2 0 0 1 2 -2 h16 a2 2 0 0 1 2 2 v5 a2 2 0 0 1 -2 2 h-2 M6,9 6,2 18,2 18,9z";
				case IconKind.Radio:
					return "M16.24 7.76 a6 6 0 0 1 0 8.49 m-8.48 -0.01 a6 6 0 0 1 0 -8.49 m11.31 -2.82 a10 10 0 0 1 0 14.14 m-14.14 0 a10 10 0 0 1 0 -14.14 M10,12a2,2 0 1,0 4,0a2,2 0 1,0 -4,0";
				case IconKind.RefreshCcw:
					return "M20.49 9 A9 9 0 0 0 5.64 5.64 L1 10 m22 4 l-4.64 4.36 A9 9 0 0 1 3.51 15 M23,20 23,14 17,14z M1,4 1,10 7,10z";
				case IconKind.RefreshCw:
					return "M3.51 9 a9 9 0 0 1 14.85 -3.36 L23 10 M1 14 l4.64 4.36 A9 9 0 0 0 20.49 15 M1,20 1,14 7,14z M23,4 23,10 17,10z";
				case IconKind.Repeat:
					return "M21 13 v2 a4 4 0 0 1 -4 4 H3 M7,23 3,19 7,15z M3 11 V9 a4 4 0 0 1 4 -4 h14 M17,1 21,5 17,9z";
				case IconKind.Rewind:
					return "M22,19 13,12 22,5 22,19z M11,19 2,12 11,5 11,19z";
				case IconKind.RotateCcw:
					return "M3.51 15 a9 9 0 1 0 2.13 -9.36 L1 10 M1,4 1,10 7,10z";
				case IconKind.RotateCw:
					return "M20.49 15 a9 9 0 1 1 -2.12 -9.36 L23 10 M23,4 23,10 17,10z";
				case IconKind.Rss:
					return "M4,19a1,1 0 1,0 2,0a1,1 0 1,0 -2,0 M4 4 a16 16 0 0 1 16 16 M4 11 a9 9 0 0 1 9 9";
				case IconKind.Save:
					return "M7,3 7,8 15,8z M17,21 17,13 7,13 7,21z M19 21 H5 a2 2 0 0 1 -2 -2 V5 a2 2 0 0 1 2 -2 h11 l5 5 v11 a2 2 0 0 1 -2 2 z";
				case IconKind.Scissors:
					return "M8.12,8.12 H 12 M14.47,14.48 H 20 M20,4 H 8.12 M3,18a3,3 0 1,0 6,0a3,3 0 1,0 -6,0 M3,6a3,3 0 1,0 6,0a3,3 0 1,0 -6,0";
				case IconKind.Search:
					return "M21,21 H 16.65 M3,11a8,8 0 1,0 16,0a8,8 0 1,0 -16,0";
				case IconKind.Send:
					return "M22,2 15,22 11,13 2,9 22,2z M22,2 H 11";
				case IconKind.Server:
					return "M6,18 H 6.01 M6,6 H 6.01 M2,14L22,14 22, 22 2,22z M2,2L22,2 22, 10 2,10z";
				case IconKind.Settings:
					return "M19.4 15 a1.65 1.65 0 0 0 0.33 1.82 l0.06 0.06 a2 2 0 0 1 0 2.83 a2 2 0 0 1 -2.83 0 l-0.06 -0.06 a1.65 1.65 0 0 0 -1.82 -0.33 a1.65 1.65 0 0 0 -1 1.51 V21 a2 2 0 0 1 -2 2 a2 2 0 0 1 -2 -2 v-0.09 A1.65 1.65 0 0 0 9 19.4 a1.65 1.65 0 0 0 -1.82 0.33 l-0.06 0.06 a2 2 0 0 1 -2.83 0 a2 2 0 0 1 0 -2.83 l0.06 -0.06 a1.65 1.65 0 0 0 0.33 -1.82 a1.65 1.65 0 0 0 -1.51 -1 H3 a2 2 0 0 1 -2 -2 a2 2 0 0 1 2 -2 h0.09 A1.65 1.65 0 0 0 4.6 9 a1.65 1.65 0 0 0 -0.33 -1.82 l-0.06 -0.06 a2 2 0 0 1 0 -2.83 a2 2 0 0 1 2.83 0 l0.06 0.06 a1.65 1.65 0 0 0 1.82 0.33 H9 a1.65 1.65 0 0 0 1 -1.51 V3 a2 2 0 0 1 2 -2 a2 2 0 0 1 2 2 v0.09 a1.65 1.65 0 0 0 1 1.51 a1.65 1.65 0 0 0 1.82 -0.33 l0.06 -0.06 a2 2 0 0 1 2.83 0 a2 2 0 0 1 0 2.83 l-0.06 0.06 a1.65 1.65 0 0 0 -0.33 1.82 V9 a1.65 1.65 0 0 0 1.51 1 H21 a2 2 0 0 1 2 2 a2 2 0 0 1 -2 2 h-0.09 a1.65 1.65 0 0 0 -1.51 1 z M9,12a3,3 0 1,0 6,0a3,3 0 1,0 -6,0";
				case IconKind.Share2:
					return "M15.41,6.51 H 8.59 M8.59,13.51 H 15.42 M15,19a3,3 0 1,0 6,0a3,3 0 1,0 -6,0 M3,12a3,3 0 1,0 6,0a3,3 0 1,0 -6,0 M15,5a3,3 0 1,0 6,0a3,3 0 1,0 -6,0";
				case IconKind.Share:
					return "M12,2 V 15 M16,6 12,2 8,6z M4 12 v8 a2 2 0 0 0 2 2 h12 a2 2 0 0 0 2 -2 v-8";
				case IconKind.ShieldOff:
					return "M1,1 H 23 M4.73 4.73 L4 5 v7 c0 6 8 10 8 10 a20.29 20.29 0 0 0 5.62 -4.38 M19.69 14 a6.9 6.9 0 0 0 0.31 -2 V5 l-8 -3 l-3.16 1.18";
				case IconKind.Shield:
					return "M12 22 s8 -4 8 -10 V5 l-8 -3 l-8 3 v7 c0 6 8 10 8 10 z";
				case IconKind.ShoppingBag:
					return "M16 10 a4 4 0 0 1 -8 0 M3,6 H 21 M6 2 L3 6 v14 a2 2 0 0 0 2 2 h14 a2 2 0 0 0 2 -2 V6 l-3 -4 z";
				case IconKind.ShoppingCart:
					return "M1 1 h4 l2.68 13.39 a2 2 0 0 0 2 1.61 h9.72 a2 2 0 0 0 2 -1.61 L23 6 H6 M19,21a1,1 0 1,0 2,0a1,1 0 1,0 -2,0 M8,21a1,1 0 1,0 2,0a1,1 0 1,0 -2,0";
				case IconKind.Shuffle:
					return "M4,4 H 9 M15,15 H 21 M21,16 21,21 16,21z M4,20 H 21 M16,3 21,3 21,8z";
				case IconKind.Sidebar:
					return "M9,3 V 21 M3,3L21,3 21, 21 3,21z";
				case IconKind.SkipBack:
					return "M5,19 V 5 M19,20 9,12 19,4 19,20z";
				case IconKind.SkipForward:
					return "M19,5 V 19 M5,4 15,12 5,20 5,4z";
				case IconKind.Slack:
					return "M8.5 5 H10 V3.5 C10 2.67 9.33 2 8.5 2 S7 2.67 7 3.5 S7.67 5 8.5 5 z M10 9.5 C10 8.67 9.33 8 8.5 8 h-5 C2.67 8 2 8.67 2 9.5 S2.67 11 3.5 11 h5 c0.83 0 1.5 -0.67 1.5 -1.5 z M15.5 19 H14 v1.5 c0 0.83 0.67 1.5 1.5 1.5 s1.5 -0.67 1.5 -1.5 s-0.67 -1.5 -1.5 -1.5 z M14 14.5 c0 -0.83 0.67 -1.5 1.5 -1.5 h5 c0.83 0 1.5 0.67 1.5 1.5 s-0.67 1.5 -1.5 1.5 h-5 c-0.83 0 -1.5 -0.67 -1.5 -1.5 z M3.5 14 H5 v1.5 c0 0.83 -0.67 1.5 -1.5 1.5 S2 16.33 2 15.5 S2.67 14 3.5 14 z M9.5 14 c0.83 0 1.5 0.67 1.5 1.5 v5 c0 0.83 -0.67 1.5 -1.5 1.5 S8 21.33 8 20.5 v-5 c0 -0.83 0.67 -1.5 1.5 -1.5 z M20.5 10 H19 V8.5 c0 -0.83 0.67 -1.5 1.5 -1.5 s1.5 0.67 1.5 1.5 s-0.67 1.5 -1.5 1.5 z M14.5 10 c-0.83 0 -1.5 -0.67 -1.5 -1.5 v-5 c0 -0.83 0.67 -1.5 1.5 -1.5 s1.5 0.67 1.5 1.5 v5 c0 0.83 -0.67 1.5 -1.5 1.5 z";
				case IconKind.Slash:
					return "M4.93,4.93 H 19.07 M2,12a10,10 0 1,0 20,0a10,10 0 1,0 -20,0";
				case IconKind.Sliders:
					return "M17,16 H 23 M9,8 H 15 M1,14 H 7 M20,12 V 3 M20,21 V 16 M12,8 V 3 M12,21 V 12 M4,10 V 3 M4,21 V 14";
				case IconKind.Smartphone:
					return "M12,18 H 12.01 M5,2L19,2 19, 22 5,22z";
				case IconKind.Smile:
					return "M15,9 H 15.01 M9,9 H 9.01 M8 14 s1.5 2 4 2 s4 -2 4 -2 M2,12a10,10 0 1,0 20,0a10,10 0 1,0 -20,0";
				case IconKind.Speaker:
					return "M12,6 H 12.01 M8,14a4,4 0 1,0 8,0a4,4 0 1,0 -8,0 M4,2L20,2 20, 22 4,22z";
				case IconKind.Square:
					return "M3,3L21,3 21, 21 3,21z";
				case IconKind.Star:
					return "M12,2 15.09,8.26 22,9.27 17,14.14 18.18,21.02 12,17.77 5.82,21.02 7,14.14 2,9.27 8.91,8.26 12,2z";
				case IconKind.StopCircle:
					return "M9,9L15,9 15, 15 9,15z M2,12a10,10 0 1,0 20,0a10,10 0 1,0 -20,0";
				case IconKind.Sun:
					return "M18.36,5.64 H 19.78 M4.22,19.78 H 5.64 M21,12 H 23 M1,12 H 3 M18.36,18.36 H 19.78 M4.22,4.22 H 5.64 M12,21 V 23 M12,1 V 3 M7,12a5,5 0 1,0 10,0a5,5 0 1,0 -10,0";
				case IconKind.Sunrise:
					return "M8,6 12,2 16,6z M23,22 H 1 M18.36,11.64 H 19.78 M21,18 H 23 M1,18 H 3 M4.22,10.22 H 5.64 M12,2 V 9 M17 18 a5 5 0 0 0 -10 0";
				case IconKind.Sunset:
					return "M16,5 12,9 8,5z M23,22 H 1 M18.36,11.64 H 19.78 M21,18 H 23 M1,18 H 3 M4.22,10.22 H 5.64 M12,9 V 2 M17 18 a5 5 0 0 0 -10 0";
				case IconKind.Table:
					return "M9 3 H5 a2 2 0 0 0 -2 2 v4 m6 -6 h10 a2 2 0 0 1 2 2 v4 M9 3 v18 m0 0 h10 a2 2 0 0 0 2 -2 V9 M9 21 H5 a2 2 0 0 1 -2 -2 V9 m0 0 h18";
				case IconKind.Tablet:
					return "M12,18 H 12.01 M4,2L20,2 20, 22 4,22z";
				case IconKind.Tag:
					return "M7,7 H 7.01 M20.59 13.41 l-7.17 7.17 a2 2 0 0 1 -2.83 0 L2 12 V2 h10 l8.59 8.59 a2 2 0 0 1 0 2.82 z";
				case IconKind.Target:
					return "M10,12a2,2 0 1,0 4,0a2,2 0 1,0 -4,0 M6,12a6,6 0 1,0 12,0a6,6 0 1,0 -12,0 M2,12a10,10 0 1,0 20,0a10,10 0 1,0 -20,0";
				case IconKind.Terminal:
					return "M12,19 H 20 M4,17 10,11 4,5z";
				case IconKind.Thermometer:
					return "M14 14.76 V3.5 a2.5 2.5 0 0 0 -5 0 v11.26 a4.5 4.5 0 1 0 5 0 z";
				case IconKind.ThumbsDown:
					return "M10 15 v4 a3 3 0 0 0 3 3 l4 -9 V2 H5.72 a2 2 0 0 0 -2 1.7 l-1.38 9 a2 2 0 0 0 2 2.3 z m7 -13 h2.67 A2.31 2.31 0 0 1 22 4 v7 a2.31 2.31 0 0 1 -2.33 2 H17";
				case IconKind.ThumbsUp:
					return "M14 9 V5 a3 3 0 0 0 -3 -3 l-4 9 v11 h11.28 a2 2 0 0 0 2 -1.7 l1.38 -9 a2 2 0 0 0 -2 -2.3 z M7 22 H4 a2 2 0 0 1 -2 -2 v-7 a2 2 0 0 1 2 -2 h3";
				case IconKind.ToggleLeft:
					return "M5,12a3,3 0 1,0 6,0a3,3 0 1,0 -6,0 M1,5L23,5 23, 19 1,19z";
				case IconKind.ToggleRight:
					return "M13,12a3,3 0 1,0 6,0a3,3 0 1,0 -6,0 M1,5L23,5 23, 19 1,19z";
				case IconKind.Tool:
					return "M14.7 6.3 a1 1 0 0 0 0 1.4 l1.6 1.6 a1 1 0 0 0 1.4 0 l3.77 -3.77 a6 6 0 0 1 -7.94 7.94 l-6.91 6.91 a2.12 2.12 0 0 1 -3 -3 l6.91 -6.91 a6 6 0 0 1 7.94 -7.94 l-3.76 3.76 z";
				case IconKind.Trash2:
					return "M14,11 V 17 M10,11 V 17 M19 6 v14 a2 2 0 0 1 -2 2 H7 a2 2 0 0 1 -2 -2 V6 m3 0 V4 a2 2 0 0 1 2 -2 h4 a2 2 0 0 1 2 2 v2 M3,6 5,6 21,6z";
				case IconKind.Trash:
					return "M19 6 v14 a2 2 0 0 1 -2 2 H7 a2 2 0 0 1 -2 -2 V6 m3 0 V4 a2 2 0 0 1 2 -2 h4 a2 2 0 0 1 2 2 v2 M3,6 5,6 21,6z";
				case IconKind.Trello:
					return "M14,7L17,7 17, 12 14,12z M7,7L10,7 10, 16 7,16z M3,3L21,3 21, 21 3,21z";
				case IconKind.TrendingDown:
					return "M17,18 23,18 23,12z M23,18 13.5,8.5 8.5,13.5 1,6z";
				case IconKind.TrendingUp:
					return "M17,6 23,6 23,12z M23,6 13.5,15.5 8.5,10.5 1,18z";
				case IconKind.Triangle:
					return "M10.29 3.86 L1.82 18 a2 2 0 0 0 1.71 3 h16.94 a2 2 0 0 0 1.71 -3 L13.71 3.86 a2 2 0 0 0 -3.42 0 z";
				case IconKind.Truck:
					return "M16,18.5a2.5,2.5 0 1,0 5,0a2.5,2.5 0 1,0 -5,0 M3,18.5a2.5,2.5 0 1,0 5,0a2.5,2.5 0 1,0 -5,0 M16,8 20,8 23,11 23,16 16,16 16,8z M1,3L16,3 16, 16 1,16z";
				case IconKind.Tv:
					return "M17,2 12,7 7,2z M2,7L22,7 22, 22 2,22z";
				case IconKind.Twitch:
					return "M21 2 H3 v16 h5 v4 l4 -4 h5 l4 -4 V2 z M11 11 V7 M16 11 V7";
				case IconKind.Twitter:
					return "M23 3 a10.9 10.9 0 0 1 -3.14 1.53 a4.48 4.48 0 0 0 -7.86 3 v1 A10.66 10.66 0 0 1 3 4 s-4 9 5 13 a11.64 11.64 0 0 1 -7 2 c9 5 20 0 20 -11.5 a4.5 4.5 0 0 0 -0.08 -0.83 A7.72 7.72 0 0 0 23 3 z";
				case IconKind.Type:
					return "M12,4 V 20 M9,20 H 15 M4,7 4,4 20,4 20,7z";
				case IconKind.Umbrella:
					return "M23 12 a11.05 11.05 0 0 0 -22 0 z m-5 7 a3 3 0 0 1 -6 0 v-7";
				case IconKind.Underline:
					return "M4,21 H 20 M6 3 v7 a6 6 0 0 0 6 6 a6 6 0 0 0 6 -6 V3";
				case IconKind.Unlock:
					return "M7 11 V7 a5 5 0 0 1 9.9 -1 M3,11L21,11 21, 22 3,22z";
				case IconKind.UploadCloud:
					return "M16,16 12,12 8,16z M20.39 18.39 A5 5 0 0 0 18 9 h-1.26 A8 8 0 1 0 3 16.3 M12,12 V 21 M16,16 12,12 8,16z";
				case IconKind.Upload:
					return "M12,3 V 15 M17,8 12,3 7,8z M21 15 v4 a2 2 0 0 1 -2 2 H5 a2 2 0 0 1 -2 -2 v-4";
				case IconKind.UserCheck:
					return "M17,11 19,13 23,9z M4.5,7a4,4 0 1,0 8,0a4,4 0 1,0 -8,0 M16 21 v-2 a4 4 0 0 0 -4 -4 H5 a4 4 0 0 0 -4 4 v2";
				case IconKind.UserMinus:
					return "M23,11 H 17 M4.5,7a4,4 0 1,0 8,0a4,4 0 1,0 -8,0 M16 21 v-2 a4 4 0 0 0 -4 -4 H5 a4 4 0 0 0 -4 4 v2";
				case IconKind.UserPlus:
					return "M23,11 H 17 M20,8 V 14 M4.5,7a4,4 0 1,0 8,0a4,4 0 1,0 -8,0 M16 21 v-2 a4 4 0 0 0 -4 -4 H5 a4 4 0 0 0 -4 4 v2";
				case IconKind.UserX:
					return "M23,8 H 18 M18,8 H 23 M4.5,7a4,4 0 1,0 8,0a4,4 0 1,0 -8,0 M16 21 v-2 a4 4 0 0 0 -4 -4 H5 a4 4 0 0 0 -4 4 v2";
				case IconKind.User:
					return "M8,7a4,4 0 1,0 8,0a4,4 0 1,0 -8,0 M20 21 v-2 a4 4 0 0 0 -4 -4 H8 a4 4 0 0 0 -4 4 v2";
				case IconKind.Users:
					return "M16 3.13 a4 4 0 0 1 0 7.75 M23 21 v-2 a4 4 0 0 0 -3 -3.87 M5,7a4,4 0 1,0 8,0a4,4 0 1,0 -8,0 M17 21 v-2 a4 4 0 0 0 -4 -4 H5 a4 4 0 0 0 -4 4 v2";
				case IconKind.VideoOff:
					return "M1,1 H 23 M16 16 v1 a2 2 0 0 1 -2 2 H3 a2 2 0 0 1 -2 -2 V7 a2 2 0 0 1 2 -2 h2 m5.66 0 H14 a2 2 0 0 1 2 2 v3.34 l1 1 L23 7 v10";
				case IconKind.Video:
					return "M1,5L16,5 16, 19 1,19z M23,7 16,12 23,17 23,7z";
				case IconKind.Voicemail:
					return "M5.5,16 H 18.5 M14,11.5a4.5,4.5 0 1,0 9,0a4.5,4.5 0 1,0 -9,0 M1,11.5a4.5,4.5 0 1,0 9,0a4.5,4.5 0 1,0 -9,0";
				case IconKind.Volume1:
					return "M15.54 8.46 a5 5 0 0 1 0 7.07 M11,5 6,9 2,9 2,15 6,15 11,19 11,5z";
				case IconKind.Volume2:
					return "M19.07 4.93 a10 10 0 0 1 0 14.14 M15.54 8.46 a5 5 0 0 1 0 7.07 M11,5 6,9 2,9 2,15 6,15 11,19 11,5z";
				case IconKind.VolumeX:
					return "M17,9 H 23 M23,9 H 17 M11,5 6,9 2,9 2,15 6,15 11,19 11,5z";
				case IconKind.Volume:
					return "M11,5 6,9 2,9 2,15 6,15 11,19 11,5z";
				case IconKind.Watch:
					return "M16.51 17.35 l-0.35 3.83 a2 2 0 0 1 -2 1.82 H9.83 a2 2 0 0 1 -2 -1.82 l-0.35 -3.83 m0.01 -10.7 l0.35 -3.83 A2 2 0 0 1 9.83 1 h4.35 a2 2 0 0 1 2 1.82 l0.35 3.83 M12,9 12,12 13.5,13.5z M5,12a7,7 0 1,0 14,0a7,7 0 1,0 -14,0";
				case IconKind.WifiOff:
					return "M12,20 H 12.01 M8.53 16.11 a6 6 0 0 1 6.95 0 M1.42 9 a15.91 15.91 0 0 1 4.7 -2.88 M10.71 5.05 A16 16 0 0 1 22.58 9 M5 12.55 a10.94 10.94 0 0 1 5.17 -2.39 M16.72 11.06 A10.94 10.94 0 0 1 19 12.55 M1,1 H 23";
				case IconKind.Wifi:
					return "M12,20 H 12.01 M8.53 16.11 a6 6 0 0 1 6.95 0 M1.42 9 a16 16 0 0 1 21.16 0 M5 12.55 a11 11 0 0 1 14.08 0";
				case IconKind.Wind:
					return "M9.59 4.59 A2 2 0 1 1 11 8 H2 m10.59 11.41 A2 2 0 1 0 14 16 H2 m15.73 -8.27 A2.5 2.5 0 1 1 19.5 12 H2";
				case IconKind.XCircle:
					return "M9,9 H 15 M15,9 H 9 M2,12a10,10 0 1,0 20,0a10,10 0 1,0 -20,0";
				case IconKind.XOctagon:
					return "M9,9 H 15 M15,9 H 9 M7.86,2 16.14,2 22,7.86 22,16.14 16.14,22 7.86,22 2,16.14 2,7.86 7.86,2z";
				case IconKind.XSquare:
					return "M15,9 H 9 M9,9 H 15 M3,3L21,3 21, 21 3,21z";
				case IconKind.X:
					return "M6,6 H 18 M18,6 H 6";
				case IconKind.Youtube:
					return "M9.75,15.02 15.5,11.75 9.75,8.48 9.75,15.02z M22.54 6.42 a2.78 2.78 0 0 0 -1.94 -2 C18.88 4 12 4 12 4 s-6.88 0 -8.6 0.46 a2.78 2.78 0 0 0 -1.94 2 A29 29 0 0 0 1 11.75 a29 29 0 0 0 0.46 5.33 A2.78 2.78 0 0 0 3.4 19 c1.72 0.46 8.6 0.46 8.6 0.46 s6.88 0 8.6 -0.46 a2.78 2.78 0 0 0 1.94 -2 a29 29 0 0 0 0.46 -5.25 a29 29 0 0 0 -0.46 -5.33 z";
				case IconKind.ZapOff:
					return "M1,1 H 23 M8,8 3,14 12,14 11,22 16,16z M18.57,12.91 21,10 15.66,10z M12.41,6.75 13,2 10.57,4.92z";
				case IconKind.Zap:
					return "M13,2 3,14 12,14 11,22 21,10 12,10 13,2z";
				case IconKind.ZoomIn:
					return "M8,11 H 14 M11,8 V 14 M21,21 H 16.65 M3,11a8,8 0 1,0 16,0a8,8 0 1,0 -16,0";
				case IconKind.ZoomOut:
					return "M8,11 H 14 M21,21 H 16.65 M3,11a8,8 0 1,0 16,0a8,8 0 1,0 -16,0";
				default:
					return string.Empty;
			}
		}
	}
}