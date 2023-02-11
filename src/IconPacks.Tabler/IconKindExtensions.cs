using System.Collections.Generic;
namespace IconPacks.Tabler
{
	public static class IconKindExtensions
	{
		public static string GetData(this IconKind kind)
		{
			switch (kind)
			{
				case IconKind._123:
					return "M17 8 h2.5 a1.5 1.5 0 0 1 1.5 1.5 v1 a1.5 1.5 0 0 1 -1.5 1.5 h-1.5 h1.5 a1.5 1.5 0 0 1 1.5 1.5 v1 a1.5 1.5 0 0 1 -1.5 1.5 h-2.5 M9 8 h3 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 0 -1 1 v2 a1 1 0 0 0 1 1 h3 M3 10 l2 -2 v8 M0 0 h24 v24 H0 z";
				case IconKind._24Hours:
					return "M20 15 v6 M17 15 v2 a1 1 0 0 0 1 1 h1 M11 15 h2 a1 1 0 0 1 1 1 v1 a1 1 0 0 1 -1 1 h-1 a1 1 0 0 0 -1 1 v1 a1 1 0 0 0 1 1 h2 M4 13 a8.094 8.094 0 0 0 3 5.24 M20 11 a8.1 8.1 0 0 0 -15.5 -2 m-0.5 -4 v4 h4 M0 0 h24 v24 H0 z";
				case IconKind._2fa:
					return "M17 13 l4 0 M17 16 v-6 a2 2 0 0 1 4 0 v6 M10 12 l3 0 M10 16 v-8 h4 M7 16 h-4 l3.47 -4.66 a2 2 0 1 0 -3.47 -1.54 M0 0 h24 v24 H0 z";
				case IconKind._360View:
					return "M3 16 c0 1.657 4.03 3 9 3 s9 -1.343 9 -3 M17 7 v4 a2 2 0 1 0 4 0 v-4 a2 2 0 1 0 -4 0 z M3 5 h2.5 a1.5 1.5 0 0 1 1.5 1.5 v1 a1.5 1.5 0 0 1 -1.5 1.5 h-1.5 h1.5 a1.5 1.5 0 0 1 1.5 1.5 v1 a1.5 1.5 0 0 1 -1.5 1.5 h-2.5 M14 6 a1 1 0 0 0 -1 -1 h-2 a1 1 0 0 0 -1 1 v6 a1 1 0 0 0 1 1 h2 a1 1 0 0 0 1 -1 v-2 a1 1 0 0 0 -1 -1 h-3 M0 0 h24 v24 H0 z";
				case IconKind._360:
					return "M9 13 l3 3 l-3 3 M17 15.328 c2.414 -0.718 4 -1.94 4 -3.328 c0 -2.21 -4.03 -4 -9 -4 s-9 1.79 -9 4 s4.03 4 9 4 M0 0 h24 v24 H0 z";
				case IconKind._3dCubeSphereOff:
					return "M3 3 l18 18 M6 8.6 l-2 -1.1 M12 12 l-2 -1.12 M12 18.5 v2.5 M12 12 v2.5 M18 8.6 l2 -1.1 M14 19.9 l-2 1.1 l-2 -1.1 M20 14 v2 M18 6.4 l2 1.1 v2.5 M10 4.1 l2 -1.1 l2 1.1 M4 10 v-2.5 l2 -1.1 M6 17.6 l-2 -1.1 v-2.5 M0 0 h24 v24 H0 z";
				case IconKind._3dCubeSphere:
					return "M6 8.6 l-2 -1.1 M12 12 l-2 -1.12 M12 18.5 l0 2.5 M12 12 l0 2.5 M18 8.6 l2 -1.1 M12 12 l2 -1.1 M14 19.9 l-2 1.1 l-2 -1.1 M20 14 v2.5 l-2 1.12 M18 6.4 l2 1.1 v2.5 M10 4.1 l2 -1.1 l2 1.1 M4 10 v-2.5 l2 -1.1 M6 17.6 l-2 -1.1 v-2.5 M0 0 h24 v24 H0 z";
				case IconKind._3dRotate:
					return "M8 15.545 l5 -3.03 M3 12.5 v5.5 l5 3 M8 15.5 l-5 -3 l5 -3 l5 3 v5.5 l-5 3 z M22 11 l-3 3 M12 3 a7 7 0 0 1 7 7 v4 l-3 -3 M0 0 h24 v24 H0 z";
				case IconKind.AB2:
					return "M8 7 h-4 M2.99 11.98 a9 9 0 0 0 9 9 m9 -9 a9 9 0 0 0 -9 -9 M4 9 v-4 c0 -1.036 0.895 -2 2 -2 s2 0.964 2 2 v4 M16 15 h2.5 c0.84 -0.01 1.5 0.66 1.5 1.5 s-0.66 1.5 -1.5 1.5 h-2.5 v-3 z M16 21 h3 c0.81 0 1.48 -0.67 1.48 -1.48 l0.02 -0.02 c0 -0.82 -0.69 -1.5 -1.5 -1.5 h-3 v3 z M0 0 h24 v24 H0 z";
				case IconKind.ABOff:
					return "M3 3 l18 18 M16 8 h3 a2 2 0 1 1 0 4 h-3 m3 0 a2 2 0 0 1 0.83 3.82 m-3.83 -3.82 v-4 M12 6 v2 M12 12 v6 M3 16 v-5.5 a2.5 2.5 0 0 1 5 0 v5.5 m0 -4 h-5 M0 0 h24 v24 H0 z";
				case IconKind.AB:
					return "M16 16 v-8 h3 a2 2 0 0 1 0 4 h-3 m3 0 a2 2 0 0 1 0 4 h-3 M12 6 l0 12 M3 16 v-5.5 a2.5 2.5 0 0 1 5 0 v5.5 m0 -4 h-5 M0 0 h24 v24 H0 z";
				case IconKind.AbacusOff:
					return "M3 3 l18 18 M3 21 h18 M8 8 v1 M11 5 v2 M14 5 v4 M16 16 v1 M11 13 v4 M8 13 v4 M5 15 h10 M5 7 h2 m4 0 h8 M19 21 v-2 m0 -4 v-12 M5 5 v16 M0 0 h24 v24 H0 z";
				case IconKind.Abacus:
					return "M3 21 h18 M8 5 v4 M11 5 v4 M14 5 v4 M16 13 v4 M11 13 v4 M8 13 v4 M5 15 h14 M5 7 h14 M19 21 v-18 M5 3 v18 M0 0 h24 v24 H0 z";
				case IconKind.Abc:
					return "M20.732 12 a2 2 0 0 0 -3.732 1 v1 a2 2 0 0 0 3.726 1.01 M10 8 v6 a2 2 0 1 0 4 0 v-1 a2 2 0 1 0 -4 0 v1 M3 13 h4 M3 16 v-6 a2 2 0 1 1 4 0 v6 M0 0 h24 v24 H0 z";
				case IconKind.AccessPointOff:
					return "M6.337 17.657 a8 8 0 0 1 0 -11.314 M9.168 14.828 a4 4 0 0 1 0 -5.656 M17.657 6.343 a8 8 0 0 1 1.635 8.952 M14.828 9.172 a4 4 0 0 1 1.172 2.828 M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.AccessPoint:
					return "M6.337 17.657 a8 8 0 0 1 0 -11.314 M9.168 14.828 a4 4 0 0 1 0 -5.656 M17.657 6.343 a8 8 0 0 1 0 11.314 M14.828 9.172 a4 4 0 0 1 0 5.656 M12 12 l0 0.01 M0 0 h24 v24 H0 z";
				case IconKind.AccessibleOffFilled:
					return "M17 3.34 a10 10 0 1 1 -14.995 8.984 l-0.005 -0.324 l0.005 -0.324 a10 10 0 0 1 14.995 -8.336 z m-1.051 6.844 a1 1 0 0 0 -1.152 -0.663 l-0.113 0.03 l-2.684 0.895 l-2.684 -0.895 l-0.113 -0.03 a1 1 0 0 0 -0.628 1.884 l0.109 0.044 l2.316 0.771 v0.976 l-1.832 2.75 l-0.06 0.1 a1 1 0 0 0 0.237 1.21 l0.1 0.076 l0.101 0.06 a1 1 0 0 0 1.21 -0.237 l0.076 -0.1 l1.168 -1.752 l1.168 1.752 l0.07 0.093 a1 1 0 0 0 1.653 -1.102 l-0.059 -0.1 l-1.832 -2.75 v-0.977 l2.316 -0.771 l0.109 -0.044 a1 1 0 0 0 0.524 -1.221 z m-3.949 -4.184 a1.5 1.5 0 1 0 0 3 a1.5 1.5 0 0 0 0 -3 z M0 0 h24 v24 H0 z";
				case IconKind.AccessibleOff:
					return "M3 3 l18 18 M12 8 a0.5 0.5 0 1 0 -0.5 -0.5 M20.042 16.045 a9 9 0 0 0 -12.087 -12.087 m-2.318 1.677 a9 9 0 1 0 12.725 12.73 M10 16.5 l2 -3 l2 3 m-2 -3 v-1.5 m2.627 -1.376 l0.373 -0.124 m-6 0 l2.231 0.744 M0 0 h24 v24 H0 z";
				case IconKind.Accessible:
					return "M11.5,7.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M10 16.5 l2 -3 l2 3 m-2 -3 v-2 l3 -1 m-6 0 l3 1 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.ActivityHeartbeat:
					return "M3 12 h4.5 l1.5 -6 l4 12 l2 -9 l1.5 3 h4.5 M0 0 h24 v24 H0 z";
				case IconKind.Activity:
					return "M3 12 h4 l3 8 l4 -16 l3 8 h4 M0 0 h24 v24 H0 z";
				case IconKind.Ad2:
					return "M19 9 h2 M18 6 l2 -2 M15 5 v-2 M9 13 h5 v-4 h-5 z M14 17 h-5 M11.933 5 h-6.933 v16 h13 v-8 M0 0 h24 v24 H0 z";
				case IconKind.AdFilled:
					return "M19 4 h-14 a3 3 0 0 0 -3 3 v10 a3 3 0 0 0 3 3 h14 a3 3 0 0 0 3 -3 v-10 a3 3 0 0 0 -3 -3 z m-10 4 a3 3 0 0 1 2.995 2.824 l0.005 0.176 v4 a1 1 0 0 1 -1.993 0.117 l-0.007 -0.117 v-1 h-2 v1 a1 1 0 0 1 -1.993 0.117 l-0.007 -0.117 v-4 a3 3 0 0 1 3 -3 z m0 2 a1 1 0 0 0 -0.993 0.883 l-0.007 0.117 v1 h2 v-1 a1 1 0 0 0 -1 -1 z m8 -2 a1 1 0 0 1 0.993 0.883 l0.007 0.117 v6 a1 1 0 0 1 -0.883 0.993 l-0.117 0.007 h-1.5 a2.5 2.5 0 1 1 0.326 -4.979 l0.174 0.029 v-2.05 a1 1 0 0 1 0.883 -0.993 l0.117 -0.007 z m-1.41 5.008 l-0.09 -0.008 a0.5 0.5 0 0 0 -0.09 0.992 l0.09 0.008 h0.5 v-0.5 l-0.008 -0.09 a0.5 0.5 0 0 0 -0.318 -0.379 l-0.084 -0.023 z M0 0 h24 v24 H0 z";
				case IconKind.AdOff:
					return "M3 3 l18 18 M16.115 12.131 c0.33 0.149 0.595 0.412 0.747 0.74 M17 9 v4 M7 13 h4 M7 15 v-4 a2 2 0 0 1 2 -2 m2 2 v4 M9 5 h10 a2 2 0 0 1 2 2 v10 m-2 2 h-14 a2 2 0 0 1 -2 -2 v-10 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.Ad:
					return "M17 9 v6 h-1.5 a1.5 1.5 0 1 1 1.5 -1.5 M7 13 l4 0 M7 15 v-4 a2 2 0 0 1 4 0 v4 M3 5 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.AddressBookOff:
					return "M3 3 l18 18 M4 16 h3 M4 12 h3 M4 8 h3 M11 11 a2 2 0 0 0 2 2 m2 -2 a2 2 0 0 0 -2 -2 M10 16 h6 M8 4 h10 a2 2 0 0 1 2 2 v10 m-0.57 3.399 c-0.363 0.37 -0.87 0.601 -1.43 0.601 h-10 a2 2 0 0 1 -2 -2 v-12 M0 0 h24 v24 H0 z";
				case IconKind.AddressBook:
					return "M4 16 h3 M4 12 h3 M4 8 h3 M13 11 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M10 16 h6 M20 6 v12 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 v-12 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 z M0 0 h24 v24 H0 z";
				case IconKind.AdjustmentsAlt:
					return "M18 9 l0 11 M18 4 l0 1 M16 5 h4 v4 h-4 z M12 18 l0 2 M12 4 l0 10 M10 14 h4 v4 h-4 z M6 12 l0 8 M6 4 l0 4 M4 8 h4 v4 h-4 z M0 0 h24 v24 H0 z";
				case IconKind.AdjustmentsFilled:
					return "M18 3 a1 1 0 0 1 0.993 0.883 l0.007 0.117 v0.171 a3.001 3.001 0 0 1 0 5.658 v10.171 a1 1 0 0 1 -1.993 0.117 l-0.007 -0.117 v-10.17 a3.002 3.002 0 0 1 -1.995 -2.654 l-0.005 -0.176 l0.005 -0.176 a3.002 3.002 0 0 1 1.995 -2.654 v-0.17 a1 1 0 0 1 1 -1 z M12 3 a1 1 0 0 1 0.993 0.883 l0.007 0.117 v9.171 a3.001 3.001 0 0 1 0 5.658 v1.171 a1 1 0 0 1 -1.993 0.117 l-0.007 -0.117 v-1.17 a3.002 3.002 0 0 1 -1.995 -2.654 l-0.005 -0.176 l0.005 -0.176 a3.002 3.002 0 0 1 1.995 -2.654 v-9.17 a1 1 0 0 1 1 -1 z M6 3 a1 1 0 0 1 0.993 0.883 l0.007 0.117 v3.171 a3.001 3.001 0 0 1 0 5.658 v7.171 a1 1 0 0 1 -1.993 0.117 l-0.007 -0.117 v-7.17 a3.002 3.002 0 0 1 -1.995 -2.654 l-0.005 -0.176 l0.005 -0.176 a3.002 3.002 0 0 1 1.995 -2.654 v-3.17 a1 1 0 0 1 1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.AdjustmentsHorizontal:
					return "M19 18 l1 0 M4 18 l11 0 M17 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M10 12 l10 0 M4 12 l2 0 M8 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M16 6 l4 0 M4 6 l8 0 M14 6 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.AdjustmentsOff:
					return "M3 3 l18 18 M18 18 v2 M18 9 v5 M18 4 v1 M18 7 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M12 18 v2 M12 12 v2 M12 4 v4 M12 16 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 12 v8 M6 6 v2 M6 10 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Adjustments:
					return "M18 9 l0 11 M18 4 l0 1 M18 7 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M12 18 l0 2 M12 4 l0 10 M12 16 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 12 l0 8 M6 4 l0 4 M6 10 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.AerialLift:
					return "M4 5 l16 -2 m-8 1 v10 m-5.106 -6 h10.306 c2.45 3 2.45 9 -0.2 12 h-10.106 c-2.544 -3 -2.544 -9 0 -12 z m-1.894 6 h14 M0 0 h24 v24 H0 z";
				case IconKind.AffiliateFilled:
					return "M18.5 3 a2.5 2.5 0 1 1 -0.912 4.828 l-4.556 4.555 a5.475 5.475 0 0 1 0.936 3.714 l2.624 0.787 a2.5 2.5 0 1 1 -0.575 1.916 l-2.623 -0.788 a5.5 5.5 0 0 1 -10.39 -2.29 l-0.004 -0.222 l0.004 -0.221 a5.5 5.5 0 0 1 2.984 -4.673 l-0.788 -2.624 a2.498 2.498 0 0 1 -2.194 -2.304 l-0.006 -0.178 l0.005 -0.164 a2.5 2.5 0 1 1 4.111 2.071 l0.787 2.625 a5.475 5.475 0 0 1 3.714 0.936 l4.555 -4.556 a2.487 2.487 0 0 1 -0.167 -0.748 l-0.005 -0.164 l0.005 -0.164 a2.5 2.5 0 0 1 2.495 -2.336 z M0 0 h24 v24 H0 z";
				case IconKind.Affiliate:
					return "M8.5 15.5 m-4.5 0 a4.5 4.5 0 1 0 9 0 a4.5 4.5 0 1 0 -9 0 M18.5 18.5 m-1.5 0 a1.5 1.5 0 1 0 3 0 a1.5 1.5 0 1 0 -3 0 M18.5 5.5 m-1.5 0 a1.5 1.5 0 1 0 3 0 a1.5 1.5 0 1 0 -3 0 M5.5 5.5 m-1.5 0 a1.5 1.5 0 1 0 3 0 a1.5 1.5 0 1 0 -3 0 M11.683 12.317 l5.759 -5.759 M5.931 6.936 l1.275 4.249 m5.607 5.609 l4.251 1.275 M0 0 h24 v24 H0 z";
				case IconKind.AirBalloon:
					return "M12 9 m-2 0 a2 7 0 1 0 4 0 a2 7 0 1 0 -4 0 M12 16 c3.314 0 6 -4.686 6 -8 a6 6 0 1 0 -12 0 c0 3.314 2.686 8 6 8 z M10 19 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v1 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.AirConditioningDisabled:
					return "M7 16 v-3 a1 1 0 0 1 1 -1 h8 a1 1 0 0 1 1 1 v3 M3 8 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v4 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.AirConditioning:
					return "M7 13 v-3 a1 1 0 0 1 1 -1 h8 a1 1 0 0 1 1 1 v3 M3 5 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v4 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M12 16 v4 M16 16 a3 3 0 0 0 3 3 M8 16 a3 3 0 0 1 -3 3 M0 0 h24 v24 H0 z";
				case IconKind.AlarmMinus:
					return "M10 13 h4 M17 4 l2.75 2 M7 4 l-2.75 2 M12 13 m-7 0 a7 7 0 1 0 14 0 a7 7 0 1 0 -14 0 M0 0 h24 v24 H0 z";
				case IconKind.AlarmOff:
					return "M3 3 l18 18 M17 4 l2.75 2 M5.261 5.265 l-1.011 0.735 M12 12 v1 h1 M7.587 7.566 a7 7 0 1 0 9.833 9.864 m1.35 -2.645 a7 7 0 0 0 -8.536 -8.56 M0 0 h24 v24 H0 z";
				case IconKind.AlarmPlus:
					return "M12 11 v4 M10 13 h4 M17 4 l2.75 2 M7 4 l-2.75 2 M12 13 m-7 0 a7 7 0 1 0 14 0 a7 7 0 1 0 -14 0 M0 0 h24 v24 H0 z";
				case IconKind.AlarmSnooze:
					return "M17 4 l2.75 2 M7 4 l-2.75 2 M10 11 h4 l-4 4 h4 M12 13 m-7 0 a7 7 0 1 0 14 0 a7 7 0 1 0 -14 0 M0 0 h24 v24 H0 z";
				case IconKind.Alarm:
					return "M17 4 l2.75 2 M7 4 l-2.75 2 M12 10 l0 3 l2 0 M12 13 m-7 0 a7 7 0 1 0 14 0 a7 7 0 1 0 -14 0 M0 0 h24 v24 H0 z";
				case IconKind.AlbumOff:
					return "M3 3 l18 18 M12 4 v4 m1.503 1.497 l0.497 -0.497 l2 2 v-7 M8 4 h10 a2 2 0 0 1 2 2 v10 m-0.581 3.41 c-0.362 0.364 -0.864 0.59 -1.419 0.59 h-12 a2 2 0 0 1 -2 -2 v-12 c0 -0.552 0.224 -1.052 0.585 -1.413 M0 0 h24 v24 H0 z";
				case IconKind.Album:
					return "M12 4 v7 l2 -2 l2 2 v-7 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.AlertCircleFilled:
					return "M17 3.34 a10 10 0 1 1 -14.995 8.984 l-0.005 -0.324 l0.005 -0.324 a10 10 0 0 1 14.995 -8.336 z m-4.99 11.66 l-0.127 0.007 a1 1 0 0 0 0 1.986 l0.117 0.007 l0.127 -0.007 a1 1 0 0 0 0 -1.986 l-0.117 -0.007 z m-0.01 -8 a1 1 0 0 0 -0.993 0.883 l-0.007 0.117 v4 l0.007 0.117 a1 1 0 0 0 1.986 0 l0.007 -0.117 v-4 l-0.007 -0.117 a1 1 0 0 0 -0.993 -0.883 z M0 0 h24 v24 H0 z";
				case IconKind.AlertCircle:
					return "M12 16 l0.01 0 M12 8 l0 4 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.AlertOctagonFilled:
					return "M15.3 2 c0.5 0 0.914 0.16 1.274 0.47 l0.133 0.123 l4.7 4.7 c0.348 0.348 0.546 0.745 0.586 1.224 l0.007 0.183 v6.6 c0 0.5 -0.16 0.914 -0.47 1.274 l-0.123 0.133 l-4.7 4.7 c-0.348 0.348 -0.745 0.546 -1.224 0.586 l-0.183 0.007 h-6.6 c-0.5 0 -0.914 -0.16 -1.274 -0.47 l-0.133 -0.123 l-4.7 -4.7 c-0.348 -0.348 -0.546 -0.745 -0.586 -1.224 l-0.007 -0.183 v-6.6 c0 -0.5 0.16 -0.914 0.47 -1.274 l0.123 -0.133 l4.7 -4.7 c0.348 -0.348 0.745 -0.546 1.224 -0.586 l0.183 -0.007 h6.6 z m-3.29 13 l-0.127 0.007 a1 1 0 0 0 0 1.986 l0.117 0.007 l0.127 -0.007 a1 1 0 0 0 0 -1.986 l-0.117 -0.007 z m-0.01 -8 a1 1 0 0 0 -0.993 0.883 l-0.007 0.117 v4 l0.007 0.117 a1 1 0 0 0 1.986 0 l0.007 -0.117 v-4 l-0.007 -0.117 a1 1 0 0 0 -0.993 -0.883 z M0 0 h24 v24 H0 z";
				case IconKind.AlertOctagon:
					return "M12 16 l0.01 0 M12 8 l0 4 M8.7 3 h6.6 c0.3 0 0.5 0.1 0.7 0.3 l4.7 4.7 c0.2 0.2 0.3 0.4 0.3 0.7 v6.6 c0 0.3 -0.1 0.5 -0.3 0.7 l-4.7 4.7 c-0.2 0.2 -0.4 0.3 -0.7 0.3 h-6.6 c-0.3 0 -0.5 -0.1 -0.7 -0.3 l-4.7 -4.7 c-0.2 -0.2 -0.3 -0.4 -0.3 -0.7 v-6.6 c0 -0.3 0.1 -0.5 0.3 -0.7 l4.7 -4.7 c0.2 -0.2 0.4 -0.3 0.7 -0.3 z M0 0 h24 v24 H0 z";
				case IconKind.AlertTriangleFilled:
					return "M11.99 1.968 c1.023 0 1.97 0.521 2.512 1.359 l0.103 0.172 l7.1 12.25 l0.062 0.126 a3 3 0 0 1 -2.568 4.117 l-0.199 0.008 h-14 l-0.049 -0.003 l-0.112 0.002 a3 3 0 0 1 -2.268 -1.226 l-0.109 -0.16 a3 3 0 0 1 -0.32 -2.545 l0.072 -0.194 l0.06 -0.125 l7.092 -12.233 a3 3 0 0 1 2.625 -1.548 z m0.02 12.032 l-0.127 0.007 a1 1 0 0 0 0 1.986 l0.117 0.007 l0.127 -0.007 a1 1 0 0 0 0 -1.986 l-0.117 -0.007 z m-0.01 -6 a1 1 0 0 0 -0.993 0.883 l-0.007 0.117 v2 l0.007 0.117 a1 1 0 0 0 1.986 0 l0.007 -0.117 v-2 l-0.007 -0.117 a1 1 0 0 0 -0.993 -0.883 z M0 0 h24 v24 H0 z";
				case IconKind.AlertTriangle:
					return "M5 19 h14 a2 2 0 0 0 1.84 -2.75 l-7.1 -12.25 a2 2 0 0 0 -3.5 0 l-7.1 12.25 a2 2 0 0 0 1.75 2.75 M12 9 v2 m0 4 v0.01 M0 0 h24 v24 H0 z";
				case IconKind.Alien:
					return "M16 11 l-2 2 M8 11 l2 2 M12 3 c-4.664 0 -7.396 2.331 -7.862 5.595 a11.816 11.816 0 0 0 2 8.592 a10.777 10.777 0 0 0 3.199 3.064 c1.666 1 3.664 1 5.33 0 a10.777 10.777 0 0 0 3.199 -3.064 a11.89 11.89 0 0 0 2 -8.592 c-0.466 -3.265 -3.198 -5.595 -7.862 -5.595 z M11 17 a2.5 2.5 0 0 0 2 0 M0 0 h24 v24 H0 z";
				case IconKind.AlignBoxBottomCenter:
					return "M15 13 v4 M12 11 v6 M9 15 v2 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.AlignBoxBottomLeft:
					return "M13 13 v4 M10 11 v6 M7 15 v2 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.AlignBoxBottomRight:
					return "M17 13 v4 M14 11 v6 M11 15 v2 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.AlignBoxLeftBottom:
					return "M11 11 h-4 M13 14 h-6 M9 17 h-2 M20 18.222 v-12.444 c0 -0.982 -0.796 -1.778 -1.778 -1.778 h-12.444 c-0.982 0 -1.778 0.796 -1.778 1.778 v12.444 c0 0.982 0.796 1.778 1.778 1.778 h12.444 c0.982 0 1.778 -0.796 1.778 -1.778 z M0 0 h24 v24 H0 z";
				case IconKind.AlignBoxLeftMiddle:
					return "M11 9 h-4 M13 12 h-6 M9 15 h-2 M20 18.222 v-12.444 c0 -0.982 -0.796 -1.778 -1.778 -1.778 h-12.444 c-0.982 0 -1.778 0.796 -1.778 1.778 v12.444 c0 0.982 0.796 1.778 1.778 1.778 h12.444 c0.982 0 1.778 -0.796 1.778 -1.778 z M0 0 h24 v24 H0 z";
				case IconKind.AlignBoxLeftTop:
					return "M11 7 h-4 M13 10 h-6 M9 13 h-2 M20 18.222 v-12.444 c0 -0.982 -0.796 -1.778 -1.778 -1.778 h-12.444 c-0.982 0 -1.778 0.796 -1.778 1.778 v12.444 c0 0.982 0.796 1.778 1.778 1.778 h12.444 c0.982 0 1.778 -0.796 1.778 -1.778 z M0 0 h24 v24 H0 z";
				case IconKind.AlignBoxRightBottom:
					return "M13 11 h4 M11 14 h6 M15 17 h2 M4 18.222 v-12.444 c0 -0.982 0.796 -1.778 1.778 -1.778 h12.444 c0.982 0 1.778 0.796 1.778 1.778 v12.444 c0 0.982 -0.796 1.778 -1.778 1.778 h-12.444 a1.778 1.778 0 0 1 -1.778 -1.778 z M0 0 h24 v24 H0 z";
				case IconKind.AlignBoxRightMiddle:
					return "M13 9 h4 M11 12 h6 M15 15 h2 M4 18.222 v-12.444 c0 -0.982 0.796 -1.778 1.778 -1.778 h12.444 c0.982 0 1.778 0.796 1.778 1.778 v12.444 c0 0.982 -0.796 1.778 -1.778 1.778 h-12.444 a1.778 1.778 0 0 1 -1.778 -1.778 z M0 0 h24 v24 H0 z";
				case IconKind.AlignBoxRightTop:
					return "M13 7 h4 M11 10 h6 M15 13 h2 M4 18.222 v-12.444 c0 -0.982 0.796 -1.778 1.778 -1.778 h12.444 c0.982 0 1.778 0.796 1.778 1.778 v12.444 c0 0.982 -0.796 1.778 -1.778 1.778 h-12.444 a1.778 1.778 0 0 1 -1.778 -1.778 z M0 0 h24 v24 H0 z";
				case IconKind.AlignBoxTopCenter:
					return "M15 11 v-4 M12 13 v-6 M9 9 v-2 M5.778 20 h12.444 c0.982 0 1.778 -0.796 1.778 -1.778 v-12.444 c0 -0.982 -0.796 -1.778 -1.778 -1.778 h-12.444 c-0.982 0 -1.778 0.796 -1.778 1.778 v12.444 c0 0.982 0.796 1.778 1.778 1.778 z M0 0 h24 v24 H0 z";
				case IconKind.AlignBoxTopLeft:
					return "M13 11 v-4 M10 13 v-6 M7 9 v-2 M5.778 20 h12.444 c0.982 0 1.778 -0.796 1.778 -1.778 v-12.444 c0 -0.982 -0.796 -1.778 -1.778 -1.778 h-12.444 c-0.982 0 -1.778 0.796 -1.778 1.778 v12.444 c0 0.982 0.796 1.778 1.778 1.778 z M0 0 h24 v24 H0 z";
				case IconKind.AlignBoxTopRight:
					return "M17 11 v-4 M14 13 v-6 M11 9 v-2 M5.778 20 h12.444 c0.982 0 1.778 -0.796 1.778 -1.778 v-12.444 c0 -0.982 -0.796 -1.778 -1.778 -1.778 h-12.444 c-0.982 0 -1.778 0.796 -1.778 1.778 v12.444 c0 0.982 0.796 1.778 1.778 1.778 z M0 0 h24 v24 H0 z";
				case IconKind.AlignCenter:
					return "M6 18 l12 0 M8 12 l8 0 M4 6 l16 0 M0 0 h24 v24 H0 z";
				case IconKind.AlignJustified:
					return "M4 18 l12 0 M4 12 l16 0 M4 6 l16 0 M0 0 h24 v24 H0 z";
				case IconKind.AlignLeft:
					return "M4 18 l14 0 M4 12 l10 0 M4 6 l16 0 M0 0 h24 v24 H0 z";
				case IconKind.AlignRight:
					return "M6 18 l14 0 M10 12 l10 0 M4 6 l16 0 M0 0 h24 v24 H0 z";
				case IconKind.Alpha:
					return "M18.1 6 c-1.1 2.913 -1.9 4.913 -2.4 6 c-1.879 4.088 -3.713 6 -6 6 c-2.4 0 -4.8 -2.4 -4.8 -6 s2.4 -6 4.8 -6 c2.267 0 4.135 1.986 6 6 c0.512 1.102 1.312 3.102 2.4 6 M0 0 h24 v24 H0 z";
				case IconKind.AlphabetCyrillic:
					return "M19 7 h-3 a2 2 0 0 0 -2 2 v6 a2 2 0 0 0 2 2 h1 a2 2 0 0 0 2 -2 v-3 a2 2 0 0 0 -2 -2 h-3 M6 10 h2 a2 2 0 0 1 2 2 v5 h-3 a2 2 0 1 1 0 -4 h3 M0 0 h24 v24 H0 z";
				case IconKind.AlphabetGreek:
					return "M14 20 v-11 a2 2 0 0 1 2 -2 h1 a2 2 0 0 1 2 2 v1 a2 2 0 0 1 -2 2 a2 2 0 0 1 2 2 v1 a2 2 0 0 1 -2 2 M5 10 m0 2 a2 2 0 0 1 2 -2 h1 a2 2 0 0 1 2 2 v3 a2 2 0 0 1 -2 2 h-1 a2 2 0 0 1 -2 -2 z M10 10 v7 M0 0 h24 v24 H0 z";
				case IconKind.AlphabetLatin:
					return "M14 10 m0 2 a2 2 0 0 1 2 -2 h1 a2 2 0 0 1 2 2 v3 a2 2 0 0 1 -2 2 h-1 a2 2 0 0 1 -2 -2 z M14 7 v10 M6 10 h2 a2 2 0 0 1 2 2 v5 h-3 a2 2 0 1 1 0 -4 h3 M0 0 h24 v24 H0 z";
				case IconKind.Ambulance:
					return "M6 10 h4 m-2 -2 v4 M5 17 h-2 v-11 a1 1 0 0 1 1 -1 h9 v12 m-4 0 h6 m4 0 h2 v-6 h-8 m0 -5 h5 l3 5 M17 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M7 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Ampersand:
					return "M19 20 l-10.403 -10.972 a2.948 2.948 0 0 1 0 -4.165 a2.94 2.94 0 0 1 4.161 0 a2.948 2.948 0 0 1 0 4.165 l-4.68 4.687 a3.685 3.685 0 0 0 0 5.207 a3.675 3.675 0 0 0 5.2 0 l5.722 -5.922 M0 0 h24 v24 H0 z";
				case IconKind.AnalyzeOff:
					return "M3 3 l18 18 M9.888 9.87 a3 3 0 1 0 4.233 4.252 m0.595 -3.397 a3.012 3.012 0 0 0 -1.426 -1.435 M5 8 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M20 16 a1 1 0 0 0 -1 -1 M4 13 a8.1 8.1 0 0 0 13.687 4.676 M20 11 a8.1 8.1 0 0 0 -6.986 -6.918 a8.086 8.086 0 0 0 -4.31 0.62 m-2.383 1.608 a8.089 8.089 0 0 0 -1.326 1.69 M0 0 h24 v24 H0 z";
				case IconKind.Analyze:
					return "M12 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M5 8 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M19 16 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M4 13 a8.1 8.1 0 0 0 15 3 M20 11 a8.1 8.1 0 0 0 -6.986 -6.918 a8.095 8.095 0 0 0 -8.019 3.918 M0 0 h24 v24 H0 z";
				case IconKind.AnchorOff:
					return "M3 3 l18 18 M12.866 8.873 a3 3 0 1 0 -3.737 -3.747 M5 13 h-2 M21 13 h-2 M4 13 a8 8 0 0 0 14.138 5.13 m1.44 -2.56 a7.99 7.99 0 0 0 0.422 -2.57 M12 12 v9 M0 0 h24 v24 H0 z";
				case IconKind.Anchor:
					return "M12 6 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M12 9 v12 m-8 -8 a8 8 0 0 0 16 0 m1 0 h-2 m-14 0 h-2 M0 0 h24 v24 H0 z";
				case IconKind.Angle:
					return "M15.415 5.971 h0.015 M17.715 8.671 h0.015 M19.515 11.771 h0.015 M20.615 15.171 h0.015 M21 19 h-18 l9 -15 M0 0 h24 v24 H0 z";
				case IconKind.Ankh:
					return "M12 21 v-8 l-0.422 -0.211 a6.472 6.472 0 0 1 -3.578 -5.789 a4 4 0 1 1 8 0 a6.472 6.472 0 0 1 -3.578 5.789 l-0.422 0.211 M6 13 h12 M0 0 h24 v24 H0 z";
				case IconKind.AntennaBars1:
					return "M18 18 l0 0.01 M14 18 l0 0.01 M10 18 l0 0.01 M6 18 l0 0.01 M0 0 h24 v24 H0 z";
				case IconKind.AntennaBars2:
					return "M18 18 l0 0.01 M14 18 l0 0.01 M10 18 l0 0.01 M6 18 l0 -3 M0 0 h24 v24 H0 z";
				case IconKind.AntennaBars3:
					return "M18 18 l0 0.01 M14 18 l0 0.01 M10 18 l0 -6 M6 18 l0 -3 M0 0 h24 v24 H0 z";
				case IconKind.AntennaBars4:
					return "M18 18 l0 0.01 M14 18 l0 -9 M10 18 l0 -6 M6 18 l0 -3 M0 0 h24 v24 H0 z";
				case IconKind.AntennaBars5:
					return "M18 18 l0 -12 M14 18 l0 -9 M10 18 l0 -6 M6 18 l0 -3 M0 0 h24 v24 H0 z";
				case IconKind.AntennaBarsOff:
					return "M3 3 l18 18 M18 14 v-8 M14 10 v-1 M14 18 v-4 M10 18 v-6 M6 18 v-3 M0 0 h24 v24 H0 z";
				case IconKind.AntennaOff:
					return "M3 3 l18 18 M20 8 h-8 m-4 0 h-4 M4 6 v4 M8 8 v2.5 M12 5 v3 m0 4 v9 M16 4.5 v7 M20 4 v8 M0 0 h24 v24 H0 z";
				case IconKind.Antenna:
					return "M20 8 h-16 M4 6 v4 M8 5.5 v5 M12 5 v16 M16 4.5 v7 M20 4 v8 M0 0 h24 v24 H0 z";
				case IconKind.ApertureOff:
					return "M3 3 l18 18 M12.257 20.916 l2.123 -6.533 m0.984 -3.028 l0.154 -0.473 M20.559 14.51 l-8.535 -6.201 M17.032 4.636 l-4.852 3.526 m-2.334 1.695 l-1.349 0.98 M7.395 7.534 l2.416 7.438 M5.641 5.631 a9 9 0 1 0 12.719 12.738 m1.68 -2.318 a9 9 0 0 0 -12.074 -12.098 M3.6 15 h10.55 M0 0 h24 v24 H0 z";
				case IconKind.Aperture:
					return "M12.257 20.916 l3.261 -10.034 M20.559 14.51 l-8.535 -6.201 M17.032 4.636 l-8.535 6.201 M6.551 4.938 l3.26 10.034 M3.6 15 h10.55 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.ApiAppOff:
					return "M3 3 l18 18 M9 12 v-3 m0.042 -3.957 a2.5 2.5 0 0 1 4.958 0.457 v0.5 M13 9 h5.5 a2.5 2.5 0 1 1 0 5 h-0.5 M15 15 v3.5 a2.5 2.5 0 1 1 -5 0 v-0.5 M12 15 h-6.5 a2.5 2.5 0 1 1 0 -5 h0.5 M0 0 h24 v24 H0 z";
				case IconKind.ApiApp:
					return "M9 12 v-6.5 a2.5 2.5 0 0 1 5 0 v0.5 M12 9 h6.5 a2.5 2.5 0 1 1 0 5 h-0.5 M15 12 v6.5 a2.5 2.5 0 1 1 -5 0 v-0.5 M12 15 h-6.5 a2.5 2.5 0 1 1 0 -5 h0.5 M0 0 h24 v24 H0 z";
				case IconKind.ApiOff:
					return "M3 3 l18 18 M9 16 v-5.5 a2.5 2.5 0 0 0 -5 0 v5.5 M20 8 v8 M12 16 v-4 m0 -4 h3 a2 2 0 0 1 2 2 v1 c0 0.554 -0.225 1.055 -0.589 1.417 m-3.411 0.583 h-1 M4 13 h5 M0 0 h24 v24 H0 z";
				case IconKind.Api:
					return "M9 16 v-5.5 a2.5 2.5 0 0 0 -5 0 v5.5 M20 8 v8 M12 16 v-8 h3 a2 2 0 0 1 2 2 v1 a2 2 0 0 1 -2 2 h-3 M4 13 h5 M0 0 h24 v24 H0 z";
				case IconKind.AppWindow:
					return "M9 8 h0.01 M6 8 h0.01 M3 5 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Apple:
					return "M10 10.5 c1.333 0.667 2.667 0.667 4 0 M12 11 v-6 a2 2 0 0 1 2 -2 h2 v1 a2 2 0 0 1 -2 2 h-2 M12 14 m-7 0 a7 7 0 1 0 14 0 a7 7 0 1 0 -14 0 M0 0 h24 v24 H0 z";
				case IconKind.AppsFilled:
					return "M17 3 a1 1 0 0 1 0.993 0.883 l0.007 0.117 v2 h2 a1 1 0 0 1 0.117 1.993 l-0.117 0.007 h-2 v2 a1 1 0 0 1 -1.993 0.117 l-0.007 -0.117 v-2 h-2 a1 1 0 0 1 -0.117 -1.993 l0.117 -0.007 h2 v-2 a1 1 0 0 1 1 -1 z M19 13 h-4 a2 2 0 0 0 -2 2 v4 a2 2 0 0 0 2 2 h4 a2 2 0 0 0 2 -2 v-4 a2 2 0 0 0 -2 -2 z M9 13 h-4 a2 2 0 0 0 -2 2 v4 a2 2 0 0 0 2 2 h4 a2 2 0 0 0 2 -2 v-4 a2 2 0 0 0 -2 -2 z M9 3 h-4 a2 2 0 0 0 -2 2 v4 a2 2 0 0 0 2 2 h4 a2 2 0 0 0 2 -2 v-4 a2 2 0 0 0 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.AppsOff:
					return "M3 3 l18 18 M17 4 v6 M14 7 h6 M4 14 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M18 14 h1 a1 1 0 0 1 1 1 v1 m-0.29 3.704 a1 1 0 0 1 -0.71 0.296 h-4 a1 1 0 0 1 -1 -1 v-4 c0 -0.276 0.111 -0.525 0.292 -0.706 M8 4 h1 a1 1 0 0 1 1 1 v1 m-0.29 3.704 a1 1 0 0 1 -0.71 0.296 h-4 a1 1 0 0 1 -1 -1 v-4 c0 -0.276 0.111 -0.525 0.292 -0.706 M0 0 h24 v24 H0 z";
				case IconKind.Apps:
					return "M17 4 l0 6 M14 7 l6 0 M14 14 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M4 14 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M4 4 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.ArchiveOff:
					return "M3 3 l18 18 M10 12 h2 M5 8 v10 a2 2 0 0 0 2 2 h10 a2 2 0 0 0 1.824 -1.18 m0.176 -3.82 v-7 M8 4 h11 a2 2 0 1 1 0 4 h-7 m-4 0 h-3 a2 2 0 0 1 -0.826 -3.822 M0 0 h24 v24 H0 z";
				case IconKind.Archive:
					return "M10 12 l4 0 M5 8 v10 a2 2 0 0 0 2 2 h10 a2 2 0 0 0 2 -2 v-10 M3 4 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v0 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Armchair2Off:
					return "M3 3 l18 18 M17 19 v2 M7 19 v2 M8 12 h4 M16.124 12.145 a3 3 0 1 1 3.756 3.724 m-0.88 3.131 h-14 v-3 a3 3 0 1 1 3 -3 v2 M5 10 v-4 a3 3 0 0 1 0.128 -0.869 m2.038 -2.013 c0.264 -0.078 0.544 -0.118 0.834 -0.118 h8 a3 3 0 0 1 3 3 v4 M0 0 h24 v24 H0 z";
				case IconKind.Armchair2:
					return "M17 19 v2 M7 19 v2 M8 12 h8 M16 15 v-2 a3 3 0 1 1 3 3 v3 h-14 v-3 a3 3 0 1 1 3 -3 v2 M5 10 v-4 a3 3 0 0 1 3 -3 h8 a3 3 0 0 1 3 3 v4 M0 0 h24 v24 H0 z";
				case IconKind.ArmchairOff:
					return "M3 3 l18 18 M18 19 v2 M6 19 v2 M5 11 v-5 a3 3 0 0 1 0.134 -0.89 m1.987 -1.98 a3 3 0 0 1 0.879 -0.13 h8 a3 3 0 0 1 3 3 v5 M17 13 a2 2 0 1 1 4 0 v4 m-2 2 h-14 a2 2 0 0 1 -2 -2 v-4 a2 2 0 1 1 4 0 v2 h8.036 M0 0 h24 v24 H0 z";
				case IconKind.Armchair:
					return "M18 19 v2 M6 19 v2 M5 11 v-5 a3 3 0 0 1 3 -3 h8 a3 3 0 0 1 3 3 v5 M5 11 a2 2 0 0 1 2 2 v2 h10 v-2 a2 2 0 1 1 4 0 v4 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 v-4 a2 2 0 0 1 2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowAutofitContentFilled:
					return "M18 13 h-12 a3 3 0 0 0 -3 3 v2 a3 3 0 0 0 3 3 h12 a3 3 0 0 0 3 -3 v-2 a3 3 0 0 0 -3 -3 z M18.613 3.21 l0.094 0.083 l3 3 a0.927 0.927 0 0 1 0.097 0.112 l0.071 0.11 l0.054 0.114 l0.035 0.105 l0.03 0.148 l0.006 0.118 l-0.003 0.075 l-0.017 0.126 l-0.03 0.111 l-0.044 0.111 l-0.052 0.098 l-0.074 0.104 l-0.073 0.082 l-3 3 a1 1 0 0 1 -1.497 -1.32 l0.083 -0.094 l1.292 -1.293 h-4.585 a1 1 0 0 1 -0.117 -1.993 l0.117 -0.007 h4.585 l-1.292 -1.293 a1 1 0 0 1 -0.083 -1.32 l0.083 -0.094 a1 1 0 0 1 1.32 -0.083 z M6.707 3.293 a1 1 0 0 1 0.083 1.32 l-0.083 0.094 l-1.292 1.293 h4.585 a1 1 0 0 1 0.117 1.993 l-0.117 0.007 h-4.585 l1.292 1.293 a1 1 0 0 1 0.083 1.32 l-0.083 0.094 a1 1 0 0 1 -1.32 0.083 l-0.094 -0.083 l-3 -3 a1.008 1.008 0 0 1 -0.097 -0.112 l-0.071 -0.11 l-0.054 -0.114 l-0.035 -0.105 l-0.025 -0.118 l-0.007 -0.058 l-0.004 -0.09 l0.003 -0.075 l0.017 -0.126 l0.03 -0.111 l0.044 -0.111 l0.052 -0.098 l0.064 -0.092 l0.083 -0.094 l3 -3 a1 1 0 0 1 1.414 0 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowAutofitContent:
					return "M21 7 h-7 M10 7 h-7 M4 14 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v2 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M18 4 l3 3 l-3 3 M6 4 l-3 3 l3 3 M0 0 h24 v24 H0 z";
				case IconKind.ArrowAutofitDown:
					return "M15 18 l3 3 l3 -3 M18 4 v17 M12 20 h-6 a2 2 0 0 1 -2 -2 v-12 a2 2 0 0 1 2 -2 h8 M0 0 h24 v24 H0 z";
				case IconKind.ArrowAutofitHeight:
					return "M15 6 l3 -3 l3 3 M15 18 l3 3 l3 -3 M18 3 v7 M18 14 v7 M12 20 h-6 a2 2 0 0 1 -2 -2 v-12 a2 2 0 0 1 2 -2 h6 M0 0 h24 v24 H0 z";
				case IconKind.ArrowAutofitLeft:
					return "M6 15 l-3 3 l3 3 M20 18 h-17 M4 12 v-6 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v8 M0 0 h24 v24 H0 z";
				case IconKind.ArrowAutofitRight:
					return "M18 15 l3 3 l-3 3 M4 18 h17 M20 12 v-6 a2 2 0 0 0 -2 -2 h-12 a2 2 0 0 0 -2 2 v8 M0 0 h24 v24 H0 z";
				case IconKind.ArrowAutofitUp:
					return "M15 6 l3 -3 l3 3 M18 20 v-17 M12 4 h-6 a2 2 0 0 0 -2 2 v12 a2 2 0 0 0 2 2 h8 M0 0 h24 v24 H0 z";
				case IconKind.ArrowAutofitWidth:
					return "M18 15 l3 3 l-3 3 M6 15 l-3 3 l3 3 M21 18 h-7 M10 18 h-7 M4 12 v-6 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v6 M0 0 h24 v24 H0 z";
				case IconKind.ArrowBackUp:
					return "M9 13 l-4 -4 l4 -4 m-4 4 h11 a4 4 0 0 1 0 8 h-1 M0 0 h24 v24 H0 z";
				case IconKind.ArrowBack:
					return "M9 11 l-4 4 l4 4 m-4 -4 h11 a4 4 0 0 0 0 -8 h-1 M0 0 h24 v24 H0 z";
				case IconKind.ArrowBadgeDown:
					return "M17 13 v-6 l-5 4 l-5 -4 v6 l5 4 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowBadgeLeft:
					return "M11 17 h6 l-4 -5 l4 -5 h-6 l-4 5 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowBadgeRight:
					return "M13 7 h-6 l4 5 l-4 5 h6 l4 -5 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowBadgeUp:
					return "M17 11 v6 l-5 -4 l-5 4 v-6 l5 -4 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowBarDown:
					return "M4 4 l16 0 M12 20 l-4 -4 M12 20 l4 -4 M12 20 l0 -10 M0 0 h24 v24 H0 z";
				case IconKind.ArrowBarLeft:
					return "M20 4 l0 16 M4 12 l4 -4 M4 12 l4 4 M4 12 l10 0 M0 0 h24 v24 H0 z";
				case IconKind.ArrowBarRight:
					return "M4 4 l0 16 M20 12 l-4 -4 M20 12 l-4 4 M20 12 l-10 0 M0 0 h24 v24 H0 z";
				case IconKind.ArrowBarToDown:
					return "M12 14 l-4 -4 M12 14 l4 -4 M12 14 l0 -10 M4 20 l16 0 M0 0 h24 v24 H0 z";
				case IconKind.ArrowBarToLeft:
					return "M4 4 l0 16 M10 12 l4 -4 M10 12 l4 4 M10 12 l10 0 M0 0 h24 v24 H0 z";
				case IconKind.ArrowBarToRight:
					return "M20 4 l0 16 M14 12 l-4 -4 M14 12 l-4 4 M14 12 l-10 0 M0 0 h24 v24 H0 z";
				case IconKind.ArrowBarToUp:
					return "M4 4 l16 0 M12 10 l-4 4 M12 10 l4 4 M12 10 l0 10 M0 0 h24 v24 H0 z";
				case IconKind.ArrowBarUp:
					return "M4 20 l16 0 M12 4 l-4 4 M12 4 l4 4 M12 4 l0 10 M0 0 h24 v24 H0 z";
				case IconKind.ArrowBearLeft2:
					return "M20 5 l-4.5 4.5 M4 3 l7.536 7.536 a5 5 0 0 1 1.464 3.534 v6.93 M9 3 h-5 v5 M0 0 h24 v24 H0 z";
				case IconKind.ArrowBearLeft:
					return "M8 3 l7.536 7.536 a5 5 0 0 1 1.464 3.534 v6.93 M13 3 h-5 v5 M0 0 h24 v24 H0 z";
				case IconKind.ArrowBearRight2:
					return "M4 5 l4.5 4.5 M20 3 l-7.536 7.536 a5 5 0 0 0 -1.464 3.534 v6.93 M15 3 h5 v5 M0 0 h24 v24 H0 z";
				case IconKind.ArrowBearRight:
					return "M17 3 l-7.536 7.536 a5 5 0 0 0 -1.464 3.534 v6.93 M12 3 h5 v5 M0 0 h24 v24 H0 z";
				case IconKind.ArrowBigDownFilled:
					return "M15 4 v8 h3.586 a1 1 0 0 1 0.707 1.707 l-6.586 6.586 a1 1 0 0 1 -1.414 0 l-6.586 -6.586 a1 1 0 0 1 0.707 -1.707 h3.586 v-8 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowBigDownLineFilled:
					return "M15 3 h-6 M15 12 h3.586 a1 1 0 0 1 0.707 1.707 l-6.586 6.586 a1 1 0 0 1 -1.414 0 l-6.586 -6.586 a1 1 0 0 1 0.707 -1.707 h3.586 v-6 h6 v6 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowBigDownLine:
					return "M15 3 h-6 M15 12 h3.586 a1 1 0 0 1 0.707 1.707 l-6.586 6.586 a1 1 0 0 1 -1.414 0 l-6.586 -6.586 a1 1 0 0 1 0.707 -1.707 h3.586 v-6 h6 v6 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowBigDownLinesFilled:
					return "M15 6 h-6 M15 3 h-6 M15 12 h3.586 a1 1 0 0 1 0.707 1.707 l-6.586 6.586 a1 1 0 0 1 -1.414 0 l-6.586 -6.586 a1 1 0 0 1 0.707 -1.707 h3.586 v-3 h6 v3 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowBigDownLines:
					return "M15 6 h-6 M15 3 h-6 M15 12 h3.586 a1 1 0 0 1 0.707 1.707 l-6.586 6.586 a1 1 0 0 1 -1.414 0 l-6.586 -6.586 a1 1 0 0 1 0.707 -1.707 h3.586 v-3 h6 v3 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowBigDown:
					return "M15 4 v8 h3.586 a1 1 0 0 1 0.707 1.707 l-6.586 6.586 a1 1 0 0 1 -1.414 0 l-6.586 -6.586 a1 1 0 0 1 0.707 -1.707 h3.586 v-8 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowBigLeftFilled:
					return "M20 15 h-8 v3.586 a1 1 0 0 1 -1.707 0.707 l-6.586 -6.586 a1 1 0 0 1 0 -1.414 l6.586 -6.586 a1 1 0 0 1 1.707 0.707 v3.586 h8 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowBigLeftLineFilled:
					return "M21 15 v-6 M12 15 v3.586 a1 1 0 0 1 -1.707 0.707 l-6.586 -6.586 a1 1 0 0 1 0 -1.414 l6.586 -6.586 a1 1 0 0 1 1.707 0.707 v3.586 h6 v6 h-6 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowBigLeftLine:
					return "M21 15 v-6 M12 15 v3.586 a1 1 0 0 1 -1.707 0.707 l-6.586 -6.586 a1 1 0 0 1 0 -1.414 l6.586 -6.586 a1 1 0 0 1 1.707 0.707 v3.586 h6 v6 h-6 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowBigLeftLinesFilled:
					return "M18 15 v-6 M21 15 v-6 M12 15 v3.586 a1 1 0 0 1 -1.707 0.707 l-6.586 -6.586 a1 1 0 0 1 0 -1.414 l6.586 -6.586 a1 1 0 0 1 1.707 0.707 v3.586 h3 v6 h-3 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowBigLeftLines:
					return "M18 15 v-6 M21 15 v-6 M12 15 v3.586 a1 1 0 0 1 -1.707 0.707 l-6.586 -6.586 a1 1 0 0 1 0 -1.414 l6.586 -6.586 a1 1 0 0 1 1.707 0.707 v3.586 h3 v6 h-3 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowBigLeft:
					return "M20 15 h-8 v3.586 a1 1 0 0 1 -1.707 0.707 l-6.586 -6.586 a1 1 0 0 1 0 -1.414 l6.586 -6.586 a1 1 0 0 1 1.707 0.707 v3.586 h8 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowBigRightFilled:
					return "M4 9 h8 v-3.586 a1 1 0 0 1 1.707 -0.707 l6.586 6.586 a1 1 0 0 1 0 1.414 l-6.586 6.586 a1 1 0 0 1 -1.707 -0.707 v-3.586 h-8 a1 1 0 0 1 -1 -1 v-4 a1 1 0 0 1 1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowBigRightLineFilled:
					return "M3 15 v-6 M12 9 v-3.586 a1 1 0 0 1 1.707 -0.707 l6.586 6.586 a1 1 0 0 1 0 1.414 l-6.586 6.586 a1 1 0 0 1 -1.707 -0.707 v-3.586 h-6 v-6 h6 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowBigRightLine:
					return "M3 9 v6 M12 9 v-3.586 a1 1 0 0 1 1.707 -0.707 l6.586 6.586 a1 1 0 0 1 0 1.414 l-6.586 6.586 a1 1 0 0 1 -1.707 -0.707 v-3.586 h-6 v-6 h6 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowBigRightLinesFilled:
					return "M6 9 v6 M3 9 v6 M12 9 v-3.586 a1 1 0 0 1 1.707 -0.707 l6.586 6.586 a1 1 0 0 1 0 1.414 l-6.586 6.586 a1 1 0 0 1 -1.707 -0.707 v-3.586 h-3 v-6 h3 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowBigRightLines:
					return "M6 9 v6 M3 9 v6 M12 9 v-3.586 a1 1 0 0 1 1.707 -0.707 l6.586 6.586 a1 1 0 0 1 0 1.414 l-6.586 6.586 a1 1 0 0 1 -1.707 -0.707 v-3.586 h-3 v-6 h3 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowBigRight:
					return "M4 9 h8 v-3.586 a1 1 0 0 1 1.707 -0.707 l6.586 6.586 a1 1 0 0 1 0 1.414 l-6.586 6.586 a1 1 0 0 1 -1.707 -0.707 v-3.586 h-8 a1 1 0 0 1 -1 -1 v-4 a1 1 0 0 1 1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowBigUpFilled:
					return "M9 20 v-8 h-3.586 a1 1 0 0 1 -0.707 -1.707 l6.586 -6.586 a1 1 0 0 1 1.414 0 l6.586 6.586 a1 1 0 0 1 -0.707 1.707 h-3.586 v8 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowBigUpLineFilled:
					return "M9 21 h6 M9 12 h-3.586 a1 1 0 0 1 -0.707 -1.707 l6.586 -6.586 a1 1 0 0 1 1.414 0 l6.586 6.586 a1 1 0 0 1 -0.707 1.707 h-3.586 v6 h-6 v-6 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowBigUpLine:
					return "M9 21 h6 M9 12 h-3.586 a1 1 0 0 1 -0.707 -1.707 l6.586 -6.586 a1 1 0 0 1 1.414 0 l6.586 6.586 a1 1 0 0 1 -0.707 1.707 h-3.586 v6 h-6 v-6 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowBigUpLinesFilled:
					return "M9 18 h6 M9 21 h6 M9 12 h-3.586 a1 1 0 0 1 -0.707 -1.707 l6.586 -6.586 a1 1 0 0 1 1.414 0 l6.586 6.586 a1 1 0 0 1 -0.707 1.707 h-3.586 v3 h-6 v-3 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowBigUpLines:
					return "M9 18 h6 M9 21 h6 M9 12 h-3.586 a1 1 0 0 1 -0.707 -1.707 l6.586 -6.586 a1 1 0 0 1 1.414 0 l6.586 6.586 a1 1 0 0 1 -0.707 1.707 h-3.586 v3 h-6 v-3 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowBigUp:
					return "M9 20 v-8 h-3.586 a1 1 0 0 1 -0.707 -1.707 l6.586 -6.586 a1 1 0 0 1 1.414 0 l6.586 6.586 a1 1 0 0 1 -0.707 1.707 h-3.586 v8 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowBounce:
					return "M15 6 h5 v5 M3 8 a9 9 0 0 1 9 9 v1 l1.428 -4.285 a12 12 0 0 1 6.018 -6.938 l0.554 -0.277 M10 18 h4 M0 0 h24 v24 H0 z";
				case IconKind.ArrowCurveLeft:
					return "M10 3 v4.394 a6.737 6.737 0 0 0 3 5.606 a6.737 6.737 0 0 1 3 5.606 v2.394 M14 7 l-4 -4 l-4 4 M0 0 h24 v24 H0 z";
				case IconKind.ArrowCurveRight:
					return "M14 3 v4.394 a6.737 6.737 0 0 1 -3 5.606 a6.737 6.737 0 0 0 -3 5.606 v2.394 M10 7 l4 -4 l4 4 M0 0 h24 v24 H0 z";
				case IconKind.ArrowDownBar:
					return "M9 3 h6 M9 18 l3 3 l3 -3 M12 3 v18 M0 0 h24 v24 H0 z";
				case IconKind.ArrowDownCircle:
					return "M12 7 a2 2 0 1 0 0 -4 a2 2 0 0 0 0 4 M9 18 l3 3 l3 -3 M12 7 v14 M0 0 h24 v24 H0 z";
				case IconKind.ArrowDownLeftCircle:
					return "M15.586 8.414 a2 2 0 1 0 2.828 -2.828 a2 2 0 0 0 -2.828 2.828 M6 14 v4 h4 M15.536 8.464 l-9.536 9.536 M0 0 h24 v24 H0 z";
				case IconKind.ArrowDownLeft:
					return "M16 17 l-9 0 l0 -9 M17 7 l-10 10 M0 0 h24 v24 H0 z";
				case IconKind.ArrowDownRhombus:
					return "M14.5 5.5 l-2.5 -2.5 l-2.5 2.5 l2.5 2.5 z M15 18 l-3 3 l-3 -3 M12 8 v13 M0 0 h24 v24 H0 z";
				case IconKind.ArrowDownRightCircle:
					return "M8.414 8.414 a2 2 0 1 0 -2.828 -2.828 a2 2 0 0 0 2.828 2.828 M14 18 h4 v-4 M8.464 8.464 l9.536 9.536 M0 0 h24 v24 H0 z";
				case IconKind.ArrowDownRight:
					return "M17 8 l0 9 l-9 0 M7 7 l10 10 M0 0 h24 v24 H0 z";
				case IconKind.ArrowDownSquare:
					return "M14 3 v4 h-4 v-4 z M9 18 l3 3 l3 -3 M12 7 v14 M0 0 h24 v24 H0 z";
				case IconKind.ArrowDownTail:
					return "M9 3 l3 3 l3 -3 M9 18 l3 3 l3 -3 M12 6 v15 M0 0 h24 v24 H0 z";
				case IconKind.ArrowDown:
					return "M6 13 l6 6 M18 13 l-6 6 M12 5 l0 14 M0 0 h24 v24 H0 z";
				case IconKind.ArrowFork:
					return "M3 3 l7.536 7.536 a5 5 0 0 1 1.464 3.534 v0.93 M21 3 l-7.536 7.536 a5 5 0 0 0 -1.464 3.534 v6.93 M8 3 h-5 v5 M16 3 h5 v5 M0 0 h24 v24 H0 z";
				case IconKind.ArrowForwardUp:
					return "M15 13 l4 -4 l-4 -4 m4 4 h-11 a4 4 0 0 0 0 8 h1 M0 0 h24 v24 H0 z";
				case IconKind.ArrowForward:
					return "M15 11 l4 4 l-4 4 m4 -4 h-11 a4 4 0 0 1 0 -8 h1 M0 0 h24 v24 H0 z";
				case IconKind.ArrowGuide:
					return "M18 4 l3 3 l-3 3 M7 19 h3 a2 2 0 0 0 2 -2 v-8 a2 2 0 0 1 2 -2 h7 M5 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.ArrowIteration:
					return "M18 13 l3 3 l-3 3 M3 16 h18 M8.5 16 a5.5 5.5 0 1 0 -5.5 -5.5 v0.5 M0 0 h24 v24 H0 z";
				case IconKind.ArrowLeftBar:
					return "M21 9 v6 M6 9 l-3 3 l3 3 M21 12 h-18 M0 0 h24 v24 H0 z";
				case IconKind.ArrowLeftCircle:
					return "M19 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 9 l-3 3 l3 3 M17 12 h-14 M0 0 h24 v24 H0 z";
				case IconKind.ArrowLeftRhombus:
					return "M18.5 9.5 l2.5 2.5 l-2.5 2.5 l-2.5 -2.5 z M6 9 l-3 3 l3 3 M16 12 h-13 M0 0 h24 v24 H0 z";
				case IconKind.ArrowLeftRight:
					return "M12 19 v-5 a5 5 0 0 0 -5 -5 h-4 M12 14 a5 5 0 0 1 5 -5 h4 M7 13 l-4 -4 l4 -4 M17 13 l4 -4 l-4 -4 M0 0 h24 v24 H0 z";
				case IconKind.ArrowLeftSquare:
					return "M21 14 h-4 v-4 h4 z M6 9 l-3 3 l3 3 M17 12 h-14 M0 0 h24 v24 H0 z";
				case IconKind.ArrowLeftTail:
					return "M21 9 l-3 3 l3 3 M6 9 l-3 3 l3 3 M18 12 h-15 M0 0 h24 v24 H0 z";
				case IconKind.ArrowLeft:
					return "M5 12 l6 -6 M5 12 l6 6 M5 12 l14 0 M0 0 h24 v24 H0 z";
				case IconKind.ArrowLoopLeft2:
					return "M8 16 l-4 -4 l4 -4 M13 21 v-6 m0 -6 v-1 a4 4 0 1 1 4 4 h-13 M0 0 h24 v24 H0 z";
				case IconKind.ArrowLoopLeft:
					return "M8 16 l-4 -4 l4 -4 M13 21 v-13 a4 4 0 1 1 4 4 h-13 M0 0 h24 v24 H0 z";
				case IconKind.ArrowLoopRight2:
					return "M17 16 l4 -4 l-4 -4 M12 21 v-6 m0 -6 v-1 a4 4 0 1 0 -4 4 h13 M0 0 h24 v24 H0 z";
				case IconKind.ArrowLoopRight:
					return "M17 16 l4 -4 l-4 -4 M12 21 v-13 a4 4 0 1 0 -4 4 h13 M0 0 h24 v24 H0 z";
				case IconKind.ArrowMergeBoth:
					return "M6 18 c4 -1.333 6 -4.667 6 -10 M18 18 c-4 -1.333 -6 -4.667 -6 -10 M12 20 v-16 M16 8 l-4 -4 l-4 4 M0 0 h24 v24 H0 z";
				case IconKind.ArrowMergeLeft:
					return "M6 18 c4 -1.333 6 -4.667 6 -10 M12 20 v-16 M8 8 l4 -4 l4 4 M0 0 h24 v24 H0 z";
				case IconKind.ArrowMergeRight:
					return "M18 18 c-4 -1.333 -6 -4.667 -6 -10 M12 20 v-16 M16 8 l-4 -4 l-4 4 M0 0 h24 v24 H0 z";
				case IconKind.ArrowMerge:
					return "M12 3 v5.394 a6.737 6.737 0 0 0 3 5.606 a6.737 6.737 0 0 1 3 5.606 v1.394 M12 3 v5.394 a6.737 6.737 0 0 1 -3 5.606 a6.737 6.737 0 0 0 -3 5.606 v1.394 M8 7 l4 -4 l4 4 M0 0 h24 v24 H0 z";
				case IconKind.ArrowMoveDown:
					return "M12 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M9 18 l3 3 l3 -3 M12 11 v10 M0 0 h24 v24 H0 z";
				case IconKind.ArrowMoveLeft:
					return "M17 12 a2 2 0 1 1 4 0 a2 2 0 0 1 -4 0 z M6 15 l-3 -3 l3 -3 M13 12 h-10 M0 0 h24 v24 H0 z";
				case IconKind.ArrowMoveRight:
					return "M7 12 a2 2 0 1 1 -4 0 a2 2 0 0 1 4 0 z M18 9 l3 3 l-3 3 M11 12 h10 M0 0 h24 v24 H0 z";
				case IconKind.ArrowMoveUp:
					return "M12 17 a2 2 0 1 1 0 4 a2 2 0 0 1 0 -4 z M9 6 l3 -3 l3 3 M12 13 v-10 M0 0 h24 v24 H0 z";
				case IconKind.ArrowNarrowDown:
					return "M8 15 l4 4 M16 15 l-4 4 M12 5 l0 14 M0 0 h24 v24 H0 z";
				case IconKind.ArrowNarrowLeft:
					return "M5 12 l4 -4 M5 12 l4 4 M5 12 l14 0 M0 0 h24 v24 H0 z";
				case IconKind.ArrowNarrowRight:
					return "M15 8 l4 4 M15 16 l4 -4 M5 12 l14 0 M0 0 h24 v24 H0 z";
				case IconKind.ArrowNarrowUp:
					return "M8 9 l4 -4 M16 9 l-4 -4 M12 5 l0 14 M0 0 h24 v24 H0 z";
				case IconKind.ArrowRampLeft2:
					return "M18 21 c0 -6.075 -4.925 -11 -11 -11 h-3 M8 14 l-4 -4 l4 -4 M18 3 v8.707 M0 0 h24 v24 H0 z";
				case IconKind.ArrowRampLeft3:
					return "M18 21 v-6 a3 3 0 0 0 -3 -3 h-11 M8 16 l-4 -4 l4 -4 M18 3 v6 M0 0 h24 v24 H0 z";
				case IconKind.ArrowRampLeft:
					return "M17 21 a11 11 0 0 0 -11 -11 h-3 M7 14 l-4 -4 l4 -4 M13 7 l4 -4 l4 4 M17 3 l0 8.707 M0 0 h24 v24 H0 z";
				case IconKind.ArrowRampRight2:
					return "M6 21 c0 -6.075 4.925 -11 11 -11 h3 M16 14 l4 -4 l-4 -4 M6 3 v8.707 M0 0 h24 v24 H0 z";
				case IconKind.ArrowRampRight3:
					return "M6 21 v-6 a3 3 0 0 1 3 -3 h11 M16 16 l4 -4 l-4 -4 M6 3 v6 M0 0 h24 v24 H0 z";
				case IconKind.ArrowRampRight:
					return "M7 21 a11 11 0 0 1 11 -11 h3 M17 14 l4 -4 l-4 -4 M11 7 l-4 -4 l-4 4 M7 3 l0 8.707 M0 0 h24 v24 H0 z";
				case IconKind.ArrowRightBar:
					return "M3 9 v6 M3 12 h18 M18 15 l3 -3 l-3 -3 M0 0 h24 v24 H0 z";
				case IconKind.ArrowRightCircle:
					return "M7 12 h14 M5 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M18 15 l3 -3 l-3 -3 M0 0 h24 v24 H0 z";
				case IconKind.ArrowRightRhombus:
					return "M5.5 9.5 l-2.5 2.5 l2.5 2.5 l2.5 -2.5 z M18 9 l3 3 l-3 3 M8 12 h13 M0 0 h24 v24 H0 z";
				case IconKind.ArrowRightSquare:
					return "M3 10 h4 v4 h-4 z M18 15 l3 -3 l-3 -3 M7 12 l14 0 M0 0 h24 v24 H0 z";
				case IconKind.ArrowRightTail:
					return "M6 12 l15 0 M3 15 l3 -3 l-3 -3 M18 15 l3 -3 l-3 -3 M0 0 h24 v24 H0 z";
				case IconKind.ArrowRight:
					return "M13 6 l6 6 M13 18 l6 -6 M5 12 l14 0 M0 0 h24 v24 H0 z";
				case IconKind.ArrowRotaryFirstLeft:
					return "M10 18 h-5 v-5 M13.5 9.5 l-8.5 8.5 M16 10 v10 M16 10 a3 3 0 1 1 0 -6 a3 3 0 0 1 0 6 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowRotaryFirstRight:
					return "M14 18 h5 v-5 M10.5 9.5 l8.5 8.5 M8 10 v10 M8 7 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.ArrowRotaryLastLeft:
					return "M11 3 h-5 v5 M12.5 9.5 l-6.5 -6.5 M15 15 v6 M15 15 a3 3 0 1 1 0 -6 a3 3 0 0 1 0 6 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowRotaryLastRight:
					return "M13 3 h5 v5 M11.5 9.5 l6.5 -6.5 M9 15 v6 M9 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.ArrowRotaryLeft:
					return "M7 11 l-4 -4 l4 -4 M13 7 h-10 M16 10 v10 M16 10 a3 3 0 1 1 0 -6 a3 3 0 0 1 0 6 z M0 0 h24 v24 H0 z";
				case IconKind.ArrowRotaryRight:
					return "M11 7 h10 M17 11 l4 -4 l-4 -4 M8 10 v10 M8 7 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.ArrowRotaryStraight:
					return "M9 7 l4 -4 l4 4 M13 3 v7 M13 16 v5 M13 13 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.ArrowRoundaboutLeft:
					return "M7 5 l-4 4 l4 4 M3 9 h8 a5 5 0 1 1 5 5 v7 M0 0 h24 v24 H0 z";
				case IconKind.ArrowRoundaboutRight:
					return "M17 5 l4 4 l-4 4 M21 9 h-8 a5 5 0 1 0 -5 5 v7 M0 0 h24 v24 H0 z";
				case IconKind.ArrowSharpTurnLeft:
					return "M11 16 h-5 v-5 M17 18 v-11.31 a0.7 0.7 0 0 0 -1.195 -0.495 l-9.805 9.805 M0 0 h24 v24 H0 z";
				case IconKind.ArrowSharpTurnRight:
					return "M13 16 h5 v-5 M7 18 v-11.31 a0.7 0.7 0 0 1 1.195 -0.495 l9.805 9.805 M0 0 h24 v24 H0 z";
				case IconKind.ArrowTopCircle:
					return "M12 17 a2 2 0 1 0 0 4 a2 2 0 0 0 0 -4 M15 6 l-3 -3 l-3 3 M12 17 v-14 M0 0 h24 v24 H0 z";
				case IconKind.ArrowUpBar:
					return "M9 21 l6 0 M15 6 l-3 -3 l-3 3 M12 21 l0 -18 M0 0 h24 v24 H0 z";
				case IconKind.ArrowUpCircle:
					return "M16 12 l-4 -4 M12 8 l0 8 M12 8 l-4 4 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.ArrowUpLeftCircle:
					return "M15.586 15.586 a2 2 0 1 0 2.828 2.828 a2 2 0 0 0 -2.828 -2.828 M10 6 h-4 v4 M15.536 15.536 l-9.536 -9.536 M0 0 h24 v24 H0 z";
				case IconKind.ArrowUpLeft:
					return "M16 7 l-9 0 l0 9 M7 7 l10 10 M0 0 h24 v24 H0 z";
				case IconKind.ArrowUpRhombus:
					return "M14.5 18.5 l-2.5 2.5 l-2.5 -2.5 l2.5 -2.5 z M15 6 l-3 -3 l-3 3 M12 16 v-13 M0 0 h24 v24 H0 z";
				case IconKind.ArrowUpRightCircle:
					return "M8.414 15.586 a2 2 0 1 0 -2.828 2.828 a2 2 0 0 0 2.828 -2.828 M18 10 v-4 h-4 M8.464 15.536 l9.536 -9.536 M0 0 h24 v24 H0 z";
				case IconKind.ArrowUpRight:
					return "M8 7 l9 0 l0 9 M17 7 l-10 10 M0 0 h24 v24 H0 z";
				case IconKind.ArrowUpSquare:
					return "M10 21 v-4 h4 v4 z M15 6 l-3 -3 l-3 3 M12 17 l0 -14 M0 0 h24 v24 H0 z";
				case IconKind.ArrowUpTail:
					return "M15 21 l-3 -3 l-3 3 M15 6 l-3 -3 l-3 3 M12 18 l0 -15 M0 0 h24 v24 H0 z";
				case IconKind.ArrowUp:
					return "M6 11 l6 -6 M18 11 l-6 -6 M12 5 l0 14 M0 0 h24 v24 H0 z";
				case IconKind.ArrowWaveLeftDown:
					return "M21 12 c-0.887 1.284 -2.48 2.033 -4 2 c-1.52 0.033 -3.113 -0.716 -4 -2 s-2.48 -2.033 -4 -2 c-1.52 -0.033 -3 1 -4 2 l-2 2 M7 14 h-4 v-4 M0 0 h24 v24 H0 z";
				case IconKind.ArrowWaveLeftUp:
					return "M21 12 c-0.887 -1.285 -2.48 -2.033 -4 -2 c-1.52 -0.033 -3.113 0.715 -4 2 c-0.887 1.284 -2.48 2.033 -4 2 c-1.52 0.033 -3 -1 -4 -2 l-2 -2 M7 10 h-4 v4 M0 0 h24 v24 H0 z";
				case IconKind.ArrowWaveRightDown:
					return "M3 12 c0.887 1.284 2.48 2.033 4 2 c1.52 0.033 3.113 -0.716 4 -2 s2.48 -2.033 4 -2 c1.52 -0.033 3 1 4 2 l2 2 M17 14 h4 v-4 M0 0 h24 v24 H0 z";
				case IconKind.ArrowWaveRightUp:
					return "M3 12 c0.887 -1.284 2.48 -2.033 4 -2 c1.52 -0.033 3.113 0.716 4 2 s2.48 2.033 4 2 c1.52 0.033 3 -1 4 -2 l2 -2 M17 10 h4 v4 M0 0 h24 v24 H0 z";
				case IconKind.ArrowZigZag:
					return "M13 7 l3 -3 l3 3 M6 20 v-10 l10 6 v-12 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsCross:
					return "M4 4 l16 16 M16 20 h4 v-4 M4 20 l5 -5 M15 9 l5 -5 M16 4 h4 v4 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsDiagonal2:
					return "M4 4 l6 6 M8 4 l-4 0 l0 4 M14 14 l6 6 M16 20 l4 0 l0 -4 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsDiagonalMinimize2:
					return "M10 14 l-6 6 M6 14 h4 v4 M20 4 l-6 6 M18 10 h-4 v-4 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsDiagonalMinimize:
					return "M14 14 l6 6 M18 14 h-4 v4 M4 4 l6 6 M6 10 h4 v-4 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsDiagonal:
					return "M4 20 l6 -6 M8 20 l-4 0 l0 -4 M14 10 l6 -6 M16 4 l4 0 l0 4 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsDiff:
					return "M13 8 l-4 -4 M13 8 l-4 4 M13 8 h-10 M11 16 l4 -4 M11 16 l4 4 M11 16 h10 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsDoubleNeSw:
					return "M21 10 l-11 11 M10 17 v4 h4 M10 3 h4 v4 M3 14 l11 -11 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsDoubleNwSe:
					return "M10 3 l11 11 M17 14 h4 v-4 M3 14 v-4 h4 M14 21 l-11 -11 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsDoubleSeNw:
					return "M21 14 l-11 -11 M14 3 h-4 v4 M14 17 v4 h-4 M3 10 l11 11 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsDoubleSwNe:
					return "M10 21 l11 -11 M17 10 h4 v4 M3 10 v4 h4 M14 3 l-11 11 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsDownUp:
					return "M20 6 l-3 -3 l-3 3 M7 21 l0 -18 M10 18 l-3 3 l-3 -3 M17 3 l0 18 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsDown:
					return "M17 21 l0 -18 M4 18 l3 3 l3 -3 M20 18 l-3 3 l-3 -3 M7 21 l0 -18 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsExchange2:
					return "M7 14 h14 l-4 4 M17 10 h-14 l4 -4 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsExchange:
					return "M17 14 h-14 l4 4 M7 10 h14 l-4 -4 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsHorizontal:
					return "M3 12 l18 0 M17 8 l4 4 l-4 4 M7 8 l-4 4 l4 4 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsJoin2:
					return "M18 15 l3 -3 l-3 -3 M3 17 h1.95 a5.854 5.854 0 0 0 4.798 -2.5 a5.854 5.854 0 0 1 4.798 -2.5 h5.454 M3 7 h1.948 c1.913 0 3.705 0.933 4.802 2.5 a5.861 5.861 0 0 0 4.802 2.5 h6.448 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsJoin:
					return "M18 15 l3 -3 l-3 -3 M3 17 h5 l3.495 -5 M3 7 h5 l3.5 5 h9.5 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsLeftDown:
					return "M13 17 l4 4 l4 -4 M3 7 h11 a3 3 0 0 1 3 3 v11 M7 3 l-4 4 l4 4 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsLeftRight:
					return "M18 20 l3 -3 l-3 -3 M3 7 l18 0 M6 10 l-3 -3 l3 -3 M21 17 l-18 0 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsLeft:
					return "M3 17 l18 0 M6 4 l-3 3 l3 3 M6 20 l-3 -3 l3 -3 M3 7 l18 0 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsMaximize:
					return "M4 4 l6 6 M8 4 l-4 0 l0 4 M14 14 l6 6 M16 20 l4 0 l0 -4 M4 20 l6 -6 M8 20 l-4 0 l0 -4 M14 10 l6 -6 M16 4 l4 0 l0 4 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsMinimize:
					return "M15 15 l6 6 M19 15 l-4 0 l0 4 M15 9 l6 -6 M19 9 l-4 0 l0 -4 M3 21 l6 -6 M5 15 l4 0 l0 4 M3 3 l6 6 M5 9 l4 0 l0 -4 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsMoveHorizontal:
					return "M3 12 h6 M6 9 l-3 3 l3 3 M15 12 h6 M18 9 l3 3 l-3 3 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsMoveVertical:
					return "M12 3 v6 M15 6 l-3 -3 l-3 3 M12 15 v6 M9 18 l3 3 l3 -3 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsMove:
					return "M12 3 v6 M15 6 l-3 -3 l-3 3 M12 15 v6 M9 18 l3 3 l3 -3 M3 12 h6 M6 9 l-3 3 l3 3 M15 12 h6 M18 9 l3 3 l-3 3 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsRandom:
					return "M20.5 9 l-4.5 -5.5 M21 5 l-0.5 4 l-4 -0.5 M8 15 l-3.5 6 M4 16 l4 -1 l1 4 M3 7.504 l6.83 -1.87 M6.5 9.504 l-3.5 -2 l2 -3.504 M16 21 l5 -5 M20 21 h-4 v-4 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsRightDown:
					return "M17 11 l4 -4 l-4 -4 M7 21 v-11 a3 3 0 0 1 3 -3 h11 M3 17 l4 4 l4 -4 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsRightLeft:
					return "M3 17 l18 0 M6 20 l-3 -3 l3 -3 M18 10 l3 -3 l-3 -3 M21 7 l-18 0 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsRight:
					return "M21 7 l-18 0 M18 20 l3 -3 l-3 -3 M18 4 l3 3 l-3 3 M21 17 l-18 0 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsShuffle2:
					return "M3 17 h3 a5 5 0 0 0 5 -5 a5 5 0 0 1 5 -5 h5 M3 7 h3 a5 5 0 0 1 5 5 a5 5 0 0 0 5 5 h5 M18 20 l3 -3 l-3 -3 M18 4 l3 3 l-3 3 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsShuffle:
					return "M21 7 h-5 a4.978 4.978 0 0 0 -3 1 m-4 8 a4.984 4.984 0 0 1 -3 1 h-3 M3 7 h3 a5 5 0 0 1 5 5 a5 5 0 0 0 5 5 h5 M18 20 l3 -3 l-3 -3 M18 4 l3 3 l-3 3 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsSort:
					return "M21 15 l-4 4 l-4 -4 m4 4 v-14 M3 9 l4 -4 l4 4 m-4 -4 v14 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsSplit2:
					return "M18 20 l3 -3 l-3 -3 M18 10 l3 -3 l-3 -3 M21 7 h-5.395 a5 5 0 0 0 -4.098 2.135 l-0.51 0.73 a5 5 0 0 1 -4.097 2.135 h-3.9 M21 17 h-5.397 a5 5 0 0 1 -4.096 -2.133 l-0.514 -0.734 a5 5 0 0 0 -4.096 -2.133 h-3.897 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsSplit:
					return "M18 20 l3 -3 l-3 -3 M18 10 l3 -3 l-3 -3 M21 7 h-8 l-3.495 5 M21 17 h-8 l-3.5 -5 h-6.5 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsTransferDown:
					return "M17 15 v-2 M17 21 v-2 M20 6 l-3 -3 l-3 3 M7 21 v-18 M10 18 l-3 3 l-3 -3 M17 3 v6 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsTransferUp:
					return "M7 9 v2 M7 3 v2 M10 18 l-3 3 l-3 -3 M17 3 v18 M20 6 l-3 -3 l-3 3 M7 21 v-6 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsUpDown:
					return "M17 21 l0 -18 M20 18 l-3 3 l-3 -3 M10 6 l-3 -3 l-3 3 M7 3 l0 18 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsUpLeft:
					return "M7 13 l-4 4 l4 4 M17 3 v11 a3 3 0 0 1 -3 3 h-11 M21 7 l-4 -4 l-4 4 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsUpRight:
					return "M11 7 l-4 -4 l-4 4 M21 17 h-11 a3 3 0 0 1 -3 -3 v-11 M17 21 l4 -4 l-4 -4 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsUp:
					return "M7 3 l0 18 M20 6 l-3 -3 l-3 3 M4 6 l3 -3 l3 3 M17 3 l0 18 M0 0 h24 v24 H0 z";
				case IconKind.ArrowsVertical:
					return "M12 3 l0 18 M8 17 l4 4 l4 -4 M8 7 l4 -4 l4 4 M0 0 h24 v24 H0 z";
				case IconKind.ArtboardOff:
					return "M3 3 l18 18 M16 20 v1 M8 20 v1 M20 16 h1 M20 8 h1 M16 3 v1 M8 3 v1 M3 16 h1 M3 8 h1 M15.716 15.698 a1 1 0 0 1 -0.716 0.302 h-6 a1 1 0 0 1 -1 -1 v-6 c0 -0.273 0.11 -0.52 0.287 -0.7 M12 8 h3 a1 1 0 0 1 1 1 v3 M0 0 h24 v24 H0 z";
				case IconKind.Artboard:
					return "M16 20 l0 1 M8 20 l0 1 M20 16 l1 0 M20 8 l1 0 M16 3 l0 1 M8 3 l0 1 M3 16 l1 0 M3 8 l1 0 M8 8 m0 1 a1 1 0 0 1 1 -1 h6 a1 1 0 0 1 1 1 v6 a1 1 0 0 1 -1 1 h-6 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.ArticleOff:
					return "M3 3 l18 18 M7 16 h9 M7 12 h5 m4 0 h1 M7 8 h1 m4 0 h5 M8 4 h11 a2 2 0 0 1 2 2 v11 m-1.172 2.821 a1.993 1.993 0 0 1 -0.828 0.179 h-14 a2 2 0 0 1 -2 -2 v-12 a2 2 0 0 1 1.156 -1.814 M0 0 h24 v24 H0 z";
				case IconKind.Article:
					return "M7 16 h10 M7 12 h10 M7 8 h10 M3 4 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.AspectRatioOff:
					return "M3 3 l18 18 M17 12 v1 m-2 2 h-1 M7 12 v-3 h2 M9 5 h10 a2 2 0 0 1 2 2 v10 m-2 2 h-14 a2 2 0 0 1 -2 -2 v-10 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.AspectRatio:
					return "M17 12 v3 h-3 M7 12 v-3 h3 M3 5 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.AssemblyOff:
					return "M3 3 l18 18 M11.593 7.591 c0.295 -0.133 0.637 -0.12 0.921 0.04 l3 1.79 h-0.014 c0.312 0.181 0.503 0.516 0.5 0.877 v1.702 m-1.152 2.86 l-2.363 1.514 a1 1 0 0 1 -0.97 0 l-3 -1.922 a1 1 0 0 1 -0.515 -0.876 v-3.278 c0 -0.364 0.197 -0.7 0.514 -0.877 l0.568 -0.339 M8.703 4.685 l2.326 -1.385 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 a2 2 0 0 1 1 1.747 v6.536 c0 0.248 -0.046 0.49 -0.132 0.715 m-2.156 1.837 l-4.741 3.029 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l1.157 -0.689 M0 0 h24 v24 H0 z";
				case IconKind.Assembly:
					return "M15.5 9.422 c0.312 0.18 0.503 0.515 0.5 0.876 v3.277 c0 0.364 -0.197 0.7 -0.515 0.877 l-3 1.922 a1 1 0 0 1 -0.97 0 l-3 -1.922 a1 1 0 0 1 -0.515 -0.876 v-3.278 c0 -0.364 0.197 -0.7 0.514 -0.877 l3 -1.79 c0.311 -0.174 0.69 -0.174 1 0 l3 1.79 h-0.014 z M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.Asset:
					return "M9 15 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6.079 9.756 l12.217 -6.631 M14.218 17.975 l6.619 -12.174 M19 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M9 15 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M9 15 m-6 0 a6 6 0 1 0 12 0 a6 6 0 1 0 -12 0 M0 0 h24 v24 H0 z";
				case IconKind.AsteriskSimple:
					return "M12 12 l-6 8.5 M12 12 l6 8.5 M12 12 l9 -2.5 M12 12 l-9 -2.5 M12 12 v-9 M0 0 h24 v24 H0 z";
				case IconKind.Asterisk:
					return "M12 12 l-8 4.5 M12 3 v9 M12 12 l8 4.5 M12 12 l-8 -4.5 M12 12 v9 M12 12 l8 -4.5 M0 0 h24 v24 H0 z";
				case IconKind.AtOff:
					return "M3 3 l18 18 M19.695 15.697 a2.5 2.5 0 0 0 1.305 -2.197 v-1.5 a9 9 0 0 0 -13.055 -8.047 m-2.322 1.683 a9 9 0 0 0 9.877 14.644 M9.174 9.17 a4 4 0 0 0 5.646 5.668 m1.18 -2.838 a4 4 0 0 0 -4 -4 M0 0 h24 v24 H0 z";
				case IconKind.At:
					return "M16 12 v1.5 a2.5 2.5 0 0 0 5 0 v-1.5 a9 9 0 1 0 -5.5 8.28 M12 12 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M0 0 h24 v24 H0 z";
				case IconKind.Atom2:
					return "M6.2 5 a9 9 0 0 1 11.4 0 M16 20.1 a9 9 0 0 0 5 -7.1 M8 20.1 a9 9 0 0 1 -5 -7.1 M21 9 l0 0.01 M3 9 l0 0.01 M12 21 l0 0.01 M12 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.AtomOff:
					return "M3 3 l18 18 M4.929 4.929 c-1.562 1.562 0.337 6 4.243 9.9 c3.905 3.905 8.337 5.804 9.9 4.242 m-0.072 -4.071 c-0.767 -1.794 -2.215 -3.872 -4.172 -5.828 c-1.944 -1.945 -4.041 -3.402 -5.828 -4.172 M9.172 9.172 c-3.906 3.905 -5.805 8.337 -4.243 9.9 c1.562 1.561 6 -0.338 9.9 -4.244 m1.884 -2.113 c2.587 -3.277 3.642 -6.502 2.358 -7.786 c-1.284 -1.284 -4.508 -0.23 -7.784 2.357 M12 12 v0.01 M0 0 h24 v24 H0 z";
				case IconKind.Atom:
					return "M4.929 4.929 c-1.562 1.562 0.337 6 4.243 9.9 c3.905 3.905 8.337 5.804 9.9 4.242 c1.561 -1.562 -0.338 -6 -4.244 -9.9 c-3.905 -3.905 -8.337 -5.804 -9.9 -4.242 M19.071 4.929 c-1.562 -1.562 -6 0.337 -9.9 4.243 c-3.905 3.905 -5.804 8.337 -4.242 9.9 c1.562 1.561 6 -0.338 9.9 -4.244 c3.905 -3.905 5.804 -8.337 4.242 -9.9 M12 12 v0.01 M0 0 h24 v24 H0 z";
				case IconKind.AugmentedReality2:
					return "M11 4 h2 M17 17 l4 -2.5 M13 14.5 v4.5 l4 2.5 M17 17 l-4 -2.5 l4 -2.5 l4 2.5 v4.5 l-4 2.5 z M10 21 h-2 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v3.5 M0 0 h24 v24 H0 z";
				case IconKind.AugmentedRealityOff:
					return "M3 3 l18 18 M8 10 v4.5 l4 2.5 M9.225 9.235 l-1.225 0.765 l4 2.5 v4.5 l3.076 -1.923 m0.924 -3.077 v-2 l-4 -2.5 l-0.302 0.189 M12 12.5 l0.312 -0.195 m2.457 -1.536 l1.231 -0.769 M16 20 h2 c0.558 0 1.062 -0.228 1.425 -0.596 M16 4 h2 a2 2 0 0 1 2 2 v2 M4 16 v2 a2 2 0 0 0 2 2 h2 M4 8 v-2 c0 -0.557 0.228 -1.061 0.595 -1.424 M0 0 h24 v24 H0 z";
				case IconKind.AugmentedReality:
					return "M8 10 v4.5 l4 2.5 M8 10 l4 2.5 v4.5 l4 -2.5 v-4.5 l-4 -2.5 z M12 12.5 l4 -2.5 M16 20 h2 a2 2 0 0 0 2 -2 v-2 M16 4 h2 a2 2 0 0 1 2 2 v2 M4 16 v2 a2 2 0 0 0 2 2 h2 M4 8 v-2 a2 2 0 0 1 2 -2 h2 M0 0 h24 v24 H0 z";
				case IconKind.AwardOff:
					return "M3 3 l18 18 M6.802 12 l-3.4 5.89 l3.598 -0.233 l1.598 3.232 l3.4 -5.889 M12 15 l3.4 5.89 l1.598 -3.233 l0.707 0.046 m1.108 -2.902 l-1.617 -2.8 M16.72 12.704 a6 6 0 0 0 -8.433 -8.418 m-1.755 2.24 a6 6 0 0 0 7.936 7.944 M0 0 h24 v24 H0 z";
				case IconKind.Award:
					return "M6.802 12 l-3.4 5.89 l3.598 -0.233 l1.598 3.232 l3.4 -5.889 M12 15 l3.4 5.89 l1.598 -3.233 l3.598 0.232 l-3.4 -5.889 M12 9 m-6 0 a6 6 0 1 0 12 0 a6 6 0 1 0 -12 0 M0 0 h24 v24 H0 z";
				case IconKind.Axe:
					return "M6.66 15.66 l-3.32 -3.32 a1.25 1.25 0 0 1 0.42 -2.044 l3.24 -1.296 l6 -6 l3 3 l-6 6 l-1.296 3.24 a1.25 1.25 0 0 1 -2.044 0.42 z M13 9 l7.383 7.418 c0.823 0.82 0.823 2.148 0 2.967 a2.11 2.11 0 0 1 -2.976 0 l-7.407 -7.385 M0 0 h24 v24 H0 z";
				case IconKind.AxisX:
					return "M4 17 h16 M17 20 l3 -3 l-3 -3 M4 5 v0.01 M4 9 v0.01 M4 13 v0.01 M0 0 h24 v24 H0 z";
				case IconKind.AxisY:
					return "M7 20 v-16 M4 7 l3 -3 l3 3 M19 20 h-0.01 M15 20 h-0.01 M11 20 h-0.01 M0 0 h24 v24 H0 z";
				case IconKind.BabyBottle:
					return "M12 4 a5 5 0 0 1 5 5 v11 a2 2 0 0 1 -2 2 h-6 a2 2 0 0 1 -2 -2 v-11 a5 5 0 0 1 5 -5 z M12 2 v2 M5 10 h14 M0 0 h24 v24 H0 z";
				case IconKind.BabyCarriage:
					return "M16 14 l1 3 M9 17 l1 -3 M6 9 h14 M2 5 h2.5 l1.632 4.897 a6 6 0 0 0 5.693 4.103 h2.675 a5.5 5.5 0 0 0 0 -11 h-0.5 v6 M18 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M8 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Backhoe:
					return "M21.12 9.88 a3 3 0 0 1 -2.12 5.12 a3 3 0 0 1 -2.12 -0.88 l4.24 -4.24 z M21.12 9.88 l-3.12 -4.88 l-5 5 M5 15 v-2 a1 1 0 0 1 1 -1 h7 M8 12 v-5 h2 a3 3 0 0 1 3 3 v5 M4 15 l9 0 M13 19 l-9 0 M13 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M4 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.BackpackOff:
					return "M3 3 l18 18 M9 21 v-4 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v4 M10 6 v-1 a2 2 0 1 1 4 0 v1 M10 6 h3 a6 6 0 0 1 6 6 v3 m-0.129 3.872 a3 3 0 0 1 -2.871 2.128 h-8 a3 3 0 0 1 -3 -3 v-6 a5.99 5.99 0 0 1 2.285 -4.712 M0 0 h24 v24 H0 z";
				case IconKind.Backpack:
					return "M11 10 h2 M9 21 v-4 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v4 M10 6 v-1 a2 2 0 1 1 4 0 v1 M5 18 v-6 a6 6 0 0 1 6 -6 h2 a6 6 0 0 1 6 6 v6 a3 3 0 0 1 -3 3 h-8 a3 3 0 0 1 -3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.Backspace:
					return "M12 10 l4 4 m0 -4 l-4 4 M20 6 a1 1 0 0 1 1 1 v10 a1 1 0 0 1 -1 1 h-11 l-5 -5 a1.5 1.5 0 0 1 0 -2 l5 -5 z M0 0 h24 v24 H0 z";
				case IconKind.Badge3d:
					return "M14 9 v6 h1 a2 2 0 0 0 2 -2 v-2 a2 2 0 0 0 -2 -2 h-1 z M7 9.5 a0.5 0.5 0 0 1 0.5 -0.5 h1 a1.5 1.5 0 0 1 0 3 h-0.5 h0.5 a1.5 1.5 0 0 1 0 3 h-1 a0.5 0.5 0 0 1 -0.5 -0.5 M3 5 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Badge4k:
					return "M15 12 h-1 M17 9 l-2 3 l2 3 M14 9 v6 M10 9 v6 M7 9 v2 a1 1 0 0 0 1 1 h1 M3 5 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Badge8k:
					return "M8.5 12 h-0.5 a1 1 0 0 1 -1 -1 v-1 a1 1 0 0 1 1 -1 h1 a1 1 0 0 1 1 1 v1 a1 1 0 0 1 -1 1 h-1 a1 1 0 0 0 -1 1 v1 a1 1 0 0 0 1 1 h1 a1 1 0 0 0 1 -1 v-1 a1 1 0 0 0 -1 -1 M15 12 h-1 M17 9 l-2 3 l2 3 M14 9 v6 M3 5 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BadgeAd:
					return "M7 13 h3 M7 15 v-4.5 a1.5 1.5 0 0 1 3 0 v4.5 M14 9 v6 h1 a2 2 0 0 0 2 -2 v-2 a2 2 0 0 0 -2 -2 h-1 z M3 5 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BadgeAr:
					return "M14 12 h1.5 a1.5 1.5 0 0 0 0 -3 h-1.5 v6 m3 0 l-2 -3 M7 13 h3 M7 15 v-4.5 a1.5 1.5 0 0 1 3 0 v4.5 M3 5 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BadgeCc:
					return "M17 10.5 a1.5 1.5 0 0 0 -3 0 v3 a1.5 1.5 0 0 0 3 0 M10 10.5 a1.5 1.5 0 0 0 -3 0 v3 a1.5 1.5 0 0 0 3 0 M3 5 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BadgeFilled:
					return "M17 17 v-13 l-5 3 l-5 -3 v13 l5 3 z M0 0 h24 v24 H0 z";
				case IconKind.BadgeHd:
					return "M7 12 h3 M10 15 v-6 M7 15 v-6 M14 9 v6 h1 a2 2 0 0 0 2 -2 v-2 a2 2 0 0 0 -2 -2 h-1 z M3 5 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BadgeOff:
					return "M3 3 l18 18 M7 7 v10 l5 3 l5 -3 m0 -4 v-9 l-5 3 l-2.496 -1.497 M0 0 h24 v24 H0 z";
				case IconKind.BadgeSd:
					return "M7 14.25 c0 0.414 0.336 0.75 0.75 0.75 h1.25 a1 1 0 0 0 1 -1 v-1 a1 1 0 0 0 -1 -1 h-1 a1 1 0 0 1 -1 -1 v-1 a1 1 0 0 1 1 -1 h1.25 a0.75 0.75 0 0 1 0.75 0.75 M14 9 v6 h1 a2 2 0 0 0 2 -2 v-2 a2 2 0 0 0 -2 -2 h-1 z M3 5 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BadgeTm:
					return "M13 15 v-6 l2 3 l2 -3 v6 M8 9 v6 M6 9 h4 M3 5 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BadgeVo:
					return "M15.5 9 a1.5 1.5 0 0 1 1.5 1.5 v3 a1.5 1.5 0 0 1 -3 0 v-3 a1.5 1.5 0 0 1 1.5 -1.5 z M7 9 l2 6 l2 -6 M3 5 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BadgeVr:
					return "M7 9 l2 6 l2 -6 M14 12 h1.5 a1.5 1.5 0 0 0 0 -3 h-1.5 v6 m3 0 l-2 -3 M3 5 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BadgeWc:
					return "M17 10.5 a1.5 1.5 0 0 0 -3 0 v3 a1.5 1.5 0 0 0 3 0 M6.5 9 l0.5 6 l2 -4 l2 4 l0.5 -6 M3 5 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Badge:
					return "M17 17 v-13 l-5 3 l-5 -3 v13 l5 3 z M0 0 h24 v24 H0 z";
				case IconKind.BadgesOff:
					return "M3 3 l18 18 M13.873 9.876 l3.127 -1.876 v-4 l-5 3 l-2.492 -1.495 m-2.508 1.495 v1 l2.492 1.495 M14.505 14.497 l-2.505 1.503 l-5 -3 v4 l5 3 l5 -3 M0 0 h24 v24 H0 z";
				case IconKind.Badges:
					return "M17 8 v-4 l-5 3 l-5 -3 v4 l5 3 z M17 17 v-4 l-5 3 l-5 -3 v4 l5 3 z M0 0 h24 v24 H0 z";
				case IconKind.Baguette:
					return "M12.5 4.5 l1.5 3.5 M6.5 10.5 l1.5 3.5 M9.5 7.5 l1.5 3.5 M5.628 11.283 l5.644 -5.637 c2.665 -2.663 5.924 -3.747 8.663 -1.205 l0.188 0.181 a2.987 2.987 0 0 1 0 4.228 l-11.287 11.274 a3 3 0 0 1 -4.089 0.135 l-0.143 -0.135 c-2.728 -2.724 -1.704 -6.117 1.024 -8.841 z M0 0 h24 v24 H0 z";
				case IconKind.BallAmericanFootballOff:
					return "M3 3 l18 18 M16 3 a5 5 0 0 0 5 5 M6.813 6.802 a12.96 12.96 0 0 0 -3.813 9.198 a5 5 0 0 0 5 5 a12.96 12.96 0 0 0 9.186 -3.801 m1.789 -2.227 a12.94 12.94 0 0 0 2.025 -6.972 a5 5 0 0 0 -5 -5 a12.94 12.94 0 0 0 -6.967 2.022 M8 21 a5 5 0 0 0 -5 -5 M10 12 l2 2 M15 9 l-1 1 m-2 2 l-3 3 M0 0 h24 v24 H0 z";
				case IconKind.BallAmericanFootball:
					return "M16 3 a5 5 0 0 0 5 5 M16 3 c-7.18 0 -13 5.82 -13 13 a5 5 0 0 0 5 5 c7.18 0 13 -5.82 13 -13 a5 5 0 0 0 -5 -5 M8 21 a5 5 0 0 0 -5 -5 M12 10 l2 2 M10 12 l2 2 M15 9 l-6 6 M0 0 h24 v24 H0 z";
				case IconKind.BallBaseball:
					return "M11 16 l2 1 M16 11 l1 2 M7 11 l1 2 M11 7 l2 1 M13 13 l2 2 M9 9 l2 2 M20.98 11.505 a9 9 0 0 0 -9.475 9.475 M12.495 3.02 a9 9 0 0 1 -9.475 9.475 M5.636 18.364 a9 9 0 1 0 12.728 -12.728 a9 9 0 0 0 -12.728 12.728 z M0 0 h24 v24 H0 z";
				case IconKind.BallBasketball:
					return "M3 12 a9 9 0 0 1 9 9 M12 3 a9 9 0 0 0 9 9 M5.65 18.35 l12.7 -12.7 M5.65 5.65 l12.7 12.7 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.BallBowling:
					return "M14 12 l0 0.01 M15 8 l0 0.01 M11 9 l0 0.01 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.BallFootballOff:
					return "M3 3 l18 18 M7.245 10.455 l-3.745 -1.455 M9.061 16.045 l-2.561 2.955 M16.755 10.455 l3.745 -1.455 M15 16 l2.5 3 M12 7 v-4 M12 7 l4.755 3.455 l-0.566 1.743 l-0.98 3.014 l-0.209 0.788 h-6 l-1.755 -5.545 l1.86 -1.351 l2.313 -1.681 z M20.041 16.046 a9 9 0 0 0 -12.084 -12.09 m-2.323 1.683 a9 9 0 0 0 12.726 12.73 M0 0 h24 v24 H0 z";
				case IconKind.BallFootball:
					return "M12 7 v-4 m3 13 l2.5 3 m-0.74 -8.55 l3.74 -1.45 m-11.44 7.05 l-2.56 2.95 m0.74 -8.55 l-3.74 -1.45 M12 7 l4.76 3.45 l-1.76 5.55 h-6 l-1.76 -5.55 z M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.BallTennis:
					return "M18 5.3 a9 9 0 0 0 0 13.4 M6 5.3 a9 9 0 0 1 0 13.4 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.BallVolleyball:
					return "M15.549 15.147 a12 12 0 0 0 1.38 -10.611 M12 12 a8 8 0 0 0 -0.536 -8.928 M12.951 7.353 a12 12 0 0 0 -9.88 4.111 M12 12 a8 8 0 0 0 -7.464 4.928 M7.5 13.5 a12 12 0 0 0 8.5 6.5 M12 12 a8 8 0 0 0 8 4 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.BalloonOff:
					return "M3 3 l18 18 M12 17 v1 a2 2 0 0 1 -2 2 h-3 a2 2 0 0 0 -2 2 M7.762 3.753 a6 6 0 0 1 10.238 4.247 c0 1.847 -0.37 3.564 -1.007 4.993 m-1.59 2.42 c-0.967 1 -2.14 1.587 -3.403 1.587 c-3.314 0 -6 -4.03 -6 -9 c0 -0.593 0.086 -1.166 0.246 -1.707 M14 8 a2 2 0 0 0 -2 -2 M0 0 h24 v24 H0 z";
				case IconKind.Balloon:
					return "M12 17 v1 a2 2 0 0 1 -2 2 h-3 a2 2 0 0 0 -2 2 M6 8 a6 6 0 1 1 12 0 c0 4.97 -2.686 9 -6 9 s-6 -4.03 -6 -9 M14 8 a2 2 0 0 0 -2 -2 M0 0 h24 v24 H0 z";
				case IconKind.BallpenOff:
					return "M3 3 l18 18 M4 20 l1.768 -1.768 M16 12 l4.414 -4.414 a2 2 0 0 0 0 -2.829 l-1.171 -1.171 a2 2 0 0 0 -2.829 0 l-4.414 4.414 M10 10 l-4.172 4.172 a2.828 2.828 0 1 0 4 4 l4.172 -4.172 M14 6 l7 7 l-2 2 M0 0 h24 v24 H0 z";
				case IconKind.Ballpen:
					return "M4 20 l1.768 -1.768 M5.828 18.172 a2.828 2.828 0 0 0 4 0 l10.586 -10.586 a2 2 0 0 0 0 -2.829 l-1.171 -1.171 a2 2 0 0 0 -2.829 0 l-10.586 10.586 a2.828 2.828 0 0 0 0 4 z M14 6 l7 7 l-4 4 M0 0 h24 v24 H0 z";
				case IconKind.Ban:
					return "M5.7 5.7 l12.6 12.6 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.BandageOff:
					return "M3 3 l18 18 M10.513 6.487 l1.987 -1.987 a4.95 4.95 0 0 1 7 7 l-2.018 2.018 m-1.982 1.982 l-4 4 a4.95 4.95 0 0 1 -7 -7 l4 -4 M12 14 v0.01 M10 12 v0.01 M0 0 h24 v24 H0 z";
				case IconKind.Bandage:
					return "M4.5 12.5 l8 -8 a4.94 4.94 0 0 1 7 7 l-8 8 a4.94 4.94 0 0 1 -7 -7 M12 14 l0 0.01 M12 10 l0 0.01 M10 12 l0 0.01 M14 12 l0 0.01 M0 0 h24 v24 H0 z";
				case IconKind.BarbellOff:
					return "M3 3 l18 18 M22 12 h-1 M18 8 h2 a1 1 0 0 1 1 1 v6 a1 1 0 0 1 -1 1 M15 15 v2 a1 1 0 0 0 1 1 h1 c0.275 0 0.523 -0.11 0.704 -0.29 m0.296 -3.71 v-7 a1 1 0 0 0 -1 -1 h-1 a1 1 0 0 0 -1 1 v4 M9 12 h3 M6.298 6.288 a1 1 0 0 0 -0.298 0.712 v10 a1 1 0 0 0 1 1 h1 a1 1 0 0 0 1 -1 v-8 M6 8 h-2 a1 1 0 0 0 -1 1 v6 a1 1 0 0 0 1 1 h2 M2 12 h1 M0 0 h24 v24 H0 z";
				case IconKind.Barbell:
					return "M22 12 h-1 M18 8 h2 a1 1 0 0 1 1 1 v6 a1 1 0 0 1 -1 1 h-2 M15 7 v10 a1 1 0 0 0 1 1 h1 a1 1 0 0 0 1 -1 v-10 a1 1 0 0 0 -1 -1 h-1 a1 1 0 0 0 -1 1 z M9 12 h6 M6 7 v10 a1 1 0 0 0 1 1 h1 a1 1 0 0 0 1 -1 v-10 a1 1 0 0 0 -1 -1 h-1 a1 1 0 0 0 -1 1 z M6 8 h-2 a1 1 0 0 0 -1 1 v6 a1 1 0 0 0 1 1 h2 M2 12 h1 M0 0 h24 v24 H0 z";
				case IconKind.BarcodeOff:
					return "M3 3 l18 18 M19 11 v2 M15 11 v0.01 M10 11 v2 M5 11 h1 v2 h-1 z M16 20 h2 c0.551 0 1.05 -0.223 1.412 -0.584 M16 4 h2 a2 2 0 0 1 2 2 v1 M4 17 v1 a2 2 0 0 0 2 2 h2 M4 7 v-1 c0 -0.552 0.224 -1.052 0.586 -1.414 M0 0 h24 v24 H0 z";
				case IconKind.Barcode:
					return "M19 11 l0 2 M14 11 h1 v2 h-1 z M10 11 l0 2 M5 11 h1 v2 h-1 z M16 20 h2 a2 2 0 0 0 2 -2 v-1 M16 4 h2 a2 2 0 0 1 2 2 v1 M4 17 v1 a2 2 0 0 0 2 2 h2 M4 7 v-1 a2 2 0 0 1 2 -2 h2 M0 0 h24 v24 H0 z";
				case IconKind.BarrelOff:
					return "M3 3 l18 18 M19.5 8 h-7.5 m-4 0 h-3.5 M4.5 16 h11.5 M10 4 a34.42 34.42 0 0 0 -0.366 1.632 m-0.506 3.501 a32.126 32.126 0 0 0 -0.128 2.867 c0 2.667 0.333 5.333 1 8 M14 4 c0.585 2.337 0.913 4.674 0.985 7.01 m-0.114 3.86 a33.415 33.415 0 0 1 -0.871 5.13 M8 4 h8.722 a2 2 0 0 1 1.841 1.22 c0.958 2.26 1.437 4.52 1.437 6.78 a16.35 16.35 0 0 1 -0.407 3.609 m-0.964 3.013 l-0.066 0.158 a2 2 0 0 1 -1.841 1.22 h-9.444 a2 2 0 0 1 -1.841 -1.22 c-0.958 -2.26 -1.437 -4.52 -1.437 -6.78 c0 -2.21 0.458 -4.42 1.374 -6.63 M0 0 h24 v24 H0 z";
				case IconKind.Barrel:
					return "M19.5 8 h-15 M4.5 16 h15 M10 4 c-0.667 2.667 -1 5.333 -1 8 s0.333 5.333 1 8 M14 4 c0.667 2.667 1 5.333 1 8 s-0.333 5.333 -1 8 M7.278 4 h9.444 a2 2 0 0 1 1.841 1.22 c0.958 2.26 1.437 4.52 1.437 6.78 c0 2.26 -0.479 4.52 -1.437 6.78 a2 2 0 0 1 -1.841 1.22 h-9.444 a2 2 0 0 1 -1.841 -1.22 c-0.958 -2.26 -1.437 -4.52 -1.437 -6.78 c0 -2.26 0.479 -4.52 1.437 -6.78 a2 2 0 0 1 1.841 -1.22 z M0 0 h24 v24 H0 z";
				case IconKind.BarrierBlockOff:
					return "M3 3 l18 18 M17 7 v-2 M15 20 h4 M5 20 h4 M17 17 v3 M4 13.5 l4.752 -4.752 M16.741 12.759 l3.259 -3.259 M13.5 16 l1.249 -1.249 M13.745 9.755 l2.755 -2.755 M7.5 16 l4.244 -4.244 M7 16 v4 M16 16 h-11 a1 1 0 0 1 -1 -1 v-7 a1 1 0 0 1 1 -1 h2 M11 7 h8 a1 1 0 0 1 1 1 v7 c0 0.27 -0.107 0.516 -0.282 0.696 M0 0 h24 v24 H0 z";
				case IconKind.BarrierBlock:
					return "M7 7 v-2 M17 7 v-2 M15 20 h4 M5 20 h4 M17 16 v4 M4 13.5 l6.5 -6.5 M13.5 16 l6.5 -6.5 M7.5 16 l9 -9 M7 16 v4 M4 7 m0 1 a1 1 0 0 1 1 -1 h14 a1 1 0 0 1 1 1 v7 a1 1 0 0 1 -1 1 h-14 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.Baseline:
					return "M8 10 h8 M8 16 v-8 a4 4 0 1 1 8 0 v8 M4 20 h16 M0 0 h24 v24 H0 z";
				case IconKind.BasketOff:
					return "M3 3 l18 18 M12 15 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M14 10 h7 l-1.397 5.587 M18.77 18.757 c-0.358 0.768 -1.027 1.262 -1.77 1.243 h-10 c-0.966 0.024 -1.807 -0.817 -2 -2 l-2 -8 h7 M10.176 6.188 l1.824 -2.188 l5 6 M7 10 l1.359 -1.63 M0 0 h24 v24 H0 z";
				case IconKind.Basket:
					return "M12 15 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M21 10 l-2 8 a2 2.5 0 0 1 -2 2 h-10 a2 2.5 0 0 1 -2 -2 l-2 -8 z M7 10 l5 -6 l5 6 M0 0 h24 v24 H0 z";
				case IconKind.Bat:
					return "M9 8 a3 3 0 0 0 6 0 M17 16 c0.74 -2.286 2.778 -3.762 5 -3 c-0.173 -2.595 0.13 -5.314 -2 -7.5 c-1.708 2.648 -3.358 2.557 -5 2.5 v-4 l-3 2 l-3 -2 v4 c-1.642 0.057 -3.292 0.148 -5 -2.5 c-2.13 2.186 -1.827 4.905 -2 7.5 c2.222 -0.762 4.26 0.714 5 3 c2.593 0 3.889 0.952 5 4 c1.111 -3.048 2.407 -4 5 -4 z M0 0 h24 v24 H0 z";
				case IconKind.BathOff:
					return "M3 3 l18 18 M20 21 l-1 -1.5 M4 21 l1 -1.5 M6 12 v-6 m1.178 -2.824 c0.252 -0.113 0.53 -0.176 0.822 -0.176 h3 v2.25 M16 12 h4 a1 1 0 0 1 1 1 v3 c0 0.311 -0.036 0.614 -0.103 0.904 m-1.61 2.378 a3.982 3.982 0 0 1 -2.287 0.718 h-10 a4 4 0 0 1 -4 -4 v-3 a1 1 0 0 1 1 -1 h8 M0 0 h24 v24 H0 z";
				case IconKind.Bath:
					return "M20 21 l-1 -1.5 M4 21 l1 -1.5 M6 12 v-7 a2 2 0 0 1 2 -2 h3 v2.25 M4 12 h16 a1 1 0 0 1 1 1 v3 a4 4 0 0 1 -4 4 h-10 a4 4 0 0 1 -4 -4 v-3 a1 1 0 0 1 1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.Battery1:
					return "M7 10 l0 4 M6 7 h11 a2 2 0 0 1 2 2 v0.5 a0.5 0.5 0 0 0 0.5 0.5 a0.5 0.5 0 0 1 0.5 0.5 v3 a0.5 0.5 0 0 1 -0.5 0.5 a0.5 0.5 0 0 0 -0.5 0.5 v0.5 a2 2 0 0 1 -2 2 h-11 a2 2 0 0 1 -2 -2 v-6 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.Battery2:
					return "M10 10 l0 4 M7 10 l0 4 M6 7 h11 a2 2 0 0 1 2 2 v0.5 a0.5 0.5 0 0 0 0.5 0.5 a0.5 0.5 0 0 1 0.5 0.5 v3 a0.5 0.5 0 0 1 -0.5 0.5 a0.5 0.5 0 0 0 -0.5 0.5 v0.5 a2 2 0 0 1 -2 2 h-11 a2 2 0 0 1 -2 -2 v-6 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.Battery3:
					return "M13 10 l0 4 M10 10 l0 4 M7 10 l0 4 M6 7 h11 a2 2 0 0 1 2 2 v0.5 a0.5 0.5 0 0 0 0.5 0.5 a0.5 0.5 0 0 1 0.5 0.5 v3 a0.5 0.5 0 0 1 -0.5 0.5 a0.5 0.5 0 0 0 -0.5 0.5 v0.5 a2 2 0 0 1 -2 2 h-11 a2 2 0 0 1 -2 -2 v-6 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.Battery4:
					return "M16 10 l0 4 M13 10 l0 4 M10 10 l0 4 M7 10 l0 4 M6 7 h11 a2 2 0 0 1 2 2 v0.5 a0.5 0.5 0 0 0 0.5 0.5 a0.5 0.5 0 0 1 0.5 0.5 v3 a0.5 0.5 0 0 1 -0.5 0.5 a0.5 0.5 0 0 0 -0.5 0.5 v0.5 a2 2 0 0 1 -2 2 h-11 a2 2 0 0 1 -2 -2 v-6 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.BatteryAutomotive:
					return "M16 11.5 l0 3 M14.5 13 l3 0 M6.5 13 l3 0 M19 4 l0 2 M6 6 v-2 M3 6 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BatteryCharging2:
					return "M8 15 v-2.5 M4 15 v-2.5 M6 22 v-3 M3 15 h6 v2 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 v-2 z M4 9 a2 2 0 0 1 2 -2 h11 a2 2 0 0 1 2 2 v0.5 a0.5 0.5 0 0 0 0.5 0.5 a0.5 0.5 0 0 1 0.5 0.5 v3 a0.5 0.5 0 0 1 -0.5 0.5 a0.5 0.5 0 0 0 -0.5 0.5 v0.5 a2 2 0 0 1 -2 2 h-4.5 M0 0 h24 v24 H0 z";
				case IconKind.BatteryCharging:
					return "M12 8 l-2 4 h3 l-2 4 M8 7 h-2 a2 2 0 0 0 -2 2 v6 a2 2 0 0 0 2 2 h1 M16 7 h1 a2 2 0 0 1 2 2 v0.5 a0.5 0.5 0 0 0 0.5 0.5 a0.5 0.5 0 0 1 0.5 0.5 v3 a0.5 0.5 0 0 1 -0.5 0.5 a0.5 0.5 0 0 0 -0.5 0.5 v0.5 a2 2 0 0 1 -2 2 h-2 M0 0 h24 v24 H0 z";
				case IconKind.BatteryEco:
					return "M3 20 v-3 M3 16.143 c0 -2.84 2.09 -5.143 4.667 -5.143 h2.333 v0.857 c0 2.84 -2.09 5.143 -4.667 5.143 h-2.333 v-0.857 z M4 9 a2 2 0 0 1 2 -2 h11 a2 2 0 0 1 2 2 v0.5 a0.5 0.5 0 0 0 0.5 0.5 a0.5 0.5 0 0 1 0.5 0.5 v3 a0.5 0.5 0 0 1 -0.5 0.5 a0.5 0.5 0 0 0 -0.5 0.5 v0.5 a2 2 0 0 1 -2 2 h-5.5 M0 0 h24 v24 H0 z";
				case IconKind.BatteryFilled:
					return "M6 7 h11 a2 2 0 0 1 2 2 v0.5 a0.5 0.5 0 0 0 0.5 0.5 a0.5 0.5 0 0 1 0.5 0.5 v3 a0.5 0.5 0 0 1 -0.5 0.5 a0.5 0.5 0 0 0 -0.5 0.5 v0.5 a2 2 0 0 1 -2 2 h-11 a2 2 0 0 1 -2 -2 v-6 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.BatteryOff:
					return "M11 7 h6 a2 2 0 0 1 2 2 v0.5 a0.5 0.5 0 0 0 0.5 0.5 a0.5 0.5 0 0 1 0.5 0.5 v3 a0.5 0.5 0 0 1 -0.5 0.5 a0.5 0.5 0 0 0 -0.5 0.5 v0.5 m-2 2 h-11 a2 2 0 0 1 -2 -2 v-6 a2 2 0 0 1 2 -2 h1 M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.Battery:
					return "M6 7 h11 a2 2 0 0 1 2 2 v0.5 a0.5 0.5 0 0 0 0.5 0.5 a0.5 0.5 0 0 1 0.5 0.5 v3 a0.5 0.5 0 0 1 -0.5 0.5 a0.5 0.5 0 0 0 -0.5 0.5 v0.5 a2 2 0 0 1 -2 2 h-11 a2 2 0 0 1 -2 -2 v-6 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.BeachOff:
					return "M3 3 l18 18 M3 19.25 a2.4 2.4 0 0 1 1 -0.25 a2.4 2.4 0 0 1 2 1 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 a2.4 2.4 0 0 1 2 -1 a2.4 2.4 0 0 1 2 1 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 a2.4 2.4 0 0 1 1.135 -0.858 M12.794 12.82 l-0.794 1.376 M15 9 l-0.739 1.279 M16.732 10 c1.658 -2.87 2.225 -5.644 1.268 -6.196 c-0.957 -0.552 -3.075 1.326 -4.732 4.196 M10.27 6.269 l9.926 5.731 a6 6 0 0 0 -10.32 -6.123 M15.071 15.102 a7.502 7.502 0 0 0 -8.124 1.648 M0 0 h24 v24 H0 z";
				case IconKind.Beach:
					return "M3 19.25 a2.4 2.4 0 0 1 1 -0.25 a2.4 2.4 0 0 1 2 1 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 a2.4 2.4 0 0 1 2 -1 a2.4 2.4 0 0 1 2 1 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 a2.4 2.4 0 0 1 2 -1 a2.4 2.4 0 0 1 1 0.25 M15 9 l-3 5.196 M16.732 10 c1.658 -2.87 2.225 -5.644 1.268 -6.196 c-0.957 -0.552 -3.075 1.326 -4.732 4.196 M18 3.804 a6 6 0 0 0 -8.196 2.196 l10.392 6 a6 6 0 0 0 -2.196 -8.196 z M17.553 16.75 a7.5 7.5 0 0 0 -10.606 0 M0 0 h24 v24 H0 z";
				case IconKind.BedOff:
					return "M3 3 l18 18 M7 10 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M11 11 v3 M21 18 v-8 a2 2 0 0 0 -2 -2 h-7 M18 14 h3 M3 14 h11 M3 7 v11 M0 0 h24 v24 H0 z";
				case IconKind.Bed:
					return "M7 10 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M3 7 v11 m0 -4 h18 m0 4 v-8 a2 2 0 0 0 -2 -2 h-8 v6 M0 0 h24 v24 H0 z";
				case IconKind.BeerOff:
					return "M3 3 l18 18 M7 8 h1 m4 0 h5 M7 7 v1.111 c0 1.242 0.29 2.467 0.845 3.578 l0.31 0.622 a8 8 0 0 1 0.845 3.578 v4.111 h6 v-4.111 a8 8 0 0 1 0.045 -0.85 m0.953 -3.035 l0.157 -0.315 a8 8 0 0 0 0.845 -3.578 v-4.111 h-9 M0 0 h24 v24 H0 z";
				case IconKind.Beer:
					return "M7 8 h10 M9 20 h6 v-4.111 a8 8 0 0 1 0.845 -3.578 l0.31 -0.622 a8 8 0 0 0 0.845 -3.578 v-4.111 h-10 v4.111 a8 8 0 0 0 0.845 3.578 l0.31 0.622 a8 8 0 0 1 0.845 3.578 v4.111 z M0 0 h24 v24 H0 z";
				case IconKind.BellFilled:
					return "M9 17 v1 a3 3 0 0 0 6 0 v-1 M10 5 a2 2 0 0 1 4 0 a7 7 0 0 1 4 6 v3 a4 4 0 0 0 2 3 h-16 a4 4 0 0 0 2 -3 v-3 a7 7 0 0 1 4 -6 M0 0 h24 v24 H0 z";
				case IconKind.BellMinus:
					return "M10 11 l4 0 M9 17 v1 a3 3 0 0 0 6 0 v-1 M10 5 a2 2 0 1 1 4 0 a7 7 0 0 1 4 6 v3 a4 4 0 0 0 2 3 h-16 a4 4 0 0 0 2 -3 v-3 a7 7 0 0 1 4 -6 M0 0 h24 v24 H0 z";
				case IconKind.BellOff:
					return "M9 17 v1 a3 3 0 0 0 6 0 v-1 M17 17 h-13 a4 4 0 0 0 2 -3 v-3 a7 7 0 0 1 1.279 -3.716 m2.072 -1.934 c0.209 -0.127 0.425 -0.244 0.649 -0.35 a2 2 0 1 1 4 0 a7 7 0 0 1 4 6 v3 M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.BellPlus:
					return "M12 9 l0 4 M10 11 l4 0 M9 17 v1 a3 3 0 0 0 6 0 v-1 M10 5 a2 2 0 1 1 4 0 a7 7 0 0 1 4 6 v3 a4 4 0 0 0 2 3 h-16 a4 4 0 0 0 2 -3 v-3 a7 7 0 0 1 4 -6 M0 0 h24 v24 H0 z";
				case IconKind.BellRinging2:
					return "M7.343 12.414 l-0.707 0.707 a3 3 0 0 0 4.243 4.243 l0.707 -0.707 M19.364 4.636 a2 2 0 0 1 0 2.828 a7 7 0 0 1 -1.414 7.072 l-2.122 2.12 a4 4 0 0 0 -0.707 3.536 l-11.313 -11.312 a4 4 0 0 0 3.535 -0.707 l2.121 -2.123 a7 7 0 0 1 7.072 -1.414 a2 2 0 0 1 2.828 0 z M0 0 h24 v24 H0 z";
				case IconKind.BellRinging:
					return "M3 6.727 a11.05 11.05 0 0 1 2.792 -3.727 M21 6.727 a11.05 11.05 0 0 0 -2.794 -3.727 M9 17 v1 a3 3 0 0 0 6 0 v-1 M10 5 a2 2 0 0 1 4 0 a7 7 0 0 1 4 6 v3 a4 4 0 0 0 2 3 h-16 a4 4 0 0 0 2 -3 v-3 a7 7 0 0 1 4 -6 M0 0 h24 v24 H0 z";
				case IconKind.BellSchool:
					return "M20 8 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M10 10 v0.01 M16 17 a5.698 5.698 0 0 0 4.467 -7.932 l-0.467 -1.068 M13.5 15 h0.5 a2 2 0 0 1 2 2 v1 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 v-1 a2 2 0 0 1 2 -2 h0.5 M10 10 m-6 0 a6 6 0 1 0 12 0 a6 6 0 1 0 -12 0 M0 0 h24 v24 H0 z";
				case IconKind.BellX:
					return "M10.5 9.5 l3 3 m0 -3 l-3 3 M9 17 v1 a3 3 0 0 0 6 0 v-1 M10 5 a2 2 0 1 1 4 0 a7 7 0 0 1 4 6 v3 a4 4 0 0 0 2 3 h-16 a4 4 0 0 0 2 -3 v-3 a7 7 0 0 1 4 -6 M0 0 h24 v24 H0 z";
				case IconKind.BellZ:
					return "M10 9 h4 l-4 4 h4 M9 17 v1 a3 3 0 0 0 6 0 v-1 M10 5 a2 2 0 1 1 4 0 a7 7 0 0 1 4 6 v3 a4 4 0 0 0 2 3 h-16 a4 4 0 0 0 2 -3 v-3 a7 7 0 0 1 4 -6 M0 0 h24 v24 H0 z";
				case IconKind.Bell:
					return "M9 17 v1 a3 3 0 0 0 6 0 v-1 M10 5 a2 2 0 0 1 4 0 a7 7 0 0 1 4 6 v3 a4 4 0 0 0 2 3 h-16 a4 4 0 0 0 2 -3 v-3 a7 7 0 0 1 4 -6 M0 0 h24 v24 H0 z";
				case IconKind.Beta:
					return "M8 22 v-14 a4 4 0 0 1 4 -4 h0.5 a3.5 3.5 0 0 1 0 7 h-0.5 h0.5 a4.5 4.5 0 1 1 -4.5 4.5 v-0.5 M0 0 h24 v24 H0 z";
				case IconKind.Bible:
					return "M10 9 h4 M12 7 v6 M19 16 h-12 a2 2 0 0 0 -2 2 M19 4 v16 h-12 a2 2 0 0 1 -2 -2 v-12 a2 2 0 0 1 2 -2 h12 z M0 0 h24 v24 H0 z";
				case IconKind.BikeOff:
					return "M3 3 l18 18 M17 5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12 19 v-4 l-3 -3 l1.665 -1.332 m2.215 -1.772 l1.12 -0.896 l2 3 h3 M16.437 16.44 a3 3 0 0 0 4.123 4.123 m1.44 -2.563 a3 3 0 0 0 -3 -3 M5 18 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.Bike:
					return "M17 5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12 19 l0 -4 l-3 -3 l5 -4 l2 3 l3 0 M19 18 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M5 18 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.BinaryOff:
					return "M3 3 l18 18 M6 19 v0.01 M6 10 v0.01 M10.5 14 h2 a0.5 0.5 0 0 1 0.5 0.5 v4 a0.5 0.5 0 0 1 -0.5 0.5 h-2 a0.5 0.5 0 0 1 -0.5 -0.5 v-4 a0.5 0.5 0 0 1 0.5 -0.5 z M15.5 5 h2 a0.5 0.5 0 0 1 0.5 0.5 v4 a0.5 0.5 0 0 1 -0.5 0.5 h-2 a0.5 0.5 0 0 1 -0.5 -0.5 v-4 a0.5 0.5 0 0 1 0.5 -0.5 z M18 19 v-1 M11 7 v-2 h-1 M0 0 h24 v24 H0 z";
				case IconKind.BinaryTree2:
					return "M17.684 12.496 l-4.366 -4.99 M6.316 12.496 l4.368 -4.992 M12 8 v8 M14 18 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M21 14 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M7 14 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M14 6 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M0 0 h24 v24 H0 z";
				case IconKind.BinaryTree:
					return "M15.063 5.7 l2.881 4.61 M10.065 13.705 l2.876 4.6 M10.061 10.303 l2.877 -4.604 M5.058 18.306 l2.88 -4.606 M21 12 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M11 12 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M16 20 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M16 4 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M6 20 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M0 0 h24 v24 H0 z";
				case IconKind.Binary:
					return "M6 10 h0.01 m-0.01 9 h0.01 M10 14 m0 0.5 a0.5 0.5 0 0 1 0.5 -0.5 h2 a0.5 0.5 0 0 1 0.5 0.5 v4 a0.5 0.5 0 0 1 -0.5 0.5 h-2 a0.5 0.5 0 0 1 -0.5 -0.5 z M15 5 m0 0.5 a0.5 0.5 0 0 1 0.5 -0.5 h2 a0.5 0.5 0 0 1 0.5 0.5 v4 a0.5 0.5 0 0 1 -0.5 0.5 h-2 a0.5 0.5 0 0 1 -0.5 -0.5 z M11 10 v-5 h-1 m8 14 v-5 h-1 M0 0 h24 v24 H0 z";
				case IconKind.BiohazardOff:
					return "M3 3 l18 18 M15.349 3.133 a4.75 4.75 0 0 1 -0.836 7.385 M10.295 10.929 a4.75 4.75 0 0 1 -2.988 -3.64 m0.66 -3.324 a4.75 4.75 0 0 1 0.5 -0.66 l0.164 -0.172 M14.533 10.538 a4.75 4.75 0 0 1 6.957 3.987 v0.217 M16.745 19.495 a4.75 4.75 0 0 1 -4.69 -5.503 h-0.06 M2.495 14.745 a4.75 4.75 0 0 1 7.737 -3.693 M11.939 14 c0 0.173 0.048 0.351 0.056 0.533 v0.217 a4.75 4.75 0 0 1 -4.533 4.745 h-0.217 M10.586 10.586 a2 2 0 1 0 2.836 2.82 M0 0 h24 v24 H0 z";
				case IconKind.Biohazard:
					return "M11.939 14 c0 0.173 0.048 0.351 0.056 0.533 l0 0.217 a4.75 4.75 0 0 1 -4.533 4.745 l-0.217 0 m-4.75 -4.75 a4.75 4.75 0 0 1 7.737 -3.693 m6.513 8.443 a4.75 4.75 0 0 1 -4.69 -5.503 l-0.06 0 m1.764 -2.944 a4.75 4.75 0 0 1 7.731 3.477 l0 0.217 m-11.195 -3.813 a4.75 4.75 0 0 1 -1.828 -7.624 l0.164 -0.172 m6.718 0 a4.75 4.75 0 0 1 -1.665 7.798 M12 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Blade:
					return "M12 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M8 14 l2 2 M14 8 l2 2 M12.8 11.2 l3.2 -3.2 M8 16 l3.2 -3.2 M17.707 3.707 l2.586 2.586 a1 1 0 0 1 0 1.414 l-0.586 0.586 a1 1 0 0 0 0 1.414 l0.586 0.586 a1 1 0 0 1 0 1.414 l-8.586 8.586 a1 1 0 0 1 -1.414 0 l-0.586 -0.586 a1 1 0 0 0 -1.414 0 l-0.586 0.586 a1 1 0 0 1 -1.414 0 l-2.586 -2.586 a1 1 0 0 1 0 -1.414 l0.586 -0.586 a1 1 0 0 0 0 -1.414 l-0.586 -0.586 a1 1 0 0 1 0 -1.414 l8.586 -8.586 a1 1 0 0 1 1.414 0 l0.586 0.586 a1 1 0 0 0 1.414 0 l0.586 -0.586 a1 1 0 0 1 1.414 0 z M0 0 h24 v24 H0 z";
				case IconKind.BleachChlorine:
					return "M14 12 v4 h2 M11 12 h-1 a2 2 0 1 0 0 4 h1 M5 19 h14 a2 2 0 0 0 1.84 -2.75 l-7.1 -12.25 a2 2 0 0 0 -3.5 0 l-7.1 12.25 a2 2 0 0 0 1.75 2.75 M0 0 h24 v24 H0 z";
				case IconKind.BleachNoChlorine:
					return "M11.719 19.014 l5.346 -9.284 M6.576 19 l7.907 -13.733 M5 19 h14 a2 2 0 0 0 1.84 -2.75 l-7.1 -12.25 a2 2 0 0 0 -3.5 0 l-7.1 12.25 a2 2 0 0 0 1.75 2.75 M0 0 h24 v24 H0 z";
				case IconKind.BleachOff:
					return "M3 3 l18 18 M5 19 h14 m1.986 -1.977 a2 2 0 0 0 -0.146 -0.773 l-7.1 -12.25 a2 2 0 0 0 -3.5 0 l-0.815 1.405 m-1.488 2.568 l-4.797 8.277 a2 2 0 0 0 1.75 2.75 M0 0 h24 v24 H0 z";
				case IconKind.Bleach:
					return "M5 19 h14 a2 2 0 0 0 1.84 -2.75 l-7.1 -12.25 a2 2 0 0 0 -3.5 0 l-7.1 12.25 a2 2 0 0 0 1.75 2.75 M0 0 h24 v24 H0 z";
				case IconKind.Blockquote:
					return "M3 9 h1 a1 1 0 1 1 -1 1 v-2.5 a2 2 0 0 1 2 -2 M9 9 h1 a1 1 0 1 1 -1 1 v-2.5 a2 2 0 0 1 2 -2 M21 7 h-6 M15 11 h6 M21 19 h-15 M6 15 h15 M0 0 h24 v24 H0 z";
				case IconKind.BluetoothConnected:
					return "M18 12 l1 0 M4 12 l1 0 M7 8 l10 8 l-5 4 l0 -16 l5 4 l-10 8 M0 0 h24 v24 H0 z";
				case IconKind.BluetoothOff:
					return "M16.438 16.45 l-4.438 3.55 v-8 m0 -4 v-4 l5 4 l-2.776 2.22 m-2.222 1.779 l-5 4 M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.BluetoothX:
					return "M20 6 l-4 4 M16 6 l4 4 M7 8 l10 8 l-5 4 v-16 l1 0.802 m0 6.396 l-6 4.802 M0 0 h24 v24 H0 z";
				case IconKind.Bluetooth:
					return "M7 8 l10 8 l-5 4 l0 -16 l5 4 l-10 8 M0 0 h24 v24 H0 z";
				case IconKind.BlurOff:
					return "M3 3 l18 18 M12 15 h3 m4 0 h1 M12 18 h6 M12 6 h6 M13 9 h7 M16 12 h5 M5.641 5.631 a9 9 0 1 0 12.719 12.738 m1.68 -2.318 a9 9 0 0 0 -12.074 -12.098 M12 3 v5 m0 4 v8 M0 0 h24 v24 H0 z";
				case IconKind.Blur:
					return "M12 15 h8 M12 18 h6 M12 6 h6 M12 9 h8 M12 12 h9 M12 3 v17 M12 21 a9.01 9.01 0 0 0 2.32 -0.302 a9 9 0 0 0 1.74 -16.733 a9 9 0 1 0 -4.06 17.035 z M0 0 h24 v24 H0 z";
				case IconKind.Bmp:
					return "M9 16 v-8 l3 6 l3 -6 v8 M6 14 a2 2 0 0 1 -2 2 h-2 v-8 h2 a2 2 0 1 1 0 4 h-2 h2 a2 2 0 0 1 2 2 z M18 16 v-8 h2 a2 2 0 1 1 0 4 h-2 M0 0 h24 v24 H0 z";
				case IconKind.BoldOff:
					return "M3 3 l18 18 M17.107 17.112 a3.5 3.5 0 0 1 -3.107 1.888 h-7 v-7 M9 5 h4 a3.5 3.5 0 0 1 2.222 6.204 m-3.222 0.796 h-5 v-5 M0 0 h24 v24 H0 z";
				case IconKind.Bold:
					return "M13 12 h1 a3.5 3.5 0 0 1 0 7 h-7 v-7 M7 5 h6 a3.5 3.5 0 0 1 0 7 h-6 z M0 0 h24 v24 H0 z";
				case IconKind.BoltOff:
					return "M15.212 15.21 l-4.212 5.79 v-7 h-6 l3.79 -5.21 m1.685 -2.32 l2.525 -3.47 v6 m1 1 h5 l-2.104 2.893 M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.Bolt:
					return "M13 3 l0 7 l6 0 l-8 11 l0 -7 l-6 0 l8 -11 M0 0 h24 v24 H0 z";
				case IconKind.Bomb:
					return "M7 13 a3 3 0 0 1 3 -3 M17 7 l1.293 -1.293 a2.414 2.414 0 0 0 0.707 -1.707 a1 1 0 0 1 1 -1 h1 M15.349 5.349 l3.301 3.301 a1.2 1.2 0 0 1 0 1.698 l-0.972 0.972 a7.5 7.5 0 1 1 -5 -5 l0.972 -0.972 a1.2 1.2 0 0 1 1.698 0 z M0 0 h24 v24 H0 z";
				case IconKind.BoneOff:
					return "M3 3 l18 18 M12.5 8.502 l0.38 -0.38 a3 3 0 1 1 5.12 -2.122 a3 3 0 1 1 -2.12 5.122 l-0.372 0.372 m-2.008 2.008 l-2.378 2.378 a3 3 0 1 1 -5.117 2.297 l0 -0.177 l-0.176 0 a3 3 0 1 1 2.298 -5.115 l2.378 -2.378 M0 0 h24 v24 H0 z";
				case IconKind.Bone:
					return "M15 3 a3 3 0 0 1 3 3 a3 3 0 1 1 -2.12 5.122 l-4.758 4.758 a3 3 0 1 1 -5.117 2.297 l0 -0.177 l-0.176 0 a3 3 0 1 1 2.298 -5.115 l4.758 -4.758 a3 3 0 0 1 2.12 -5.122 z M0 0 h24 v24 H0 z";
				case IconKind.BongOff:
					return "M3 3 l18 18 M6.1 17 h9.8 M8 3 h6 M9 5 v-2 h4 v6 m1.5 1.5 l2.5 -2.5 l2 2 l-2.5 2.5 m-0.5 3.505 a5 5 0 1 1 -7 -4.589 v-2.416 M0 0 h24 v24 H0 z";
				case IconKind.Bong:
					return "M6.1 17 h9.8 M8 3 h6 M13 3 v8.416 c0.134 0.059 0.265 0.123 0.393 0.193 l3.607 -3.609 l2 2 l-3.608 3.608 a5 5 0 1 1 -6.392 -2.192 v-8.416 h4 z M0 0 h24 v24 H0 z";
				case IconKind.Book2:
					return "M9 8 h6 M19 16 h-12 a2 2 0 0 0 -2 2 M19 4 v16 h-12 a2 2 0 0 1 -2 -2 v-12 a2 2 0 0 1 2 -2 h12 z M0 0 h24 v24 H0 z";
				case IconKind.BookDownload:
					return "M18 22 v-9 M15 19 l3 3 l3 -3 M13 16 h-7 a2 2 0 0 0 -2 2 M12 20 h-6 a2 2 0 0 1 -2 -2 v-12 a2 2 0 0 1 2 -2 h12 v5 M0 0 h24 v24 H0 z";
				case IconKind.BookOff:
					return "M3 3 l18 18 M21 6 v11 M12 6 v2 m0 4 v7 M3 6 v13 M3 6 a9 9 0 0 1 2.114 -0.884 m3.8 -0.21 c1.07 0.17 2.116 0.534 3.086 1.094 a9 9 0 0 1 9 0 M3 19 a9 9 0 0 1 9 0 a9 9 0 0 1 5.899 -1.096 M0 0 h24 v24 H0 z";
				case IconKind.BookUpload:
					return "M18 13 v9 M15 16 l3 -3 l3 3 M11 16 h-5 a2 2 0 0 0 -2 2 M14 20 h-8 a2 2 0 0 1 -2 -2 v-12 a2 2 0 0 1 2 -2 h12 v5 M0 0 h24 v24 H0 z";
				case IconKind.Book:
					return "M21 6 l0 13 M12 6 l0 13 M3 6 l0 13 M3 6 a9 9 0 0 1 9 0 a9 9 0 0 1 9 0 M3 19 a9 9 0 0 1 9 0 a9 9 0 0 1 9 0 M0 0 h24 v24 H0 z";
				case IconKind.BookmarkOff:
					return "M17 17 v3 l-5 -3 l-5 3 v-13 m1.178 -2.818 c0.252 -0.113 0.53 -0.176 0.822 -0.176 h6 a2 2 0 0 1 2 2 v7 M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.Bookmark:
					return "M9 4 h6 a2 2 0 0 1 2 2 v14 l-5 -3 l-5 3 v-14 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.BookmarksOff:
					return "M3 3 l18 18 M9.265 4 a2 2 0 0 1 1.735 -1 h6 a2 2 0 0 1 2 2 v10 M11 7 h2 a2 2 0 0 1 2 2 v2 m0 4 v6 l-5 -3 l-5 3 v-12 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.Bookmarks:
					return "M9.265 4 a2 2 0 0 1 1.735 -1 h6 a2 2 0 0 1 2 2 v12 l-1 -0.6 M13 7 a2 2 0 0 1 2 2 v12 l-5 -3 l-5 3 v-12 a2 2 0 0 1 2 -2 h6 z M0 0 h24 v24 H0 z";
				case IconKind.BooksOff:
					return "M3 3 l18 18 M19.207 15.199 l0.716 -0.18 M14 9 l4 -1 M19.585 19.589 l-1.572 0.38 c-0.562 0.136 -1.133 -0.19 -1.282 -0.731 l-0.952 -3.458 M14.254 10.244 l-1.218 -4.424 a1.02 1.02 0 0 1 0.634 -1.219 l0.133 -0.041 l2.184 -0.53 c0.562 -0.135 1.133 0.19 1.282 0.732 l3.236 11.75 M9 16 h4 M5 8 h3 M13 13 v6 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 v-10 M9 5 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v4 M8 4 a1 1 0 0 1 1 1 M9 9 v10 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 v-14 M0 0 h24 v24 H0 z";
				case IconKind.Books:
					return "M16 16 l3.923 -0.98 M14 9 l4 -1 M13.803 4.56 l2.184 -0.53 c0.562 -0.135 1.133 0.19 1.282 0.732 l3.695 13.418 a1.02 1.02 0 0 1 -0.634 1.219 l-0.133 0.041 l-2.184 0.53 c-0.562 0.135 -1.133 -0.19 -1.282 -0.732 l-3.695 -13.418 a1.02 1.02 0 0 1 0.634 -1.219 l0.133 -0.041 z M9 16 h4 M5 8 h4 M9 4 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v14 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M5 4 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v14 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.BorderAll:
					return "M12 4 l0 16 M4 12 l16 0 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BorderBottom:
					return "M20 16 l0 0.01 M12 16 l0 0.01 M4 16 l0 0.01 M20 12 l0 0.01 M16 12 l0 0.01 M12 12 l0 0.01 M8 12 l0 0.01 M4 12 l0 0.01 M20 8 l0 0.01 M12 8 l0 0.01 M4 8 l0 0.01 M20 4 l0 0.01 M16 4 l0 0.01 M12 4 l0 0.01 M8 4 l0 0.01 M4 4 l0 0.01 M20 20 l-16 0 M0 0 h24 v24 H0 z";
				case IconKind.BorderHorizontal:
					return "M20 20 l0 0.01 M16 20 l0 0.01 M12 20 l0 0.01 M8 20 l0 0.01 M4 20 l0 0.01 M20 16 l0 0.01 M12 16 l0 0.01 M4 16 l0 0.01 M20 8 l0 0.01 M12 8 l0 0.01 M4 8 l0 0.01 M20 4 l0 0.01 M16 4 l0 0.01 M12 4 l0 0.01 M8 4 l0 0.01 M4 4 l0 0.01 M4 12 l16 0 M0 0 h24 v24 H0 z";
				case IconKind.BorderInner:
					return "M20 20 l0 0.01 M16 20 l0 0.01 M8 20 l0 0.01 M4 20 l0 0.01 M20 16 l0 0.01 M4 16 l0 0.01 M20 8 l0 0.01 M4 8 l0 0.01 M20 4 l0 0.01 M16 4 l0 0.01 M8 4 l0 0.01 M4 4 l0 0.01 M12 4 l0 16 M4 12 l16 0 M0 0 h24 v24 H0 z";
				case IconKind.BorderLeft:
					return "M20 20 l0 0.01 M16 20 l0 0.01 M12 20 l0 0.01 M8 20 l0 0.01 M20 16 l0 0.01 M12 16 l0 0.01 M20 12 l0 0.01 M16 12 l0 0.01 M12 12 l0 0.01 M8 12 l0 0.01 M20 8 l0 0.01 M12 8 l0 0.01 M20 4 l0 0.01 M16 4 l0 0.01 M12 4 l0 0.01 M8 4 l0 0.01 M4 20 l0 -16 M0 0 h24 v24 H0 z";
				case IconKind.BorderNone:
					return "M20 20 l0 0.01 M16 20 l0 0.01 M12 20 l0 0.01 M8 20 l0 0.01 M4 20 l0 0.01 M20 16 l0 0.01 M12 16 l0 0.01 M4 16 l0 0.01 M20 12 l0 0.01 M16 12 l0 0.01 M12 12 l0 0.01 M8 12 l0 0.01 M4 12 l0 0.01 M20 8 l0 0.01 M12 8 l0 0.01 M4 8 l0 0.01 M20 4 l0 0.01 M16 4 l0 0.01 M12 4 l0 0.01 M8 4 l0 0.01 M4 4 l0 0.01 M0 0 h24 v24 H0 z";
				case IconKind.BorderOuter:
					return "M12 16 l0 0.01 M16 12 l0 0.01 M12 12 l0 0.01 M8 12 l0 0.01 M12 8 l0 0.01 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BorderRadius:
					return "M20 20 l0 0.01 M16 20 l0 0.01 M12 20 l0 0.01 M8 20 l0 0.01 M4 20 l0 0.01 M20 16 l0 0.01 M4 16 l0 0.01 M20 12 l0 0.01 M20 8 l0 0.01 M20 4 l0 0.01 M16 4 l0 0.01 M4 12 v-4 a4 4 0 0 1 4 -4 h4 M0 0 h24 v24 H0 z";
				case IconKind.BorderRight:
					return "M16 20 l0 0.01 M12 20 l0 0.01 M8 20 l0 0.01 M4 20 l0 0.01 M12 16 l0 0.01 M4 16 l0 0.01 M16 12 l0 0.01 M12 12 l0 0.01 M8 12 l0 0.01 M4 12 l0 0.01 M12 8 l0 0.01 M4 8 l0 0.01 M16 4 l0 0.01 M12 4 l0 0.01 M8 4 l0 0.01 M4 4 l0 0.01 M20 4 l0 16 M0 0 h24 v24 H0 z";
				case IconKind.BorderStyle2:
					return "M4 6 h16 M4 12 h2 M11 12 h2 M18 12 h2 M20 18 v0.01 M16 18 v0.01 M12 18 v0.01 M8 18 v0.01 M4 18 v0.01 M0 0 h24 v24 H0 z";
				case IconKind.BorderStyle:
					return "M20 20 v0.01 M16 20 v0.01 M12 20 v0.01 M8 20 v0.01 M20 16 v0.01 M20 12 v0.01 M20 8 v0.01 M4 20 v-14 a2 2 0 0 1 2 -2 h14 M0 0 h24 v24 H0 z";
				case IconKind.BorderTop:
					return "M20 20 l0 0.01 M16 20 l0 0.01 M12 20 l0 0.01 M8 20 l0 0.01 M4 20 l0 0.01 M20 16 l0 0.01 M12 16 l0 0.01 M4 16 l0 0.01 M20 12 l0 0.01 M16 12 l0 0.01 M12 12 l0 0.01 M8 12 l0 0.01 M4 12 l0 0.01 M20 8 l0 0.01 M12 8 l0 0.01 M4 8 l0 0.01 M4 4 l16 0 M0 0 h24 v24 H0 z";
				case IconKind.BorderVertical:
					return "M20 20 l0 0.01 M16 20 l0 0.01 M8 20 l0 0.01 M4 20 l0 0.01 M20 16 l0 0.01 M4 16 l0 0.01 M20 12 l0 0.01 M16 12 l0 0.01 M8 12 l0 0.01 M4 12 l0 0.01 M20 8 l0 0.01 M4 8 l0 0.01 M20 4 l0 0.01 M16 4 l0 0.01 M8 4 l0 0.01 M4 4 l0 0.01 M12 4 l0 16 M0 0 h24 v24 H0 z";
				case IconKind.BottleOff:
					return "M3 3 l18 18 M7 14.803 a2.4 2.4 0 0 0 1 -0.803 a2.4 2.4 0 0 1 2 -1 a2.4 2.4 0 0 1 2 1 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 0.866 -0.142 M14 3.5 c0 1.626 0.507 3.212 1.45 4.537 l0.05 0.07 a8.093 8.093 0 0 1 1.5 4.694 v0.199 m0 4 v2 a2 2 0 0 1 -2 2 h-6 a2 2 0 0 1 -2 -2 v-6.2 a8.09 8.09 0 0 1 1.35 -4.474 m1.336 -2.63 a7.822 7.822 0 0 0 0.314 -2.196 M10 5 h4 v-2 a1 1 0 0 0 -1 -1 h-2 a1 1 0 0 0 -1 1 v2 z M0 0 h24 v24 H0 z";
				case IconKind.Bottle:
					return "M7 14.803 a2.4 2.4 0 0 0 1 -0.803 a2.4 2.4 0 0 1 2 -1 a2.4 2.4 0 0 1 2 1 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 a2.4 2.4 0 0 1 1 -0.805 M14 3.5 c0 1.626 0.507 3.212 1.45 4.537 l0.05 0.07 a8.093 8.093 0 0 1 1.5 4.694 v6.199 a2 2 0 0 1 -2 2 h-6 a2 2 0 0 1 -2 -2 v-6.2 c0 -1.682 0.524 -3.322 1.5 -4.693 l0.05 -0.07 a7.823 7.823 0 0 0 1.45 -4.537 M10 5 h4 v-2 a1 1 0 0 0 -1 -1 h-2 a1 1 0 0 0 -1 1 v2 z M0 0 h24 v24 H0 z";
				case IconKind.BounceLeft:
					return "M6 9 a2 2 0 1 1 0 -4 a2 2 0 0 1 0 4 z M20 15.5 c-3 -1 -5.5 -0.5 -8 4.5 c-0.5 -3 -1.5 -5.5 -3 -8 M0 0 h24 v24 H0 z";
				case IconKind.BounceRight:
					return "M18 9 a2 2 0 1 1 0 -4 a2 2 0 0 1 0 4 z M4 15.5 c3 -1 5.5 -0.5 8 4.5 c0.5 -3 1.5 -5.5 3 -8 M0 0 h24 v24 H0 z";
				case IconKind.Bow:
					return "M16.5 20 c1.576 -1.576 2.5 -4.095 2.5 -6.5 c0 -4.81 -3.69 -8.5 -8.5 -8.5 c-2.415 0 -4.922 0.913 -6.5 2.5 l12.5 12.5 z M3 18 h3 v3 M21 3 l-15 15 M17 3 h4 v4 M0 0 h24 v24 H0 z";
				case IconKind.Bowl:
					return "M4 8 h16 a1 1 0 0 1 1 1 v0.5 c0 1.5 -2.517 5.573 -4 6.5 v1 a1 1 0 0 1 -1 1 h-8 a1 1 0 0 1 -1 -1 v-1 c-1.687 -1.054 -4 -5 -4 -6.5 v-0.5 a1 1 0 0 1 1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.BoxAlignBottomLeft:
					return "M20 20 v0.01 M20 15 v0.01 M20 9 v0.01 M20 4 v0.01 M15 20 v0.01 M15 4 v0.01 M9 4 v0.01 M4 4 v0.01 M4 9 v0.01 M5 13 h5 a1 1 0 0 1 1 1 v5 a1 1 0 0 1 -1 1 h-5 a1 1 0 0 1 -1 -1 v-5 a1 1 0 0 1 1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.BoxAlignBottomRight:
					return "M4 20 v0.01 M4 15 v0.01 M4 9 v0.01 M4 4 v0.01 M9 20 v0.01 M9 4 v0.01 M15 4 v0.01 M20 4 v0.01 M20 9 v0.01 M19 13 h-5 a1 1 0 0 0 -1 1 v5 a1 1 0 0 0 1 1 h5 a1 1 0 0 0 1 -1 v-5 a1 1 0 0 0 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.BoxAlignBottom:
					return "M20 9 v0.01 M20 4 v0.01 M15 4 v0.01 M9 4 v0.01 M4 4 v0.01 M4 9 v0.01 M4 14 h16 v5 a1 1 0 0 1 -1 1 h-14 a1 1 0 0 1 -1 -1 v-5 z M0 0 h24 v24 H0 z";
				case IconKind.BoxAlignLeft:
					return "M14.752 3.752 h-0.01 M19.753 3.752 h-0.011 M19.753 8.752 h-0.011 M19.753 14.752 h-0.011 M19.753 19.753 h-0.011 M14.752 19.753 h-0.01 M9.752 19.753 v-16 h-5 a1 1 0 0 0 -1 1 v14 a1 1 0 0 0 1 1 h5 z M0 0 h24 v24 H0 z";
				case IconKind.BoxAlignRight:
					return "M9.248 3.752 h0.01 M4.247 3.752 h0.011 M4.247 8.752 h0.011 M4.247 14.752 h0.011 M4.247 19.753 h0.011 M9.248 19.753 h0.01 M14.248 19.753 v-16 h5 a1 1 0 0 1 1 1 v14 a1 1 0 0 1 -1 1 h-5 z M0 0 h24 v24 H0 z";
				case IconKind.BoxAlignTopLeft:
					return "M4 20 h-0.01 M9 20 h-0.01 M15 20 h-0.01 M20 20 h-0.01 M4 15 h-0.01 M20 15 h-0.01 M20 9 h-0.01 M20 4 h-0.01 M15 4 h-0.01 M11 5 v5 a1 1 0 0 1 -1 1 h-5 a1 1 0 0 1 -1 -1 v-5 a1 1 0 0 1 1 -1 h5 a1 1 0 0 1 1 1 z M0 0 h24 v24 H0 z";
				case IconKind.BoxAlignTopRight:
					return "M4 4.01 v-0.01 M4 9.01 v-0.01 M4 15.01 v-0.01 M4 20.01 v-0.01 M9 4.01 v-0.01 M9 20.01 v-0.01 M15 20.01 v-0.01 M20 20.01 v-0.01 M20 15.01 v-0.01 M19 11.01 h-5 a1 1 0 0 1 -1 -1 v-5 a1 1 0 0 1 1 -1 h5 a1 1 0 0 1 1 1 v5 a1 1 0 0 1 -1 1 z M0 0 h24 v24 H0 z";
				case IconKind.BoxAlignTop:
					return "M20 14.505 v-0.01 M20 19.505 v-0.01 M15 19.505 v-0.01 M9 19.505 v-0.01 M4 19.505 v-0.01 M4 14.505 v-0.01 M4 9.505 h16 v-5 a1 1 0 0 0 -1 -1 h-14 a1 1 0 0 0 -1 1 v5 z M0 0 h24 v24 H0 z";
				case IconKind.BoxMargin:
					return "M4 8 v0.01 M4 12 v0.01 M4 16 v0.01 M20 8 v0.01 M20 12 v0.01 M20 16 v0.01 M20 20 v0.01 M16 20 v0.01 M12 20 v0.01 M8 20 v0.01 M4 20 v0.01 M20 4 v0.01 M16 4 v0.01 M12 4 v0.01 M8 4 v0.01 M4 4 v0.01 M8 8 h8 v8 h-8 z M0 0 h24 v24 H0 z";
				case IconKind.BoxModel2Off:
					return "M3 3 l18 18 M12 8 h4 v4 m0 4 h-8 v-8 M8 4 h10 a2 2 0 0 1 2 2 v10 m-0.586 3.414 a2 2 0 0 1 -1.414 0.586 h-12 a2 2 0 0 1 -2 -2 v-12 c0 -0.547 0.22 -1.043 0.576 -1.405 M0 0 h24 v24 H0 z";
				case IconKind.BoxModel2:
					return "M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M8 8 h8 v8 h-8 z M0 0 h24 v24 H0 z";
				case IconKind.BoxModelOff:
					return "M3 3 l18 18 M8 16 l-3.3 3.3 M8 8 l-3.3 -3.3 M16 8 l3.3 -3.3 M16 16 l3.3 3.3 M8 4 h10 a2 2 0 0 1 2 2 v10 m-0.586 3.414 a2 2 0 0 1 -1.414 0.586 h-12 a2 2 0 0 1 -2 -2 v-12 c0 -0.547 0.22 -1.043 0.576 -1.405 M12 8 h4 v4 m0 4 h-8 v-8 M0 0 h24 v24 H0 z";
				case IconKind.BoxModel:
					return "M8 16 l-3.3 3.3 M8 8 l-3.3 -3.3 M16 8 l3.3 -3.3 M16 16 l3.3 3.3 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M8 8 h8 v8 h-8 z M0 0 h24 v24 H0 z";
				case IconKind.BoxMultiple0:
					return "M17 17 v2 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 v-10 a2 2 0 0 1 2 -2 h2 M7 3 m0 2 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 z M14 6 a2 2 0 0 1 2 2 v4 a2 2 0 1 1 -4 0 v-4 a2 2 0 0 1 2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BoxMultiple1:
					return "M14 14 v-8 l-2 2 M17 17 v2 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 v-10 a2 2 0 0 1 2 -2 h2 M7 3 m0 2 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BoxMultiple2:
					return "M12 8 a2 2 0 1 1 4 0 c0 0.591 -0.417 1.318 -0.816 1.858 l-3.184 4.143 l4 0 M17 17 v2 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 v-10 a2 2 0 0 1 2 -2 h2 M7 3 m0 2 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BoxMultiple3:
					return "M12 12 a2 2 0 1 0 2 -2 M14 10 a2 2 0 1 0 -2 -2 M17 17 v2 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 v-10 a2 2 0 0 1 2 -2 h2 M7 3 m0 2 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BoxMultiple4:
					return "M15 14 v-8 l-4 6 h5 M17 17 v2 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 v-10 a2 2 0 0 1 2 -2 h2 M7 3 m0 2 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BoxMultiple5:
					return "M17 17 v2 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 v-10 a2 2 0 0 1 2 -2 h2 M12 14 h2 a2 2 0 1 0 0 -4 h-2 v-4 h4 M7 3 m0 2 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BoxMultiple6:
					return "M17 17 v2 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 v-10 a2 2 0 0 1 2 -2 h2 M16 8 a2 2 0 1 0 -4 0 v4 M14 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M7 3 m0 2 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BoxMultiple7:
					return "M17 17 v2 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 v-10 a2 2 0 0 1 2 -2 h2 M12 6 h4 l-2 8 M7 3 m0 2 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BoxMultiple8:
					return "M17 17 v2 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 v-10 a2 2 0 0 1 2 -2 h2 M14 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M14 8 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M7 3 m0 2 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BoxMultiple9:
					return "M17 17 v2 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 v-10 a2 2 0 0 1 2 -2 h2 M12 12 a2 2 0 1 0 4 0 v-4 M14 8 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M7 3 m0 2 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BoxMultiple:
					return "M17 17 v2 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 v-10 a2 2 0 0 1 2 -2 h2 M7 3 m0 2 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BoxOff:
					return "M3 3 l18 18 M12 12 l-8 -4.5 M12 12 v9 M14.561 10.559 l5.439 -3.059 M17.765 17.757 l-5.765 3.243 l-8 -4.5 v-9 l2.236 -1.258 m2.57 -1.445 l3.194 -1.797 l8 4.5 v8.5 M0 0 h24 v24 H0 z";
				case IconKind.BoxPadding:
					return "M12 16 v0.01 M12 8 v0.01 M16 8 v0.01 M16 12 v0.01 M16 16 v0.01 M8 8 v0.01 M8 12 v0.01 M8 16 v0.01 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BoxSeam:
					return "M12 12 l-8 -4.5 M12 12 v9 M8.2 9.8 l7.6 -4.6 M12 12 l8 -4.5 M12 3 l8 4.5 v9 l-8 4.5 l-8 -4.5 v-9 l8 -4.5 M0 0 h24 v24 H0 z";
				case IconKind.Box:
					return "M12 12 l-8 -4.5 M12 12 l0 9 M12 12 l8 -4.5 M12 3 l8 4.5 l0 9 l-8 4.5 l-8 -4.5 l0 -9 l8 -4.5 M0 0 h24 v24 H0 z";
				case IconKind.BracesOff:
					return "M3 3 l18 18 M17 4 a2 2 0 0 1 2 2 v3 c0 1.657 0.895 3 2 3 c-1.105 0 -2 1.343 -2 3 m-0.176 3.821 a2 2 0 0 1 -1.824 1.179 M5.176 5.177 c-0.113 0.251 -0.176 0.53 -0.176 0.823 v3 c0 1.657 -0.895 3 -2 3 c1.105 0 2 1.343 2 3 v3 a2 2 0 0 0 2 2 M0 0 h24 v24 H0 z";
				case IconKind.Braces:
					return "M17 4 a2 2 0 0 1 2 2 v3 a2 3 0 0 0 2 3 a2 3 0 0 0 -2 3 v3 a2 2 0 0 1 -2 2 M7 4 a2 2 0 0 0 -2 2 v3 a2 3 0 0 1 -2 3 a2 3 0 0 1 2 3 v3 a2 2 0 0 0 2 2 M0 0 h24 v24 H0 z";
				case IconKind.BracketsContainEnd:
					return "M13 16 h0.01 M9 16 h0.01 M5 16 h0.01 M14 4 h4 v16 h-4 M0 0 h24 v24 H0 z";
				case IconKind.BracketsContainStart:
					return "M10 16 h-0.01 M14 16 h-0.01 M18 16 h-0.01 M9 4 h-4 v16 h4 M0 0 h24 v24 H0 z";
				case IconKind.BracketsContain:
					return "M16 16 h0.01 M12 16 h0.01 M8 16 h0.01 M17 4 h4 v16 h-4 M7 4 h-4 v16 h4 M0 0 h24 v24 H0 z";
				case IconKind.BracketsOff:
					return "M3 3 l18 18 M16 4 h3 v11 m0 4 v1 h-3 M5 5 v15 h3 M0 0 h24 v24 H0 z";
				case IconKind.Brackets:
					return "M16 4 h3 v16 h-3 M8 4 h-3 v16 h3 M0 0 h24 v24 H0 z";
				case IconKind.Braille:
					return "M16 19 h0.01 M8 12 h0.01 M16 12 h0.01 M7 19 a1 1 0 1 0 2 0 a1 1 0 0 0 -2 0 z M7 5 a1 1 0 1 0 2 0 a1 1 0 0 0 -2 0 z M15 5 a1 1 0 1 0 2 0 a1 1 0 0 0 -2 0 z M0 0 h24 v24 H0 z";
				case IconKind.Brain:
					return "M5 9.3 v-2.8 a3.5 3.5 0 0 1 7 0 v10 M6.5 16 a3.5 3.5 0 0 1 0 -7 h0.5 M19 9.3 v-2.8 a3.5 3.5 0 0 0 -7 0 M17.5 16 a3.5 3.5 0 0 0 0 -7 h-0.5 M8.5 13 a3.5 3.5 0 0 1 3.5 3.5 v1 a3.5 3.5 0 0 1 -7 0 v-1.8 M15.5 13 a3.5 3.5 0 0 0 -3.5 3.5 v1 a3.5 3.5 0 0 0 7 0 v-1.8 M0 0 h24 v24 H0 z";
				case IconKind.Brand4chan:
					return "M11 10.02 l-0.062 -0.309 l-0.081 -0.35 l-0.075 -0.29 l-0.092 -0.328 l-0.11 -0.358 l-0.128 -0.382 l-0.148 -0.399 c-0.658 -1.687 -1.844 -3.634 -3.804 -3.604 c-2.324 0.038 -3.19 2.493 -1.5 3.025 l-0.148 0.045 l-0.164 0.058 a4.13 4.13 0 0 0 -0.1 0.039 l-0.22 0.098 c-0.588 0.28 -1.368 0.832 -1.368 1.777 c0 1.513 3 3 8 0.977 z M10.02 13 l-0.309 0.062 l-0.35 0.081 l-0.29 0.075 l-0.328 0.092 l-0.358 0.11 l-0.188 0.061 l-0.392 0.139 c-1.73 0.64 -3.837 1.84 -3.805 3.88 c0.038 2.324 2.493 3.19 3.025 1.5 l0.045 0.148 l0.058 0.165 l0.039 0.098 l0.098 0.222 c0.28 0.586 0.832 1.367 1.777 1.367 c1.513 0 3 -3 0.977 -8 z M13 13.98 l0.062 0.309 l0.081 0.35 l0.075 0.29 l0.092 0.328 l0.11 0.358 l0.061 0.188 l0.139 0.392 c0.64 1.73 1.841 3.837 3.88 3.805 c2.324 -0.038 3.19 -2.493 1.5 -3.025 l0.148 -0.045 l0.165 -0.058 a4.13 4.13 0 0 0 0.098 -0.039 l0.222 -0.098 c0.586 -0.28 1.367 -0.832 1.367 -1.777 c0 -1.513 -3 -3 -8 -0.977 z M13.98 11 s6.075 -1.05 6.02 -4.5 c-0.038 -2.324 -2.493 -3.19 -3.025 -1.5 c0 0 -0.505 -2 -2.017 -2 c-1.513 0 -3 3 -0.977 8 z M14 11 s6.054 -1.05 6 -4.5 c-0.038 -2.324 -2.485 -3.19 -3.016 -1.5 c0 0 -0.502 -2 -2.01 -2 c-1.508 0 -2.984 3 -0.974 8 z M0 0 h24 v24 H0 z";
				case IconKind.BrandAbstract:
					return "M8 8 h8 v8 M10.5 13.5 m-2.5 0 a2.5 2.5 0 1 0 5 0 a2.5 2.5 0 1 0 -5 0 M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M0 0 h24 v24 H0 z";
				case IconKind.BrandAdobe:
					return "M12.893 4.514 l7.977 14 a0.993 0.993 0 0 1 -0.394 1.365 a1.04 1.04 0 0 1 -0.5 0.127 h-3.476 l-4.5 -8 l-2.5 4 h1.5 l2 4 h-8.977 c-0.565 0 -1.023 -0.45 -1.023 -1 c0 -0.171 0.045 -0.34 0.13 -0.49 l7.977 -13.993 a1.034 1.034 0 0 1 1.786 0 z M0 0 h24 v24 H0 z";
				case IconKind.BrandAdonisJs:
					return "M8.863 16.922 c1.137 -0.422 1.637 -0.922 3.137 -0.922 s2 0.5 3.138 0.922 c0.713 0.264 1.516 -0.102 1.778 -0.772 c0.126 -0.32 0.11 -0.673 -0.044 -0.983 l-3.708 -7.474 c-0.297 -0.598 -1.058 -0.859 -1.7 -0.583 a1.24 1.24 0 0 0 -0.627 0.583 l-3.709 7.474 c-0.321 0.648 -0.017 1.415 0.679 1.714 c0.332 0.143 0.715 0.167 1.056 0.04 z M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M0 0 h24 v24 H0 z";
				case IconKind.BrandAirbnb:
					return "M12 10 c-2 0 -3 1 -3 3 c0 1.5 1.494 3.535 3 5.5 c1 1 1.5 1.5 2.5 2 s2.5 1 4.5 -0.5 s1.5 -3.5 0.5 -6 s-2.333 -5.5 -5 -9.5 c-0.834 -1 -1.5 -1.5 -2.503 -1.5 c-1 0 -1.623 0.45 -2.497 1.5 c-2.667 4 -4 7 -5 9.5 s-1.5 4.5 0.5 6 s3.5 1 4.5 0.5 s1.5 -1 2.5 -2 c1.506 -1.965 3 -4 3 -5.5 c0 -2 -1 -3 -3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.BrandAirtable:
					return "M14 12.3 v8.7 l7 -3 v-8 z M3 6 l9 3 l9 -3 l-9 -3 z M3 10 v8 l7 -3 v-2.6 z M0 0 h24 v24 H0 z";
				case IconKind.BrandAlgolia:
					return "M12 12 v1 l0.9 -0.5 z M12 13 m-3.5 0 a3.5 3.5 0 1 0 7 0 a3.5 3.5 0 1 0 -7 0 M7.403 9.11 l0.707 -0.706 M11.5 7 h1 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BrandAlpineJs:
					return "M16.5 16 l4.5 -4.5 l-4.5 -4.5 l-4.5 4.5 M3 11.5 l4.5 4.5 h9 l-9 -9 z M0 0 h24 v24 H0 z";
				case IconKind.BrandAmazon:
					return "M19.5 15 c0.907 -1.411 1.451 -3.323 1.5 -5 c-1.197 -0.773 -2.577 -0.935 -4 -1 M17 12.5 a15.198 15.198 0 0 1 -7.37 1.44 a14.62 14.62 0 0 1 -6.63 -2.94 M0 0 h24 v24 H0 z";
				case IconKind.BrandAmd:
					return "M11.293 20.707 l4.707 -4.707 h-7 a1 1 0 0 1 -1 -1 v-7 l-4.707 4.707 a1 1 0 0 0 -0.293 0.707 v6.586 a1 1 0 0 0 1 1 h6.586 a1 1 0 0 0 0.707 -0.293 z M16 16 v-7 c0 -0.566 -0.434 -1 -1 -1 h-7 l-5 -5 h17 c0.566 0 1 0.434 1 1 v17 l-5 -5 z M0 0 h24 v24 H0 z";
				case IconKind.BrandAmigo:
					return "M9.591 3.635 l-7.13 14.082 c-1.712 3.38 1.759 5.45 3.69 3.573 l1.86 -1.81 c3.142 -3.054 4.959 -2.99 8.039 0.11 l1.329 1.337 c2.372 2.387 5.865 0.078 4.176 -3.225 l-7.195 -14.067 c-1.114 -2.18 -3.666 -2.18 -4.77 0 z M12 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandAmongUs:
					return "M17 10 c0.991 0.163 2.105 0.383 3.069 0.67 c0.255 0.13 0.52 0.275 0.534 0.505 c0.264 3.434 0.57 7.448 0.278 9.825 h-3.881 M5.84 7.132 c0.083 -0.564 0.214 -1.12 0.392 -1.661 c0.456 -0.936 1.095 -2.068 3.985 -2.456 a22.464 22.464 0 0 1 2.867 0.08 c1.776 0.14 2.643 1.234 3.287 3.368 c0.339 1.157 0.46 2.342 0.629 3.537 v11 l-12.704 -0.019 c-0.552 -2.386 -0.262 -5.894 0.204 -8.481 M10.646 12.774 c-1.939 0.396 -4.467 0.317 -6.234 -0.601 c-2.454 -1.263 -1.537 -4.66 1.423 -4.982 c2.254 -0.224 3.814 -0.354 5.65 0.214 c0.835 0.256 1.93 0.569 1.355 3.281 c-0.191 1.067 -1.07 1.904 -2.194 2.088 z M0 0 h24 v24 H0 z";
				case IconKind.BrandAndroid:
					return "M15 18 l0 3 M9 18 l0 3 M16 3 l-1 2 M8 3 l1 2 M7 9 h10 v8 a1 1 0 0 1 -1 1 h-8 a1 1 0 0 1 -1 -1 v-8 a5 5 0 0 1 10 0 M20 10 l0 6 M4 10 l0 6 M0 0 h24 v24 H0 z";
				case IconKind.BrandAngular:
					return "M10 13 h4 M9 15 l3 -8 l3 8 M5.428 17.245 l6.076 3.471 a1 1 0 0 0 0.992 0 l6.076 -3.471 a1 1 0 0 0 0.495 -0.734 l1.323 -9.704 a1 1 0 0 0 -0.658 -1.078 l-7.4 -2.612 a1 1 0 0 0 -0.665 0 l-7.399 2.613 a1 1 0 0 0 -0.658 1.078 l1.323 9.704 a1 1 0 0 0 0.495 0.734 z M0 0 h24 v24 H0 z";
				case IconKind.BrandAo3:
					return "M7 9 c-0.278 5.494 -2.337 7.33 -4 10 c4.013 -2 6.02 -5 15.05 -5 c4.012 0 3.51 2.5 1 3 c2 0.5 2.508 5 -2.007 2 M14 8 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M2 5 c7.109 4.1 10.956 10.131 12 14 c1.074 -4.67 4.49 -8.94 8 -11 M0 0 h24 v24 H0 z";
				case IconKind.BrandAppgallery:
					return "M9 8 a3 3 0 0 0 6 0 M4 4 m0 4 a4 4 0 0 1 4 -4 h8 a4 4 0 0 1 4 4 v8 a4 4 0 0 1 -4 4 h-8 a4 4 0 0 1 -4 -4 z M0 0 h24 v24 H0 z";
				case IconKind.BrandAppleArcade:
					return "M12 7 l0 6 M4.431 12.216 l5.634 -2.332 a5.065 5.065 0 0 1 3.87 0 l5.634 2.332 a0.692 0.692 0 0 1 0.028 1.269 l-5.462 2.543 a5.064 5.064 0 0 1 -4.27 0 l-5.462 -2.543 a0.691 0.691 0 0 1 0.028 -1.27 z M20 12.5 v4.75 a0.734 0.734 0 0 1 -0.055 0.325 a0.704 0.704 0 0 1 -0.348 0.366 l-5.462 2.58 a5 5 0 0 1 -4.27 0 l-5.462 -2.58 a0.705 0.705 0 0 1 -0.401 -0.691 l0 -4.75 M12 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandApplePodcast:
					return "M12 9 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M11.766 22 h0.468 a2 2 0 0 0 1.985 -1.752 l0.5 -4 a2 2 0 0 0 -1.985 -2.248 h-1.468 a2 2 0 0 0 -1.985 2.248 l0.5 4 a2 2 0 0 0 1.985 1.752 z M18.364 18.364 a9 9 0 1 0 -12.728 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandApple:
					return "M12 4 a2 2 0 0 0 2 -2 a2 2 0 0 0 -2 2 M9 7 c-3 0 -4 3 -4 5.5 c0 3 2 7.5 4 7.5 c1.088 -0.046 1.679 -0.5 3 -0.5 c1.312 0 1.5 0.5 3 0.5 s4 -3 4 -5 c-0.028 -0.01 -2.472 -0.403 -2.5 -3 c-0.019 -2.17 2.416 -2.954 2.5 -3 c-1.023 -1.492 -2.951 -1.963 -3.5 -2 c-1.433 -0.111 -2.83 1 -3.5 1 c-0.68 0 -1.9 -1 -3 -1 z M0 0 h24 v24 H0 z";
				case IconKind.BrandAppstore:
					return "M16 16 l-2.51 -4.518 m-1.487 -2.677 l-1 -1.805 M7 14 h5 m2.9 0 h2.1 M8 16 l1.106 -1.99 m1.4 -2.522 l2.494 -4.488 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandAsana:
					return "M7 16 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M17 16 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M12 7 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandBackbone:
					return "M19 20 l-14 -8 l14 -8 z M5 20 l14 -8 l-14 -8 z M0 0 h24 v24 H0 z";
				case IconKind.BrandBadoo:
					return "M7.5 10 c0 2.761 2.015 5 4.5 5 s4.5 -2.239 4.5 -5 M22 9.43 c0 5.838 -4.477 10.57 -10 10.57 s-10 -4.662 -10 -10.5 c0 -2.667 1.83 -5.01 4.322 -5.429 c2.492 -0.418 4.9 1.392 5.678 3.929 c0.768 -2.54 3.177 -4.354 5.668 -3.931 c2.495 0.417 4.332 2.69 4.332 5.36 z M0 0 h24 v24 H0 z";
				case IconKind.BrandBaidu:
					return "M19 9.5 m-1 0 a1 1.5 0 1 0 2 0 a1 1.5 0 1 0 -2 0 M15 4.5 m-1 0 a1 1.5 0 1 0 2 0 a1 1.5 0 1 0 -2 0 M9 4.5 m-1 0 a1 1.5 0 1 0 2 0 a1 1.5 0 1 0 -2 0 M14.463 11.596 c1.282 1.774 3.476 3.416 3.476 3.416 s1.921 1.574 0.593 3.636 c-1.328 2.063 -4.892 1.152 -4.892 1.152 s-1.416 -0.44 -3.06 -0.088 c-1.644 0.356 -3.06 0.22 -3.06 0.22 s-2.055 -0.22 -2.47 -2.304 c-0.416 -2.084 1.918 -3.638 2.102 -3.858 c0.182 -0.222 1.409 -0.966 2.284 -2.394 c0.875 -1.428 3.337 -2.287 5.027 0.221 z M5 9.5 m-1 0 a1 1.5 0 1 0 2 0 a1 1.5 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandBandcamp:
					return "M8.5 6 h13.5 l-7 12 h-13 z M0 0 h24 v24 H0 z";
				case IconKind.BrandBandlab:
					return "M15.078 4 h-5.136 l3.678 8.768 c0.547 1.14 0.847 1.822 0.162 2.676 c-0.053 0.093 -1.332 1.907 -3.053 1.495 c-0.825 -0.187 -1.384 -0.926 -1.32 -1.74 c0.04 -0.91 0.62 -1.717 1.488 -2.074 a4.463 4.463 0 0 1 2.723 -0.358 M6.885 7 l-2.536 4.907 c-2.021 3.845 -2.499 8.775 3.821 9.093 h6.808 c4.86 -0.207 7.989 -2.975 4.607 -9.093 l-2.988 -4.907 M0 0 h24 v24 H0 z";
				case IconKind.BrandBeats:
					return "M9 12 v-8 M12.5 12.5 m-3.5 0 a3.5 3.5 0 1 0 7 0 a3.5 3.5 0 1 0 -7 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandBehance:
					return "M16 6 l3 0 M14 13 h7 a3.5 3.5 0 0 0 -7 0 v2 a3.5 3.5 0 0 0 6.64 1 M3 12 l4.5 0 M3 18 v-12 h4.5 a3 3 0 0 1 0 6 a3 3 0 0 1 0 6 h-4.5 M0 0 h24 v24 H0 z";
				case IconKind.BrandBilibili:
					return "M3 10 a4 4 0 0 1 4 -4 h10 a4 4 0 0 1 4 4 v6 a4 4 0 0 1 -4 4 h-10 a4 4 0 0 1 -4 -4 v-6 z m5 -7 l2 3 m6 -3 l-2 3 m-7 6 l3 -1 m4 0 l3 1 m-8 3 a1.625 1.625 0 0 0 3 0 a1.625 1.625 0 0 0 3 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandBinance:
					return "M12 10 l2 2 l-2 2 l-2 -2 z M4 10 l2 2 l-2 2 l-2 -2 z M20 10 l2 2 l-2 2 l-2 -2 z M6 16 l2 -2 l4 4 l3.5 -3.5 l2 2 l-5.5 5.5 z M6 8 l2 2 l4 -4 l4 4 l2 -2 l-6 -6 z M0 0 h24 v24 H0 z";
				case IconKind.BrandBing:
					return "M5 3 l4 1.5 v12 l6 -2.5 l-2 -1 l-1 -4 l7 2.5 v4.5 l-10 5 l-4 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BrandBitbucket:
					return "M14 15 h-4 l-1 -6 h6 z M3.648 4 a0.64 0.64 0 0 0 -0.64 0.744 l3.14 14.528 c0.07 0.417 0.43 0.724 0.852 0.728 h10 a0.644 0.644 0 0 0 0.642 -0.539 l3.35 -14.71 a0.641 0.641 0 0 0 -0.64 -0.744 l-16.704 -0.007 z M0 0 h24 v24 H0 z";
				case IconKind.BrandBlackberry:
					return "M21 9 a1 1 0 0 0 -1 -1 h-2 l-0.5 2 h2.5 a1 1 0 0 0 1 -1 z M20 15 a1 1 0 0 0 -1 -1 h-2 l-0.5 2 h2.5 a1 1 0 0 0 1 -1 z M12 18 a1 1 0 0 0 -1 -1 h-2 l-0.5 2 h2.5 a1 1 0 0 0 1 -1 z M14 6 a1 1 0 0 0 -1 -1 h-2 l-0.5 2 h2.5 a1 1 0 0 0 1 -1 z M13 12 a1 1 0 0 0 -1 -1 h-2 l-0.5 2 h2.5 a1 1 0 0 0 1 -1 z M6 12 a1 1 0 0 0 -1 -1 h-2 l-0.5 2 h2.5 a1 1 0 0 0 1 -1 z M7 6 a1 1 0 0 0 -1 -1 h-2 l-0.5 2 h2.5 a1 1 0 0 0 1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.BrandBlender:
					return "M13 5 l5.65 5 M6 9 h9 M3 16 l9 -6.5 M15 14 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M15 14 m-6 0 a6 5 0 1 0 12 0 a6 5 0 1 0 -12 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandBlogger:
					return "M7 14 m0 1.5 a1.5 1.5 0 0 1 1.5 -1.5 h7 a1.5 1.5 0 0 1 1.5 1.5 v0 a1.5 1.5 0 0 1 -1.5 1.5 h-7 a1.5 1.5 0 0 1 -1.5 -1.5 z M7 7 m0 1.5 a1.5 1.5 0 0 1 1.5 -1.5 h3 a1.5 1.5 0 0 1 1.5 1.5 v0 a1.5 1.5 0 0 1 -1.5 1.5 h-3 a1.5 1.5 0 0 1 -1.5 -1.5 z M8 21 h8 a5 5 0 0 0 5 -5 v-3 a3 3 0 0 0 -3 -3 h-1 v-2 a5 5 0 0 0 -5 -5 h-4 a5 5 0 0 0 -5 5 v8 a5 5 0 0 0 5 5 z M0 0 h24 v24 H0 z";
				case IconKind.BrandBooking:
					return "M16 16 l0.01 0 M8 12 h3.5 a2 2 0 1 1 0 4 h-3.5 v-7 a1 1 0 0 1 1 -1 h1.5 a2 2 0 1 1 0 4 h-1.5 M4 18 v-9.5 a4.5 4.5 0 0 1 4.5 -4.5 h7 a4.5 4.5 0 0 1 4.5 4.5 v7 a4.5 4.5 0 0 1 -4.5 4.5 h-9.5 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BrandBootstrap:
					return "M9 16 v-8 h3.5 a2 2 0 1 1 0 4 h-3.5 h4 a2 2 0 1 1 0 4 h-4 z M2 12 a2 2 0 0 1 2 2 v4 a2 2 0 0 0 2 2 h12 a2 2 0 0 0 2 -2 v-4 a2 2 0 0 1 2 -2 M2 12 a2 2 0 0 0 2 -2 v-4 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v4 a2 2 0 0 0 2 2 M0 0 h24 v24 H0 z";
				case IconKind.BrandBulma:
					return "M5 16 l1 -9 l5 -5 l6.5 6 l-3.5 4 l5 5 l-8 5 z M0 0 h24 v24 H0 z";
				case IconKind.BrandBumble:
					return "M16.268 3 h-8.536 a1.46 1.46 0 0 0 -1.268 0.748 l-4.268 7.509 a1.507 1.507 0 0 0 0 1.486 l4.268 7.509 c0.26 0.462 0.744 0.747 1.268 0.748 h8.536 a1.46 1.46 0 0 0 1.268 -0.748 l4.268 -7.509 a1.507 1.507 0 0 0 0 -1.486 l-4.268 -7.509 a1.46 1.46 0 0 0 -1.268 -0.748 z M10 16 h4 M9 8 h6 M7 12 h10 M0 0 h24 v24 H0 z";
				case IconKind.BrandBunpo:
					return "M3.9 7.205 a17.764 17.764 0 0 0 4.008 2.753 a7.917 7.917 0 0 0 4.57 0.567 c1.5 -0.33 2.907 -1 4.121 -1.956 a12.107 12.107 0 0 0 2.892 -2.903 c0.603 -0.94 0.745 -1.766 0.484 -2.231 c-0.261 -0.465 -0.927 -0.568 -1.72 -0.257 a7.564 7.564 0 0 0 -2.608 2.034 a18.425 18.425 0 0 0 -2.588 3.884 a34.927 34.927 0 0 0 -2.093 5.073 a12.908 12.908 0 0 0 -0.677 3.515 c-0.07 0.752 0.07 1.51 0.405 2.184 c0.323 0.562 1.06 1.132 2.343 1.132 c3.474 0 5.093 -3.53 5.463 -5.62 c0.24 -1.365 -0.085 -3.197 -1.182 -4.01 M0 0 h24 v24 H0 z";
				case IconKind.BrandCSharp:
					return "M21 14 h-7.5 M14 10 h7.5 M20 7 l-1 10 M16 7 l-1 10 M10 9 a3 3 0 0 0 -3 -3 h-0.5 a3.5 3.5 0 0 0 -3.5 3.5 v5 a3.5 3.5 0 0 0 3.5 3.5 h0.5 a3 3 0 0 0 3 -3 M0 0 h24 v24 H0 z";
				case IconKind.BrandCampaignmonitor:
					return "M3 18 l9 -6.462 l-9 -5.538 v12 h18 v-12 l-9 5.538 M0 0 h24 v24 H0 z";
				case IconKind.BrandCarbon:
					return "M3 3 m0 3 a3 3 0 0 1 3 -3 h12 a3 3 0 0 1 3 3 v12 a3 3 0 0 1 -3 3 h-12 a3 3 0 0 1 -3 -3 z M14 10 v-0.2 a1.8 1.8 0 0 0 -1.8 -1.8 h-0.4 a1.8 1.8 0 0 0 -1.8 1.8 v4.4 a1.8 1.8 0 0 0 1.8 1.8 h0.4 a1.8 1.8 0 0 0 1.8 -1.8 v-0.2 M0 0 h24 v24 H0 z";
				case IconKind.BrandCashapp:
					return "M17.1 8.648 a0.568 0.568 0 0 1 -0.761 0.011 a5.682 5.682 0 0 0 -3.659 -1.34 c-1.102 0 -2.205 0.363 -2.205 1.374 c0 1.023 1.182 1.364 2.546 1.875 c2.386 0.796 4.363 1.796 4.363 4.137 c0 2.545 -1.977 4.295 -5.204 4.488 l-0.295 1.364 a0.557 0.557 0 0 1 -0.546 0.443 h-2.034 l-0.102 -0.011 a0.568 0.568 0 0 1 -0.432 -0.67 l0.318 -1.444 a7.432 7.432 0 0 1 -3.273 -1.784 v-0.011 a0.545 0.545 0 0 1 0 -0.773 l1.137 -1.102 c0.214 -0.2 0.547 -0.2 0.761 0 a5.495 5.495 0 0 0 3.852 1.5 c1.478 0 2.466 -0.625 2.466 -1.614 c0 -0.989 -1 -1.25 -2.886 -1.954 c-2 -0.716 -3.898 -1.728 -3.898 -4.091 c0 -2.75 2.284 -4.091 4.989 -4.216 l0.284 -1.398 a0.545 0.545 0 0 1 0.545 -0.432 h2.023 l0.114 0.012 a0.544 0.544 0 0 1 0.42 0.647 l-0.307 1.557 a8.528 8.528 0 0 1 2.818 1.58 l0.023 0.022 c0.216 0.228 0.216 0.569 0 0.773 l-1.057 1.057 z M0 0 h24 v24 H0 z";
				case IconKind.BrandChrome:
					return "M9.402 13.5 l-4.2 -7.275 M14.598 13.5 l-4.2 7.275 M12 9 h8.4 M12 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandCitymapper:
					return "M13 9 l3 3 l-3 3 M8 12 h8 M21 11 a1 1 0 1 1 -1 1.013 a1 1 0 0 1 1 -1 v-0.013 z M3 11 a1 1 0 1 1 -1 1.013 a1 1 0 0 1 1 -1 v-0.013 z M0 0 h24 v24 H0 z";
				case IconKind.BrandCodecov:
					return "M9.695 12.985 a5.972 5.972 0 0 0 -3.295 -0.985 c-1.257 0 -2.436 0.339 -3.4 1 a9 9 0 1 1 18 0 c-0.966 -0.664 -2.14 -1 -3.4 -1 a6 6 0 0 0 -5.605 8.144 M0 0 h24 v24 H0 z";
				case IconKind.BrandCodepen:
					return "M12 15 l0 6 M12 3 l0 6 M21 9 l0 6 M3 9 l0 6 M3 9 l9 6 l9 -6 l-9 -6 l-9 6 M3 15 l9 6 l9 -6 l-9 -6 l-9 6 M0 0 h24 v24 H0 z";
				case IconKind.BrandCodesandbox:
					return "M8 5.25 l4 2.25 l4 -2.25 M4 12 l4 2 l0 4.75 M20 12 l-4 2 v4.75 M12 12 l-4 -2.25 l-4 -2.25 M12 12 l0 9 M12 12 l4 -2.25 l4 -2.25 M20 7.5 v9 l-4 2.25 l-4 2.25 l-4 -2.25 l-4 -2.25 v-9 l4 -2.25 l4 -2.25 l4 2.25 z M0 0 h24 v24 H0 z";
				case IconKind.BrandCohost:
					return "M11 12.508 c-0.53 -0.316 -1.23 -0.508 -2 -0.508 c-1.657 0 -3 0.895 -3 2 s1.343 2 3 2 c0.767 0 1.467 -0.192 2 -0.508 M4.526 17.666 c-1.133 -0.772 -1.897 -1.924 -2.291 -3.456 c-0.398 -1.54 -0.29 -2.937 0.32 -4.19 c0.61 -1.255 1.59 -2.34 2.938 -3.254 c1.348 -0.914 2.93 -1.625 4.749 -2.132 c1.81 -0.504 3.516 -0.708 5.12 -0.61 c1.608 0.1 2.979 0.537 4.112 1.31 s1.897 1.924 2.291 3.456 c0.398 1.541 0.29 2.938 -0.32 4.192 c-0.61 1.253 -1.59 2.337 -2.938 3.252 c-1.348 0.915 -2.93 1.626 -4.749 2.133 c-1.81 0.503 -3.516 0.707 -5.12 0.61 c-1.608 -0.102 -2.979 -0.538 -4.112 -1.31 z M17 14 m-3 0 a3 2 0 1 0 6 0 a3 2 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandCoinbase:
					return "M12.95 22 c-4.503 0 -8.445 -3.04 -9.61 -7.413 c-1.165 -4.373 0.737 -8.988 4.638 -11.25 a9.906 9.906 0 0 1 12.008 1.598 l-3.335 3.367 a5.185 5.185 0 0 0 -7.354 0.013 a5.252 5.252 0 0 0 0 7.393 a5.185 5.185 0 0 0 7.354 0.013 l3.349 3.367 a9.887 9.887 0 0 1 -7.05 2.912 z M0 0 h24 v24 H0 z";
				case IconKind.BrandComedyCentral:
					return "M13.828 9.172 a4 4 0 1 0 0 5.656 M5.343 17.657 a8 8 0 1 0 0 -11.314 M0 0 h24 v24 H0 z";
				case IconKind.BrandCoreos:
					return "M9.5 9 a4.494 4.494 0 0 1 5.5 5.5 M12 3 c-3.263 3.212 -3 7.654 -3 12 c4.59 0.244 8.814 -0.282 12 -3 M21 12 a9 9 0 1 1 -18 0 a9 9 0 0 1 18 0 z M0 0 h24 v24 H0 z";
				case IconKind.BrandCouchdb:
					return "M3 11 v7 M21 11 v7 M6 18 h12 M6 15 h12 M6 12 h12 v-2 a2 2 0 0 1 2 -2 a2 2 0 0 0 -2 -2 h-12 a2 2 0 0 0 -2 2 a2 2 0 0 1 2 2 v2 z M0 0 h24 v24 H0 z";
				case IconKind.BrandCouchsurfing:
					return "M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M3.1 13 c3.267 0 5.9 -0.167 7.9 -0.5 c3 -0.5 4 -2 4 -3.5 a3 3 0 1 0 -6 0 c0 1.554 1.807 3 3 4 c1.193 1 2 2.5 2 3.5 a1.5 1.5 0 1 1 -3 0 c0 -2 4 -3.5 7 -3.5 h2.9 M0 0 h24 v24 H0 z";
				case IconKind.BrandCpp:
					return "M9 9 a3 3 0 0 0 -3 -3 h-0.5 a3.5 3.5 0 0 0 -3.5 3.5 v5 a3.5 3.5 0 0 0 3.5 3.5 h0.5 a3 3 0 0 0 3 -3 M13 10 v4 M11 12 h4 M20 10 v4 M18 12 h4 M0 0 h24 v24 H0 z";
				case IconKind.BrandCss3:
					return "M8.5 8 h7 l-4.5 4 h4 l-0.5 3.5 l-2.5 0.75 l-2.5 -0.75 l-0.1 -0.5 M20 4 l-2 14.5 l-6 2 l-6 -2 l-2 -14.5 z M0 0 h24 v24 H0 z";
				case IconKind.BrandCtemplar:
					return "M17.738 15 l-4.238 -4.5 M20 5 c-2 0 -4.37 3.304 -8 6.644 c-3.63 -3.34 -6 -6.644 -8 -6.644 M12.555 20.82 c4.55 -3.456 7.582 -8.639 8.426 -14.405 a1.668 1.668 0 0 0 -0.934 -1.767 a19.647 19.647 0 0 0 -8.047 -1.648 a19.647 19.647 0 0 0 -8.047 1.647 a1.668 1.668 0 0 0 -0.934 1.767 c0.844 5.766 3.875 10.95 8.426 14.406 a0.948 0.948 0 0 0 1.11 0 z M6.04 14.831 l4.46 -4.331 M0 0 h24 v24 H0 z";
				case IconKind.BrandCucumber:
					return "M9 10 l-1 -0.5 M16 12.5 l-1 -0.5 M13 8 l0.5 -1 M11 14 l-0.5 1 M9 12.5 l-1 0.5 M13.5 14 l0.5 1 M10.5 8 l-0.5 -1 M20 10.99 c-0.01 5.52 -4.48 10 -10 10.01 v-2.26 l-0.01 -0.01 c-4.28 -1.11 -6.86 -5.47 -5.76 -9.75 a8 8 0 0 1 9.74 -5.76 c3.53 0.91 6.03 4.13 6.03 7.78 v-0.01 z M0 0 h24 v24 H0 z";
				case IconKind.BrandCupra:
					return "M10 19 l-3.388 -5.808 a0.2 0.2 0 0 1 0.09 -0.283 l15.298 -6.909 l-2.5 4 M4.5 10 l-2.5 -4 l15.298 6.909 a0.2 0.2 0 0 1 0.09 0.283 l-3.388 5.808 M0 0 h24 v24 H0 z";
				case IconKind.BrandCypress:
					return "M10.764 9.411 a3 3 0 1 0 -0.023 5.19 M13.5 9 l2 6 M19.48 17.007 a9 9 0 1 0 -7.48 3.993 c0.896 0 1.691 -0.573 1.974 -1.423 l3.526 -10.577 M0 0 h24 v24 H0 z";
				case IconKind.BrandD3:
					return "M17.472 12 c1.948 0 3.528 1.79 3.528 4 s-1.58 4 -3.528 4 h-5.472 M17.472 12 h-2.352 M17.472 12 h-2.472 M12 4 h5.472 c1.948 0 3.528 1.79 3.528 4 s-1.58 4 -3.528 4 M3 4 h1.8 c3.976 0 7.2 3.582 7.2 8 s-3.224 8 -7.2 8 h-1.8 M0 0 h24 v24 H0 z";
				case IconKind.BrandDaysCounter:
					return "M12 8 v4 l3 3 M13 21 h8 v-7 M20.779 10.007 a9 9 0 1 0 -10.77 10.772 M0 0 h24 v24 H0 z";
				case IconKind.BrandDcos:
					return "M3 18 l18 -12 h-18 l9 14 l9 -14 v10 l-18 -10 z M0 0 h24 v24 H0 z";
				case IconKind.BrandDebian:
					return "M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M12 17 c-2.397 -0.943 -4 -3.153 -4 -5.635 c0 -2.19 1.039 -3.14 1.604 -3.595 c2.646 -2.133 6.396 -0.27 6.396 3.23 c0 2.5 -2.905 2.121 -3.5 1.5 c-0.595 -0.621 -1 -1.5 -0.5 -2.5 M0 0 h24 v24 H0 z";
				case IconKind.BrandDeliveroo:
					return "M10.5,14.5a1,1 0 1,0 2,0a1,1 0 1,0 -2,0 M14.5,15.5a1,1 0 1,0 2,0a1,1 0 1,0 -2,0 M15 11 l1 -9 l5 0.5 l-1 13.5 l-3 6 l-12.5 -2.5 l-1.5 -6 l7 -1.5 l-1.5 -7.5 l4.5 -1 z M0 0 h24 v24 H0 z";
				case IconKind.BrandDeno:
					return "M12 11 h0.01 M13.47 20.882 l-1.47 -5.882 c-2.649 -0.088 -5 -1.624 -5 -3.5 c0 -1.933 2.239 -3.5 5 -3.5 s4 1 5 3 c0.024 0.048 0.69 2.215 2 6.5 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandDenodo:
					return "M3.634 8.366 l1 -1.732 l1.732 1 l-1 1.732 z M11 3 h2 v2 h-2 z M17.634 7.634 l1.732 -1 l1 1.732 l-1.732 1 z M18.634 14.634 l1.732 1 l-1 1.732 l-1.732 -1 z M11 19 h2 v2 h-2 z M3.634 15.634 l1.732 -1 l1 1.732 l-1.732 1 z M11 11 h2 v2 h-2 z M0 0 h24 v24 H0 z";
				case IconKind.BrandDeviantart:
					return "M18 3 v4 l-3.857 6 h3.857 v4 h-6.429 l-2.571 4 h-3 v-4 l3.857 -6 h-3.857 v-4 h6.429 l2.571 -4 z M0 0 h24 v24 H0 z";
				case IconKind.BrandDingtalk:
					return "M8 7.5 l7.02 2.632 a1 1 0 0 1 0.567 1.33 l-1.087 2.538 h1.5 l-5 4 l1 -4 c-3.1 0.03 -3.114 -3.139 -4 -6.5 z M21 12 a9 9 0 1 1 -18 0 a9 9 0 0 1 18 0 z M0 0 h24 v24 H0 z";
				case IconKind.BrandDiscord:
					return "M8.5 17 c0 1 -1.356 3 -1.832 3 c-1.429 0 -2.698 -1.667 -3.333 -3 c-0.635 -1.667 -0.476 -5.833 1.428 -11.5 c1.388 -1.015 2.782 -1.34 4.237 -1.5 l1 2.5 M15.5 17 c0 1 1.5 3 2 3 c1.5 0 2.833 -1.667 3.5 -3 c0.667 -1.667 0.5 -5.833 -1.5 -11.5 c-1.457 -1.015 -3 -1.34 -4.5 -1.5 l-1 2.5 M7 16.5 c3.5 1 6.5 1 10 0 M7.5 7.5 c3.5 -1 5.5 -1 9 0 M15 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M9 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandDisney:
					return "M10.02 8 a505.153 505.153 0 0 0 0 13 M3.22 5.838 c-1.307 -0.15 -1.22 -0.578 -1.22 -0.794 c0 -0.216 0.424 -1.044 4.34 -1.044 c4.694 0 14.66 3.645 14.66 10.042 s-8.71 4.931 -10.435 4.52 c-1.724 -0.412 -5.565 -2.256 -5.565 -4.174 c0 -1.395 3.08 -2.388 6.715 -2.388 c3.634 0 5.285 1.041 5.285 2 c0 0.5 -0.074 1.229 -1 1.5 M0 0 h24 v24 H0 z";
				case IconKind.BrandDisqus:
					return "M11.485 15 h-1.485 v-6 h1.485 c2.112 0 3.515 0.823 3.515 2.981 v0.035 c0 2.18 -1.403 2.984 -3.515 2.984 z M11.847 21 c-2.259 0 -4.323 -0.667 -5.919 -2 h-3.928 l1.708 -3.266 c-0.545 -1.174 -0.759 -2.446 -0.758 -3.734 c0 -4.97 3.84 -9 8.898 -9 c5.052 0 9.152 4.03 9.152 9 c0 4.972 -4.098 9 -9.153 9 z M0 0 h24 v24 H0 z";
				case IconKind.BrandDjango:
					return "M16 10 v5.586 c0 0.905 -0.36 1.774 -1 2.414 M16 7 v0.01 M12 7 v8.5 l-2.015 0.201 a2.715 2.715 0 1 1 0 -5.402 l2.015 0.201 M3 3 m0 3 a3 3 0 0 1 3 -3 h12 a3 3 0 0 1 3 3 v12 a3 3 0 0 1 -3 3 h-12 a3 3 0 0 1 -3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.BrandDocker:
					return "M10 16 l0 0.01 M4.571 18 c1.5 0 2.047 -0.074 2.958 -0.78 M11 4 h3 v3 h-3 z M11 7 h3 v3 h-3 z M8 7 h3 v3 h-3 z M11 10 h3 v3 h-3 z M8 10 h3 v3 h-3 z M5 10 h3 v3 h-3 z M22 12.54 c-1.804 -0.345 -2.701 -1.08 -3.523 -2.94 c-0.487 0.696 -1.102 1.568 -0.92 2.4 c0.028 0.238 -0.32 1 -0.557 1 h-14 c0 5.208 3.164 7 6.196 7 c4.124 0.022 7.828 -1.376 9.854 -5 c1.146 -0.101 2.296 -1.505 2.95 -2.46 z M0 0 h24 v24 H0 z";
				case IconKind.BrandDoctrine:
					return "M10 3 l6.9 6 M12 11 l3 3 l-3 3 M9 14 h6 M12 14 m-7 0 a7 7 0 1 0 14 0 a7 7 0 1 0 -14 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandDolbyDigital:
					return "M3.063 6 v12 h0.891 c3.34 0 6.046 -2.686 6.046 -6 s-2.707 -6 -6.046 -6 h-0.89 z M21 6 v12 h-0.89 c-3.34 0 -6.047 -2.686 -6.047 -6 s2.707 -6 6.046 -6 h0.891 z M0 0 h24 v24 H0 z";
				case IconKind.BrandDouban:
					return "M8 17 l1 3 M16 14 l-2 6 M8 8 h8 a2 2 0 0 1 2 2 v2 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 v-2 a2 2 0 0 1 2 -2 z M5 4 h14 M4 20 h16 M0 0 h24 v24 H0 z";
				case IconKind.BrandDribbble:
					return "M3.1 10.75 c5 0 9.814 -0.38 15.314 -5 M6.4 19 c3.5 -3.5 6 -6.5 14.5 -6.4 M9 3.6 c5 6 7 10.5 7.5 16.2 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandDrops:
					return "M14.466 10.923 a3.595 3.595 0 0 1 0.77 3.877 a3.5 3.5 0 0 1 -3.236 2.2 a3.5 3.5 0 0 1 -3.236 -2.2 a3.595 3.595 0 0 1 0.77 -3.877 l2.466 -2.423 l2.466 2.423 z M17.637 7.416 a7.907 7.907 0 0 1 1.76 8.666 a8 8 0 0 1 -7.397 4.918 a8 8 0 0 1 -7.396 -4.918 a7.907 7.907 0 0 1 1.759 -8.666 l5.637 -5.416 l5.637 5.416 z M0 0 h24 v24 H0 z";
				case IconKind.BrandDrupal:
					return "M12 11.33 a65.753 65.753 0 0 1 -2.012 2.023 c-1 0.957 -1.988 1.967 -1.988 3.647 c0 2.17 1.79 4 4 4 s4 -1.827 4 -4 c0 -1.676 -0.989 -2.685 -1.983 -3.642 c-0.42 -0.404 -2.259 -2.357 -5.517 -5.858 l3.5 3.83 z M12 2 c0 4.308 -7 6 -7 12 a7 7 0 0 0 14 0 c0 -6 -7 -7.697 -7 -12 z M0 0 h24 v24 H0 z";
				case IconKind.BrandEdge:
					return "M12.628 20.978 c-2.993 0.21 -5.162 -4.725 -3.567 -9.748 M3.022 12.628 c-0.283 -4.043 8.717 -7.228 11.248 -2.688 M20.978 11.372 c0.21 2.993 -5.034 2.413 -6.913 1.486 c1.392 -1.6 0.402 -4.038 -2.274 -3.851 c-1.745 0.122 -2.927 1.157 -2.784 3.202 c0.28 3.99 4.444 6.205 10.36 4.79 M20.978 11.372 a9 9 0 1 0 -1.593 5.773 M0 0 h24 v24 H0 z";
				case IconKind.BrandElastic:
					return "M5.417 15 l4.083 -4 M14.5 19 l1 -3.5 M18.499 16 l-3 -0.5 l-1 -2.5 M9.5 5 l-1 4 l1 2 l5 2 l4 -4 M8.5 9 l-3 -1 M14 2 a5 5 0 0 1 5 5 c0 0.712 -0.232 1.387 -0.5 2 c1.894 0.042 3.5 1.595 3.5 3.5 c0 1.869 -1.656 3.4 -3.5 3.5 c0.333 0.625 0.5 1.125 0.5 1.5 a2.5 2.5 0 0 1 -2.5 2.5 c-0.787 0 -1.542 -0.432 -2 -1 c-0.786 1.73 -2.476 3 -4.5 3 a5 5 0 0 1 -4.583 -7 a3.5 3.5 0 0 1 -0.11 -6.992 l0.195 0 a2.5 2.5 0 0 1 2 -4 c0.787 0 1.542 0.432 2 1 c0.786 -1.73 2.476 -3 4.5 -3 z M0 0 h24 v24 H0 z";
				case IconKind.BrandEmber:
					return "M3 12.958 c8.466 1.647 11.112 -1.196 12.17 -2.294 c2.116 -2.196 0 -6.589 -2.646 -5.49 c-2.644 1.096 -6.35 7.686 -3.174 12.078 c2.116 2.928 6 2.178 11.65 -2.252 M0 0 h24 v24 H0 z";
				case IconKind.BrandEnvato:
					return "M19.715 12.508 c-0.54 3.409 -2.094 6.156 -4.155 7.348 c-4.069 2.353 -8.144 0.45 -9.297 -0.188 c0.877 -1.436 4.433 -7.22 6.882 -10.591 c2.714 -3.737 5.864 -5.978 6.565 -6.077 c0 0.201 0.03 0.55 0.071 1.03 c0.144 1.709 0.443 5.264 -0.066 8.478 z M4.711 17.875 c-0.534 -1.339 -1.35 -4.178 0.129 -6.47 c1.415 -2.193 3.769 -3.608 5.099 -4.278 l-5.229 10.748 z M0 0 h24 v24 H0 z";
				case IconKind.BrandEtsy:
					return "M15 16 h-5 a1 1 0 0 1 -1 -1 v-6 a1 1 0 0 1 1 -1 h5 M3 3 m0 5 a5 5 0 0 1 5 -5 h8 a5 5 0 0 1 5 5 v8 a5 5 0 0 1 -5 5 h-8 a5 5 0 0 1 -5 -5 z M14 12 h-5 M0 0 h24 v24 H0 z";
				case IconKind.BrandEvernote:
					return "M15 10 h1 M17.9 19 c0.6 -2.5 1.1 -5.471 1.1 -9 c0 -4.5 -2 -5 -3 -5 c-1.906 0 -3 -0.5 -3.5 -1 c-0.354 -0.354 -0.5 -1 -1.5 -1 h-2 l-5 5 c0 6 2.5 8 5 8 c1 0 1.5 -0.5 2 -1.5 s1.414 -0.326 2.5 0 c1.044 0.313 2.01 0.255 2.5 0.5 c1 0.5 2 1.5 2 3 c0 0.5 0 3 -3 3 s-3 -3 -1 -3 M4 8 h5 v-5 M0 0 h24 v24 H0 z";
				case IconKind.BrandFacebook:
					return "M7 10 v4 h3 v7 h4 v-7 h3 l1 -4 h-4 v-2 a1 1 0 0 1 1 -1 h3 v-4 h-3 a5 5 0 0 0 -5 5 v2 h-3 M0 0 h24 v24 H0 z";
				case IconKind.BrandFigma:
					return "M9 9 a3 3 0 0 0 0 6 h3 m-3 0 a3 3 0 1 0 3 3 v-15 M6 3 m0 3 a3 3 0 0 1 3 -3 h6 a3 3 0 0 1 3 3 v0 a3 3 0 0 1 -3 3 h-6 a3 3 0 0 1 -3 -3 z M15 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandFinder:
					return "M7 15.5 c3.667 2 6.333 2 10 0 M12.5 4 c-0.654 1.486 -1.26 3.443 -1.5 9 h2.5 c-0.19 2.867 0.094 5.024 0.5 7 M17 8 v1 M7 8 v1 M3 4 m0 1 a1 1 0 0 1 1 -1 h16 a1 1 0 0 1 1 1 v14 a1 1 0 0 1 -1 1 h-16 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.BrandFirebase:
					return "M4.57 17.18 l10.93 -10.68 M15.47 6.45 c0.58 -0.59 1.53 -0.59 2.11 -0.01 c0.22 0.22 0.36 0.5 0.41 0.81 l1.5 9.11 c0.1 0.62 -0.2 1.24 -0.76 1.54 l-6.07 2.9 c-0.46 0.25 -1.01 0.26 -1.46 0 l-6.02 -2.92 c-0.55 -0.31 -0.85 -0.92 -0.75 -1.54 l1.96 -12.04 c0.12 -0.82 0.89 -1.38 1.7 -1.25 c0.46 0.07 0.87 0.36 1.09 0.77 l1.24 1.76 M4.53 17.05 l6.15 -11.72 h-0.02 c0.38 -0.74 1.28 -1.02 2.01 -0.63 c0.26 0.14 0.48 0.36 0.62 0.62 l1.06 2.01 M0 0 h24 v24 H0 z";
				case IconKind.BrandFirefox:
					return "M4.914 9.485 c-1.756 -1.569 -0.805 -5.38 0.109 -6.17 c0.086 0.896 0.585 1.208 1.111 1.685 c0.88 -0.275 1.313 -0.282 1.867 0 c0.82 -0.91 1.694 -2.354 2.628 -2.093 c-1.082 1.741 -0.07 3.733 1.371 4.173 c-0.17 0.975 -1.484 1.913 -2.76 2.686 c-1.296 0.938 -0.722 1.85 0 2.234 c0.949 0.506 3.611 -1 4.545 0.354 c-1.698 0.102 -1.536 3.107 -3.983 2.727 c2.523 0.957 4.345 0.462 5.458 -0.34 c1.965 -1.52 2.879 -3.542 2.879 -5.557 c-0.014 -1.398 0.194 -2.695 -1.26 -4.75 M4.028 7.82 a9 9 0 1 0 12.823 -3.4 c-1.636 -1.02 -3.064 -1.02 -4.851 -1.02 h-1.647 M0 0 h24 v24 H0 z";
				case IconKind.BrandFlickr:
					return "M17 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M7 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandFlightradar24:
					return "M12 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M8.5 20 l3.5 -8 l-6.5 6 M12 12 m-5 0 a5 5 0 1 0 10 0 a5 5 0 1 0 -10 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandFlipboard:
					return "M3.973 3 h16.054 c0.537 0 0.973 0.436 0.973 0.973 v4.052 a0.973 0.973 0 0 1 -0.973 0.973 h-5.025 v4.831 c0 0.648 -0.525 1.173 -1.173 1.173 h-4.829 v5.025 a0.973 0.973 0 0 1 -0.974 0.973 h-4.053 a0.973 0.973 0 0 1 -0.973 -0.973 v-16.054 c0 -0.537 0.436 -0.973 0.973 -0.973 z M0 0 h24 v24 H0 z";
				case IconKind.BrandFlutter:
					return "M14 21 l-5 -5 l5 -5 h5 l-5 5 l5 5 z M7 14 l-3 -3 l8 -8 h6 z M0 0 h24 v24 H0 z";
				case IconKind.BrandFortnite:
					return "M8 3 h7.5 l-0.5 4 h-3 v3 h3 v3.5 h-3 v6.5 l-4 1 z M0 0 h24 v24 H0 z";
				case IconKind.BrandFoursquare:
					return "M12 9 l5 0 M7 3 h10 c0.644 0 1.11 0.696 0.978 1.33 l-1.984 9.859 a1.014 1.014 0 0 1 -1 0.811 h-2.254 c-0.308 0 -0.6 0.141 -0.793 0.382 l-4.144 5.25 c-0.599 0.752 -1.809 0.331 -1.809 -0.632 v-16 c0 -0.564 0.44 -1 1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.BrandFramer:
					return "M6 15 h12 l-12 -12 h12 v6 h-12 v6 l6 6 v-6 M0 0 h24 v24 H0 z";
				case IconKind.BrandFunimation:
					return "M8 13 h8 a4 4 0 1 1 -8 0 z M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandGatsby:
					return "M16 13 h5 c-0.41 3.603 -3.007 6.59 -6.386 7.614 l-11.228 -11.229 a9 9 0 0 1 15.66 -2.985 M3.296 14.297 l6.407 6.407 a9.018 9.018 0 0 1 -6.325 -6.116 l-0.082 -0.291 z M0 0 h24 v24 H0 z";
				case IconKind.BrandGit:
					return "M10.5 20.4 l-6.9 -6.9 c-0.781 -0.781 -0.781 -2.219 0 -3 l6.9 -6.9 c0.781 -0.781 2.219 -0.781 3 0 l6.9 6.9 c0.781 0.781 0.781 2.219 0 3 l-6.9 6.9 c-0.781 0.781 -2.219 0.781 -3 0 z M11 7 l-1.9 -1.9 M15 11 l-2 -2 M12 15 v-6 M12 16 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12 8 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M16 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandGithubCopilot:
					return "M14 15 v2 M10 15 v2 M12 7.5 l0 -0.297 l0.01 -0.269 l0.027 -0.298 l0.013 -0.105 l0.033 -0.215 c0.014 -0.073 0.029 -0.146 0.046 -0.22 l0.06 -0.223 c0.336 -1.118 1.262 -2.237 3.808 -1.873 c2.838 0.405 3.703 1.797 3.93 2.842 l0.036 0.204 c0 0.033 0.01 0.066 0.013 0.098 l0.016 0.185 l0 0.171 l0 0.49 l-0.015 0.394 l-0.02 0.271 c-0.122 1.366 -0.655 2.845 -2.962 2.845 c-3.256 0 -4.524 -1.656 -4.883 -3.081 l-0.053 -0.242 a3.865 3.865 0 0 1 -0.036 -0.235 l-0.021 -0.227 a3.518 3.518 0 0 1 -0.007 -0.215 z M20 18 v-5.5 c0 -0.667 -0.167 -1.333 -0.5 -2 M4 12 c-1.333 0.667 -2 1.333 -2 2 c0 1 0 3 1.5 4 c3 2 6.5 3 8.5 3 s5.499 -1 8.5 -3 c1.5 -1 1.5 -3 1.5 -4 c0 -0.667 -0.667 -1.333 -2 -2 M12 7.5 c0 -1 -0.01 -4.07 -4 -3.5 c-3.5 0.5 -4 2.5 -4 3.5 c0 1.5 0 4 3 4 c4 0 5 -2.5 5 -4 z M4 18 v-5.5 c0 -0.667 0.167 -1.333 0.5 -2 M0 0 h24 v24 H0 z";
				case IconKind.BrandGithub:
					return "M9 19 c-4.3 1.4 -4.3 -2.5 -6 -3 m12 5 v-3.5 c0 -1 0.1 -1.4 -0.5 -2 c2.8 -0.3 5.5 -1.4 5.5 -6 a4.6 4.6 0 0 0 -1.3 -3.2 a4.2 4.2 0 0 0 -0.1 -3.2 s-1.1 -0.3 -3.5 1.3 a12.3 12.3 0 0 0 -6.2 0 c-2.4 -1.6 -3.5 -1.3 -3.5 -1.3 a4.2 4.2 0 0 0 -0.1 3.2 a4.6 4.6 0 0 0 -1.3 3.2 c0 4.6 2.7 5.7 5.5 6 c-0.6 0.6 -0.6 1.2 -0.5 2 v3.5 M0 0 h24 v24 H0 z";
				case IconKind.BrandGitlab:
					return "M21 14 l-9 7 l-9 -7 l3 -11 l3 7 h6 l3 -7 z M0 0 h24 v24 H0 z";
				case IconKind.BrandGmail:
					return "M4 6.5 l8 7.5 l8 -7.5 M16 4 l-4 4 l-4 -4 M5 20 h3 v-16 h-3 a1 1 0 0 0 -1 1 v14 a1 1 0 0 0 1 1 z M16 20 h3 a1 1 0 0 0 1 -1 v-14 a1 1 0 0 0 -1 -1 h-3 v16 z M0 0 h24 v24 H0 z";
				case IconKind.BrandGoogleAnalytics:
					return "M5 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M17 3 m0 1.105 a1.105 1.105 0 0 1 1.105 -1.105 h1.79 a1.105 1.105 0 0 1 1.105 1.105 v15.79 a1.105 1.105 0 0 1 -1.105 1.105 h-1.79 a1.105 1.105 0 0 1 -1.105 -1.105 z M10 9 m0 1.105 a1.105 1.105 0 0 1 1.105 -1.105 h1.79 a1.105 1.105 0 0 1 1.105 1.105 v9.79 a1.105 1.105 0 0 1 -1.105 1.105 h-1.79 a1.105 1.105 0 0 1 -1.105 -1.105 z M0 0 h24 v24 H0 z";
				case IconKind.BrandGoogleBigQuery:
					return "M14 14 l2 2 M11.5 11.5 m-3.5 0 a3.5 3.5 0 1 0 7 0 a3.5 3.5 0 1 0 -7 0 M17.73 19.875 a2.225 2.225 0 0 1 -1.948 1.125 h-7.283 a2.222 2.222 0 0 1 -1.947 -1.158 l-4.272 -6.75 a2.269 2.269 0 0 1 0 -2.184 l4.272 -6.75 a2.225 2.225 0 0 1 1.946 -1.158 h7.285 c0.809 0 1.554 0.443 1.947 1.158 l3.98 6.75 a2.33 2.33 0 0 1 0 2.25 l-3.98 6.75 v-0.033 z M0 0 h24 v24 H0 z";
				case IconKind.BrandGoogleDrive:
					return "M15 15 l-6 -10 h6 l6 10 z M9 15 h12 l-3 5 h-12 M12 10 l-6 10 l-3 -5 l6 -10 z M0 0 h24 v24 H0 z";
				case IconKind.BrandGoogleFit:
					return "M12 9.314 l-2.343 -2.344 a3.314 3.314 0 0 0 -4.686 4.686 l2.343 2.344 l4.686 4.686 l7.03 -7.03 a3.314 3.314 0 0 0 -4.687 -4.685 l-7.03 7.029 M0 0 h24 v24 H0 z";
				case IconKind.BrandGoogleHome:
					return "M17 17 v4 M7 17 v4 M14.8 5.2 l-11.8 11.8 M7 13 v4 h10 v-4 l-5 -5 M19.072 21 h-14.144 a1.928 1.928 0 0 1 -1.928 -1.928 v-6.857 c0 -0.512 0.203 -1 0.566 -1.365 l7.07 -7.063 a1.928 1.928 0 0 1 2.727 0 l7.071 7.063 c0.363 0.362 0.566 0.853 0.566 1.365 v6.857 a1.928 1.928 0 0 1 -1.928 1.928 z M0 0 h24 v24 H0 z";
				case IconKind.BrandGoogleOne:
					return "M6.63 8.407 a2.125 2.125 0 0 0 -0.074 2.944 c0.77 0.834 2.051 0.869 2.862 0.077 l4.95 -4.834 c0.812 -0.792 0.846 -2.11 0.076 -2.945 a1.984 1.984 0 0 0 -2.861 -0.077 l-4.953 4.835 z M11 5 v13.982 a2 2 0 0 0 4 0 v-13.982 a2 2 0 1 0 -4 0 z M0 0 h24 v24 H0 z";
				case IconKind.BrandGooglePhotos:
					return "M17 7.5 c0 2.485 -1.972 4.5 -4.405 4.5 h-0.595 v-8.397 a0.61 0.61 0 0 1 0.175 -0.428 a0.584 0.584 0 0 1 0.42 -0.175 c2.433 0 4.405 2.015 4.405 4.5 z M7 16.5 c0 -2.485 1.972 -4.5 4.405 -4.5 h0.595 v8.392 a0.61 0.61 0 0 1 -0.173 0.431 a0.584 0.584 0 0 1 -0.422 0.177 c-2.433 0 -4.405 -2.015 -4.405 -4.5 z M16.5 17 c-2.485 0 -4.5 -1.974 -4.5 -4.409 v-0.591 h8.397 c0.333 0 0.603 0.265 0.603 0.591 c0 2.435 -2.015 4.409 -4.5 4.409 z M7.5 7 c2.485 0 4.5 1.974 4.5 4.409 v0.591 h-8.397 a0.61 0.61 0 0 1 -0.426 -0.173 a0.585 0.585 0 0 1 -0.177 -0.418 c0 -2.435 2.015 -4.409 4.5 -4.409 z M0 0 h24 v24 H0 z";
				case IconKind.BrandGooglePlay:
					return "M4.5 3.5 l10.5 11.5 M15 9 l-10.5 11.5 M4 3.71 v16.58 a0.7 0.7 0 0 0 1.05 0.606 l14.622 -8.42 a0.55 0.55 0 0 0 0 -0.953 l-14.622 -8.419 a0.7 0.7 0 0 0 -1.05 0.607 z M0 0 h24 v24 H0 z";
				case IconKind.BrandGooglePodcasts:
					return "M16 19 v-8 M16 7 v-2 M8 5 v8 M20 11 v2 M4 11 v2 M8 17 v2 M12 8 v8 M12 19 v2 M12 3 v2 M0 0 h24 v24 H0 z";
				case IconKind.BrandGoogle:
					return "M17.788 5.108 a9 9 0 1 0 3.212 6.892 h-8 M0 0 h24 v24 H0 z";
				case IconKind.BrandGrammarly:
					return "M13.5 14 h2.5 v2.5 M15.697 9.434 a4.5 4.5 0 1 0 0.217 4.788 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandGraphql:
					return "M20 8 m-1.5 0 a1.5 1.5 0 1 0 3 0 a1.5 1.5 0 1 0 -3 0 M20 16 m-1.5 0 a1.5 1.5 0 1 0 3 0 a1.5 1.5 0 1 0 -3 0 M4 16 m-1.5 0 a1.5 1.5 0 1 0 3 0 a1.5 1.5 0 1 0 -3 0 M4 8 m-1.5 0 a1.5 1.5 0 1 0 3 0 a1.5 1.5 0 1 0 -3 0 M12 20.5 m-1.5 0 a1.5 1.5 0 1 0 3 0 a1.5 1.5 0 1 0 -3 0 M12 3.5 m-1.5 0 a1.5 1.5 0 1 0 3 0 a1.5 1.5 0 1 0 -3 0 M5.107 14.988 l6.122 -10.201 M18.5 16 h-13 M12.772 4.786 l6.121 10.202 M4 14.5 v-5 M10.692 19.765 l-5.384 -3.03 M18.693 16.736 l-5.385 3.029 M20 9.5 v5 M13.308 4.235 l5.384 3.03 M5.308 7.265 l5.385 -3.029 M0 0 h24 v24 H0 z";
				case IconKind.BrandGravatar:
					return "M5.64 5.632 a9 9 0 1 0 6.36 -2.632 v7.714 M0 0 h24 v24 H0 z";
				case IconKind.BrandGrindr:
					return "M11 13.282 c0 0.492 -0.784 1.718 -2.102 1.718 c-1.318 0 -2.898 -0.966 -2.898 -2.062 c0 -0.817 0.932 -0.938 1.409 -0.938 c0.228 0 3.591 0.111 3.591 1.282 z M12 21 c-2.984 0 -6.471 -2.721 -6.63 -2.982 c-2.13 -3.49 -2.37 -13.703 -2.37 -13.703 l1.446 -1.315 c2.499 0.39 5.023 0.617 7.554 0.68 a58.626 58.626 0 0 0 7.554 -0.68 l1.446 1.315 s-0.24 10.213 -2.37 13.704 c-0.16 0.26 -3.646 2.981 -6.63 2.981 z M13 13.282 c0 0.492 0.784 1.718 2.102 1.718 c1.318 0 2.898 -0.966 2.898 -2.062 c0 -0.817 -0.932 -0.938 -1.409 -0.938 c-0.228 0 -3.591 0.111 -3.591 1.282 z M0 0 h24 v24 H0 z";
				case IconKind.BrandGuardian:
					return "M13.5 3 h1 M13.5 21 h1.5 M15 13 v8 s2.77 -0.37 4 -2 v-6 M14.5 3 c1.416 0 3.853 1.16 4.5 2 v3.5 M4 12 c0 -9.296 9.5 -9 9.5 -9 c-2.808 0 -4.5 4.373 -4.5 9 s1.763 8.976 4.572 8.976 c0 0.023 -9.572 1.092 -9.572 -8.976 z M14 13 h6 M0 0 h24 v24 H0 z";
				case IconKind.BrandGumroad:
					return "M15.024 9.382 a4 4 0 1 0 -3.024 6.618 c1.862 0 2.554 -1.278 3 -3 M13.5 13 h2.5 v3 M21 12 a9 9 0 1 1 -18 0 a9 9 0 0 1 18 0 z M0 0 h24 v24 H0 z";
				case IconKind.BrandHbo:
					return "M19 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M19 8 a4 4 0 1 1 0 8 a4 4 0 0 1 0 -8 z M9 16 h2 a2 2 0 1 0 0 -4 h-2 h2 a2 2 0 1 0 0 -4 h-2 v8 z M2 12 h4 M6 8 v8 M2 16 v-8 M0 0 h24 v24 H0 z";
				case IconKind.BrandHeadlessui:
					return "M7.252 7.704 l7.897 -1.28 a1 1 0 0 1 1.147 0.828 l0.36 2.223 l-9.562 3.51 l-0.67 -4.134 a1 1 0 0 1 0.828 -1.147 z M6.744 4.325 l7.82 -1.267 a4.456 4.456 0 0 1 5.111 3.686 l1.267 7.82 a4.456 4.456 0 0 1 -3.686 5.111 l-7.82 1.267 a4.456 4.456 0 0 1 -5.111 -3.686 l-1.267 -7.82 a4.456 4.456 0 0 1 3.686 -5.111 z M0 0 h24 v24 H0 z";
				case IconKind.BrandHipchat:
					return "M7.5 13.5 c2.5 2.5 6.5 2.5 9 0 M17.802 17.292 s0.077 -0.055 0.2 -0.149 c1.843 -1.425 3 -3.49 3 -5.789 c0 -4.286 -4.03 -7.764 -9 -7.764 c-4.97 0 -9 3.478 -9 7.764 c0 4.288 4.03 7.646 9 7.646 c0.424 0 1.12 -0.028 2.088 -0.084 c1.262 0.82 3.104 1.493 4.716 1.493 c0.499 0 0.734 -0.41 0.414 -0.828 c-0.486 -0.596 -1.156 -1.551 -1.416 -2.29 z M0 0 h24 v24 H0 z";
				case IconKind.BrandHtml5:
					return "M15.5 8 h-7 l0.5 4 h6 l-0.5 3.5 l-2.5 0.75 l-2.5 -0.75 l-0.1 -0.5 M20 4 l-2 14.5 l-6 2 l-6 -2 l-2 -14.5 z M0 0 h24 v24 H0 z";
				case IconKind.BrandInertia:
					return "M3.5 8 l4 4 l-4 4 h4.5 l4 -4 l-4 -4 z M12.5 8 l4 4 l-4 4 h4.5 l4 -4 l-4 -4 z M0 0 h24 v24 H0 z";
				case IconKind.BrandInstagram:
					return "M16.5 7.5 l0 0 M12 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M4 4 m0 4 a4 4 0 0 1 4 -4 h8 a4 4 0 0 1 4 4 v8 a4 4 0 0 1 -4 4 h-8 a4 4 0 0 1 -4 -4 z M0 0 h24 v24 H0 z";
				case IconKind.BrandIntercom:
					return "M7 15 c4 2.667 6 2.667 10 0 M17 8 v3 M14 7 v6 M10 7 v6 M7 8 v3 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BrandJavascript:
					return "M16.5 8 h-2.5 a0.5 0.5 0 0 0 -0.5 0.5 v3 a0.5 0.5 0 0 0 0.5 0.5 h1.423 a0.5 0.5 0 0 1 0.495 0.57 l-0.418 2.93 l-2 0.5 M7.5 8 h3 v8 l-2 -1 M20 4 l-2 14.5 l-6 2 l-6 -2 l-2 -14.5 z M0 0 h24 v24 H0 z";
				case IconKind.BrandKickstarter:
					return "M11 9 l2.975 -4.65 c0.615 -0.9 1.405 -1.35 2.377 -1.35 c0.79 0 1.474 0.286 2.054 0.858 c0.576 0.574 0.866 1.256 0.866 2.054 c0 0.588 -0.153 1.109 -0.46 1.559 l-2.812 4.029 l3.465 4.912 c0.356 0.46 0.535 1 0.535 1.613 a2.92 2.92 0 0 1 -0.843 2.098 c-0.561 0.584 -1.242 0.877 -2.04 0.877 c-0.876 0 -1.545 -0.29 -2 -0.87 l-4.112 -5.697 v3.067 c0 0.876 -0.313 1.69 -0.611 2.175 c-0.543 0.883 -1.35 1.325 -2.389 1.325 c-0.944 0 -1.753 -0.327 -2.271 -0.974 c-0.486 -0.6 -0.729 -1.392 -0.729 -2.38 v-11.371 c0 -0.934 0.247 -1.706 0.74 -2.313 c0.512 -0.641 1.347 -0.962 2.26 -0.962 c0.868 0 1.821 0.321 2.4 0.962 c0.323 0.356 0.515 0.714 0.6 1.08 c0.052 0.224 0 0.643 0 1.26 v2.698 z M0 0 h24 v24 H0 z";
				case IconKind.BrandKotlin:
					return "M12 12 l8 8 M4 12 l8 -8 M4 20 l16 -16 M20 20 h-16 v-16 h16 M0 0 h24 v24 H0 z";
				case IconKind.BrandLaravel:
					return "M18 10 l4 -2.5 M7 8 l4 -2.5 M11 13 v-7.5 l-4 -2.5 l-4 2.5 M14 11.5 l4 2.5 M14 7.5 v4 M7 15.5 l7 -4 M11 18 v4 M3 17 l8 5 l7 -4 v-8 l-4 -2.5 l4 -2.5 l4 2.5 v4 l-11 6.5 l-4 -2.5 v-7.5 l-4 -2.5 z M0 0 h24 v24 H0 z";
				case IconKind.BrandLastfm:
					return "M20 8 c-0.83 -1 -1.388 -1 -2 -1 c-0.612 0 -2 0.271 -2 2 s1.384 2.233 3 3 c1.616 0.767 2.125 1.812 2 3 s-1 2 -3 2 s-3 -1 -3.5 -2 s-1.585 -4.78 -2.497 -6 a5 5 0 1 0 -1 7 M0 0 h24 v24 H0 z";
				case IconKind.BrandLinkedin:
					return "M16 16 v-3 a2 2 0 0 0 -4 0 M12 16 l0 -5 M8 8 l0 0.01 M8 11 l0 5 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BrandLinktree:
					return "M15 3 l7 12 h-3 v5 h-5 v-5 h2 l-4 -7 z M9 3 l-7 12 h3 v5 h5 v-5 h-2 l4 -7 z M0 0 h24 v24 H0 z";
				case IconKind.BrandLinqpad:
					return "M5 21 h3.5 l2.5 -6 l2.5 -1 l2.5 7 h4 l1 -4.5 l-2 -1 l-7 -12 l-6 -0.5 l1.5 4 l2.5 0.5 l1 2.5 l-7 8 z M0 0 h24 v24 H0 z";
				case IconKind.BrandLoom:
					return "M6.518 6.54 a6 6 0 1 0 7.965 3.024 M6.54 17.482 a6 6 0 1 0 3.024 -7.965 M17.482 17.464 a6 6 0 1 0 -7.965 -3.023 M17.464 6.518 a6 6 0 1 0 -3.023 7.965 M0 0 h24 v24 H0 z";
				case IconKind.BrandMailgun:
					return "M12 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12 12 m-5 0 a5 5 0 1 0 10 0 a5 5 0 1 0 -10 0 M17 12 a2 2 0 1 0 4 0 a9 9 0 1 0 -2.987 6.697 M0 0 h24 v24 H0 z";
				case IconKind.BrandMantine:
					return "M10 12 h0.01 M14 15 h-2 M14 9 h-2 M11 16 c1.22 -0.912 2 -2.36 2 -4 a5.01 5.01 0 0 0 -2 -4 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandMastercard:
					return "M3 5 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M12 9.765 a3 3 0 1 0 0 4.47 M14 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandMastodon:
					return "M12 11.204 v-2.926 c0 -1.258 -0.895 -2.278 -2 -2.278 s-2 1.02 -2 2.278 v4.722 m4 -4.722 c0 -1.258 0.895 -2.278 2 -2.278 s2 1.02 2 2.278 v4.722 M18.648 15.254 c-1.816 1.763 -6.648 1.626 -6.648 1.626 a18.262 18.262 0 0 1 -3.288 -0.256 c1.127 1.985 4.12 2.81 8.982 2.475 c-1.945 2.013 -13.598 5.257 -13.668 -7.636 l-0.026 -1.154 c0 -3.036 0.023 -4.115 1.352 -5.633 c1.671 -1.91 6.648 -1.666 6.648 -1.666 s4.977 -0.243 6.648 1.667 c1.329 1.518 1.352 2.597 1.352 5.633 s-0.456 4.074 -1.352 4.944 z M0 0 h24 v24 H0 z";
				case IconKind.BrandMatrix:
					return "M17 15 v-3.5 a2.5 2.5 0 1 0 -5 0 v0.5 M12 15 v-3.5 a2.5 2.5 0 1 0 -5 0 v0.5 M7 9 v6 M20 21 h1 v-18 h-1 M4 3 h-1 v18 h1 M0 0 h24 v24 H0 z";
				case IconKind.BrandMcdonalds:
					return "M20 20 c0 -3.952 -0.966 -16 -4.038 -16 s-3.962 9.087 -3.962 14.756 c0 -5.669 -0.896 -14.756 -3.962 -14.756 c-3.065 0 -4.038 12.048 -4.038 16 M0 0 h24 v24 H0 z";
				case IconKind.BrandMedium:
					return "M15 9 l0 6 M9 9 l0 6 M14 15 l2 0 M8 15 l2 0 M8 9 h1 l3 3 l3 -3 h1 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BrandMercedes:
					return "M12 12 l-7 5 M12 12 l7 5 M12 3 v9 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandMessenger:
					return "M8 13 l3 -2 l2 2 l3 -2 M3 20 l1.3 -3.9 a9 8 0 1 1 3.4 2.9 l-4.7 1 M0 0 h24 v24 H0 z";
				case IconKind.BrandMeta:
					return "M12 10.174 c-1.766 -2.784 -3.315 -4.174 -4.648 -4.174 c-2 0 -3.263 2.213 -4 5.217 c-0.704 2.869 -0.5 6.783 2 6.783 c1.114 0 2.648 -1.565 4.148 -3.652 c1 -1.391 1.833 -2.783 2.5 -4.174 z M12 10.174 c1.766 -2.784 3.315 -4.174 4.648 -4.174 c2 0 3.263 2.213 4 5.217 c0.704 2.869 0.5 6.783 -2 6.783 c-1.114 0 -2.648 -1.565 -4.148 -3.652 a27.627 27.627 0 0 1 -2.5 -4.174 z M0 0 h24 v24 H0 z";
				case IconKind.BrandMiniprogram:
					return "M8 11.503 a2.5 2.5 0 1 0 4 2 v-3 a2.5 2.5 0 1 1 4 2 M21 12 a9 9 0 1 1 -18 0 a9 9 0 0 1 18 0 z M0 0 h24 v24 H0 z";
				case IconKind.BrandMixpanel:
					return "M13 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M20.5 12 m-1.5 0 a1.5 1.5 0 1 0 3 0 a1.5 1.5 0 1 0 -3 0 M4.5 12 m-2.5 0 a2.5 2.5 0 1 0 5 0 a2.5 2.5 0 1 0 -5 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandMonday:
					return "M16.5 7 a1.5 1.5 0 0 1 1.339 2.177 l-4.034 7.074 c-0.264 0.447 -0.75 0.749 -1.305 0.749 a1.5 1.5 0 0 1 -1.271 -2.297 l3.906 -6.827 a1.5 1.5 0 0 1 1.365 -0.876 z M9.5 7 a1.5 1.5 0 0 1 1.339 2.177 l-4.034 7.074 c-0.264 0.447 -0.75 0.749 -1.305 0.749 a1.5 1.5 0 0 1 -1.271 -2.297 l3.906 -6.827 a1.5 1.5 0 0 1 1.365 -0.876 z M19.5 15.5 m-1.5 0 a1.5 1.5 0 1 0 3 0 a1.5 1.5 0 1 0 -3 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandMongodb:
					return "M18 11.227 c0 3.273 -1.812 4.77 -6 9.273 c-4.188 -4.503 -6 -6 -6 -9.273 c0 -4.454 3.071 -6.927 6 -9.227 c2.929 2.3 6 4.773 6 9.227 z M12 3 v19 M0 0 h24 v24 H0 z";
				case IconKind.BrandMyOppo:
					return "M9 11 l3 3 l3 -3 M18.316 5 h-12.632 l-3.418 4.019 a1.089 1.089 0 0 0 0.019 1.447 l9.714 10.534 l9.715 -10.49 a1.09 1.09 0 0 0 0.024 -1.444 l-3.422 -4.066 z M0 0 h24 v24 H0 z";
				case IconKind.BrandMysql:
					return "M9 7 h0.01 M13 21 c-1.427 -1.026 -3.59 -3.854 -4 -6 c-0.486 0.77 -1.501 2 -2 2 c-1.499 -0.888 -0.574 -3.973 0 -6 c-1.596 -1.433 -2.468 -2.458 -2.5 -4 c-3.35 -3.44 -0.444 -5.27 2.5 -3 h1 c8.482 0.5 6.421 8.07 9 11.5 c2.295 0.522 3.665 2.254 5 3.5 c-2.086 -0.2 -2.784 -0.344 -3.5 0 c0.478 1.64 2.123 2.2 3.5 3 M0 0 h24 v24 H0 z";
				case IconKind.BrandNationalGeographic:
					return "M7 3 h10 v18 h-10 z M0 0 h24 v24 H0 z";
				case IconKind.BrandNem:
					return "M16.35 18.51 s2.65 -5.51 -4.35 -8.51 M2.1 7.07 c2.073 6.72 5.373 7.697 9.9 2.93 c0 -4 1.357 -6.353 4.07 -7.06 l0.59 -0.11 M12.182 2 c1.94 0.022 3.879 0.382 5.818 1.08 l0.364 0.135 a23.075 23.075 0 0 1 3.636 1.785 c0 5.618 -1.957 10.258 -5.87 13.92 c-1.24 1.239 -2.5 2.204 -3.78 2.898 l-0.35 0.182 c-1.4 -0.703 -2.777 -1.729 -4.13 -3.079 c-3.912 -3.663 -5.87 -8.303 -5.87 -13.921 c2.545 -1.527 5.09 -2.471 7.636 -2.832 l0.364 -0.048 a16.786 16.786 0 0 1 1.818 -0.12 h0.364 z M0 0 h24 v24 H0 z";
				case IconKind.BrandNetbeans:
					return "M8 14 l-3.5 2 M19.5 16 l-3.5 -2 M12 3 v4.5 M12 12 l7.5 -4.5 M12 21 v-9 l-7.5 -4.5 M15.5 9.43 a1 1 0 0 1 0.5 0.874 v3.268 a1 1 0 0 1 -0.515 0.874 l-3 1.917 a1 1 0 0 1 -0.97 0 l-3 -1.917 a1 1 0 0 1 -0.515 -0.873 v-3.269 a1 1 0 0 1 0.514 -0.874 l3 -1.786 c0.311 -0.173 0.69 -0.173 1 0 l3 1.787 h-0.014 z M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.BrandNeteaseMusic:
					return "M9 4 c-2.93 1.346 -5 5.046 -5 8.492 c0 4.508 4 7.508 8 7.508 s8 -3 8 -7 c0 -3.513 -3.5 -5.513 -6 -5.513 s-5 1.513 -5 4.513 c0 2 1.5 3 3 3 s3 -1 3 -3 c0 -3.513 -2 -4.508 -2 -6.515 c0 -3.504 3.5 -2.603 4 -1.502 M0 0 h24 v24 H0 z";
				case IconKind.BrandNetflix:
					return "M19 21 v-18 h-4 v10.5 M5 3 v18 h4 v-10.5 M9 3 l10 18 h-4 l-10 -18 z M0 0 h24 v24 H0 z";
				case IconKind.BrandNexo:
					return "M12 6 l-5 -3 l-5 3 v12 l5 3 l4.7 -3.13 M17 3 l5 3 v12 l-5 3 l-10 -6 v-6 l10 6 v-6 l-5 -3 z M0 0 h24 v24 H0 z";
				case IconKind.BrandNextcloud:
					return "M19.5 12.5 m-2.5 0 a2.5 2.5 0 1 0 5 0 a2.5 2.5 0 1 0 -5 0 M4.5 12.5 m-2.5 0 a2.5 2.5 0 1 0 5 0 a2.5 2.5 0 1 0 -5 0 M12 12 m-5 0 a5 5 0 1 0 10 0 a5 5 0 1 0 -10 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandNextjs:
					return "M15 12 v-3 M9 15 v-6 l7.745 10.65 a9 9 0 1 1 2.255 -1.993 M0 0 h24 v24 H0 z";
				case IconKind.BrandNordVpn:
					return "M14.5 15 l-3 -6 l-2.5 4.5 M9.992 15 l-2.007 -3 l-4.015 8 c-2.212 -3.061 -2.625 -7.098 -0.915 -10.463 a10.14 10.14 0 0 1 8.945 -5.537 a10.14 10.14 0 0 1 8.945 5.537 c1.71 3.365 1.297 7.402 -0.915 10.463 l-4.517 -8 l-1.505 1.5 M0 0 h24 v24 H0 z";
				case IconKind.BrandNotion:
					return "M16 7 v10 h-1 l-7 -7 M15 7 h2 M7 17 h2 M8 7 v10 M7 7 h3 l6 6 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BrandNpm:
					return "M20 11 v4 M11 11 v1 M4 11 v4 M17 11 v4 M14 8 v7 M7 8 v7 M1 8 h22 v7 h-12 v2 h-4 v-2 h-6 z M0 0 h24 v24 H0 z";
				case IconKind.BrandNuxt:
					return "M20.043 18 c0.743 0 1.201 -0.843 0.82 -1.505 l-4.044 -7.013 a0.936 0.936 0 0 0 -1.638 0 l-4.043 7.013 c-0.382 0.662 0.076 1.505 0.819 1.505 h8.086 z M12.146 8.583 l-1.3 -2.09 a1.046 1.046 0 0 0 -1.786 0.017 l-5.91 9.908 a1.046 1.046 0 0 0 0.897 1.582 h3.913 M0 0 h24 v24 H0 z";
				case IconKind.BrandNytimes:
					return "M16 13 h-0.01 M9 12 v8 M17.5 3 a2.5 2.5 0 1 1 0 5 l-11 -5 a2.5 2.5 0 0 0 -0.67 4.91 M12 21 v-11 l-7.5 4 M11.036 5.058 a8 8 0 1 0 8.706 9.965 M0 0 h24 v24 H0 z";
				case IconKind.BrandOffice:
					return "M4 18 h9 v-12 l-5 2 v5 l-4 2 v-8 l9 -4 l7 2 v13 l-7 3 z M0 0 h24 v24 H0 z";
				case IconKind.BrandOkRu:
					return "M12 13.5 v0.5 M9.5 17 l2.5 -3 l2.5 3 M9.5 13 c1.333 0.667 3.667 0.667 5 0 M20 12 c0 8 0 8 -8 8 s-8 0 -8 -8 s0 -8 8 -8 s8 0 8 8 z M12 9 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandOnedrive:
					return "M18.456 10.45 a6.45 6.45 0 0 0 -12 -2.151 a4.857 4.857 0 0 0 -4.44 5.241 a4.856 4.856 0 0 0 5.236 4.444 h10.751 a3.771 3.771 0 0 0 3.99 -3.54 a3.772 3.772 0 0 0 -3.538 -3.992 z M0 0 h24 v24 H0 z";
				case IconKind.BrandOnlyfans:
					return "M14 16 c2.5 0 6.42 -1.467 7 -4 h-6 c3 -1 6.44 -3.533 7 -6 h-4 c-3.03 0 -3.764 -0.196 -5 1.5 M8.5 15 a2.5 2.5 0 1 1 0 -5 a2.5 2.5 0 0 1 0 5 z M8.5 6 a6.5 6.5 0 1 0 0 13 a6.5 6.5 0 0 0 0 -13 z M0 0 h24 v24 H0 z";
				case IconKind.BrandOpenSource:
					return "M12 3 a9 9 0 0 1 3.618 17.243 l-2.193 -5.602 a3 3 0 1 0 -2.849 0 l-2.193 5.603 a9 9 0 0 1 3.617 -17.244 z M0 0 h24 v24 H0 z";
				case IconKind.BrandOpenvpn:
					return "M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M15.618 20.243 l-2.193 -5.602 a3 3 0 1 0 -2.849 0 l-2.193 5.603 M0 0 h24 v24 H0 z";
				case IconKind.BrandOpera:
					return "M12 12 m-3 0 a3 5 0 1 0 6 0 a3 5 0 1 0 -6 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandPagekit:
					return "M12.077 20 h-5.077 v-16 h11 v14 h-5.077 M0 0 h24 v24 H0 z";
				case IconKind.BrandPatreon:
					return "M15 9.5 m-6.5 0 a6.5 6.5 0 1 0 13 0 a6.5 6.5 0 1 0 -13 0 M3 3 h3 v18 h-3 z M0 0 h24 v24 H0 z";
				case IconKind.BrandPaypal:
					return "M10 13 l2.5 0 c2.5 0 5 -2.5 5 -5 c0 -3 -1.9 -5 -5 -5 h-5.5 c-0.5 0 -1 0.5 -1 1 l-2 14 c0 0.5 0.5 1 1 1 h2.8 l1.2 -5 c0.1 -0.6 0.4 -1 1 -1 z m7.5 -5.8 c1.7 1 2.5 2.8 2.5 4.8 c0 2.5 -2.5 4.5 -5 4.5 h-2.6 l-0.6 3.6 a1 1 0 0 1 -1 0.8 l-2.7 0 a0.5 0.5 0 0 1 -0.5 -0.6 l0.2 -1.4 M0 0 h24 v24 H0 z";
				case IconKind.BrandPaypay:
					return "M21 19 v-14 a2 2 0 0 0 -2 -2 h-14 a2 2 0 0 0 -2 2 v14 a2 2 0 0 0 2 2 h14 a2 2 0 0 0 2 -2 z M3 6 c16.731 0 21.231 9.881 4.5 11 M6.375 21 l3.938 -13.838 M0 0 h24 v24 H0 z";
				case IconKind.BrandPeanut:
					return "M15 16.25 l-0.816 -0.36 l-0.462 -0.196 c-1.444 -0.592 -2 -0.593 -3.447 0 l-0.462 0.195 l-0.817 0.359 a4.5 4.5 0 1 1 0 -8.49 v0 l1.054 0.462 l0.434 0.178 c1.292 0.507 1.863 0.48 3.237 -0.082 l0.462 -0.195 l0.817 -0.359 a4.5 4.5 0 1 1 0 8.49 M0 0 h24 v24 H0 z";
				case IconKind.BrandPepsi:
					return "M5 17.5 c5.118 -2.859 15 0 14 -11 M4 16 c5.713 -2.973 11 -3.5 13.449 -11.162 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandPhp:
					return "M11.6 10 h2.4 l-0.5 3 M12 7.5 l-1 5.5 M15.5 15 l0.395 -1.974 l0.605 -3.026 h1.32 a1 1 0 0 1 0.986 1.164 l-0.167 1 a1 1 0 0 1 -0.986 0.836 h-1.653 M5.5 15 l0.395 -1.974 l0.605 -3.026 h1.32 a1 1 0 0 1 0.986 1.164 l-0.167 1 a1 1 0 0 1 -0.986 0.836 h-1.653 M12 12 m-10 0 a10 9 0 1 0 20 0 a10 9 0 1 0 -20 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandPicsart:
					return "M5 9 v11 a2 2 0 1 0 4 0 v-4.5 M12 9 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M12 9 m-7 0 a7 7 0 1 0 14 0 a7 7 0 1 0 -14 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandPinterest:
					return "M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M10.7 14 c0.437 1.263 1.43 2 2.55 2 c2.071 0 3.75 -1.554 3.75 -4 a5 5 0 1 0 -9.7 1.7 M8 20 l4 -9 M0 0 h24 v24 H0 z";
				case IconKind.BrandPocket:
					return "M8 11 l4 4 l4 -4 M5 4 h14 a2 2 0 0 1 2 2 v6 a9 9 0 0 1 -18 0 v-6 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.BrandPolymer:
					return "M6.706 6 l-3.706 6 l3.706 6 h1.059 l8.47 -12 h1.06 l3.705 6 l-3.706 6 M0 0 h24 v24 H0 z";
				case IconKind.BrandPowershell:
					return "M12 16 h3 M9 8 l4 4 l-6 4 M4.887 20 h11.868 c0.893 0 1.664 -0.665 1.847 -1.592 l2.358 -12 c0.212 -1.081 -0.442 -2.14 -1.462 -2.366 a1.784 1.784 0 0 0 -0.385 -0.042 h-11.868 c-0.893 0 -1.664 0.665 -1.847 1.592 l-2.358 12 c-0.212 1.081 0.442 2.14 1.462 2.366 c0.127 0.028 0.256 0.042 0.385 0.042 z M0 0 h24 v24 H0 z";
				case IconKind.BrandPrisma:
					return "M8.5 22 l3.5 -20 M4.186 16.202 l3.615 5.313 c0.265 0.39 0.754 0.57 1.215 0.447 l10.166 -2.718 a1.086 1.086 0 0 0 0.713 -1.511 l-7.505 -15.483 a0.448 0.448 0 0 0 -0.787 -0.033 l-7.453 12.838 a1.07 1.07 0 0 0 0.037 1.147 z M0 0 h24 v24 H0 z";
				case IconKind.BrandProducthunt:
					return "M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M10 16 v-8 h2.5 a2.5 2.5 0 1 1 0 5 h-2.5 M0 0 h24 v24 H0 z";
				case IconKind.BrandPushbullet:
					return "M8 8 v8 M11 8 v8 h2 a4 4 0 1 0 0 -8 h-2 z M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandPushover:
					return "M12.5 6 l-5.5 15 M6.16 10.985 c-0.83 -1.935 1.53 -7.985 8.195 -7.985 c3.333 0 4.645 1.382 4.645 3.9 c0 2.597 -2.612 6.1 -9 6.1 M0 0 h24 v24 H0 z";
				case IconKind.BrandPython:
					return "M13 18 l0 0.01 M11 6 l0 0.01 M8 9 v-4 a2 2 0 0 1 2 -2 h4 a2 2 0 0 1 2 2 v5 a2 2 0 0 1 -2 2 h-4 a2 2 0 0 0 -2 2 v5 a2 2 0 0 0 2 2 h4 a2 2 0 0 0 2 -2 v-4 M12 15 h7 a2 2 0 0 0 2 -2 v-4 a2 2 0 0 0 -2 -2 h-3 M12 9 h-7 a2 2 0 0 0 -2 2 v4 a2 2 0 0 0 2 2 h3 M0 0 h24 v24 H0 z";
				case IconKind.BrandQq:
					return "M16 21 c1.5 0 3.065 -1 1 -3 c4.442 2 1.987 -4.5 1 -7 c0 -4 -1.558 -8 -6 -8 s-6 4 -6 8 c-0.987 2.5 -3.442 9 1 7 c-2.065 2 -0.5 3 1 3 h8 z M10.5 10 c0.667 1.333 2.333 1.333 3 0 h-3 z M9 13.5 v2.5 M6 11 c4 4 8 4 12 0 M10 7 h0.01 M14 7 h0.01 M0 0 h24 v24 H0 z";
				case IconKind.BrandReactNative:
					return "M12.26 12.015 h-0.01 c-0.01 0.13 -0.12 0.24 -0.26 0.24 a0.263 0.263 0 0 1 -0.25 -0.26 c0 -0.14 0.11 -0.25 0.24 -0.25 h-0.01 c0.13 -0.01 0.25 0.11 0.25 0.24 M8 12 c0.285 -0.66 0.607 -1.308 0.968 -1.978 c2.647 -4.844 6.253 -7.89 8.046 -6.801 c1.11 0.679 1.262 2.706 0.56 5.393 M17.66 15 c2.612 -0.687 4.34 -1.85 4.34 -3.176 c0 -2.11 -4.408 -3.824 -9.845 -3.824 c-0.747 0 -1.266 0.029 -1.955 0.087 M12 18.52 c1.928 2 3.817 2.95 4.978 2.253 c1.85 -1.102 1.121 -5.972 -1.633 -10.873 c-0.384 -0.677 -0.777 -1.204 -1.18 -1.8 M6.429 15.387 c-0.702 2.688 -0.56 4.716 0.56 5.395 c1.783 1.08 5.387 -1.958 8.043 -6.804 c0.36 -0.67 0.683 -1.329 0.968 -1.978 M9.837 15.9 c-0.413 -0.596 -0.806 -1.133 -1.18 -1.8 c-2.751 -4.9 -3.488 -9.77 -1.63 -10.873 c1.15 -0.697 3.047 0.253 4.974 2.254 M6.357 9 c-2.637 0.68 -4.357 1.845 -4.357 3.175 c0 2.107 4.405 3.825 9.85 3.825 c0.74 0 1.26 -0.039 1.95 -0.097 M0 0 h24 v24 H0 z";
				case IconKind.BrandReact:
					return "M11.5 12.866 a1 1 0 1 0 1 -1.732 a1 1 0 0 0 -1 1.732 z M12 18.574 c1.926 1.893 3.821 2.768 5 2.086 c1.913 -1.104 1.226 -5.877 -1.536 -10.66 c-0.375 -0.65 -0.78 -1.283 -1.212 -1.897 M12 5.424 c-1.925 -1.892 -3.82 -2.766 -5 -2.084 c-1.913 1.104 -1.226 5.877 1.536 10.66 c0.386 0.67 0.793 1.304 1.212 1.896 M17.694 8.716 c0.677 -2.616 0.487 -4.696 -0.694 -5.376 c-1.913 -1.105 -5.703 1.877 -8.464 6.66 c-0.387 0.67 -0.733 1.34 -1.037 2 M6.305 15.287 c-0.676 2.615 -0.485 4.693 0.695 5.373 c1.913 1.105 5.703 -1.877 8.464 -6.66 c0.387 -0.67 0.733 -1.339 1.036 -2 M17.692 15.289 c2.603 -0.722 4.308 -1.926 4.308 -3.289 c0 -2.21 -4.477 -4 -10 -4 c-0.773 0 -1.526 0.035 -2.25 0.102 M6.306 8.711 c-2.602 0.723 -4.306 1.926 -4.306 3.289 c0 2.21 4.477 4 10 4 c0.773 0 1.526 -0.035 2.248 -0.102 M0 0 h24 v24 H0 z";
				case IconKind.BrandReason:
					return "M12 18 l-2 -3 M8 18 v-6 h2.5 a1.5 1.5 0 0 1 0 3 h-2.5 M18 15 h-3 M18 18 h-3 v-6 h3 M3 3 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v14 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BrandReddit:
					return "M10 17 c0.667 0.333 1.333 0.5 2 0.5 s1.333 -0.167 2 -0.5 M14.5,13a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M8.5,13a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M19 4 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12 8 l1 -5 l6 1 M12 8 c2.648 0 5.028 0.826 6.675 2.14 a2.5 2.5 0 0 1 2.326 4.36 c0 3.59 -4.03 6.5 -9 6.5 c-4.875 0 -8.845 -2.8 -9 -6.294 l-1 -0.206 a2.5 2.5 0 0 1 2.326 -4.36 c1.646 -1.313 4.026 -2.14 6.674 -2.14 z M0 0 h24 v24 H0 z";
				case IconKind.BrandRedhat:
					return "M6 10.5 c0 0.969 4.39 3.5 9.5 3.5 c1.314 0 3 0.063 3 -1.5 M6 10.5 l1.436 -4 c0.318 -0.876 0.728 -1.302 1.359 -1.302 c0.219 0 1.054 0.365 1.88 0.583 c0.825 0.219 0.733 -0.329 0.908 -0.487 c0.176 -0.158 0.355 -0.294 0.61 -0.294 c0.242 0 0.553 0.048 1.692 0.448 c0.759 0.267 1.493 0.574 2.204 0.922 c1.175 0.582 1.426 0.913 1.595 1.507 l0.816 4.623 c2.086 0.898 3.5 2.357 3.5 3.682 c0 1.685 -1.2 3.818 -5.957 3.818 c-6.206 0 -14.043 -4.042 -14.043 -7.32 c0 -1.044 1.333 -1.77 4 -2.18 z M0 0 h24 v24 H0 z";
				case IconKind.BrandRedux:
					return "M15.5 14 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M9.5 15.5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M10.493 9.862 c0.48 0.276 1.095 0.112 1.372 -0.366 a1 1 0 0 0 -0.367 -1.365 a1.007 1.007 0 0 0 -1.373 0.366 a1 1 0 0 0 0.368 1.365 z M15.014 19.99 c2.511 0 4.523 -0.438 5.487 -2.1 c1.387 -2.39 -0.215 -5.893 -3.579 -7.824 c-1.702 -0.979 -4.357 -1.235 -5.927 -1.07 M4.711 11.979 c-1.656 1.877 -2.214 4.185 -1.211 5.911 c1.387 2.39 5.138 2.831 8.501 0.9 c1.703 -0.979 2.875 -3.362 3.516 -4.798 M16.54 7 c-0.805 -2.365 -2.536 -4 -4.54 -4 c-2.774 0 -5.023 2.632 -5.023 6.496 c0 1.956 1.582 4.727 2.512 6 M0 0 h24 v24 H0 z";
				case IconKind.BrandRevolut:
					return "M15.5 13.5 l1.791 4.558 c0.535 1.352 1.13 2.008 1.709 2.442 c-1 0.5 -2.616 0.522 -3.605 0.497 c-0.973 0 -2.28 -0.24 -3.106 -2.6 l-1.289 -3.397 h-1.5 s-0.465 2.243 -0.65 3.202 c-0.092 0.704 0.059 1.594 0.15 2.298 c-1 0.5 -2.5 0.5 -3.5 0.5 c-0.727 0 -1.45 -0.248 -1.5 -1.5 l0 -0.311 a7 7 0 0 1 0.149 -1.409 c0.75 -3.577 1.366 -7.17 1.847 -10.78 c0.23 -1.722 0 -3.5 0 -3.5 c0.585 -0.144 2.709 -0.602 6.787 -0.471 a10.26 10.26 0 0 1 3.641 0.722 c0.308 0.148 0.601 0.326 0.875 0.531 c0.254 0.212 0.497 0.437 0.727 0.674 c0.3 0.382 0.545 0.804 0.727 1.253 c0.155 0.483 0.237 0.987 0.243 1.493 c0 2.462 -1.412 4.676 -3.5 5.798 z M10.908 6 c-0.091 0.363 -0.908 5 -0.908 5 h1.228 c1.59 0 2.772 -1.168 2.772 -2.943 c0 -1.249 -0.818 -2.057 -2.087 -2.057 h-1 z M0 0 h24 v24 H0 z";
				case IconKind.BrandSafari:
					return "M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M8 16 l2 -6 l6 -2 l-2 6 l-6 2 M0 0 h24 v24 H0 z";
				case IconKind.BrandSamsungpass:
					return "M10.485 17.577 c0.337 0.29 0.7 0.423 1.515 0.423 h0.413 c0.323 0 0.633 -0.133 0.862 -0.368 a1.27 1.27 0 0 0 0.356 -0.886 c0 -0.332 -0.128 -0.65 -0.356 -0.886 a1.203 1.203 0 0 0 -0.862 -0.368 h-0.826 a1.2 1.2 0 0 1 -0.861 -0.367 a1.27 1.27 0 0 1 -0.356 -0.886 c0 -0.332 0.128 -0.651 0.356 -0.886 a1.2 1.2 0 0 1 0.861 -0.368 h0.413 c0.816 0 1.178 0.133 1.515 0.423 M7 10 v-1.862 c0 -2.838 2.239 -5.138 5 -5.138 s5 2.3 5 5.138 v1.862 M4 10 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v7 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BrandSass:
					return "M12 10.523 c2.46 -0.826 4 -0.826 4 -2.155 c0 -1.366 -1.347 -1.366 -2.735 -1.366 c-1.91 0 -3.352 0.49 -4.537 1.748 c-0.848 0.902 -1.027 2.449 -0.153 3.307 c0.973 0.956 3.206 1.789 2.884 3.493 c-0.233 1.235 -1.469 1.823 -2.617 1.202 c-0.782 -0.424 -0.454 -1.746 0.626 -2.512 s2.822 -0.992 4.1 -0.24 c0.98 0.575 1.046 1.724 0.434 2.193 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandSentry:
					return "M3 18 a1.93 1.93 0 0 0 0.306 1.076 a2 2 0 0 0 1.584 0.924 c0.646 0.033 -0.537 0 0.11 0 h3 a4.992 4.992 0 0 0 -3.66 -4.81 c0.558 -0.973 1.24 -2.149 2.04 -3.531 a9 9 0 0 1 5.62 8.341 h4 c0.663 0 2.337 0 3 0 a2 2 0 0 0 1.84 -2.75 l-7.1 -12.25 a2 2 0 0 0 -3.5 0 l-1.84 3.176 c4.482 2.05 7.6 6.571 7.6 11.824 M0 0 h24 v24 H0 z";
				case IconKind.BrandSharik:
					return "M4.281 16.606 a8.968 8.968 0 0 1 1.363 -10.977 a9.033 9.033 0 0 1 11.011 -1.346 c-1.584 4.692 -2.415 6.96 -4.655 8.717 c-1.584 1.242 -3.836 2.24 -7.719 3.606 z m16.335 -7.306 c2.113 7.59 -4.892 13.361 -11.302 11.264 c1.931 -3.1 3.235 -4.606 4.686 -6.065 c1.705 -1.715 3.591 -3.23 6.616 -5.199 z M0 0 h24 v24 H0 z";
				case IconKind.BrandShazam:
					return "M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M14 12 l-2 2 a2.828 2.828 0 1 1 -4 -4 l3 -3 M10 12 l2 -2 a2.828 2.828 0 0 1 4 0 a2.828 2.828 0 0 1 0 4 l-3 3 M0 0 h24 v24 H0 z";
				case IconKind.BrandShopee:
					return "M9.5 17 c0.413 0.462 1 1 2.5 1 s2.5 -0.897 2.5 -2 s-1 -1.5 -2.5 -2 s-2 -1.47 -2 -2 c0 -1.104 1 -2 2 -2 s1.5 0 2.5 1 M8.5 7 c0 -1.653 1.5 -4 3.5 -4 s3.5 2.347 3.5 4 M4 7 l0.867 12.143 a2 2 0 0 0 2 1.857 h10.276 a2 2 0 0 0 2 -1.857 l0.867 -12.143 h-16 z M0 0 h24 v24 H0 z";
				case IconKind.BrandSketch:
					return "M3.262 10.878 l8 8.789 c0.4 0.44 1.091 0.44 1.491 0 l8 -8.79 c0.313 -0.344 0.349 -0.859 0.087 -1.243 l-3.537 -5.194 a1 1 0 0 0 -0.823 -0.436 h-8.926 a1 1 0 0 0 -0.823 0.436 l-3.54 5.192 c-0.263 0.385 -0.227 0.901 0.087 1.246 z M0 0 h24 v24 H0 z";
				case IconKind.BrandSkype:
					return "M8 14.5 c0.5 2 2.358 2.5 4 2.5 c2.905 0 4 -1.187 4 -2.5 c0 -1.503 -1.927 -2.5 -4 -2.5 s-4 -1 -4 -2.5 c0 -1.313 1.095 -2.5 4 -2.5 c1.642 0 3.5 0.5 4 2.5 M12 3 a9 9 0 0 1 8.603 11.65 a4.5 4.5 0 0 1 -5.953 5.953 a9 9 0 0 1 -11.253 -11.253 a4.5 4.5 0 0 1 5.953 -5.954 a8.987 8.987 0 0 1 2.65 -0.396 z M0 0 h24 v24 H0 z";
				case IconKind.BrandSlack:
					return "M12 12 h-6 a2 2 0 0 1 0 -4 h6 m-2 0 a2 2 0 1 1 2 -2 v6 M12 12 v6 a2 2 0 0 1 -4 0 v-6 m0 2 a2 2 0 1 1 -2 -2 h6 M12 12 h6 a2 2 0 0 1 0 4 h-6 m2 0 a2 2 0 1 1 -2 2 v-6 M12 12 v-6 a2 2 0 0 1 4 0 v6 m0 -2 a2 2 0 1 1 2 2 h-6 M0 0 h24 v24 H0 z";
				case IconKind.BrandSnapchat:
					return "M16.882 7.842 a4.882 4.882 0 0 0 -9.764 0 c0 4.273 -0.213 6.409 -4.118 8.118 c2 0.882 2 0.882 3 3 c3 0 4 2 6 2 s3 -2 6 -2 c1 -2.118 1 -2.118 3 -3 c-3.906 -1.709 -4.118 -3.845 -4.118 -8.118 z m-13.882 8.119 c4 -2.118 4 -4.118 1 -7.118 m17 7.118 c-4 -2.118 -4 -4.118 -1 -7.118 M0 0 h24 v24 H0 z";
				case IconKind.BrandSnapseed:
					return "M8 20 l12.09 -0.011 c0.503 0 0.91 -0.434 0.91 -0.969 v-6.063 c0 -0.535 -0.407 -0.968 -0.91 -0.968 h-7.382 M8.152 3.115 a0.46 0.46 0 0 0 -0.609 0 c-2.943 2.58 -4.529 5.441 -4.543 8.378 c0 2.928 1.586 5.803 4.543 8.392 a0.46 0.46 0 0 0 0.61 0 c2.957 -2.589 4.547 -5.464 4.547 -8.392 c0 -2.928 -1.6 -5.799 -4.548 -8.378 z M0 0 h24 v24 H0 z";
				case IconKind.BrandSnowflake:
					return "M12 11 l1 1 l-1 1 l-1 -1 z M14 3 v5.5 l4.5 -2.5 M10 3 v5.5 l-4.5 -2.5 M20.5 9.5 l-4.5 2.5 l4.5 2.5 M3.5 14.5 l4.5 -2.5 l-4.5 -2.5 M10 21 v-5.5 l-4.5 2.5 M14 21 v-5.5 l4.5 2.5 M0 0 h24 v24 H0 z";
				case IconKind.BrandSocketIo:
					return "M12 13 h1 l-4 4 z M11 11 h1 l3 -4 z M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandSolidjs:
					return "M7.416 12.662 c-1.51 -0.476 -2.416 -1.479 -2.416 -3.162 c0 -2.5 1.5 -3.5 4 -3.5 c1.688 0 5.087 1.068 8.198 3.204 a114.76 114.76 0 0 1 1.802 1.296 l-2.302 0.785 M8.581 3.545 l-2.953 3.711 M22 6.5 l-3 4 M2 17.5 l3 -4 M22 6.5 c-4 -3 -8 -4.5 -10 -4.5 c-2.04 0 -2.618 0.463 -3.419 1.545 M5 13.5 c4.667 -1.667 8 -2.5 10 -2.5 c2.5 0 4 1.5 4 3.5 c0 0.738 -0.204 1.408 -0.588 1.96 l-2.883 3.825 M2 17.5 c4.667 3 8 4.5 10 4.5 c2.5 0 4 -1.5 4 -3.5 s-1.5 -3.5 -4 -3.5 c-2 0 -5.333 0.833 -10 2.5 z M0 0 h24 v24 H0 z";
				case IconKind.BrandSoundcloud:
					return "M3 16 l0 -2 M6 17 l0 -7 M9 8 l0 9 M17 11 h1 c1.38 0 3 1.274 3 3 c0 1.657 -1.5 3 -3 3 l-6 0 v-10 c3 0 4.5 1.5 5 4 z M0 0 h24 v24 H0 z";
				case IconKind.BrandSpacehey:
					return "M11 8 v2.5 a3.5 3.5 0 0 1 -3.5 3.5 h-0.5 a3 3 0 0 1 0 -6 h4 z M14 20 h6 v-6 a3 3 0 0 0 -6 0 v6 z M17 6 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandSpotify:
					return "M7 9 c2 -1 6 -2 10 0.5 M9 15 c1.5 -1 4 -1 5 0.5 M8 11.973 c2.5 -1.473 5.5 -0.973 7.5 0.527 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandStackoverflow:
					return "M10.096 5.764 l7.608 2.472 M8.787 9.168 l7.826 1.664 M8.322 12.582 l7.956 0.836 M8 16 h8 M4 17 v1 a2 2 0 0 0 2 2 h12 a2 2 0 0 0 2 -2 v-1 M0 0 h24 v24 H0 z";
				case IconKind.BrandStackshare:
					return "M17 6 h-3.5 l-3.5 6 M7 12 h3 l3.5 6 h3.5 M5 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M19 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M19 6 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandSteam:
					return "M15.5,9.5a1,1 0 1,0 2,0a1,1 0 1,0 -2,0 M16.5 5 a4.5 4.5 0 1 1 -0.653 8.953 l-4.347 3.009 l0 0.038 a3 3 0 0 1 -2.824 3 l-0.176 0 a3 3 0 0 1 -2.94 -2.402 l-2.56 -1.098 v-3.5 l3.51 1.755 a2.989 2.989 0 0 1 2.834 -0.635 l2.727 -3.818 a4.5 4.5 0 0 1 4.429 -5.302 z M0 0 h24 v24 H0 z";
				case IconKind.BrandStorybook:
					return "M16 3.5 v1 M9 15 c0.6 1.5 1.639 2 3.283 2 h-0.283 c1.8 0 3 -0.974 3 -2.435 c0 -1.194 -0.831 -1.799 -2.147 -2.333 l-1.975 -0.802 c-1.15 -0.467 -1.878 -1.422 -1.878 -2.467 c0 -0.97 0.899 -1.786 2.087 -1.893 l0.613 -0.055 c1.528 -0.138 3 0.762 3.3 1.985 M5 4 l0.5 16.5 l13.5 0.5 v-18 z M0 0 h24 v24 H0 z";
				case IconKind.BrandStorytel:
					return "M4.103 22 c2.292 -2.933 16.825 -2.43 16.825 -11.538 c0 -6.298 -4.974 -8.462 -8.451 -8.462 c-3.477 0 -9.477 3.036 -9.477 11.241 c0 6.374 1.103 8.759 1.103 8.759 z M0 0 h24 v24 H0 z";
				case IconKind.BrandStrava:
					return "M15 13 l-5 -10 l-5 10 m6 0 l4 8 l4 -8 M0 0 h24 v24 H0 z";
				case IconKind.BrandStripe:
					return "M11.453 8.056 c0 -0.623 0.518 -0.979 1.442 -0.979 c1.69 0 3.41 0.343 4.605 0.923 l0.5 -4 c-0.948 -0.449 -2.82 -1 -5.5 -1 c-1.895 0 -3.373 0.087 -4.5 1 c-1.172 0.956 -2 2.33 -2 4 c0 3.03 1.958 4.906 5 6 c1.961 0.69 3 0.743 3 1.5 c0 0.735 -0.851 1.5 -2 1.5 c-1.423 0 -3.963 -0.609 -5.5 -1.5 l-0.5 4 c1.321 0.734 3.474 1.5 6 1.5 c2 0 3.957 -0.468 5.084 -1.36 c1.263 -0.979 1.916 -2.268 1.916 -4.14 c0 -3.096 -1.915 -4.547 -5 -5.637 c-1.646 -0.605 -2.544 -1.07 -2.544 -1.807 z M0 0 h24 v24 H0 z";
				case IconKind.BrandSublimeText:
					return "M5 12.5 l14 4.5 M19 11.5 l-14 -4.5 M19 17 l-14 4.5 v-5.5 l14 -4.5 z M19 8 l-14 4.5 v-5.5 l14 -4.5 z M0 0 h24 v24 H0 z";
				case IconKind.BrandSupabase:
					return "M4 14 h8 v7 l8 -11 h-8 v-7 z M0 0 h24 v24 H0 z";
				case IconKind.BrandSuperhuman:
					return "M12 15 h8 M12 3 l-8 6 l8 6 l8 -6 z M16 12 l4 3 l-8 7 l-8 -7 l4 -3 M0 0 h24 v24 H0 z";
				case IconKind.BrandSupernova:
					return "M9 15 v0.5 c0 3.038 1.343 5.5 3 5.5 s3 -2.462 3 -5.5 c0 -1.842 -0.494 -3.472 -1.252 -4.47 M15 9 v-0.5 c0 -3.038 -1.343 -5.5 -3 -5.5 s-3 2.462 -3 5.5 c0 1.833 0.49 3.457 1.241 4.456 M9 9 h-0.5 c-3.038 0 -5.5 1.343 -5.5 3 s2.462 3 5.5 3 c1.844 0 3.476 -0.495 4.474 -1.255 M15 15 h0.5 c3.038 0 5.5 -1.343 5.5 -3 s-2.462 -3 -5.5 -3 c-1.836 0 -3.462 0.49 -4.46 1.245 M12 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandSurfshark:
					return "M8 16 h0.452 c1.943 0.007 3.526 -1.461 3.543 -3.286 v-2.428 c0.018 -1.828 1.607 -3.298 3.553 -3.286 h0.452 M19.954 9.447 c-0.237 -6.217 0 -6.217 -6 -6.425 c-5.774 -0.208 -6.824 1 -7.91 5.382 c-2.884 11.816 -3.845 14.716 4.792 11.198 c9.392 -3.831 9.297 -5.382 9.114 -10.155 z M0 0 h24 v24 H0 z";
				case IconKind.BrandSvelte:
					return "M8 17 l5 -3 l-0.822 0.496 c-1.86 1.151 -4.411 0.491 -5.574 -1.351 a3.91 3.91 0 0 1 1.264 -5.42 l5.054 -3.127 c1.86 -1.15 4.311 -0.59 5.474 1.252 a3.91 3.91 0 0 1 -1.264 5.42 l-0.26 0.16 M15 8 l-5 3 l0.821 -0.495 c1.86 -1.15 4.412 -0.49 5.574 1.352 a3.91 3.91 0 0 1 -1.264 5.42 l-5.053 3.126 c-1.86 1.151 -4.312 0.591 -5.474 -1.251 a3.91 3.91 0 0 1 1.263 -5.42 l0.26 -0.16 M0 0 h24 v24 H0 z";
				case IconKind.BrandSymfony:
					return "M22 12 c0 5.523 -4.477 10 -10 10 s-10 -4.477 -10 -10 s4.477 -10 10 -10 a10 10 0 0 1 10 10 z M9 17 c-0.095 0.667 0.238 1 1 1 c1.714 0 2.714 -2 3 -6 c0.286 -4 1.571 -6 3 -6 c0.571 0 0.905 0.333 1 1 M6 13 c0.458 0.667 1.125 1 2 1 c1.313 0 2 -0.875 2 -1.5 c0 -1.5 -2 -1 -2 -2 c0 -0.625 0.516 -1.5 1.5 -1.5 c2.5 0 1.563 2 5.5 2 c0.667 0 1 -0.333 1 -1 M0 0 h24 v24 H0 z";
				case IconKind.BrandTabler:
					return "M4 4 m0 4 a4 4 0 0 1 4 -4 h8 a4 4 0 0 1 4 4 v8 a4 4 0 0 1 -4 4 h-8 a4 4 0 0 1 -4 -4 z M13 15 l3 0 M8 9 l3 3 l-3 3 M0 0 h24 v24 H0 z";
				case IconKind.BrandTailwind:
					return "M11.667 6 c-2.49 0 -4.044 1.222 -4.667 3.667 c0.933 -1.223 2.023 -1.68 3.267 -1.375 c0.71 0.174 1.217 0.68 1.778 1.24 c0.916 0.912 2 1.968 4.288 1.968 c2.49 0 4.044 -1.222 4.667 -3.667 c-0.933 1.223 -2.023 1.68 -3.267 1.375 c-0.71 -0.174 -1.217 -0.68 -1.778 -1.24 c-0.916 -0.912 -1.975 -1.968 -4.288 -1.968 z m-4 6.5 c-2.49 0 -4.044 1.222 -4.667 3.667 c0.933 -1.223 2.023 -1.68 3.267 -1.375 c0.71 0.174 1.217 0.68 1.778 1.24 c0.916 0.912 1.975 1.968 4.288 1.968 c2.49 0 4.044 -1.222 4.667 -3.667 c-0.933 1.223 -2.023 1.68 -3.267 1.375 c-0.71 -0.174 -1.217 -0.68 -1.778 -1.24 c-0.916 -0.912 -1.975 -1.968 -4.288 -1.968 z M0 0 h24 v24 H0 z";
				case IconKind.BrandTaobao:
					return "M5 6 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M8.5 7 c4.333 -0.667 7 -1 8 -1 c1.5 0 3.5 -0.5 4 1.5 c0.333 1.333 0.5 2.833 0.5 4.5 v4 c0 2 -1 3 -5 3 M7 9 c1.43 -1.652 2.06 -2.876 2.5 -4 M3 10 c4.5 1 2.902 4.85 0 8 M10 13 h5 M17 14.5 l1 2 M9 15 c0.71 3.675 6 1.366 8.5 0.5 M13 10 v6.8 M11 9 c-0.44 0.843 -1 1.5 -2 2 M17 10 h-6.5 M0 0 h24 v24 H0 z";
				case IconKind.BrandTed:
					return "M16 8 v8 h2 a3 3 0 0 0 3 -3 v-2 a3 3 0 0 0 -3 -3 h-2 z M9 12 h2.5 M13 8 h-4 v8 h4 M4 8 v8 M2 8 h4 M0 0 h24 v24 H0 z";
				case IconKind.BrandTelegram:
					return "M15 10 l-4 4 l6 6 l4 -16 l-18 7 l4 2 l2 6 l3 -4 M0 0 h24 v24 H0 z";
				case IconKind.BrandTether:
					return "M8 8 h8 M12 15 v-7 M14.08 20.188 c-1.15 1.083 -3.02 1.083 -4.17 0 l-6.93 -6.548 c-0.96 -0.906 -1.27 -2.624 -0.69 -3.831 l2.4 -5.018 c0.47 -0.991 1.72 -1.791 2.78 -1.791 h9.06 c1.06 0 2.31 0.802 2.78 1.79 l2.4 5.019 c0.58 1.207 0.26 2.925 -0.69 3.83 c-3.453 3.293 -3.466 3.279 -6.94 6.549 z M0 0 h24 v24 H0 z";
				case IconKind.BrandThreejs:
					return "M9.527 4.893 l1.473 6.107 l-6.31 -1.564 z M12.573 17.58 l-1.573 -6.58 l6.13 2.179 M12.573 17.58 l-6.152 -1.576 l8.796 -9.466 l1.914 6.64 M8 22 l-5 -19 l19 5.5 z M0 0 h24 v24 H0 z";
				case IconKind.BrandTidal:
					return "M5.333 6 l3.334 3.25 l3.333 -3.25 l3.333 3.25 l3.334 -3.25 l3.333 3.25 l-3.333 3.25 l-3.334 -3.25 l-3.333 3.25 l3.333 3.25 l-3.333 3.25 l-3.333 -3.25 l3.333 -3.25 l-3.333 -3.25 l-3.334 3.25 l-3.333 -3.25 z M0 0 h24 v24 H0 z";
				case IconKind.BrandTiktok:
					return "M9 12 a4 4 0 1 0 4 4 v-12 a5 5 0 0 0 5 5 M0 0 h24 v24 H0 z";
				case IconKind.BrandTinder:
					return "M18.918 8.174 c2.56 4.982 0.501 11.656 -5.38 12.626 c-7.702 1.687 -12.84 -7.716 -7.054 -13.229 c0.309 -0.305 1.161 -1.095 1.516 -1.349 c0 0.528 0.27 3.475 1 3.167 c3 0 4 -4.222 3.587 -7.389 c2.7 1.411 4.987 3.376 6.331 6.174 z M0 0 h24 v24 H0 z";
				case IconKind.BrandTopbuzz:
					return "M4.417 8.655 a0.524 0.524 0 0 1 -0.405 -0.622 l0.986 -4.617 a0.524 0.524 0 0 1 0.626 -0.404 l14.958 3.162 c0.285 0.06 0.467 0.339 0.406 0.622 l-0.987 4.618 a0.524 0.524 0 0 1 -0.625 0.404 l-4.345 -0.92 c-0.198 -0.04 -0.315 0.024 -0.353 0.197 l-2.028 9.49 a0.527 0.527 0 0 1 -0.625 0.404 l-4.642 -0.982 a0.527 0.527 0 0 1 -0.406 -0.622 l2.028 -9.493 c0.037 -0.17 -0.031 -0.274 -0.204 -0.31 l-4.384 -0.927 z M0 0 h24 v24 H0 z";
				case IconKind.BrandTorchain:
					return "M8.412 8.464 l3.553 3.536 l7.742 -8.18 c0.791 -0.85 -0.153 -2.18 -1.238 -1.73 l-9.616 4.098 a1.398 1.398 0 0 0 -0.44 2.277 z M15.588 15.537 l-3.553 -3.537 l-7.742 8.18 c-0.791 0.85 0.153 2.18 1.238 1.73 l9.616 -4.096 a1.398 1.398 0 0 0 0.44 -2.277 z M0 0 h24 v24 H0 z";
				case IconKind.BrandToyota:
					return "M6.415 6.191 c-0.888 0.503 -1.415 1.13 -1.415 1.809 c0 1.657 3.134 3 7 3 s7 -1.343 7 -3 c0 -0.678 -0.525 -1.304 -1.41 -1.806 M9 12 c0 3.866 1.343 7 3 7 s3 -3.134 3 -7 s-1.343 -7 -3 -7 s-3 3.134 -3 7 z M12 12 m-10 0 a10 7 0 1 0 20 0 a10 7 0 1 0 -20 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandTrello:
					return "M14 7 h3 v6 h-3 z M7 7 h3 v10 h-3 z M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BrandTripadvisor:
					return "M9 6.75 c2 -0.667 4 -0.667 6 0 M10.5 15.5 l1.5 2 l1.5 -2 M6.5 9 a4.5 4.5 0 1 1 -3.5 1.671 l-1 -1.671 h4.5 z M17.5 9 a4.5 4.5 0 1 0 3.5 1.671 l1 -1.671 h-4.5 z M17.5 13.5 m-1.5 0 a1.5 1.5 0 1 0 3 0 a1.5 1.5 0 1 0 -3 0 M6.5 13.5 m-1.5 0 a1.5 1.5 0 1 0 3 0 a1.5 1.5 0 1 0 -3 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandTumblr:
					return "M14 21 h4 v-4 h-4 v-6 h4 v-4 h-4 v-4 h-4 v1 a3 3 0 0 1 -3 3 h-1 v4 h4 v6 a4 4 0 0 0 4 4 M0 0 h24 v24 H0 z";
				case IconKind.BrandTwilio:
					return "M9 15 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M15 15 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M15 9 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M9 9 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M21 12 a9 9 0 1 1 -18 0 a9 9 0 0 1 18 0 z M0 0 h24 v24 H0 z";
				case IconKind.BrandTwitch:
					return "M12 8 l0 4 M16 8 l0 4 M4 5 v11 a1 1 0 0 0 1 1 h2 v4 l4 -4 h5.584 c0.266 0 0.52 -0.105 0.707 -0.293 l2.415 -2.414 c0.187 -0.188 0.293 -0.442 0.293 -0.708 v-8.585 a1 1 0 0 0 -1 -1 h-14 a1 1 0 0 0 -1 1 z M0 0 h24 v24 H0 z";
				case IconKind.BrandTwitter:
					return "M22 4.01 c-1 0.49 -1.98 0.689 -3 0.99 c-1.121 -1.265 -2.783 -1.335 -4.38 -0.737 s-2.643 2.06 -2.62 3.737 v1 c-3.245 0.083 -6.135 -1.395 -8 -4 c0 0 -4.182 7.433 4 11 c-1.872 1.247 -3.739 2.088 -6 2 c3.308 1.803 6.913 2.423 10.034 1.517 c3.58 -1.04 6.522 -3.723 7.651 -7.742 a13.84 13.84 0 0 0 0.497 -3.753 c0 -0.249 1.51 -2.772 1.818 -4.013 z M0 0 h24 v24 H0 z";
				case IconKind.BrandTypescript:
					return "M21 19 v-14 a2 2 0 0 0 -2 -2 h-14 a2 2 0 0 0 -2 2 v14 a2 2 0 0 0 2 2 h14 a2 2 0 0 0 2 -2 z M11 12 v6 M9 12 h4 M15 17.5 c0.32 0.32 0.754 0.5 1.207 0.5 h0.543 c0.69 0 1.25 -0.56 1.25 -1.25 v-0.25 a1.5 1.5 0 0 0 -1.5 -1.5 a1.5 1.5 0 0 1 -1.5 -1.5 v-0.25 c0 -0.69 0.56 -1.25 1.25 -1.25 h0.543 c0.453 0 0.887 0.18 1.207 0.5 M0 0 h24 v24 H0 z";
				case IconKind.BrandUber:
					return "M3 12 h6 M9 9 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandUbuntu:
					return "M19 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M17.723 7.41 a7.992 7.992 0 0 0 -3.74 -2.162 m-3.971 0 a7.993 7.993 0 0 0 -3.789 2.216 m-1.881 3.215 a8 8 0 0 0 -0.342 2.32 c0 0.738 0.1 1.453 0.287 2.132 m1.96 3.428 a7.993 7.993 0 0 0 3.759 2.19 m4 0 a7.993 7.993 0 0 0 3.747 -2.186 m1.962 -3.43 a8.008 8.008 0 0 0 0.287 -2.131 c0 -0.764 -0.107 -1.503 -0.307 -2.203 M12 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandUnity:
					return "M20 7 l-8 5 M4 7 l8 5 v9 M4 14 v-7 l6 -4 M18 17 l-6 4 l-6 -4 M14 3 l6 4 v7 M0 0 h24 v24 H0 z";
				case IconKind.BrandUnsplash:
					return "M4 11 h5 v4 h6 v-4 h5 v9 h-16 z m5 -7 h6 v4 h-6 z M0 0 h24 v24 H0 z";
				case IconKind.BrandUpwork:
					return "M3 7 v5 a3 3 0 0 0 6 0 v-5 h1 l4 6 c0.824 1.319 1.945 2 3.5 2 a3.5 3.5 0 0 0 0 -7 c-2.027 0 -3.137 1 -3.5 3 c-0.242 1.33 -0.908 4 -2 8 M0 0 h24 v24 H0 z";
				case IconKind.BrandValorant:
					return "M9 19 h5 l-11 -13 v6 z M14.5 14 h4.5 l2 -2 v-6 z M0 0 h24 v24 H0 z";
				case IconKind.BrandVercel:
					return "M3 19 h18 l-9 -15 z M0 0 h24 v24 H0 z";
				case IconKind.BrandVimeo:
					return "M3 8.5 l1 1 s1.5 -1.102 2 -0.5 c0.509 0.609 1.863 7.65 2.5 9 c0.556 1.184 1.978 2.89 4 1.5 c2 -1.5 7.5 -5.5 8.5 -11.5 c0.444 -2.661 -1 -4 -2.5 -4 c-2 0 -4.047 1.202 -4.5 4 c2.05 -1.254 2.551 1 1.5 3 c-1.052 2 -2 3 -2.5 3 c-0.49 0 -0.924 -1.165 -1.5 -3.5 c-0.59 -2.42 -0.5 -6.5 -3 -6.5 s-5.5 4.5 -5.5 4.5 z M0 0 h24 v24 H0 z";
				case IconKind.BrandVinted:
					return "M11.028 6 c0 7.695 -0.292 11.728 0 12 c2.046 -5 4.246 -12.642 5.252 -14.099 c0.343 -0.497 0.768 -0.93 1.257 -1.277 c0.603 -0.39 1.292 -0.76 1.463 -0.575 c-0.07 2.319 -4.023 15.822 -4.209 16.314 a6.135 6.135 0 0 1 -3.465 3.386 c-3.213 0.78 -3.429 -0.446 -3.836 -1.134 c-0.95 -2.103 -1.682 -14.26 -1.445 -15.615 c0.05 -0.523 0.143 -1.851 2.491 -2 c2.359 -0.354 2.547 1.404 2.492 3 z M0 0 h24 v24 H0 z";
				case IconKind.BrandVisa:
					return "M18 14 h2.7 M16 9.5 a0.5 0.5 0 0 0 -0.5 -0.5 h-0.75 c-0.721 0 -1.337 0.521 -1.455 1.233 l-0.09 0.534 a1.059 1.059 0 0 0 1.045 1.233 a1.059 1.059 0 0 1 1.045 1.233 l-0.09 0.534 a1.476 1.476 0 0 1 -1.455 1.233 h-0.75 a0.5 0.5 0 0 1 -0.5 -0.5 M3 9 h1 v6 h0.5 l2.5 -6 M9 15 l1 -6 M21 15 l-1 -6 l-2.5 6 M0 0 h24 v24 H0 z";
				case IconKind.BrandVisualStudio:
					return "M4 8 l2 -1 l10 13 l4 -2 v-12 l-4 -2 l-10 13 l-2 -1 z M0 0 h24 v24 H0 z";
				case IconKind.BrandVite:
					return "M15 6.5 l7 -1.5 l-10 17 l-10 -17 l7.741 1.5 M10 4.5 l6 -1.5 l-2 6.5 l2 -0.5 l-4 7 v-5 l-3 1 z M0 0 h24 v24 H0 z";
				case IconKind.BrandVivaldi:
					return "M21.648 6.808 c-2.468 4.28 -4.937 8.56 -7.408 12.836 c-0.397 0.777 -1.366 1.301 -2.24 1.356 c-0.962 0.102 -1.7 -0.402 -2.154 -1.254 c-1.563 -2.684 -3.106 -5.374 -4.66 -8.064 c-0.943 -1.633 -1.891 -3.266 -2.83 -4.905 a2.47 2.47 0 0 1 -0.06 -2.45 a2.493 2.493 0 0 1 2.085 -1.307 c0.951 -0.065 1.85 0.438 2.287 1.281 c0.697 1.19 2.043 3.83 2.55 4.682 a3.919 3.919 0 0 0 3.282 2.017 c2.126 0.133 3.974 -0.95 4.21 -3.058 c0 -0.164 0.228 -3.178 0.846 -3.962 c0.619 -0.784 1.64 -1.155 2.606 -0.893 a2.484 2.484 0 0 1 1.814 2.062 c0.08 0.581 -0.041 1.171 -0.343 1.674 M0 0 h24 v24 H0 z";
				case IconKind.BrandVk:
					return "M14 19 h-4 a8 8 0 0 1 -8 -8 v-5 h4 v5 a4 4 0 0 0 4 4 h0 v-9 h4 v4.5 l0.03 0 a4.531 4.531 0 0 0 3.97 -4.496 h4 l-0.342 1.711 a6.858 6.858 0 0 1 -3.658 4.789 h0 a5.34 5.34 0 0 1 3.566 4.111 l0.434 2.389 h0 h-4 a4.531 4.531 0 0 0 -3.97 -4.496 v4.5 z M0 0 h24 v24 H0 z";
				case IconKind.BrandVolkswagen:
					return "M9 4 l2 6 h2 l2 -6 M5 7 l4.5 11 l1.5 -5 h2 l1.5 5 l4.5 -11 M12 21 a9 9 0 0 0 9 -9 a9 9 0 0 0 -9 -9 a9 9 0 0 0 -9 9 a9 9 0 0 0 9 9 z M0 0 h24 v24 H0 z";
				case IconKind.BrandVsco:
					return "M5.636 5.636 l2.828 2.828 M5.636 18.364 l2.828 -2.828 M18.364 18.364 l-2.828 -2.828 M18.364 5.636 l-2.828 2.828 M3 12 h4 M12 21 v-4 M21 12 h-4 M12 3 v4 M17 12 a5 5 0 1 0 -10 0 a5 5 0 0 0 10 0 z M21 12 a9 9 0 1 1 -18 0 a9 9 0 0 1 18 0 z M0 0 h24 v24 H0 z";
				case IconKind.BrandVscode:
					return "M16 16.5 l-11 -10 l-2 1 l13 13.5 M9.165 13.903 l-4.165 3.597 l-2 -1 l4.333 -4.5 m1.735 -1.802 l6.932 -7.198 v5 l-4.795 4.141 M16 3 v18 l4 -2.5 v-13 z M0 0 h24 v24 H0 z";
				case IconKind.BrandVue:
					return "M3 4 l9 16 l9 -16 M16.5 4 l-4.5 8 l-4.5 -8 M0 0 h24 v24 H0 z";
				case IconKind.BrandWalmart:
					return "M8.5 10 l-4.5 -2.505 M8.5 14 l-4.5 2.5 M12 15.96 v5.04 M15.5 14 l4.5 2.5 M15.5 10 l4.5 -2.5 M12 8.04 v-5.04 M0 0 h24 v24 H0 z";
				case IconKind.BrandWaze:
					return "M11 9 h0.01 M16 9 h0.01 M8 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M16 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M10 18.69 a17.29 17.29 0 0 0 3.33 0.3 h0.54 M6.66 17.52 a7 7 0 0 1 -3.66 -4.52 c2 0 3 -1 3 -2.51 c0 -3.92 2.25 -7.49 7.38 -7.49 c4.62 0 7.62 3.51 7.62 8 a8.08 8.08 0 0 1 -3.39 6.62 M0 0 h24 v24 H0 z";
				case IconKind.BrandWebflow:
					return "M17 10 s-1.376 3.606 -1.5 4 c-0.046 -0.4 -1.5 -8 -1.5 -8 c-2.627 0 -3.766 1.562 -4.5 3.5 c0 0 -1.843 4.593 -2 5 c-0.013 -0.368 -0.5 -4.5 -0.5 -4.5 c-0.15 -2.371 -2.211 -3.98 -4 -3.98 l2 12.98 c2.745 -0.013 4.72 -1.562 5.5 -3.5 c0 0 1.44 -4.3 1.5 -4.5 c0.013 0.18 1 8 1 8 c2.758 0 4.694 -1.626 5.5 -3.5 l3.5 -9.5 c-2.732 0 -4.253 2.055 -5 4 z M0 0 h24 v24 H0 z";
				case IconKind.BrandWechat:
					return "M18 14 h0.01 M15 14 h0.01 M7 8 h0.01 M10 8 h0.01 M11.197 15.698 c-0.69 0.196 -1.43 0.302 -2.197 0.302 a8.008 8.008 0 0 1 -2.612 -0.432 l-2.388 1.432 v-2.801 c-1.237 -1.082 -2 -2.564 -2 -4.199 c0 -3.314 3.134 -6 7 -6 c3.782 0 6.863 2.57 7 5.785 l0 0.233 M16.5 10 c3.038 0 5.5 2.015 5.5 4.5 c0 1.397 -0.778 2.645 -2 3.47 l0 2.03 l-1.964 -1.178 a6.649 6.649 0 0 1 -1.536 0.178 c-3.038 0 -5.5 -2.015 -5.5 -4.5 s2.462 -4.5 5.5 -4.5 z M0 0 h24 v24 H0 z";
				case IconKind.BrandWeibo:
					return "M15 4 h1 a5 5 0 0 1 5 5 v1 M19 14.127 c0 3.073 -3.502 5.873 -8 5.873 c-4.126 0 -8 -2.224 -8 -5.565 c0 -1.78 0.984 -3.737 2.7 -5.567 c2.362 -2.51 5.193 -3.687 6.551 -2.238 c0.415 0.44 0.752 1.39 0.749 2.062 c2 -1.615 4.308 0.387 3.5 2.693 c1.26 0.557 2.5 0.538 2.5 2.742 z M0 0 h24 v24 H0 z";
				case IconKind.BrandWhatsapp:
					return "M9 10 a0.5 0.5 0 0 0 1 0 v-1 a0.5 0.5 0 0 0 -1 0 v1 a5 5 0 0 0 5 5 h1 a0.5 0.5 0 0 0 0 -1 h-1 a0.5 0.5 0 0 0 0 1 M3 21 l1.65 -3.8 a9 9 0 1 1 3.4 2.9 l-5.05 0.9 M0 0 h24 v24 H0 z";
				case IconKind.BrandWindows:
					return "M4 12 l16 0 M12 5 l0 14 M17.8 20 l-12 -1.5 c-1 -0.1 -1.8 -0.9 -1.8 -1.9 v-9.2 c0 -1 0.8 -1.8 1.8 -1.9 l12 -1.5 c1.2 -0.1 2.2 0.8 2.2 1.9 v12.1 c0 1.2 -1.1 2.1 -2.2 1.9 z M0 0 h24 v24 H0 z";
				case IconKind.BrandWindy:
					return "M3 4 c0.253 5.44 1.449 16 5.894 16 c4.444 0 8.42 -10.036 9.106 -14 M9 4 c0 5.5 -0.33 16 4 16 s7.546 -11.27 8 -13 M0 0 h24 v24 H0 z";
				case IconKind.BrandWish:
					return "M14.504 14.429 l0.334 -3 M2 6 l5.981 2.392 l-0.639 6.037 c-0.18 0.893 0.06 1.819 0.65 2.514 a3 3 0 0 0 2.381 1.057 a4.328 4.328 0 0 0 4.132 -3.57 c-0.18 0.893 0.06 1.819 0.65 2.514 a3 3 0 0 0 2.38 1.056 a4.328 4.328 0 0 0 4.132 -3.57 l0.333 -4.633 M0 0 h24 v24 H0 z";
				case IconKind.BrandWix:
					return "M13 9 h0.01 M21 9 l-5 6 M16 9 l5 6 M13 11.5 v3.5 M3 9 l1.5 6 l1.379 -5.515 a0.64 0.64 0 0 1 1.242 0 l1.379 5.515 l1.5 -6 M0 0 h24 v24 H0 z";
				case IconKind.BrandWordpress:
					return "M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M18 11 c0.177 -0.528 1 -1.364 1 -2.5 c0 -1.78 -0.776 -2.5 -1.875 -2.5 c-0.898 0 -1.125 0.812 -1.125 1.429 c0 1.83 2 2.058 2 3.571 z M5.5 9 l3.5 11 l3 -7 M11 9 l3 11 l4 -9 M4 9 h2.5 M9.5 9 h3 M0 0 h24 v24 H0 z";
				case IconKind.BrandXbox:
					return "M17.5 5 c-7.72 2.266 -10.037 7.597 -12.5 12.5 M6.5 5 c7.72 2.266 10.037 7.597 12.5 12.5 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandXing:
					return "M7 7 l2 3.5 l-3 4.5 M16 21 l-4 -7 l6.5 -11 M0 0 h24 v24 H0 z";
				case IconKind.BrandYahoo:
					return "M20 18 l0 0.01 M20 11 l0 4 M12.5 8 l5 0 M10 13 l6 -5 M4.5 6 l5.5 7 v5 M7 18 l7 0 M3 6 l5 0 M0 0 h24 v24 H0 z";
				case IconKind.BrandYatse:
					return "M7 3 l5 2.876 v5.088 l4.197 -2.73 l4.803 2.731 l-9.281 5.478 l-2.383 1.41 l-2.334 1.377 l-3 1.77 v-5.565 l3 -1.771 z M0 0 h24 v24 H0 z";
				case IconKind.BrandYcombinator:
					return "M12 17 l0 -4 M8 7 l4 6 l4 -6 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.BrandYoutubeKids:
					return "M10 10 l0.972 4 l4.028 -3 z M17.782 17.03 l-3.413 0.235 l-0.023 0 c-1.117 0.09 -2.214 0.335 -3.257 0.725 l-2.197 0.794 a3.597 3.597 0 0 1 -2.876 -0.189 a3.342 3.342 0 0 1 -1.732 -2.211 l-1.204 -5.293 a3.21 3.21 0 0 1 0.469 -2.503 a3.468 3.468 0 0 1 2.177 -1.452 l9.843 -2.06 c1.87 -0.392 3.716 0.744 4.124 2.537 l1.227 5.392 a3.217 3.217 0 0 1 -0.61 2.7 a3.506 3.506 0 0 1 -2.528 1.323 z M0 0 h24 v24 H0 z";
				case IconKind.BrandYoutube:
					return "M10 9 l5 3 l-5 3 z M3 5 m0 4 a4 4 0 0 1 4 -4 h10 a4 4 0 0 1 4 4 v6 a4 4 0 0 1 -4 4 h-10 a4 4 0 0 1 -4 -4 z M0 0 h24 v24 H0 z";
				case IconKind.BrandZalando:
					return "M7.531 21 c-0.65 0 -1 -0.15 -1.196 -0.27 c-0.266 -0.157 -0.753 -0.563 -1.197 -1.747 a20.583 20.583 0 0 1 -1.137 -6.983 c0.015 -2.745 0.436 -5.07 1.137 -6.975 c0.444 -1.2 0.93 -1.605 1.197 -1.763 c0.192 -0.103 0.545 -0.262 1.195 -0.262 c0.244 0 0.532 0.022 0.871 0.075 a19.093 19.093 0 0 1 6.425 2.475 h0.007 a19.572 19.572 0 0 1 5.287 4.508 c0.783 0.99 0.879 1.627 0.879 1.942 c0 0.315 -0.096 0.953 -0.879 1.943 a19.571 19.571 0 0 1 -5.287 4.5 h-0.007 a19.041 19.041 0 0 1 -6.425 2.474 a5.01 5.01 0 0 1 -0.871 0.083 z M0 0 h24 v24 H0 z";
				case IconKind.BrandZapier:
					return "M9.879 14.121 l-4.243 4.243 M18.364 5.636 l-4.243 4.243 M18.364 18.364 l-4.243 -4.243 M5.636 5.636 l4.243 4.243 M12 15 v6 M12 3 v6 M21 12 h-6 M3 12 h6 M0 0 h24 v24 H0 z";
				case IconKind.BrandZeit:
					return "M3 20 h18 l-9 -16 z M0 0 h24 v24 H0 z";
				case IconKind.BrandZhihu:
					return "M11 18 l-3 -5 M8 6 v7 c0 4.5 -2 5.5 -4 7 M6 4 c-0.5 2.5 -1.5 3.5 -2.5 4.5 M10.5 6 h-5 M4 12 h6.5 M14 6 h6 v12 h-2 l-2 2 l-1 -2 h-1 z M0 0 h24 v24 H0 z";
				case IconKind.BrandZoom:
					return "M3.887 6 h10.08 c1.468 0 3.033 1.203 3.033 2.803 v8.196 a0.991 0.991 0 0 1 -0.975 1 h-10.373 c-1.667 0 -2.652 -1.5 -2.652 -3 l0.01 -8 a0.882 0.882 0 0 1 0.208 -0.71 a0.841 0.841 0 0 1 0.67 -0.287 z M17.011 9.385 v5.128 l3.989 3.487 v-12 z M0 0 h24 v24 H0 z";
				case IconKind.BrandZulip:
					return "M17.5 21 h-11 c-1.325 0 -2.5 -1 -2.5 -2.5 c0 -2 1.705 -3.264 2 -3.5 l4.5 -4 l-2 5 h9 a2.5 2.5 0 1 1 0 5 z M6.5 3 h11 c1.325 0 2.5 1 2.5 2.5 c0 2 -1.705 3.264 -2 3.5 l-4.5 4 l2 -5 h-9 a2.5 2.5 0 0 1 0 -5 z M0 0 h24 v24 H0 z";
				case IconKind.BrandZwift:
					return "M5.5 4 c-1.465 0 -2.5 1.101 -2.5 2.5 s1.035 2.5 2.5 2.5 h2.5 l-4.637 7.19 a2.434 2.434 0 0 0 -0.011 2.538 c0.473 0.787 1.35 1.272 2.3 1.272 h10.848 c1.465 0 2.5 -1.101 2.5 -2.5 s-1.035 -2.5 -2.5 -2.5 h-2.5 l7 -11 h-15.5 z M0 0 h24 v24 H0 z";
				case IconKind.BreadOff:
					return "M3 3 l18 18 M18.415 18.414 a2 2 0 0 1 -1.415 0.586 h-10 a2 2 0 0 1 -2 -2 v-6.764 a3 3 0 0 1 0.435 -4.795 m3.565 -0.441 h8 a3 3 0 0 1 2 5.235 v4.765 M0 0 h24 v24 H0 z";
				case IconKind.Bread:
					return "M17 5 a3 3 0 0 1 2 5.235 v6.765 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 v-6.764 a3 3 0 0 1 1.824 -5.231 l0.176 0 h10 z M0 0 h24 v24 H0 z";
				case IconKind.BriefcaseOff:
					return "M3 3 l18 18 M3 13 a20 20 0 0 0 11.905 1.928 m3.263 -0.763 a20 20 0 0 0 2.832 -1.165 M12 12 v0.01 M8.185 4.158 a2 2 0 0 1 1.815 -1.158 h4 a2 2 0 0 1 2 2 v2 M11 7 h8 a2 2 0 0 1 2 2 v8 m-1.166 2.818 a1.993 1.993 0 0 1 -0.834 0.182 h-14 a2 2 0 0 1 -2 -2 v-9 a2 2 0 0 1 2 -2 h2 M0 0 h24 v24 H0 z";
				case IconKind.Briefcase:
					return "M3 13 a20 20 0 0 0 18 0 M12 12 l0 0.01 M8 7 v-2 a2 2 0 0 1 2 -2 h4 a2 2 0 0 1 2 2 v2 M3 7 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v9 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Brightness2:
					return "M6 6 h3.5 l2.5 -2.5 l2.5 2.5 h3.5 v3.5 l2.5 2.5 l-2.5 2.5 v3.5 h-3.5 l-2.5 2.5 l-2.5 -2.5 h-3.5 v-3.5 l-2.5 -2.5 l2.5 -2.5 z M12 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.BrightnessDown:
					return "M7 7 l0 0.01 M5 12 l0 0.01 M7 17 l0 0.01 M12 19 l0 0.01 M17 17 l0 0.01 M19 12 l0 0.01 M17 7 l0 0.01 M12 5 l0 0.01 M12 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.BrightnessHalf:
					return "M6 6 h3.5 l2.5 -2.5 l2.5 2.5 h3.5 v3.5 l2.5 2.5 l-2.5 2.5 v3.5 h-3.5 l-2.5 2.5 l-2.5 -2.5 h-3.5 v-3.5 l-2.5 -2.5 l2.5 -2.5 z M12 9 a3 3 0 0 0 0 6 v-6 z M0 0 h24 v24 H0 z";
				case IconKind.BrightnessOff:
					return "M3 3 l18 18 M12 19.6 l3.79 -3.79 m2 -2 l3.054 -3.054 M12 14 l1.025 -0.983 m2.065 -1.981 l4.28 -4.106 M12.5 8.5 l4.15 -4.15 M5.641 5.631 a9 9 0 1 0 12.719 12.738 m1.68 -2.318 a9 9 0 0 0 -12.074 -12.098 M12 3 v5 m0 4 v9 M0 0 h24 v24 H0 z";
				case IconKind.BrightnessUp:
					return "M7 7 l-1.4 -1.4 M6 12 l-2 0 M7 17 l-1.4 1.4 M12 19 l0 2 M17 17 l1.4 1.4 M19 12 l2 0 M17 7 l1.4 -1.4 M12 5 l0 -2 M12 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.Brightness:
					return "M12 19.6 l8.85 -8.85 M12 14.3 l7.37 -7.37 M12 9 l4.65 -4.65 M12 3 l0 18 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.BroadcastOff:
					return "M3 3 l18 18 M12 12 a1 1 0 1 0 1 1 M15.536 16.536 a5 5 0 0 0 -3.536 -8.536 m-3 1 a5 5 0 0 0 -0.535 7.536 M18.364 19.364 a9 9 0 0 0 -9.721 -14.717 m-2.488 1.509 a9 9 0 0 0 -0.519 13.208 M0 0 h24 v24 H0 z";
				case IconKind.Broadcast:
					return "M12 13 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M15.536 16.536 a5 5 0 1 0 -7.072 0 M18.364 19.364 a9 9 0 1 0 -12.728 0 M0 0 h24 v24 H0 z";
				case IconKind.BrowserCheck:
					return "M9.5 14.5 l1.5 1.5 l3 -3 M8 4 v4 M4 8 h16 M4 4 m0 1 a1 1 0 0 1 1 -1 h14 a1 1 0 0 1 1 1 v14 a1 1 0 0 1 -1 1 h-14 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.BrowserOff:
					return "M3 3 l18 18 M4 8 h4 m4 0 h8 M8 4 h11 a1 1 0 0 1 1 1 v11 m-0.288 3.702 a1 1 0 0 1 -0.712 0.298 h-14 a1 1 0 0 1 -1 -1 v-14 c0 -0.276 0.112 -0.526 0.293 -0.707 M0 0 h24 v24 H0 z";
				case IconKind.BrowserPlus:
					return "M12 12 v4 M10 14 h4 M8 4 v4 M4 8 h16 M4 4 m0 1 a1 1 0 0 1 1 -1 h14 a1 1 0 0 1 1 1 v14 a1 1 0 0 1 -1 1 h-14 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.BrowserX:
					return "M14 16 l-4 -4 M10 16 l4 -4 M8 4 v4 M4 8 h16 M4 4 m0 1 a1 1 0 0 1 1 -1 h14 a1 1 0 0 1 1 1 v14 a1 1 0 0 1 -1 1 h-14 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.Browser:
					return "M8 4 l0 4 M4 8 l16 0 M4 4 m0 1 a1 1 0 0 1 1 -1 h14 a1 1 0 0 1 1 1 v14 a1 1 0 0 1 -1 1 h-14 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.BrushOff:
					return "M3 3 l18 18 M21 3 a16 16 0 0 1 -4.697 9.302 m-2.195 1.786 a15.993 15.993 0 0 1 -3.308 1.712 M21 3 a16 16 0 0 0 -9.309 4.704 m-1.795 2.212 a15.993 15.993 0 0 0 -1.696 3.284 M3 17 a4 4 0 1 1 4 4 h-4 v-4 z M0 0 h24 v24 H0 z";
				case IconKind.Brush:
					return "M10.6 9 a9 9 0 0 1 4.4 4.4 M21 3 a16 16 0 0 1 -10.2 12.8 M21 3 a16 16 0 0 0 -12.8 10.2 M3 21 v-4 a4 4 0 1 1 4 4 h-4 M0 0 h24 v24 H0 z";
				case IconKind.BucketDroplet:
					return "M7.492 11.818 c0.362 0.362 0.768 0.676 1.208 0.934 l6.895 4.047 c1.078 0.557 2.255 -0.075 3.692 -1.512 c1.437 -1.437 2.07 -2.614 1.512 -3.692 c-0.372 -0.718 -1.72 -3.017 -4.047 -6.895 a6.015 6.015 0 0 0 -0.934 -1.208 M13.737 9.737 c2.299 -2.3 3.23 -5.095 2.081 -6.245 c-1.15 -1.15 -3.945 -0.217 -6.244 2.082 c-2.3 2.299 -3.231 5.095 -2.082 6.244 c1.15 1.15 3.946 0.218 6.245 -2.081 z M5 16 l1.465 1.638 a2 2 0 1 1 -3.015 0.099 l1.55 -1.737 z M0 0 h24 v24 H0 z";
				case IconKind.BucketOff:
					return "M3 3 l18 18 M4 7 c0 0.664 0.088 1.324 0.263 1.965 l2.737 10.035 c0.5 1.5 2.239 2 5 2 s4.5 -0.5 5 -2 c0.1 -0.3 0.252 -0.812 0.457 -1.535 m0.862 -3.146 c0.262 -0.975 0.735 -2.76 1.418 -5.354 a7.45 7.45 0 0 0 0.263 -1.965 M5.029 5.036 c-0.655 0.58 -1.029 1.25 -1.029 1.964 c0 2.033 3.033 3.712 6.96 3.967 m3.788 -0.21 c3.064 -0.559 5.252 -2.029 5.252 -3.757 c0 -2.21 -3.582 -4 -8 -4 c-1.605 0 -3.1 0.236 -4.352 0.643 M0 0 h24 v24 H0 z";
				case IconKind.Bucket:
					return "M4 7 c0 0.664 0.088 1.324 0.263 1.965 l2.737 10.035 c0.5 1.5 2.239 2 5 2 s4.5 -0.5 5 -2 c0.333 -1 1.246 -4.345 2.737 -10.035 a7.45 7.45 0 0 0 0.263 -1.965 M12 7 m-8 0 a8 4 0 1 0 16 0 a8 4 0 1 0 -16 0 M0 0 h24 v24 H0 z";
				case IconKind.BugOff:
					return "M3 3 l18 18 M20 7 l-3.75 2.4 M4 7 l3.75 2.4 M4 19 l3.35 -2 M12 20 v-6 M17 13 h4 M3 13 h4 M13 9 h3 a6 6 0 0 1 1 3 v1 m-0.298 3.705 a5 5 0 0 1 -9.702 -1.705 v-3 a6 6 0 0 1 1 -3 h1 M9.884 5.873 a3 3 0 0 1 5.116 2.127 v1 M0 0 h24 v24 H0 z";
				case IconKind.Bug:
					return "M20 7 l-3.75 2.4 M4 7 l3.75 2.4 M20 19 l-3.35 -2 M4 19 l3.35 -2 M12 20 l0 -6 M17 13 l4 0 M3 13 l4 0 M8 9 h8 a6 6 0 0 1 1 3 v3 a5 5 0 0 1 -10 0 v-3 a6 6 0 0 1 1 -3 M9 9 v-1 a3 3 0 0 1 6 0 v1 M0 0 h24 v24 H0 z";
				case IconKind.BuildingArch:
					return "M9 21 v-8 a3 3 0 0 1 6 0 v8 M4 21 v-15 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v15 M3 21 l18 0 M0 0 h24 v24 H0 z";
				case IconKind.BuildingBank:
					return "M16 14 l0 3 M12 14 l0 3 M8 14 l0 3 M20 10 l0 11 M4 10 l0 11 M5 6 l7 -3 l7 3 M3 10 l18 0 M3 21 l18 0 M0 0 h24 v24 H0 z";
				case IconKind.BuildingBridge2:
					return "M6 7 h12 a2 2 0 0 1 2 2 v9 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 v-2 a4 4 0 0 0 -8 0 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 v-9 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.BuildingBridge:
					return "M12 10 l0 5 M3 8 a7.5 7.5 0 0 0 3 -2 a6.5 6.5 0 0 0 12 0 a7.5 7.5 0 0 0 3 2 M2 15 l20 0 M18 5 l0 14 M6 5 l0 14 M0 0 h24 v24 H0 z";
				case IconKind.BuildingBroadcastTower:
					return "M10 19 h4 M9 21 l3 -9 l3 9 M20.307 15.469 a9 9 0 1 0 -16.615 0 M16.616 13.924 a5 5 0 1 0 -9.23 0 M12 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.BuildingCarousel:
					return "M8 22 l4 -10 l4 10 M19 16 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 16 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M19 8 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M12 4 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 8 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M12 12 m-6 0 a6 6 0 1 0 12 0 a6 6 0 1 0 -12 0 M0 0 h24 v24 H0 z";
				case IconKind.BuildingCastle:
					return "M3 11 l18 0 M15 19 v-2 a3 3 0 0 0 -6 0 v2 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 v-14 h4 v3 h3 v-3 h4 v3 h3 v-3 h4 v14 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.BuildingChurch:
					return "M6 21 v-7 m-2 2 l8 -8 l8 8 m-2 -2 v7 M12 3 l0 5 M10 5 l4 0 M10 21 v-4 a2 2 0 0 1 4 0 v4 M3 21 l18 0 M0 0 h24 v24 H0 z";
				case IconKind.BuildingCircus:
					return "M12 7 v-4 l2 1 h-2 M18 11 c0.333 5.333 1 8.667 2 10 h-4 c-1 0 -4 -4 -4 -9 v-1 M6 11 c-0.333 5.333 -1 8.667 -2 10 h4 c1 0 4 -4 4 -9 v-1 M12 6.5 c0 1 5 4.5 8 4.5 M12 6.5 c0 1 -5 4.5 -8 4.5 M4 11 h16 M0 0 h24 v24 H0 z";
				case IconKind.BuildingCommunity:
					return "M17 15 l0 0.01 M17 11 l0 0.01 M17 7 l0 0.01 M13 7 l0 0.01 M8 9 l5 5 v7 h-5 v-4 m0 4 h-5 v-7 l5 -5 m1 1 v-6 a1 1 0 0 1 1 -1 h10 a1 1 0 0 1 1 1 v17 h-8 M0 0 h24 v24 H0 z";
				case IconKind.BuildingCottage:
					return "M9 21 v-5 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v5 M12 9 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M4 21 v-11 l2.5 -4.5 l5.5 -2.5 l5.5 2.5 l2.5 4.5 v11 M3 21 l18 0 M0 0 h24 v24 H0 z";
				case IconKind.BuildingEstate:
					return "M8 9 h2 M8 13 h2 M9 17 v4 M14 21 v-14 a3 3 0 0 0 -3 -3 h-4 a3 3 0 0 0 -3 3 v14 M19 17 a2 2 0 0 0 2 -2 v-2 a2 2 0 1 0 -4 0 v2 a2 2 0 0 0 2 2 z M19 21 v-4 M3 21 h18 M0 0 h24 v24 H0 z";
				case IconKind.BuildingFactory2:
					return "M14 17 h1 M9 17 h1 M19 21 v-8 l-1.436 -9.574 a0.5 0.5 0 0 0 -0.495 -0.426 h-1.145 a0.5 0.5 0 0 0 -0.494 0.418 l-1.43 8.582 M5 21 v-12 l5 4 v-4 l5 4 h4 M3 21 h18 M0 0 h24 v24 H0 z";
				case IconKind.BuildingFactory:
					return "M3 21 l19 0 M9 5 a2.4 2.4 0 0 1 2 -1 a2.4 2.4 0 0 1 2 1 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 a2.4 2.4 0 0 1 2 -1 a2.4 2.4 0 0 1 2 1 M12.5 13 h4.5 c0.025 2.612 0.894 5.296 2 8 M4 21 c1.147 -4.02 1.983 -8.027 2 -12 h6 c0.017 3.973 0.853 7.98 2 12 M0 0 h24 v24 H0 z";
				case IconKind.BuildingFortress:
					return "M17 13 h0 v0.01 M17 10 h0 v0.01 M17 7 h0 v0.01 M7 13 h0 v0.01 M7 10 h0 v0.01 M7 7 h0 v0.01 M7 21 h1 a1 1 0 0 0 1 -1 v-1 h0 a3 3 0 0 1 6 0 m3 2 h1 a1 1 0 0 0 1 -1 v-15 l-3 -2 l-3 2 v6 h-4 v-6 l-3 -2 l-3 2 v15 a1 1 0 0 0 1 1 h2 m8 -2 v1 a1 1 0 0 0 1 1 h2 M0 0 h24 v24 H0 z";
				case IconKind.BuildingHospital:
					return "M12 7 l0 4 M10 9 l4 0 M9 21 v-4 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v4 M5 21 v-16 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v16 M3 21 l18 0 M0 0 h24 v24 H0 z";
				case IconKind.BuildingLighthouse:
					return "M21 11 l-2 -2 l2 -2 M3 11 l2 -2 l-2 -2 M8 9 l8 0 M12 3 l2 3 l2 15 h-8 l2 -15 z M0 0 h24 v24 H0 z";
				case IconKind.BuildingMonument:
					return "M3 21 l18 0 M5 21 v-3 h14 v3 M8 18 l2 -13 l2 -2 l2 2 l2 13 M0 0 h24 v24 H0 z";
				case IconKind.BuildingPavilion:
					return "M6 12 h12 a3 3 0 0 0 3 -3 a9 8 0 0 1 -9 -6 a9 8 0 0 1 -9 6 a3 3 0 0 0 3 3 M18 21 l0 -9 M6 21 l0 -9 M3 21 h7 v-3 a2 2 0 0 1 4 0 v3 h7 M0 0 h24 v24 H0 z";
				case IconKind.BuildingSkyscraper:
					return "M9 18 l0 0.01 M9 15 l0 0.01 M9 12 l0 0.01 M9 9 l0 0.01 M19 21 v-10 l-6 -4 M5 21 v-14 l8 -4 v18 M3 21 l18 0 M0 0 h24 v24 H0 z";
				case IconKind.BuildingStadium:
					return "M7 6 h4 v-3 h-4 v7 M15 6 h4 v-3 h-4 v7 M4 12 v7 c0 0.94 2.51 1.785 6 2 v-3 h4 v3 c3.435 -0.225 6 -1.07 6 -2 v-7 M12 12 m-8 0 a8 2 0 1 0 16 0 a8 2 0 1 0 -16 0 M0 0 h24 v24 H0 z";
				case IconKind.BuildingStore:
					return "M9 21 v-4 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v4 M19 21 l0 -10.15 M5 21 l0 -10.15 M3 7 v1 a3 3 0 0 0 6 0 v-1 m0 1 a3 3 0 0 0 6 0 v-1 m0 1 a3 3 0 0 0 6 0 v-1 h-18 l2 -4 h14 l2 4 M3 21 l18 0 M0 0 h24 v24 H0 z";
				case IconKind.BuildingTunnel:
					return "M15 9 l3 -3 l-3 3 z M6 6 l3 3 M12 3 v5 M7 12 h-4 M21 12 h-4 M17 17 h4 M3 17 h4 M8 21 v-9 a4 4 0 1 1 8 0 v9 M5 21 h14 a2 2 0 0 0 2 -2 v-7 a9 9 0 0 0 -18 0 v7 a2 2 0 0 0 2 2 z M0 0 h24 v24 H0 z";
				case IconKind.BuildingWarehouse:
					return "M13 21 v-9 a1 1 0 0 0 -1 -1 h-2 a1 1 0 0 0 -1 1 v3 M13 13 h4 v8 h-10 v-6 h6 M3 21 v-13 l9 -4 l9 4 v13 M0 0 h24 v24 H0 z";
				case IconKind.BuildingWindTurbine:
					return "M13 14 l1 7 M10 21 l1 -7 M7 21 h10 M13 12.716 l-2.236 1.277 a3.624 3.624 0 0 1 -0.485 0.23 l-4.555 1.681 c-0.551 0.241 -1.223 0.015 -1.548 -0.54 c-0.324 -0.557 -0.187 -1.245 0.3 -1.597 l3.836 -2.91 a3.41 3.41 0 0 1 0.446 -0.3 l2.235 -1.277 M13.01 9.28 l2.235 1.276 c0.156 0.09 0.305 0.19 0.446 0.3 l3.836 2.911 c0.487 0.352 0.624 1.04 0.3 1.596 c-0.325 0.556 -1 0.782 -1.548 0.541 l-4.555 -1.68 a3.624 3.624 0 0 1 -0.486 -0.231 l-2.235 -1.277 M10 11 v-2.573 c0 -0.18 0.013 -0.358 0.04 -0.536 l0.716 -4.828 c0.064 -0.597 0.597 -1.063 1.244 -1.063 s1.18 0.466 1.244 1.063 l0.716 4.828 c0.027 0.178 0.04 0.357 0.04 0.536 v2.573 M12 11 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Building:
					return "M5 21 v-16 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v16 M14 16 l1 0 M14 12 l1 0 M14 8 l1 0 M9 16 l1 0 M9 12 l1 0 M9 8 l1 0 M3 21 l18 0 M0 0 h24 v24 H0 z";
				case IconKind.BulbFilled:
					return "M3 12 h1 m8 -9 v1 m8 8 h1 m-15.4 -6.4 l0.7 0.7 m12.1 -0.7 l-0.7 0.7 m-3.405 10.7 a3.5 3.5 0 0 0 -0.295 2 a2 2 0 1 1 -4 0 a3.5 3.5 0 0 0 -0.295 -2 m2.295 -10 a5 5 0 0 1 3 9 a3.498 3.498 0 0 0 -0.706 1 h-4.588 a3.498 3.498 0 0 0 -0.706 -1 a5 5 0 0 1 3 -9 z M0 0 h24 v24 H0 z";
				case IconKind.BulbOff:
					return "M3 3 l18 18 M9.7 17 h4.6 M11.089 7.083 a5 5 0 0 1 5.826 5.84 m-1.378 2.611 a5.012 5.012 0 0 1 -0.537 0.466 a3.5 3.5 0 0 0 -1 3 a2 2 0 1 1 -4 0 a3.5 3.5 0 0 0 -1 -3 a5 5 0 0 1 -0.528 -7.544 M3 12 h1 m8 -9 v1 m8 8 h1 m-15.4 -6.4 l0.7 0.7 m12.1 -0.7 l-0.7 0.7 M0 0 h24 v24 H0 z";
				case IconKind.Bulb:
					return "M9.7 17 l4.6 0 M9 16 a5 5 0 1 1 6 0 a3.5 3.5 0 0 0 -1 3 a2 2 0 0 1 -4 0 a3.5 3.5 0 0 0 -1 -3 M3 12 h1 m8 -9 v1 m8 8 h1 m-15.4 -6.4 l0.7 0.7 m12.1 -0.7 l-0.7 0.7 M0 0 h24 v24 H0 z";
				case IconKind.Bulldozer:
					return "M18 17 l-3 0 M5 15 v-2 a1 1 0 0 1 1 -1 h7 M8 12 v-5 h2 a3 3 0 0 1 3 3 v5 M4 15 l9 0 M13 19 l-9 0 M18 13 v6 h3 M13 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M4 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.BusOff:
					return "M3 3 l18 18 M12 5 v3 M7 7 v3 M2 10 h8 m4 0 h3 M16 5 l1.5 7 h4.5 M4 17 h-2 v-11 a1 1 0 0 1 1 -1 h2 m4 0 h8 c2.761 0 5 3.134 5 7 v5 h-1 m-5 0 h-8 M16.18 16.172 a2 2 0 0 0 2.652 2.648 M6 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.BusStop:
					return "M5 9 v11 M12 5 v5 M9.5 10 h7.5 M16 5 l1.5 7 h4.5 M16 17 h-8 M10 5 h7 c2.761 0 5 3.134 5 7 v5 h-2 M18 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M3 3 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.Bus:
					return "M12 5 l0 5 M7 5 l0 5 M2 10 l15 0 M16 5 l1.5 7 l4.5 0 M4 17 h-2 v-11 a1 1 0 0 1 1 -1 h14 a5 7 0 0 1 5 7 v5 h-2 m-4 0 h-8 M18 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Businessplan:
					return "M5 15 v1 m0 -8 v1 M7 9 h-2.5 a1.5 1.5 0 0 0 0 3 h1 a1.5 1.5 0 0 1 0 3 h-2.5 M11 14 v4 c0 1.657 2.239 3 5 3 s5 -1.343 5 -3 v-4 M11 10 v4 c0 1.657 2.239 3 5 3 s5 -1.343 5 -3 v-4 M11 6 v4 c0 1.657 2.239 3 5 3 s5 -1.343 5 -3 v-4 M16 6 m-5 0 a5 3 0 1 0 10 0 a5 3 0 1 0 -10 0 M0 0 h24 v24 H0 z";
				case IconKind.Butterfly:
					return "M9 3 l3 2 l3 -2 M12 19 v-10 M12 18.176 a3 3 0 1 1 -4.953 -2.449 l-0.025 0.023 a4.502 4.502 0 0 1 1.483 -8.75 c1.414 0 2.675 0.652 3.5 1.671 a4.5 4.5 0 1 1 4.983 7.079 a3 3 0 1 1 -4.983 2.25 z M0 0 h24 v24 H0 z";
				case IconKind.CactusOff:
					return "M3 3 l18 18 M7 21 h10 M10 21 v-11 m0 -4 v-1 a2 2 0 1 1 4 0 v5 m0 4 v7 M18 8 v5 a3 3 0 0 1 -0.129 0.872 m-2.014 2 a3 3 0 0 1 -0.857 0.124 h-1 M6 9 v1 a3 3 0 0 0 3 3 h1 M0 0 h24 v24 H0 z";
				case IconKind.Cactus:
					return "M7 21 h10 M10 21 v-16 a2 2 0 1 1 4 0 v16 M18 8 v5 a3 3 0 0 1 -3 3 h-1 M6 9 v1 a3 3 0 0 0 3 3 h1 M0 0 h24 v24 H0 z";
				case IconKind.CakeOff:
					return "M3 3 l18 18 M10.172 6.188 c0.07 -0.158 0.163 -0.31 0.278 -0.451 l1.55 -1.737 l1.465 1.638 a2 2 0 0 1 -0.65 3.19 M3 14.803 c0.312 0.135 0.654 0.204 1 0.197 a2.4 2.4 0 0 0 2 -1 a2.4 2.4 0 0 1 2 -1 a2.4 2.4 0 0 1 2 1 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 m4 0 a2.4 2.4 0 0 0 2 1 c0.35 0.007 0.692 -0.062 1 -0.197 M21 17 v-5 a3 3 0 0 0 -3 -3 h-5 m-4 0 h-3 a3 3 0 0 0 -3 3 v8 h17 M0 0 h24 v24 H0 z";
				case IconKind.Cake:
					return "M12 4 l1.465 1.638 a2 2 0 1 1 -3.015 0.099 l1.55 -1.737 z M3 14.803 c0.312 0.135 0.654 0.204 1 0.197 a2.4 2.4 0 0 0 2 -1 a2.4 2.4 0 0 1 2 -1 a2.4 2.4 0 0 1 2 1 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 a2.4 2.4 0 0 1 2 -1 a2.4 2.4 0 0 1 2 1 a2.4 2.4 0 0 0 2 1 c0.35 0.007 0.692 -0.062 1 -0.197 M3 20 h18 v-8 a3 3 0 0 0 -3 -3 h-12 a3 3 0 0 0 -3 3 v8 z M0 0 h24 v24 H0 z";
				case IconKind.CalculatorOff:
					return "M3 3 l18 18 M16 17 v0.01 M12 17 v0.01 M8 17 v0.01 M12 14 v0.01 M8 14 v0.01 M10 10 h-1 a1 1 0 0 1 -1 -1 v-1 m3 -1 h4 a1 1 0 0 1 1 1 v1 a1 1 0 0 1 -1 1 h-1 M19.823 19.824 a2 2 0 0 1 -1.823 1.176 h-12 a2 2 0 0 1 -2 -2 v-14 c0 -0.295 0.064 -0.575 0.178 -0.827 m2.822 -1.173 h11 a2 2 0 0 1 2 2 v11 M0 0 h24 v24 H0 z";
				case IconKind.Calculator:
					return "M16 17 l0 0.01 M12 17 l0 0.01 M8 17 l0 0.01 M16 14 l0 0.01 M12 14 l0 0.01 M8 14 l0 0.01 M8 7 m0 1 a1 1 0 0 1 1 -1 h6 a1 1 0 0 1 1 1 v1 a1 1 0 0 1 -1 1 h-6 a1 1 0 0 1 -1 -1 z M4 3 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v14 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.CalendarDue:
					return "M12 16 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M4 11 h16 M8 3 v4 M16 3 v4 M4 5 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.CalendarEvent:
					return "M8 15 h2 v2 h-2 z M4 11 l16 0 M8 3 l0 4 M16 3 l0 4 M4 5 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.CalendarMinus:
					return "M10 16 l4 0 M4 11 l16 0 M8 3 l0 4 M16 3 l0 4 M4 5 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.CalendarOff:
					return "M3 3 l18 18 M12 15 l0 3 M11 15 l1 0 M4 11 h7 m4 0 h5 M8 3 l0 1 M16 3 l0 4 M19.823 19.824 a2 2 0 0 1 -1.823 1.176 h-12 a2 2 0 0 1 -2 -2 v-12 a2 2 0 0 1 1.175 -1.823 m3.825 -0.177 h9 a2 2 0 0 1 2 2 v9 M0 0 h24 v24 H0 z";
				case IconKind.CalendarPlus:
					return "M12 14 l0 4 M10 16 l4 0 M4 11 l16 0 M8 3 l0 4 M16 3 l0 4 M4 5 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.CalendarStats:
					return "M3 11 h16 M7 3 v4 M15 3 v4 M18 18 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M18 14 v4 h4 M11.795 21 h-6.795 a2 2 0 0 1 -2 -2 v-12 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v4 M0 0 h24 v24 H0 z";
				case IconKind.CalendarTime:
					return "M18 16.496 v1.504 l1 1 M3 11 h16 M7 3 v4 M15 3 v4 M18 18 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M11.795 21 h-6.795 a2 2 0 0 1 -2 -2 v-12 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v4 M0 0 h24 v24 H0 z";
				case IconKind.Calendar:
					return "M12 15 l0 3 M11 15 l1 0 M4 11 l16 0 M8 3 l0 4 M16 3 l0 4 M4 5 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.CameraMinus:
					return "M15 6 l6 0 M5 7 h1 a2 2 0 0 0 2 -2 a1 1 0 0 1 1 -1 h3 m9 6 v8 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 v-9 a2 2 0 0 1 2 -2 M12 13 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.CameraOff:
					return "M3 3 l18 18 M10.436 10.44 a3 3 0 1 0 4.126 4.122 M8.29 4.296 a1 1 0 0 1 0.71 -0.296 h6 a1 1 0 0 1 1 1 a2 2 0 0 0 2 2 h1 a2 2 0 0 1 2 2 v8 m-1.179 2.824 c-0.25 0.113 -0.528 0.176 -0.821 0.176 h-14 a2 2 0 0 1 -2 -2 v-9 a2 2 0 0 1 2 -2 h1 c0.292 0 0.568 -0.062 0.818 -0.175 M0 0 h24 v24 H0 z";
				case IconKind.CameraPlus:
					return "M18 3 l0 6 M15 6 l6 0 M5 7 h2 a2 2 0 0 0 2 -2 a1 1 0 0 1 1 -1 h2 m9 7 v7 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 v-9 a2 2 0 0 1 2 -2 M12 13 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.CameraRotate:
					return "M10 13 h-2 v-2 M14 13 h2 v2 M11.245 15.904 a3 3 0 0 0 3.755 -2.904 m-2.25 -2.905 a3 3 0 0 0 -3.75 2.905 M5 7 h1 a2 2 0 0 0 2 -2 a1 1 0 0 1 1 -1 h6 a1 1 0 0 1 1 1 a2 2 0 0 0 2 2 h1 a2 2 0 0 1 2 2 v9 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 v-9 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.CameraSelfie:
					return "M9 11 l0.01 0 M15 11 l0.01 0 M9.5 15 a3.5 3.5 0 0 0 5 0 M5 7 h1 a2 2 0 0 0 2 -2 a1 1 0 0 1 1 -1 h6 a1 1 0 0 1 1 1 a2 2 0 0 0 2 2 h1 a2 2 0 0 1 2 2 v9 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 v-9 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.Camera:
					return "M12 13 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M5 7 h1 a2 2 0 0 0 2 -2 a1 1 0 0 1 1 -1 h6 a1 1 0 0 1 1 1 a2 2 0 0 0 2 2 h1 a2 2 0 0 1 2 2 v9 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 v-9 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.Campfire:
					return "M12 15 a4 4 0 0 0 4 -4 c0 -3 -2 -3 -2 -8 c-4 2 -6 5 -6 8 a4 4 0 0 0 4 4 z M20 21 l-16 -4 M4 21 l16 -4 M0 0 h24 v24 H0 z";
				case IconKind.Candle:
					return "M12 3 l1.465 1.638 a2 2 0 1 1 -3.015 0.099 l1.55 -1.737 z M9 21 h6 v-9 a1 1 0 0 0 -1 -1 h-4 a1 1 0 0 0 -1 1 v9 z M0 0 h24 v24 H0 z";
				case IconKind.CandyOff:
					return "M3 3 l18 18 M9.172 16.243 l-0.772 3.086 a1.5 1.5 0 0 1 -2.516 0.697 l-2.217 -2.216 a1.5 1.5 0 0 1 0.47 -2.44 l2.913 -1.248 M16.243 9.172 l3.086 -0.772 a1.5 1.5 0 0 0 0.697 -2.516 l-2.216 -2.217 a1.5 1.5 0 0 0 -2.44 0.47 l-1.248 2.913 M11.174 7.17 l0.119 -0.12 a2 2 0 0 1 2.828 0 l2.829 2.83 a2 2 0 0 1 0 2.828 l-0.124 0.124 m-2 2 l-2.123 2.123 a2 2 0 0 1 -2.828 0 l-2.829 -2.831 a2 2 0 0 1 0 -2.828 l2.113 -2.112 M0 0 h24 v24 H0 z";
				case IconKind.Candy:
					return "M9.172 16.243 l-0.772 3.086 a1.5 1.5 0 0 1 -2.516 0.697 l-2.217 -2.216 a1.5 1.5 0 0 1 0.47 -2.44 l2.913 -1.248 M16.243 9.172 l3.086 -0.772 a1.5 1.5 0 0 0 0.697 -2.516 l-2.216 -2.217 a1.5 1.5 0 0 0 -2.44 0.47 l-1.248 2.913 M7.05 11.293 l4.243 -4.243 a2 2 0 0 1 2.828 0 l2.829 2.83 a2 2 0 0 1 0 2.828 l-4.243 4.243 a2 2 0 0 1 -2.828 0 l-2.829 -2.831 a2 2 0 0 1 0 -2.828 z M0 0 h24 v24 H0 z";
				case IconKind.Cane:
					return "M9 21 l6.324 -11.69 c0.54 -0.974 1.756 -4.104 -1.499 -5.762 c-3.255 -1.657 -5.175 0.863 -5.825 2.032 M0 0 h24 v24 H0 z";
				case IconKind.Cannabis:
					return "M12 22 v-5 M7 20 s0 -2 1 -3.5 c-1.5 0 -2 -0.5 -4 -1.5 c0 0 1.839 -1.38 5 -1 c-1.789 -0.97 -3.279 -2.03 -5 -6 c0 0 3.98 -0.3 6.5 3.5 c-2.284 -4.9 1.5 -9.5 1.5 -9.5 c2.734 5.47 2.389 7.5 1.5 9.5 c2.531 -3.77 6.5 -3.5 6.5 -3.5 c-1.721 3.97 -3.211 5.03 -5 6 c3.161 -0.38 5 1 5 1 c-2 1 -2.5 1.5 -4 1.5 c1 1.5 1 3.5 1 3.5 c-2 0 -4.438 -2.22 -5 -3 c-0.563 0.78 -3 3 -5 3 z M0 0 h24 v24 H0 z";
				case IconKind.CaptureOff:
					return "M3 3 l18 18 M4 8 v-2 c0 -0.548 0.22 -1.044 0.577 -1.405 M9.87 9.887 a3 3 0 0 0 4.255 4.23 m0.58 -3.416 a3.012 3.012 0 0 0 -1.4 -1.403 M16 20 h2 c0.554 0 1.055 -0.225 1.417 -0.589 M16 4 h2 a2 2 0 0 1 2 2 v2 M4 16 v2 a2 2 0 0 0 2 2 h2 M0 0 h24 v24 H0 z";
				case IconKind.Capture:
					return "M12 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M16 20 h2 a2 2 0 0 0 2 -2 v-2 M16 4 h2 a2 2 0 0 1 2 2 v2 M4 16 v2 a2 2 0 0 0 2 2 h2 M4 8 v-2 a2 2 0 0 1 2 -2 h2 M0 0 h24 v24 H0 z";
				case IconKind.CarCrane:
					return "M8 12 v-4 l-4 -2 M4 12 v-6 l18 -3 v2 M3 17 v-5 h9 M12 18 v-11 h3 M7 18 h8 m4 0 h2 v-6 a5 5 0 0 0 -5 -5 h-1 l1.5 5 h4.5 M17 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.CarCrash:
					return "M17.5 8.5 l1.5 -1.5 M17.5 15.5 l1.5 1.5 M19 12 h2 M14 8 v-2 M7 6 l4 5 h1 a2 2 0 0 1 2 2 v4 h-2 m-4 0 h-5 m0 -6 h8 m-6 0 v-5 m2 0 h-4 M10 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.CarOff:
					return "M3 3 l18 18 M5 17 h-2 v-6 l2 -5 h1 m4 0 h4 l4 5 h1 a2 2 0 0 1 2 2 v4 m-6 0 h-6 m-6 -6 h8 m4 0 h3 m-6 -3 v-2 M15.584 15.588 a2 2 0 0 0 2.828 2.83 M7 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.CarTurbine:
					return "M11 9 v4 M11 13 l3.5 -1.5 M8.5 16 l2.5 -3 M11 13 l2.5 3 M11 13 l-3.5 -1.5 M17 3 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v6 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M11 9 c2.489 0.108 4.489 0.108 6 0 M18.86 11 c0.088 0.66 0.14 1.512 0.14 2 a8 8 0 1 1 -8 -8 h6 M11 13 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M0 0 h24 v24 H0 z";
				case IconKind.Car:
					return "M5 17 h-2 v-6 l2 -5 h9 l4 5 h1 a2 2 0 0 1 2 2 v4 h-2 m-4 0 h-6 m-6 -6 h15 m-6 0 v-5 M17 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M7 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Caravan:
					return "M6 8 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M9 17 h-5 a1 1 0 0 1 -1 -1 v-9 a2 2 0 0 1 2 -2 h10 l4 4 v8 M21 17 l-8 0 M11 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.CardboardsOff:
					return "M3 3 l18 18 M16.714 12.7 a1 1 0 0 0 -1.417 -1.411 l1.417 1.41 z M8 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M20.96 16.953 c0.026 -0.147 0.04 -0.298 0.04 -0.453 v-8.5 a2 2 0 0 0 -2 -2 h-9 m-4 0 h-1 a2 2 0 0 0 -2 2 v8.5 a2.5 2.5 0 0 0 2.5 2.5 h1.06 a3 3 0 0 0 2.34 -1.13 l1.54 -1.92 a2 2 0 0 1 3.12 0 l1.54 1.92 a3 3 0 0 0 2.34 1.13 h1.06 c0.155 0 0.307 -0.014 0.454 -0.041 M0 0 h24 v24 H0 z";
				case IconKind.Cardboards:
					return "M16 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M8 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M3 8 v8.5 a2.5 2.5 0 0 0 2.5 2.5 h1.06 a3 3 0 0 0 2.34 -1.13 l1.54 -1.92 a2 2 0 0 1 3.12 0 l1.54 1.92 a3 3 0 0 0 2.34 1.13 h1.06 a2.5 2.5 0 0 0 2.5 -2.5 v-8.5 a2 2 0 0 0 -2 -2 h-14 a2 2 0 0 0 -2 2 z M0 0 h24 v24 H0 z";
				case IconKind.Cards:
					return "M20 6 c0.264 0.112 0.52 0.217 0.768 0.315 a1 1 0 0 1 0.53 1.311 l-2.298 5.374 M15 4 h1 a1 1 0 0 1 1 1 v3.5 M3.604 7.197 l7.138 -3.109 a0.96 0.96 0 0 1 1.27 0.527 l4.924 11.902 a1 1 0 0 1 -0.514 1.304 l-7.137 3.109 a0.96 0.96 0 0 1 -1.271 -0.527 l-4.924 -11.903 a1 1 0 0 1 0.514 -1.304 z M0 0 h24 v24 H0 z";
				case IconKind.CaretDown:
					return "M6 10 l6 6 l6 -6 h-12 M0 0 h24 v24 H0 z";
				case IconKind.CaretLeft:
					return "M14 6 l-6 6 l6 6 v-12 M0 0 h24 v24 H0 z";
				case IconKind.CaretRight:
					return "M10 18 l6 -6 l-6 -6 v12 M0 0 h24 v24 H0 z";
				case IconKind.CaretUp:
					return "M18 14 l-6 -6 l-6 6 h12 M0 0 h24 v24 H0 z";
				case IconKind.CarouselHorizontal:
					return "M2 17 h1 a1 1 0 0 0 1 -1 v-8 a1 1 0 0 0 -1 -1 h-1 M22 17 h-1 a1 1 0 0 1 -1 -1 v-8 a1 1 0 0 1 1 -1 h1 M7 5 m0 1 a1 1 0 0 1 1 -1 h8 a1 1 0 0 1 1 1 v12 a1 1 0 0 1 -1 1 h-8 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.CarouselVertical:
					return "M17 2 v1 a1 1 0 0 1 -1 1 h-8 a1 1 0 0 1 -1 -1 v-1 M7 22 v-1 a1 1 0 0 1 1 -1 h8 a1 1 0 0 1 1 1 v1 M19 8 v8 a1 1 0 0 1 -1 1 h-12 a1 1 0 0 1 -1 -1 v-8 a1 1 0 0 1 1 -1 h12 a1 1 0 0 1 1 1 z M0 0 h24 v24 H0 z";
				case IconKind.CarrotOff:
					return "M3 3 l18 18 M16 2 s-2 1.14 -2 3 s2 3 2 3 s2 -1.577 2 -3 c0 -1.86 -2 -3 -2 -3 z M22 8 s-1.14 -2 -3 -2 c-1.406 0 -3 2 -3 2 s1.14 2 3 2 s3 -2 3 -2 z M9 13 l-1.5 -1.5 M8.868 8.846 c-2.756 3.382 -5.868 12.154 -5.868 12.154 s8.75 -3.104 12.134 -5.85 m1.667 -2.342 a4.486 4.486 0 0 0 -5.589 -5.615 M0 0 h24 v24 H0 z";
				case IconKind.Carrot:
					return "M16 2 s-2 1.14 -2 3 s2 3 2 3 s2 -1.577 2 -3 c0 -1.86 -2 -3 -2 -3 z M22 8 s-1.14 -2 -3 -2 c-1.406 0 -3 2 -3 2 s1.14 2 3 2 s3 -2 3 -2 z M16 14 l-2 -2 M9 13 l-1.5 -1.5 M3 21 s9.834 -3.489 12.684 -6.34 a4.487 4.487 0 0 0 0 -6.344 a4.483 4.483 0 0 0 -6.342 0 c-2.86 2.861 -6.347 12.689 -6.347 12.689 z M0 0 h24 v24 H0 z";
				case IconKind.CashBanknoteOff:
					return "M3 3 l18 18 M6 12 l0.01 0 M18 12 l0.01 0 M10 6 h9 a2 2 0 0 1 2 2 v8 c0 0.294 -0.064 0.574 -0.178 0.825 m-2.822 1.175 h-13 a2 2 0 0 1 -2 -2 v-8 a2 2 0 0 1 2 -2 h1 M9.88 9.878 a3 3 0 1 0 4.242 4.243 m0.58 -3.425 a3.012 3.012 0 0 0 -1.412 -1.405 M0 0 h24 v24 H0 z";
				case IconKind.CashBanknote:
					return "M6 12 l0.01 0 M18 12 l0.01 0 M3 6 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M12 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.CashOff:
					return "M3 3 l18 18 M17 9 v-2 a2 2 0 0 0 -2 -2 h-6 m-4 0 a2 2 0 0 0 -2 2 v6 a2 2 0 0 0 2 2 h2 M12.582 12.59 a2 2 0 0 0 2.83 2.826 M13 9 h6 a2 2 0 0 1 2 2 v6 m-2 2 h-10 a2 2 0 0 1 -2 -2 v-6 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.Cash:
					return "M17 9 v-2 a2 2 0 0 0 -2 -2 h-10 a2 2 0 0 0 -2 2 v6 a2 2 0 0 0 2 2 h2 M14 14 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M7 9 m0 2 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v6 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.CastOff:
					return "M3 3 l18 18 M15 19 h3 a3 3 0 0 0 0.875 -0.13 m2 -2 a3 3 0 0 0 0.128 -0.868 v-8 a3 3 0 0 0 -3 -3 h-9 m-3.865 0.136 a3 3 0 0 0 -1.935 1.864 M11 19 a8 8 0 0 0 -8 -8 M7 19 a4 4 0 0 0 -4 -4 M3 19 h0.01 M0 0 h24 v24 H0 z";
				case IconKind.Cast:
					return "M15 19 h3 a3 3 0 0 0 3 -3 v-8 a3 3 0 0 0 -3 -3 h-12 a3 3 0 0 0 -2.8 2 M11 19 a8 8 0 0 0 -8 -8 M7 19 a4 4 0 0 0 -4 -4 M3 19 l0.01 0 M0 0 h24 v24 H0 z";
				case IconKind.Cat:
					return "M15 11 v0.01 M9 11 v0.01 M12 16 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M22 16 h-5 l4 4 M2 16 h5 l-4 4 M20 3 v10 a8 8 0 1 1 -16 0 v-10 l3.432 3.432 a7.963 7.963 0 0 1 4.568 -1.432 c1.769 0 3.403 0.574 4.728 1.546 l3.272 -3.546 z M0 0 h24 v24 H0 z";
				case IconKind.Category2:
					return "M7 7 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M17 17 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M4 14 h6 v6 h-6 z M14 4 h6 v6 h-6 z M0 0 h24 v24 H0 z";
				case IconKind.Category:
					return "M17 17 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M4 14 h6 v6 h-6 z M14 4 h6 v6 h-6 z M4 4 h6 v6 h-6 z M0 0 h24 v24 H0 z";
				case IconKind.CeOff:
					return "M3 3 l18 18 M16 12 h4 M12 12 a8 8 0 0 0 8 8 M20 4 a8 8 0 0 0 -7.29 4.7 M5.867 5.864 a8 8 0 0 0 5.133 14.136 M11 4 a7.99 7.99 0 0 0 -2.581 0.426 M0 0 h24 v24 H0 z";
				case IconKind.Ce:
					return "M12 12 l8 0 M20 4 a8 8 0 1 0 0 16 M11 4 a8 8 0 1 0 0 16 M0 0 h24 v24 H0 z";
				case IconKind.CellSignal1:
					return "M20 20 h-15.269 a0.731 0.731 0 0 1 -0.517 -1.249 l14.537 -14.537 a0.731 0.731 0 0 1 1.249 0.517 v15.269 z M0 0 h24 v24 H0 z";
				case IconKind.CellSignal2:
					return "M8 20 v-5 M20 20 h-15.269 a0.731 0.731 0 0 1 -0.517 -1.249 l14.537 -14.537 a0.731 0.731 0 0 1 1.249 0.517 v15.269 z M0 0 h24 v24 H0 z";
				case IconKind.CellSignal3:
					return "M12 20 v-9 M20 20 h-15.269 a0.731 0.731 0 0 1 -0.517 -1.249 l14.537 -14.537 a0.731 0.731 0 0 1 1.249 0.517 v15.269 z M0 0 h24 v24 H0 z";
				case IconKind.CellSignal4:
					return "M16 7 v13 M20 20 h-15.269 a0.731 0.731 0 0 1 -0.517 -1.249 l14.537 -14.537 a0.731 0.731 0 0 1 1.249 0.517 v15.269 z M0 0 h24 v24 H0 z";
				case IconKind.CellSignal5:
					return "M8 20 v-5 M12 20 v-9 M16 7 v13 M20 20 h-15.269 a0.731 0.731 0 0 1 -0.517 -1.249 l14.537 -14.537 a0.731 0.731 0 0 1 1.249 0.517 v15.269 z M0 0 h24 v24 H0 z";
				case IconKind.CellSignalOff:
					return "M3 3 l18 18 M20 20 h-15.269 a0.731 0.731 0 0 1 -0.517 -1.249 l7.265 -7.264 m2 -2 l5.272 -5.272 a0.731 0.731 0 0 1 1.249 0.517 v11.269 M0 0 h24 v24 H0 z";
				case IconKind.Cell:
					return "M8 13 v5 l4 2 l4 -2 v-5 M12 11 l4 2 l4 -2 v-5 l-4 -2 l-4 2 M8 4 l-4 2 v5 l4 2 l4 -2 v-5 z M0 0 h24 v24 H0 z";
				case IconKind.Certificate2Off:
					return "M3 3 l18 18 M10 19 h-2 a2 2 0 0 1 -2 -2 v-11 m1.18 -2.825 c0.25 -0.112 0.529 -0.175 0.82 -0.175 h8 a2 2 0 0 1 2 2 v9 m-0.175 3.82 a2 2 0 0 1 -1.825 1.18 h-2 M10 18 v4 l2 -1 l2 1 v-4 M11 7 h3 M12 12 a3 3 0 1 0 3 3 M0 0 h24 v24 H0 z";
				case IconKind.Certificate2:
					return "M10 19 h-2 a2 2 0 0 1 -2 -2 v-12 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-2 M10 18 v4 l2 -1 l2 1 v-4 M10 7 h4 M12 15 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.CertificateOff:
					return "M3 3 l18 18 M6 15 h2 M6 12 h3 M6 9 h3 m4 0 h5 M10 19 h-5 a2 2 0 0 1 -2 -2 v-10 c0 -1.1 0.9 -2 2 -2 m4 0 h10 a2 2 0 0 1 2 2 v10 M13 17.5 v4.5 l2 -1.5 l2 1.5 v-4.5 M12.876 12.881 a3 3 0 0 0 4.243 4.243 m0.588 -3.42 a3.012 3.012 0 0 0 -1.437 -1.423 M0 0 h24 v24 H0 z";
				case IconKind.Certificate:
					return "M6 15 l2 0 M6 12 l3 0 M6 9 l12 0 M10 19 h-5 a2 2 0 0 1 -2 -2 v-10 c0 -1.1 0.9 -2 2 -2 h14 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -1 1.73 M13 17.5 v4.5 l2 -1.5 l2 1.5 v-4.5 M15 15 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.ChairDirector:
					return "M6 5 h12 M6 8 h12 M18 3 v9 M6 3 v9 M5 12 h14 M6 12 l12 9 M6 21 l12 -9 M0 0 h24 v24 H0 z";
				case IconKind.ChalkboardOff:
					return "M3 3 l18 18 M17 17 v1 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 v-1 a1 1 0 0 1 1 -1 h4 M8 19 h-3 a2 2 0 0 1 -2 -2 v-10 a2 2 0 0 1 2 -2 m4 0 h10 a2 2 0 0 1 2 2 v10 M0 0 h24 v24 H0 z";
				case IconKind.Chalkboard:
					return "M11 16 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v1 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M8 19 h-3 a2 2 0 0 1 -2 -2 v-10 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v11 a1 1 0 0 1 -1 1 M0 0 h24 v24 H0 z";
				case IconKind.ChargingPile:
					return "M4 8 l10 0 M3 20 l12 0 M9 11.5 l-1.5 2.5 h3 l-1.5 2.5 M4 20 v-14 a2 2 0 0 1 2 -2 h6 a2 2 0 0 1 2 2 v14 M14 11 h1 a2 2 0 0 1 2 2 v3 a1.5 1.5 0 0 0 3 0 v-7 l-3 -3 M18 7 l-1 1 M0 0 h24 v24 H0 z";
				case IconKind.ChartArcs3:
					return "M6.29 18.957 a9 9 0 1 0 5.71 -15.957 M7 12 a5 5 0 1 0 5 -5 M12 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.ChartArcs:
					return "M3 12 a9 9 0 1 0 9 -9 M16.924 11.132 a5 5 0 1 0 -4.056 5.792 M12 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.ChartAreaFilled:
					return "M4 15 l4 -6 l4 2 l4 -5 l4 4 l0 5 l-16 0 M4 19 l16 0 M0 0 h24 v24 H0 z";
				case IconKind.ChartAreaLineFilled:
					return "M4 12 l3 -4 l4 2 l5 -6 l4 4 M4 19 l4 -6 l4 2 l4 -5 l4 4 l0 5 l-16 0 M0 0 h24 v24 H0 z";
				case IconKind.ChartAreaLine:
					return "M4 12 l3 -4 l4 2 l5 -6 l4 4 M4 19 l4 -6 l4 2 l4 -5 l4 4 l0 5 l-16 0 M0 0 h24 v24 H0 z";
				case IconKind.ChartArea:
					return "M4 15 l4 -6 l4 2 l4 -5 l4 4 l0 5 l-16 0 M4 19 l16 0 M0 0 h24 v24 H0 z";
				case IconKind.ChartArrowsVertical:
					return "M6 21 v-18 M3 6 l3 -3 l3 3 M12 21 l0 -9 M3 21 l18 0 M15 10 l3 -3 l3 3 M9 15 l3 -3 l3 3 M18 21 v-14 M0 0 h24 v24 H0 z";
				case IconKind.ChartArrows:
					return "M3 6 l18 0 M18 3 l3 3 l-3 3 M3 12 l9 0 M3 3 l0 18 M14 15 l3 3 l-3 3 M9 9 l3 3 l-3 3 M3 18 l14 0 M0 0 h24 v24 H0 z";
				case IconKind.ChartBarOff:
					return "M3 3 l18 18 M4 20 h14 M15 11 v-6 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v12 m-1 3 h-4 a1 1 0 0 1 -1 -1 v-4 M12 8 h2 a1 1 0 0 1 1 1 v2 m0 4 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 v-10 M3 12 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v6 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.ChartBar:
					return "M4 20 l14 0 M15 4 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v14 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M9 8 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v10 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M3 12 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v6 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.ChartBubbleFilled:
					return "M14.5 7.5 m-4.5 0 a4.5 4.5 0 1 0 9 0 a4.5 4.5 0 1 0 -9 0 M16 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 16 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.ChartBubble:
					return "M14.5 7.5 m-4.5 0 a4.5 4.5 0 1 0 9 0 a4.5 4.5 0 1 0 -9 0 M16 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 16 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.ChartCandleFilled:
					return "M18 11 l0 9 M18 4 l0 1 M16 5 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M12 19 l0 1 M12 4 l0 10 M10 14 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v3 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M6 11 l0 9 M6 4 l0 2 M4 6 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v3 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.ChartCandle:
					return "M18 11 l0 9 M18 4 l0 1 M16 5 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M12 19 l0 1 M12 4 l0 10 M10 14 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v3 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M6 11 l0 9 M6 4 l0 2 M4 6 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v3 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.ChartCircles:
					return "M14.5 14.5 m-5.5 0 a5.5 5.5 0 1 0 11 0 a5.5 5.5 0 1 0 -11 0 M9.5 9.5 m-5.5 0 a5.5 5.5 0 1 0 11 0 a5.5 5.5 0 1 0 -11 0 M0 0 h24 v24 H0 z";
				case IconKind.ChartDonut2:
					return "M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M12 12 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M12 3 v5 m4 4 h5 M0 0 h24 v24 H0 z";
				case IconKind.ChartDonut3:
					return "M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M12 12 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M8.929 14.582 l-3.429 2.918 M12 3 v5 m4 4 h5 M0 0 h24 v24 H0 z";
				case IconKind.ChartDonut4:
					return "M12 12 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M14.219 15.328 l2.781 4.172 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M12 3 v5 m4 4 h5 M8.848 14.667 l-3.348 2.833 M0 0 h24 v24 H0 z";
				case IconKind.ChartDonutFilled:
					return "M15 3.5 a9 9 0 0 1 5.5 5.5 h-4.5 a9 9 0 0 0 -1 -1 v-4.5 M10 3.2 a9 9 0 1 0 10.8 10.8 a1 1 0 0 0 -1 -1 h-3.8 a4.1 4.1 0 1 1 -5 -5 v-4 a0.9 0.9 0 0 0 -1 -0.8 M0 0 h24 v24 H0 z";
				case IconKind.ChartDonut:
					return "M15 3.5 a9 9 0 0 1 5.5 5.5 h-4.5 a9 9 0 0 0 -1 -1 v-4.5 M10 3.2 a9 9 0 1 0 10.8 10.8 a1 1 0 0 0 -1 -1 h-3.8 a4.1 4.1 0 1 1 -5 -5 v-4 a0.9 0.9 0 0 0 -1 -0.8 M0 0 h24 v24 H0 z";
				case IconKind.ChartDots2:
					return "M16 12.5 l-5 2 M14.113 6.65 l2.771 3.695 M21 3 l-6 1.5 M18 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M13 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M9 15 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M3 3 v18 h18 M0 0 h24 v24 H0 z";
				case IconKind.ChartDots3:
					return "M7 7 l8 -1 M6.5 8.5 l7.81 5.37 M9 17 l5 -1.5 M6 18 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M18 6 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M16 15 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 7 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.ChartDots:
					return "M15.088 13.328 l2.837 -4.586 M10.16 10.62 l2.34 2.88 M14 15 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M19 7 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M9 9 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M3 3 v18 h18 M0 0 h24 v24 H0 z";
				case IconKind.ChartGridDots:
					return "M6 14 v2 M3 18 h1 M20 18 h1 M3 12 h1 M16 6 h-13 M21 6 h-1 M8 12 h13 M18 8 v8 M12 3 v18 M6 10 v-7 M6 20 v1 M18 3 v1 M18 20 v1 M8 18 h8 M18 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M18 6 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.ChartHistogram:
					return "M3 11 c6 0 5 -5 9 -5 s3 5 9 5 M8 16 v5 M12 13 v8 M16 16 v5 M20 18 v3 M3 3 v18 h18 M0 0 h24 v24 H0 z";
				case IconKind.ChartInfographic:
					return "M21 12 l0 9 M13 13 l0 8 M17 14 l0 7 M9 17 l0 4 M7 3 v4 h4 M7 7 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M0 0 h24 v24 H0 z";
				case IconKind.ChartLine:
					return "M4 15 l4 -6 l4 2 l4 -5 l4 4 M4 19 l16 0 M0 0 h24 v24 H0 z";
				case IconKind.ChartPie2:
					return "M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M12 3 v9 h9 M0 0 h24 v24 H0 z";
				case IconKind.ChartPie3:
					return "M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M12 3 v9 h9 M12 12 l-6.5 5.5 M0 0 h24 v24 H0 z";
				case IconKind.ChartPie4:
					return "M12 12 l5 7.5 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M12 3 v9 h9 M12 12 l-6.5 5.5 M0 0 h24 v24 H0 z";
				case IconKind.ChartPieFilled:
					return "M15 3.5 a9 9 0 0 1 5.5 5.5 h-4.5 a1 1 0 0 1 -1 -1 v-4.5 M10 3.2 a9 9 0 1 0 10.8 10.8 a1 1 0 0 0 -1 -1 h-6.8 a2 2 0 0 1 -2 -2 v-7 a0.9 0.9 0 0 0 -1 -0.8 M0 0 h24 v24 H0 z";
				case IconKind.ChartPieOff:
					return "M3 3 l18 18 M15 3.5 a9 9 0 0 1 5.5 5.5 h-4.5 a1 1 0 0 1 -1 -1 v-4.5 M5.63 5.643 a9 9 0 0 0 12.742 12.715 m1.674 -2.29 a9.03 9.03 0 0 0 0.754 -2.068 a1 1 0 0 0 -1 -1 h-2.8 m-4 0 a2 2 0 0 1 -2 -2 m0 -4 v-3 a0.9 0.9 0 0 0 -1 -0.8 a9 9 0 0 0 -2.057 0.749 M0 0 h24 v24 H0 z";
				case IconKind.ChartPie:
					return "M15 3.5 a9 9 0 0 1 5.5 5.5 h-4.5 a1 1 0 0 1 -1 -1 v-4.5 M10 3.2 a9 9 0 1 0 10.8 10.8 a1 1 0 0 0 -1 -1 h-6.8 a2 2 0 0 1 -2 -2 v-7 a0.9 0.9 0 0 0 -1 -0.8 M0 0 h24 v24 H0 z";
				case IconKind.ChartPpf:
					return "M3 3 v18 h18 M19 17 c0 -6.075 -5.373 -11 -12 -11 M0 0 h24 v24 H0 z";
				case IconKind.ChartRadar:
					return "M6 21 l6 -8 M12 3 v10 l6 8 M2.5 10 l9.5 3 l9.5 -3 M12 7.5 l5.5 4 l-2.5 5.5 h-6.5 l-2 -5.5 z M12 3 l9.5 7 l-3.5 11 h-12 l-3.5 -11 z M0 0 h24 v24 H0 z";
				case IconKind.ChartSankey:
					return "M3 8 c10 0 8 9 18 9 M3 6 h18 M3 3 v18 h18 M0 0 h24 v24 H0 z";
				case IconKind.ChartTreemap:
					return "M16 16 h4 M16 12 v8 M12 12 h8 M4 15 h8 M12 4 v16 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Check:
					return "M5 12 l5 5 l10 -10 M0 0 h24 v24 H0 z";
				case IconKind.Checkbox:
					return "M20 12 v6 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 v-12 a2 2 0 0 1 2 -2 h9 M9 11 l3 3 l8 -8 M0 0 h24 v24 H0 z";
				case IconKind.Checklist:
					return "M9 12 h2 M9 8 h4 M14 19 l2 2 l4 -4 M9.615 20 h-2.615 a2 2 0 0 1 -2 -2 v-12 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v8 M0 0 h24 v24 H0 z";
				case IconKind.Checks:
					return "M2 12 l5 5 m5 -5 l5 -5 M7 12 l5 5 l10 -10 M0 0 h24 v24 H0 z";
				case IconKind.CheckupList:
					return "M12 16 l1 1 l3 -3 M9 17 h0.01 M9 14 h0.01 M9 3 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v0 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M9 5 h-2 a2 2 0 0 0 -2 2 v12 a2 2 0 0 0 2 2 h10 a2 2 0 0 0 2 -2 v-12 a2 2 0 0 0 -2 -2 h-2 M0 0 h24 v24 H0 z";
				case IconKind.Cheese:
					return "M11 16 v0.01 M8 13 v0.01 M15 13 v0.01 M21 9 l-9.385 -4.992 c-2.512 0.12 -4.758 1.42 -6.327 3.425 c-1.423 1.82 -2.288 4.221 -2.288 6.854 c0 2.117 0.56 4.085 1.519 5.721 M4.519 20.008 l16.481 -0.008 v-3.5 a2 2 0 1 1 0 -4 v-3.5 h-16.722 M0 0 h24 v24 H0 z";
				case IconKind.ChefHatOff:
					return "M3 3 l18 18 M6.161 17.009 l10.839 -0.009 M8.72 4.712 a4 4 0 0 1 7.19 1.439 a4 4 0 0 1 2.09 7.723 v0.126 m0 4 v3 h-12 v-7.126 a4 4 0 0 1 0.081 -7.796 M0 0 h24 v24 H0 z";
				case IconKind.ChefHat:
					return "M6.161 17.009 l11.839 -0.009 M12 3 c1.918 0 3.52 1.35 3.91 3.151 a4 4 0 0 1 2.09 7.723 l0 7.126 h-12 v-7.126 a4 4 0 1 1 2.092 -7.723 a4 4 0 0 1 3.908 -3.151 z M0 0 h24 v24 H0 z";
				case IconKind.Cherry:
					return "M5 6 c3.667 -2.667 7.333 -2.667 11 0 c-3.667 2.667 -7.333 2.667 -11 0 M17 15 c-1.333 -2.333 -2.333 -5.333 -1 -9 M9 13 c0.366 -2 1.866 -3.873 4.5 -5.6 M17 18 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M7.5 16.5 m-3.5 0 a3.5 3.5 0 1 0 7 0 a3.5 3.5 0 1 0 -7 0 M0 0 h24 v24 H0 z";
				case IconKind.ChessBishop:
					return "M12 5 v1 M15 8 l-3 3 M9.5 16 c-1.667 0 -2.5 -1.669 -2.5 -3 c0 -3.667 1.667 -6 5 -7 c3.333 1 5 3.427 5 7 c0 1.284 -0.775 2.881 -2.325 3 l-0.175 0 h-5 z M12 4 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M8 16 l-1.447 0.724 a1 1 0 0 0 -0.553 0.894 v2.382 h12 v-2.382 a1 1 0 0 0 -0.553 -0.894 l-1.447 -0.724 h-8 z M0 0 h24 v24 H0 z";
				case IconKind.ChessKing:
					return "M12 3 v8 M9 6 h6 M8.5 16 a3.5 3.5 0 1 1 3.163 -5 h0.674 a3.5 3.5 0 1 1 3.163 5 z M8 16 l-1.447 0.724 a1 1 0 0 0 -0.553 0.894 v2.382 h12 v-2.382 a1 1 0 0 0 -0.553 -0.894 l-1.447 -0.724 h-8 z M0 0 h24 v24 H0 z";
				case IconKind.ChessKnight:
					return "M9 3 l1 3 l-3.491 2.148 a1 1 0 0 0 0.524 1.852 h2.967 l-2.073 6 h7.961 l0.112 -5 c0 -3 -1.09 -5.983 -4 -7 c-1.94 -0.678 -2.94 -1.011 -3 -1 z M8 16 l-1.447 0.724 a1 1 0 0 0 -0.553 0.894 v2.382 h12 v-2.382 a1 1 0 0 0 -0.553 -0.894 l-1.447 -0.724 h-8 z M0 0 h24 v24 H0 z";
				case IconKind.ChessQueen:
					return "M18 5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M6 5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12 4 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M8 16 l-1.447 0.724 a1 1 0 0 0 -0.553 0.894 v2.382 h12 v-2.382 a1 1 0 0 0 -0.553 -0.894 l-1.447 -0.724 h-8 z M16 16 l2 -11 l-4 4 l-2 -5 l-2 5 l-4 -4 l2 11 M0 0 h24 v24 H0 z";
				case IconKind.ChessRook:
					return "M14 4 v3 M10 4 v3 M6 4 l0.5 3 h11 l0.5 -3 M8 16 l1 -9 h6 l1 9 M8 16 l-1.447 0.724 a1 1 0 0 0 -0.553 0.894 v2.382 h12 v-2.382 a1 1 0 0 0 -0.553 -0.894 l-1.447 -0.724 h-8 z M0 0 h24 v24 H0 z";
				case IconKind.Chess:
					return "M6.684 16.772 a1 1 0 0 0 -0.684 0.949 v1.279 a1 1 0 0 0 1 1 h10 a1 1 0 0 0 1 -1 v-1.28 a1 1 0 0 0 -0.684 -0.948 l-2.316 -0.772 h-6 l-2.316 0.772 z M8 9 h8 M12 3 a3 3 0 0 1 3 3 c0 1.113 -0.6 2.482 -1.5 3 l1.5 7 h-6 l1.5 -7 c-0.9 -0.518 -1.5 -1.887 -1.5 -3 a3 3 0 0 1 3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.ChevronDownLeft:
					return "M8 8 v8 h8 M0 0 h24 v24 H0 z";
				case IconKind.ChevronDownRight:
					return "M16 8 v8 h-8 M0 0 h24 v24 H0 z";
				case IconKind.ChevronDown:
					return "M6 9 l6 6 l6 -6 M0 0 h24 v24 H0 z";
				case IconKind.ChevronLeft:
					return "M15 6 l-6 6 l6 6 M0 0 h24 v24 H0 z";
				case IconKind.ChevronRight:
					return "M9 6 l6 6 l-6 6 M0 0 h24 v24 H0 z";
				case IconKind.ChevronUpLeft:
					return "M8 16 v-8 h8 M0 0 h24 v24 H0 z";
				case IconKind.ChevronUpRight:
					return "M8 8 h8 v8 M0 0 h24 v24 H0 z";
				case IconKind.ChevronUp:
					return "M6 15 l6 -6 l6 6 M0 0 h24 v24 H0 z";
				case IconKind.ChevronsDownLeft:
					return "M7 9 v8 h8 M11 5 v8 h8 M0 0 h24 v24 H0 z";
				case IconKind.ChevronsDownRight:
					return "M17 9 v8 h-8 M13 5 v8 h-8 M0 0 h24 v24 H0 z";
				case IconKind.ChevronsDown:
					return "M7 13 l5 5 l5 -5 M7 7 l5 5 l5 -5 M0 0 h24 v24 H0 z";
				case IconKind.ChevronsLeft:
					return "M17 7 l-5 5 l5 5 M11 7 l-5 5 l5 5 M0 0 h24 v24 H0 z";
				case IconKind.ChevronsRight:
					return "M13 7 l5 5 l-5 5 M7 7 l5 5 l-5 5 M0 0 h24 v24 H0 z";
				case IconKind.ChevronsUpLeft:
					return "M11 19 v-8 h8 M7 15 v-8 h8 M0 0 h24 v24 H0 z";
				case IconKind.ChevronsUpRight:
					return "M5 11 h8 v8 M9 7 h8 v8 M0 0 h24 v24 H0 z";
				case IconKind.ChevronsUp:
					return "M7 17 l5 -5 l5 5 M7 11 l5 -5 l5 5 M0 0 h24 v24 H0 z";
				case IconKind.Chisel:
					return "M3 6 l3 -3 l7.414 7.414 a2 2 0 0 1 0.586 1.414 v2.172 h-2.172 a2 2 0 0 1 -1.414 -0.586 l-7.414 -7.414 z M18.347 15.575 l2.08 2.079 a1.96 1.96 0 0 1 -2.773 2.772 l-2.08 -2.079 a1.96 1.96 0 0 1 2.773 -2.772 z M14 14 l1.5 1.5 M0 0 h24 v24 H0 z";
				case IconKind.ChristmasTreeOff:
					return "M3 3 l18 18 M14 17 v3 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 v-3 M9.5 5.5 l2.5 -2.5 l4 4 l-2 1 l4 4 l-1.5 0.5 m0.5 4.5 h-12 l4 -4 l-3 -1 l3 -3 M0 0 h24 v24 H0 z";
				case IconKind.ChristmasTree:
					return "M14 17 v3 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 v-3 M12 3 l4 4 l-2 1 l4 4 l-3 1 l4 4 h-14 l4 -4 l-3 -1 l4 -4 l-2 -1 z M0 0 h24 v24 H0 z";
				case IconKind.CircleArrowDownFilled:
					return "M17 3.34 a10 10 0 1 1 -14.995 8.984 l-0.005 -0.324 l0.005 -0.324 a10 10 0 0 1 14.995 -8.336 z m-5 3.66 a1 1 0 0 0 -1 1 v5.585 l-2.293 -2.292 l-0.094 -0.083 a1 1 0 0 0 -1.32 1.497 l4 4 c0.028 0.028 0.057 0.054 0.094 0.083 l0.092 0.064 l0.098 0.052 l0.081 0.034 l0.113 0.034 l0.112 0.02 l0.117 0.006 l0.115 -0.007 l0.114 -0.02 l0.142 -0.044 l0.113 -0.054 l0.111 -0.071 a0.939 0.939 0 0 0 0.112 -0.097 l4 -4 l0.083 -0.094 a1 1 0 0 0 -1.497 -1.32 l-2.293 2.291 v-5.584 l-0.007 -0.117 a1 1 0 0 0 -0.993 -0.883 z M0 0 h24 v24 H0 z";
				case IconKind.CircleArrowDownLeftFilled:
					return "M17 3.34 a10 10 0 1 1 -14.995 8.984 l-0.005 -0.324 l0.005 -0.324 a10 10 0 0 1 14.995 -8.336 z m-8 4.66 a1 1 0 0 0 -1 1 v6 l0.007 0.117 l0.029 0.149 l0.035 0.105 l0.054 0.113 l0.071 0.111 c0.03 0.04 0.061 0.077 0.097 0.112 l0.09 0.08 l0.096 0.067 l0.098 0.052 l0.11 0.044 l0.112 0.03 l0.126 0.017 l6.075 0.003 l0.117 -0.007 a1 1 0 0 0 0.883 -0.993 l-0.007 -0.117 a1 1 0 0 0 -0.993 -0.883 h-3.586 l4.293 -4.293 l0.083 -0.094 a1 1 0 0 0 -1.497 -1.32 l-4.293 4.291 v-3.584 l-0.007 -0.117 a1 1 0 0 0 -0.993 -0.883 z M0 0 h24 v24 H0 z";
				case IconKind.CircleArrowDownLeft:
					return "M15 15 h-6 v-6 M15 9 l-6 6 M3 12 a9 9 0 1 0 18 0 a9 9 0 0 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleArrowDownRightFilled:
					return "M17 3.34 a10 10 0 1 1 -14.995 8.984 l-0.005 -0.324 l0.005 -0.324 a10 10 0 0 1 14.995 -8.336 z m-2 4.66 l-0.117 0.007 a1 1 0 0 0 -0.883 0.993 v3.585 l-4.293 -4.292 l-0.094 -0.083 a1 1 0 0 0 -1.32 1.497 l4.292 4.293 h-3.585 l-0.117 0.007 a1 1 0 0 0 0.117 1.993 l6.034 0.001 a0.998 0.998 0 0 0 0.186 -0.025 l0.053 -0.014 l0.066 -0.02 l0.13 -0.059 l0.093 -0.055 a0.98 0.98 0 0 0 0.438 -0.828 v-6 l-0.007 -0.117 a1 1 0 0 0 -0.993 -0.883 z M0 0 h24 v24 H0 z";
				case IconKind.CircleArrowDownRight:
					return "M15 9 v6 l-6 -6 M15 15 h-6 M3 12 a9 9 0 1 0 18 0 a9 9 0 0 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleArrowDown:
					return "M16 12 l-4 4 M12 8 v8 M8 12 l4 4 M3 12 a9 9 0 1 0 18 0 a9 9 0 0 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleArrowLeftFilled:
					return "M12 2 a10 10 0 0 1 0.324 19.995 l-0.324 0.005 l-0.324 -0.005 a10 10 0 0 1 0.324 -19.995 z m0.707 5.293 a1 1 0 0 0 -1.414 0 l-4 4 a1.048 1.048 0 0 0 -0.083 0.094 l-0.064 0.092 l-0.052 0.098 l-0.044 0.11 l-0.03 0.112 l-0.017 0.126 l-0.003 0.075 l0.004 0.09 l0.007 0.058 l0.025 0.118 l0.035 0.105 l0.054 0.113 l0.043 0.07 l0.071 0.095 l0.054 0.058 l4 4 l0.094 0.083 a1 1 0 0 0 1.32 -1.497 l-2.292 -2.293 h5.585 l0.117 -0.007 a1 1 0 0 0 -0.117 -1.993 h-5.586 l2.293 -2.293 l0.083 -0.094 a1 1 0 0 0 -0.083 -1.32 z M0 0 h24 v24 H0 z";
				case IconKind.CircleArrowLeft:
					return "M12 8 l-4 4 M8 12 h8 M8 12 l4 4 M12 21 a9 9 0 1 0 0 -18 a9 9 0 0 0 0 18 M0 0 h24 v24 H0 z";
				case IconKind.CircleArrowRightFilled:
					return "M12 2 l0.324 0.005 a10 10 0 1 1 -0.648 0 l0.324 -0.005 z m0.613 5.21 a1 1 0 0 0 -1.32 1.497 l2.291 2.293 h-5.584 l-0.117 0.007 a1 1 0 0 0 0.117 1.993 h5.584 l-2.291 2.293 l-0.083 0.094 a1 1 0 0 0 1.497 1.32 l4 -4 l0.073 -0.082 l0.064 -0.089 l0.062 -0.113 l0.044 -0.11 l0.03 -0.112 l0.017 -0.126 l0.003 -0.075 l-0.007 -0.118 l-0.029 -0.148 l-0.035 -0.105 l-0.054 -0.113 l-0.071 -0.111 a1.008 1.008 0 0 0 -0.097 -0.112 l-4 -4 z M0 0 h24 v24 H0 z";
				case IconKind.CircleArrowRight:
					return "M12 16 l4 -4 M16 12 h-8 M16 12 l-4 -4 M12 3 a9 9 0 1 0 0 18 a9 9 0 0 0 0 -18 M0 0 h24 v24 H0 z";
				case IconKind.CircleArrowUpFilled:
					return "M17 3.34 a10 10 0 1 1 -14.995 8.984 l-0.005 -0.324 l0.005 -0.324 a10 10 0 0 1 14.995 -8.336 z m-4.98 3.66 l-0.163 0.01 l-0.086 0.016 l-0.142 0.045 l-0.113 0.054 l-0.07 0.043 l-0.095 0.071 l-0.058 0.054 l-4 4 l-0.083 0.094 a1 1 0 0 0 1.497 1.32 l2.293 -2.293 v5.586 l0.007 0.117 a1 1 0 0 0 1.993 -0.117 v-5.585 l2.293 2.292 l0.094 0.083 a1 1 0 0 0 1.32 -1.497 l-4 -4 l-0.082 -0.073 l-0.089 -0.064 l-0.113 -0.062 l-0.081 -0.034 l-0.113 -0.034 l-0.112 -0.02 l-0.098 -0.006 z M0 0 h24 v24 H0 z";
				case IconKind.CircleArrowUpLeftFilled:
					return "M17 3.34 a10 10 0 1 1 -14.995 8.984 l-0.005 -0.324 l0.005 -0.324 a10 10 0 0 1 14.995 -8.336 z m-2 4.66 h-6 l-0.117 0.007 l-0.149 0.029 l-0.105 0.035 l-0.113 0.054 l-0.111 0.071 a1.01 1.01 0 0 0 -0.112 0.097 l-0.08 0.09 l-0.067 0.096 l-0.052 0.098 l-0.044 0.11 l-0.03 0.112 l-0.017 0.126 l-0.003 6.075 l0.007 0.117 a1 1 0 0 0 0.993 0.883 l0.117 -0.007 a1 1 0 0 0 0.883 -0.993 v-3.585 l4.293 4.292 l0.094 0.083 a1 1 0 0 0 1.32 -1.497 l-4.292 -4.293 h3.585 l0.117 -0.007 a1 1 0 0 0 -0.117 -1.993 z M0 0 h24 v24 H0 z";
				case IconKind.CircleArrowUpLeft:
					return "M15 9 h-6 v6 M9 9 l6 6 M3 12 a9 9 0 1 0 18 0 a9 9 0 0 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleArrowUpRightFilled:
					return "M17 3.34 a10 10 0 1 1 -14.995 8.984 l-0.005 -0.324 l0.005 -0.324 a10 10 0 0 1 14.995 -8.336 z m-2 4.66 h-6 l-0.117 0.007 a1 1 0 0 0 -0.883 0.993 l0.007 0.117 a1 1 0 0 0 0.993 0.883 h3.584 l-4.291 4.293 l-0.083 0.094 a1 1 0 0 0 1.497 1.32 l4.293 -4.293 v3.586 l0.007 0.117 a1 1 0 0 0 1.993 -0.117 v-6 l-0.007 -0.117 l-0.029 -0.149 l-0.035 -0.105 l-0.054 -0.113 l-0.071 -0.111 a1.01 1.01 0 0 0 -0.097 -0.112 l-0.09 -0.08 l-0.096 -0.067 l-0.098 -0.052 l-0.11 -0.044 l-0.112 -0.03 l-0.126 -0.017 l-0.075 -0.003 z M0 0 h24 v24 H0 z";
				case IconKind.CircleArrowUpRight:
					return "M15 15 v-6 h-6 M15 9 l-6 6 M3 12 a9 9 0 1 0 18 0 a9 9 0 0 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleArrowUp:
					return "M16 12 l-4 -4 M12 8 v8 M12 8 l-4 4 M3 12 a9 9 0 1 0 18 0 a9 9 0 0 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleCaretDown:
					return "M12 15 l-4 -4 h8 z M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleCaretLeft:
					return "M12 21 a9 9 0 1 1 0 -18 a9 9 0 0 1 0 18 z M9 12 l4 -4 v8 z M0 0 h24 v24 H0 z";
				case IconKind.CircleCaretRight:
					return "M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M15 12 l-4 -4 v8 z M0 0 h24 v24 H0 z";
				case IconKind.CircleCaretUp:
					return "M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M12 9 l4 4 h-8 z M0 0 h24 v24 H0 z";
				case IconKind.CircleCheckFilled:
					return "M17 3.34 a10 10 0 1 1 -14.995 8.984 l-0.005 -0.324 l0.005 -0.324 a10 10 0 0 1 14.995 -8.336 z m-1.293 5.953 a1 1 0 0 0 -1.32 -0.083 l-0.094 0.083 l-3.293 3.292 l-1.293 -1.292 l-0.094 -0.083 a1 1 0 0 0 -1.403 1.403 l0.083 0.094 l2 2 l0.094 0.083 a1 1 0 0 0 1.226 0 l0.094 -0.083 l4 -4 l0.083 -0.094 a1 1 0 0 0 -0.083 -1.32 z M0 0 h24 v24 H0 z";
				case IconKind.CircleCheck:
					return "M9 12 l2 2 l4 -4 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleChevronDown:
					return "M12 3 a9 9 0 1 0 0 18 a9 9 0 0 0 0 -18 z M15 11 l-3 3 l-3 -3 M0 0 h24 v24 H0 z";
				case IconKind.CircleChevronLeft:
					return "M21 12 a9 9 0 1 0 -18 0 a9 9 0 0 0 18 0 z M13 15 l-3 -3 l3 -3 M0 0 h24 v24 H0 z";
				case IconKind.CircleChevronRight:
					return "M3 12 a9 9 0 1 0 18 0 a9 9 0 0 0 -18 0 z M11 9 l3 3 l-3 3 M0 0 h24 v24 H0 z";
				case IconKind.CircleChevronUp:
					return "M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M9 13 l3 -3 l3 3 M0 0 h24 v24 H0 z";
				case IconKind.CircleChevronsDown:
					return "M12 3 a9 9 0 1 0 0 18 a9 9 0 0 0 0 -18 z M15 13 l-3 3 l-3 -3 M15 9 l-3 3 l-3 -3 M0 0 h24 v24 H0 z";
				case IconKind.CircleChevronsLeft:
					return "M21 12 a9 9 0 1 0 0 0.265 l0 -0.265 z M11 15 l-3 -3 l3 -3 M15 15 l-3 -3 l3 -3 M0 0 h24 v24 H0 z";
				case IconKind.CircleChevronsRight:
					return "M3 12 a9 9 0 1 0 0 -0.265 l0 0.265 z M13 9 l3 3 l-3 3 M9 9 l3 3 l-3 3 M0 0 h24 v24 H0 z";
				case IconKind.CircleChevronsUp:
					return "M12 21 a9 9 0 1 0 -0.265 0 l0.265 0 z M9 11 l3 -3 l3 3 M9 15 l3 -3 l3 3 M0 0 h24 v24 H0 z";
				case IconKind.CircleDashed:
					return "M15.44 3.69 a9 9 0 0 0 -3.44 -0.69 M20.31 8.56 a9 9 0 0 0 -1.95 -2.92 M20.31 15.44 a9 9 0 0 0 0.69 -3.44 M15.44 20.31 a9 9 0 0 0 2.92 -1.95 M8.56 20.31 a9 9 0 0 0 3.44 0.69 M3.69 15.44 a9 9 0 0 0 1.95 2.92 M3.69 8.56 a9 9 0 0 0 -0.69 3.44 M8.56 3.69 a9 9 0 0 0 -2.92 1.95 M0 0 h24 v24 H0 z";
				case IconKind.CircleDotFilled:
					return "M17 3.34 a10 10 0 1 1 -14.995 8.984 l-0.005 -0.324 l0.005 -0.324 a10 10 0 0 1 14.995 -8.336 z m-5 6.66 a2 2 0 0 0 -1.977 1.697 l-0.018 0.154 l-0.005 0.149 l0.005 0.15 a2 2 0 1 0 1.995 -2.15 z M0 0 h24 v24 H0 z";
				case IconKind.CircleDot:
					return "M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M12 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleDotted:
					return "M12 3 l0 0.01 M16.5 4.21 l0 0.01 M19.79 7.5 l0 0.01 M21 12 l0 0.01 M19.79 16.5 l0 0.01 M16.5 19.79 l0 0.01 M12 21 l0 0.01 M7.5 19.79 l0 0.01 M4.21 16.5 l0 0.01 M3 12 l0 0.01 M4.21 7.5 l0 0.01 M7.5 4.21 l0 0.01 M0 0 h24 v24 H0 z";
				case IconKind.CircleFilled:
					return "M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleHalf2:
					return "M12 9 l4.5 -4.5 M12 19 l8.5 -8.5 M12 14 l7 -7 M12 3 v18 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleHalfVertical:
					return "M3 12 h18 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleHalf:
					return "M12 3 v18 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleKeyFilled:
					return "M12 2 c5.523 0 10 4.477 10 10 a10 10 0 0 1 -20 0 c0 -5.523 4.477 -10 10 -10 z m2 5 a3 3 0 0 0 -2.98 2.65 l-0.015 0.174 l-0.005 0.176 l0.005 0.176 c0.019 0.319 0.087 0.624 0.197 0.908 l0.09 0.209 l-3.5 3.5 l-0.082 0.094 a1 1 0 0 0 0 1.226 l0.083 0.094 l1.5 1.5 l0.094 0.083 a1 1 0 0 0 1.226 0 l0.094 -0.083 l0.083 -0.094 a1 1 0 0 0 0 -1.226 l-0.083 -0.094 l-0.792 -0.793 l0.585 -0.585 l0.793 0.792 l0.094 0.083 a1 1 0 0 0 1.403 -1.403 l-0.083 -0.094 l-0.792 -0.793 l0.792 -0.792 a3 3 0 1 0 1.293 -5.708 z m0 2 a1 1 0 1 1 0 2 a1 1 0 0 1 0 -2 z M0 0 h24 v24 H0 z";
				case IconKind.CircleKey:
					return "M12 15 l-1.5 -1.5 M12.5 11.5 l-4 4 l1.5 1.5 M21 12 a9 9 0 1 1 -18 0 a9 9 0 0 1 18 0 z M14 10 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleLetterA:
					return "M10 13 h4 M10 16 v-6 a2 2 0 1 1 4 0 v6 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleLetterB:
					return "M10 16 h2 a2 2 0 1 0 0 -4 h-2 h2 a2 2 0 1 0 0 -4 h-2 v8 z M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleLetterC:
					return "M14 10 a2 2 0 1 0 -4 0 v4 a2 2 0 1 0 4 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleLetterD:
					return "M10 8 v8 h2 a2 2 0 0 0 2 -2 v-4 a2 2 0 0 0 -2 -2 h-2 z M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleLetterE:
					return "M10 12 h2.5 M14 8 h-4 v8 h4 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleLetterF:
					return "M14 8 h-4 v8 M10 12 h3 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleLetterG:
					return "M14 8 h-2 a2 2 0 0 0 -2 2 v4 a2 2 0 0 0 2 2 h2 v-4 h-1 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleLetterH:
					return "M10 12 h4 M10 16 v-8 m4 0 v8 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleLetterI:
					return "M12 8 v8 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleLetterJ:
					return "M10 8 h4 v6 a2 2 0 1 1 -4 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleLetterK:
					return "M10 12 h1.5 M14 8 l-2.5 4 l2.5 4 M10 8 v8 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleLetterL:
					return "M10 8 v8 h4 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleLetterM:
					return "M9 16 v-8 l3 5 l3 -5 v8 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleLetterN:
					return "M10 16 v-8 l4 8 v-8 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleLetterO:
					return "M12 8 a2 2 0 0 1 2 2 v4 a2 2 0 1 1 -4 0 v-4 a2 2 0 0 1 2 -2 z M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleLetterP:
					return "M10 12 h2 a2 2 0 1 0 0 -4 h-2 v8 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleLetterQ:
					return "M13 15 l1 1 M12 8 a2 2 0 0 1 2 2 v4 a2 2 0 1 1 -4 0 v-4 a2 2 0 0 1 2 -2 z M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleLetterR:
					return "M10 12 h2 a2 2 0 1 0 0 -4 h-2 v8 m4 0 l-3 -4 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleLetterS:
					return "M10 15 a1 1 0 0 0 1 1 h2 a1 1 0 0 0 1 -1 v-2 a1 1 0 0 0 -1 -1 h-2 a1 1 0 0 1 -1 -1 v-2 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleLetterT:
					return "M12 8 v8 M10 8 h4 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleLetterU:
					return "M10 8 v6 a2 2 0 1 0 4 0 v-6 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleLetterV:
					return "M10 8 l2 8 l2 -8 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleLetterW:
					return "M9 8 l1 8 l2 -5 l2 5 l1 -8 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleLetterX:
					return "M10 16 l4 -8 M10 8 l4 8 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleLetterY:
					return "M12 16 v-3 M10 8 l2 5 l2 -5 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleLetterZ:
					return "M10 8 h4 l-4 8 h4 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleMinus:
					return "M9 12 l6 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleNumber0:
					return "M10 10 v4 a2 2 0 1 0 4 0 v-4 a2 2 0 1 0 -4 0 z M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleNumber1:
					return "M10 10 l2 -2 v8 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleNumber2:
					return "M10 8 h3 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 0 -1 1 v2 a1 1 0 0 0 1 1 h3 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleNumber3:
					return "M10 9 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleNumber4:
					return "M14 8 v8 M10 8 v3 a1 1 0 0 0 1 1 h3 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleNumber5:
					return "M10 15 a1 1 0 0 0 1 1 h2 a1 1 0 0 0 1 -1 v-2 a1 1 0 0 0 -1 -1 h-3 v-4 h4 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleNumber6:
					return "M14 9 a1 1 0 0 0 -1 -1 h-2 a1 1 0 0 0 -1 1 v6 a1 1 0 0 0 1 1 h2 a1 1 0 0 0 1 -1 v-2 a1 1 0 0 0 -1 -1 h-3 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleNumber7:
					return "M10 8 h4 l-2 8 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleNumber8:
					return "M12 12 h-1 a1 1 0 0 1 -1 -1 v-2 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 0 -1 1 v2 a1 1 0 0 0 1 1 h2 a1 1 0 0 0 1 -1 v-2 a1 1 0 0 0 -1 -1 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleNumber9:
					return "M10 15 a1 1 0 0 0 1 1 h2 a1 1 0 0 0 1 -1 v-6 a1 1 0 0 0 -1 -1 h-2 a1 1 0 0 0 -1 1 v2 a1 1 0 0 0 1 1 h3 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleOff:
					return "M3 3 l18 18 M20.042 16.045 a9 9 0 0 0 -12.087 -12.087 m-2.318 1.677 a9 9 0 1 0 12.725 12.73 M0 0 h24 v24 H0 z";
				case IconKind.CirclePlus:
					return "M12 9 l0 6 M9 12 l6 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleRectangleOff:
					return "M3 3 l18 18 M20.042 16.045 a9 9 0 0 0 -12.087 -12.087 m-2.318 1.677 a9 9 0 1 0 12.725 12.73 M14 10 h3 v3 m-3 1 h-7 v-4 h3 M0 0 h24 v24 H0 z";
				case IconKind.CircleRectangle:
					return "M7 10 h10 v4 h-10 z M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleSquare:
					return "M10 10 m0 2 a2 2 0 0 1 2 -2 h7 a2 2 0 0 1 2 2 v7 a2 2 0 0 1 -2 2 h-7 a2 2 0 0 1 -2 -2 z M9.5 9.5 m-6.5 0 a6.5 6.5 0 1 0 13 0 a6.5 6.5 0 1 0 -13 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleTriangle:
					return "M12 20 l7 -12 h-14 z M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CircleX:
					return "M10 10 l4 4 m0 -4 l-4 4 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.Circle:
					return "M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CirclesFilled:
					return "M12 2 a5 5 0 1 1 -4.995 5.217 l-0.005 -0.217 l0.005 -0.217 a5 5 0 0 1 4.995 -4.783 z M17.5 12 a5 5 0 1 1 -4.995 5.217 l-0.005 -0.217 l0.005 -0.217 a5 5 0 0 1 4.995 -4.783 z M6.5 12 a5 5 0 1 1 -4.995 5.217 l-0.005 -0.217 l0.005 -0.217 a5 5 0 0 1 4.995 -4.783 z M0 0 h24 v24 H0 z";
				case IconKind.CirclesRelation:
					return "M14.813 17.883 a6 6 0 1 0 -4.496 -3.954 M9.183 6.117 a6 6 0 1 0 4.511 3.986 M0 0 h24 v24 H0 z";
				case IconKind.Circles:
					return "M17.5 17 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M6.5 17 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M12 7 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M0 0 h24 v24 H0 z";
				case IconKind.CircuitAmmeter:
					return "M14 12 h-4 M10 14 v-3 c0 -1.036 0.895 -2 2 -2 s2 0.964 2 2 v3 M19 12 h3 M5 12 h-3 M12 12 m-7 0 a7 7 0 1 0 14 0 a7 7 0 1 0 -14 0 M0 0 h24 v24 H0 z";
				case IconKind.CircuitBattery:
					return "M6 9 v6 M10 5 v14 M14 9 v6 M18 5 v14 M18 12 h4 M2 12 h4 M0 0 h24 v24 H0 z";
				case IconKind.CircuitBulb:
					return "M15.5 8.5 l-7 7 M8.5 8.5 l7 7 M12 12 m-5 0 a5 5 0 1 0 10 0 a5 5 0 1 0 -10 0 M17 12 h5 M2 12 h5 M0 0 h24 v24 H0 z";
				case IconKind.CircuitCapacitorPolarized:
					return "M19 3 v4 M17 5 h4 M14 7 v10 M10 7 v10 M2 12 h8 M22 12 h-8 M0 0 h24 v24 H0 z";
				case IconKind.CircuitCapacitor:
					return "M14 7 v10 M10 7 v10 M2 12 h8 M22 12 h-8 M0 0 h24 v24 H0 z";
				case IconKind.CircuitCellPlus:
					return "M5 3 v4 M3 5 h4 M15 9 v6 M11 5 v14 M15 12 h7 M2 12 h9 M0 0 h24 v24 H0 z";
				case IconKind.CircuitCell:
					return "M14 9 v6 M10 5 v14 M14 12 h8 M2 12 h8 M0 0 h24 v24 H0 z";
				case IconKind.CircuitChangeover:
					return "M7.5 10.5 l8.5 -3.5 M18 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M20 17 h2 M18 7 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M20 7 h2 M2 12 h2 M0 0 h24 v24 H0 z";
				case IconKind.CircuitDiodeZener:
					return "M14 7 h2 v10 h2 M8 7 l8 5 l-8 5 z M2 12 h6 M22 12 h-6 M0 0 h24 v24 H0 z";
				case IconKind.CircuitDiode:
					return "M16 7 v10 M8 7 l8 5 l-8 5 z M2 12 h6 M22 12 h-6 M0 0 h24 v24 H0 z";
				case IconKind.CircuitGroundDigital:
					return "M12 21 l-6 -8 h12 z M12 13 v-10 M0 0 h24 v24 H0 z";
				case IconKind.CircuitGround:
					return "M10 19 h4 M7 16 h10 M4 13 h16 M12 13 v-8 M0 0 h24 v24 H0 z";
				case IconKind.CircuitInductor:
					return "M2 14 h3 v-2 a2 2 0 1 1 4 0 v2 v-1.5 a2.5 2.5 0 1 1 5 0 v1.5 v-1.5 a2.5 2.5 0 1 1 5 0 v1.5 h3 M0 0 h24 v24 H0 z";
				case IconKind.CircuitMotor:
					return "M10 14 v-4 l2 2 l2 -2 v4 M19 12 h3 M5 12 h-3 M12 12 m-7 0 a7 7 0 1 0 14 0 a7 7 0 1 0 -14 0 M0 0 h24 v24 H0 z";
				case IconKind.CircuitPushbutton:
					return "M12 11 v-6 M6 11 h12 M18 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M20 17 h2 M2 17 h2 M0 0 h24 v24 H0 z";
				case IconKind.CircuitResistor:
					return "M2 12 h2 l2 -5 l3 10 l3 -10 l3 10 l3 -10 l1.5 5 h2.5 M0 0 h24 v24 H0 z";
				case IconKind.CircuitSwitchClosed:
					return "M8 12 h8 M18 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M20 12 h2 M2 12 h2 M0 0 h24 v24 H0 z";
				case IconKind.CircuitSwitchOpen:
					return "M7.5 10.5 l7.5 -5.5 M18 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M20 12 h2 M2 12 h2 M0 0 h24 v24 H0 z";
				case IconKind.CircuitVoltmeter:
					return "M10 10 l2 4 l2 -4 M19 12 h3 M5 12 h-3 M12 12 m-7 0 a7 7 0 1 0 14 0 a7 7 0 1 0 -14 0 M0 0 h24 v24 H0 z";
				case IconKind.ClearAll:
					return "M4 18 h12 M6 12 h12 M8 6 h12 M0 0 h24 v24 H0 z";
				case IconKind.ClearFormatting:
					return "M13 5 l-4 14 M7 19 l4 0 M7 6 v-1 h11 v1 M17 15 l4 4 m0 -4 l-4 4 M0 0 h24 v24 H0 z";
				case IconKind.Click:
					return "M12 12 l9 3 l-4 2 l-2 4 l-3 -9 M7.8 16.2 l-2.2 2.2 M16.2 7.8 l2.2 -2.2 M7.8 7.8 l-2.2 -2.2 M12 3 l0 3 M3 12 l3 0 M0 0 h24 v24 H0 z";
				case IconKind.ClipboardCheck:
					return "M9 14 l2 2 l4 -4 M9 3 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v0 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M9 5 h-2 a2 2 0 0 0 -2 2 v12 a2 2 0 0 0 2 2 h10 a2 2 0 0 0 2 -2 v-12 a2 2 0 0 0 -2 -2 h-2 M0 0 h24 v24 H0 z";
				case IconKind.ClipboardCopy:
					return "M9 3 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v0 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M13 17 v-1 a1 1 0 0 1 1 -1 h1 m3 0 h1 a1 1 0 0 1 1 1 v1 m0 3 v1 a1 1 0 0 1 -1 1 h-1 m-3 0 h-1 a1 1 0 0 1 -1 -1 v-1 M9 5 h-2 a2 2 0 0 0 -2 2 v12 a2 2 0 0 0 2 2 h3 m9 -9 v-5 a2 2 0 0 0 -2 -2 h-2 M0 0 h24 v24 H0 z";
				case IconKind.ClipboardData:
					return "M12 17 v-1 M15 17 v-2 M12 17 v-1 M9 17 v-4 M9 3 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v0 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M9 5 h-2 a2 2 0 0 0 -2 2 v12 a2 2 0 0 0 2 2 h10 a2 2 0 0 0 2 -2 v-12 a2 2 0 0 0 -2 -2 h-2 M0 0 h24 v24 H0 z";
				case IconKind.ClipboardHeart:
					return "M11.993 16.75 l2.747 -2.815 a1.9 1.9 0 0 0 0 -2.632 a1.775 1.775 0 0 0 -2.56 0 l-0.183 0.188 l-0.183 -0.189 a1.775 1.775 0 0 0 -2.56 0 a1.899 1.899 0 0 0 0 2.632 l2.738 2.825 z M9 3 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v0 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M9 5 h-2 a2 2 0 0 0 -2 2 v12 a2 2 0 0 0 2 2 h10 a2 2 0 0 0 2 -2 v-12 a2 2 0 0 0 -2 -2 h-2 M0 0 h24 v24 H0 z";
				case IconKind.ClipboardList:
					return "M13 16 l2 0 M9 16 l0.01 0 M13 12 l2 0 M9 12 l0.01 0 M9 3 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v0 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M9 5 h-2 a2 2 0 0 0 -2 2 v12 a2 2 0 0 0 2 2 h10 a2 2 0 0 0 2 -2 v-12 a2 2 0 0 0 -2 -2 h-2 M0 0 h24 v24 H0 z";
				case IconKind.ClipboardOff:
					return "M3 3 l18 18 M9 5 a2 2 0 0 1 2 -2 h2 a2 2 0 1 1 0 4 h-2 M5.575 5.597 a2 2 0 0 0 -0.575 1.403 v12 a2 2 0 0 0 2 2 h10 a2 2 0 0 0 2 -2 m0 -4 v-8 a2 2 0 0 0 -2 -2 h-2 M0 0 h24 v24 H0 z";
				case IconKind.ClipboardPlus:
					return "M12 12 v4 M10 14 h4 M9 3 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v0 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M9 5 h-2 a2 2 0 0 0 -2 2 v12 a2 2 0 0 0 2 2 h10 a2 2 0 0 0 2 -2 v-12 a2 2 0 0 0 -2 -2 h-2 M0 0 h24 v24 H0 z";
				case IconKind.ClipboardText:
					return "M9 16 h6 M9 12 h6 M9 3 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v0 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M9 5 h-2 a2 2 0 0 0 -2 2 v12 a2 2 0 0 0 2 2 h10 a2 2 0 0 0 2 -2 v-12 a2 2 0 0 0 -2 -2 h-2 M0 0 h24 v24 H0 z";
				case IconKind.ClipboardTypography:
					return "M11 17 h2 M12 11 v6 M9 12 v-1 h6 v1 M9 3 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v0 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M9 5 h-2 a2 2 0 0 0 -2 2 v12 a2 2 0 0 0 2 2 h10 a2 2 0 0 0 2 -2 v-12 a2 2 0 0 0 -2 -2 h-2 M0 0 h24 v24 H0 z";
				case IconKind.ClipboardX:
					return "M10 12 l4 4 m0 -4 l-4 4 M9 3 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v0 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M9 5 h-2 a2 2 0 0 0 -2 2 v12 a2 2 0 0 0 2 2 h10 a2 2 0 0 0 2 -2 v-12 a2 2 0 0 0 -2 -2 h-2 M0 0 h24 v24 H0 z";
				case IconKind.Clipboard:
					return "M9 3 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v0 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M9 5 h-2 a2 2 0 0 0 -2 2 v12 a2 2 0 0 0 2 2 h10 a2 2 0 0 0 2 -2 v-12 a2 2 0 0 0 -2 -2 h-2 M0 0 h24 v24 H0 z";
				case IconKind.Clock2:
					return "M12 19 v1 M19 12 h1 M4 12 h1 M12 7 v5 l3 3 M4 4 m0 1 a1 1 0 0 1 1 -1 h14 a1 1 0 0 1 1 1 v14 a1 1 0 0 1 -1 1 h-14 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.ClockCancel:
					return "M12 7 v5 l2 2 M21 12.3 a9 9 0 1 0 -8.683 8.694 M17 21 l4 -4 M19 19 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.ClockEdit:
					return "M18.42 15.61 a2.1 2.1 0 0 1 2.97 2.97 l-3.39 3.42 h-3 v-3 l3.42 -3.39 z M12 7 v5 l2 2 M21 12 a9 9 0 1 0 -9.972 8.948 c0.32 0.034 0.644 0.052 0.972 0.052 M0 0 h24 v24 H0 z";
				case IconKind.ClockHour1:
					return "M12 12 l2 -3 M12 7 v5 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.ClockHour10:
					return "M12 7 v5 M12 12 l-3 -2 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.ClockHour11:
					return "M12 7 v5 M12 12 l-2 -3 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.ClockHour12:
					return "M12 7 v5 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.ClockHour2:
					return "M12 7 v5 M12 12 l3 -2 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.ClockHour3:
					return "M12 7 v5 M12 12 h3.5 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.ClockHour4:
					return "M12 7 v5 M12 12 l3 2 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.ClockHour5:
					return "M12 7 v5 M12 12 l2 3 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.ClockHour6:
					return "M12 7 v5 M12 12 v3.5 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.ClockHour7:
					return "M12 7 v5 M12 12 l-2 3 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.ClockHour8:
					return "M12 7 v5 M12 12 l-3 2 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.ClockHour9:
					return "M12 7 v5 M12 12 h-3.5 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.ClockOff:
					return "M3 3 l18 18 M20.042 16.045 a9 9 0 0 0 -12.087 -12.087 m-2.318 1.677 a9 9 0 1 0 12.725 12.73 M12 7 v1 M0 0 h24 v24 H0 z";
				case IconKind.ClockPause:
					return "M21 17 v5 M17 17 v5 M12 7 v5 l2 2 M13 20.94 a8.916 8.916 0 0 1 -7.364 -2.576 a9 9 0 1 1 15.306 -5.342 M0 0 h24 v24 H0 z";
				case IconKind.ClockPlay:
					return "M13.017 20.943 a9 9 0 1 1 7.831 -7.292 M17 22 l5 -3 l-5 -3 z M12 7 v5 l2 2 M0 0 h24 v24 H0 z";
				case IconKind.ClockRecord:
					return "M19 19 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M12 7 v5 l2 2 M21 12.3 a9 9 0 1 0 -8.683 8.694 M0 0 h24 v24 H0 z";
				case IconKind.ClockStop:
					return "M16 16 h6 v6 h-6 z M12 7 v5 l1 1 M21 12 a9 9 0 1 0 -9 9 M0 0 h24 v24 H0 z";
				case IconKind.Clock:
					return "M12 7 l0 5 l3 3 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.ClothesRackOff:
					return "M3 3 l18 18 M7.757 9.243 a6 6 0 0 0 3.129 1.653 m3.578 -0.424 a6 6 0 0 0 1.779 -1.229 M9 21 h6 M12 7 v1 m0 4 v9 M12 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.ClothesRack:
					return "M7.757 9.243 a6 6 0 0 0 8.486 0 M9 21 h6 M12 7 v14 M12 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.CloudComputing:
					return "M8 16 v4 a1 1 0 0 1 -1 1 h-4 M16 16 v4 a1 1 0 0 0 1 1 h4 M12 16 v5 M6.657 16 c-2.572 0 -4.657 -2.007 -4.657 -4.483 c0 -2.475 2.085 -4.482 4.657 -4.482 c0.393 -1.762 1.794 -3.2 3.675 -3.773 c1.88 -0.572 3.956 -0.193 5.444 1 c1.488 1.19 2.162 3.007 1.77 4.769 h0.99 c1.913 0 3.464 1.56 3.464 3.486 c0 1.927 -1.551 3.487 -3.465 3.487 h-11.878 M0 0 h24 v24 H0 z";
				case IconKind.CloudDataConnection:
					return "M3 18 h7 M14 18 h7 M12 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M12 13 v3 M5 9.897 c0 -1.714 1.46 -3.104 3.26 -3.104 c0.275 -1.22 1.255 -2.215 2.572 -2.611 c1.317 -0.397 2.77 -0.134 3.811 0.69 c1.042 0.822 1.514 2.08 1.239 3.3 h0.693 a2.42 2.42 0 0 1 2.425 2.414 a2.42 2.42 0 0 1 -2.425 2.414 h-8.315 c-1.8 0 -3.26 -1.39 -3.26 -3.103 z M0 0 h24 v24 H0 z";
				case IconKind.CloudDownload:
					return "M9 19 l3 3 l3 -3 M12 13 l0 9 M19 18 a3.5 3.5 0 0 0 0 -7 h-1 a5 4.5 0 0 0 -11 -2 a4.6 4.4 0 0 0 -2.1 8.4 M0 0 h24 v24 H0 z";
				case IconKind.CloudFilled:
					return "M6.657 18 c-2.572 0 -4.657 -2.007 -4.657 -4.483 c0 -2.475 2.085 -4.482 4.657 -4.482 c0.393 -1.762 1.794 -3.2 3.675 -3.773 c1.88 -0.572 3.956 -0.193 5.444 1 c1.488 1.19 2.162 3.007 1.77 4.769 h0.99 c1.913 0 3.464 1.56 3.464 3.486 c0 1.927 -1.551 3.487 -3.465 3.487 h-11.878 M0 0 h24 v24 H0 z";
				case IconKind.CloudFog:
					return "M5 20 l14 0 M7 16 a4.6 4.4 0 0 1 0 -9 a5 4.5 0 0 1 11 2 h1 a3.5 3.5 0 0 1 0 7 h-12 M0 0 h24 v24 H0 z";
				case IconKind.CloudLockOpen:
					return "M10 15 v-2 a2 2 0 0 1 3.736 -1 M8 15 m0 1 a1 1 0 0 1 1 -1 h6 a1 1 0 0 1 1 1 v3 a1 1 0 0 1 -1 1 h-6 a1 1 0 0 1 -1 -1 z M19 18 a3.5 3.5 0 0 0 0 -7 h-1 c0.397 -1.768 -0.285 -3.593 -1.788 -4.787 c-1.503 -1.193 -3.6 -1.575 -5.5 -1 s-3.315 2.019 -3.712 3.787 c-2.199 -0.088 -4.155 1.326 -4.666 3.373 c-0.512 2.047 0.564 4.154 2.566 5.027 M0 0 h24 v24 H0 z";
				case IconKind.CloudLock:
					return "M10 15 v-2 a2 2 0 1 1 4 0 v2 M8 15 m0 1 a1 1 0 0 1 1 -1 h6 a1 1 0 0 1 1 1 v3 a1 1 0 0 1 -1 1 h-6 a1 1 0 0 1 -1 -1 z M19 18 a3.5 3.5 0 0 0 0 -7 h-1 c0.397 -1.768 -0.285 -3.593 -1.788 -4.787 c-1.503 -1.193 -3.6 -1.575 -5.5 -1 s-3.315 2.019 -3.712 3.787 c-2.199 -0.088 -4.155 1.326 -4.666 3.373 c-0.512 2.047 0.564 4.154 2.566 5.027 M0 0 h24 v24 H0 z";
				case IconKind.CloudOff:
					return "M18 18 h-11 c-2.598 0 -4.705 -2.015 -4.705 -4.5 s2.107 -4.5 4.705 -4.5 c0.112 -0.5 0.305 -0.973 0.568 -1.408 m2.094 -1.948 c0.329 -0.174 0.68 -0.319 1.05 -0.43 c1.9 -0.576 4 -0.194 5.5 1 c1.503 1.192 2.185 3.017 1.788 4.786 h1 a3.5 3.5 0 0 1 2.212 6.212 M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.CloudRain:
					return "M11 13 v2 m0 3 v2 m4 -5 v2 m0 3 v2 M7 18 a4.6 4.4 0 0 1 0 -9 a5 4.5 0 0 1 11 2 h1 a3.5 3.5 0 0 1 0 7 M0 0 h24 v24 H0 z";
				case IconKind.CloudSnow:
					return "M11 15 v0.01 m0 3 v0.01 m0 3 v0.01 m4 -4 v0.01 m0 3 v0.01 M7 18 a4.6 4.4 0 0 1 0 -9 a5 4.5 0 0 1 11 2 h1 a3.5 3.5 0 0 1 0 7 M0 0 h24 v24 H0 z";
				case IconKind.CloudStorm:
					return "M13 14 l-2 4 l3 0 l-2 4 M7 18 a4.6 4.4 0 0 1 0 -9 a5 4.5 0 0 1 11 2 h1 a3.5 3.5 0 0 1 0 7 h-1 M0 0 h24 v24 H0 z";
				case IconKind.CloudUpload:
					return "M12 12 l0 9 M9 15 l3 -3 l3 3 M7 18 a4.6 4.4 0 0 1 0 -9 a5 4.5 0 0 1 11 2 h1 a3.5 3.5 0 0 1 0 7 h-1 M0 0 h24 v24 H0 z";
				case IconKind.Cloud:
					return "M6.657 18 c-2.572 0 -4.657 -2.007 -4.657 -4.483 c0 -2.475 2.085 -4.482 4.657 -4.482 c0.393 -1.762 1.794 -3.2 3.675 -3.773 c1.88 -0.572 3.956 -0.193 5.444 1 c1.488 1.19 2.162 3.007 1.77 4.769 h0.99 c1.913 0 3.464 1.56 3.464 3.486 c0 1.927 -1.551 3.487 -3.465 3.487 h-11.878 M0 0 h24 v24 H0 z";
				case IconKind.Clover2:
					return "M15 15 l6 6 M7.56 7.603 a2.104 2.104 0 0 0 -2.95 0 a2.04 2.04 0 0 0 0 2.912 l0.39 0.485 l-0.39 0.485 a2.04 2.04 0 0 0 0 2.912 a2.104 2.104 0 0 0 2.95 0 M14.44 7.603 a2.104 2.104 0 0 1 2.95 0 a2.04 2.04 0 0 1 0 2.912 l-0.39 0.485 l0.39 0.485 a2.04 2.04 0 0 1 0 2.912 a2.104 2.104 0 0 1 -2.95 0 M11 11 l-3.397 3.44 a2.104 2.104 0 0 0 0 2.95 a2.04 2.04 0 0 0 2.912 0 l0.485 -0.39 l0.485 0.39 a2.04 2.04 0 0 0 2.912 0 a2.104 2.104 0 0 0 0 -2.95 l-3.397 -3.44 z M11 11 l-3.397 -3.44 a2.104 2.104 0 0 1 0 -2.95 a2.04 2.04 0 0 1 2.912 0 l0.485 0.39 l0.485 -0.39 a2.04 2.04 0 0 1 2.912 0 a2.104 2.104 0 0 1 0 2.95 l-3.397 3.44 z M0 0 h24 v24 H0 z";
				case IconKind.Clover:
					return "M10 12 l-3.44 -3.397 a2.104 2.104 0 0 0 -2.95 0 a2.04 2.04 0 0 0 0 2.912 l0.39 0.485 l-0.39 0.485 a2.04 2.04 0 0 0 0 2.912 a2.104 2.104 0 0 0 2.95 0 l3.44 -3.397 z M14 12 l3.44 -3.397 a2.104 2.104 0 0 1 2.95 0 a2.04 2.04 0 0 1 0 2.912 l-0.39 0.485 l0.39 0.485 a2.04 2.04 0 0 1 0 2.912 a2.104 2.104 0 0 1 -2.95 0 l-3.44 -3.397 z M12 14 l-3.397 3.44 a2.104 2.104 0 0 0 0 2.95 a2.04 2.04 0 0 0 2.912 0 l0.485 -0.39 l0.485 0.39 a2.04 2.04 0 0 0 2.912 0 a2.104 2.104 0 0 0 0 -2.95 l-3.397 -3.44 z M12 10 l-3.397 -3.44 a2.104 2.104 0 0 1 0 -2.95 a2.04 2.04 0 0 1 2.912 0 l0.485 0.39 l0.485 -0.39 a2.04 2.04 0 0 1 2.912 0 a2.104 2.104 0 0 1 0 2.95 l-3.397 3.44 z M0 0 h24 v24 H0 z";
				case IconKind.ClubsFilled:
					return "M12 3 a4 4 0 0 1 3.164 6.447 a4 4 0 1 1 -1.164 6.198 v1.355 l1 4 h-6 l1 -4 l0 -1.355 a4 4 0 1 1 -1.164 -6.199 a4 4 0 0 1 3.163 -6.446 z M0 0 h24 v24 H0 z";
				case IconKind.Clubs:
					return "M12 3 a4 4 0 0 1 3.164 6.447 a4 4 0 1 1 -1.164 6.198 v1.355 l1 4 h-6 l1 -4 l0 -1.355 a4 4 0 1 1 -1.164 -6.199 a4 4 0 0 1 3.163 -6.446 z M0 0 h24 v24 H0 z";
				case IconKind.CodeAsterix:
					return "M18 19 a2 2 0 0 0 2 -2 v-4 l1 -1 l-1 -1 v-4 a2 2 0 0 0 -2 -2 M12 11.875 l-3 1.688 M12 8.5 v3.375 M12 11.875 l3 1.688 M12 11.875 l-3 -1.687 M12 11.875 v3.375 M12 11.875 l3 -1.687 M6 19 a2 2 0 0 1 -2 -2 v-4 l-1 -1 l1 -1 v-4 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.CodeCircle2:
					return "M13 9.5 l-2 5.5 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M15.5 10.5 l1.5 1.5 l-1.5 1.5 M8.5 13.5 l-1.5 -1.5 l1.5 -1.5 M0 0 h24 v24 H0 z";
				case IconKind.CodeCircle:
					return "M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M14 10 l2 2 l-2 2 M10 14 l-2 -2 l2 -2 M0 0 h24 v24 H0 z";
				case IconKind.CodeDots:
					return "M18 19 a2 2 0 0 0 2 -2 v-4 l1 -1 l-1 -1 v-4 a2 2 0 0 0 -2 -2 M6 19 a2 2 0 0 1 -2 -2 v-4 l-1 -1 l1 -1 v-4 a2 2 0 0 1 2 -2 M9 12 h0.01 M12 12 h0.01 M15 12 h0.01 M0 0 h24 v24 H0 z";
				case IconKind.CodeMinus:
					return "M18 19 a2 2 0 0 0 2 -2 v-4 l1 -1 l-1 -1 v-4 a2 2 0 0 0 -2 -2 M6 19 a2 2 0 0 1 -2 -2 v-4 l-1 -1 l1 -1 v-4 a2 2 0 0 1 2 -2 M9 12 h6 M0 0 h24 v24 H0 z";
				case IconKind.CodeOff:
					return "M3 3 l18 18 M14 4 l-1.201 4.805 m-0.802 3.207 l-2 7.988 M17 8 l4 4 l-2.5 2.5 M7 8 l-4 4 l4 4 M0 0 h24 v24 H0 z";
				case IconKind.CodePlus:
					return "M18 19 a2 2 0 0 0 2 -2 v-4 l1 -1 l-1 -1 v-4 a2 2 0 0 0 -2 -2 M6 19 a2 2 0 0 1 -2 -2 v-4 l-1 -1 l1 -1 v-4 a2 2 0 0 1 2 -2 M12 9 v6 M9 12 h6 M0 0 h24 v24 H0 z";
				case IconKind.Code:
					return "M14 4 l-4 16 M17 8 l4 4 l-4 4 M7 8 l-4 4 l4 4 M0 0 h24 v24 H0 z";
				case IconKind.CoffeeOff:
					return "M3 3 l18 18 M20.116 16.124 a3 3 0 0 0 -3.118 -4.953 M14 10 h3 v3 m-0.257 3.743 a6 6 0 0 1 -5.743 4.257 h-2 a6 6 0 0 1 -6 -6 v-5 h7 M12 3 a2.4 2.4 0 0 0 -1 2 a2.4 2.4 0 0 0 1 2 M8 3 c-0.194 0.14 -0.364 0.305 -0.506 0.49 M3 14 c0.83 0.642 2.077 1.017 3.5 1 c1.423 0.017 2.67 -0.358 3.5 -1 c0.73 -0.565 1.783 -0.923 3 -0.99 M0 0 h24 v24 H0 z";
				case IconKind.Coffee:
					return "M16.746 16.726 a3 3 0 1 0 0.252 -5.555 M3 10 h14 v5 a6 6 0 0 1 -6 6 h-2 a6 6 0 0 1 -6 -6 v-5 z M12 3 a2.4 2.4 0 0 0 -1 2 a2.4 2.4 0 0 0 1 2 M8 3 a2.4 2.4 0 0 0 -1 2 a2.4 2.4 0 0 0 1 2 M3 14 c0.83 0.642 2.077 1.017 3.5 1 c1.423 0.017 2.67 -0.358 3.5 -1 c0.83 -0.642 2.077 -1.017 3.5 -1 c1.423 -0.017 2.67 0.358 3.5 1 M0 0 h24 v24 H0 z";
				case IconKind.Coffin:
					return "M13 21 h4 l2 -12 l-2 -6 h-4 M8 9 h4 M10 7 v5 M7 3 l-2 6 l2 12 h6 l2 -12 l-2 -6 z M0 0 h24 v24 H0 z";
				case IconKind.CoinBitcoin:
					return "M13 16 v1 M13 7 v1 M10 7 v10 v-9 M10 12 h4 M9 8 h4.09 c1.055 0 1.91 0.895 1.91 2 s-0.855 2 -1.91 2 c1.055 0 1.91 0.895 1.91 2 s-0.855 2 -1.91 2 h-4.09 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CoinEuro:
					return "M7 13.5 h4 M7 10.5 h4 M14.401 8 c-0.669 -0.628 -1.5 -1 -2.401 -1 c-2.21 0 -4 2.239 -4 5 s1.79 5 4 5 c0.9 0 1.731 -0.372 2.4 -1 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CoinMonero:
					return "M4 16 h4 v-7 l4 4 l4 -4 v7 h4 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CoinOff:
					return "M3 3 l18 18 M12 6 v2 m0 8 v2 M20.042 16.045 a9 9 0 0 0 -12.087 -12.087 m-2.318 1.677 a9 9 0 1 0 12.725 12.73 M14.8 9 a2 2 0 0 0 -1.8 -1 h-1 m-2.82 1.171 a2 2 0 0 0 1.82 2.829 h1 m2.824 2.822 a2 2 0 0 1 -1.824 1.178 h-2 a2 2 0 0 1 -1.8 -1 M0 0 h24 v24 H0 z";
				case IconKind.CoinPound:
					return "M9 12 h4 M15 9 a2 2 0 1 0 -4 0 v5 a2 2 0 0 1 -2 2 h6 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CoinRupee:
					return "M9 11 h6 M15 8 h-6 h1 a3 3 0 0 1 0 6 h-1 l3 3 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CoinYen:
					return "M15 8 l-3 4.5 v4.5 M9 8 l3 4.5 M9 15 h6 M9 12 h6 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CoinYuan:
					return "M15 8 l-3 4.5 v4.5 M9 8 l3 4.5 M9 13 h6 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.Coin:
					return "M12 7 v10 M14.8 9 a2 2 0 0 0 -1.8 -1 h-2 a2 2 0 1 0 0 4 h2 a2 2 0 1 1 0 4 h-2 a2 2 0 0 1 -1.8 -1 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.Coins:
					return "M3 11 c0 0.888 0.772 1.45 2 2 M3 6 v10 c0 0.888 0.772 1.45 2 2 M3 6 c0 1.072 1.144 2.062 3 2.598 s4.144 0.536 6 0 c1.856 -0.536 3 -1.526 3 -2.598 c0 -1.072 -1.144 -2.062 -3 -2.598 s-4.144 -0.536 -6 0 c-1.856 0.536 -3 1.526 -3 2.598 z M9 14 v4 c0 1.656 2.686 3 6 3 s6 -1.344 6 -3 v-4 M9 14 c0 1.657 2.686 3 6 3 s6 -1.343 6 -3 s-2.686 -3 -6 -3 s-6 1.343 -6 3 z M0 0 h24 v24 H0 z";
				case IconKind.ColorFilter:
					return "M12 8 m-6 0 a6 6 0 1 0 12 0 a6 6 0 1 0 -12 0 M17.58 10.21 c2.54 0.69 4.42 3.03 4.42 5.79 c0 3.31 -2.69 6 -6 6 a5.93 5.93 0 0 1 -4 -1.54 M13.58 13.79 c0.27 0.68 0.42 1.43 0.42 2.21 c0 1.77 -0.77 3.37 -2 4.46 a5.93 5.93 0 0 1 -4 1.54 c-3.31 0 -6 -2.69 -6 -6 c0 -2.76 1.88 -5.1 4.42 -5.79 M0 0 h24 v24 H0 z";
				case IconKind.ColorPickerOff:
					return "M3 3 l18 18 M12 8 l3.699 -3.699 a1 1 0 0 1 1.4 0 l2.6 2.6 a1 1 0 0 1 0 1.4 l-3.702 3.702 m-2 2 l-6 6 h-4 v-4 l6 -6 M11 7 l6 6 M0 0 h24 v24 H0 z";
				case IconKind.ColorPicker:
					return "M4 16 l11.7 -11.7 a1 1 0 0 1 1.4 0 l2.6 2.6 a1 1 0 0 1 0 1.4 l-11.7 11.7 h-4 v-4 z M11 7 l6 6 M0 0 h24 v24 H0 z";
				case IconKind.ColorSwatchOff:
					return "M3 3 l18 18 M17 17 v0.01 M7.3 13 h-2.3 a2 2 0 0 0 -2 2 v4 a2 2 0 0 0 2 2 h12 M13 7.35 l-2 -2 a2 2 0 0 0 -2.11 -0.461 m-2.13 1.874 l-1.416 1.415 a2 2 0 0 0 0 2.828 l9 9 M13 13 v4 a4 4 0 0 0 6.832 2.825 m1.168 -2.825 v-12 a2 2 0 0 0 -2 -2 h-4 a2 2 0 0 0 -2 2 v4 M0 0 h24 v24 H0 z";
				case IconKind.ColorSwatch:
					return "M17 17 l0 0.01 M7.3 13 h-2.3 a2 2 0 0 0 -2 2 v4 a2 2 0 0 0 2 2 h12 M13 7.35 l-2 -2 a2 2 0 0 0 -2.828 0 l-2.828 2.828 a2 2 0 0 0 0 2.828 l9 9 M19 3 h-4 a2 2 0 0 0 -2 2 v12 a4 4 0 0 0 8 0 v-12 a2 2 0 0 0 -2 -2 M0 0 h24 v24 H0 z";
				case IconKind.ColumnInsertLeft:
					return "M7 10 l0 4 M5 12 l4 0 M14 4 h4 a1 1 0 0 1 1 1 v14 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 v-14 a1 1 0 0 1 1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.ColumnInsertRight:
					return "M17 10 l0 4 M15 12 l4 0 M6 4 h4 a1 1 0 0 1 1 1 v14 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 v-14 a1 1 0 0 1 1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.Columns1:
					return "M5 3 m0 1 a1 1 0 0 1 1 -1 h12 a1 1 0 0 1 1 1 v16 a1 1 0 0 1 -1 1 h-12 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.Columns2:
					return "M3 3 m0 1 a1 1 0 0 1 1 -1 h16 a1 1 0 0 1 1 1 v16 a1 1 0 0 1 -1 1 h-16 a1 1 0 0 1 -1 -1 z m9 -1 v18 M0 0 h24 v24 H0 z";
				case IconKind.Columns3:
					return "M3 3 m0 1 a1 1 0 0 1 1 -1 h16 a1 1 0 0 1 1 1 v16 a1 1 0 0 1 -1 1 h-16 a1 1 0 0 1 -1 -1 z m6 -1 v18 m6 -18 v18 M0 0 h24 v24 H0 z";
				case IconKind.ColumnsOff:
					return "M3 3 l18 18 M14.5 18 h3.5 M18 14 h2 M14.5 10 h5.5 M14.5 6 h5.5 M4 18 h5.5 M4 14 h5.5 M4 10 h5.5 M4 6 h2 M0 0 h24 v24 H0 z";
				case IconKind.Columns:
					return "M14.5 18 l5.5 0 M14.5 14 l5.5 0 M14.5 10 l5.5 0 M14.5 6 l5.5 0 M4 18 l5.5 0 M4 14 l5.5 0 M4 10 l5.5 0 M4 6 l5.5 0 M0 0 h24 v24 H0 z";
				case IconKind.Comet:
					return "M4 9 l3.5 3.5 M9 4 l3.5 3.5 M4 4 l7 7 M15.5 18.5 l-3 1.5 l0.5 -3.5 l-2 -2 l3 -0.5 l1.5 -3 l1.5 3 l3 0.5 l-2 2 l0.5 3.5 z M0 0 h24 v24 H0 z";
				case IconKind.CommandOff:
					return "M3 3 l18 18 M9 9 v8 a2 2 0 1 1 -2 -2 h8 m3.411 3.417 a2 2 0 0 1 -3.411 -1.417 v-2 m0 -4 v-4 a2 2 0 1 1 2 2 h-4 m-4 0 h-2 a2 2 0 0 1 -1.417 -3.411 M0 0 h24 v24 H0 z";
				case IconKind.Command:
					return "M7 9 a2 2 0 1 1 2 -2 v10 a2 2 0 1 1 -2 -2 h10 a2 2 0 1 1 -2 2 v-10 a2 2 0 1 1 2 2 h-10 M0 0 h24 v24 H0 z";
				case IconKind.CompassOff:
					return "M3 3 l18 18 M19 12 h2 M3 12 h2 M12 19 v2 M12 3 v2 M20.042 16.045 a9 9 0 0 0 -12.087 -12.087 m-2.318 1.677 a9 9 0 1 0 12.725 12.73 M13 9 l3 -1 l-1 3 m-1 3 l-6 2 l2 -6 M0 0 h24 v24 H0 z";
				case IconKind.Compass:
					return "M19 12 l2 0 M3 12 l2 0 M12 19 l0 2 M12 3 l0 2 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M8 16 l2 -6 l6 -2 l-2 6 l-6 2 M0 0 h24 v24 H0 z";
				case IconKind.ComponentsOff:
					return "M3 3 l18 18 M9 18 l3 3 l3 -3 l-3 -3 z M12.499 8.501 l2.501 -2.501 l-3 -3 l-2.5 2.5 M18.5 14.5 l2.5 -2.5 l-3 -3 l-2.5 2.5 M3 12 l3 3 l3 -3 l-3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.Components:
					return "M9 18 l3 3 l3 -3 l-3 -3 z M9 6 l3 3 l3 -3 l-3 -3 z M15 12 l3 3 l3 -3 l-3 -3 z M3 12 l3 3 l3 -3 l-3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.Cone2:
					return "M19 7 v0.5 l-7 12.5 l-7 -12.5 v-0.5 M12 7 m-7 0 a7 3 0 1 0 14 0 a7 3 0 1 0 -14 0 M0 0 h24 v24 H0 z";
				case IconKind.ConeOff:
					return "M3 3 l18 18 M17.07 13.054 l-5.07 -9.054 l-1.432 2.558 m-1.439 2.569 l-4.129 7.373 v0.5 M18.305 18.305 c-1.132 1 -3.53 1.695 -6.305 1.695 c-3.866 0 -7 -1.343 -7 -3 s3.134 -3 7 -3 c0.747 0 1.467 0.05 2.142 0.143 M0 0 h24 v24 H0 z";
				case IconKind.Cone:
					return "M19 17 v-0.5 l-7 -12.5 l-7 12.5 v0.5 M12 14 c3.866 0 7 1.343 7 3 s-3.134 3 -7 3 s-7 -1.343 -7 -3 s3.134 -3 7 -3 z M0 0 h24 v24 H0 z";
				case IconKind.ConfettiOff:
					return "M3 3 l18 18 M14 16.518 l-6.518 -6.518 l-4.39 9.58 a1 1 0 0 0 1.329 1.329 l9.579 -4.39 v0 z M19 19 v1 M18 19 h1 M18 13 l2 -0.5 M15 9 l-1 1 M19 4 v2 M18 5 h2 M11.5 4 l-0.5 2 M5 5 v1 M4 5 h1 M0 0 h24 v24 H0 z";
				case IconKind.Confetti:
					return "M14 16.518 l-6.518 -6.518 l-4.39 9.58 a1 1 0 0 0 1.329 1.329 l9.579 -4.39 z M19 18 v2 M18 19 h2 M18 13 l2 -0.5 M15 9 l-1 1 M19 4 v2 M18 5 h2 M11.5 4 l-0.5 2 M5 4 v2 M4 5 h2 M0 0 h24 v24 H0 z";
				case IconKind.Confucius:
					return "M20 18 l-8 -8 l8 -4 M4 18 l8 -10 M4 10 l8 -2 M9 19 l3 2 v-18 M0 0 h24 v24 H0 z";
				case IconKind.ContainerOff:
					return "M3 3 l18 18 M4 8 v0.01 M4 12 v0.01 M4 16 v0.01 M4 20 v0.01 M4 4 v0.01 M8.297 4.289 a1 1 0 0 1 0.703 -0.289 h6 a1 1 0 0 1 1 1 v7 m0 4 v3 a1 1 0 0 1 -1 1 h-6 a1 1 0 0 1 -1 -1 v-11 M20 8 v0.01 M20 12 v0.01 M20 16 v0.01 M20 20 v0.01 M20 4 v0.01 M0 0 h24 v24 H0 z";
				case IconKind.Container:
					return "M4 8 v0.01 M4 12 v0.01 M4 16 v0.01 M4 20 v0.01 M4 4 v0.01 M8 4 m0 1 a1 1 0 0 1 1 -1 h6 a1 1 0 0 1 1 1 v14 a1 1 0 0 1 -1 1 h-6 a1 1 0 0 1 -1 -1 z M20 8 v0.01 M20 12 v0.01 M20 16 v0.01 M20 20 v0.01 M20 4 v0.01 M0 0 h24 v24 H0 z";
				case IconKind.Contrast2Off:
					return "M3 3 l18 18 M8 4 h10 a2 2 0 0 1 2 2 v10 m-0.586 3.414 a2 2 0 0 1 -1.414 0.586 h-12 a2 2 0 0 1 -2 -2 v-12 c0 -0.547 0.22 -1.043 0.576 -1.405 M4 18 h2 a6 6 0 0 0 6 -6 m0.878 -3.126 a6 6 0 0 1 5.122 -2.874 h2 M0 0 h24 v24 H0 z";
				case IconKind.Contrast2:
					return "M4 18 h2 a6 6 0 0 0 6 -6 a6 6 0 0 1 6 -6 h2 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.ContrastOff:
					return "M3 3 l18 18 M5.641 5.631 a9 9 0 1 0 12.719 12.738 m1.68 -2.318 a9 9 0 0 0 -12.074 -12.098 M12 12 v5 a4.984 4.984 0 0 0 3.522 -1.45 m1.392 -2.623 a5 5 0 0 0 -4.914 -5.927 v1 M0 0 h24 v24 H0 z";
				case IconKind.Contrast:
					return "M12 17 a5 5 0 0 0 0 -10 v10 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.Cooker:
					return "M5 11 h14 M9 15 h6 M5 3 m0 2 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v14 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 z M9 7 h0.01 M15 7 h0.01 M12 7 h0.01 M0 0 h24 v24 H0 z";
				case IconKind.CookieMan:
					return "M12 9 h0.01 M14 7 h0.01 M10 7 h0.01 M12 13 h0.01 M12 16 h0.01 M12 2 a5 5 0 0 1 2.845 9.112 l0.147 0.369 l1.755 -0.803 c0.969 -0.443 2.12 -0.032 2.571 0.918 a1.88 1.88 0 0 1 -0.787 2.447 l-0.148 0.076 l-2.383 1.089 v2.02 l1.426 1.425 l0.114 0.125 a1.96 1.96 0 0 1 -2.762 2.762 l-0.125 -0.114 l-2.079 -2.08 l-0.114 -0.124 a1.957 1.957 0 0 1 -0.161 -0.22 h-0.599 c-0.047 0.075 -0.101 0.15 -0.16 0.22 l-0.115 0.125 l-2.08 2.079 a1.96 1.96 0 0 1 -2.886 -2.648 l0.114 -0.125 l1.427 -1.426 v-2.019 l-2.383 -1.09 l-0.148 -0.075 a1.88 1.88 0 0 1 -0.787 -2.447 c0.429 -0.902 1.489 -1.318 2.424 -0.978 l0.147 0.06 l1.755 0.803 l0.147 -0.369 a5 5 0 0 1 -2.15 -3.895 l0 -0.217 a5 5 0 0 1 5 -5 z M0 0 h24 v24 H0 z";
				case IconKind.CookieOff:
					return "M3 3 l18 18 M18.192 18.187 a3 3 0 0 1 -0.976 0.652 c-1.048 0.263 -1.787 0.483 -2.216 0.661 c-0.475 0.197 -1.092 0.538 -1.852 1.024 a3 3 0 0 1 -2.296 0 c-0.802 -0.503 -1.419 -0.844 -1.852 -1.024 c-0.471 -0.195 -1.21 -0.415 -2.216 -0.66 a3 3 0 0 1 -1.623 -1.624 c-0.265 -1.052 -0.485 -1.79 -0.661 -2.216 c-0.198 -0.479 -0.54 -1.096 -1.024 -1.852 a3 3 0 0 1 0 -2.296 c0.48 -0.744 0.82 -1.361 1.024 -1.852 c0.171 -0.413 0.391 -1.152 0.66 -2.216 a3 3 0 0 1 0.649 -0.971 m2.821 -1.174 c0.14 -0.049 0.263 -0.095 0.37 -0.139 c0.458 -0.19 1.075 -0.531 1.852 -1.024 a3 3 0 0 1 2.296 0 l2.667 1.104 a4 4 0 0 0 4.656 6.14 l0.053 0.132 a3 3 0 0 1 0 2.296 c-0.497 0.786 -0.838 1.404 -1.024 1.852 a6.579 6.579 0 0 0 -0.135 0.36 M12 12 v0.01 M12 17 v0.01 M8 13 v0.01 M0 0 h24 v24 H0 z";
				case IconKind.Cookie:
					return "M13.148 3.476 l2.667 1.104 a4 4 0 0 0 4.656 6.14 l0.053 0.132 a3 3 0 0 1 0 2.296 c-0.497 0.786 -0.838 1.404 -1.024 1.852 c-0.189 0.456 -0.409 1.194 -0.66 2.216 a3 3 0 0 1 -1.624 1.623 c-1.048 0.263 -1.787 0.483 -2.216 0.661 c-0.475 0.197 -1.092 0.538 -1.852 1.024 a3 3 0 0 1 -2.296 0 c-0.802 -0.503 -1.419 -0.844 -1.852 -1.024 c-0.471 -0.195 -1.21 -0.415 -2.216 -0.66 a3 3 0 0 1 -1.623 -1.624 c-0.265 -1.052 -0.485 -1.79 -0.661 -2.216 c-0.198 -0.479 -0.54 -1.096 -1.024 -1.852 a3 3 0 0 1 0 -2.296 c0.48 -0.744 0.82 -1.361 1.024 -1.852 c0.171 -0.413 0.391 -1.152 0.66 -2.216 a3 3 0 0 1 1.624 -1.623 c1.032 -0.256 1.77 -0.476 2.216 -0.661 c0.458 -0.19 1.075 -0.531 1.852 -1.024 a3 3 0 0 1 2.296 0 z M11 8 v0.01 M16 14 v0.01 M12 12 v0.01 M12 17 v0.01 M8 13 v0.01 M0 0 h24 v24 H0 z";
				case IconKind.CopyOff:
					return "M3 3 l18 18 M16 8 v-2 a2 2 0 0 0 -2 -2 h-6 m-3.418 0.59 c-0.36 0.36 -0.582 0.86 -0.582 1.41 v8 a2 2 0 0 0 2 2 h2 M19.414 19.415 a2 2 0 0 1 -1.414 0.585 h-8 a2 2 0 0 1 -2 -2 v-8 c0 -0.554 0.225 -1.055 0.589 -1.417 m3.411 -0.583 h6 a2 2 0 0 1 2 2 v6 M0 0 h24 v24 H0 z";
				case IconKind.Copy:
					return "M16 8 v-2 a2 2 0 0 0 -2 -2 h-8 a2 2 0 0 0 -2 2 v8 a2 2 0 0 0 2 2 h2 M8 8 m0 2 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.CopyleftOff:
					return "M3 3 l18 18 M20.042 16.045 a9 9 0 0 0 -12.087 -12.087 m-2.318 1.677 a9 9 0 1 0 12.725 12.73 M13.303 9.3 a3.01 3.01 0 0 1 1.405 1.406 m-0.586 3.413 a3.016 3.016 0 0 1 -4.122 0.131 M0 0 h24 v24 H0 z";
				case IconKind.Copyleft:
					return "M10 9.75 a3.016 3.016 0 0 1 4.163 0.173 a2.993 2.993 0 0 1 0 4.154 a3.016 3.016 0 0 1 -4.163 0.173 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CopyrightOff:
					return "M3 3 l18 18 M20.042 16.045 a9 9 0 0 0 -12.087 -12.087 m-2.318 1.677 a9 9 0 1 0 12.725 12.73 M14 9.75 a3.016 3.016 0 0 0 -0.711 -0.466 m-3.41 0.596 a2.993 2.993 0 0 0 -0.042 4.197 a3.016 3.016 0 0 0 4.163 0.173 M0 0 h24 v24 H0 z";
				case IconKind.Copyright:
					return "M14 9.75 a3.016 3.016 0 0 0 -4.163 0.173 a2.993 2.993 0 0 0 0 4.154 a3.016 3.016 0 0 0 4.163 0.173 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CornerDownLeftDouble:
					return "M13 10 l-4 4 l4 4 m-5 -8 l-4 4 l4 4 M19 5 v6 a3 3 0 0 1 -3 3 h-7 M0 0 h24 v24 H0 z";
				case IconKind.CornerDownLeft:
					return "M18 6 v6 a3 3 0 0 1 -3 3 h-10 l4 -4 m0 8 l-4 -4 M0 0 h24 v24 H0 z";
				case IconKind.CornerDownRightDouble:
					return "M10 10 l4 4 l-4 4 m5 -8 l4 4 l-4 4 M4 5 v6 a3 3 0 0 0 3 3 h7 M0 0 h24 v24 H0 z";
				case IconKind.CornerDownRight:
					return "M6 6 v6 a3 3 0 0 0 3 3 h10 l-4 -4 m0 8 l4 -4 M0 0 h24 v24 H0 z";
				case IconKind.CornerLeftDownDouble:
					return "M13 10 l-4 4 l-4 -4 m8 5 l-4 4 l-4 -4 M18 4 h-6 a3 3 0 0 0 -3 3 v7 M0 0 h24 v24 H0 z";
				case IconKind.CornerLeftDown:
					return "M18 6 h-6 a3 3 0 0 0 -3 3 v10 l-4 -4 m8 0 l-4 4 M0 0 h24 v24 H0 z";
				case IconKind.CornerLeftUpDouble:
					return "M13 13 l-4 -4 l-4 4 m8 -5 l-4 -4 l-4 4 M18 19 h-6 a3 3 0 0 1 -3 -3 v-7 M0 0 h24 v24 H0 z";
				case IconKind.CornerLeftUp:
					return "M18 18 h-6 a3 3 0 0 1 -3 -3 v-10 l-4 4 m8 0 l-4 -4 M0 0 h24 v24 H0 z";
				case IconKind.CornerRightDownDouble:
					return "M10 10 l4 4 l4 -4 m-8 5 l4 4 l4 -4 M5 4 h6 a3 3 0 0 1 3 3 v7 M0 0 h24 v24 H0 z";
				case IconKind.CornerRightDown:
					return "M6 6 h6 a3 3 0 0 1 3 3 v10 l-4 -4 m8 0 l-4 4 M0 0 h24 v24 H0 z";
				case IconKind.CornerRightUpDouble:
					return "M10 13 l4 -4 l4 4 m-8 -5 l4 -4 l4 4 M5 19 h6 a3 3 0 0 0 3 -3 v-7 M0 0 h24 v24 H0 z";
				case IconKind.CornerRightUp:
					return "M6 18 h6 a3 3 0 0 0 3 -3 v-10 l-4 4 m8 0 l-4 -4 M0 0 h24 v24 H0 z";
				case IconKind.CornerUpLeftDouble:
					return "M13 13 l-4 -4 l4 -4 m-5 8 l-4 -4 l4 -4 M19 18 v-6 a3 3 0 0 0 -3 -3 h-7 M0 0 h24 v24 H0 z";
				case IconKind.CornerUpLeft:
					return "M18 18 v-6 a3 3 0 0 0 -3 -3 h-10 l4 -4 m0 8 l-4 -4 M0 0 h24 v24 H0 z";
				case IconKind.CornerUpRightDouble:
					return "M10 13 l4 -4 l-4 -4 m5 8 l4 -4 l-4 -4 M4 18 v-6 a3 3 0 0 1 3 -3 h7 M0 0 h24 v24 H0 z";
				case IconKind.CornerUpRight:
					return "M6 18 v-6 a3 3 0 0 1 3 -3 h10 l-4 -4 m0 8 l4 -4 M0 0 h24 v24 H0 z";
				case IconKind.Cpu2:
					return "M10 21 v-2 M14 21 v-2 M21 14 h-2 M21 10 h-2 M14 3 v2 M10 3 v2 M3 14 h2 M3 10 h2 M8 10 v-2 h2 m6 6 v2 h-2 m-4 0 h-2 v-2 m8 -4 v-2 h-2 M5 5 m0 1 a1 1 0 0 1 1 -1 h12 a1 1 0 0 1 1 1 v12 a1 1 0 0 1 -1 1 h-12 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.CpuOff:
					return "M3 3 l18 18 M10 21 v-2 M14 21 v-2 M21 14 h-2 M21 10 h-2 M14 3 v2 M10 3 v2 M3 14 h2 M3 10 h2 M13 9 h2 v2 m0 4 h-6 v-6 M9 5 h9 a1 1 0 0 1 1 1 v9 m-0.292 3.706 a1 1 0 0 1 -0.708 0.294 h-12 a1 1 0 0 1 -1 -1 v-12 c0 -0.272 0.108 -0.518 0.284 -0.698 M0 0 h24 v24 H0 z";
				case IconKind.Cpu:
					return "M10 21 v-2 M14 21 v-2 M21 14 h-2 M21 10 h-2 M14 3 v2 M10 3 v2 M3 14 h2 M3 10 h2 M9 9 h6 v6 h-6 z M5 5 m0 1 a1 1 0 0 1 1 -1 h12 a1 1 0 0 1 1 1 v12 a1 1 0 0 1 -1 1 h-12 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.CraneOff:
					return "M3 3 l18 18 M17 9 v4 a2 2 0 0 1 2 2 m-2 2 a2 2 0 0 1 -2 -2 M9 3 l10 6 M13 9 h8 M6 6 l-3 3 h6 M9 5 v-2 l-1 1 M9 21 v-12 M6 21 h6 M0 0 h24 v24 H0 z";
				case IconKind.Crane:
					return "M17 9 v4 a2 2 0 1 1 -2 2 M9 3 l10 6 M9 21 v-18 l-6 6 h18 M6 21 h6 M0 0 h24 v24 H0 z";
				case IconKind.CreativeCommonsBy:
					return "M9 13 v-1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v1 a1 1 0 0 1 -1 1 h-0.5 l-0.5 4 h-2 l-0.5 -4 h-0.5 a1 1 0 0 1 -1 -1 z M12 7 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CreativeCommonsNc:
					return "M15 15 l3 3 M6 6 l3 3 M12 15 v2 M12 7 v2 M15 9 h-4.5 a1.5 1.5 0 0 0 0 3 h3 a1.5 1.5 0 0 1 0 3 h-4.5 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CreativeCommonsNd:
					return "M9 14 h6 M9 10 h6 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CreativeCommonsOff:
					return "M3 3 l18 18 M16.5 10.5 a2.194 2.194 0 0 0 -2.309 -0.302 M10.5 10.5 a2.187 2.187 0 0 0 -2.914 0.116 a1.928 1.928 0 0 0 0 2.768 a2.188 2.188 0 0 0 2.914 0.116 M5.638 5.634 a9 9 0 1 0 12.723 12.733 m1.686 -2.332 a9 9 0 0 0 -12.093 -12.077 M0 0 h24 v24 H0 z";
				case IconKind.CreativeCommonsSa:
					return "M6 12 l2 2 l2 -2 M12 16 a4 4 0 1 0 -4 -4 v1 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CreativeCommonsZero:
					return "M14 9 l-4 6 M12 12 m-3 0 a3 4 0 1 0 6 0 a3 4 0 1 0 -6 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CreativeCommons:
					return "M16.5 10.5 c-0.847 -0.71 -2.132 -0.658 -2.914 0.116 a1.928 1.928 0 0 0 0 2.768 c0.782 0.774 2.067 0.825 2.914 0.116 M10.5 10.5 c-0.847 -0.71 -2.132 -0.658 -2.914 0.116 a1.928 1.928 0 0 0 0 2.768 c0.782 0.774 2.067 0.825 2.914 0.116 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.CreditCardOff:
					return "M11 15 l2 0 M7 15 l0.01 0 M15 11 l6 0 M3 11 l8 0 M18.87 18.872 a3 3 0 0 1 -0.87 0.128 h-12 a3 3 0 0 1 -3 -3 v-8 c0 -1.352 0.894 -2.495 2.124 -2.87 M9 5 h9 a3 3 0 0 1 3 3 v8 a3 3 0 0 1 -0.128 0.87 M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.CreditCard:
					return "M11 15 l2 0 M7 15 l0.01 0 M3 10 l18 0 M3 5 m0 3 a3 3 0 0 1 3 -3 h12 a3 3 0 0 1 3 3 v8 a3 3 0 0 1 -3 3 h-12 a3 3 0 0 1 -3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.Cricket:
					return "M14 18 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M10.5 7.5 l6 6 M11.105 18.79 l-1 0.992 a4.159 4.159 0 0 1 -6.038 -5.715 l0.157 -0.166 l8.282 -8.401 l1.5 1.5 l3.45 -3.391 a2.08 2.08 0 0 1 3.057 2.815 l-0.116 0.126 l-3.391 3.45 l1.5 1.5 l-3.668 3.617 M0 0 h24 v24 H0 z";
				case IconKind.Crop:
					return "M5 8 h10 a1 1 0 0 1 1 1 v10 M8 5 v10 a1 1 0 0 0 1 1 h10 M0 0 h24 v24 H0 z";
				case IconKind.CrossFilled:
					return "M10 21 h4 v-9 h5 v-4 h-5 v-5 h-4 v5 h-5 v4 h5 z M0 0 h24 v24 H0 z";
				case IconKind.CrossOff:
					return "M3 3 l18 18 M16 12 h3 v-4 h-5 v-5 h-4 v3 m-2 2 h-3 v4 h5 v9 h4 v-7 M0 0 h24 v24 H0 z";
				case IconKind.Cross:
					return "M10 21 h4 v-9 h5 v-4 h-5 v-5 h-4 v5 h-5 v4 h5 z M0 0 h24 v24 H0 z";
				case IconKind.Crosshair:
					return "M12 9 l0 6 M9 12 l6 0 M16 20 h2 a2 2 0 0 0 2 -2 v-2 M16 4 h2 a2 2 0 0 1 2 2 v2 M4 16 v2 a2 2 0 0 0 2 2 h2 M4 8 v-2 a2 2 0 0 1 2 -2 h2 M0 0 h24 v24 H0 z";
				case IconKind.CrownOff:
					return "M3 3 l18 18 M18 18 h-13 l-1.865 -9.327 a0.25 0.25 0 0 1 0.4 -0.244 l4.465 3.571 l1.6 -2.4 m1.596 -2.394 l0.804 -1.206 l4 6 l4.464 -3.571 a0.25 0.25 0 0 1 0.401 0.244 l-1.363 6.818 M0 0 h24 v24 H0 z";
				case IconKind.Crown:
					return "M12 6 l4 6 l5 -4 l-2 10 h-14 l-2 -10 l5 4 z M0 0 h24 v24 H0 z";
				case IconKind.CrutchesOff:
					return "M3 3 l18 18 M10 11 h1 M12 21 v-4.092 a3 3 0 0 0 -0.504 -1.664 l-0.992 -1.488 a3 3 0 0 1 -0.504 -1.664 v-2.092 M12 21 v-4.092 a3 3 0 0 1 0.504 -1.664 l0.992 -1.488 a3 3 0 0 0 0.097 -0.155 m0.407 -3.601 v-3 M11 21 h2 M8.178 4.174 a2 2 0 0 1 1.822 -1.174 h4 a2 2 0 1 1 0 4 h-3 M0 0 h24 v24 H0 z";
				case IconKind.Crutches:
					return "M10 11 h4 M12 21 v-4.092 a3 3 0 0 0 -0.504 -1.664 l-0.992 -1.488 a3 3 0 0 1 -0.504 -1.664 v-5.092 M12 21 v-4.092 a3 3 0 0 1 0.504 -1.664 l0.992 -1.488 a3 3 0 0 0 0.504 -1.664 v-5.092 M11 21 h2 M8 3 m0 2 a2 2 0 0 1 2 -2 h4 a2 2 0 0 1 2 2 v0 a2 2 0 0 1 -2 2 h-4 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.CrystalBall:
					return "M11 7 a3 3 0 0 0 -3 3 M5 19 a2 2 0 0 0 2 2 h10 a2 2 0 1 0 0 -4 h-10 a2 2 0 0 0 -2 2 z M6.73 17.018 a8 8 0 1 1 10.54 0 M0 0 h24 v24 H0 z";
				case IconKind.CubeSend:
					return "M7 15 h-1 M7 12 h-3 M7 9 h-5 M16 12.545 l5 -3.03 M11 9.5 v5.5 l5 3 M16 12.5 l-5 -3 l5 -3 l5 3 v5.5 l-5 3 z M0 0 h24 v24 H0 z";
				case IconKind.CubeUnfolded:
					return "M7 15 v-5 h5 v5 h5 v-5 M2 15 h10 v5 h5 v-5 h5 v-5 h-10 v-5 h-5 v5 h-5 z M0 0 h24 v24 H0 z";
				case IconKind.CupOff:
					return "M3 3 l18 18 M15 5 v-2 M6 8 v-1 c0 -0.296 0.064 -0.577 0.18 -0.83 m2.82 -1.17 h7 a2 2 0 0 1 2 2 v1 M17.5 11 l-0.323 2.154 m-0.525 3.497 l-0.652 4.349 h-8 l-1.5 -10 M8 8 h-3 v3 h6 m4 0 h4 v-3 h-7 M0 0 h24 v24 H0 z";
				case IconKind.Cup:
					return "M15 5 v-2 M6 8 v-1 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v1 M17.5 11 l-1.5 10 h-8 l-1.5 -10 M5 11 h14 v-3 h-14 z M0 0 h24 v24 H0 z";
				case IconKind.Curling:
					return "M8 5 h6 a2 2 0 0 1 2 2 v2 M4 14 h16 M4 9 m0 4 a4 4 0 0 1 4 -4 h8 a4 4 0 0 1 4 4 v2 a4 4 0 0 1 -4 4 h-8 a4 4 0 0 1 -4 -4 z M0 0 h24 v24 H0 z";
				case IconKind.CurlyLoop:
					return "M21 8 c-4 0 -7 2 -7 5 a3 3 0 0 0 6 0 c0 -3 -2.5 -5 -8 -5 s-8 2 -8 5 a3 3 0 0 0 6 0 c0 -3 -3 -5 -7 -5 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyAfghani:
					return "M12 19 v2 M12 3 v0.01 M15 13 h-3.5 a3.5 3.5 0 1 1 3.5 -3.5 v6.5 h-7 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyBahraini:
					return "M17 15 h2 a2 2 0 0 0 1.649 -3.131 l-2.653 -3.869 M14 15.01 v-0.01 M7 19.01 v-0.01 M3 10 v1 a4 4 0 0 0 4 4 h2 a2 2 0 0 0 2 -2 v-3 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyBaht:
					return "M11 18 v2 M11 4 v2 M8 6 v12 M8 12 h5 a3 3 0 0 1 3 3 v0.143 a2.857 2.857 0 0 1 -2.857 2.857 h-5.143 M8 6 h5 a3 3 0 0 1 3 3 v0.143 a2.857 2.857 0 0 1 -2.857 2.857 h-5.143 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyBitcoin:
					return "M13 18 l0 3 M9 18 l0 3 M13 3 l0 3 M9 3 l0 3 M8 12 l6 0 M8 6 l0 12 M6 6 h8 a3 3 0 0 1 0 6 a3 3 0 0 1 0 6 h-8 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyCent:
					return "M12 6 v-2 M12 20 v-2 M16.007 7.54 a5.965 5.965 0 0 0 -4.008 -1.54 a6 6 0 0 0 -5.992 6 c0 3.314 2.682 6 5.992 6 a5.965 5.965 0 0 0 4 -1.536 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyDinar:
					return "M16 17 l1 1 h2 a2 2 0 0 0 1.649 -3.131 l-2.653 -3.869 M3 14 v1 a3 3 0 0 0 3 3 h4.161 a3 3 0 0 0 2.983 -3.32 l-1.144 -10.68 M6 13 l2.386 -0.9 a1 1 0 0 0 -0.095 -1.902 l-1.514 -0.404 a1 1 0 0 1 -0.102 -1.9 l2.325 -0.894 M14 20.01 v-0.01 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyDirham:
					return "M11 13.01 v-0.01 M15 13 h1.888 a1.5 1.5 0 0 0 1.296 -2.256 l-2.184 -3.744 M7 4 v9 M8.599 16.479 a1.5 1.5 0 1 0 -1.099 2.521 M8.5 19 h-3.5 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyDogecoin:
					return "M6 18 h6 a6 6 0 1 0 0 -12 h-6 M9 6 v12 M6 12 h6 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyDollarAustralian:
					return "M4.5 14 h5 M18 6 v-2 M17 20 v-2 M21 6 h-4 a3 3 0 0 0 0 6 h1 a3 3 0 0 1 0 6 h-4 M3 18 l3.279 -11.476 a0.75 0.75 0 0 1 1.442 0 l3.279 11.476 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyDollarBrunei:
					return "M3 6 v12 h4 a3 3 0 0 0 0 -6 h-4 h4 a3 3 0 0 0 0 -6 h-4 z M18 6 v-2 M17 20 v-2 M21 6 h-4 a3 3 0 0 0 0 6 h1 a3 3 0 0 1 0 6 h-4 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyDollarCanadian:
					return "M18 6 v-2 M17 20 v-2 M10 18 h-1 a6 6 0 1 1 0 -12 h1 M21 6 h-4 a3 3 0 0 0 0 6 h1 a3 3 0 0 1 0 6 h-4 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyDollarGuyanese:
					return "M18 6 v-2 M17 20 v-2 M10 6 h-3 a4 4 0 0 0 -4 4 v4 a4 4 0 0 0 4 4 h3 v-6 h-2 M21 6 h-4 a3 3 0 0 0 0 6 h1 a3 3 0 0 1 0 6 h-4 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyDollarOff:
					return "M3 3 l18 18 M12 3 v3 m0 12 v3 M16.7 8 a3 3 0 0 0 -2.7 -2 h-4 m-2.557 1.431 a3 3 0 0 0 2.557 4.569 h2 m4.564 4.558 a3 3 0 0 1 -2.564 1.442 h-4 a3 3 0 0 1 -2.7 -2 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyDollarSingapore:
					return "M18 6 v-2 M17 20 v-2 M10 6 h-4 a3 3 0 1 0 0 6 h1 a3 3 0 0 1 0 6 h-4 M21 6 h-4 a3 3 0 0 0 0 6 h1 a3 3 0 0 1 0 6 h-4 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyDollarZimbabwean:
					return "M3 6 h7 l-7 12 h7 M18 6 v-2 M17 20 v-2 M21 6 h-4 a3 3 0 0 0 0 6 h1 a3 3 0 0 1 0 6 h-4 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyDollar:
					return "M12 3 v3 m0 12 v3 M16.7 8 a3 3 0 0 0 -2.7 -2 h-4 a3 3 0 0 0 0 6 h4 a3 3 0 0 1 0 6 h-4 a3 3 0 0 1 -2.7 -2 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyDong:
					return "M17 5 h-4 M16 16 v-12 M12 12 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M6 19 h12 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyDram:
					return "M12 12 h8 M12 16 h8 M4 10 a6 6 0 1 1 12 0 v10 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyEthereum:
					return "M6 12 l6 -3 l6 3 l-6 2 z M6 12 l6 -9 l6 9 l-6 9 z M0 0 h24 v24 H0 z";
				case IconKind.CurrencyEuroOff:
					return "M3 3 l18 18 M10 10 h-5 m0 4 h8 M17.2 7 c-1.977 -2.26 -4.954 -2.602 -7.234 -1.04 m-1.913 2.079 c-1.604 2.72 -1.374 6.469 0.69 8.894 c2.292 2.691 6 2.758 8.356 0.18 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyEuro:
					return "M13 10 h-8 m0 4 h8 M17.2 7 a6 7 0 1 0 0 10 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyForint:
					return "M19 9 h-5 M16 4 v13 a2 2 0 0 0 2 2 h2 M10 11 h-6 M11 4 h-4 a3 3 0 0 0 -3 3 v12 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyFrank:
					return "M9 11 h7 M7 15 h4 M17 5 h-6 a2 2 0 0 0 -2 2 v12 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyGuarani:
					return "M12 20 v-16 M16.007 7.54 a5.965 5.965 0 0 0 -4.008 -1.54 a6 6 0 0 0 -5.992 6 c0 3.314 2.682 6 5.992 6 a5.965 5.965 0 0 0 4 -1.536 c0.732 -0.66 1.064 -2.148 1 -4.464 h-5 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyHryvnia:
					return "M6 14 h12 M6 10 h12 M8 7 a2.64 2.64 0 0 1 2.562 -2 h3.376 a2.64 2.64 0 0 1 2.562 2 a2.57 2.57 0 0 1 -1.344 2.922 l-5.876 2.938 a3.338 3.338 0 0 0 -1.78 3.64 a3.11 3.11 0 0 0 3.05 2.5 h2.888 a2.64 2.64 0 0 0 2.562 -2 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyKip:
					return "M16 19 a7 7 0 0 0 -7 -7 a7 7 0 0 0 7 -7 M9 5 v14 M6 12 h12 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyKroneCzech:
					return "M19 12 h-2 a3 3 0 0 0 0 6 h2 M19 6 l-2 2 l-2 -2 M5 12 c3.5 0 6 3 6 6 M5 12 c3.5 0 6 -3 6 -6 M5 6 v12 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyKroneDanish:
					return "M20 18.01 v-0.01 M19 10 a4 4 0 0 0 -4 4 M15 10 v8 M5 12 c3.5 0 6 3 6 6 M5 12 c3.5 0 6 -3 6 -6 M5 6 v12 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyKroneSwedish:
					return "M19 10 a4 4 0 0 0 -4 4 M15 10 v8 M5 12 c3.5 0 6 3 6 6 M5 12 c3.5 0 6 -3 6 -6 M5 6 v12 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyLari:
					return "M14 12 v-7 M10 5 v7 M6 19 h12 M18 13 a6 6 0 1 0 -6 6 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyLeu:
					return "M17 18 h-7 a3 3 0 0 1 -3 -3 v-10 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyLira:
					return "M14 7 l-8 4 M6 15 l8 -4 M10 5 v15 a7 7 0 0 0 7 -7 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyLitecoin:
					return "M14 9 l-9 4 M18 19 h-8.194 a2 2 0 0 1 -1.98 -2.283 l1.674 -11.717 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyLyd:
					return "M5 8 l2.773 4.687 c0.427 0.697 0.234 1.626 -0.43 2.075 a1.38 1.38 0 0 1 -0.773 0.238 h-2.224 a0.93 0.93 0 0 1 -0.673 -0.293 l-0.673 -0.707 M21 5 v10 a2 2 0 0 1 -2 2 h-2.764 a2 2 0 0 1 -1.789 -1.106 l-0.447 -0.894 M11 15 h0.01 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyManat:
					return "M12 5 v14 M7 19 v-7 a5 5 0 1 1 10 0 v7 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyMonero:
					return "M3 18 h3 v-11 l6 7 l6 -7 v11 h3 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyNaira:
					return "M5 14 h14 M5 10 h14 M7 18 v-10.948 a1.05 1.05 0 0 1 1.968 -0.51 l6.064 10.916 a1.05 1.05 0 0 0 1.968 -0.51 v-10.948 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyOff:
					return "M3 3 l18 18 M20 20 l-3 -3 M4 20 l3 -3 M20 4 l-3 3 M4 4 l3 3 M18.531 14.524 a7 7 0 0 0 -9.06 -9.053 m-2.422 1.582 a7 7 0 0 0 9.903 9.896 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyPaanga:
					return "M7 6 v12 M3 6 h8 M18 6 v-2 M17 20 v-2 M21 6 h-4 a3 3 0 0 0 0 6 h1 a3 3 0 0 1 0 6 h-4 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyPeso:
					return "M18 11 h-12 M18 8 h-12 M8 19 v-14 h3.5 a4.5 4.5 0 1 1 0 9 h-3.5 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyPoundOff:
					return "M3 3 l18 18 M17 18.5 a6 6 0 0 1 -5 0 a6 6 0 0 0 -5 0.5 a3 3 0 0 0 2 -2.5 v-7.5 m1.192 -2.825 a4 4 0 0 1 6.258 0.825 m-3.45 6 h-6 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyPound:
					return "M17 18.5 a6 6 0 0 1 -5 0 a6 6 0 0 0 -5 0.5 a3 3 0 0 0 2 -2.5 v-7.5 a4 4 0 0 1 7.45 -2 m-2.55 6 h-7 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyQuetzal:
					return "M13 13 l5 5 M12 12 m-6 0 a6 6 0 1 0 12 0 a6 6 0 1 0 -12 0 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyReal:
					return "M17 20 v-2 M18 6 v-2 M4 18 v-12 h3 a3 3 0 1 1 0 6 h-3 c5.5 0 5 4 6 6 M21 6 h-4 a3 3 0 0 0 0 6 h1 a3 3 0 0 1 0 6 h-4 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyRenminbi:
					return "M9 9 v4 c0 2.5 -0.667 4 -2 6 M19 5 h-14 M19 9 h-14 M15 9 v8 a2 2 0 1 0 4 0 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyRipple:
					return "M15 14.5 l-2 -2.5 M10 12 h3 l2 -2.5 M17 17 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M17 7 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M7 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyRiyal:
					return "M22 10 v1 a5 5 0 0 1 -5 5 M18 12.01 v-0.01 M15 9 v2 a2 2 0 1 1 -4 0 v-1 v1 a2 2 0 1 1 -4 0 v-1 v4 a2 2 0 1 1 -4 0 v-2 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyRubel:
					return "M14 15 h-8 M8 19 v-14 h6 a3 3 0 0 1 0 6 h-8 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyRufiyaa:
					return "M12 8 l5 3 M4 16 c9.5 -4 11.5 -8 14 -9 M20 16 h0.01 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyRupeeNepalese:
					return "M21 17 l-4.586 -4.414 a2 2 0 0 0 -2.828 2.828 l0.707 0.707 M15 5 h-11 h3 a4 4 0 1 1 0 8 h-3 l6 6 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyRupee:
					return "M7 9 l11 0 M18 5 h-11 h3 a4 4 0 0 1 0 8 h-3 l6 6 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyShekel:
					return "M18 6 v12 h-4 a4 4 0 0 1 -4 -4 v-4 M6 18 v-12 h4 a4 4 0 0 1 4 4 v4 M0 0 h24 v24 H0 z";
				case IconKind.CurrencySolana:
					return "M16 10 l4 -4 h-12 l-4 4 M8 14 l-4 -4 h12 l4 4 M4 18 h12 l4 -4 h-12 z M0 0 h24 v24 H0 z";
				case IconKind.CurrencySom:
					return "M14 6 v12 h4 a3 3 0 0 0 0 -6 h-4 h4 a3 3 0 0 0 0 -6 h-4 z M10 18 v-12 h-5 v10 a2 2 0 0 1 -2 2 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyTaka:
					return "M8 11 h6 M7 7 a2 2 0 1 1 4 0 v9 a3 3 0 0 0 6 0 v-0.5 M16.5 15.5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyTenge:
					return "M12 9 v10 M6 9 h12 M6 5 h12 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyTugrik:
					return "M16 10 l-8 3 M8 17 l8 -3 M12 6 v13 M7 6 h10 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyWon:
					return "M21 14 h-18 M21 10 h-18 M4 6 l3.245 11.358 a0.85 0.85 0 0 0 1.624 0.035 l3.131 -9.393 l3.131 9.393 a0.85 0.85 0 0 0 1.624 -0.035 l3.245 -11.358 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyYenOff:
					return "M3 3 l18 18 M8 13 h5 M8 17 h8 M12 19 v-7 m5 -7 l-3.328 4.66 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyYen:
					return "M8 13 l8 0 M8 17 l8 0 M12 19 v-7 l-5 -7 m10 0 l-5 7 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyYuan:
					return "M8 13 h8 M17 5 l-5 7 M12 19 v-7 l-5 -7 M0 0 h24 v24 H0 z";
				case IconKind.CurrencyZloty:
					return "M14 14.5 l6 -3.5 M17 18 v-13 M12 18 h-7 l7 -7 h-7 M0 0 h24 v24 H0 z";
				case IconKind.Currency:
					return "M20 20 l-3 -3 M4 20 l3 -3 M20 4 l-3 3 M4 4 l3 3 M12 12 m-7 0 a7 7 0 1 0 14 0 a7 7 0 1 0 -14 0 M0 0 h24 v24 H0 z";
				case IconKind.CurrentLocationOff:
					return "M3 3 l18 18 M2 12 h2 M20 12 h2 M12 20 v2 M12 2 v2 M6.357 6.33 a8 8 0 1 0 11.301 11.326 m1.642 -2.378 a8 8 0 0 0 -10.597 -10.569 M14.685 10.661 c-0.3 -0.6 -0.795 -1.086 -1.402 -1.374 m-3.397 0.584 a3 3 0 1 0 4.24 4.245 M0 0 h24 v24 H0 z";
				case IconKind.CurrentLocation:
					return "M2 12 l2 0 M20 12 l2 0 M12 20 l0 2 M12 2 l0 2 M12 12 m-8 0 a8 8 0 1 0 16 0 a8 8 0 1 0 -16 0 M12 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.CursorOff:
					return "M3 3 l18 18 M15 4 a3 3 0 0 0 -3 3 v1 m0 4 v5 a3 3 0 0 0 3 3 M9 4 a3 3 0 0 1 3 3 v1 m0 9 a3 3 0 0 1 -3 3 M0 0 h24 v24 H0 z";
				case IconKind.CursorText:
					return "M15 4 a3 3 0 0 0 -3 3 v10 a3 3 0 0 0 3 3 M9 4 a3 3 0 0 1 3 3 v10 a3 3 0 0 1 -3 3 M10 12 h4 M0 0 h24 v24 H0 z";
				case IconKind.Cut:
					return "M6 4 l8.85 10.85 M9.15 14.85 l8.85 -10.85 M17 17 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M7 17 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.Cylinder:
					return "M7 6 v12 c0 1.657 2.239 3 5 3 s5 -1.343 5 -3 v-12 M12 6 m-5 0 a5 3 0 1 0 10 0 a5 3 0 1 0 -10 0 M0 0 h24 v24 H0 z";
				case IconKind.DashboardOff:
					return "M3 3 l18 18 M8.621 4.612 a9 9 0 0 1 11.721 11.72 m-1.516 2.488 a9.008 9.008 0 0 1 -1.226 1.18 h-11.2 a9 9 0 0 1 -0.268 -13.87 M14.5 10.5 l1 -1 M11.175 11.178 a2 2 0 1 0 2.653 2.634 M0 0 h24 v24 H0 z";
				case IconKind.Dashboard:
					return "M6.4 20 a9 9 0 1 1 11.2 0 z M13.45 11.55 l2.05 -2.05 M12 13 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.DatabaseExport:
					return "M4 12 v6 c0 1.599 3.335 2.905 7.538 3 m8.462 -7 v-2 m-6 7 h7 m-3 -3 l3 3 l-3 3 M4 6 v6 c0 1.657 3.582 3 8 3 a19.84 19.84 0 0 0 3.302 -0.267 m4.698 -2.733 v-6 M12 6 m-8 0 a8 3 0 1 0 16 0 a8 3 0 1 0 -16 0 M0 0 h24 v24 H0 z";
				case IconKind.DatabaseImport:
					return "M11.252 20.987 c0.246 0.009 0.496 0.013 0.748 0.013 c4.418 0 8 -1.343 8 -3 v-6 m-18 7 h7 m-3 -3 l3 3 l-3 3 M4 6 v8 m5.009 0.783 c0.924 0.14 1.933 0.217 2.991 0.217 c4.418 0 8 -1.343 8 -3 v-6 M12 6 m-8 0 a8 3 0 1 0 16 0 a8 3 0 1 0 -16 0 M0 0 h24 v24 H0 z";
				case IconKind.DatabaseOff:
					return "M3 3 l18 18 M4 12 v6 c0 1.657 3.582 3 8 3 c3.217 0 5.991 -0.712 7.261 -1.74 m0.739 -3.26 v-4 M4 6 v6 c0 1.657 3.582 3 8 3 c0.986 0 1.93 -0.067 2.802 -0.19 m3.187 -0.82 c1.251 -0.53 2.011 -1.228 2.011 -1.99 v-6 M12.983 8.978 c3.955 -0.182 7.017 -1.446 7.017 -2.978 c0 -1.657 -3.582 -3 -8 -3 c-1.661 0 -3.204 0.19 -4.483 0.515 m-2.783 1.228 c-0.471 0.382 -0.734 0.808 -0.734 1.257 c0 1.22 1.944 2.271 4.734 2.74 M0 0 h24 v24 H0 z";
				case IconKind.Database:
					return "M4 12 v6 a8 3 0 0 0 16 0 v-6 M4 6 v6 a8 3 0 0 0 16 0 v-6 M12 6 m-8 0 a8 3 0 1 0 16 0 a8 3 0 1 0 -16 0 M0 0 h24 v24 H0 z";
				case IconKind.Deer:
					return "M12 15 h0.01 M15.5 10 l1.5 -1 M8.5 10 l-1.5 -1 M17 6 c2.667 0.667 4.333 1.667 5 3 M7 6 c-2.667 0.667 -4.333 1.667 -5 3 M7 3 c0 1.333 0.333 2.333 1 3 M17 3 c0 1.333 -0.333 2.333 -1 3 M15.185 14.889 l0.095 -0.18 a4 4 0 1 1 -6.56 0 M12 18 c-1 0 -4 -3 -4 -6 c0 -2 1.333 -3 4 -3 s4 1 4 3 c0 3 -3 6 -4 6 M21 3 c0 2 -1 3 -4 3 c-2 0 -3 0.333 -3 3 M3 3 c0 2 1 3 4 3 c2 0 3 1 3 3 M0 0 h24 v24 H0 z";
				case IconKind.Delta:
					return "M4 20 h16 l-8 -16 z M0 0 h24 v24 H0 z";
				case IconKind.DentalBroken:
					return "M12 5.5 l1 2.5 l-2 2 l2 2 M12 5.5 c-1.074 -0.586 -2.583 -1.5 -4 -1.5 c-2.1 0 -4 1.247 -4 5 c0 4.899 1.056 8.41 2.671 10.537 c0.573 0.756 1.97 0.521 2.567 -0.236 c0.398 -0.505 0.819 -1.439 1.262 -2.801 c0.292 -0.771 0.892 -1.504 1.5 -1.5 c0.602 0 1.21 0.737 1.5 1.5 c0.443 1.362 0.864 2.295 1.262 2.8 c0.597 0.759 2 0.993 2.567 0.237 c1.615 -2.127 2.671 -5.637 2.671 -10.537 c0 -3.74 -1.908 -5 -4 -5 c-1.423 0 -2.92 0.911 -4 1.5 z M0 0 h24 v24 H0 z";
				case IconKind.DentalOff:
					return "M3 3 l18 18 M12 5.5 l3 1.5 M19.277 15.281 c0.463 -1.75 0.723 -3.844 0.723 -6.281 c0 -3.74 -1.908 -5 -4 -5 c-1.423 0 -2.92 0.911 -4 1.5 c-1.074 -0.586 -2.583 -1.5 -4 -1.5 m-2.843 1.153 c-0.707 0.784 -1.157 2.017 -1.157 3.847 c0 4.899 1.056 8.41 2.671 10.537 c0.573 0.756 1.97 0.521 2.567 -0.236 c0.398 -0.505 0.819 -1.439 1.262 -2.801 c0.292 -0.771 0.892 -1.504 1.5 -1.5 c0.602 0 1.21 0.737 1.5 1.5 c0.443 1.362 0.864 2.295 1.262 2.8 c0.597 0.759 2 0.993 2.567 0.237 c0.305 -0.402 0.59 -0.853 0.852 -1.353 M0 0 h24 v24 H0 z";
				case IconKind.Dental:
					return "M12 5.5 l3 1.5 M12 5.5 c-1.074 -0.586 -2.583 -1.5 -4 -1.5 c-2.1 0 -4 1.247 -4 5 c0 4.899 1.056 8.41 2.671 10.537 c0.573 0.756 1.97 0.521 2.567 -0.236 c0.398 -0.505 0.819 -1.439 1.262 -2.801 c0.292 -0.771 0.892 -1.504 1.5 -1.5 c0.602 0 1.21 0.737 1.5 1.5 c0.443 1.362 0.864 2.295 1.262 2.8 c0.597 0.759 2 0.993 2.567 0.237 c1.615 -2.127 2.671 -5.637 2.671 -10.537 c0 -3.74 -1.908 -5 -4 -5 c-1.423 0 -2.92 0.911 -4 1.5 z M0 0 h24 v24 H0 z";
				case IconKind.DetailsOff:
					return "M3 3 l18 18 M12 3 v5 m0 4 v7 M20.986 16.984 a2 2 0 0 0 -0.146 -0.734 l-7.1 -12.25 a2 2 0 0 0 -3.5 0 l-0.821 1.417 m-1.469 2.534 l-4.81 8.299 a2 2 0 0 0 1.75 2.75 M5 19 h14 M0 0 h24 v24 H0 z";
				case IconKind.Details:
					return "M12 3 v16 M5 19 h14 a2 2 0 0 0 1.84 -2.75 l-7.1 -12.25 a2 2 0 0 0 -3.5 0 l-7.1 12.25 a2 2 0 0 0 1.75 2.75 M0 0 h24 v24 H0 z";
				case IconKind.DeviceAirpodsCase:
					return "M7 10 v1.5 a1.5 1.5 0 0 0 1.5 1.5 h7 a1.5 1.5 0 0 0 1.5 -1.5 v-1.5 M3 4 m0 4 a4 4 0 0 1 4 -4 h10 a4 4 0 0 1 4 4 v8 a4 4 0 0 1 -4 4 h-10 a4 4 0 0 1 -4 -4 z M21 10 h-18 M0 0 h24 v24 H0 z";
				case IconKind.DeviceAirpods:
					return "M18 4 a4 4 0 0 0 -4 3.8 l0 0.2 v10.5 a1.5 1.5 0 0 0 3 0 v-6.5 h1 a4 4 0 0 0 4 -3.8 l0 -0.2 a4 4 0 0 0 -4 -4 z M6 4 a4 4 0 0 1 4 3.8 l0 0.2 v10.5 a1.5 1.5 0 0 1 -3 0 v-6.5 h-1 a4 4 0 0 1 -4 -3.8 l0 -0.2 a4 4 0 0 1 4 -4 z M0 0 h24 v24 H0 z";
				case IconKind.DeviceAnalytics:
					return "M8 12 l3 -3 l2 2 l3 -3 M15 16 l0 4 M9 16 l0 4 M7 20 l10 0 M3 4 m0 1 a1 1 0 0 1 1 -1 h16 a1 1 0 0 1 1 1 v10 a1 1 0 0 1 -1 1 h-16 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.DeviceAudioTape:
					return "M16,9.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M7,9.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M3 17 l4 -3 h10 l4 3 M3 5 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.DeviceCameraPhone:
					return "M17 15 v-1 M13 7 h-8 a2 2 0 0 0 -2 2 v7 a2 2 0 0 0 2 2 h13 a2 2 0 0 0 2 -2 v-2 M18.5 8.5 m-2.5 0 a2.5 2.5 0 1 0 5 0 a2.5 2.5 0 1 0 -5 0 M0 0 h24 v24 H0 z";
				case IconKind.DeviceCctvOff:
					return "M3 3 l18 18 M12 14 h0.01 M19 7 v7 c0 0.321 -0.022 0.637 -0.064 0.947 m-1.095 2.913 a7 7 0 0 1 -12.841 -3.86 l0 -7 M10.36 10.35 a4 4 0 1 0 5.285 5.3 M7 7 h-3 a1 1 0 0 1 -1 -1 v-2 c0 -0.275 0.11 -0.523 0.29 -0.704 m3.71 -0.296 h13 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-9 M0 0 h24 v24 H0 z";
				case IconKind.DeviceCctv:
					return "M12 14 l0.01 0 M19 7 v7 a7 7 0 0 1 -14 0 v-7 M12 14 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M3 3 m0 1 a1 1 0 0 1 1 -1 h16 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-16 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.DeviceComputerCameraOff:
					return "M3 3 l18 18 M8 16 l-2.091 3.486 a1 1 0 0 0 0.857 1.514 h10.468 a1 1 0 0 0 0.857 -1.514 l-2.091 -3.486 M9.13 9.122 a3 3 0 0 0 3.743 3.749 m2 -2 a3 3 0 0 0 -3.737 -3.736 M6.15 6.153 a7 7 0 0 0 9.696 9.696 m2 -2 a7 7 0 0 0 -9.699 -9.695 M0 0 h24 v24 H0 z";
				case IconKind.DeviceComputerCamera:
					return "M8 16 l-2.091 3.486 a1 1 0 0 0 0.857 1.514 h10.468 a1 1 0 0 0 0.857 -1.514 l-2.091 -3.486 M12 10 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M12 10 m-7 0 a7 7 0 1 0 14 0 a7 7 0 1 0 -14 0 M0 0 h24 v24 H0 z";
				case IconKind.DeviceDesktopAnalytics:
					return "M12 12 v-1 M15 12 v-2 M12 12 v-1 M9 12 v-4 M15 16 v4 M9 16 v4 M7 20 h10 M3 4 m0 1 a1 1 0 0 1 1 -1 h16 a1 1 0 0 1 1 1 v10 a1 1 0 0 1 -1 1 h-16 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.DeviceDesktopOff:
					return "M3 3 l18 18 M15 16 l0 4 M9 16 l0 4 M7 20 l10 0 M8 4 h12 a1 1 0 0 1 1 1 v10 a1 1 0 0 1 -1 1 m-4 0 h-12 a1 1 0 0 1 -1 -1 v-10 a1 1 0 0 1 1 -1 M0 0 h24 v24 H0 z";
				case IconKind.DeviceDesktop:
					return "M15 16 l0 4 M9 16 l0 4 M7 20 l10 0 M3 4 m0 1 a1 1 0 0 1 1 -1 h16 a1 1 0 0 1 1 1 v10 a1 1 0 0 1 -1 1 h-16 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.DeviceFloppy:
					return "M14 4 l0 4 l-6 0 l0 -4 M12 14 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 4 h10 l4 4 v10 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 v-12 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.DeviceGamepad2:
					return "M14 10 h2 M7 10 h2 M8 9 v2 M14 15 l4.07 4.284 a2.3 2.3 0 0 0 3.925 -2.023 l-1.6 -8.232 M12 5 h3.5 a5 5 0 0 1 0 10 h-5.5 l-4.015 4.227 a2.3 2.3 0 0 1 -3.923 -2.035 l1.634 -8.173 a5 5 0 0 1 4.904 -4.019 h3.4 z M0 0 h24 v24 H0 z";
				case IconKind.DeviceGamepad:
					return "M18 13 l0 0.01 M15 11 l0 0.01 M6 12 h4 m-2 -2 v4 M2 6 m0 2 a2 2 0 0 1 2 -2 h16 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-16 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.DeviceHeartMonitor:
					return "M17 17 v0.01 M14 17 v0.01 M4 14 h16 M4 9 h6 l1 -2 l2 4 l1 -2 h6 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.DeviceIpadHorizontal:
					return "M9 17 h6 M2 4 m0 2 a2 2 0 0 1 2 -2 h16 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-16 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.DeviceIpad:
					return "M9 19 h6 M20 4 v16 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 v-16 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 z M0 0 h24 v24 H0 z";
				case IconKind.DeviceLandlinePhone:
					return "M6 17 v0.01 M9 17 v0.01 M12 17 v0.01 M6 14 v0.01 M9 14 v0.01 M12 14 v0.01 M12 8 h-6 v3 h6 z M16 4 h-11 a3 3 0 0 0 -3 3 v10 a3 3 0 0 0 3 3 h11 M20 3 h-2 a2 2 0 0 0 -2 2 v14 a2 2 0 0 0 2 2 h2 a2 2 0 0 0 2 -2 v-14 a2 2 0 0 0 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.DeviceLaptopOff:
					return "M3 3 l18 18 M10 6 h8 a1 1 0 0 1 1 1 v8 m-3 1 h-10 a1 1 0 0 1 -1 -1 v-8 a1 1 0 0 1 1 -1 M3 19 h16 M0 0 h24 v24 H0 z";
				case IconKind.DeviceLaptop:
					return "M5 6 m0 1 a1 1 0 0 1 1 -1 h12 a1 1 0 0 1 1 1 v8 a1 1 0 0 1 -1 1 h-12 a1 1 0 0 1 -1 -1 z M3 19 l18 0 M0 0 h24 v24 H0 z";
				case IconKind.DeviceMobileCharging:
					return "M12 9.5 l-1 2.5 h2 l-1 2.5 M11 4 h2 M6 3 m0 2 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v14 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.DeviceMobileMessage:
					return "M10 18 v0.01 M15 16 v4 a1 1 0 0 1 -1 1 h-8 a1 1 0 0 1 -1 -1 v-14 a1 1 0 0 1 1 -1 h2 M11 3 h10 v8 h-3 l-4 2 v-2 h-3 z M0 0 h24 v24 H0 z";
				case IconKind.DeviceMobileOff:
					return "M3 3 l18 18 M12 17 v0.01 M11 4 h2 M7.174 3.178 c0.252 -0.114 0.531 -0.178 0.826 -0.178 h8 a2 2 0 0 1 2 2 v9 m0 4 v1 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 v-13 M0 0 h24 v24 H0 z";
				case IconKind.DeviceMobileRotated:
					return "M7 12 h-0.01 M20 11 v2 M3 6 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.DeviceMobileVibration:
					return "M21 6 l-2 3 l2 3 l-2 3 l2 3 M9 17 l0 0.01 M8 4 l2 0 M3 3 m0 2 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v14 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.DeviceMobile:
					return "M12 17 l0 0.01 M11 4 l2 0 M6 3 m0 2 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v14 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.DeviceNintendoOff:
					return "M3 3 l18 18 M6.5 8.5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M14 10 v-6 h3 a4 4 0 0 1 4 4 v8 c0 0.308 -0.035 0.608 -0.1 0.896 m-1.62 2.39 a3.982 3.982 0 0 1 -2.28 0.714 h-3 v-6 M4.713 4.718 a4 4 0 0 0 -1.713 3.282 v8 a4 4 0 0 0 4 4 h3 v-10 m0 -4 v-2 h-2 M0 0 h24 v24 H0 z";
				case IconKind.DeviceNintendo:
					return "M5.5,8.5a1,1 0 1,0 2,0a1,1 0 1,0 -2,0 M16.5,15.5a1,1 0 1,0 2,0a1,1 0 1,0 -2,0 M14 20 v-16 h3 a4 4 0 0 1 4 4 v8 a4 4 0 0 1 -4 4 h-3 z M10 20 v-16 h-3 a4 4 0 0 0 -4 4 v8 a4 4 0 0 0 4 4 h3 z M0 0 h24 v24 H0 z";
				case IconKind.DeviceSdCard:
					return "M10 7 v1 M16 6 v2 M13 6 v2 M7 21 h10 a2 2 0 0 0 2 -2 v-14 a2 2 0 0 0 -2 -2 h-6.172 a2 2 0 0 0 -1.414 0.586 l-3.828 3.828 a2 2 0 0 0 -0.586 1.414 v10.172 a2 2 0 0 0 2 2 z M0 0 h24 v24 H0 z";
				case IconKind.DeviceSim1:
					return "M10 11 l2 -2 v8 M6 3 h8.5 l4.5 4.5 v12.5 a1 1 0 0 1 -1 1 h-12 a1 1 0 0 1 -1 -1 v-16 a1 1 0 0 1 1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.DeviceSim2:
					return "M10 9 h3 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 0 -1 1 v2 a1 1 0 0 0 1 1 h3 M6 3 h8.5 l4.5 4.5 v12.5 a1 1 0 0 1 -1 1 h-12 a1 1 0 0 1 -1 -1 v-16 a1 1 0 0 1 1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.DeviceSim3:
					return "M10 9 h2.5 a1.5 1.5 0 0 1 1.5 1.5 v1 a1.5 1.5 0 0 1 -1.5 1.5 h-1.5 h1.5 a1.5 1.5 0 0 1 1.5 1.5 v1 a1.5 1.5 0 0 1 -1.5 1.5 h-2.5 M6 3 h8.5 l4.5 4.5 v12.5 a1 1 0 0 1 -1 1 h-12 a1 1 0 0 1 -1 -1 v-16 a1 1 0 0 1 1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.DeviceSim:
					return "M9 17 v0.01 M9 14 v0.01 M15 11 v0.01 M15 14 v0.01 M15 17 v0.01 M9 11 h3 v6 M6 3 h8.5 l4.5 4.5 v12.5 a1 1 0 0 1 -1 1 h-12 a1 1 0 0 1 -1 -1 v-16 a1 1 0 0 1 1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.DeviceSpeakerOff:
					return "M3 3 l18 18 M12 7 v0.01 M11.114 11.133 a3 3 0 1 0 3.754 3.751 M7 3 h10 a2 2 0 0 1 2 2 v10 m0 4 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 v-14 M0 0 h24 v24 H0 z";
				case IconKind.DeviceSpeaker:
					return "M12 7 l0 0.01 M12 14 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M5 3 m0 2 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v14 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.DeviceTabletOff:
					return "M3 3 l18 18 M12 17 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M7 3 h11 a1 1 0 0 1 1 1 v11 m0 4 v1 a1 1 0 0 1 -1 1 h-12 a1 1 0 0 1 -1 -1 v-15 M0 0 h24 v24 H0 z";
				case IconKind.DeviceTablet:
					return "M12 17 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M5 3 m0 1 a1 1 0 0 1 1 -1 h12 a1 1 0 0 1 1 1 v16 a1 1 0 0 1 -1 1 h-12 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.DeviceTvOff:
					return "M3 3 l18 18 M16 3 l-4 4 l-4 -4 M11 7 h8 a2 2 0 0 1 2 2 v8 m-1.178 2.824 c-0.25 0.113 -0.529 0.176 -0.822 0.176 h-14 a2 2 0 0 1 -2 -2 v-9 a2 2 0 0 1 2 -2 h2 M0 0 h24 v24 H0 z";
				case IconKind.DeviceTvOld:
					return "M18 12 v0.01 M18 15 v0.01 M15 7 v13 M16 3 l-4 4 l-4 -4 M3 7 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v9 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.DeviceTv:
					return "M16 3 l-4 4 l-4 -4 M3 7 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v9 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.DeviceWatchOff:
					return "M3 3 l18 18 M9 5 v-2 h6 v3 M9 18 v3 h6 v-3 M10 6 h5 a3 3 0 0 1 3 3 v5 m-0.882 3.125 a2.99 2.99 0 0 1 -2.118 0.875 h-6 a3 3 0 0 1 -3 -3 v-6 c0 -0.828 0.336 -1.578 0.878 -2.121 M0 0 h24 v24 H0 z";
				case IconKind.DeviceWatchStats2:
					return "M12 10 a2 2 0 1 0 2 2 M9 6 v-3 h6 v3 M9 18 v3 h6 v-3 M6 6 m0 3 a3 3 0 0 1 3 -3 h6 a3 3 0 0 1 3 3 v6 a3 3 0 0 1 -3 3 h-6 a3 3 0 0 1 -3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.DeviceWatchStats:
					return "M15 14 v-3 M12 14 v-1 M9 14 v-4 M9 6 v-3 h6 v3 M9 18 v3 h6 v-3 M6 6 m0 3 a3 3 0 0 1 3 -3 h6 a3 3 0 0 1 3 3 v6 a3 3 0 0 1 -3 3 h-6 a3 3 0 0 1 -3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.DeviceWatch:
					return "M9 6 v-3 h6 v3 M9 18 v3 h6 v-3 M6 6 m0 3 a3 3 0 0 1 3 -3 h6 a3 3 0 0 1 3 3 v6 a3 3 0 0 1 -3 3 h-6 a3 3 0 0 1 -3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.Devices2:
					return "M9 15 l0 4 M17 16 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M17 8 l0 0.01 M7 19 l3 0 M13 4 m0 1 a1 1 0 0 1 1 -1 h6 a1 1 0 0 1 1 1 v14 a1 1 0 0 1 -1 1 h-6 a1 1 0 0 1 -1 -1 z M10 15 h-6 a1 1 0 0 1 -1 -1 v-8 a1 1 0 0 1 1 -1 h6 M0 0 h24 v24 H0 z";
				case IconKind.DevicesOff:
					return "M3 3 l18 18 M16 9 h2 M18 8 v-3 a1 1 0 0 0 -1 -1 h-9 m-4 0 a1 1 0 0 0 -1 1 v12 a1 1 0 0 0 1 1 h9 M13 9 a1 1 0 0 1 1 -1 h6 a1 1 0 0 1 1 1 v8 m-1 3 h-6 a1 1 0 0 1 -1 -1 v-6 M0 0 h24 v24 H0 z";
				case IconKind.DevicesPcOff:
					return "M3 3 l18 18 M6 16 v0.01 M6 13 v0.01 M17 17 v2 M14 19 h5 M13 9 h9 v7 h-2 m-4 0 h-4 v-4 M9 9 v10 h-6 v-14 h2 M0 0 h24 v24 H0 z";
				case IconKind.DevicesPc:
					return "M6 16 v0.01 M6 13 v0.01 M17 16 v3 M14 19 h6 M12 9 h10 v7 h-10 z M3 5 h6 v14 h-6 z M0 0 h24 v24 H0 z";
				case IconKind.Devices:
					return "M16 9 l2 0 M18 8 v-3 a1 1 0 0 0 -1 -1 h-13 a1 1 0 0 0 -1 1 v12 a1 1 0 0 0 1 1 h9 M13 8 m0 1 a1 1 0 0 1 1 -1 h6 a1 1 0 0 1 1 1 v10 a1 1 0 0 1 -1 1 h-6 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.DialpadOff:
					return "M3 3 l18 18 M10 17 h4 v4 h-4 z M14 14 h-4 v-4 M17 13 v-3 h4 v4 h-3 M3 10 h4 v4 h-4 z M10 6 v-3 h4 v4 h-3 M17 3 h4 v4 h-4 z M7 7 h-4 v-4 M0 0 h24 v24 H0 z";
				case IconKind.Dialpad:
					return "M10 17 h4 v4 h-4 z M10 10 h4 v4 h-4 z M17 10 h4 v4 h-4 z M3 10 h4 v4 h-4 z M10 3 h4 v4 h-4 z M17 3 h4 v4 h-4 z M3 3 h4 v4 h-4 z M0 0 h24 v24 H0 z";
				case IconKind.DiamondOff:
					return "M3 3 l18 18 M10 12 l-2 -2.2 l0.6 -1 M9 5 h9 l3 5 l-3.308 3.697 m-1.883 2.104 l-3.309 3.699 a0.7 0.7 0 0 1 -1 0 l-8.5 -9.5 l2.62 -4.368 M0 0 h24 v24 H0 z";
				case IconKind.Diamond:
					return "M10 12 l-2 -2.2 l0.6 -1 M6 5 h12 l3 5 l-8.5 9.5 a0.7 0.7 0 0 1 -1 0 l-8.5 -9.5 l3 -5 M0 0 h24 v24 H0 z";
				case IconKind.DiamondsFilled:
					return "M10.831 20.413 l-5.375 -6.91 c-0.608 -0.783 -0.608 -2.223 0 -3 l5.375 -6.911 a1.457 1.457 0 0 1 2.338 0 l5.375 6.91 c0.608 0.783 0.608 2.223 0 3 l-5.375 6.911 a1.457 1.457 0 0 1 -2.338 0 z M0 0 h24 v24 H0 z";
				case IconKind.Diamonds:
					return "M10.831 20.413 l-5.375 -6.91 c-0.608 -0.783 -0.608 -2.223 0 -3 l5.375 -6.911 a1.457 1.457 0 0 1 2.338 0 l5.375 6.91 c0.608 0.783 0.608 2.223 0 3 l-5.375 6.911 a1.457 1.457 0 0 1 -2.338 0 z M0 0 h24 v24 H0 z";
				case IconKind.Dice1:
					return "M11.5,12a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Dice2:
					return "M14,14.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M9,9.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Dice3:
					return "M11.5,12a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M15,15.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M8,8.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Dice4:
					return "M8,15.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M15,15.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M15,8.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M8,8.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Dice5:
					return "M11.5,12a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M8,15.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M15,15.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M15,8.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M8,8.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Dice6:
					return "M8,16.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M15,16.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M15,12a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M8,12a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M15,7.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M8,7.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Dice:
					return "M8,15.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M15,15.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M15,8.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M8,8.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Dimensions:
					return "M3 10 m0 2 a2 2 0 0 1 2 -2 h7 a2 2 0 0 1 2 2 v7 a2 2 0 0 1 -2 2 h-7 a2 2 0 0 1 -2 -2 z M21 12 l-2 -2 l-2 2 M17 19 l2 2 l2 -2 M19 10 v11 M5 3 l-2 2 l2 2 M12 7 l2 -2 l-2 -2 M3 5 h11 M0 0 h24 v24 H0 z";
				case IconKind.DirectionHorizontal:
					return "M14 9 l3 3 l-3 3 M10 9 l-3 3 l3 3 M0 0 h24 v24 H0 z";
				case IconKind.DirectionSignOff:
					return "M3 3 l18 18 M13.748 13.752 l-1.748 1.748 M8 12 h4 M18.73 14.724 l1.949 -1.95 a1.095 1.095 0 0 0 0 -1.548 l-7.905 -7.905 a1.095 1.095 0 0 0 -1.548 0 l-1.95 1.95 m-2.01 2.01 l-3.945 3.945 a1.095 1.095 0 0 0 0 1.548 l7.905 7.905 c0.427 0.428 1.12 0.428 1.548 0 l3.95 -3.95 M0 0 h24 v24 H0 z";
				case IconKind.DirectionSign:
					return "M12 8.5 l3.5 3.5 l-3.5 3.5 M8 12 h7.5 M3.32 12.774 l7.906 7.905 c0.427 0.428 1.12 0.428 1.548 0 l7.905 -7.905 a1.095 1.095 0 0 0 0 -1.548 l-7.905 -7.905 a1.095 1.095 0 0 0 -1.548 0 l-7.905 7.905 a1.095 1.095 0 0 0 0 1.548 z M0 0 h24 v24 H0 z";
				case IconKind.Direction:
					return "M9 14 l3 3 l3 -3 M9 10 l3 -3 l3 3 M0 0 h24 v24 H0 z";
				case IconKind.DirectionsOff:
					return "M3 3 l18 18 M14 14 v3 h-8 l-2 -2 l2 -2 h7 M8 8 v1 h1 m4 0 h6 l2 -2 l-2 -2 h-10 M10 21 h4 M12 5 v-2 M12 13 v-1 M12 21 v-4 M0 0 h24 v24 H0 z";
				case IconKind.Directions:
					return "M14 13 v4 h-8 l-2 -2 l2 -2 z M8 5 v4 h11 l2 -2 l-2 -2 z M10 21 h4 M12 5 v-2 M12 13 v-4 M12 21 v-4 M0 0 h24 v24 H0 z";
				case IconKind.Disabled2:
					return "M19 20 l-4 -5 h-4 l3 -5 l-4 -3 l-4 1 M9 11 a5 5 0 1 0 3.95 7.95 M17 6 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.DisabledOff:
					return "M3 3 l18 18 M7 11.5 a5 5 0 1 0 6 7.5 M15 11 h1 M11 11 v4 h4 l4 5 M11 7 a2 2 0 1 0 -2 -2 M0 0 h24 v24 H0 z";
				case IconKind.Disabled:
					return "M7 11.5 a5 5 0 1 0 6 7.5 M11 11 l5 0 M11 7 l0 8 l4 0 l4 5 M11 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.DiscGolf:
					return "M11 21 h2 M7 16 c0.64 0.64 1.509 1 2.414 1 h5.172 c0.905 0 1.774 -0.36 2.414 -1 M12 3 v2 M12 15 v6 M14 5 c0 4.915 -0.552 7.082 -2 10 M10 5 c0 4.915 0.552 7.082 2 10 M18 5 c-0.32 6.744 -2.74 9.246 -6 10 M6 5 c0.32 6.744 2.74 9.246 6 10 M5 5 h14 M0 0 h24 v24 H0 z";
				case IconKind.DiscOff:
					return "M3 3 l18 18 M12 17 a4.985 4.985 0 0 0 3.551 -1.48 m1.362 -2.587 c0.057 -0.302 0.087 -0.614 0.087 -0.933 M7 12 c0 -1.38 0.559 -2.629 1.462 -3.534 m2.607 -1.38 c0.302 -0.056 0.613 -0.086 0.931 -0.086 M11.298 11.288 a1 1 0 1 0 1.402 1.427 M20.044 16.04 a9 9 0 0 0 -12.082 -12.085 m-2.333 1.688 a9 9 0 0 0 6.371 15.357 c2.491 0 4.73 -1 6.36 -2.631 M0 0 h24 v24 H0 z";
				case IconKind.Disc:
					return "M12 17 a5 5 0 0 0 5 -5 M7 12 a5 5 0 0 1 5 -5 M12 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.Discount2Off:
					return "M3 3 l18 18 M8.887 4.89 a2.2 2.2 0 0 0 0.863 -0.53 l0.7 -0.7 a2.2 2.2 0 0 1 3.12 0 l0.7 0.7 c0.412 0.41 0.97 0.64 1.55 0.64 h1 a2.2 2.2 0 0 1 2.2 2.2 v1 c0 0.58 0.23 1.138 0.64 1.55 l0.7 0.7 a2.2 2.2 0 0 1 0 3.12 l-0.7 0.7 a2.2 2.2 0 0 0 -0.528 0.858 m-0.757 3.248 a2.193 2.193 0 0 1 -1.555 0.644 h-1 a2.2 2.2 0 0 0 -1.55 0.64 l-0.7 0.7 a2.2 2.2 0 0 1 -3.12 0 l-0.7 -0.7 a2.2 2.2 0 0 0 -1.55 -0.64 h-1 a2.2 2.2 0 0 1 -2.2 -2.2 v-1 a2.2 2.2 0 0 0 -0.64 -1.55 l-0.7 -0.7 a2.2 2.2 0 0 1 0 -3.12 l0.7 -0.7 a2.2 2.2 0 0 0 0.64 -1.55 v-1 c0 -0.604 0.244 -1.152 0.638 -1.55 M14.148 14.145 a0.498 0.498 0 0 0 0.352 0.855 a0.5 0.5 0 0 0 0.35 -0.142 M9.148 9.145 a0.498 0.498 0 0 0 0.352 0.855 a0.5 0.5 0 0 0 0.35 -0.142 M9 15 l3 -3 m2 -2 l1 -1 M0 0 h24 v24 H0 z";
				case IconKind.Discount2:
					return "M5 7.2 a2.2 2.2 0 0 1 2.2 -2.2 h1 a2.2 2.2 0 0 0 1.55 -0.64 l0.7 -0.7 a2.2 2.2 0 0 1 3.12 0 l0.7 0.7 a2.2 2.2 0 0 0 1.55 0.64 h1 a2.2 2.2 0 0 1 2.2 2.2 v1 a2.2 2.2 0 0 0 0.64 1.55 l0.7 0.7 a2.2 2.2 0 0 1 0 3.12 l-0.7 0.7 a2.2 2.2 0 0 0 -0.64 1.55 v1 a2.2 2.2 0 0 1 -2.2 2.2 h-1 a2.2 2.2 0 0 0 -1.55 0.64 l-0.7 0.7 a2.2 2.2 0 0 1 -3.12 0 l-0.7 -0.7 a2.2 2.2 0 0 0 -1.55 -0.64 h-1 a2.2 2.2 0 0 1 -2.2 -2.2 v-1 a2.2 2.2 0 0 0 -0.64 -1.55 l-0.7 -0.7 a2.2 2.2 0 0 1 0 -3.12 l0.7 -0.7 a2.2 2.2 0 0 0 0.64 -1.55 v-1 M14,14.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M9,9.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M9 15 l6 -6 M0 0 h24 v24 H0 z";
				case IconKind.DiscountCheck:
					return "M9 12 l2 2 l4 -4 M5 7.2 a2.2 2.2 0 0 1 2.2 -2.2 h1 a2.2 2.2 0 0 0 1.55 -0.64 l0.7 -0.7 a2.2 2.2 0 0 1 3.12 0 l0.7 0.7 c0.412 0.41 0.97 0.64 1.55 0.64 h1 a2.2 2.2 0 0 1 2.2 2.2 v1 c0 0.58 0.23 1.138 0.64 1.55 l0.7 0.7 a2.2 2.2 0 0 1 0 3.12 l-0.7 0.7 a2.2 2.2 0 0 0 -0.64 1.55 v1 a2.2 2.2 0 0 1 -2.2 2.2 h-1 a2.2 2.2 0 0 0 -1.55 0.64 l-0.7 0.7 a2.2 2.2 0 0 1 -3.12 0 l-0.7 -0.7 a2.2 2.2 0 0 0 -1.55 -0.64 h-1 a2.2 2.2 0 0 1 -2.2 -2.2 v-1 a2.2 2.2 0 0 0 -0.64 -1.55 l-0.7 -0.7 a2.2 2.2 0 0 1 0 -3.12 l0.7 -0.7 a2.2 2.2 0 0 0 0.64 -1.55 v-1 M0 0 h24 v24 H0 z";
				case IconKind.DiscountOff:
					return "M3 3 l18 18 M5.641 5.631 a9 9 0 1 0 12.719 12.738 m1.68 -2.318 a9 9 0 0 0 -12.074 -12.098 M14.148 14.145 a0.498 0.498 0 0 0 0.352 0.855 a0.5 0.5 0 0 0 0.35 -0.142 M9.148 9.145 a0.498 0.498 0 0 0 0.352 0.855 a0.5 0.5 0 0 0 0.35 -0.142 M9 15 l3 -3 m2 -2 l1 -1 M0 0 h24 v24 H0 z";
				case IconKind.Discount:
					return "M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M14,14.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M9,9.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M9 15 l6 -6 M0 0 h24 v24 H0 z";
				case IconKind.Divide:
					return "M5 12 l14 0 M11,18a1,1 0 1,0 2,0a1,1 0 1,0 -2,0 M11,6a1,1 0 1,0 2,0a1,1 0 1,0 -2,0 M0 0 h24 v24 H0 z";
				case IconKind.Dna2Off:
					return "M3 3 l18 18 M8 16 h8 M12 8 h4 M7 20 h10 M8 4 h9 M17 21.014 v-1 c0 -1.44 -0.315 -2.755 -0.932 -3.944 m-4.068 -4.07 c-1.903 -1.138 -3.263 -2.485 -4.082 -4.068 M17 3 v1 c-0.007 2.46 -0.91 4.554 -2.705 6.281 m-2.295 1.719 c-3.328 1.99 -5 4.662 -5.008 8.014 v1 M0 0 h24 v24 H0 z";
				case IconKind.Dna2:
					return "M8 16 h8 M8 8 h8 M7 20 h10 M7 4 h10 M17 21.014 v-1 c-0.01 -3.352 -1.68 -6.023 -5.008 -8.014 c-3.328 -1.99 3.336 2 0.008 0.014 c-3.328 -1.991 -5 -4.662 -5.008 -8.014 v-1 M17 3 v1 c-0.01 3.352 -1.68 6.023 -5.008 8.014 c-3.328 1.99 3.336 -2 0.008 -0.014 c-3.328 1.99 -5 4.662 -5.008 8.014 v1 M0 0 h24 v24 H0 z";
				case IconKind.DnaOff:
					return "M3 3 l18 18 M14.828 3.515 a4 4 0 1 0 5.657 5.657 M9.172 20.485 a4 4 0 1 0 -5.657 -5.657 M16 12 a3.898 3.898 0 0 0 -1.172 -2.828 a4.027 4.027 0 0 0 -2.828 -1.172 m-2.828 1.172 a4 4 0 1 0 5.656 5.656 M0 0 h24 v24 H0 z";
				case IconKind.Dna:
					return "M14.828 3.515 a4 4 0 0 0 5.657 5.657 M9.172 20.485 a4 4 0 1 0 -5.657 -5.657 M14.828 14.828 a4 4 0 1 0 -5.656 -5.656 a4 4 0 0 0 5.656 5.656 z M0 0 h24 v24 H0 z";
				case IconKind.DogBowl:
					return "M3 20 h18 c-0.175 -1.671 -0.046 -3.345 -2 -5 h-14 c-1.333 1 -2 2.667 -2 5 z M12 13 l-3.586 -3.585 a2 2 0 1 0 -3.414 -1.415 a2 2 0 1 0 1.413 3.414 l3.587 3.586 M10 15 l5.586 -5.585 a2 2 0 1 1 3.414 -1.415 a2 2 0 1 1 -1.413 3.414 l-3.587 3.586 M0 0 h24 v24 H0 z";
				case IconKind.Dog:
					return "M19 4 l-6 0.97 l6.238 6.688 c0.358 0.408 0.989 0.458 1.41 0.111 a0.953 0.953 0 0 0 0.327 -0.954 l-1.975 -6.815 z M5 4 l6 0.97 l-6.238 6.688 a1.021 1.021 0 0 1 -1.41 0.111 a0.953 0.953 0 0 1 -0.327 -0.954 l1.975 -6.815 z M14 11 v0.01 M10 11 v0.01 M12 18 v2 M11 16 c0 0.667 0.333 1 1 1 s1 -0.333 1 -1 h-2 z M19 12 c-0.667 5.333 -2.333 8 -5 8 h-4 c-2.667 0 -4.333 -2.667 -5 -8 M11 5 h2 M0 0 h24 v24 H0 z";
				case IconKind.DoorEnter:
					return "M21 7 h-7 m3 -3 l-3 3 l3 3 M5 21 v-16 a2 2 0 0 1 2 -2 h6 m4 10.5 v7.5 M3 21 h18 M13 12 v0.01 M0 0 h24 v24 H0 z";
				case IconKind.DoorExit:
					return "M14 7 h7 m-3 -3 l3 3 l-3 3 M5 21 v-16 a2 2 0 0 1 2 -2 h7.5 m2.5 10.5 v7.5 M3 21 h18 M13 12 v0.01 M0 0 h24 v24 H0 z";
				case IconKind.DoorOff:
					return "M3 3 l18 18 M18 18 v3 M7.18 3.175 c0.25 -0.112 0.528 -0.175 0.82 -0.175 h8 a2 2 0 0 1 2 2 v9 M6 21 v-15 M3 21 h18 M0 0 h24 v24 H0 z";
				case IconKind.Door:
					return "M6 21 v-16 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v16 M3 21 h18 M14 12 v0.01 M0 0 h24 v24 H0 z";
				case IconKind.DotsCircleHorizontal:
					return "M16 12 l0 0.01 M12 12 l0 0.01 M8 12 l0 0.01 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.DotsDiagonal2:
					return "M17 17 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M7 7 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.DotsDiagonal:
					return "M17 7 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M7 17 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.DotsVertical:
					return "M12 5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12 19 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.Dots:
					return "M19 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M5 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.DownloadOff:
					return "M3 3 l18 18 M12 4 v4 m0 4 v4 M7 11 l5 5 l2 -2 m2 -2 l1 -1 M4 17 v2 a2 2 0 0 0 2 2 h12 a2 2 0 0 0 1.83 -1.19 M0 0 h24 v24 H0 z";
				case IconKind.Download:
					return "M12 4 l0 12 M7 11 l5 5 l5 -5 M4 17 v2 a2 2 0 0 0 2 2 h12 a2 2 0 0 0 2 -2 v-2 M0 0 h24 v24 H0 z";
				case IconKind.DragDrop2:
					return "M4 16 l0 0.01 M4 12 l0 0.01 M4 8 l0 0.01 M16 4 l0 0.01 M12 4 l0 0.01 M8 4 l0 0.01 M4 4 l0 0.01 M8 8 m0 2 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.DragDrop:
					return "M3 15 l0 0.01 M3 11 l0 0.01 M3 7 l0 0.01 M15 3 l0 0.01 M11 3 l0 0.01 M7 3 l0 0.01 M3 3 l0 0.01 M13 13 l9 3 l-4 2 l-2 4 l-3 -9 M19 11 v-2 a2 2 0 0 0 -2 -2 h-8 a2 2 0 0 0 -2 2 v8 a2 2 0 0 0 2 2 h2 M0 0 h24 v24 H0 z";
				case IconKind.DroneOff:
					return "M3 3 l18 18 M6 14.035 a3.5 3.5 0 1 0 3.966 3.965 M10 14 l-3.5 3.5 M14.035 18 a3.5 3.5 0 0 0 5.936 1.98 m0.987 -3.026 a3.503 3.503 0 0 0 -2.918 -2.913 M14 14 l3.5 3.5 M18 9.965 a3.5 3.5 0 1 0 -3.966 -3.965 M14 10 l3.5 -3.5 M9.957 5.95 a3.503 3.503 0 0 0 -2.917 -2.91 m-3.02 0.989 a3.5 3.5 0 0 0 1.98 5.936 M10 10 l-3.5 -3.5 M14 14 h-4 v-4 M0 0 h24 v24 H0 z";
				case IconKind.Drone:
					return "M6 14.04 a3.5 3.5 0 1 0 3.96 3.96 M10 14 l-3.5 3.5 M14.04 18 a3.5 3.5 0 1 0 3.96 -3.96 M14 14 l3.5 3.5 M18 9.96 a3.5 3.5 0 1 0 -3.96 -3.96 M14 10 l3.5 -3.5 M9.96 6 a3.5 3.5 0 1 0 -3.96 3.96 M10 10 l-3.5 -3.5 M10 10 h4 v4 h-4 z M0 0 h24 v24 H0 z";
				case IconKind.DropCircle:
					return "M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M10.07 15.34 c1.115 0.88 2.74 0.88 3.855 0 c1.115 -0.88 1.398 -2.388 0.671 -3.575 l-2.596 -3.765 l-2.602 3.765 c-0.726 1.187 -0.443 2.694 0.672 3.575 z M0 0 h24 v24 H0 z";
				case IconKind.DropletFilled2:
					return "M10.26 19.74 l5.74 -5.74 l-5.74 5.74 z M7.305 17.695 l3.695 -3.695 M6 14 h12 M6.8 11 a6 6 0 1 0 10.396 0 l-5.197 -8 l-5.2 8 z M0 0 h24 v24 H0 z";
				case IconKind.DropletFilled:
					return "M6.8 11 a6 6 0 1 0 10.396 0 l-5.197 -8 l-5.2 8 z M0 0 h24 v24 H0 z";
				case IconKind.DropletHalf2:
					return "M6 14 h12 M6.8 11 a6 6 0 1 0 10.396 0 l-5.197 -8 l-5.2 8 z M0 0 h24 v24 H0 z";
				case IconKind.DropletHalfFilled:
					return "M6.8 11 a6 6 0 1 0 10.396 0 l-5.197 -8 l-5.2 8 z m5.2 -8 v17 m0 -8 l3.544 -3.544 m-3.544 8.844 l5.558 -5.558 M0 0 h24 v24 H0 z";
				case IconKind.DropletHalf:
					return "M12 3 v17 M6.8 11 a6 6 0 1 0 10.396 0 l-5.197 -8 l-5.2 8 z M0 0 h24 v24 H0 z";
				case IconKind.DropletOff:
					return "M3 3 l18 18 M18 14 a5.971 5.971 0 0 0 -0.803 -3 l-5.197 -8 l-1.968 3.03 M8.454 8.458 l-1.653 2.545 a6 6 0 0 0 10.32 6.123 M0 0 h24 v24 H0 z";
				case IconKind.Droplet:
					return "M6.8 11 a6 6 0 1 0 10.396 0 l-5.197 -8 l-5.2 8 z M0 0 h24 v24 H0 z";
				case IconKind.EPassport:
					return "M15 12 h7 M9 12 h-7 M12 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M2 5 m0 2 a2 2 0 0 1 2 -2 h16 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-16 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.EarOff:
					return "M3 3 l18 18 M11.42 7.414 a3 3 0 0 1 4.131 4.13 M6 10 c0 -1.146 0.277 -2.245 0.78 -3.219 m1.792 -2.208 a7 7 0 0 1 10.428 9.027 a10 10 0 0 1 -0.633 0.762 m-2.045 1.96 a8 8 0 0 0 -1.322 2.278 a4.5 4.5 0 0 1 -6.8 1.4 M0 0 h24 v24 H0 z";
				case IconKind.Ear:
					return "M10 10 a3 3 0 1 1 5 2.2 M6 10 a7 7 0 1 1 13 3.6 a10 10 0 0 1 -2 2 a8 8 0 0 0 -2 3 a4.5 4.5 0 0 1 -6.8 1.4 M0 0 h24 v24 H0 z";
				case IconKind.EaseInControlPoint:
					return "M12 19 h-2 M17 19 h-2 M17 19 a2 2 0 1 0 4 0 a2 2 0 0 0 -4 0 z M3 19 c8 0 18 -16 18 -16 M0 0 h24 v24 H0 z";
				case IconKind.EaseInOutControlPoints:
					return "M3 20 c8 0 10 -16 18 -16 M12 20 h-2 M14 4 h-2 M7 4 h2 M7 4 a2 2 0 1 1 -4 0 a2 2 0 0 1 4 0 z M17 20 h-2 M17 20 a2 2 0 1 0 4 0 a2 2 0 0 0 -4 0 z M0 0 h24 v24 H0 z";
				case IconKind.EaseInOut:
					return "M3 20 c8 0 10 -16 18 -16 M0 0 h24 v24 H0 z";
				case IconKind.EaseIn:
					return "M3 20 c8 0 18 -16 18 -16 M0 0 h24 v24 H0 z";
				case IconKind.EaseOutControlPoint:
					return "M14 5 h-2 M7 5 h2 M7 5 a2 2 0 1 1 -4 0 a2 2 0 0 1 4 0 z M3 21 s10 -16 18 -16 M0 0 h24 v24 H0 z";
				case IconKind.EaseOut:
					return "M3 20 s10 -16 18 -16 M0 0 h24 v24 H0 z";
				case IconKind.EditCircleOff:
					return "M3 3 l18 18 M7.476 7.471 a7 7 0 0 0 2.524 13.529 a7 7 0 0 0 6.53 -4.474 M16 5 l3 3 M10.507 10.498 l-1.507 1.502 v3 h3 l1.493 -1.498 m2 -2.01 l4.89 -4.907 a2.1 2.1 0 0 0 -2.97 -2.97 l-4.913 4.896 M0 0 h24 v24 H0 z";
				case IconKind.EditCircle:
					return "M9 7.07 a7 7 0 0 0 1 13.93 a7 7 0 0 0 6.929 -6 M16 5 l3 3 M12 15 l8.385 -8.415 a2.1 2.1 0 0 0 -2.97 -2.97 l-8.415 8.385 v3 h3 z M0 0 h24 v24 H0 z";
				case IconKind.EditOff:
					return "M3 3 l18 18 M16 5 l3 3 M10.507 10.498 l-1.507 1.502 v3 h3 l1.493 -1.498 m2 -2.01 l4.89 -4.907 a2.1 2.1 0 0 0 -2.97 -2.97 l-4.913 4.896 M7 7 h-1 a2 2 0 0 0 -2 2 v9 a2 2 0 0 0 2 2 h9 a2 2 0 0 0 2 -2 v-1 M0 0 h24 v24 H0 z";
				case IconKind.Edit:
					return "M16 5 l3 3 M20.385 6.585 a2.1 2.1 0 0 0 -2.97 -2.97 l-8.415 8.385 v3 h3 l8.385 -8.415 z M7 7 h-1 a2 2 0 0 0 -2 2 v9 a2 2 0 0 0 2 2 h9 a2 2 0 0 0 2 -2 v-1 M0 0 h24 v24 H0 z";
				case IconKind.EggCracked:
					return "M12 3 l-1.5 5 l3.5 2.5 l-2 3.5 M19 14.083 c0 4.154 -2.966 6.74 -7 6.917 c-4.2 0 -7 -2.763 -7 -6.917 c0 -5.538 3.5 -11.09 7 -11.083 c3.5 0.007 7 5.545 7 11.083 z M0 0 h24 v24 H0 z";
				case IconKind.EggFilled:
					return "M19 14.083 c0 4.154 -2.966 6.74 -7 6.917 c-4.2 0 -7 -2.763 -7 -6.917 c0 -5.538 3.5 -11.09 7 -11.083 c3.5 0.007 7 5.545 7 11.083 z M0 0 h24 v24 H0 z";
				case IconKind.EggFried:
					return "M14 3 a5 5 0 0 1 4.872 6.13 a3 3 0 0 1 0.178 5.681 a3 3 0 1 1 -4.684 3.626 a5 5 0 1 1 -8.662 -5 a5 5 0 1 1 4.645 -8.856 a4.982 4.982 0 0 1 3.651 -1.585 z M12 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.EggOff:
					return "M3 3 l18 18 M8.642 4.628 c1.034 -1.02 2.196 -1.63 3.358 -1.628 c3.5 0.007 7 5.545 7 11.083 c0 0.298 -0.015 0.587 -0.045 0.868 M17.927 17.934 c-1.211 1.858 -3.351 2.953 -5.927 3.066 c-4.2 0 -7 -2.763 -7 -6.917 c0 -2.568 0.753 -5.14 1.91 -7.158 M0 0 h24 v24 H0 z";
				case IconKind.Egg:
					return "M19 14.083 c0 4.154 -2.966 6.74 -7 6.917 c-4.2 0 -7 -2.763 -7 -6.917 c0 -5.538 3.5 -11.09 7 -11.083 c3.5 0.007 7 5.545 7 11.083 z M0 0 h24 v24 H0 z";
				case IconKind.Eggs:
					return "M8 18 c-3.03 -0.196 -5 -2.309 -5 -5.38 c0 -4.307 2.75 -8.625 5.5 -8.62 c2.614 0 5.248 3.915 5.5 8 M13 22 c-3 0 -4.868 -2.118 -5 -5 c0 -3 2 -5 5 -5 c4 0 8.01 2.5 8 5 c0 2.5 -4 5 -8 5 z M0 0 h24 v24 H0 z";
				case IconKind.ElevatorOff:
					return "M3 3 l18 18 M10 14 l2 2 l2 -2 M12 8 l2 2 M8 4 h10 a1 1 0 0 1 1 1 v10 m0 4 a1 1 0 0 1 -1 1 h-12 a1 1 0 0 1 -1 -1 v-14 M0 0 h24 v24 H0 z";
				case IconKind.Elevator:
					return "M10 14 l2 2 l2 -2 M10 10 l2 -2 l2 2 M5 4 m0 1 a1 1 0 0 1 1 -1 h12 a1 1 0 0 1 1 1 v14 a1 1 0 0 1 -1 1 h-12 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.EmergencyBed:
					return "M14.5 16.5 l-2.5 -2.5 M12 12 v2 l-2.5 2.5 M12 4 v4 M10 6 h4 M4 8 l2.1 2.8 a3 3 0 0 0 2.4 1.2 h11.5 M8 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M16 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.EmpathizeOff:
					return "M3 3 l18 18 M12.317 12.315 l-0.317 0.317 l-0.728 -0.727 a3.088 3.088 0 1 0 -4.367 4.367 l5.095 5.096 l4.689 -4.69 m1.324 -2.673 a3.087 3.087 0 0 0 -3.021 -3.018 M12 8 a2.5 2.5 0 1 0 -2.5 -2.5 M0 0 h24 v24 H0 z";
				case IconKind.Empathize:
					return "M12 21.368 l5.095 -5.096 a3.088 3.088 0 1 0 -4.367 -4.367 l-0.728 0.727 l-0.728 -0.727 a3.088 3.088 0 1 0 -4.367 4.367 l5.095 5.096 z M12 5.5 m-2.5 0 a2.5 2.5 0 1 0 5 0 a2.5 2.5 0 1 0 -5 0 M0 0 h24 v24 H0 z";
				case IconKind.Emphasis:
					return "M18 20 l0 0.01 M14 20 l0 0.01 M10 20 l0 0.01 M6 20 l0 0.01 M16 5 h-8 v10 h8 m-1 -5 h-7 M0 0 h24 v24 H0 z";
				case IconKind.EngineOff:
					return "M3 3 l18 18 M16 16 h-1 v2 a1 1 0 0 1 -1 1 h-3.465 a1 1 0 0 1 -0.832 -0.445 l-1.703 -2.555 h-2 v-6 h2 l0.99 -0.99 m3.01 -1.01 h1.382 a1 1 0 0 1 0.894 0.553 l1.448 2.894 a1 1 0 0 0 0.894 0.553 h1.382 v-2 h2 a1 1 0 0 1 1 1 v6 M5 13 h-2 M10 5 h4 M12 5 v3 M3 10 v6 M0 0 h24 v24 H0 z";
				case IconKind.Engine:
					return "M6 10 h2 l2 -2 h3.382 a1 1 0 0 1 0.894 0.553 l1.448 2.894 a1 1 0 0 0 0.894 0.553 h1.382 v-2 h2 a1 1 0 0 1 1 1 v6 a1 1 0 0 1 -1 1 h-2 v-2 h-3 v2 a1 1 0 0 1 -1 1 h-3.465 a1 1 0 0 1 -0.832 -0.445 l-1.703 -2.555 h-2 v-6 z M5 13 h-2 M10 5 h4 M12 5 v3 M3 10 v6 M0 0 h24 v24 H0 z";
				case IconKind.EqualDouble:
					return "M14 14 h7 M14 10 h7 M3 14 h7 M3 10 h7 M0 0 h24 v24 H0 z";
				case IconKind.EqualNot:
					return "M5 19 l14 -14 M5 14 h14 M5 10 h14 M0 0 h24 v24 H0 z";
				case IconKind.Equal:
					return "M5 14 h14 M5 10 h14 M0 0 h24 v24 H0 z";
				case IconKind.EraserOff:
					return "M18 13.3 l-6.3 -6.3 M19 20 h-10.5 l-4.21 -4.3 a1 1 0 0 1 0 -1.41 l5 -4.993 m2.009 -2.01 l3 -3 a1 1 0 0 1 1.41 0 l5 5 a1 1 0 0 1 0 1.41 c-1.417 1.431 -2.406 2.432 -2.97 3 m-2.02 2.043 l-4.211 4.256 M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.Eraser:
					return "M18 13.3 l-6.3 -6.3 M19 20 h-10.5 l-4.21 -4.3 a1 1 0 0 1 0 -1.41 l10 -10 a1 1 0 0 1 1.41 0 l5 5 a1 1 0 0 1 0 1.41 l-9.2 9.3 M0 0 h24 v24 H0 z";
				case IconKind.Error404Off:
					return "M3 3 l18 18 M21 7 v10 M17 7 v4 a1 1 0 0 0 1 1 h3 M10 10 v6 a1 1 0 0 0 1 1 h2 a1 1 0 0 0 1 -1 v-2 m0 -4 v-2 a1 1 0 0 0 -1 -1 h-2 M7 7 v10 M3 7 v4 a1 1 0 0 0 1 1 h3 M0 0 h24 v24 H0 z";
				case IconKind.Error404:
					return "M21 7 v10 M17 7 v4 a1 1 0 0 0 1 1 h3 M10 8 v8 a1 1 0 0 0 1 1 h2 a1 1 0 0 0 1 -1 v-8 a1 1 0 0 0 -1 -1 h-2 a1 1 0 0 0 -1 1 z M7 7 v10 M3 7 v4 a1 1 0 0 0 1 1 h3 M0 0 h24 v24 H0 z";
				case IconKind.ExchangeOff:
					return "M3 3 l18 18 M11.501 7.499 l1.499 -1.499 M5 16 v-5 c0 -1.632 0.782 -3.082 1.992 -4 m3.008 -1 h3 l-3 -3 M14 21 l-3 -3 M19 8 v5 c0 0.594 -0.104 1.164 -0.294 1.692 m-1.692 2.298 a4.978 4.978 0 0 1 -3.014 1.01 h-3 l3 -3 M19 6 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Exchange:
					return "M5 16 v-5 a5 5 0 0 1 5 -5 h3 l-3 -3 m0 6 l3 -3 M19 8 v5 a5 5 0 0 1 -5 5 h-3 l3 -3 m0 6 l-3 -3 M19 6 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.ExclamationCircle:
					return "M12 16 v0.01 M12 9 v4 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.ExclamationMarkOff:
					return "M3 3 l18 18 M12 15 v-3 m0 -4 v-3 M12 19 v0.01 M0 0 h24 v24 H0 z";
				case IconKind.ExclamationMark:
					return "M12 15 v-10 M12 19 v0.01 M0 0 h24 v24 H0 z";
				case IconKind.ExplicitOff:
					return "M3 3 l18 18 M12 12 h-2 M8 4 h10 a2 2 0 0 1 2 2 v10 m-0.586 3.414 a2 2 0 0 1 -1.414 0.586 h-12 a2 2 0 0 1 -2 -2 v-12 c0 -0.547 0.22 -1.043 0.576 -1.405 M14 8 h-2 m-2 2 v6 h4 M0 0 h24 v24 H0 z";
				case IconKind.Explicit:
					return "M14 12 h-4 M14 8 h-4 v8 h4 M4 4 m0 1 a1 1 0 0 1 1 -1 h14 a1 1 0 0 1 1 1 v14 a1 1 0 0 1 -1 1 h-14 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.Exposure0:
					return "M12 19 a4 4 0 0 0 4 -4 v-6 a4 4 0 1 0 -8 0 v6 a4 4 0 0 0 4 4 z M0 0 h24 v24 H0 z";
				case IconKind.ExposureMinus1:
					return "M18 19 v-14 l-4 4 M3 12 h6 M0 0 h24 v24 H0 z";
				case IconKind.ExposureMinus2:
					return "M3 12 h6 M12 9 a4 4 0 1 1 8 0 c0 1.098 -0.564 2.025 -1.159 2.815 l-6.841 7.185 h8 M0 0 h24 v24 H0 z";
				case IconKind.ExposureOff:
					return "M3 3 l18 18 M13 16 h3 M7 9 h2 v2 M8 4 h10 a2 2 0 0 1 2 2 v10 m-0.586 3.414 a2 2 0 0 1 -1.414 0.586 h-12 a2 2 0 0 1 -2 -2 v-12 c0 -0.547 0.22 -1.043 0.576 -1.405 M4.6 19.4 l7.4 -7.4 m2 -2 l5.4 -5.4 M0 0 h24 v24 H0 z";
				case IconKind.ExposurePlus1:
					return "M18 19 v-14 l-4 4 M6 9 v6 M3 12 h6 M0 0 h24 v24 H0 z";
				case IconKind.ExposurePlus2:
					return "M6 9 v6 M3 12 h6 M12 9 a4 4 0 1 1 8 0 c0 1.098 -0.564 2.025 -1.159 2.815 l-6.841 7.185 h8 M0 0 h24 v24 H0 z";
				case IconKind.Exposure:
					return "M13 16 l4 0 M7 9 h4 m-2 -2 v4 M4.6 19.4 l14.8 -14.8 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.ExternalLinkOff:
					return "M3 3 l18 18 M15 4 h5 v5 M10 14 l2 -2 m2.007 -2.007 l6 -6 M7 7 h-1 a2 2 0 0 0 -2 2 v9 a2 2 0 0 0 2 2 h9 a2 2 0 0 0 2 -2 v-1 M0 0 h24 v24 H0 z";
				case IconKind.ExternalLink:
					return "M15 4 l5 0 l0 5 M10 14 l10 -10 M11 7 h-5 a2 2 0 0 0 -2 2 v9 a2 2 0 0 0 2 2 h9 a2 2 0 0 0 2 -2 v-5 M0 0 h24 v24 H0 z";
				case IconKind.EyeCheck:
					return "M15 19 l2 2 l4 -4 M12 19 c-4 0 -7.333 -2.333 -10 -7 c2.667 -4.667 6 -7 10 -7 s7.333 2.333 10 7 c-0.42 0.736 -0.858 1.414 -1.311 2.033 M12 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.EyeFilled:
					return "M22 12 c-2.667 4.667 -6 7 -10 7 s-7.333 -2.333 -10 -7 c2.667 -4.667 6 -7 10 -7 s7.333 2.333 10 7 m-13 0 a3 3 0 0 0 6 0 a3 3 0 0 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.EyeOff:
					return "M9.363 5.365 a9.466 9.466 0 0 1 2.637 -0.365 c4 0 7.333 2.333 10 7 c-0.778 1.361 -1.612 2.524 -2.503 3.488 m-2.14 1.861 c-1.631 1.1 -3.415 1.651 -5.357 1.651 c-4 0 -7.333 -2.333 -10 -7 c1.369 -2.395 2.913 -4.175 4.632 -5.341 M10.584 10.587 a2 2 0 0 0 2.828 2.83 M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.EyeTable:
					return "M12 11 v-4 M14 15 h1 M9 15 h1 M14 7 h-4 M5 3 v17 a1 1 0 0 0 1 1 h12 a1 1 0 0 0 1 -1 v-17 M4 3 h16 M16 18 h-0.011 M12 18 h-0.011 M8 18 h-0.011 M0 0 h24 v24 H0 z";
				case IconKind.Eye:
					return "M22 12 c-2.667 4.667 -6 7 -10 7 s-7.333 -2.333 -10 -7 c2.667 -4.667 6 -7 10 -7 s7.333 2.333 10 7 M12 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Eyeglass2:
					return "M6.5 16.5 m-3.5 0 a3.5 3.5 0 1 0 7 0 a3.5 3.5 0 1 0 -7 0 M17.5 16.5 m-3.5 0 a3.5 3.5 0 1 0 7 0 a3.5 3.5 0 1 0 -7 0 M10 16 l4 0 M16 4 h2 l3 10 v2.5 M8 4 h-2 l-3 10 v2.5 M0 0 h24 v24 H0 z";
				case IconKind.EyeglassOff:
					return "M3 3 l18 18 M10 16.5 a3.5 3.5 0 0 1 -7 0 v-2.5 h7 v2.5 M19.426 19.423 a3.5 3.5 0 0 1 -5.426 -2.923 v-2.5 m4 0 h3 v2.5 c0 0.157 -0.01 0.312 -0.03 0.463 M10 16 h4 M16 4 h2 l3 10 M5.536 5.546 l-2.536 8.454 M0 0 h24 v24 H0 z";
				case IconKind.Eyeglass:
					return "M10 16.5 a3.5 3.5 0 0 1 -7 0 v-2.5 h7 v2.5 M21 16.5 a3.5 3.5 0 0 1 -7 0 v-2.5 h7 v2.5 M10 16 l4 0 M16 4 h2 l3 10 M8 4 h-2 l-3 10 M0 0 h24 v24 H0 z";
				case IconKind.FaceIdError:
					return "M9.5 15.05 a3.5 3.5 0 0 1 5 0 M15 10 h0.01 M9 10 h0.01 M16 20 h2 a2 2 0 0 0 2 -2 v-2 M16 4 h2 a2 2 0 0 1 2 2 v2 M4 16 v2 a2 2 0 0 0 2 2 h2 M4 8 v-2 a2 2 0 0 1 2 -2 h2 M0 0 h24 v24 H0 z";
				case IconKind.FaceId:
					return "M9.5 15 a3.5 3.5 0 0 0 5 0 M15 10 l0.01 0 M9 10 l0.01 0 M16 20 h2 a2 2 0 0 0 2 -2 v-2 M16 4 h2 a2 2 0 0 1 2 2 v2 M4 16 v2 a2 2 0 0 0 2 2 h2 M4 8 v-2 a2 2 0 0 1 2 -2 h2 M0 0 h24 v24 H0 z";
				case IconKind.FaceMaskOff:
					return "M3 3 l18 18 M19 15 v-6.49 a2 2 0 0 0 -1.45 -1.923 l-5 -1.429 a2 2 0 0 0 -1.1 0 l-1.788 0.511 m-3.118 0.891 l-0.094 0.027 a2 2 0 0 0 -1.45 1.922 v6.982 a2 2 0 0 0 1.45 1.923 l5 1.429 a2 2 0 0 0 1.1 0 l4.899 -1.4 M9 14 h5 M9 10 h1 m4 0 h1 M19 14.5 h0.222 c1.534 0 2.778 -1.12 2.778 -2.5 s-1.244 -2.5 -2.778 -2.5 h-0.222 M5 14.5 h-0.222 c-1.535 0 -2.778 -1.12 -2.778 -2.5 s1.243 -2.5 2.778 -2.5 h0.222 M0 0 h24 v24 H0 z";
				case IconKind.FaceMask:
					return "M12.55 18.843 l5 -1.429 a2 2 0 0 0 1.45 -1.923 v-6.981 a2 2 0 0 0 -1.45 -1.923 l-5 -1.429 a2 2 0 0 0 -1.1 0 l-5 1.429 a2 2 0 0 0 -1.45 1.922 v6.982 a2 2 0 0 0 1.45 1.923 l5 1.429 a2 2 0 0 0 1.1 0 z M9 14 h6 M9 10 h6 M19 14.5 h0.222 c1.534 0 2.778 -1.12 2.778 -2.5 s-1.244 -2.5 -2.778 -2.5 h-0.222 M5 14.5 h-0.222 c-1.535 0 -2.778 -1.12 -2.778 -2.5 s1.243 -2.5 2.778 -2.5 h0.222 M0 0 h24 v24 H0 z";
				case IconKind.Fall:
					return "M13.5 12 h2.5 l4 2 M6 5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M6 16 l-1 -4 l3 -4 M11 21 l1 -5 l-1 -4 l-3 -4 h4 l3 -3 M0 0 h24 v24 H0 z";
				case IconKind.FeatherOff:
					return "M3 3 l18 18 M11 18 l3.499 -3.499 m2.008 -2.008 l2.493 -2.493 M19 10 c0.638 -0.636 1 -1.515 1 -2.486 a3.515 3.515 0 0 0 -3.517 -3.514 c-0.97 0 -1.847 0.367 -2.483 1 M6 13 l3.502 -3.502 m2.023 -2.023 l2.475 -2.475 M6 13 v5 h5 M9 11 v4 h4 M14 5 v5 h5 M4 20 l8 -8 M0 0 h24 v24 H0 z";
				case IconKind.Feather:
					return "M19 10 c0.638 -0.636 1 -1.515 1 -2.486 a3.515 3.515 0 0 0 -3.517 -3.514 c-0.97 0 -1.847 0.367 -2.483 1 m-3 13 l4 -4 l4 -4 M4 20 l10 -10 m0 -5 v5 h5 m-9 -1 v5 h5 m-9 -1 v5 h5 m-5 -5 l4 -4 l4 -4 M0 0 h24 v24 H0 z";
				case IconKind.FenceOff:
					return "M3 3 l18 18 M18 12 v-6 l-2 -2 l-2 2 v4 M14 16 v4 h4 v-2 M10 12 v-2 m0 -4 l-2 -2 m-2 2 v6 M6 16 v4 h4 v-4 M12 12 h-8 v4 h12 m4 0 v-4 h-4 M0 0 h24 v24 H0 z";
				case IconKind.Fence:
					return "M14 16 v4 h4 v-4 m0 -4 v-6 l-2 -2 l-2 2 v6 M6 16 v4 h4 v-4 m0 -4 v-6 l-2 -2 l-2 2 v6 M4 12 v4 h16 v-4 z M0 0 h24 v24 H0 z";
				case IconKind.FidgetSpinner:
					return "M12 8 v0.01 M7 17 v0.01 M17 17 v0.01 M10 17 a3 3 0 1 1 -1.543 -2.623 l2.087 -3.754 a3 3 0 0 1 1.456 -5.623 a3 3 0 0 1 1.457 5.623 l2.087 3.754 a3 3 0 1 1 -1.538 2.8 l0 -0.177 h-4 z M0 0 h24 v24 H0 z";
				case IconKind.File3d:
					return "M8 12 v4.2 l4 1.8 M8 11.846 l4 1.654 v4.5 l4 -1.846 v-4.308 l-4 -1.846 z M12 13.5 l4 -1.5 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileAlert:
					return "M12 11 l0 3 M12 17 l0.01 0 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileAnalytics:
					return "M15 17 l0 -3 M12 17 l0 -1 M9 17 l0 -5 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileArrowLeft:
					return "M11.5 17.5 l-2.5 -2.5 l2.5 -2.5 M15 15 h-6 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileArrowRight:
					return "M12.5 17.5 l2.5 -2.5 l-2.5 -2.5 M9 15 h6 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileBarcode:
					return "M15 13 h1 v3 h-1 z M12 13 v3 M8 13 h1 v3 h-1 z M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileBroken:
					return "M19 16 h0.01 M19 13 h0.01 M5 10 h0.01 M5 13 h0.01 M5 16 h0.01 M19 19 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 M5 7 v-2 a2 2 0 0 1 2 -2 h7 l5 5 v2 M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileCertificate:
					return "M4.5 17 l-1.5 5 l3 -1.5 l3 1.5 l-1.5 -5 M6 14 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M5 8 v-3 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 h-5 M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileChart:
					return "M12 14 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M12 10 v4 h4 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileCheck:
					return "M9 15 l2 2 l4 -4 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileCode2:
					return "M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M14 12 h1 v5 h-1 M10 12 h-1 v5 h1 M0 0 h24 v24 H0 z";
				case IconKind.FileCode:
					return "M14 13 l1 2 l-1 2 M10 13 l-1 2 l1 2 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileDatabase:
					return "M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M8 12.5 v3.75 c0 0.966 1.79 1.75 4 1.75 s4 -0.784 4 -1.75 v-3.75 M12 12.75 m-4 0 a4 1.75 0 1 0 8 0 a4 1.75 0 1 0 -8 0 M0 0 h24 v24 H0 z";
				case IconKind.FileDelta:
					return "M9 17 h6 l-3 -6 z M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileDescription:
					return "M9 13 h6 M9 17 h6 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileDiff:
					return "M10 17 l4 0 M10 12 l4 0 M12 10 l0 4 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileDigit:
					return "M15 12 v5 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M9 12 m0 1 a1 1 0 0 1 1 -1 h1 a1 1 0 0 1 1 1 v3 a1 1 0 0 1 -1 1 h-1 a1 1 0 0 1 -1 -1 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileDislike:
					return "M5 11 v-6 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 h-2.5 M14 3 v4 a1 1 0 0 0 1 1 h4 M6 15 a1 1 0 0 1 1 -1 h3.756 a1 1 0 0 1 0.958 0.713 l1.2 3 c0.09 0.303 0.133 0.63 -0.056 0.884 c-0.188 0.254 -0.542 0.403 -0.858 0.403 h-2 v2.467 a1.1 1.1 0 0 1 -2.015 0.61 l-1.985 -3.077 v-4 z M3 14 m0 1 a1 1 0 0 1 1 -1 h1 a1 1 0 0 1 1 1 v3 a1 1 0 0 1 -1 1 h-1 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.FileDollar:
					return "M12 17 v1 m0 -8 v1 M14 11 h-2.5 a1.5 1.5 0 0 0 0 3 h1 a1.5 1.5 0 0 1 0 3 h-2.5 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileDots:
					return "M15 14 v0.01 M12 14 v0.01 M9 14 v0.01 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileDownload:
					return "M9.5 14.5 l2.5 2.5 l2.5 -2.5 M12 17 v-6 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileEuro:
					return "M14 11.172 a3 3 0 1 0 0 5.656 M12 14 h-3 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileExport:
					return "M11.5 21 h-4.5 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v5 m-5 6 h7 m-3 -3 l3 3 l-3 3 M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileFunction:
					return "M10.5 14 h3 M10.5 17 h0.333 c0.474 0 0.87 -0.323 0.916 -0.746 l0.502 -4.508 c0.047 -0.423 0.443 -0.746 0.916 -0.746 h0.333 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileHorizontal:
					return "M3 7 v10 a2 2 0 0 0 2 2 h14 a2 2 0 0 0 2 -2 v-7 l-5 -5 h-11 a2 2 0 0 0 -2 2 z M16 5 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileImport:
					return "M5 13 v-8 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 h-5.5 m-9.5 -2 h7 m-3 -3 l3 3 l-3 3 M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileInfinity:
					return "M9.5 21 h-2.5 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v6 M14 3 v4 a1 1 0 0 0 1 1 h4 M15.54 17.582 l1.46 1.42 l1.46 1.41 c0.809 0.78 -0.805 -0.779 0 0 s2.12 0.781 2.929 0 a1.951 1.951 0 0 0 0 -2.828 a2.123 2.123 0 0 0 -2.929 0 M15.536 17.586 a2.123 2.123 0 0 0 -2.929 0 a1.951 1.951 0 0 0 0 2.828 c0.809 0.781 2.12 0.781 2.929 0 c0.809 -0.781 -0.805 0.778 0 0 l1.46 -1.41 l1.46 -1.419 M0 0 h24 v24 H0 z";
				case IconKind.FileInfo:
					return "M12 11 h0.01 M11 14 h1 v4 h1 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileInvoice:
					return "M13 17 l2 0 M9 13 l6 0 M9 7 l1 0 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileLambda:
					return "M15 17 c-2.5 0 -2.5 -6 -5 -6 M10 17 l2 -3 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileLike:
					return "M5 12.1 v-7.1 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 h-2.3 M14 3 v4 a1 1 0 0 0 1 1 h4 M6 20 a1 1 0 0 0 1 1 h3.756 a1 1 0 0 0 0.958 -0.713 l1.2 -3 c0.09 -0.303 0.133 -0.63 -0.056 -0.884 c-0.188 -0.254 -0.542 -0.403 -0.858 -0.403 h-2 v-2.467 a1.1 1.1 0 0 0 -2.015 -0.61 l-1.985 3.077 v4 z M3 16 m0 1 a1 1 0 0 1 1 -1 h1 a1 1 0 0 1 1 1 v3 a1 1 0 0 1 -1 1 h-1 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.FileMinus:
					return "M9 14 l6 0 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileMusic:
					return "M12 16 l0 -5 l2 1 M11 16 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileOff:
					return "M7 3 h7 l5 5 v7 m0 4 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 v-14 M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.FileOrientation:
					return "M18 15 l2 -2 l2 2 M15 22 l-2 -2 l2 -2 M13 20 h5 a2 2 0 0 0 2 -2 v-5 M10 21 h-3 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v2 M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FilePencil:
					return "M10 18 l5 -5 a1.414 1.414 0 0 0 -2 -2 l-5 5 v2 h2 z M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FilePercent:
					return "M14 17 h0.01 M10 13 h0.01 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M10 17 l4 -4 M0 0 h24 v24 H0 z";
				case IconKind.FilePhone:
					return "M9 12 a0.5 0.5 0 0 0 1 0 v-1 a0.5 0.5 0 0 0 -1 0 v1 a5 5 0 0 0 5 5 h1 a0.5 0.5 0 0 0 0 -1 h-1 a0.5 0.5 0 0 0 0 1 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FilePlus:
					return "M9 14 l6 0 M12 11 l0 6 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FilePower:
					return "M12 11 l-2 3 h4 l-2 3 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileReport:
					return "M11.5 21 h-6.5 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v2 m0 3 v4 M12 3 v4 a1 1 0 0 0 1 1 h4 M17 13 v4 h4 M17 17 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M0 0 h24 v24 H0 z";
				case IconKind.FileRss:
					return "M9 17 h0.01 M15 17 a6 6 0 0 0 -6 -6 M12 17 a3 3 0 0 0 -3 -3 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileScissors:
					return "M15 17 l-6 -6 M9 17 l6 -6 M9 17 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M15 17 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileSearch:
					return "M18.5 19.5 l2.5 2.5 M16.5 17.5 m-2.5 0 a2.5 2.5 0 1 0 5 0 a2.5 2.5 0 1 0 -5 0 M12 21 h-5 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v4.5 M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileSettings:
					return "M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M10.285 12.97 l-1.285 -0.773 M15 15.803 l-1.285 -0.773 M10.268 15 l-1.3 0.75 M15.031 12.25 l-1.299 0.75 M12 16 v1.5 M12 10.5 v1.5 M12 14 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.FileShredder:
					return "M18 16 l0 4 M14 16 l0 2 M10 16 l0 6 M6 16 l0 2 M3 12 l18 0 M5 12 v-7 a2 2 0 0 1 2 -2 h7 l5 5 v4 M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileSignal:
					return "M9.525 11.525 a3.5 3.5 0 0 0 0 4.95 m4.95 0 a3.5 3.5 0 0 0 0 -4.95 M12 14 v0.01 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileSpreadsheet:
					return "M11 11 v7 M8 15 h8 M8 11 h8 v7 h-8 z M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileStack:
					return "M5 15 h14 M5 18 h14 M5 21 h14 M5 12 v-7 a2 2 0 0 1 2 -2 h7 l5 5 v4 M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileStar:
					return "M11.8 16.817 l-2.172 1.138 a0.392 0.392 0 0 1 -0.568 -0.41 l0.415 -2.411 l-1.757 -1.707 a0.389 0.389 0 0 1 0.217 -0.665 l2.428 -0.352 l1.086 -2.193 a0.392 0.392 0 0 1 0.702 0 l1.086 2.193 l2.428 0.352 a0.39 0.39 0 0 1 0.217 0.665 l-1.757 1.707 l0.414 2.41 a0.39 0.39 0 0 1 -0.567 0.411 l-2.172 -1.138 z M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileSymlink:
					return "M5 11 v-6 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 h-9.5 M14 3 v4 a1 1 0 0 0 1 1 h4 M9 17 l3 -3 l-3 -3 M4 21 v-4 a3 3 0 0 1 3 -3 h5 M0 0 h24 v24 H0 z";
				case IconKind.FileText:
					return "M9 17 l6 0 M9 13 l6 0 M9 9 l1 0 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileTime:
					return "M12 12.496 v1.504 l1 1 M12 14 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileTypography:
					return "M9 12 v-1 h6 v1 M12 18 v-7 M11 18 h2 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileUnknown:
					return "M12 14 a1.5 1.5 0 1 0 -1.14 -2.474 M12 17 v0.01 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileUpload:
					return "M9.5 13.5 l2.5 -2.5 l2.5 2.5 M12 11 v6 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileVector:
					return "M9.5 15 a2.5 2.5 0 0 1 2.5 -2.5 h1 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14.5 12.5 m-1.5 0 a1.5 1.5 0 1 0 3 0 a1.5 1.5 0 1 0 -3 0 M9.5 16.5 m-1.5 0 a1.5 1.5 0 1 0 3 0 a1.5 1.5 0 1 0 -3 0 M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileX:
					return "M10 12 l4 4 m0 -4 l-4 4 M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FileZip:
					return "M13 15 l-1 0 M11 13 l-1 0 M13 11 l-1 0 M11 9 l-1 0 M13 7 l-1 0 M11 5 l-1 0 M11 17 a2 2 0 0 1 2 2 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 v-2 a2 2 0 0 1 2 -2 z M6 20.735 a2 2 0 0 1 -1 -1.735 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 h-1 M0 0 h24 v24 H0 z";
				case IconKind.File:
					return "M17 21 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h7 l5 5 v11 a2 2 0 0 1 -2 2 z M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FilesOff:
					return "M3 3 l18 18 M16 17 v2 a2 2 0 0 1 -2 2 h-7 a2 2 0 0 1 -2 -2 v-10 a2 2 0 0 1 2 -2 M17 17 h-6 a2 2 0 0 1 -2 -2 v-6 m0 -4 a2 2 0 0 1 2 -2 h4 l5 5 v7 c0 0.294 -0.063 0.572 -0.177 0.823 M15 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.Files:
					return "M16 17 v2 a2 2 0 0 1 -2 2 h-7 a2 2 0 0 1 -2 -2 v-10 a2 2 0 0 1 2 -2 h2 M18 17 h-7 a2 2 0 0 1 -2 -2 v-10 a2 2 0 0 1 2 -2 h4 l5 5 v7 a2 2 0 0 1 -2 2 z M15 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.FilterOff:
					return "M9 5 h9.5 a1 1 0 0 1 0.5 1.5 l-4.049 4.454 m-0.951 3.046 v5 l-4 -3 v-4 l-5 -5.5 a1 1 0 0 1 0.18 -1.316 M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.Filter:
					return "M5.5 5 h13 a1 1 0 0 1 0.5 1.5 l-5 5.5 l0 7 l-4 -3 l0 -4 l-5 -5.5 a1 1 0 0 1 0.5 -1.5 M0 0 h24 v24 H0 z";
				case IconKind.FingerprintOff:
					return "M3 3 l18 18 M4.9 19 a22 22 0 0 1 -0.9 -7 v-1 a8 8 0 0 1 1.854 -5.143 m2.176 -1.825 a8 8 0 0 1 7.97 0.018 M8 15 a18 18 0 0 0 1.8 6 M12 12 v1 a14 14 0 0 0 2.5 8 M8 11 c0 -0.848 0.264 -1.634 0.713 -2.28 m2.4 -1.621 a4 4 0 0 1 4.887 3.901 l0 1 M18.9 7 a8 8 0 0 1 1.1 5 v1 a6 6 0 0 0 0.8 3 M0 0 h24 v24 H0 z";
				case IconKind.Fingerprint:
					return "M4.9 19 a22 22 0 0 1 -0.9 -7 v-1 a8 8 0 0 1 12 -6.95 M8 15 a18 18 0 0 0 1.8 6 M12 11 v2 a14 14 0 0 0 2.5 8 M8 11 a4 4 0 0 1 8 0 v1 a10 10 0 0 0 2 6 M18.9 7 a8 8 0 0 1 1.1 5 v1 a6 6 0 0 0 0.8 3 M0 0 h24 v24 H0 z";
				case IconKind.FireHydrantOff:
					return "M3 3 l18 18 M6 8 h2 m4 0 h6 M12 12 a2 2 0 1 0 2 2 M17 21 v-4 m2 -2 v-2 a1 1 0 0 0 -1 -1 h-1 v-4 a5 5 0 0 0 -8.533 -3.538 m-1.387 2.638 a5.03 5.03 0 0 0 -0.08 0.9 v4 h-1 a1 1 0 0 0 -1 1 v2 a1 1 0 0 0 1 1 h1 v5 M5 21 h14 M0 0 h24 v24 H0 z";
				case IconKind.FireHydrant:
					return "M6 8 h12 M12 14 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M17 21 v-5 h1 a1 1 0 0 0 1 -1 v-2 a1 1 0 0 0 -1 -1 h-1 v-4 a5 5 0 0 0 -10 0 v4 h-1 a1 1 0 0 0 -1 1 v2 a1 1 0 0 0 1 1 h1 v5 M5 21 h14 M0 0 h24 v24 H0 z";
				case IconKind.Firetruck:
					return "M6 12 l0 -4 M3 9 l18 -6 M3 17 l0 -5 l9 0 M12 18 v-11 h3 M7 18 h8 m4 0 h2 v-6 a5 5 0 0 0 -5 -5 h-1 l1.5 5 h4.5 M17 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.FirstAidKitOff:
					return "M3 3 l18 18 M12 12 v4 M10 14 h4 M12 8 h6 a2 2 0 0 1 2 2 v6 m-0.576 3.405 a2 2 0 0 1 -1.424 0.595 h-12 a2 2 0 0 1 -2 -2 v-8 a2 2 0 0 1 2 -2 h2 M8.595 4.577 a2 2 0 0 1 1.405 -0.577 h4 a2 2 0 0 1 2 2 v2 M0 0 h24 v24 H0 z";
				case IconKind.FirstAidKit:
					return "M12 12 v4 M10 14 h4 M4 8 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M8 8 v-2 a2 2 0 0 1 2 -2 h4 a2 2 0 0 1 2 2 v2 M0 0 h24 v24 H0 z";
				case IconKind.FishBone:
					return "M11 8 v8 M7 10 v4 M4.422 12 h10.578 M18 11 v0.01 M2 9.504 a40.73 40.73 0 0 0 2.422 2.504 a39.679 39.679 0 0 0 -2.422 2.498 M16.69 7.44 a6.973 6.973 0 0 0 -1.69 4.56 a6.97 6.97 0 0 0 1.699 4.571 c1.914 -0.684 3.691 -2.183 5.301 -4.565 c-1.613 -2.384 -3.394 -3.883 -5.312 -4.565 M0 0 h24 v24 H0 z";
				case IconKind.FishChristianity:
					return "M22 7 s-5.646 10 -12.308 10 c-3.226 0.025 -6.194 -1.905 -7.692 -5 c1.498 -3.095 4.466 -5.025 7.692 -5 c6.662 0 12.308 10 12.308 10 M0 0 h24 v24 H0 z";
				case IconKind.FishHookOff:
					return "M3 3 l18 18 M16 5 v-2 M16 7 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M16 9 v3 m-0.085 3.924 a5 5 0 0 1 -9.915 -0.924 v-4 l3 3 M0 0 h24 v24 H0 z";
				case IconKind.FishHook:
					return "M16 5 v-2 M16 7 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M16 9 v6 a5 5 0 0 1 -10 0 v-4 l3 3 M0 0 h24 v24 H0 z";
				case IconKind.FishOff:
					return "M3 3 l18 18 M11.153 11.169 c-0.287 0.777 -0.171 1.554 0.347 2.331 M18 11 v0.01 M2 9.504 c5.307 5.948 10.293 8.57 14.597 7.1 m2.583 -1.449 c0.988 -0.788 1.93 -1.836 2.82 -3.153 c-3 -4.443 -6.596 -5.812 -10.564 -4.548 m-2.764 1.266 c-2.145 1.266 -4.378 3.215 -6.672 5.786 M16.69 7.44 a6.973 6.973 0 0 0 -1.63 3.635 M0 0 h24 v24 H0 z";
				case IconKind.Fish:
					return "M11.5 10.5 c-0.667 1 -0.667 2 0 3 M18 11 v0.01 M2 9.504 c7.715 8.647 14.75 10.265 20 2.498 c-5.25 -7.761 -12.285 -6.142 -20 2.504 M16.69 7.44 a6.973 6.973 0 0 0 -1.69 4.56 c0 1.747 0.64 3.345 1.699 4.571 M0 0 h24 v24 H0 z";
				case IconKind.Flag2Filled:
					return "M19 4 a1 1 0 0 1 0.993 0.883 l0.007 0.117 v9 a1 1 0 0 1 -0.883 0.993 l-0.117 0.007 h-13 v6 a1 1 0 0 1 -0.883 0.993 l-0.117 0.007 a1 1 0 0 1 -0.993 -0.883 l-0.007 -0.117 v-16 a1 1 0 0 1 0.883 -0.993 l0.117 -0.007 h14 z M0 0 h24 v24 H0 z";
				case IconKind.Flag2Off:
					return "M3 3 l18 18 M5 14 h9 m4 0 h1 v-9 h-10 m-4 0 v16 M0 0 h24 v24 H0 z";
				case IconKind.Flag2:
					return "M5 14 h14 v-9 h-14 v16 M0 0 h24 v24 H0 z";
				case IconKind.Flag3Filled:
					return "M19 4 c0.852 0 1.297 0.986 0.783 1.623 l-0.076 0.084 l-3.792 3.793 l3.792 3.793 c0.603 0.602 0.22 1.614 -0.593 1.701 l-0.114 0.006 h-13 v6 a1 1 0 0 1 -0.883 0.993 l-0.117 0.007 a1 1 0 0 1 -0.993 -0.883 l-0.007 -0.117 v-16 a1 1 0 0 1 0.883 -0.993 l0.117 -0.007 h14 z M0 0 h24 v24 H0 z";
				case IconKind.Flag3:
					return "M5 14 h14 l-4.5 -4.5 l4.5 -4.5 h-14 v16 M0 0 h24 v24 H0 z";
				case IconKind.FlagFilled:
					return "M4 5 a1 1 0 0 1 0.3 -0.714 a6 6 0 0 1 8.213 -0.176 l0.351 0.328 a4 4 0 0 0 5.272 0 l0.249 -0.227 c0.61 -0.483 1.527 -0.097 1.61 0.676 l0.005 0.113 v9 a1 1 0 0 1 -0.3 0.714 a6 6 0 0 1 -8.213 0.176 l-0.351 -0.328 a4 4 0 0 0 -5.136 -0.114 v6.552 a1 1 0 0 1 -1.993 0.117 l-0.007 -0.117 v-16 z M0 0 h24 v24 H0 z";
				case IconKind.FlagOff:
					return "M3 3 l18 18 M5 14 a5 5 0 0 1 7 0 a4.984 4.984 0 0 0 3.437 1.429 m3.019 -0.966 c0.19 -0.14 0.371 -0.294 0.544 -0.463 M7.641 3.645 a5 5 0 0 1 4.359 1.355 a5 5 0 0 0 7 0 M19 5 v9 M5 5 v16 M0 0 h24 v24 H0 z";
				case IconKind.Flag:
					return "M5 21 v-7 M5 5 a5 5 0 0 1 7 0 a5 5 0 0 0 7 0 v9 a5 5 0 0 1 -7 0 a5 5 0 0 0 -7 0 v-9 z M0 0 h24 v24 H0 z";
				case IconKind.FlameOff:
					return "M3 3 l18 18 M8.973 8.974 c-0.335 0.378 -0.67 0.716 -0.973 1.026 c-1.226 1.26 -2 3.24 -2 5 a6 6 0 0 0 11.472 2.466 m0.383 -3.597 c-0.32 -1.409 -1.122 -3.045 -1.855 -3.869 c-0.281 0.472 -0.543 0.87 -0.79 1.202 m-2.358 -2.35 c-0.068 -2.157 -1.182 -4.184 -1.852 -4.852 c0 0.968 -0.18 1.801 -0.465 2.527 M0 0 h24 v24 H0 z";
				case IconKind.Flame:
					return "M12 12 c2 -2.96 0 -7 -1 -8 c0 3.038 -1.773 4.741 -3 6 c-1.226 1.26 -2 3.24 -2 5 a6 6 0 1 0 12 0 c0 -1.532 -1.056 -3.94 -2 -5 c-1.786 3 -2.791 3 -4 2 z M0 0 h24 v24 H0 z";
				case IconKind.Flare:
					return "M12 3 l3 6 l6 3 l-6 3 l-3 6 l-3 -6 l-6 -3 l6 -3 z M0 0 h24 v24 H0 z";
				case IconKind.Flask2Off:
					return "M3 3 l18 18 M9 3 h6 M17.742 17.741 a6 6 0 0 1 -2.424 3.259 h-6.635 a6 6 0 0 1 1.317 -10.66 v-0.326 m0 -4.014 v-3 h4 v7 m0.613 0.598 a6 6 0 0 1 2.801 2.817 M6.1 15 h8.9 M0 0 h24 v24 H0 z";
				case IconKind.Flask2:
					return "M9 3 h6 M14 3 v7.342 a6 6 0 0 1 1.318 10.658 h-6.635 a6 6 0 0 1 1.317 -10.66 v-7.34 h4 z M6.1 15 h11.8 M0 0 h24 v24 H0 z";
				case IconKind.FlaskOff:
					return "M3 3 l18 18 M10 3 v3 m-0.268 3.736 l-3.732 10.264 a0.7 0.7 0 0 0 0.5 1 h11 a0.7 0.7 0 0 0 0.5 -1 l-1.143 -3.142 m-2.288 -6.294 l-0.569 -1.564 v-6 M13 9 h1 M9 3 h6 M0 0 h24 v24 H0 z";
				case IconKind.Flask:
					return "M10 3 v6 l-4 11 a0.7 0.7 0 0 0 0.5 1 h11 a0.7 0.7 0 0 0 0.5 -1 l-4 -11 v-6 M10 9 l4 0 M9 3 l6 0 M0 0 h24 v24 H0 z";
				case IconKind.FlipFlops:
					return "M6 16 v1 M2.5 14 c1 -3.333 2.167 -5 3.5 -5 c1.333 0 2.5 1.667 3.5 5 M6 4 c2.21 0 4 1.682 4 3.758 c0 0.078 0 0.156 -0.008 0.234 l-0.6 9.014 c-0.11 1.683 -1.596 3 -3.392 3 s-3.28 -1.311 -3.392 -3 l-0.6 -9.014 c-0.138 -2.071 1.538 -3.855 3.742 -3.985 c0.084 0 0.167 -0.007 0.25 -0.007 z M18 16 v1 M14.5 14 c1 -3.333 2.167 -5 3.5 -5 c1.333 0 2.5 1.667 3.5 5 M18 4 c2.21 0 4 1.682 4 3.758 c0 0.078 0 0.156 -0.008 0.234 l-0.6 9.014 c-0.11 1.683 -1.596 3 -3.392 3 s-3.28 -1.311 -3.392 -3 l-0.6 -9.014 c-0.138 -2.071 1.538 -3.855 3.743 -3.985 a4.15 4.15 0 0 1 0.25 -0.007 z M0 0 h24 v24 H0 z";
				case IconKind.FlipHorizontal:
					return "M7 8 l10 0 l-10 -5 l0 5 M7 16 l10 0 l-10 5 l0 -5 M3 12 l18 0 M0 0 h24 v24 H0 z";
				case IconKind.FlipVertical:
					return "M8 7 l0 10 l-5 0 l5 -10 M16 7 l0 10 l5 0 l-5 -10 M12 3 l0 18 M0 0 h24 v24 H0 z";
				case IconKind.FloatCenter:
					return "M4 19 l16 0 M4 15 l16 0 M19 11 l1 0 M19 7 l1 0 M4 11 l1 0 M4 7 l1 0 M9 5 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.FloatLeft:
					return "M4 19 l16 0 M4 15 l16 0 M14 11 l6 0 M14 7 l6 0 M4 5 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.FloatNone:
					return "M4 19 l16 0 M4 15 l16 0 M4 5 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.FloatRight:
					return "M4 19 l16 0 M4 15 l16 0 M4 11 l6 0 M4 7 l6 0 M14 5 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.FlowerOff:
					return "M3 3 l18 18 M9 5 a3 3 0 0 1 6 0 c0 0.562 -0.259 1.442 -0.776 2.64 l-0.724 1.36 l1.76 -1.893 c0.499 -0.6 0.922 -1 1.27 -1.205 a2.968 2.968 0 0 1 4.07 1.099 a3.011 3.011 0 0 1 -1.09 4.098 c-0.374 0.217 -0.99 0.396 -1.846 0.535 l-1.779 0.244 m0.292 0.282 l1.223 0.166 c1 0.145 1.698 0.337 2.11 0.576 a3.011 3.011 0 0 1 1.226 3.832 m-2.277 1.733 a2.968 2.968 0 0 1 -1.929 -0.369 c-0.348 -0.202 -0.771 -0.604 -1.27 -1.205 l-1.76 -1.893 l0.724 1.36 c0.516 1.199 0.776 2.079 0.776 2.64 a3 3 0 0 1 -6 0 c0 -0.562 0.259 -1.442 0.776 -2.64 l0.724 -1.36 l-1.76 1.893 c-0.499 0.601 -0.922 1 -1.27 1.205 a2.968 2.968 0 0 1 -4.07 -1.098 a3.011 3.011 0 0 1 1.09 -4.098 c0.374 -0.218 0.99 -0.396 1.846 -0.536 l2.664 -0.366 l-2.4 -0.325 c-1 -0.145 -1.698 -0.337 -2.11 -0.576 a3.011 3.011 0 0 1 -1.09 -4.099 a2.968 2.968 0 0 1 2.134 -1.467 M9.875 9.882 a3 3 0 0 0 4.247 4.238 m0.581 -3.423 a3.012 3.012 0 0 0 -1.418 -1.409 M0 0 h24 v24 H0 z";
				case IconKind.Flower:
					return "M12 2 a3 3 0 0 1 3 3 c0 0.562 -0.259 1.442 -0.776 2.64 l-0.724 1.36 l1.76 -1.893 c0.499 -0.6 0.922 -1 1.27 -1.205 a2.968 2.968 0 0 1 4.07 1.099 a3.011 3.011 0 0 1 -1.09 4.098 c-0.374 0.217 -0.99 0.396 -1.846 0.535 l-2.664 0.366 l2.4 0.326 c1 0.145 1.698 0.337 2.11 0.576 a3.011 3.011 0 0 1 1.09 4.098 a2.968 2.968 0 0 1 -4.07 1.098 c-0.348 -0.202 -0.771 -0.604 -1.27 -1.205 l-1.76 -1.893 l0.724 1.36 c0.516 1.199 0.776 2.079 0.776 2.64 a3 3 0 0 1 -6 0 c0 -0.562 0.259 -1.442 0.776 -2.64 l0.724 -1.36 l-1.76 1.893 c-0.499 0.601 -0.922 1 -1.27 1.205 a2.968 2.968 0 0 1 -4.07 -1.098 a3.011 3.011 0 0 1 1.09 -4.098 c0.374 -0.218 0.99 -0.396 1.846 -0.536 l2.664 -0.366 l-2.4 -0.325 c-1 -0.145 -1.698 -0.337 -2.11 -0.576 a3.011 3.011 0 0 1 -1.09 -4.099 a2.968 2.968 0 0 1 4.07 -1.099 c0.348 0.203 0.771 0.604 1.27 1.205 l1.76 1.894 c-1 -2.292 -1.5 -3.625 -1.5 -4 a3 3 0 0 1 3 -3 z M12 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.Focus2:
					return "M19 12 l2 0 M12 19 l0 2 M3 12 l2 0 M12 3 l0 2 M12 12 m-7 0 a7 7 0 1 0 14 0 a7 7 0 1 0 -14 0 M11.5,12a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M0 0 h24 v24 H0 z";
				case IconKind.FocusCentered:
					return "M16 20 h2 a2 2 0 0 0 2 -2 v-2 M16 4 h2 a2 2 0 0 1 2 2 v2 M4 16 v2 a2 2 0 0 0 2 2 h2 M4 8 v-2 a2 2 0 0 1 2 -2 h2 M12 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.Focus:
					return "M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M11.5,12a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M0 0 h24 v24 H0 z";
				case IconKind.FoldDown:
					return "M4 7 l1 0 M19 7 l1 0 M14 7 l1 0 M9 7 l1 0 M12 11 v8 l3 -3 m-6 0 l3 3 M0 0 h24 v24 H0 z";
				case IconKind.FoldUp:
					return "M4 17 l1 0 M19 17 l1 0 M14 17 l1 0 M9 17 l1 0 M12 13 v-8 l-3 3 m6 0 l-3 -3 M0 0 h24 v24 H0 z";
				case IconKind.Fold:
					return "M19 12 l1 0 M14 12 l1 0 M9 12 l1 0 M4 12 l1 0 M12 21 v-6 l3 3 m-6 0 l3 -3 M12 3 v6 l3 -3 m-6 0 l3 3 M0 0 h24 v24 H0 z";
				case IconKind.FolderMinus:
					return "M9 13 l6 0 M5 4 h4 l3 3 h7 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 v-11 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.FolderOff:
					return "M19 19 h-14 a2 2 0 0 1 -2 -2 v-11 a2 2 0 0 1 1.172 -1.821 m3.828 -0.179 h1 l3 3 h7 a2 2 0 0 1 2 2 v8 M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.FolderPlus:
					return "M9 13 l6 0 M12 10 l0 6 M5 4 h4 l3 3 h7 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 v-11 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.FolderX:
					return "M10 11 l4 4 m0 -4 l-4 4 M5 4 h4 l3 3 h7 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 v-11 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.Folder:
					return "M5 4 h4 l3 3 h7 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 v-11 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.FoldersOff:
					return "M3 3 l18 18 M17 17 v2 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 v-9 a2 2 0 0 1 2 -2 h2 M17 17 h-8 a2 2 0 0 1 -2 -2 v-8 m1.177 -2.823 c0.251 -0.114 0.53 -0.177 0.823 -0.177 h3 l2 2 h5 a2 2 0 0 1 2 2 v7 c0 0.55 -0.223 1.05 -0.583 1.411 M0 0 h24 v24 H0 z";
				case IconKind.Folders:
					return "M17 17 v2 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 v-9 a2 2 0 0 1 2 -2 h2 M9 4 h3 l2 2 h5 a2 2 0 0 1 2 2 v7 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 v-9 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.Forbid2:
					return "M9 15 l6 -6 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.Forbid:
					return "M9 9 l6 6 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.Forklift:
					return "M16 13 l3 0 M22 15 h-3 v-10 M9 11 v-6 h4 l3 6 M5 11 v-4 h4 M3 17 v-6 h13 v6 M7 17 l5 0 M14 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Forms:
					return "M13 12 h0.01 M17 12 h0.01 M5 7 h-1 a1 1 0 0 0 -1 1 v8 a1 1 0 0 0 1 1 h1 M13 7 h7 a1 1 0 0 1 1 1 v8 a1 1 0 0 1 -1 1 h-7 M6 3 a3 3 0 0 1 3 3 v12 a3 3 0 0 1 -3 3 M12 3 a3 3 0 0 0 -3 3 v12 a3 3 0 0 0 3 3 M0 0 h24 v24 H0 z";
				case IconKind.FountainOff:
					return "M3 3 l18 18 M20 16 h1 v1 m-0.871 3.114 a2.99 2.99 0 0 1 -2.129 0.886 h-12 a3 3 0 0 1 -3 -3 v-2 h13 M7.451 3.43 a3 3 0 0 1 4.549 2.57 M12 16 v-4 m0 -4 v-2 a3 3 0 0 1 6 0 M15 16 v-1 m0 -4 a2 2 0 1 1 4 0 M9 16 v-5 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Fountain:
					return "M3 16 h18 v2 a3 3 0 0 1 -3 3 h-12 a3 3 0 0 1 -3 -3 v-2 z M6 6 a3 3 0 0 1 6 0 M12 16 v-10 a3 3 0 0 1 6 0 M15 16 v-5 a2 2 0 1 1 4 0 M9 16 v-5 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.FrameOff:
					return "M3 3 l18 18 M17 4 v9 m0 4 v3 M7 7 v13 M4 17 h13 M4 7 h3 m4 0 h9 M0 0 h24 v24 H0 z";
				case IconKind.Frame:
					return "M17 4 l0 16 M7 4 l0 16 M4 17 l16 0 M4 7 l16 0 M0 0 h24 v24 H0 z";
				case IconKind.FreeRights:
					return "M16.5 16.5 l1.5 1.5 M6 6 l1.5 1.5 M12 15 v2 M12 7 v2 M13.867 9.75 c-0.246 -0.48 -0.708 -0.769 -1.2 -0.75 h-1.334 c-0.736 0 -1.333 0.67 -1.333 1.5 c0 0.827 0.597 1.499 1.333 1.499 h1.334 c0.736 0 1.333 0.671 1.333 1.5 c0 0.828 -0.597 1.499 -1.333 1.499 h-1.334 c-0.492 0.019 -0.954 -0.27 -1.2 -0.75 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.FridgeOff:
					return "M3 3 l18 18 M9 13 v3 M5 10 h5 m4 0 h5 M7 3 h10 a2 2 0 0 1 2 2 v10 m0 4 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 v-14 M0 0 h24 v24 H0 z";
				case IconKind.Fridge:
					return "M9 6 v1 M9 13 v3 M5 10 h14 M5 3 m0 2 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v14 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.FriendsOff:
					return "M3 3 l18 18 M15 22 v-4 h-2 l1.254 -3.763 m1.036 -2.942 a1 1 0 0 1 0.71 -0.295 h2 a1 1 0 0 1 1 1 l1.503 4.508 m-1.503 2.492 v3 M17 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 22 v-5 l-1 -1 v-4 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 l-1 1 v5 M5 5 a2 2 0 0 0 2 2 m2 -2 a2 2 0 0 0 -2 -2 M0 0 h24 v24 H0 z";
				case IconKind.Friends:
					return "M15 22 v-4 h-2 l2 -6 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 l2 6 h-2 v4 M17 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 22 v-5 l-1 -1 v-4 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 l-1 1 v5 M7 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.FunctionOff:
					return "M3 3 l18 18 M9 12 h3 M8 4 h10 a2 2 0 0 1 2 2 v10 m-0.586 3.414 a2 2 0 0 1 -1.414 0.586 h-12 a2 2 0 0 1 -2 -2 v-12 c0 -0.547 0.22 -1.043 0.576 -1.405 M9 15.5 v0.25 c0 0.69 0.56 1.25 1.25 1.25 a1.38 1.38 0 0 0 1.374 -1.244 l0.376 -3.756 m0.363 -3.63 l0.013 -0.126 a1.38 1.38 0 0 1 1.374 -1.244 c0.69 0 1.25 0.56 1.25 1.25 v0.25 M0 0 h24 v24 H0 z";
				case IconKind.Function:
					return "M9 12 h6 M9 15.5 v0.25 c0 0.69 0.56 1.25 1.25 1.25 c0.71 0 1.304 -0.538 1.374 -1.244 l0.752 -7.512 a1.381 1.381 0 0 1 1.374 -1.244 c0.69 0 1.25 0.56 1.25 1.25 v0.25 M4 4 m0 2.667 a2.667 2.667 0 0 1 2.667 -2.667 h10.666 a2.667 2.667 0 0 1 2.667 2.667 v10.666 a2.667 2.667 0 0 1 -2.667 2.667 h-10.666 a2.667 2.667 0 0 1 -2.667 -2.667 z M0 0 h24 v24 H0 z";
				case IconKind.GardenCartOff:
					return "M3 3 l18 18 M6 8 h2 m4 0 h9 l-3 6.01 m-3.319 0.693 l-4.276 -0.45 a4 4 0 0 1 -3.296 -2.493 l-2.853 -7.13 a1 1 0 0 0 -0.928 -0.63 h-1.323 M6 8 v11 a1 1 0 0 0 1.806 0.591 l3.694 -5.091 v0.055 M15.733 15.732 a2.5 2.5 0 1 0 3.544 3.527 M0 0 h24 v24 H0 z";
				case IconKind.GardenCart:
					return "M6 8 h15 l-3.5 7 l-7.1 -0.747 a4 4 0 0 1 -3.296 -2.493 l-2.853 -7.13 a1 1 0 0 0 -0.928 -0.63 h-1.323 M6 8 v11 a1 1 0 0 0 1.806 0.591 l3.694 -5.091 v0.055 M17.5 17.5 m-2.5 0 a2.5 2.5 0 1 0 5 0 a2.5 2.5 0 1 0 -5 0 M0 0 h24 v24 H0 z";
				case IconKind.GasStationOff:
					return "M3 3 l18 18 M4 11 h7 M18 7 v1 a1 1 0 0 0 1 1 h1 M3 20 h12 M4 20 v-14 c0 -0.548 0.22 -1.044 0.577 -1.405 m3.423 -0.595 h4 a2 2 0 0 1 2 2 v4 m0 4 v6 M15 11 a2 2 0 0 1 2 2 m3 3 v-7 l-3 -3 M0 0 h24 v24 H0 z";
				case IconKind.GasStation:
					return "M4 11 l10 0 M18 7 v1 a1 1 0 0 0 1 1 h1 M3 20 l12 0 M4 20 v-14 a2 2 0 0 1 2 -2 h6 a2 2 0 0 1 2 2 v14 M14 11 h1 a2 2 0 0 1 2 2 v3 a1.5 1.5 0 0 0 3 0 v-7 l-3 -3 M0 0 h24 v24 H0 z";
				case IconKind.GaugeOff:
					return "M3 3 l18 18 M7 12 c0 -1.386 0.564 -2.64 1.475 -3.546 m2.619 -1.372 c0.294 -0.054 0.597 -0.082 0.906 -0.082 M14 10 l2 -2 M11.283 11.303 a1 1 0 0 0 1.419 1.41 M20.038 16.052 a9 9 0 0 0 -12.067 -12.102 m-2.333 1.686 a9 9 0 1 0 12.73 12.726 M0 0 h24 v24 H0 z";
				case IconKind.Gauge:
					return "M7 12 a5 5 0 0 1 5 -5 M13.41 10.59 l2.59 -2.59 M12 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.Gavel:
					return "M6.793 15.793 l-3.586 -3.586 a1 1 0 0 1 0 -1.414 l2.293 -2.293 l0.5 0.5 l3 -3 l-0.5 -0.5 l2.293 -2.293 a1 1 0 0 1 1.414 0 l3.586 3.586 a1 1 0 0 1 0 1.414 l-2.293 2.293 l-0.5 -0.5 l-3 3 l0.5 0.5 l-2.293 2.293 a1 1 0 0 1 -1.414 0 z M3 21 h7 M13 10 l-4 -4 M6 9 l4 4 M13 10 l7.383 7.418 c0.823 0.82 0.823 2.148 0 2.967 a2.11 2.11 0 0 1 -2.976 0 l-7.407 -7.385 M0 0 h24 v24 H0 z";
				case IconKind.GenderAgender:
					return "M7 12 h11 M12 12 m-6 0 a6 6 0 1 0 12 0 a6 6 0 1 0 -12 0 M0 0 h24 v24 H0 z";
				case IconKind.GenderAndrogyne:
					return "M16.5 10.5 l-3 -3 M19 9 v-4 h-4 M9 15 m-5 0 a5 5 0 1 0 10 0 a5 5 0 1 0 -10 0 M13 11 l6 -6 M0 0 h24 v24 H0 z";
				case IconKind.GenderBigender:
					return "M8 19 h6 M11 16 v6 M15 3 h4 v4 M19 3 l-5 5 M11 11 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M0 0 h24 v24 H0 z";
				case IconKind.GenderDemiboy:
					return "M19 5 h-5 M19 5 l-5.4 5.4 M10 14 m-5 0 a5 5 0 1 0 10 0 a5 5 0 1 0 -10 0 M0 0 h24 v24 H0 z";
				case IconKind.GenderDemigirl:
					return "M9 18 h3 M12 14 v7 M12 9 m-5 0 a5 5 0 1 0 10 0 a5 5 0 1 0 -10 0 M0 0 h24 v24 H0 z";
				case IconKind.GenderEpicene:
					return "M12 12 h0.01 M3 14 l5.464 -5.535 M15.536 15.535 l5.464 -5.535 M15.536 15.536 a5 5 0 1 0 -7.072 -7.072 a5 5 0 0 0 7.072 7.072 z M0 0 h24 v24 H0 z";
				case IconKind.GenderFemale:
					return "M9 18 h6 M12 14 v7 M12 9 m-5 0 a5 5 0 1 0 10 0 a5 5 0 1 0 -10 0 M0 0 h24 v24 H0 z";
				case IconKind.GenderFemme:
					return "M7 18 h10 M12 14 v7 M12 9 m-5 0 a5 5 0 1 0 10 0 a5 5 0 1 0 -10 0 M0 0 h24 v24 H0 z";
				case IconKind.GenderGenderfluid:
					return "M3 7 v-4 h4 M17 20 l3 -3 M21 21 l-6 -6 M5.5 8.5 l3 -3 M9 9 l-6 -6 M12 12 h0.01 M5.536 15.195 l3 -5.196 M15.464 14 l3 -5.196 M10 15.464 a4 4 0 1 0 4 -6.928 a4 4 0 0 0 -4 6.928 z M0 0 h24 v24 H0 z";
				case IconKind.GenderGenderless:
					return "M7 15 h10 M12 10 v-7 M12 10 a5 5 0 1 1 0 10 a5 5 0 0 1 0 -10 z M0 0 h24 v24 H0 z";
				case IconKind.GenderGenderqueer:
					return "M9.5 4.5 l5 3 M14.5 4.5 l-5 3 M12 11 v-8 M12 11 a5 5 0 1 1 0 10 a5 5 0 0 1 0 -10 z M0 0 h24 v24 H0 z";
				case IconKind.GenderHermaphrodite:
					return "M15 3 a3 3 0 1 1 -6 0 M12 6 a4 4 0 1 1 0 8 a4 4 0 0 1 0 -8 z M9 18 h6 M12 14 v7 M0 0 h24 v24 H0 z";
				case IconKind.GenderIntergender:
					return "M14 20 l2 -2 M9 4 a5 5 0 1 1 0 10 a5 5 0 0 1 0 -10 z M11.5 13.5 l6.5 6.5 M13.5 11.5 l6.5 6.5 v-4 M0 0 h24 v24 H0 z";
				case IconKind.GenderMale:
					return "M19 5 v5 M19 5 h-5 M19 5 l-5.4 5.4 M10 14 m-5 0 a5 5 0 1 0 10 0 a5 5 0 1 0 -10 0 M0 0 h24 v24 H0 z";
				case IconKind.GenderNeutrois:
					return "M12 10 v-7 M12 10 a5 5 0 1 1 0 10 a5 5 0 0 1 0 -10 z M0 0 h24 v24 H0 z";
				case IconKind.GenderThird:
					return "M8 12 l-5 -4 v8 z M11 12 h-3 M11 12 a5 5 0 1 0 10 0 a5 5 0 0 0 -10 0 z M0 0 h24 v24 H0 z";
				case IconKind.GenderTransgender:
					return "M9.5 19 h5 M12 16 v5 M5.5 8.5 l3 -3 M3 7 v-4 h4 M9 9 l-6 -6 M21 7 v-4 h-4 M15 9 l6 -6 M12 12 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M0 0 h24 v24 H0 z";
				case IconKind.GenderTrasvesti:
					return "M4 8 l4 -4 M6 6 l5.4 5.4 M15 20 a5 5 0 1 1 0 -10 a5 5 0 0 1 0 10 z M0 0 h24 v24 H0 z";
				case IconKind.Geometry:
					return "M12 5 v-2 M4 12 c1.526 2.955 4.588 5 8 5 c3.41 0 6.473 -2.048 8 -5 M12 7 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M7 21 l4 -12 m2 0 l1.48 4.439 m0.949 2.847 l1.571 4.714 M0 0 h24 v24 H0 z";
				case IconKind.Ghost2:
					return "M11 14 h2 a1 1 0 0 0 -2 0 z M12 3 a7 7 0 0 1 7 7 v1 l1 0 a2 2 0 1 1 0 4 l-1 0 v3 l2 3 h-10 a6 6 0 0 1 -6 -5.775 l0 -0.226 l-1 0 a2 2 0 0 1 0 -4 l1 0 v-1 a7 7 0 0 1 7 -7 z M14 9 h0.01 M10 9 h0.01 M0 0 h24 v24 H0 z";
				case IconKind.GhostOff:
					return "M3 3 l18 18 M10 14 a3.5 3.5 0 0 0 4 0 M14 10 h0.01 M8.794 4.776 a7 7 0 0 1 10.206 6.224 v4 m-0.12 3.898 a1.779 1.779 0 0 1 -2.98 0.502 a1.65 1.65 0 0 0 -2.6 0 a1.65 1.65 0 0 1 -2.6 0 a1.65 1.65 0 0 0 -2.6 0 a1.78 1.78 0 0 1 -3.1 -1.4 v-7 c0 -1.683 0.594 -3.227 1.583 -4.434 M0 0 h24 v24 H0 z";
				case IconKind.Ghost:
					return "M10 14 a3.5 3.5 0 0 0 4 0 M14 10 l0.01 0 M10 10 l0.01 0 M5 11 a7 7 0 0 1 14 0 v7 a1.78 1.78 0 0 1 -3.1 1.4 a1.65 1.65 0 0 0 -2.6 0 a1.65 1.65 0 0 1 -2.6 0 a1.65 1.65 0 0 0 -2.6 0 a1.78 1.78 0 0 1 -3.1 -1.4 v-7 M0 0 h24 v24 H0 z";
				case IconKind.Gif:
					return "M20 12 h-4 M16 16 v-8 h5 M12 8 v8 M8 8 h-3 a2 2 0 0 0 -2 2 v4 a2 2 0 0 0 2 2 h3 v-4 h-1 M0 0 h24 v24 H0 z";
				case IconKind.GiftCard:
					return "M8 13 c-0.789 0 -2 -0.672 -2 -1.5 s0.711 -1.5 1.5 -1.5 c1.128 -0.02 2.077 1.17 2.5 3 c0.423 -1.83 1.372 -3.02 2.5 -3 c0.789 0 1.5 0.672 1.5 1.5 s-1.211 1.5 -2 1.5 h-4 z M7 16 l3 -3 l3 3 M3 5 m0 3 a3 3 0 0 1 3 -3 h12 a3 3 0 0 1 3 3 v8 a3 3 0 0 1 -3 3 h-12 a3 3 0 0 1 -3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.GiftOff:
					return "M3 3 l18 18 M7.5 8 a2.5 2.5 0 0 1 -2.457 -2.963 m2.023 -2 c0.14 -0.023 0.286 -0.037 0.434 -0.037 c1.974 -0.034 3.76 1.95 4.5 5 c0.74 -3.05 2.526 -5.034 4.5 -5 a2.5 2.5 0 1 1 0 5 M19 12 v3 m0 4 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 v-7 M12 12 v9 M12 8 h8 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-4 m-4 0 h-8 a1 1 0 0 1 -1 -1 v-2 a1 1 0 0 1 1 -1 h4 M0 0 h24 v24 H0 z";
				case IconKind.Gift:
					return "M7.5 8 a2.5 2.5 0 0 1 0 -5 a4.8 8 0 0 1 4.5 5 a4.8 8 0 0 1 4.5 -5 a2.5 2.5 0 0 1 0 5 M19 12 v7 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 v-7 M12 8 l0 13 M3 8 m0 1 a1 1 0 0 1 1 -1 h16 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-16 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.GitBranchDeleted:
					return "M15 8 l4 -4 M15 4 l4 4 M14 14 l3 -3 l3 3 M9 18 h6 a2 2 0 0 0 2 -2 v-5 M7 8 v8 M7 6 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M7 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.GitBranch:
					return "M14 14 l3 -3 l3 3 M9 18 h6 a2 2 0 0 0 2 -2 v-5 M7 8 l0 8 M17 6 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M7 6 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M7 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.GitCherryPick:
					return "M17 12 h3 M13 7 h2.5 l1.5 5 l-1.5 5 h-2.5 M7 15 v6 M7 3 v6 M7 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.GitCommit:
					return "M12 15 l0 6 M12 3 l0 6 M12 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.GitCompare:
					return "M10 15 l3 3 l-3 3 M13 18 h-5 a2 2 0 0 1 -2 -2 v-8 M14 9 l-3 -3 l3 -3 M11 6 h5 a2 2 0 0 1 2 2 v8 M18 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 6 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.GitFork:
					return "M12 12 l0 4 M7 8 v2 a2 2 0 0 0 2 2 h6 a2 2 0 0 0 2 -2 v-2 M17 6 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M7 6 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M12 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.GitMerge:
					return "M7 8 a4 4 0 0 0 4 4 h4 M7 8 l0 8 M17 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M7 6 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M7 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.GitPullRequestClosed:
					return "M16 4 l4 4 m0 -4 l-4 4 M18 11 v5 M6 8 v8 M18 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 6 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.GitPullRequestDraft:
					return "M18 6 h0.01 M18 11 h0.01 M6 8 v8 M18 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 6 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.GitPullRequest:
					return "M14 9 l-3 -3 l3 -3 M11 6 h5 a2 2 0 0 1 2 2 v8 M6 8 l0 8 M18 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 6 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Gizmo:
					return "M20 19 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M4 19 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12 4 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12 4 v9.5 M20 19 l-8 -5.5 l-8 5.5 M0 0 h24 v24 H0 z";
				case IconKind.GlassFull:
					return "M6 10 a5 5 0 0 1 6 0 a5 5 0 0 0 6 0 M17 3 l1 7 c0 3.012 -2.686 5 -6 5 s-6 -1.988 -6 -5 l1 -7 h10 z M12 15 l0 6 M8 21 l8 0 M0 0 h24 v24 H0 z";
				case IconKind.GlassOff:
					return "M3 3 l18 18 M7 3 h10 l1 7 a4.511 4.511 0 0 1 -1.053 2.94 m-2.386 1.625 a7.48 7.48 0 0 1 -2.561 0.435 c-3.314 0 -6 -1.988 -6 -5 l0.5 -3.495 M12 15 l0 6 M8 21 l8 0 M0 0 h24 v24 H0 z";
				case IconKind.Glass:
					return "M17 3 l1 7 c0 3.012 -2.686 5 -6 5 s-6 -1.988 -6 -5 l1 -7 h10 z M12 15 l0 6 M8 21 l8 0 M0 0 h24 v24 H0 z";
				case IconKind.GlobeOff:
					return "M3 3 l18 18 M8 22 h8 M12 18 v4 M6.75 16 a8.015 8.015 0 0 0 9.799 0.553 m2.016 -2 a8.015 8.015 0 0 0 -2.565 -11.555 M8.36 8.339 a4 4 0 0 0 5.281 5.31 m2 -1.98 a4 4 0 0 0 -5.262 -5.325 M0 0 h24 v24 H0 z";
				case IconKind.Globe:
					return "M8 22 l8 0 M12 18 l0 4 M6.75 16 a8.015 8.015 0 1 0 9.25 -13 M12 10 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M0 0 h24 v24 H0 z";
				case IconKind.GoGame:
					return "M18 3 v13 m0 4 v1 M12 3 v7 m0 4 v7 M6 3 v1 m0 4 v8 m0 4 v1 M3 18 h1 m4 0 h8 m4 0 h1 M3 6 h1 m4 0 h13 M3 12 h7 m4 0 h7 M18 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M12 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 6 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.GolfOff:
					return "M3 3 l18 18 M9 17.67 c-0.62 0.36 -1 0.82 -1 1.33 c0 1.1 1.8 2 4 2 s4 -0.9 4 -2 c0 -0.5 -0.38 -0.97 -1 -1.33 M12 18 v-6 m0 -4 v-5 l7 4 l-5.07 2.897 M0 0 h24 v24 H0 z";
				case IconKind.Golf:
					return "M9 17.67 c-0.62 0.36 -1 0.82 -1 1.33 c0 1.1 1.8 2 4 2 s4 -0.9 4 -2 c0 -0.5 -0.38 -0.97 -1 -1.33 M12 18 v-15 l7 4 l-7 4 M0 0 h24 v24 H0 z";
				case IconKind.Gps:
					return "M12 17 l-1 -4 l-4 -1 l9 -4 z M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.Gradienter:
					return "M12 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M20.78 10 a9 9 0 0 0 -8.78 -7 a8.985 8.985 0 0 0 -8.782 7 M3.227 14 c0.917 4 4.497 7 8.773 7 c4.277 0 7.858 -3 8.773 -7 M0 0 h24 v24 H0 z";
				case IconKind.Grain:
					return "M19.5 14.5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M14.5 19.5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M19.5 4.5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M14.5 9.5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M4.5 19.5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M9.5 14.5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M9.5 4.5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M4.5 9.5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.GraphOff:
					return "M3 3 l18 18 M7 14 l3 -3 l2 2 l0.5 -0.5 m2 -2 l0.5 -0.5 l2 2 M8 4 h10 a2 2 0 0 1 2 2 v10 m-0.586 3.414 a2 2 0 0 1 -1.414 0.586 h-12 a2 2 0 0 1 -2 -2 v-12 c0 -0.547 0.22 -1.043 0.576 -1.405 M0 0 h24 v24 H0 z";
				case IconKind.Graph:
					return "M7 14 l3 -3 l2 2 l3 -3 l2 2 M4 18 v-12 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Grave2:
					return "M5 21 v-2 a3 3 0 0 1 3 -3 h8 a3 3 0 0 1 3 3 v2 h-14 z M10 9 h4 M12 7 v5 M7 16.17 v-9.17 a3 3 0 0 1 3 -3 h4 a3 3 0 0 1 3 3 v9.171 M0 0 h24 v24 H0 z";
				case IconKind.Grave:
					return "M10 16 v-5 h-4 v-4 h4 v-4 h4 v4 h4 v4 h-4 v5 M5 21 v-2 a3 3 0 0 1 3 -3 h8 a3 3 0 0 1 3 3 v2 h-14 z M0 0 h24 v24 H0 z";
				case IconKind.GridDots:
					return "M19 19 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12 19 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M5 19 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M19 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M5 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M19 5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12 5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M5 5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.GridPattern:
					return "M8 14 h8 M8 10 h8 M14 8 v8 M10 8 v8 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.GrillFork:
					return "M3 7 l3.05 3.15 a2.9 2.9 0 0 0 4.1 -4.1 l-3.15 -3.05 M19.347 16.575 l1.08 1.079 a1.96 1.96 0 0 1 -2.773 2.772 l-1.08 -1.079 a1.96 1.96 0 0 1 2.773 -2.772 z M5 5 l11.5 11.5 M0 0 h24 v24 H0 z";
				case IconKind.GrillOff:
					return "M3 3 l18 18 M9 5 v-1 M12 5 v-1 M15 5 v-1 M15 18 h-8 M9 14 l-3 6 M18.827 18.815 a2 2 0 1 1 -2.663 -2.633 M8 8 h-3 a6 6 0 0 0 6 6 h2 c0.315 0 0.624 -0.024 0.926 -0.071 m2.786 -1.214 a5.99 5.99 0 0 0 2.284 -4.49 l0 -0.225 h-7 M0 0 h24 v24 H0 z";
				case IconKind.GrillSpatula:
					return "M3 7 l3.05 3.15 a2.9 2.9 0 0 0 4.1 -4.1 l-3.15 -3.05 l-4 4 z M19.347 16.575 l1.08 1.079 a1.96 1.96 0 0 1 -2.773 2.772 l-1.08 -1.079 a1.96 1.96 0 0 1 2.773 -2.772 z M10.2 10.2 l6.3 6.3 M0 0 h24 v24 H0 z";
				case IconKind.Grill:
					return "M9 5 v-1 M12 5 v-1 M15 5 v-1 M15 18 h-8 M9 14 l-3 6 M15 14 l1 2 M17 20 a2 2 0 1 1 0 -4 a2 2 0 0 1 0 4 z M19 8 h-14 a6 6 0 0 0 6 6 h2 a6 6 0 0 0 6 -5.775 l0 -0.225 z M0 0 h24 v24 H0 z";
				case IconKind.GripHorizontal:
					return "M19 15 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M19 9 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12 15 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12 9 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M5 15 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M5 9 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.GripVertical:
					return "M15 19 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M15 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M15 5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M9 19 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M9 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M9 5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.Growth:
					return "M16.5 15 a4.5 4.5 0 0 0 -4.5 4.5 m4.5 -8.5 a4.5 4.5 0 0 0 -4.5 4.5 m4.5 -8.5 a4.5 4.5 0 0 0 -4.5 4.5 m-4 3.5 c2.21 0 4 2.015 4 4.5 m-4 -8.5 c2.21 0 4 2.015 4 4.5 m-4 -8.5 c2.21 0 4 2.015 4 4.5 m0 -7.5 v6 M0 0 h24 v24 H0 z";
				case IconKind.GuitarPickFilled:
					return "M16 18.5 c2 -2.5 4 -6.5 4 -10.5 c0 -2.946 -2.084 -4.157 -4.204 -4.654 c-0.864 -0.23 -2.13 -0.346 -3.796 -0.346 c-1.667 0 -2.932 0.115 -3.796 0.346 c-2.12 0.497 -4.204 1.708 -4.204 4.654 c0 3.312 2 8 4 10.5 c0.297 0.37 0.618 0.731 0.963 1.081 l0.354 0.347 a3.9 3.9 0 0 0 5.364 0 a14.05 14.05 0 0 0 1.319 -1.428 z M0 0 h24 v24 H0 z";
				case IconKind.GuitarPick:
					return "M16 18.5 c2 -2.5 4 -6.5 4 -10.5 c0 -2.946 -2.084 -4.157 -4.204 -4.654 c-0.864 -0.23 -2.13 -0.346 -3.796 -0.346 c-1.667 0 -2.932 0.115 -3.796 0.346 c-2.12 0.497 -4.204 1.708 -4.204 4.654 c0 3.312 2 8 4 10.5 c0.297 0.37 0.618 0.731 0.963 1.081 l0.354 0.347 a3.9 3.9 0 0 0 5.364 0 a14.05 14.05 0 0 0 1.319 -1.428 z M0 0 h24 v24 H0 z";
				case IconKind.H1:
					return "M11 6 h2 M3 6 h2 M4 12 h8 M3 18 h2 M11 18 h2 M12 6 v12 M4 6 v12 M19 18 v-8 l-2 2 M0 0 h24 v24 H0 z";
				case IconKind.H2:
					return "M11 6 h2 M3 6 h2 M4 12 h8 M3 18 h2 M11 18 h2 M12 6 v12 M4 6 v12 M17 12 a2 2 0 1 1 4 0 c0 0.591 -0.417 1.318 -0.816 1.858 l-3.184 4.143 l4 0 M0 0 h24 v24 H0 z";
				case IconKind.H3:
					return "M11 6 h2 M3 6 h2 M4 12 h8 M3 18 h2 M11 18 h2 M12 6 v12 M4 6 v12 M17 16 a2 2 0 1 0 2 -2 M19 14 a2 2 0 1 0 -2 -2 M0 0 h24 v24 H0 z";
				case IconKind.H4:
					return "M11 6 h2 M3 6 h2 M4 12 h8 M3 18 h2 M11 18 h2 M12 6 v12 M4 6 v12 M20 18 v-8 l-4 6 h5 M0 0 h24 v24 H0 z";
				case IconKind.H5:
					return "M11 6 h2 M3 6 h2 M4 12 h8 M3 18 h2 M11 18 h2 M12 6 v12 M4 6 v12 M17 18 h2 a2 2 0 1 0 0 -4 h-2 v-4 h4 M0 0 h24 v24 H0 z";
				case IconKind.H6:
					return "M11 6 h2 M3 6 h2 M4 12 h8 M3 18 h2 M11 18 h2 M12 6 v12 M4 6 v12 M21 12 a2 2 0 1 0 -4 0 v4 M19 14 a2 2 0 1 0 0 4 a2 2 0 0 0 0 -4 z M0 0 h24 v24 H0 z";
				case IconKind.HammerOff:
					return "M3 3 l18 18 M18.713 14.702 l2 -2 a1 1 0 0 0 0 -1.414 l-7.586 -7.586 a1 1 0 0 0 -1.414 0 l-2 2 M10.698 10.72 l-6.668 6.698 a2.091 2.091 0 0 0 0 2.967 a2.11 2.11 0 0 0 2.976 0 l6.696 -6.676 M0 0 h24 v24 H0 z";
				case IconKind.Hammer:
					return "M18.121 15.293 l2.586 -2.586 a1 1 0 0 0 0 -1.414 l-7.586 -7.586 a1 1 0 0 0 -1.414 0 l-2.586 2.586 a1 1 0 0 0 0 1.414 l7.586 7.586 a1 1 0 0 0 1.414 0 z M11.414 10 l-7.383 7.418 a2.091 2.091 0 0 0 0 2.967 a2.11 2.11 0 0 0 2.976 0 l7.407 -7.385 M0 0 h24 v24 H0 z";
				case IconKind.HandClick:
					return "M15 6 h1 M14 3 l1 -1 M4 7 h-1 M5 3 l-1 -1 M17 11.5 a1.5 1.5 0 0 1 3 0 v4.5 a6 6 0 0 1 -6 6 h-2 h0.208 a6 6 0 0 1 -5.012 -2.7 l-0.196 -0.3 c-0.312 -0.479 -1.407 -2.388 -3.286 -5.728 a1.5 1.5 0 0 1 0.536 -2.022 a1.867 1.867 0 0 1 2.28 0.28 l1.47 1.47 M14 10.5 a1.5 1.5 0 0 1 3 0 v1.5 M11 11.5 v-2 a1.5 1.5 0 0 1 3 0 v2.5 M8 13 v-8.5 a1.5 1.5 0 0 1 3 0 v7.5 M0 0 h24 v24 H0 z";
				case IconKind.HandFingerOff:
					return "M3 3 l18 18 M17 11.5 a1.5 1.5 0 0 1 3 0 v4.5 m-0.88 3.129 a6 6 0 0 1 -5.12 2.871 h-2 h0.208 a6 6 0 0 1 -5.012 -2.7 l-0.196 -0.3 c-0.312 -0.479 -1.407 -2.388 -3.286 -5.728 a1.5 1.5 0 0 1 0.536 -2.022 a1.867 1.867 0 0 1 2.28 0.28 l1.47 1.47 M14.06 10.082 a1.5 1.5 0 0 1 2.94 0.418 v1.5 M12.063 8.065 a1.5 1.5 0 0 1 1.937 1.435 v0.5 M8.06 4.077 a1.5 1.5 0 0 1 2.94 0.423 v2.5 m0 4 v1 M8 13 v-5 M0 0 h24 v24 H0 z";
				case IconKind.HandFinger:
					return "M17 11.5 a1.5 1.5 0 0 1 3 0 v4.5 a6 6 0 0 1 -6 6 h-2 h0.208 a6 6 0 0 1 -5.012 -2.7 a69.74 69.74 0 0 1 -0.196 -0.3 c-0.312 -0.479 -1.407 -2.388 -3.286 -5.728 a1.5 1.5 0 0 1 0.536 -2.022 a1.867 1.867 0 0 1 2.28 0.28 l1.47 1.47 M14 10.5 a1.5 1.5 0 0 1 3 0 v1.5 M11 11.5 v-2 a1.5 1.5 0 1 1 3 0 v2.5 M8 13 v-8.5 a1.5 1.5 0 0 1 3 0 v7.5 M0 0 h24 v24 H0 z";
				case IconKind.HandGrab:
					return "M17 9.5 a1.5 1.5 0 0 1 3 0 v4.5 a6 6 0 0 1 -6 6 h-2 h0.208 a6 6 0 0 1 -5.012 -2.7 l-0.196 -0.3 c-0.312 -0.479 -1.407 -2.388 -3.286 -5.728 a1.5 1.5 0 0 1 0.536 -2.022 a1.867 1.867 0 0 1 2.28 0.28 l1.47 1.47 M14 7.5 a1.5 1.5 0 0 1 3 0 v2.5 M11 9.5 v-3 a1.5 1.5 0 0 1 3 0 v3.5 M8 11 v-3.5 a1.5 1.5 0 0 1 3 0 v2.5 M0 0 h24 v24 H0 z";
				case IconKind.HandLittleFinger:
					return "M14 10.5 a1.5 1.5 0 0 1 3 0 v1.5 M17 12 v-5.5 a1.5 1.5 0 0 1 3 0 v9.5 a6 6 0 0 1 -6 6 h-2 h0.208 a6 6 0 0 1 -5.012 -2.7 a69.74 69.74 0 0 1 -0.196 -0.3 c-0.312 -0.479 -1.407 -2.388 -3.286 -5.728 a1.5 1.5 0 0 1 0.536 -2.022 a1.867 1.867 0 0 1 2.28 0.28 l1.47 1.47 M11 11.5 v-1 a1.5 1.5 0 0 1 3 0 v1.5 M8 13 v-2.5 a1.5 1.5 0 0 1 3 0 v1.5 M0 0 h24 v24 H0 z";
				case IconKind.HandMiddleFinger:
					return "M11 11.5 v-8 a1.5 1.5 0 1 1 3 0 v8.5 M17 11.5 a1.5 1.5 0 0 1 3 0 v4.5 a6 6 0 0 1 -6 6 h-2 h0.208 a6 6 0 0 1 -5.012 -2.7 a69.74 69.74 0 0 1 -0.196 -0.3 c-0.312 -0.479 -1.407 -2.388 -3.286 -5.728 a1.5 1.5 0 0 1 0.536 -2.022 a1.867 1.867 0 0 1 2.28 0.28 l1.47 1.47 M14 10.5 a1.5 1.5 0 0 1 3 0 v1.5 M8 13 v-2.5 a1.5 1.5 0 0 1 3 0 v1.5 M0 0 h24 v24 H0 z";
				case IconKind.HandMove:
					return "M14 3.458 c1.32 0.354 2.558 0.902 3.685 1.612 M2.541 5.594 a13.487 13.487 0 0 1 2.46 -1.427 M17 11.5 a1.5 1.5 0 0 1 3 0 v4.5 a6 6 0 0 1 -6 6 h-2 h0.208 a6 6 0 0 1 -5.012 -2.7 l-0.196 -0.3 c-0.312 -0.479 -1.407 -2.388 -3.286 -5.728 a1.5 1.5 0 0 1 0.536 -2.022 a1.867 1.867 0 0 1 2.28 0.28 l1.47 1.47 M14 10.5 a1.5 1.5 0 0 1 3 0 v1.5 M11 11.5 v-2 a1.5 1.5 0 0 1 3 0 v2.5 M8 13 v-8.5 a1.5 1.5 0 0 1 3 0 v7.5 M0 0 h24 v24 H0 z";
				case IconKind.HandOff:
					return "M8 13.5 v-5.5 m0.44 -3.562 a1.5 1.5 0 0 1 2.56 1.062 v1.5 m0 4.008 v0.992 m0 -6.5 v-2 a1.5 1.5 0 1 1 3 0 v6.5 m0 -4.5 a1.5 1.5 0 0 1 3 0 v6.5 m0 -4.5 a1.5 1.5 0 0 1 3 0 v8.5 a6 6 0 0 1 -6 6 h-2 c-2.114 -0.292 -3.956 -1.397 -5 -3 l-2.7 -5.25 a1.7 1.7 0 0 1 2.75 -2 l0.9 1.75 M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.HandRingFinger:
					return "M14 12 v-6.5 a1.5 1.5 0 0 1 3 0 v6.5 M11 11.5 v-2 a1.5 1.5 0 1 1 3 0 v2.5 M17 11.5 a1.5 1.5 0 0 1 3 0 v4.5 a6 6 0 0 1 -6 6 h-2 h0.208 a6 6 0 0 1 -5.012 -2.7 a69.74 69.74 0 0 1 -0.196 -0.3 c-0.312 -0.479 -1.407 -2.388 -3.286 -5.728 a1.5 1.5 0 0 1 0.536 -2.022 a1.867 1.867 0 0 1 2.28 0.28 l1.47 1.47 M8 13 v-2.5 a1.5 1.5 0 0 1 3 0 v1.5 M0 0 h24 v24 H0 z";
				case IconKind.HandRock:
					return "M8 13 v-8.5 a1.5 1.5 0 0 1 3 0 v7.5 M14 10.5 a1.5 1.5 0 0 1 3 0 v1.5 M17 12 v-6.5 a1.5 1.5 0 0 1 3 0 v10.5 a6 6 0 0 1 -6 6 h-2 h0.208 a6 6 0 0 1 -5.012 -2.7 a69.74 69.74 0 0 1 -0.196 -0.3 c-0.312 -0.479 -1.407 -2.388 -3.286 -5.728 a1.5 1.5 0 0 1 0.536 -2.022 a1.867 1.867 0 0 1 2.28 0.28 l1.47 1.47 M11 11.5 v-1 a1.5 1.5 0 0 1 3 0 v1.5 M0 0 h24 v24 H0 z";
				case IconKind.HandSanitizer:
					return "M10 13 h4 M12 11 v4 M12 3 v5 M15 3 h-6 a2 2 0 0 0 -2 2 M7 21 h10 v-10 a3 3 0 0 0 -3 -3 h-4 a3 3 0 0 0 -3 3 v10 z M0 0 h24 v24 H0 z";
				case IconKind.HandStop:
					return "M17 7.5 a1.5 1.5 0 0 1 3 0 v8.5 a6 6 0 0 1 -6 6 h-2 h0.208 a6 6 0 0 1 -5.012 -2.7 a69.74 69.74 0 0 1 -0.196 -0.3 c-0.312 -0.479 -1.407 -2.388 -3.286 -5.728 a1.5 1.5 0 0 1 0.536 -2.022 a1.867 1.867 0 0 1 2.28 0.28 l1.47 1.47 M14 5.5 a1.5 1.5 0 0 1 3 0 v6.5 M11 5.5 v-2 a1.5 1.5 0 1 1 3 0 v8.5 M8 13 v-7.5 a1.5 1.5 0 0 1 3 0 v6.5 M0 0 h24 v24 H0 z";
				case IconKind.HandThreeFingers:
					return "M14 5.5 a1.5 1.5 0 0 1 3 0 v6.5 M11 5.5 v-2 a1.5 1.5 0 1 1 3 0 v8.5 M17 11.5 a1.5 1.5 0 0 1 3 0 v4.5 a6 6 0 0 1 -6 6 h-2 h0.208 a6 6 0 0 1 -5.012 -2.7 a69.74 69.74 0 0 1 -0.196 -0.3 c-0.312 -0.479 -1.407 -2.388 -3.286 -5.728 a1.5 1.5 0 0 1 0.536 -2.022 a1.867 1.867 0 0 1 2.28 0.28 l1.47 1.47 M8 13 v-8.5 a1.5 1.5 0 0 1 3 0 v7.5 M0 0 h24 v24 H0 z";
				case IconKind.HandTwoFingers:
					return "M11 5.5 v-2 a1.5 1.5 0 1 1 3 0 v8.5 M14 10.5 a1.5 1.5 0 0 1 3 0 v1.5 M17 11.5 a1.5 1.5 0 0 1 3 0 v4.5 a6 6 0 0 1 -6 6 h-2 h0.208 a6 6 0 0 1 -5.012 -2.7 a69.74 69.74 0 0 1 -0.196 -0.3 c-0.312 -0.479 -1.407 -2.388 -3.286 -5.728 a1.5 1.5 0 0 1 0.536 -2.022 a1.867 1.867 0 0 1 2.28 0.28 l1.47 1.47 M8 13 v-8.5 a1.5 1.5 0 0 1 3 0 v7.5 M0 0 h24 v24 H0 z";
				case IconKind.Hanger2:
					return "M6 16 m0 2 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v1 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 z M18 18 h1 a2 2 0 0 0 2 -2 v-0.823 a2 2 0 0 0 -1.029 -1.749 l-7.971 -4.428 c-1.457 -0.81 -1.993 -2.333 -2 -4 a2 2 0 1 1 4 0 M12 9 l-7.971 4.428 a2 2 0 0 0 -1.029 1.749 v0.823 a2 2 0 0 0 2 2 h1 M0 0 h24 v24 H0 z";
				case IconKind.HangerOff:
					return "M3 3 l18 18 M14 6 a2 2 0 1 0 -4 0 m6.506 6.506 l3.461 1.922 a2 2 0 0 1 1.029 1.749 v0.823 m-2 2 h-14 a2 2 0 0 1 -2 -2 v-0.823 a2 2 0 0 1 1.029 -1.749 l6.673 -3.707 M0 0 h24 v24 H0 z";
				case IconKind.Hanger:
					return "M14 6 a2 2 0 1 0 -4 0 c0 1.667 0.67 3 2 4 h-0.008 l7.971 4.428 a2 2 0 0 1 1.029 1.749 v0.823 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 v-0.823 a2 2 0 0 1 1.029 -1.749 l7.971 -4.428 M0 0 h24 v24 H0 z";
				case IconKind.Hash:
					return "M17 4 l-4 16 M11 4 l-4 16 M5 15 l14 0 M5 9 l14 0 M0 0 h24 v24 H0 z";
				case IconKind.Haze:
					return "M3 20 h18 M3 16 h18 M8 12 a4 4 0 1 1 8 0 M18.4 5.6 l-0.7 0.7 M5.6 5.6 l0.7 0.7 M20 12 h1 M12 3 v1 M3 12 h1 M0 0 h24 v24 H0 z";
				case IconKind.HeadingOff:
					return "M3 3 l18 18 M5 19 h4 M15 5 h4 M15 19 h4 M17 5 v8 m0 4 v2 M7 7 v12 M7 12 h5 m4 0 h1 M0 0 h24 v24 H0 z";
				case IconKind.Heading:
					return "M5 5 h4 M5 19 h4 M15 5 h4 M15 19 h4 M17 5 v14 M7 5 v14 M7 12 h10 M0 0 h24 v24 H0 z";
				case IconKind.HeadphonesOff:
					return "M4 15 v-3 c0 -2.21 0.896 -4.21 2.344 -5.658 m2.369 -1.638 a8 8 0 0 1 11.287 7.296 v3 M17 13 h1 a2 2 0 0 1 2 2 v1 m-0.589 3.417 c-0.361 0.36 -0.86 0.583 -1.411 0.583 h-1 a2 2 0 0 1 -2 -2 v-3 M4 13 m0 2 a2 2 0 0 1 2 -2 h1 a2 2 0 0 1 2 2 v3 a2 2 0 0 1 -2 2 h-1 a2 2 0 0 1 -2 -2 z M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.Headphones:
					return "M4 15 v-3 a8 8 0 0 1 16 0 v3 M15 13 m0 2 a2 2 0 0 1 2 -2 h1 a2 2 0 0 1 2 2 v3 a2 2 0 0 1 -2 2 h-1 a2 2 0 0 1 -2 -2 z M4 13 m0 2 a2 2 0 0 1 2 -2 h1 a2 2 0 0 1 2 2 v3 a2 2 0 0 1 -2 2 h-1 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.HeadsetOff:
					return "M3 3 l18 18 M16.169 12.18 c0.253 -0.115 0.534 -0.18 0.831 -0.18 h1 a2 2 0 0 1 2 2 v2 m-1.183 2.826 c-0.25 0.112 -0.526 0.174 -0.817 0.174 h-1 a2 2 0 0 1 -2 -2 v-2 M4 14 a2 2 0 0 1 2 -2 h1 a2 2 0 0 1 2 2 v3 a2 2 0 0 1 -2 2 h-1 a2 2 0 0 1 -2 -2 v-3 z M18 19 c0 1.657 -2.686 3 -6 3 M4 14 v-3 c0 -1.953 0.7 -3.742 1.862 -5.13 m2.182 -1.825 a8 8 0 0 1 11.956 6.955 v3 M0 0 h24 v24 H0 z";
				case IconKind.Headset:
					return "M15 14 a2 2 0 0 1 2 -2 h1 a2 2 0 0 1 2 2 v3 a2 2 0 0 1 -2 2 h-1 a2 2 0 0 1 -2 -2 v-3 z M4 14 a2 2 0 0 1 2 -2 h1 a2 2 0 0 1 2 2 v3 a2 2 0 0 1 -2 2 h-1 a2 2 0 0 1 -2 -2 v-3 z M18 19 c0 1.657 -2.686 3 -6 3 M4 14 v-3 a8 8 0 1 1 16 0 v3 M0 0 h24 v24 H0 z";
				case IconKind.HealthRecognition:
					return "M8.603 9.61 a2.04 2.04 0 0 1 2.912 0 l0.485 0.39 l0.5 -0.396 a2.035 2.035 0 0 1 2.897 0.007 a2.104 2.104 0 0 1 0 2.949 l-3.397 3.44 l-3.397 -3.44 a2.104 2.104 0 0 1 0 -2.95 z M16 20 h2 a2 2 0 0 0 2 -2 v-2 M16 4 h2 a2 2 0 0 1 2 2 v2 M4 16 v2 a2 2 0 0 0 2 2 h2 M4 8 v-2 a2 2 0 0 1 2 -2 h2 M0 0 h24 v24 H0 z";
				case IconKind.HeartBroken:
					return "M12 6 l-2 4 l4 3 l-2 4 v3 M19.5 12.572 l-7.5 7.428 l-7.5 -7.428 a5 5 0 1 1 7.5 -6.566 a5 5 0 1 1 7.5 6.572 M0 0 h24 v24 H0 z";
				case IconKind.HeartFilled:
					return "M19.5 12.572 l-7.5 7.428 l-7.5 -7.428 a5 5 0 1 1 7.5 -6.566 a5 5 0 1 1 7.5 6.572 M0 0 h24 v24 H0 z";
				case IconKind.HeartHandshake:
					return "M15 13 l2 2 M12.5 15.5 l2 2 M12 6 l-3.293 3.293 a1 1 0 0 0 0 1.414 l0.543 0.543 c0.69 0.69 1.81 0.69 2.5 0 l1 -1 a3.182 3.182 0 0 1 4.5 0 l2.25 2.25 M19.5 12.572 l-7.5 7.428 l-7.5 -7.428 a5 5 0 1 1 7.5 -6.566 a5 5 0 1 1 7.5 6.572 M0 0 h24 v24 H0 z";
				case IconKind.HeartMinus:
					return "M14 16 h6 M13 19 l-1 1 l-7.5 -7.428 a5 5 0 1 1 7.5 -6.566 a5 5 0 0 1 8 6 M0 0 h24 v24 H0 z";
				case IconKind.HeartOff:
					return "M19.5 12.572 l-1.5 1.428 m-2 2 l-4 4 l-7.5 -7.428 a5 5 0 0 1 -1.288 -5.068 a4.976 4.976 0 0 1 1.788 -2.504 m3 -1 c1.56 0 3.05 0.727 4 2 a5 5 0 1 1 7.5 6.572 M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.HeartPlus:
					return "M17 13 v6 M14 16 h6 M13 19 l-1 1 l-7.5 -7.428 a5 5 0 1 1 7.5 -6.566 a5 5 0 0 1 8 6 M0 0 h24 v24 H0 z";
				case IconKind.HeartRateMonitor:
					return "M7 10 h2 l2 3 l2 -6 l1 3 h3 M15 16 v4 M9 16 v4 M7 20 h10 M3 4 m0 1 a1 1 0 0 1 1 -1 h16 a1 1 0 0 1 1 1 v10 a1 1 0 0 1 -1 1 h-16 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.Heart:
					return "M19.5 12.572 l-7.5 7.428 l-7.5 -7.428 a5 5 0 1 1 7.5 -6.566 a5 5 0 1 1 7.5 6.572 M0 0 h24 v24 H0 z";
				case IconKind.Heartbeat:
					return "M3 13 h2 l2 3 l2 -6 l1 3 h3 M19.5 13.572 l-7.5 7.428 l-2.896 -2.868 m-6.117 -8.104 a5 5 0 0 1 9.013 -3.022 a5 5 0 1 1 7.5 6.572 M0 0 h24 v24 H0 z";
				case IconKind.HeartsOff:
					return "M3 3 l18 18 M11.814 11.814 a2.81 2.81 0 0 0 -0.007 3.948 l4.182 4.238 l2.01 -2.021 m1.977 -1.99 l0.211 -0.212 a2.81 2.81 0 0 0 0 -3.948 a2.747 2.747 0 0 0 -3.91 -0.007 l-0.283 0.178 M14.017 18 l-2.017 2 l-7.5 -7.428 a5 5 0 0 1 0.49 -7.586 m3.01 -1 a5 5 0 0 1 4 2.018 a5 5 0 0 1 8.153 5.784 M0 0 h24 v24 H0 z";
				case IconKind.Hearts:
					return "M15.99 20 l4.197 -4.223 a2.81 2.81 0 0 0 0 -3.948 a2.747 2.747 0 0 0 -3.91 -0.007 l-0.28 0.282 l-0.279 -0.283 a2.747 2.747 0 0 0 -3.91 -0.007 a2.81 2.81 0 0 0 -0.007 3.948 l4.182 4.238 z M14.017 18 l-2.017 2 l-7.5 -7.428 a5 5 0 1 1 7.5 -6.566 a5 5 0 0 1 8.153 5.784 M0 0 h24 v24 H0 z";
				case IconKind.HelicopterLanding:
					return "M15 8 l0 8 M9 12 l6 0 M9 8 l0 8 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Helicopter:
					return "M19 19 l-8 0 M15 19 l0 -3 M15 9.1 v3.9 h5.5 M5 6 l15 0 M13 9 l0 -3 M12 9 a2 2 0 0 0 -2 2 v3 c0 1.1 0.9 2 2 2 h7 a2 2 0 0 0 2 -2 c0 -3.31 -3.13 -5 -7 -5 h-2 z M3 10 l1 2 h6 M0 0 h24 v24 H0 z";
				case IconKind.HelmetOff:
					return "M3 3 l18 18 M20 9 h-7 m-2.768 1.246 c0.507 2 1.596 3.418 3.268 4.254 c0.524 0.262 1.07 0.49 1.64 0.683 M8.633 4.654 a9 9 0 0 1 11.718 11.7 m-1.503 2.486 a9.008 9.008 0 0 1 -1.192 1.16 h-11.312 a9 9 0 0 1 -0.185 -13.847 M0 0 h24 v24 H0 z";
				case IconKind.Helmet:
					return "M20 9 h-8.8 a1 1 0 0 0 -0.968 1.246 c0.507 2 1.596 3.418 3.268 4.254 c2 1 4.333 1.5 7 1.5 M12 4 a9 9 0 0 1 5.656 16 h-11.312 a9 9 0 0 1 5.656 -16 z M0 0 h24 v24 H0 z";
				case IconKind.HelpOff:
					return "M3 3 l18 18 M12 13.5 a1.5 1.5 0 0 1 0.394 -1.1 m2.106 -1.9 a2.6 2.6 0 0 0 -3.347 -3.361 M12 17 v0.01 M5.641 5.631 a9 9 0 1 0 12.719 12.738 m1.68 -2.318 a9 9 0 0 0 -12.074 -12.098 M0 0 h24 v24 H0 z";
				case IconKind.Help:
					return "M12 13.5 a1.5 1.5 0 0 1 1 -1.5 a2.6 2.6 0 1 0 -3 -4 M12 17 l0 0.01 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.Hexagon3d:
					return "M12 16.5 l4 -2.5 v-4 l-4 -2.5 l-4 2.5 v4 z M12 12 l4 2 M12 7.5 v4.5 l-4 2 M16 10 l4 -2.5 M4.5 7.5 l3.5 2.5 M12 16.5 v4.5 M19 6.844 a2.007 2.007 0 0 1 1 1.752 v6.555 c0 0.728 -0.394 1.399 -1.03 1.753 l-6 3.844 a2 2 0 0 1 -1.942 0 l-6 -3.844 a2.007 2.007 0 0 1 -1.029 -1.752 v-6.556 c0 -0.729 0.394 -1.4 1.029 -1.753 l6 -3.583 a2.05 2.05 0 0 1 2 0 l6 3.584 h-0.03 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonFilled:
					return "M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonLetterA:
					return "M10 13 h4 M10 16 v-6 a2 2 0 1 1 4 0 v6 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonLetterB:
					return "M10 16 h2 a2 2 0 1 0 0 -4 h-2 h2 a2 2 0 1 0 0 -4 h-2 v8 z M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonLetterC:
					return "M14 10 a2 2 0 1 0 -4 0 v4 a2 2 0 1 0 4 0 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonLetterD:
					return "M10 8 v8 h2 a2 2 0 0 0 2 -2 v-4 a2 2 0 0 0 -2 -2 h-2 z M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonLetterE:
					return "M10 12 h2.5 M14 8 h-4 v8 h4 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonLetterF:
					return "M14 8 h-4 v8 M10 12 h3 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonLetterG:
					return "M14 8 h-2 a2 2 0 0 0 -2 2 v4 a2 2 0 0 0 2 2 h2 v-4 h-1 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonLetterH:
					return "M10 12 h4 M10 16 v-8 m4 0 v8 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonLetterI:
					return "M12 8 v8 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonLetterJ:
					return "M10 8 h4 v6 a2 2 0 1 1 -4 0 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonLetterK:
					return "M10 12 h1.5 M14 8 l-2.5 4 l2.5 4 M10 8 v8 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonLetterL:
					return "M10 8 v8 h4 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonLetterM:
					return "M9 16 v-8 l3 5 l3 -5 v8 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonLetterN:
					return "M10 16 v-8 l4 8 v-8 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonLetterO:
					return "M12 8 a2 2 0 0 1 2 2 v4 a2 2 0 1 1 -4 0 v-4 a2 2 0 0 1 2 -2 z M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonLetterP:
					return "M10 12 h2 a2 2 0 1 0 0 -4 h-2 v8 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonLetterQ:
					return "M13 15 l1 1 M12 8 a2 2 0 0 1 2 2 v4 a2 2 0 1 1 -4 0 v-4 a2 2 0 0 1 2 -2 z M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonLetterR:
					return "M10 12 h2 a2 2 0 1 0 0 -4 h-2 v8 m4 0 l-3 -4 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonLetterS:
					return "M10 15 a1 1 0 0 0 1 1 h2 a1 1 0 0 0 1 -1 v-2 a1 1 0 0 0 -1 -1 h-2 a1 1 0 0 1 -1 -1 v-2 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonLetterT:
					return "M12 8 v8 M10 8 h4 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonLetterU:
					return "M10 8 v6 a2 2 0 1 0 4 0 v-6 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonLetterV:
					return "M10 8 l2 8 l2 -8 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonLetterW:
					return "M9 8 l1 8 l2 -5 l2 5 l1 -8 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonLetterX:
					return "M10 16 l4 -8 M10 8 l4 8 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonLetterY:
					return "M12 16 v-3 M10 8 l2 5 l2 -5 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonLetterZ:
					return "M10 8 h4 l-4 8 h4 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonNumber0:
					return "M10 10 v4 a2 2 0 1 0 4 0 v-4 a2 2 0 1 0 -4 0 z M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonNumber1:
					return "M10 10 l2 -2 v8 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonNumber2:
					return "M10 8 h3 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 0 -1 1 v2 a1 1 0 0 0 1 1 h3 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonNumber3:
					return "M10 9 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonNumber4:
					return "M14 8 v8 M10 8 v3 a1 1 0 0 0 1 1 h3 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonNumber5:
					return "M10 15 a1 1 0 0 0 1 1 h2 a1 1 0 0 0 1 -1 v-2 a1 1 0 0 0 -1 -1 h-3 v-4 h4 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonNumber6:
					return "M14 9 a1 1 0 0 0 -1 -1 h-2 a1 1 0 0 0 -1 1 v6 a1 1 0 0 0 1 1 h2 a1 1 0 0 0 1 -1 v-2 a1 1 0 0 0 -1 -1 h-3 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonNumber7:
					return "M10 8 h4 l-2 8 M19.02 6.858 a2 2 0 0 1 1 1.752 v6.555 c0 0.728 -0.395 1.4 -1.032 1.753 l-6.017 3.844 a2 2 0 0 1 -1.948 0 l-6.016 -3.844 a2 2 0 0 1 -1.032 -1.752 v-6.556 c0 -0.728 0.395 -1.4 1.032 -1.753 l6.017 -3.582 a2.062 2.062 0 0 1 2 0 l6.017 3.583 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonNumber8:
					return "M12 12 h-1 a1 1 0 0 1 -1 -1 v-2 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 0 -1 1 v2 a1 1 0 0 0 1 1 h2 a1 1 0 0 0 1 -1 v-2 a1 1 0 0 0 -1 -1 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonNumber9:
					return "M10 15 a1 1 0 0 0 1 1 h2 a1 1 0 0 0 1 -1 v-6 a1 1 0 0 0 -1 -1 h-2 a1 1 0 0 0 -1 1 v2 a1 1 0 0 0 1 1 h3 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonOff:
					return "M3 3 l18 18 M8.693 4.69 l2.336 -1.39 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 a2 2 0 0 1 1 1.747 v6.536 c0 0.246 -0.045 0.485 -0.13 0.707 m-2.16 1.847 l-4.739 3.027 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l1.154 -0.687 M0 0 h24 v24 H0 z";
				case IconKind.Hexagon:
					return "M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 z M0 0 h24 v24 H0 z";
				case IconKind.HexagonsOff:
					return "M3 3 l18 18 M15.345 11.328 l0.655 -0.328 l4 2 v3 m-1.334 2.667 l-2.666 1.333 l-4 -2 M12 13 l0.661 -0.331 M8 11 v-3 m1.332 -2.666 l2.668 -1.334 l4 2 v5 M4 18 v-5 l4 -2 l4 2 v5 l-4 2 z M0 0 h24 v24 H0 z";
				case IconKind.Hexagons:
					return "M12 13 l4 -2 l4 2 v5 l-4 2 l-4 -2 M8 11 v-5 l4 -2 l4 2 v5 M4 18 v-5 l4 -2 l4 2 v5 l-4 2 z M0 0 h24 v24 H0 z";
				case IconKind.Hierarchy2:
					return "M12 7 l0 6 M7 17 l5 -4 l5 4 M17 17 h4 v4 h-4 z M3 17 h4 v4 h-4 z M10 3 h4 v4 h-4 z M0 0 h24 v24 H0 z";
				case IconKind.Hierarchy3:
					return "M9 14 l2 3 M15 14 l-2 3 M17 14 l2 3 M13 7 l2 3 M9 10 l2 -3 M5 17 l2 -3 M16 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M4 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M20 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M12 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M8 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M12 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.HierarchyOff:
					return "M3 3 l18 18 M12 7 v1 m0 4 v1 M6.5 17.5 l5.5 -4.5 l5.5 4.5 M17.585 17.587 a2 2 0 0 0 2.813 2.843 M5 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M12 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Hierarchy:
					return "M12 7 l0 6 M6.5 17.5 l5.5 -4.5 l5.5 4.5 M19 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M12 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.HighlightOff:
					return "M3 3 l18 18 M19 15 h2 v2 m-2 2 h-6 l3 -3 M4.5 13.5 l4 4 M12.5 5.5 l4 4 M9 9 l-6 6 v4 h4 l6 -6 m2 -2 l2.503 -2.503 a2.828 2.828 0 1 0 -4 -4 l-2.497 2.497 M0 0 h24 v24 H0 z";
				case IconKind.Highlight:
					return "M21 15 v4 h-8 l4 -4 z M4.5 13.5 l4 4 M12.5 5.5 l4 4 M3 19 h4 l10.5 -10.5 a2.828 2.828 0 1 0 -4 -4 l-10.5 10.5 v4 M0 0 h24 v24 H0 z";
				case IconKind.HistoryOff:
					return "M3 3 l18 18 M3.05 11 a8.975 8.975 0 0 1 2.54 -5.403 m2.314 -1.697 a9 9 0 0 1 12.113 12.112 m-1.695 2.312 a9 9 0 0 1 -14.772 -3.324 m-0.5 5 v-5 h5 M0 0 h24 v24 H0 z";
				case IconKind.HistoryToggle:
					return "M15.44 3.69 a9 9 0 0 0 -3.44 -0.69 M20.31 8.56 a9 9 0 0 0 -1.95 -2.92 M20.31 15.44 a9 9 0 0 0 0.69 -3.44 M15.44 20.31 a9 9 0 0 0 2.92 -1.95 M8.56 20.31 a9 9 0 0 0 3.44 0.69 M3.69 15.44 a9 9 0 0 0 1.95 2.92 M3.69 8.56 a9 9 0 0 0 -0.69 3.44 M8.56 3.69 a9 9 0 0 0 -2.92 1.95 M12 8 v4 l3 3 M0 0 h24 v24 H0 z";
				case IconKind.History:
					return "M3.05 11 a9 9 0 1 1 0.5 4 m-0.5 5 v-5 h5 M12 8 l0 4 l2 2 M0 0 h24 v24 H0 z";
				case IconKind.Home2:
					return "M10 12 h4 v4 h-4 z M5 12 v7 a2 2 0 0 0 2 2 h10 a2 2 0 0 0 2 -2 v-7 M5 12 l-2 0 l9 -9 l9 9 l-2 0 M0 0 h24 v24 H0 z";
				case IconKind.HomeBolt:
					return "M19 14 l-2 4 h4 l-2 4 M9 21 v-6 a2 2 0 0 1 2 -2 h2 c0.661 0 1.248 0.32 1.612 0.815 M19 10 l-7 -7 l-9 9 h2 v7 a2 2 0 0 0 2 2 h7.5 M0 0 h24 v24 H0 z";
				case IconKind.HomeCancel:
					return "M9 21 v-6 a2 2 0 0 1 2 -2 h2 c0.58 0 1.103 0.247 1.468 0.642 M19 12 h2 l-9 -9 l-9 9 h2 v7 a2 2 0 0 0 2 2 h5.5 M17 21 l4 -4 M19 19 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.HomeCheck:
					return "M15 19 l2 2 l4 -4 M19 13.488 v-1.488 h2 l-9 -9 l-9 9 h2 v7 a2 2 0 0 0 2 2 h4.525 M9 21 v-6 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 M0 0 h24 v24 H0 z";
				case IconKind.HomeCog:
					return "M19.733 19 l1.3 0.75 M14.97 16.25 l1.3 0.75 M16.27 19 l-1.3 0.75 M21.032 16.25 l-1.299 0.75 M18 20 v1.5 M18 14.5 v1.5 M18 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M20 11 l-8 -8 l-9 9 h2 v7 a2 2 0 0 0 2 2 h4.159 M9 21 v-6 a2 2 0 0 1 2 -2 h1.6 M0 0 h24 v24 H0 z";
				case IconKind.HomeDollar:
					return "M19 21 v1 m0 -8 v1 M21 15 h-2.5 a1.5 1.5 0 0 0 0 3 h1 a1.5 1.5 0 0 1 0 3 h-2.5 M9 21 v-6 a2 2 0 0 1 2 -2 h2 c0.387 0 0.748 0.11 1.054 0.3 M19 10 l-7 -7 l-9 9 h2 v7 a2 2 0 0 0 2 2 h6 M0 0 h24 v24 H0 z";
				case IconKind.HomeDot:
					return "M9 21 v-6 a2 2 0 0 1 2 -2 h2 c0.641 0 1.212 0.302 1.578 0.771 M19 19 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M19 12 h2 l-9 -9 l-9 9 h2 v7 a2 2 0 0 0 2 2 h5 M0 0 h24 v24 H0 z";
				case IconKind.HomeDown:
					return "M22 19 l-3 3 l-3 -3 M19 16 v6 M9 21 v-6 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 M19 12 h2 l-9 -9 l-9 9 h2 v7 a2 2 0 0 0 2 2 h5.5 M0 0 h24 v24 H0 z";
				case IconKind.HomeEco:
					return "M19 21 a3 3 0 0 1 0 -6 h3 v3 a3 3 0 0 1 -3 3 z M16 22 s0 -2 3 -4 M9 21 v-6 a2 2 0 0 1 2 -2 h2 c0.325 0 0.631 0.077 0.902 0.215 M20 11 l-8 -8 l-9 9 h2 v7 a2 2 0 0 0 2 2 h5 M0 0 h24 v24 H0 z";
				case IconKind.HomeEdit:
					return "M18.42 15.61 a2.1 2.1 0 0 1 2.97 2.97 l-3.39 3.42 h-3 v-3 l3.42 -3.39 z M20 11 l-8 -8 l-9 9 h2 v7 a2 2 0 0 0 2 2 h4 M9 21 v-6 a2 2 0 0 1 2 -2 h2 c0.645 0 1.218 0.305 1.584 0.78 M0 0 h24 v24 H0 z";
				case IconKind.HomeExclamation:
					return "M19 22 v0.01 M19 16 v3 M9 21 v-6 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 1.857 1.257 M21 12 l-9 -9 l-9 9 h2 v7 a2 2 0 0 0 2 2 h8 M0 0 h24 v24 H0 z";
				case IconKind.HomeHand:
					return "M16 17.5 l-0.585 -0.578 a1.516 1.516 0 0 0 -2 0 c-0.477 0.433 -0.551 1.112 -0.177 1.622 l1.762 2.456 c0.37 0.506 1.331 1 2 1 h3 c1.009 0 1.497 -0.683 1.622 -1.593 c0.252 -0.938 0.378 -1.74 0.378 -2.407 c0 -1 -0.939 -1.843 -2 -2 h-1 v-2.636 c0 -0.754 -0.672 -1.364 -1.5 -1.364 s-1.5 0.61 -1.5 1.364 v4.136 z M9 21 v-6 a2 2 0 0 1 2 -2 h2 M18 9 l-6 -6 l-9 9 h2 v7 a2 2 0 0 0 2 2 h3.5 M0 0 h24 v24 H0 z";
				case IconKind.HomeHeart:
					return "M19 21.5 l2.518 -2.58 a1.74 1.74 0 0 0 0 -2.413 a1.627 1.627 0 0 0 -2.346 0 l-0.168 0.172 l-0.168 -0.172 a1.627 1.627 0 0 0 -2.346 0 a1.74 1.74 0 0 0 0 2.412 l2.51 2.59 z M9 21 v-6 a2 2 0 0 1 2 -2 h2 c0.39 0 0.754 0.112 1.061 0.304 M21 12 l-9 -9 l-9 9 h2 v7 a2 2 0 0 0 2 2 h6 M0 0 h24 v24 H0 z";
				case IconKind.HomeInfinity:
					return "M15.54 17.582 l1.46 1.42 l1.46 1.41 c0.809 0.78 -0.805 -0.779 0 0 s2.12 0.781 2.929 0 a1.951 1.951 0 0 0 0 -2.828 a2.123 2.123 0 0 0 -2.929 0 M15.536 17.586 a2.123 2.123 0 0 0 -2.929 0 a1.951 1.951 0 0 0 0 2.828 c0.809 0.781 2.12 0.781 2.929 0 c0.809 -0.781 -0.805 0.778 0 0 l1.46 -1.41 l1.46 -1.419 M9 21 v-6 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 1.75 1.032 M19 14 v-2 h2 l-9 -9 l-9 9 h2 v7 a2 2 0 0 0 2 2 h2.5 M0 0 h24 v24 H0 z";
				case IconKind.HomeLink:
					return "M21 16 l-5 3 l5 2 M16 19 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M21 16 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M21 21 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M9 21 v-6 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 1.807 1.143 M20.085 11.085 l-8.085 -8.085 l-9 9 h2 v7 a2 2 0 0 0 2 2 h4.5 M0 0 h24 v24 H0 z";
				case IconKind.HomeMinus:
					return "M9 21 v-6 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 M16 19 h6 M19 15 v-3 h2 l-9 -9 l-9 9 h2 v7 a2 2 0 0 0 2 2 h5.5 M0 0 h24 v24 H0 z";
				case IconKind.HomeMove:
					return "M19 16 l3 3 l-3 3 M16 19 h6 M19 12 h2 l-9 -9 l-9 9 h2 v7 a2 2 0 0 0 2 2 h5.5 M9 21 v-6 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 M0 0 h24 v24 H0 z";
				case IconKind.HomeOff:
					return "M3 3 l18 18 M9 21 v-6 a2 2 0 0 1 2 -2 h2 m2 2 v6 M5 12 v7 a2 2 0 0 0 2 2 h10 a2 2 0 0 0 2 -2 m0 -4 v-3 M5 12 h-2 l4.497 -4.497 m2 -2 l2.504 -2.504 l9 9 h-2 M0 0 h24 v24 H0 z";
				case IconKind.HomePlus:
					return "M19 16 v6 M16 19 h6 M9 21 v-6 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 M19 12 h2 l-9 -9 l-9 9 h2 v7 a2 2 0 0 0 2 2 h5.5 M0 0 h24 v24 H0 z";
				case IconKind.HomeQuestion:
					return "M19 19 a2 2 0 0 0 0.914 -3.782 a1.98 1.98 0 0 0 -2.414 0.483 M19 22 v0.01 M9 21 v-6 a2 2 0 0 1 2 -2 h2 c0.467 0 0.896 0.16 1.236 0.428 M20.136 11.136 l-8.136 -8.136 l-9 9 h2 v7 a2 2 0 0 0 2 2 h7 M0 0 h24 v24 H0 z";
				case IconKind.HomeRibbon:
					return "M9 21 v-6 a2 2 0 0 1 2 -2 h1.5 M20 11 l-8 -8 l-9 9 h2 v7 a2 2 0 0 0 2 2 h5 M16 15 h5 v7 l-2.5 -1.5 l-2.5 1.5 z M0 0 h24 v24 H0 z";
				case IconKind.HomeSearch:
					return "M20.2 20.2 l1.8 1.8 M18 18 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M9 21 v-6 a2 2 0 0 1 2 -2 h2 M21 12 l-9 -9 l-9 9 h2 v7 a2 2 0 0 0 2 2 h4.7 M0 0 h24 v24 H0 z";
				case IconKind.HomeShare:
					return "M21 21.5 v-4.5 h-4.5 M16 22 l5 -5 M19 12 h2 l-9 -9 l-9 9 h2 v7 a2 2 0 0 0 2 2 h5 M9 21 v-6 a2 2 0 0 1 2 -2 h2 c0.247 0 0.484 0.045 0.702 0.127 M0 0 h24 v24 H0 z";
				case IconKind.HomeShield:
					return "M22 16 c0 4 -2.5 6 -3.5 6 s-3.5 -2 -3.5 -6 c1 0 2.5 -0.5 3.5 -1.5 c1 1 2.5 1.5 3.5 1.5 z M19.682 10.682 l-7.682 -7.682 l-9 9 h2 v7 a2 2 0 0 0 2 2 h5 M9 21 v-6 a2 2 0 0 1 2 -2 h1.341 M0 0 h24 v24 H0 z";
				case IconKind.HomeSignal:
					return "M9 21 v-6 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v0.5 M19 12.494 v-0.494 h2 l-9 -9 l-9 9 h2 v7 a2 2 0 0 0 2 2 h4 M21 22 v-6 M18 22 v-4 M15 22 v-2 M0 0 h24 v24 H0 z";
				case IconKind.HomeStar:
					return "M17.8 20.817 l-2.172 1.138 a0.392 0.392 0 0 1 -0.568 -0.41 l0.415 -2.411 l-1.757 -1.707 a0.389 0.389 0 0 1 0.217 -0.665 l2.428 -0.352 l1.086 -2.193 a0.392 0.392 0 0 1 0.702 0 l1.086 2.193 l2.428 0.352 a0.39 0.39 0 0 1 0.217 0.665 l-1.757 1.707 l0.414 2.41 a0.39 0.39 0 0 1 -0.567 0.411 l-2.172 -1.138 z M9 21 v-6 a2 2 0 0 1 2 -2 h1.5 M19.258 10.258 l-7.258 -7.258 l-9 9 h2 v7 a2 2 0 0 0 2 2 h4 M0 0 h24 v24 H0 z";
				case IconKind.HomeStats:
					return "M19 17 h3 v3 M13 22 l3 -3 l2 2 l4 -4 M9 21 v-6 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 M19 13 v-1 h2 l-9 -9 l-9 9 h2 v7 a2 2 0 0 0 2 2 h2.5 M0 0 h24 v24 H0 z";
				case IconKind.HomeUp:
					return "M22 19 l-3 -3 l-3 3 M19 22 v-6 M20.136 11.136 l-8.136 -8.136 l-9 9 h2 v7 a2 2 0 0 0 2 2 h6.344 M9 21 v-6 a2 2 0 0 1 2 -2 h2 c0.641 0 1.212 0.302 1.578 0.771 M0 0 h24 v24 H0 z";
				case IconKind.HomeX:
					return "M16.5 21.5 l5 -5 M21.5 21.5 l-5 -5 M9 21 v-6 a2 2 0 0 1 2 -2 h2 c0.402 0 0.777 0.119 1.091 0.323 M19 13.4 v-1.4 h2 l-9 -9 l-9 9 h2 v7 a2 2 0 0 0 2 2 h5.5 M0 0 h24 v24 H0 z";
				case IconKind.Home:
					return "M9 21 v-6 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v6 M5 12 v7 a2 2 0 0 0 2 2 h10 a2 2 0 0 0 2 -2 v-7 M5 12 l-2 0 l9 -9 l9 9 l-2 0 M0 0 h24 v24 H0 z";
				case IconKind.HorseToy:
					return "M8 20 l2 -5 h4 l2 5 M5 18.5 l2 -9.5 M19 18.5 l-2 -8.5 l1 -2 l2 1 l1.5 -1.5 l-2.5 -4.5 c-5.052 0.218 -5.99 3.133 -7 6 h-6 a3 3 0 0 0 -3 3 M3.5 17.5 c5.667 4.667 11.333 4.667 17 0 M0 0 h24 v24 H0 z";
				case IconKind.HotelService:
					return "M8.5 10 a1.5 1.5 0 0 1 -1.5 -1.5 a5.5 5.5 0 0 1 11 0 v10.5 a2 2 0 0 1 -2 2 h-7 a2 2 0 0 1 -2 -2 v-2 c0 -1.38 0.71 -2.444 1.88 -3.175 l4.424 -2.765 c1.055 -0.66 1.696 -1.316 1.696 -2.56 a2.5 2.5 0 1 0 -5 0 a1.5 1.5 0 0 1 -1.5 1.5 z M0 0 h24 v24 H0 z";
				case IconKind.HourglassEmpty:
					return "M6 4 v2 a6 6 0 1 0 12 0 v-2 a1 1 0 0 0 -1 -1 h-10 a1 1 0 0 0 -1 1 z M6 20 v-2 a6 6 0 1 1 12 0 v2 a1 1 0 0 1 -1 1 h-10 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.HourglassHigh:
					return "M6 4 v2 a6 6 0 1 0 12 0 v-2 a1 1 0 0 0 -1 -1 h-10 a1 1 0 0 0 -1 1 z M6 20 v-2 a6 6 0 1 1 12 0 v2 a1 1 0 0 1 -1 1 h-10 a1 1 0 0 1 -1 -1 z M6.5 7 h11 M0 0 h24 v24 H0 z";
				case IconKind.HourglassLow:
					return "M6 4 v2 a6 6 0 1 0 12 0 v-2 a1 1 0 0 0 -1 -1 h-10 a1 1 0 0 0 -1 1 z M6 20 v-2 a6 6 0 1 1 12 0 v2 a1 1 0 0 1 -1 1 h-10 a1 1 0 0 1 -1 -1 z M6.5 17 h11 M0 0 h24 v24 H0 z";
				case IconKind.HourglassOff:
					return "M3 3 l18 18 M6 6 a6 6 0 0 0 6 6 m3.13 -0.88 a6 6 0 0 0 2.87 -5.12 v-2 a1 1 0 0 0 -1 -1 h-10 M18 18 v2 a1 1 0 0 1 -1 1 h-10 a1 1 0 0 1 -1 -1 v-2 a6 6 0 0 1 6 -6 M0 0 h24 v24 H0 z";
				case IconKind.Hourglass:
					return "M6 4 v2 a6 6 0 1 0 12 0 v-2 a1 1 0 0 0 -1 -1 h-10 a1 1 0 0 0 -1 1 z M6 20 v-2 a6 6 0 1 1 12 0 v2 a1 1 0 0 1 -1 1 h-10 a1 1 0 0 1 -1 -1 z M6.5 17 h11 M6.5 7 h11 M0 0 h24 v24 H0 z";
				case IconKind.IceCream2:
					return "M6.342 11 l5.658 11 l5.657 -11 z M17.657 11 a6 6 0 1 0 -11.315 0 M0 0 h24 v24 H0 z";
				case IconKind.IceCreamOff:
					return "M3 3 l18 18 M8 14.5 l4.488 -1.964 M8 10.5 l1.74 -0.76 m2.79 -1.222 l3.47 -1.518 M8 8 v9 h8 v-1 m0 -4 v-5 a4 4 0 0 0 -7.277 -2.294 M12 21.5 v-4.5 M0 0 h24 v24 H0 z";
				case IconKind.IceCream:
					return "M8 14.5 l8 -3.5 M8 10.5 l8 -3.5 M8 17 h8 v-10 a4 4 0 1 0 -8 0 v10 z M12 21.5 v-4.5 M0 0 h24 v24 H0 z";
				case IconKind.IceSkating:
					return "M15 15 v4 M9 15 v4 M3 19 h17 a1 1 0 0 0 1 -1 M5.905 5 h3.418 a1 1 0 0 1 0.928 0.629 l1.143 2.856 a3 3 0 0 0 2.207 1.83 l4.717 0.926 a2.084 2.084 0 0 1 1.682 2.045 v0.714 a1 1 0 0 1 -1 1 h-13.895 a1 1 0 0 1 -1 -1.1 l0.8 -8 a1 1 0 0 1 1 -0.9 z M0 0 h24 v24 H0 z";
				case IconKind.IconsOff:
					return "M3 3 l18 18 M18 14 h3 v3 m0 4 h-7 v-7 M14 10 l7 -7 M14 3 l7 7 M2.5 21 h8 l-4 -7 z M4.01 4.041 a3.5 3.5 0 0 0 2.49 5.959 c0.975 0 1.865 -0.357 2.5 -1 m0.958 -3.044 a3.503 3.503 0 0 0 -2.905 -2.912 M0 0 h24 v24 H0 z";
				case IconKind.Icons:
					return "M14 14 h7 v7 h-7 z M14 10 l7 -7 M14 3 l7 7 M2.5 21 h8 l-4 -7 z M6.5 6.5 m-3.5 0 a3.5 3.5 0 1 0 7 0 a3.5 3.5 0 1 0 -7 0 M0 0 h24 v24 H0 z";
				case IconKind.IdBadge2:
					return "M14 12 h4 M14 16 h2 M10 3 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v3 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M10 6 h-6 a1 1 0 0 0 -1 1 v12 a1 1 0 0 0 1 1 h16 a1 1 0 0 0 1 -1 v-12 a1 1 0 0 0 -1 -1 h-6 M7 12 h3 v4 h-3 z M0 0 h24 v24 H0 z";
				case IconKind.IdBadgeOff:
					return "M3 3 l18 18 M9 18 h6 M10 6 h4 M11.179 11.176 a2 2 0 1 0 2.635 2.667 M7.141 3.125 a3 3 0 0 1 0.859 -0.125 h8 a3 3 0 0 1 3 3 v9 m-0.13 3.874 a3 3 0 0 1 -2.87 2.126 h-8 a3 3 0 0 1 -3 -3 v-12 a3 3 0 0 1 0.128 -0.869 M0 0 h24 v24 H0 z";
				case IconKind.IdBadge:
					return "M9 18 h6 M10 6 h4 M12 13 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 3 m0 3 a3 3 0 0 1 3 -3 h8 a3 3 0 0 1 3 3 v12 a3 3 0 0 1 -3 3 h-8 a3 3 0 0 1 -3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.IdOff:
					return "M3 3 l18 18 M7 16 h9 M16 12 h1 M15 8 h2 M8.175 8.178 a2 2 0 1 0 2.646 2.65 M8 4 h10 a3 3 0 0 1 3 3 v10 m-1.437 2.561 c-0.455 0.279 -0.99 0.439 -1.563 0.439 h-12 a3 3 0 0 1 -3 -3 v-10 c0 -1.083 0.573 -2.031 1.433 -2.559 M0 0 h24 v24 H0 z";
				case IconKind.Id:
					return "M7 16 l10 0 M15 12 l2 0 M15 8 l2 0 M9 10 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M3 4 m0 3 a3 3 0 0 1 3 -3 h12 a3 3 0 0 1 3 3 v10 a3 3 0 0 1 -3 3 h-12 a3 3 0 0 1 -3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.InboxOff:
					return "M3 3 l18 18 M4 13 h3 l3 3 h4 l0.987 -0.987 m2.013 -2.013 h3 M8 4 h10 a2 2 0 0 1 2 2 v10 m-0.593 3.422 a2 2 0 0 1 -1.407 0.578 h-12 a2 2 0 0 1 -2 -2 v-12 c0 -0.554 0.225 -1.056 0.59 -1.418 M0 0 h24 v24 H0 z";
				case IconKind.Inbox:
					return "M4 13 h3 l3 3 h4 l3 -3 h3 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.IndentDecrease:
					return "M8 8 l-4 4 l4 4 M20 18 l-7 0 M20 12 l-9 0 M20 6 l-7 0 M0 0 h24 v24 H0 z";
				case IconKind.IndentIncrease:
					return "M4 8 l4 4 l-4 4 M20 18 l-11 0 M20 12 l-7 0 M20 6 l-11 0 M0 0 h24 v24 H0 z";
				case IconKind.InfinityOff:
					return "M3 3 l18 18 M8.165 8.174 a4 4 0 0 0 -5.166 3.826 a4 4 0 0 0 6.829 2.828 a10 10 0 0 0 2.172 -2.828 m1.677 -2.347 a10 10 0 0 1 0.495 -0.481 a4 4 0 1 1 5.129 6.1 m-3.521 0.537 a4 4 0 0 1 -1.608 -0.981 a10 10 0 0 1 -2.172 -2.828 M0 0 h24 v24 H0 z";
				case IconKind.Infinity:
					return "M9.828 9.172 a4 4 0 1 0 0 5.656 a10 10 0 0 0 2.172 -2.828 a10 10 0 0 1 2.172 -2.828 a4 4 0 1 1 0 5.656 a10 10 0 0 1 -2.172 -2.828 a10 10 0 0 0 -2.172 -2.828 M0 0 h24 v24 H0 z";
				case IconKind.InfoCircleFilled:
					return "M17 3.34 a10 10 0 1 1 -14.995 8.984 l-0.005 -0.324 l0.005 -0.324 a10 10 0 0 1 14.995 -8.336 z m-5 7.66 h-1 l-0.117 0.007 a1 1 0 0 0 0.117 1.993 v3 l0.007 0.117 a1 1 0 0 0 0.993 0.883 h1 l0.117 -0.007 a1 1 0 0 0 0.883 -0.993 l-0.007 -0.117 a1 1 0 0 0 -0.876 -0.876 l-0.117 -0.007 v-3 l-0.007 -0.117 a1 1 0 0 0 -0.993 -0.883 z m0.01 -4 l-0.127 0.007 a1 1 0 0 0 0.117 1.993 l0.127 -0.007 a1 1 0 0 0 -0.117 -1.993 z M0 0 h24 v24 H0 z";
				case IconKind.InfoCircle:
					return "M11 12 l1 0 l0 4 l1 0 M12 8 l0.01 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.InfoSquareRoundedFilled:
					return "M12 2 c-0.218 0 -0.432 0.002 -0.642 0.005 l-0.616 0.017 l-0.299 0.013 l-0.579 0.034 l-0.553 0.046 c-4.785 0.464 -6.732 2.411 -7.196 7.196 l-0.046 0.553 l-0.034 0.579 c-0.005 0.098 -0.01 0.198 -0.013 0.299 l-0.017 0.616 l-0.004 0.318 l-0.001 0.324 c0 0.218 0.002 0.432 0.005 0.642 l0.017 0.616 l0.013 0.299 l0.034 0.579 l0.046 0.553 c0.464 4.785 2.411 6.732 7.196 7.196 l0.553 0.046 l0.579 0.034 c0.098 0.005 0.198 0.01 0.299 0.013 l0.616 0.017 l0.642 0.005 l0.642 -0.005 l0.616 -0.017 l0.299 -0.013 l0.579 -0.034 l0.553 -0.046 c4.785 -0.464 6.732 -2.411 7.196 -7.196 l0.046 -0.553 l0.034 -0.579 c0.005 -0.098 0.01 -0.198 0.013 -0.299 l0.017 -0.616 l0.005 -0.642 l-0.005 -0.642 l-0.017 -0.616 l-0.013 -0.299 l-0.034 -0.579 l-0.046 -0.553 c-0.464 -4.785 -2.411 -6.732 -7.196 -7.196 l-0.553 -0.046 l-0.579 -0.034 a28.058 28.058 0 0 0 -0.299 -0.013 l-0.616 -0.017 l-0.318 -0.004 l-0.324 -0.001 z m0.01 5 a1 1 0 0 1 0.117 1.993 l-0.127 0.007 a1 1 0 0 1 -0.117 -1.993 l0.127 -0.007 z m-0.01 4 a1 1 0 0 1 0.993 0.883 l0.007 0.117 v3 l0.117 0.007 a1 1 0 0 1 0.876 0.876 l0.007 0.117 a1 1 0 0 1 -0.883 0.993 l-0.117 0.007 h-1 a1 1 0 0 1 -0.993 -0.883 l-0.007 -0.117 v-3 a1 1 0 0 1 -0.117 -1.993 l0.117 -0.007 h1 z M0 0 h24 v24 H0 z";
				case IconKind.InfoSquareRounded:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M11 12 h1 v4 h1 M12 8 h0.01 M0 0 h24 v24 H0 z";
				case IconKind.InfoSquare:
					return "M11 12 l1 0 l0 4 l1 0 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M12 8 l0.01 0 M0 0 h24 v24 H0 z";
				case IconKind.InnerShadowBottomLeft:
					return "M6 12 a6 6 0 0 0 6 6 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.InnerShadowBottomRight:
					return "M18 12 a6 6 0 0 1 -6 6 M12 21 a9 9 0 1 1 0 -18 a9 9 0 0 1 0 18 z M0 0 h24 v24 H0 z";
				case IconKind.InnerShadowBottom:
					return "M7.757 16.243 a6 6 0 0 0 8.486 0 M18.364 18.364 a9 9 0 1 0 -12.728 -12.728 a9 9 0 0 0 12.728 12.728 z M0 0 h24 v24 H0 z";
				case IconKind.InnerShadowLeft:
					return "M7.757 16.243 a6 6 0 0 1 0 -8.486 M5.636 5.636 a9 9 0 1 1 12.728 12.728 a9 9 0 0 1 -12.728 -12.728 z M0 0 h24 v24 H0 z";
				case IconKind.InnerShadowRight:
					return "M16.243 7.757 a6 6 0 0 1 0 8.486 M18.364 18.364 a9 9 0 1 1 -12.728 -12.728 a9 9 0 0 1 12.728 12.728 z M0 0 h24 v24 H0 z";
				case IconKind.InnerShadowTopLeft:
					return "M6 12 a6 6 0 0 1 6 -6 M12 3 a9 9 0 1 1 0 18 a9 9 0 0 1 0 -18 z M0 0 h24 v24 H0 z";
				case IconKind.InnerShadowTopRight:
					return "M18 12 a6 6 0 0 0 -6 -6 M12 3 a9 9 0 1 0 0 18 a9 9 0 0 0 0 -18 z M0 0 h24 v24 H0 z";
				case IconKind.InnerShadowTop:
					return "M16.243 7.757 a6 6 0 0 0 -8.486 0 M5.636 5.636 a9 9 0 1 0 12.728 12.728 a9 9 0 0 0 -12.728 -12.728 z M0 0 h24 v24 H0 z";
				case IconKind.InputSearch:
					return "M17.5 17.5 l2.5 2.5 M15.5 15.5 m-2.5 0 a2.5 2.5 0 1 0 5 0 a2.5 2.5 0 1 0 -5 0 M19 11 v-3 a2 2 0 0 0 -2 -2 h-12 a2 2 0 0 0 -2 2 v5 a2 2 0 0 0 2 2 h5 M0 0 h24 v24 H0 z";
				case IconKind.Ironing1:
					return "M12 15 h0.01 M9 6 h7.459 a3 3 0 0 1 2.959 2.507 l0.577 3.464 l0.81 4.865 a1 1 0 0 1 -0.985 1.164 h-16.82 a7 7 0 0 1 7 -7 h9.8 M0 0 h24 v24 H0 z";
				case IconKind.Ironing2:
					return "M14 15 h0.01 M9 6 h7.459 a3 3 0 0 1 2.959 2.507 l0.577 3.464 l0.81 4.865 a1 1 0 0 1 -0.985 1.164 h-16.82 a7 7 0 0 1 7 -7 h9.8 M10 15 h0.01 M0 0 h24 v24 H0 z";
				case IconKind.Ironing3:
					return "M15 15 h0.01 M9 15 h0.01 M9 6 h7.459 a3 3 0 0 1 2.959 2.507 l0.577 3.464 l0.81 4.865 a1 1 0 0 1 -0.985 1.164 h-16.82 a7 7 0 0 1 7 -7 h9.8 M12 15 h0.01 M0 0 h24 v24 H0 z";
				case IconKind.IroningOff:
					return "M3 3 l18 18 M10 6 h6.459 a3 3 0 0 1 2.959 2.507 l0.577 3.464 l0.804 4.821 l0.007 0.044 m-2.806 1.164 h-15 a7 7 0 0 1 7 -7 h1 m4 0 h4.8 M0 0 h24 v24 H0 z";
				case IconKind.IroningSteamOff:
					return "M3 3 l18 18 M16 19 l1 2 M8 19 l-1 2 M12 19 v2 M13 9 h6.8 M16 16 h-13 a7 7 0 0 1 6.056 -6.937 M9 4 h7.459 a3 3 0 0 1 2.959 2.507 l0.577 3.464 l0.81 4.865 a1 1 0 0 1 -0.821 1.15 M0 0 h24 v24 H0 z";
				case IconKind.IroningSteam:
					return "M16 19 l1 2 M8 19 l-1 2 M9 4 h7.459 a3 3 0 0 1 2.959 2.507 l0.577 3.464 l0.81 4.865 a1 1 0 0 1 -0.985 1.164 h-16.82 a7 7 0 0 1 7 -7 h9.8 M12 19 v2 M0 0 h24 v24 H0 z";
				case IconKind.Italic:
					return "M14 5 l-4 14 M7 19 l6 0 M11 5 l6 0 M0 0 h24 v24 H0 z";
				case IconKind.Jacket:
					return "M12 19 v-11 M4 17 h3 a1 1 0 0 0 1 -1 v-2 a1 1 0 0 0 -1 -1 h-3 M20 13 h-3 a1 1 0 0 0 -1 1 v2 a1 1 0 0 0 1 1 h3 M12 19 a2 2 0 0 1 -2 2 h-4 a2 2 0 0 1 -2 -2 v-8.172 a2 2 0 0 1 0.586 -1.414 l0.828 -0.828 a2 2 0 0 0 0.586 -1.414 v-2.172 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v2.172 a2 2 0 0 0 0.586 1.414 l0.828 0.828 a2 2 0 0 1 0.586 1.414 v8.172 a2 2 0 0 1 -2 2 h-4 a2 2 0 0 1 -2 -2 z M16 3 l-4 5 l-4 -5 M0 0 h24 v24 H0 z";
				case IconKind.Jetpack:
					return "M10 11 h4 M10 8 h4 M15 16 c0 2.333 0.667 4 2 5 c1.333 -1 2 -2.667 2 -5 M5 16 c0 2.333 0.667 4 2 5 c1.333 -1 2 -2.667 2 -5 M14 13 h6 v-7 a3 3 0 0 0 -6 0 v7 z M10 6 a3 3 0 1 0 -6 0 v7 h6 v-7 z M0 0 h24 v24 H0 z";
				case IconKind.JewishStarFilled:
					return "M12 2 l3 5 h6 l-3 5 l3 5 h-6 l-3 5 l-3 -5 h-6 l3 -5 l-3 -5 h6 z M0 0 h24 v24 H0 z";
				case IconKind.JewishStar:
					return "M12 2 l3 5 h6 l-3 5 l3 5 h-6 l-3 5 l-3 -5 h-6 l3 -5 l-3 -5 h6 z M0 0 h24 v24 H0 z";
				case IconKind.Jpg:
					return "M3 8 h4 v6 a2 2 0 0 1 -2 2 h-1.5 a0.5 0.5 0 0 1 -0.5 -0.5 v-0.5 M10 16 v-8 h2 a2 2 0 1 1 0 4 h-2 M21 8 h-2 a2 2 0 0 0 -2 2 v4 a2 2 0 0 0 2 2 h2 v-4 h-1 M0 0 h24 v24 H0 z";
				case IconKind.JumpRope:
					return "M4 14 m0 2 a2 2 0 0 1 2 -2 h0 a2 2 0 0 1 2 2 v3 a2 2 0 0 1 -2 2 h0 a2 2 0 0 1 -2 -2 z M16 3 m0 2 a2 2 0 0 1 2 -2 h0 a2 2 0 0 1 2 2 v3 a2 2 0 0 1 -2 2 h0 a2 2 0 0 1 -2 -2 z M6 14 v-6 a3 3 0 1 1 6 0 v8 a3 3 0 0 0 6 0 v-6 M0 0 h24 v24 H0 z";
				case IconKind.Karate:
					return "M8 4.5 l4 2 l4 1 l4 3.5 l-2 3.5 M13 21 v-8 l3 -5.5 M3 9 l4.5 1 l3 2.5 M18 4 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.Kayak:
					return "M12.5 6.5 l5 5 M6.5 12.5 l5 5 M22 2.5 c-9.983 2.601 -17.627 7.952 -20 19.5 c9.983 -2.601 17.627 -7.952 20 -19.5 z M6.5 6.5 l11 11 M17.586 17.586 a2 2 0 0 0 0 2.828 l1.414 1.414 l2.828 -2.828 l-1.414 -1.414 a2 2 0 0 0 -2.828 0 z M6.414 6.414 a2 2 0 0 0 0 -2.828 l-1.414 -1.414 l-2.828 2.828 l1.414 1.414 a2 2 0 0 0 2.828 0 z M0 0 h24 v24 H0 z";
				case IconKind.Kering:
					return "M9 20 l6 -16 M3 9 l3 6 l3 -6 M16 15 v-3.5 a2.5 2.5 0 1 1 5 0 v3.5 m0 -2 h-5 M0 0 h24 v24 H0 z";
				case IconKind.KeyOff:
					return "M3 3 l18 18 M15 9 h0.01 M14.931 14.948 a2.863 2.863 0 0 1 -1.486 -0.79 l-0.301 -0.302 l-6.558 6.558 a2 2 0 0 1 -1.239 0.578 l-0.175 0.008 h-1.172 a1 1 0 0 1 -0.993 -0.883 l-0.007 -0.117 v-1.172 a2 2 0 0 1 0.467 -1.284 l0.119 -0.13 l0.414 -0.414 h2 v-2 h2 v-2 l2.144 -2.144 l-0.301 -0.301 a2.863 2.863 0 0 1 -0.794 -1.504 M10.17 6.159 l2.316 -2.316 a2.877 2.877 0 0 1 4.069 0 l3.602 3.602 a2.877 2.877 0 0 1 0 4.069 l-2.33 2.33 M0 0 h24 v24 H0 z";
				case IconKind.Key:
					return "M15 9 h0.01 M16.555 3.843 l3.602 3.602 a2.877 2.877 0 0 1 0 4.069 l-2.643 2.643 a2.877 2.877 0 0 1 -4.069 0 l-0.301 -0.301 l-6.558 6.558 a2 2 0 0 1 -1.239 0.578 l-0.175 0.008 h-1.172 a1 1 0 0 1 -0.993 -0.883 l-0.007 -0.117 v-1.172 a2 2 0 0 1 0.467 -1.284 l0.119 -0.13 l0.414 -0.414 h2 v-2 h2 v-2 l2.144 -2.144 l-0.301 -0.301 a2.877 2.877 0 0 1 0 -4.069 l2.643 -2.643 a2.877 2.877 0 0 1 4.069 0 z M0 0 h24 v24 H0 z";
				case IconKind.KeyboardHide:
					return "M10 21 l2 -2 l2 2 M10 11 l4 0 M18 11 l0 0.01 M6 11 l0 0.01 M18 7 l0 0 M14 7 l0 0 M10 7 l0 0 M6 7 l0 0 M2 3 m0 2 a2 2 0 0 1 2 -2 h16 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-16 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.KeyboardOff:
					return "M3 3 l18 18 M10 14 l4 0 M18 14 l0 0.01 M6 14 l0 0.01 M18 10 l0 0.01 M14 10 l0 0.01 M10 10 l0 0.01 M6 10 l0 0.01 M18 18 h-14 a2 2 0 0 1 -2 -2 v-8 a2 2 0 0 1 2 -2 h2 m4 0 h10 a2 2 0 0 1 2 2 v8 c0 0.554 -0.226 1.056 -0.59 1.418 M0 0 h24 v24 H0 z";
				case IconKind.KeyboardShow:
					return "M10 19 l2 2 l2 -2 M10 11 l4 0 M18 11 l0 0.01 M6 11 l0 0.01 M18 7 l0 0 M14 7 l0 0 M10 7 l0 0 M6 7 l0 0 M2 3 m0 2 a2 2 0 0 1 2 -2 h16 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-16 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Keyboard:
					return "M10 14 l4 0 M18 14 l0 0.01 M6 14 l0 0.01 M18 10 l0 0 M14 10 l0 0 M10 10 l0 0 M6 10 l0 0 M2 6 m0 2 a2 2 0 0 1 2 -2 h16 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-16 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.KeyframeAlignCenter:
					return "M19 12 h2 M3 12 h2 M12 2 v2 M12.816 16.58 c-0.207 0.267 -0.504 0.42 -0.816 0.42 c-0.312 0 -0.61 -0.153 -0.816 -0.42 l-2.908 -3.748 a1.39 1.39 0 0 1 0 -1.664 l2.908 -3.748 c0.207 -0.267 0.504 -0.42 0.816 -0.42 c0.312 0 0.61 0.153 0.816 0.42 l2.908 3.748 a1.39 1.39 0 0 1 0 1.664 l-2.908 3.748 z M12 20 v2 M0 0 h24 v24 H0 z";
				case IconKind.KeyframeAlignHorizontal:
					return "M19 12 h2 M3 12 h2 M12.816 16.58 c-0.207 0.267 -0.504 0.42 -0.816 0.42 c-0.312 0 -0.61 -0.153 -0.816 -0.42 l-2.908 -3.748 a1.39 1.39 0 0 1 0 -1.664 l2.908 -3.748 c0.207 -0.267 0.504 -0.42 0.816 -0.42 c0.312 0 0.61 0.153 0.816 0.42 l2.908 3.748 a1.39 1.39 0 0 1 0 1.664 l-2.908 3.748 z M0 0 h24 v24 H0 z";
				case IconKind.KeyframeAlignVertical:
					return "M12 20 v2 M12.816 16.58 c-0.207 0.267 -0.504 0.42 -0.816 0.42 c-0.312 0 -0.61 -0.153 -0.816 -0.42 l-2.908 -3.748 a1.39 1.39 0 0 1 0 -1.664 l2.908 -3.748 c0.207 -0.267 0.504 -0.42 0.816 -0.42 c0.312 0 0.61 0.153 0.816 0.42 l2.908 3.748 a1.39 1.39 0 0 1 0 1.664 l-2.908 3.748 z M12 2 v2 M0 0 h24 v24 H0 z";
				case IconKind.Keyframe:
					return "M13.225 18.412 a1.595 1.595 0 0 1 -1.225 0.588 c-0.468 0 -0.914 -0.214 -1.225 -0.588 l-4.361 -5.248 a1.844 1.844 0 0 1 0 -2.328 l4.361 -5.248 a1.595 1.595 0 0 1 1.225 -0.588 c0.468 0 0.914 0.214 1.225 0.588 l4.361 5.248 a1.844 1.844 0 0 1 0 2.328 l-4.361 5.248 z M0 0 h24 v24 H0 z";
				case IconKind.Keyframes:
					return "M13 5 l4.586 5.836 a1.844 1.844 0 0 1 0 2.328 l-4.586 5.836 M17 5 l4.586 5.836 a1.844 1.844 0 0 1 0 2.328 l-4.586 5.836 M9.225 18.412 a1.595 1.595 0 0 1 -1.225 0.588 c-0.468 0 -0.914 -0.214 -1.225 -0.588 l-4.361 -5.248 a1.844 1.844 0 0 1 0 -2.328 l4.361 -5.248 a1.595 1.595 0 0 1 1.225 -0.588 c0.468 0 0.914 0.214 1.225 0.588 l4.361 5.248 a1.844 1.844 0 0 1 0 2.328 l-4.361 5.248 z M0 0 h24 v24 H0 z";
				case IconKind.LadderOff:
					return "M3 3 l18 18 M8 18 h8 M10 6 h6 M8 10 h2 m4 0 h2 M8 14 h6 M16 3 v9 m0 4 v5 M8 3 v1 m0 4 v13 M0 0 h24 v24 H0 z";
				case IconKind.Ladder:
					return "M8 18 h8 M8 6 h8 M8 10 h8 M8 14 h8 M16 3 v18 M8 3 v18 M0 0 h24 v24 H0 z";
				case IconKind.Lambda:
					return "M19 20 c-6 0 -6 -16 -12 -16 M6 20 l6.5 -9 M0 0 h24 v24 H0 z";
				case IconKind.Lamp2:
					return "M15.5 12 l0.208 0.274 a2.527 2.527 0 0 0 3.556 0 c0.939 -0.933 0.98 -2.42 0.122 -3.4 l-0.366 -0.369 M11.742 7.574 l-1.156 -1.156 a2 2 0 0 1 2.828 -2.829 l1.144 1.144 M13 14 c-2.148 -2.148 -2.148 -5.852 0 -8 c2.088 -2.088 5.842 -1.972 8 0 l-8 8 z M10 21 l-7 -8 l8.5 -5.5 M5 21 h9 M0 0 h24 v24 H0 z";
				case IconKind.LampOff:
					return "M3 3 l18 18 M7.325 7.35 l-2.325 4.65 h7 m4 0 h3 l-4 -8 h-6 l-0.338 0.676 M12 20 v-8 M9 20 h6 M0 0 h24 v24 H0 z";
				case IconKind.Lamp:
					return "M5 12 h14 l-4 -8 h-6 z M12 20 v-8 M9 20 h6 M0 0 h24 v24 H0 z";
				case IconKind.LanguageHiragana:
					return "M19.1 18 h-6.2 M12 20 l4 -9 l4 9 M10 8.5 c0 2.286 -2 4.5 -3.5 4.5 s-2.5 -1.135 -2.5 -2 c0 -2 1 -3 3 -3 s5 0.57 5 2.857 c0 1.524 -0.667 2.571 -2 3.143 M7 4 c0 4.846 0 7 0.5 8 M4 5 h7 M0 0 h24 v24 H0 z";
				case IconKind.LanguageKatakana:
					return "M19.1 18 h-6.2 M12 20 l4 -9 l4 9 M8 8 c0 1.5 0.5 3 -2 5 M5 5 h6.586 a1 1 0 0 1 0.707 1.707 l-1.293 1.293 M0 0 h24 v24 H0 z";
				case IconKind.LanguageOff:
					return "M3 3 l18 18 M18 18 h-5.1 M12 20 l2.463 -5.541 m1.228 -2.764 l0.309 -0.695 l0.8 1.8 M5 9 c0 2.144 2.952 3.908 6.7 4 M9 3 v2 m-0.508 3.517 c-0.814 2.655 -2.52 4.483 -4.492 4.483 M4 5 h1 m4 0 h2 M0 0 h24 v24 H0 z";
				case IconKind.Language:
					return "M19.1 18 h-6.2 M12 20 l4 -9 l4 9 M5 9 c0 2.144 2.952 3.908 6.7 4 M9 3 v2 c0 4.418 -2.239 8 -5 8 M4 5 h7 M0 0 h24 v24 H0 z";
				case IconKind.LassoOff:
					return "M3 3 l18 18 M5 17 c0 1.42 0.316 2.805 1 4 M5 15 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M4.028 13.252 c-0.657 -0.972 -1.028 -2.078 -1.028 -3.252 c0 -1.804 0.878 -3.449 2.319 -4.69 m2.49 -1.506 a11.066 11.066 0 0 1 4.191 -0.804 c4.97 0 9 3.134 9 7 c0 1.799 -0.873 3.44 -2.307 4.68 m-2.503 1.517 a11.066 11.066 0 0 1 -4.19 0.803 c-1.913 0 -3.686 -0.464 -5.144 -1.255 M0 0 h24 v24 H0 z";
				case IconKind.LassoPolygon:
					return "M5 17 c0 1.42 0.316 2.805 1 4 M5 15 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M4.028 13.252 l-1.028 -3.252 l2 -7 l7 5 l8 -3 l1 9 l-9 3 l-5.144 -1.255 M0 0 h24 v24 H0 z";
				case IconKind.Lasso:
					return "M5 17 c0 1.42 0.316 2.805 1 4 M5 15 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M4.028 13.252 c-0.657 -0.972 -1.028 -2.078 -1.028 -3.252 c0 -3.866 4.03 -7 9 -7 s9 3.134 9 7 s-4.03 7 -9 7 c-1.913 0 -3.686 -0.464 -5.144 -1.255 M0 0 h24 v24 H0 z";
				case IconKind.LayersDifference:
					return "M16 14 l0 2 l-2 0 M14 8 l2 0 l0 2 M8 14 l0 2 l2 0 M10 8 l-2 0 l0 2 M16 16 v2 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 v-8 a2 2 0 0 1 2 -2 h2 v-2 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-2 M0 0 h24 v24 H0 z";
				case IconKind.LayersIntersect2:
					return "M9 15 l6 -6 M4 8 m0 2 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 z M8 4 m0 2 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.LayersIntersect:
					return "M4 8 m0 2 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 z M8 4 m0 2 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.LayersLinked:
					return "M5 15.734 a2 2 0 0 1 -1 -1.734 v-8 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-3 M19 8.268 a2 2 0 0 1 1 1.732 v8 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 v-8 a2 2 0 0 1 2 -2 h3 M0 0 h24 v24 H0 z";
				case IconKind.LayersOff:
					return "M3 3 l18 18 M16 16 v2 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 v-8 a2 2 0 0 1 2 -2 h2 M8.59 4.581 c0.362 -0.359 0.86 -0.581 1.41 -0.581 h8 a2 2 0 0 1 2 2 v8 c0 0.556 -0.227 1.06 -0.594 1.422 m-3.406 0.578 h-6 a2 2 0 0 1 -2 -2 v-6 M0 0 h24 v24 H0 z";
				case IconKind.LayersSubtract:
					return "M16 16 v2 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 v-8 a2 2 0 0 1 2 -2 h2 M8 4 m0 2 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.LayersUnion:
					return "M16 16 v2 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 v-8 a2 2 0 0 1 2 -2 h2 v-2 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-2 M0 0 h24 v24 H0 z";
				case IconKind.Layout2:
					return "M14 15 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v1 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M14 4 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v3 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M4 13 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v3 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M4 4 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v1 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.LayoutAlignBottom:
					return "M9 4 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M4 20 l16 0 M0 0 h24 v24 H0 z";
				case IconKind.LayoutAlignCenter:
					return "M6 9 m0 2 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v2 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 z M12 15 l0 5 M12 4 l0 5 M0 0 h24 v24 H0 z";
				case IconKind.LayoutAlignLeft:
					return "M8 9 m0 2 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v2 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 z M4 4 l0 16 M0 0 h24 v24 H0 z";
				case IconKind.LayoutAlignMiddle:
					return "M9 6 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M15 12 l5 0 M4 12 l5 0 M0 0 h24 v24 H0 z";
				case IconKind.LayoutAlignRight:
					return "M4 9 m0 2 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v2 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 z M20 4 l0 16 M0 0 h24 v24 H0 z";
				case IconKind.LayoutAlignTop:
					return "M9 8 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M4 4 l16 0 M0 0 h24 v24 H0 z";
				case IconKind.LayoutBoardSplit:
					return "M12 4 v16 M12 9 h8 M12 15 h8 M4 12 h8 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.LayoutBoard:
					return "M12 4 v16 M12 15 h8 M4 9 h8 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.LayoutBottombarCollapse:
					return "M14 8 l-2 2 l-2 -2 M20 15 h-16 M20 6 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 v-12 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 z M0 0 h24 v24 H0 z";
				case IconKind.LayoutBottombarExpand:
					return "M14 10 l-2 -2 l-2 2 M20 15 h-16 M20 6 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 v-12 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 z M0 0 h24 v24 H0 z";
				case IconKind.LayoutBottombar:
					return "M4 15 l16 0 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.LayoutCards:
					return "M14 4 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v6 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M4 4 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.LayoutCollage:
					return "M12 12 l-8 2 M10 4 l4 16 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.LayoutColumns:
					return "M12 4 l0 16 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.LayoutDashboard:
					return "M14 4 h6 v4 h-6 z M14 12 h6 v8 h-6 z M4 16 h6 v4 h-6 z M4 4 h6 v8 h-6 z M0 0 h24 v24 H0 z";
				case IconKind.LayoutDistributeHorizontal:
					return "M6 9 m0 2 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v2 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 z M4 20 l16 0 M4 4 l16 0 M0 0 h24 v24 H0 z";
				case IconKind.LayoutDistributeVertical:
					return "M9 6 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M20 4 l0 16 M4 4 l0 16 M0 0 h24 v24 H0 z";
				case IconKind.LayoutGridAdd:
					return "M14 17 h6 m-3 -3 v6 M4 14 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M14 4 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M4 4 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.LayoutGrid:
					return "M14 14 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M4 14 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M14 4 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M4 4 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.LayoutKanban:
					return "M14 8 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v2 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M4 8 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M14 4 l6 0 M4 4 l6 0 M0 0 h24 v24 H0 z";
				case IconKind.LayoutList:
					return "M4 14 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v2 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v2 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.LayoutNavbarCollapse:
					return "M10 16 l2 -2 l2 2 M4 9 h16 M4 18 v-12 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.LayoutNavbarExpand:
					return "M10 14 l2 2 l2 -2 M4 9 h16 M4 18 v-12 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.LayoutNavbar:
					return "M4 9 l16 0 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.LayoutOff:
					return "M3 3 l18 18 M14 10 v-4 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v10 m-0.595 3.423 a2 2 0 0 1 -1.405 0.577 h-2 a2 2 0 0 1 -2 -2 v-4 M4 13 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v3 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M8 4 a2 2 0 0 1 2 2 m-1.162 2.816 a1.993 1.993 0 0 1 -0.838 0.184 h-2 a2 2 0 0 1 -2 -2 v-1 c0 -0.549 0.221 -1.046 0.58 -1.407 M0 0 h24 v24 H0 z";
				case IconKind.LayoutRows:
					return "M4 12 l16 0 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.LayoutSidebarLeftCollapse:
					return "M15 10 l-2 2 l2 2 M9 4 v16 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.LayoutSidebarLeftExpand:
					return "M14 10 l2 2 l-2 2 M9 4 v16 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.LayoutSidebarRightCollapse:
					return "M9 10 l2 2 l-2 2 M15 4 v16 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.LayoutSidebarRightExpand:
					return "M10 10 l-2 2 l2 2 M15 4 v16 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.LayoutSidebarRight:
					return "M15 4 l0 16 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.LayoutSidebar:
					return "M9 4 l0 16 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Layout:
					return "M14 4 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M4 13 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v3 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M4 4 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v1 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.LeafOff:
					return "M3 3 l18 18 M6.618 6.623 c-1.874 1.625 -2.625 3.877 -2.632 6.377 c0 1 0 3 2 5 h3.014 c2.733 0 5.092 -0.635 6.92 -2.087 m1.899 -2.099 c1.224 -1.872 1.987 -4.434 2.181 -7.814 v-2 h-4.014 c-2.863 0 -5.118 0.405 -6.861 1.118 M5 21 c0.475 -4.27 2.3 -7.64 6.331 -9.683 M0 0 h24 v24 H0 z";
				case IconKind.Leaf:
					return "M9 18 c6.218 0 10.5 -3.288 11 -12 v-2 h-4.014 c-9 0 -11.986 4 -12 9 c0 1 0 3 2 5 h3 z M5 21 c0.5 -4.5 2.5 -8 7 -10 M0 0 h24 v24 H0 z";
				case IconKind.LegoOff:
					return "M3 3 l18 18 M8 4 v-1 h8 v2 h1 a3 3 0 0 1 3 3 v8 m-0.884 3.127 a2.99 2.99 0 0 1 -2.116 0.873 v1 h-10 v-1 a3 3 0 0 1 -3 -3 v-9 c0 -1.083 0.574 -2.032 1.435 -2.56 M9.5 15 a3.5 3.5 0 0 0 5 0 M9.5 11 h0.01 M0 0 h24 v24 H0 z";
				case IconKind.Lego:
					return "M7 5 h1 v-2 h8 v2 h1 a3 3 0 0 1 3 3 v9 a3 3 0 0 1 -3 3 v1 h-10 v-1 a3 3 0 0 1 -3 -3 v-9 a3 3 0 0 1 3 -3 M9.5 15 a3.5 3.5 0 0 0 5 0 M14.5 11 l0.01 0 M9.5 11 l0.01 0 M0 0 h24 v24 H0 z";
				case IconKind.Lemon2:
					return "M18 4 a2 2 0 0 1 1.185 3.611 c1.55 2.94 0.873 6.917 -1.892 9.682 c-2.765 2.765 -6.743 3.442 -9.682 1.892 a2 2 0 1 1 -2.796 -2.796 c-1.55 -2.94 -0.873 -6.917 1.892 -9.682 c2.765 -2.765 6.743 -3.442 9.682 -1.892 a2 2 0 0 1 1.611 -0.815 z M0 0 h24 v24 H0 z";
				case IconKind.Lemon:
					return "M10.464 10.464 h6.364 M10.464 10.464 v6.364 M10.464 10.464 l4.597 4.597 M5.868 15.06 a6.5 6.5 0 0 0 9.193 -9.192 M17.536 3.393 c3.905 3.906 3.905 10.237 0 14.143 c-3.906 3.905 -10.237 3.905 -14.143 0 l14.143 -14.143 M0 0 h24 v24 H0 z";
				case IconKind.LetterA:
					return "M7 13 l10 0 M7 20 v-12 a4 4 0 0 1 4 -4 h2 a4 4 0 0 1 4 4 v12 M0 0 h24 v24 H0 z";
				case IconKind.LetterB:
					return "M7 12 l6 0 M7 20 v-16 h6 a4 4 0 0 1 0 8 a4 4 0 0 1 0 8 h-6 M0 0 h24 v24 H0 z";
				case IconKind.LetterC:
					return "M18 9 a5 5 0 0 0 -5 -5 h-2 a5 5 0 0 0 -5 5 v6 a5 5 0 0 0 5 5 h2 a5 5 0 0 0 5 -5 M0 0 h24 v24 H0 z";
				case IconKind.LetterCaseLower:
					return "M21 12 v7 M17.5 15.5 m-3.5 0 a3.5 3.5 0 1 0 7 0 a3.5 3.5 0 1 0 -7 0 M10 12 v7 M6.5 15.5 m-3.5 0 a3.5 3.5 0 1 0 7 0 a3.5 3.5 0 1 0 -7 0 M0 0 h24 v24 H0 z";
				case IconKind.LetterCaseToggle:
					return "M10 12 v7 M14 13 h7 M14 19 v-10.5 a3.5 3.5 0 0 1 7 0 v10.5 M6.5 15.5 m-3.5 0 a3.5 3.5 0 1 0 7 0 a3.5 3.5 0 1 0 -7 0 M0 0 h24 v24 H0 z";
				case IconKind.LetterCaseUpper:
					return "M14 13 h7 M14 19 v-10.5 a3.5 3.5 0 0 1 7 0 v10.5 M3 13 h7 M3 19 v-10.5 a3.5 3.5 0 0 1 7 0 v10.5 M0 0 h24 v24 H0 z";
				case IconKind.LetterCase:
					return "M21 12 v7 M3 13 h7 M3 19 v-10.5 a3.5 3.5 0 0 1 7 0 v10.5 M17.5 15.5 m-3.5 0 a3.5 3.5 0 1 0 7 0 a3.5 3.5 0 1 0 -7 0 M0 0 h24 v24 H0 z";
				case IconKind.LetterD:
					return "M7 4 h6 a5 5 0 0 1 5 5 v6 a5 5 0 0 1 -5 5 h-6 v-16 M0 0 h24 v24 H0 z";
				case IconKind.LetterE:
					return "M7 12 l8 0 M17 4 h-10 v16 h10 M0 0 h24 v24 H0 z";
				case IconKind.LetterF:
					return "M7 12 l8 0 M17 4 h-10 v16 M0 0 h24 v24 H0 z";
				case IconKind.LetterG:
					return "M18 9 a5 5 0 0 0 -5 -5 h-2 a5 5 0 0 0 -5 5 v6 a5 5 0 0 0 5 5 h2 a5 5 0 0 0 5 -5 v-2 h-4 M0 0 h24 v24 H0 z";
				case IconKind.LetterH:
					return "M7 4 l0 16 M7 12 l10 0 M17 4 l0 16 M0 0 h24 v24 H0 z";
				case IconKind.LetterI:
					return "M12 4 l0 16 M0 0 h24 v24 H0 z";
				case IconKind.LetterJ:
					return "M17 4 v12 a4 4 0 0 1 -4 4 h-2 a4 4 0 0 1 -4 -4 M0 0 h24 v24 H0 z";
				case IconKind.LetterK:
					return "M9 12 l8 8 M7 12 h2 l8 -8 M7 4 l0 16 M0 0 h24 v24 H0 z";
				case IconKind.LetterL:
					return "M7 4 v16 h10 M0 0 h24 v24 H0 z";
				case IconKind.LetterM:
					return "M6 20 v-16 l6 14 l6 -14 v16 M0 0 h24 v24 H0 z";
				case IconKind.LetterN:
					return "M7 20 v-16 l10 16 v-16 M0 0 h24 v24 H0 z";
				case IconKind.LetterO:
					return "M18 9 a5 5 0 0 0 -5 -5 h-2 a5 5 0 0 0 -5 5 v6 a5 5 0 0 0 5 5 h2 a5 5 0 0 0 5 -5 v-6 M0 0 h24 v24 H0 z";
				case IconKind.LetterP:
					return "M7 20 v-16 h5.5 a4 4 0 0 1 0 9 h-5.5 M0 0 h24 v24 H0 z";
				case IconKind.LetterQ:
					return "M13 15 l5 5 M18 9 a5 5 0 0 0 -5 -5 h-2 a5 5 0 0 0 -5 5 v6 a5 5 0 0 0 5 5 h2 a5 5 0 0 0 5 -5 v-6 M0 0 h24 v24 H0 z";
				case IconKind.LetterR:
					return "M12 13 l5 7 M7 20 v-16 h5.5 a4 4 0 0 1 0 9 h-5.5 M0 0 h24 v24 H0 z";
				case IconKind.LetterS:
					return "M17 8 a4 4 0 0 0 -4 -4 h-2 a4 4 0 0 0 0 8 h2 a4 4 0 0 1 0 8 h-2 a4 4 0 0 1 -4 -4 M0 0 h24 v24 H0 z";
				case IconKind.LetterSpacing:
					return "M7 16 l-2 2 l2 2 M17 20 l2 -2 l-2 -2 M5 18 h14 M13 4 l3 8 l3 -8 M5 12 v-5.5 a2.5 2.5 0 0 1 5 0 v5.5 m0 -4 h-5 M0 0 h24 v24 H0 z";
				case IconKind.LetterT:
					return "M12 4 l0 16 M6 4 l12 0 M0 0 h24 v24 H0 z";
				case IconKind.LetterU:
					return "M6 4 v11 a5 5 0 0 0 5 5 h2 a5 5 0 0 0 5 -5 v-11 M0 0 h24 v24 H0 z";
				case IconKind.LetterV:
					return "M6 4 l6 16 l6 -16 M0 0 h24 v24 H0 z";
				case IconKind.LetterW:
					return "M4 4 l4 16 l4 -14 l4 14 l4 -16 M0 0 h24 v24 H0 z";
				case IconKind.LetterX:
					return "M17 4 l-10 16 M7 4 l10 16 M0 0 h24 v24 H0 z";
				case IconKind.LetterY:
					return "M12 13 l0 7 M7 4 l5 9 l5 -9 M0 0 h24 v24 H0 z";
				case IconKind.LetterZ:
					return "M7 4 h10 l-10 16 h10 M0 0 h24 v24 H0 z";
				case IconKind.LicenseOff:
					return "M3 3 l18 18 M9 11 h2 M11 7 h2 M15 21 h-9 a3 3 0 0 1 -3 -3 v-1 h10 v2 a2 2 0 1 0 4 0 v-2 m0 -4 v-8 a2 2 0 1 1 2 2 h-2 m2 -4 h-11 a3 3 0 0 0 -0.864 0.126 m-2.014 2.025 a3 3 0 0 0 -0.122 0.849 v11 M0 0 h24 v24 H0 z";
				case IconKind.License:
					return "M9 11 l4 0 M9 7 l4 0 M15 21 h-9 a3 3 0 0 1 -3 -3 v-1 h10 v2 a2 2 0 0 0 4 0 v-14 a2 2 0 1 1 2 2 h-2 m2 -4 h-11 a3 3 0 0 0 -3 3 v11 M0 0 h24 v24 H0 z";
				case IconKind.LifebuoyOff:
					return "M3 3 l18 18 M18.35 5.65 l-3.35 3.35 M5.65 5.65 l3.35 3.35 M9 15 l-3.35 3.35 M15 15 l3.35 3.35 M5.64 5.632 a9 9 0 1 0 12.73 12.725 m1.667 -2.301 a9 9 0 0 0 -12.077 -12.1 M9.171 9.172 a4 4 0 0 0 5.65 5.663 m1.179 -2.835 a4 4 0 0 0 -4 -4 M0 0 h24 v24 H0 z";
				case IconKind.Lifebuoy:
					return "M18.35 5.65 l-3.35 3.35 M5.65 5.65 l3.35 3.35 M9 15 l-3.35 3.35 M15 15 l3.35 3.35 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M12 12 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M0 0 h24 v24 H0 z";
				case IconKind.LineDashed:
					return "M11 12 h2 M17 12 h2 M5 12 h2 M0 0 h24 v24 H0 z";
				case IconKind.LineDotted:
					return "M20 12 v0.01 M16 12 v0.01 M12 12 v0.01 M8 12 v0.01 M4 12 v0.01 M0 0 h24 v24 H0 z";
				case IconKind.LineHeight:
					return "M13 18 l7 0 M13 12 l7 0 M13 6 l7 0 M6 5 l0 14 M3 16 l3 3 l3 -3 M3 8 l3 -3 l3 3 M0 0 h24 v24 H0 z";
				case IconKind.Line:
					return "M7.5 16.5 l9 -9 M18 6 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.LinkOff:
					return "M3 3 l18 18 M3 3 l18 18 M9.548 9.544 a3.5 3.5 0 0 0 -0.548 0.456 l-4 4 a3.536 3.536 0 0 0 5 5 l0.5 -0.5 M10 14 a3.5 3.5 0 0 0 4.47 0.444 m2.025 -1.94 c0.557 -0.556 1.392 -1.39 2.505 -2.504 a3.536 3.536 0 0 0 -5 -5 l-0.5 0.5 M0 0 h24 v24 H0 z";
				case IconKind.Link:
					return "M14 10 a3.5 3.5 0 0 0 -5 0 l-4 4 a3.5 3.5 0 0 0 5 5 l0.5 -0.5 M10 14 a3.5 3.5 0 0 0 5 0 l4 -4 a3.5 3.5 0 0 0 -5 -5 l-0.5 0.5 M0 0 h24 v24 H0 z";
				case IconKind.ListCheck:
					return "M11 18 l9 0 M11 12 l9 0 M11 6 l9 0 M3.5 17.5 l1.5 1.5 l2.5 -2.5 M3.5 11.5 l1.5 1.5 l2.5 -2.5 M3.5 5.5 l1.5 1.5 l2.5 -2.5 M0 0 h24 v24 H0 z";
				case IconKind.ListDetails:
					return "M3 14 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M3 4 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M13 19 h5 M13 15 h8 M13 9 h5 M13 5 h8 M0 0 h24 v24 H0 z";
				case IconKind.ListNumbers:
					return "M6 10 v-6 l-2 2 M4 16 a2 2 0 1 1 4 0 c0 0.591 -0.5 1 -1 1.5 l-3 2.5 h4 M12 18 h8 M11 12 h9 M11 6 h9 M0 0 h24 v24 H0 z";
				case IconKind.ListSearch:
					return "M4 18 h4 M4 12 h4 M4 6 h16 M18.5 18.5 l2.5 2.5 M15 15 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M0 0 h24 v24 H0 z";
				case IconKind.List:
					return "M5 18 l0 0.01 M5 12 l0 0.01 M5 6 l0 0.01 M9 18 l11 0 M9 12 l11 0 M9 6 l11 0 M0 0 h24 v24 H0 z";
				case IconKind.LivePhotoOff:
					return "M3 3 l18 18 M12 21 v0.01 M8.1 20.11 v0.01 M4.96 17.61 v0.01 M3.23 14 v0.01 M3.23 10 v0.01 M4.96 6.39 v0.01 M8.1 3.89 v0.01 M12 3 v0.01 M15.9 3.89 v0.01 M19.04 6.39 v0.01 M20.77 10 v0.01 M20.77 14 v0.01 M19.04 17.61 v0.01 M15.9 20.11 v0.01 M8.473 8.456 a5 5 0 1 0 7.076 7.066 m1.365 -2.591 a5 5 0 0 0 -5.807 -5.851 M11.296 11.29 a1 1 0 1 0 1.414 1.415 M0 0 h24 v24 H0 z";
				case IconKind.LivePhoto:
					return "M12 21 l0 0.01 M8.1 20.11 l0 0.01 M4.96 17.61 l0 0.01 M3.23 14 l0 0.01 M3.23 10 l0 0.01 M4.96 6.39 l0 0.01 M8.1 3.89 l0 0.01 M12 3 l0 0.01 M15.9 3.89 l0 0.01 M19.04 6.39 l0 0.01 M20.77 10 l0 0.01 M20.77 14 l0 0.01 M19.04 17.61 l0 0.01 M15.9 20.11 l0 0.01 M12 12 m-5 0 a5 5 0 1 0 10 0 a5 5 0 1 0 -10 0 M12 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.LiveView:
					return "M12 18 l-3.5 -5 a4 4 0 1 1 7 0 l-3.5 5 M12 11 l0 0.01 M16 20 h2 a2 2 0 0 0 2 -2 v-2 M16 4 h2 a2 2 0 0 1 2 2 v2 M4 16 v2 a2 2 0 0 0 2 2 h2 M4 8 v-2 a2 2 0 0 1 2 -2 h2 M0 0 h24 v24 H0 z";
				case IconKind.Loader2:
					return "M12 3 a9 9 0 1 0 9 9 M0 0 h24 v24 H0 z";
				case IconKind.Loader3:
					return "M17 12 a5 5 0 1 0 -5 5 M3 12 a9 9 0 0 0 9 9 a9 9 0 0 0 9 -9 a9 9 0 0 0 -9 -9 M0 0 h24 v24 H0 z";
				case IconKind.LoaderQuarter:
					return "M7.75 7.75 l-2.15 -2.15 M6 12 l-3 0 M12 6 l0 -3 M0 0 h24 v24 H0 z";
				case IconKind.Loader:
					return "M7.75 7.75 l-2.15 -2.15 M6 12 l-3 0 M7.75 16.25 l-2.15 2.15 M12 18 l0 3 M16.25 16.25 l2.15 2.15 M18 12 l3 0 M16.25 7.75 l2.15 -2.15 M12 6 l0 -3 M0 0 h24 v24 H0 z";
				case IconKind.LocationBroken:
					return "M16 17 l4 4 m0 -4 l-4 4 M13 20 l-3 -6 l-7 -3.5 a0.55 0.55 0 0 1 0 -1 l18 -6.5 c-1.698 4.703 -3.05 8.37 -4 11 M0 0 h24 v24 H0 z";
				case IconKind.LocationFilled:
					return "M21 3 l-6.5 18 a0.55 0.55 0 0 1 -1 0 l-3.5 -7 l-7 -3.5 a0.55 0.55 0 0 1 0 -1 l18 -6.5 M0 0 h24 v24 H0 z";
				case IconKind.LocationOff:
					return "M3 3 l18 18 M10.72 6.712 l10.28 -3.712 l-3.724 10.313 m-1.056 2.925 l-1.72 4.762 a0.55 0.55 0 0 1 -1 0 l-3.5 -7 l-7 -3.5 a0.55 0.55 0 0 1 0 -1 l4.775 -1.724 M0 0 h24 v24 H0 z";
				case IconKind.Location:
					return "M21 3 l-6.5 18 a0.55 0.55 0 0 1 -1 0 l-3.5 -7 l-7 -3.5 a0.55 0.55 0 0 1 0 -1 l18 -6.5 M0 0 h24 v24 H0 z";
				case IconKind.LockAccessOff:
					return "M3 3 l18 18 M10 11 v-1 m1.182 -2.826 a2 2 0 0 1 2.818 1.826 v1 M15 11 a1 1 0 0 1 1 1 m-0.29 3.704 a1 1 0 0 1 -0.71 0.296 h-6 a1 1 0 0 1 -1 -1 v-3 a1 1 0 0 1 1 -1 h2 M16 20 h2 c0.55 0 1.05 -0.222 1.41 -0.582 M16 4 h2 a2 2 0 0 1 2 2 v2 M4 16 v2 a2 2 0 0 0 2 2 h2 M4 8 v-2 c0 -0.554 0.225 -1.055 0.588 -1.417 M0 0 h24 v24 H0 z";
				case IconKind.LockAccess:
					return "M10 11 v-2 a2 2 0 1 1 4 0 v2 M8 11 m0 1 a1 1 0 0 1 1 -1 h6 a1 1 0 0 1 1 1 v3 a1 1 0 0 1 -1 1 h-6 a1 1 0 0 1 -1 -1 z M16 20 h2 a2 2 0 0 0 2 -2 v-2 M16 4 h2 a2 2 0 0 1 2 2 v2 M4 16 v2 a2 2 0 0 0 2 2 h2 M4 8 v-2 a2 2 0 0 1 2 -2 h2 M0 0 h24 v24 H0 z";
				case IconKind.LockOff:
					return "M8 11 v-3 m0.712 -3.278 a4 4 0 0 1 7.288 2.278 v4 M12 16 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M19 19 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 v-6 a2 2 0 0 1 2 -2 h4 m4 0 h2 a2 2 0 0 1 2 2 v2 M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.LockOpenOff:
					return "M3 3 l18 18 M8 11 v-3 m0.347 -3.631 a4 4 0 0 1 7.653 1.631 M12 16 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M15 11 h2 a2 2 0 0 1 2 2 v2 m0 4 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 v-6 a2 2 0 0 1 2 -2 h4 M0 0 h24 v24 H0 z";
				case IconKind.LockOpen:
					return "M8 11 v-5 a4 4 0 0 1 8 0 M12 16 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M5 11 m0 2 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v6 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.LockSquareRoundedFilled:
					return "M12 2 c-0.218 0 -0.432 0.002 -0.642 0.005 l-0.616 0.017 l-0.299 0.013 l-0.579 0.034 l-0.553 0.046 c-4.785 0.464 -6.732 2.411 -7.196 7.196 l-0.046 0.553 l-0.034 0.579 c-0.005 0.098 -0.01 0.198 -0.013 0.299 l-0.017 0.616 l-0.004 0.318 l-0.001 0.324 c0 0.218 0.002 0.432 0.005 0.642 l0.017 0.616 l0.013 0.299 l0.034 0.579 l0.046 0.553 c0.464 4.785 2.411 6.732 7.196 7.196 l0.553 0.046 l0.579 0.034 c0.098 0.005 0.198 0.01 0.299 0.013 l0.616 0.017 l0.642 0.005 l0.642 -0.005 l0.616 -0.017 l0.299 -0.013 l0.579 -0.034 l0.553 -0.046 c4.785 -0.464 6.732 -2.411 7.196 -7.196 l0.046 -0.553 l0.034 -0.579 c0.005 -0.098 0.01 -0.198 0.013 -0.299 l0.017 -0.616 l0.005 -0.642 l-0.005 -0.642 l-0.017 -0.616 l-0.013 -0.299 l-0.034 -0.579 l-0.046 -0.553 c-0.464 -4.785 -2.411 -6.732 -7.196 -7.196 l-0.553 -0.046 l-0.579 -0.034 a28.058 28.058 0 0 0 -0.299 -0.013 l-0.616 -0.017 l-0.318 -0.004 l-0.324 -0.001 z m0 4 a3 3 0 0 1 2.995 2.824 l0.005 0.176 v1 a2 2 0 0 1 1.995 1.85 l0.005 0.15 v3 a2 2 0 0 1 -1.85 1.995 l-0.15 0.005 h-6 a2 2 0 0 1 -1.995 -1.85 l-0.005 -0.15 v-3 a2 2 0 0 1 1.85 -1.995 l0.15 -0.005 v-1 a3 3 0 0 1 3 -3 z m3 6 h-6 v3 h6 v-3 z m-3 -4 a1 1 0 0 0 -0.993 0.883 l-0.007 0.117 v1 h2 v-1 a1 1 0 0 0 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.LockSquareRounded:
					return "M10 11 v-2 a2 2 0 1 1 4 0 v2 M8 11 m0 1 a1 1 0 0 1 1 -1 h6 a1 1 0 0 1 1 1 v3 a1 1 0 0 1 -1 1 h-6 a1 1 0 0 1 -1 -1 z M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M0 0 h24 v24 H0 z";
				case IconKind.LockSquare:
					return "M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M10 11 v-2 a2 2 0 1 1 4 0 v2 M8 11 m0 1 a1 1 0 0 1 1 -1 h6 a1 1 0 0 1 1 1 v3 a1 1 0 0 1 -1 1 h-6 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.Lock:
					return "M8 11 v-4 a4 4 0 0 1 8 0 v4 M12 16 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M5 11 m0 2 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v6 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.LogicAnd:
					return "M9 5 c6 0 8 3.5 8 7 s-2 7 -8 7 h-2 v-14 h2 z M2 15 h5 M2 9 h5 M22 12 h-5 M0 0 h24 v24 H0 z";
				case IconKind.LogicBuffer:
					return "M7 5 l10 7 l-10 7 z M2 15 h5 M2 9 h5 M22 12 h-5 M0 0 h24 v24 H0 z";
				case IconKind.LogicNand:
					return "M17 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M7 5 c6 0 8 3.5 8 7 s-2 7 -8 7 h-2 v-14 h2 z M2 15 h3 M2 9 h3 M22 12 h-3 M0 0 h24 v24 H0 z";
				case IconKind.LogicNor:
					return "M16 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 5 c10.667 2.1 10.667 12.6 0 14 c1.806 -4.667 1.806 -9.333 0 -14 z M2 15 h5 M2 9 h5 M22 12 h-4 M0 0 h24 v24 H0 z";
				case IconKind.LogicNot:
					return "M17 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 5 l10 7 l-10 7 z M2 15 h3 M2 9 h3 M22 12 h-3 M0 0 h24 v24 H0 z";
				case IconKind.LogicOr:
					return "M8 5 c10.667 2.1 10.667 12.6 0 14 c1.806 -4.667 1.806 -9.333 0 -14 z M2 15 h7 M2 9 h7 M22 12 h-6 M0 0 h24 v24 H0 z";
				case IconKind.LogicXnor:
					return "M18 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M8 5 c10.667 2.1 10.667 12.6 0 14 c1.806 -4.667 1.806 -9.333 0 -14 z M5 19 c1.778 -4.667 1.778 -9.333 0 -14 M2 15 h4 M2 9 h4 M22 12 h-2 M0 0 h24 v24 H0 z";
				case IconKind.LogicXor:
					return "M10 5 c10.667 2.1 10.667 12.6 0 14 c1.806 -4.667 1.806 -9.333 0 -14 z M7 19 c1.778 -4.667 1.778 -9.333 0 -14 M2 15 h6 M2 9 h6 M22 12 h-4 M0 0 h24 v24 H0 z";
				case IconKind.Login:
					return "M20 12 h-13 l3 -3 m0 6 l-3 -3 M14 8 v-2 a2 2 0 0 0 -2 -2 h-7 a2 2 0 0 0 -2 2 v12 a2 2 0 0 0 2 2 h7 a2 2 0 0 0 2 -2 v-2 M0 0 h24 v24 H0 z";
				case IconKind.Logout:
					return "M7 12 h14 l-3 -3 m0 6 l3 -3 M14 8 v-2 a2 2 0 0 0 -2 -2 h-7 a2 2 0 0 0 -2 2 v12 a2 2 0 0 0 2 2 h7 a2 2 0 0 0 2 -2 v-2 M0 0 h24 v24 H0 z";
				case IconKind.LollipopOff:
					return "M3 3 l18 18 M3 21 l6 -6 M14 3 a3.5 3.5 0 0 0 -3.5 3.5 M14 17 c0.838 0 1.607 -0.294 2.209 -0.785 m1.291 -2.715 a3.5 3.5 0 0 0 -3.5 -3.5 M12.71 12.715 a3.5 3.5 0 0 1 -5.71 -2.715 M21 10 a3.5 3.5 0 0 0 -7 0 M7.462 7.493 a7 7 0 0 0 9.06 9.039 m2.416 -1.57 a7 7 0 1 0 -9.884 -9.915 M0 0 h24 v24 H0 z";
				case IconKind.Lollipop:
					return "M3 21 l6 -6 M14 3 a3.5 3.5 0 0 0 0 7 M14 17 a3.5 3.5 0 0 0 0 -7 M14 10 a3.5 3.5 0 0 1 -7 0 M21 10 a3.5 3.5 0 0 0 -7 0 M14 10 m-7 0 a7 7 0 1 0 14 0 a7 7 0 1 0 -14 0 M0 0 h24 v24 H0 z";
				case IconKind.LuggageOff:
					return "M3 3 l18 18 M15 20 v1 M9 20 v1 M6 16 h10 M6 10 h4 m4 0 h4 M9 5 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v1 M10 6 h6 a2 2 0 0 1 2 2 v6 m0 4 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 v-10 c0 -0.546 0.218 -1.04 0.573 -1.4 M0 0 h24 v24 H0 z";
				case IconKind.Luggage:
					return "M15 20 v1 M9 20 v1 M6 16 h12 M6 10 h12 M9 6 v-1 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v1 M6 6 m0 2 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.LungsOff:
					return "M3 3 l18 18 M12 4 v4 M9 12 a2.99 2.99 0 0 0 2.132 -0.89 M15 11 v-3.743 c0 -0.694 0.552 -1.257 1.233 -1.257 c0.204 0 0.405 0.052 0.584 0.15 l0.13 0.083 c1.46 1.059 2.432 2.647 3.405 5.824 c0.42 1.37 0.636 2.962 0.648 4.775 c0 0.063 0 0.125 0 0.187 m-1.455 2.51 c-0.417 0.265 -0.9 0.43 -1.419 0.464 l-0.202 0.007 c-1.613 0 -2.92 -1.335 -2.92 -2.98 v-2.02 M6.583 6.608 c-1.206 1.058 -2.07 2.626 -2.933 5.449 c-0.42 1.37 -0.636 2.962 -0.648 4.775 c-0.012 1.675 1.261 3.054 2.877 3.161 l0.203 0.007 c1.611 0 2.918 -1.335 2.918 -2.98 v-8.02 M0 0 h24 v24 H0 z";
				case IconKind.Lungs:
					return "M12 4 v5 M9 12 a3 3 0 0 0 3 -3 a3 3 0 0 0 3 3 M17.92 20 c-1.613 0 -2.92 -1.335 -2.92 -2.98 v-9.763 c0 -0.694 0.552 -1.257 1.233 -1.257 c0.204 0 0.405 0.052 0.584 0.15 l0.13 0.083 c1.46 1.059 2.432 2.647 3.405 5.824 c0.42 1.37 0.636 2.962 0.648 4.775 c0.012 1.675 -1.261 3.054 -2.878 3.161 l-0.202 0.007 z M6.081 20 c1.612 0 2.919 -1.335 2.919 -2.98 v-9.763 c0 -0.694 -0.552 -1.257 -1.232 -1.257 c-0.205 0 -0.405 0.052 -0.584 0.15 l-0.13 0.083 c-1.46 1.059 -2.432 2.647 -3.404 5.824 c-0.42 1.37 -0.636 2.962 -0.648 4.775 c-0.012 1.675 1.261 3.054 2.877 3.161 l0.203 0.007 z M0 0 h24 v24 H0 z";
				case IconKind.MacroOff:
					return "M3 3 l18 18 M10.866 10.87 a5.007 5.007 0 0 1 -3.734 -3.723 m-0.132 -4.147 l3 2 l2 -2 l2 2 l3 -2 v3 a5 5 0 0 1 -2.604 4.389 M12 21 v-10 M12 21 a6 6 0 0 0 -6 -6 M15.53 15.53 a6 6 0 0 0 -3.53 5.47 M6 15 a6 6 0 0 0 11.47 2.467 M0 0 h24 v24 H0 z";
				case IconKind.Macro:
					return "M12 11 a5 5 0 0 1 -5 -5 v-3 l3 2 l2 -2 l2 2 l3 -2 v3 a5 5 0 0 1 -5 5 z M12 21 v-10 M12 21 a6 6 0 0 0 -6 -6 M18 15 a6 6 0 0 0 -6 6 M6 15 a6 6 0 1 0 12 0 M0 0 h24 v24 H0 z";
				case IconKind.MagnetOff:
					return "M3 3 l18 18 M15 8 h4 M4 8 h4 M7 3 a2 2 0 0 1 2 2 m0 4 v4 a3 3 0 0 0 5.552 1.578 m0.448 -3.578 v-6 a2 2 0 0 1 2 -2 h1 a2 2 0 0 1 2 2 v8 a7.99 7.99 0 0 1 -0.424 2.577 m-1.463 2.584 a8 8 0 0 1 -14.113 -5.161 v-8 c0 -0.297 0.065 -0.58 0.181 -0.833 M0 0 h24 v24 H0 z";
				case IconKind.Magnet:
					return "M15 8 l4 0 M4 8 l5 0 M4 13 v-8 a2 2 0 0 1 2 -2 h1 a2 2 0 0 1 2 2 v8 a2 2 0 0 0 6 0 v-8 a2 2 0 0 1 2 -2 h1 a2 2 0 0 1 2 2 v8 a8 8 0 0 1 -16 0 M0 0 h24 v24 H0 z";
				case IconKind.MailFast:
					return "M9.8 7.5 l2.982 3.28 a3 3 0 0 0 4.238 0.202 l3.28 -2.982 M9.02 8.801 l-0.6 6 a2 2 0 0 0 1.99 2.199 h7.98 a2 2 0 0 0 1.99 -1.801 l0.6 -6 a2 2 0 0 0 -1.99 -2.199 h-7.98 a2 2 0 0 0 -1.99 1.801 z M3 11 h2 M3 7 h3 M0 0 h24 v24 H0 z";
				case IconKind.MailForward:
					return "M18 15 l3 3 l-3 3 M15 18 h6 M3 6 l9 6 l9 -6 M12 18 h-7 a2 2 0 0 1 -2 -2 v-10 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v7.5 M0 0 h24 v24 H0 z";
				case IconKind.MailOff:
					return "M3 3 l18 18 M3 7 l9 6 l0.598 -0.399 m2.402 -1.601 l6 -4 M9 5 h10 a2 2 0 0 1 2 2 v10 m-2 2 h-14 a2 2 0 0 1 -2 -2 v-10 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.MailOpened:
					return "M15 13 l6 6 M3 19 l6 -6 M21 9 v10 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 v-10 M3 9 l9 6 l9 -6 l-9 -6 l-9 6 M0 0 h24 v24 H0 z";
				case IconKind.Mail:
					return "M3 7 l9 6 l9 -6 M3 5 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.MailboxOff:
					return "M3 3 l18 18 M6 15 h1 M12 8 v-5 h4 l2 2 l-2 2 h-4 M10 21 v-6.5 a3.5 3.5 0 0 0 -7 0 v6.5 h18 m0 -4 v-2 a4 4 0 0 0 -4 -4 h-2 m-4 0 h-4.5 M0 0 h24 v24 H0 z";
				case IconKind.Mailbox:
					return "M6 15 h1 M12 11 v-8 h4 l2 2 l-2 2 h-4 M10 21 v-6.5 a3.5 3.5 0 0 0 -7 0 v6.5 h18 v-6 a4 4 0 0 0 -4 -4 h-10.5 M0 0 h24 v24 H0 z";
				case IconKind.Man:
					return "M12 4 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M19 11 c-1.333 -1.333 -2.667 -2 -4 -2 M5 11 c1.333 -1.333 2.667 -2 4 -2 M9 9 h6 l-1 7 h-4 z M14 16 v5 M10 16 v5 M0 0 h24 v24 H0 z";
				case IconKind.ManualGearbox:
					return "M19 8 v2 a2 2 0 0 1 -2 2 h-12 M12 8 l0 8 M5 8 l0 8 M12 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M19 6 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M12 6 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 6 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Map2:
					return "M15 15 l0 5 M9 4 l0 13 M10.5 4.75 l-1.5 -0.75 l-6 3 l0 13 l6 -3 l6 3 l6 -3 l0 -2 M18 13 l-3.5 -5 a4 4 0 1 1 7 0 l-3.5 5 M18 6 l0 0.01 M0 0 h24 v24 H0 z";
				case IconKind.MapOff:
					return "M3 3 l18 18 M15 7 v4 m0 4 v5 M9 4 v1 m0 4 v8 M8.32 4.34 l0.68 -0.34 l6 3 l6 -3 v13 m-2.67 1.335 l-3.33 1.665 l-6 -3 l-6 3 v-13 l2.665 -1.333 M0 0 h24 v24 H0 z";
				case IconKind.MapPinFilled:
					return "M17.657 16.657 l-4.243 4.243 a2 2 0 0 1 -2.827 0 l-4.244 -4.243 a8 8 0 1 1 11.314 0 m-8.657 -5.657 a3 3 0 0 0 6 0 a3 3 0 0 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.MapPinOff:
					return "M8.048 4.042 a8 8 0 0 1 10.912 10.908 m-1.8 2.206 l-3.745 3.744 a2 2 0 0 1 -2.827 0 l-4.244 -4.243 a8 8 0 0 1 -0.48 -10.79 M9.44 9.435 a3 3 0 0 0 4.126 4.124 m1.434 -2.559 a3 3 0 0 0 -3 -3 M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.MapPin:
					return "M17.657 16.657 l-4.243 4.243 a2 2 0 0 1 -2.827 0 l-4.244 -4.243 a8 8 0 1 1 11.314 0 z M12 11 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.MapPins:
					return "M16 15 l0 0.01 M18.828 17.828 a4 4 0 1 0 -5.656 0 l2.828 2.829 l2.828 -2.829 z M8 7 l0 0.01 M10.828 9.828 a4 4 0 1 0 -5.656 0 l2.828 2.829 l2.828 -2.829 z M0 0 h24 v24 H0 z";
				case IconKind.MapSearch:
					return "M18.5 19.5 l2.5 2.5 M16.5 17.5 m-2.5 0 a2.5 2.5 0 1 0 5 0 a2.5 2.5 0 1 0 -5 0 M15 7 v5 M9 4 v13 M11 18 l-2 -1 l-6 3 v-13 l6 -3 l6 3 l6 -3 v10 M0 0 h24 v24 H0 z";
				case IconKind.Map:
					return "M15 7 l0 13 M9 4 l0 13 M3 7 l6 -3 l6 3 l6 -3 l0 13 l-6 3 l-6 -3 l-6 3 l0 -13 M0 0 h24 v24 H0 z";
				case IconKind.MarkdownOff:
					return "M3 3 l18 18 M17.5 13.5 l0.5 -0.5 m-2 -1 v-3 M7 15 v-6 l2 2 l1 -1 m1 1 v4 M19 19 h-14 a2 2 0 0 1 -2 -2 v-10 a2 2 0 0 1 1.85 -2 M9 5 h10 a2 2 0 0 1 2 2 v10 M0 0 h24 v24 H0 z";
				case IconKind.Markdown:
					return "M14 13 l2 2 l2 -2 m-2 2 v-6 M7 15 v-6 l2 2 l2 -2 v6 M3 5 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Marquee2:
					return "M4 6 v-1 a1 1 0 0 1 1 -1 h1 m5 0 h2 m5 0 h1 a1 1 0 0 1 1 1 v1 m0 5 v2 m0 5 v1 a1 1 0 0 1 -1 1 h-1 m-5 0 h-2 m-5 0 h-1 a1 1 0 0 1 -1 -1 v-1 m0 -5 v-2 M0 0 h24 v24 H0 z";
				case IconKind.MarqueeOff:
					return "M3 3 l18 18 M4 10.5 v-1.5 M4 15 v-1.5 M6 20 a2 2 0 0 1 -2 -2 M10.5 20 h-1.5 M15 20 h-1.5 M19.402 19.426 a1.993 1.993 0 0 1 -1.402 0.574 M20 13.5 v1.5 M20 9 v1.5 M18 4 a2 2 0 0 1 2 2 M13.5 4 h1.5 M9 4 h1.5 M4 6 c0 -0.556 0.227 -1.059 0.593 -1.421 M0 0 h24 v24 H0 z";
				case IconKind.Marquee:
					return "M4 6 a2 2 0 0 1 2 -2 m3 0 h1.5 m3 0 h1.5 m3 0 a2 2 0 0 1 2 2 m0 3 v1.5 m0 3 v1.5 m0 3 a2 2 0 0 1 -2 2 m-3 0 h-1.5 m-3 0 h-1.5 m-3 0 a2 2 0 0 1 -2 -2 m0 -3 v-1.5 m0 -3 v-1.5 m0 -3 M0 0 h24 v24 H0 z";
				case IconKind.Mars:
					return "M19 5 l0 5 M19 5 l-5 0 M19 5 l-5.4 5.4 M10 14 m-5 0 a5 5 0 1 0 10 0 a5 5 0 1 0 -10 0 M0 0 h24 v24 H0 z";
				case IconKind.MaskOff:
					return "M3 3 l18 18 M9.885 9.872 a3 3 0 1 0 4.245 4.24 m0.582 -3.396 a3.012 3.012 0 0 0 -1.438 -1.433 M19.42 19.41 a2 2 0 0 1 -1.42 0.59 h-12 a2 2 0 0 1 -2 -2 v-12 c0 -0.554 0.225 -1.055 0.588 -1.417 m3.412 -0.583 h10 a2 2 0 0 1 2 2 v10 M0 0 h24 v24 H0 z";
				case IconKind.Mask:
					return "M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M12 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.MasksTheaterOff:
					return "M3 3 l18 18 M6 12 c0.764 -0.51 1.528 -0.63 2.291 -0.36 M6 8 h0.01 M8.632 15.982 a4.05 4.05 0 0 1 -0.382 0.018 h-1.5 a4 4 0 0 1 -3.983 -3.635 l-0.567 -6.182 a2 2 0 0 1 0.514 -1.531 a1.99 1.99 0 0 1 1.286 -0.652 m4 0 h2.808 a2 2 0 0 1 2 2 M15 16.5 c0.657 0.438 1.313 0.588 1.97 0.451 M18 13 h0.01 M13 9 c0.058 0 0.133 0 0.192 0 h6.616 a2 2 0 0 1 1.992 2.183 l-0.554 6.041 m-1.286 2.718 a3.99 3.99 0 0 1 -2.71 1.058 h-1.5 a4 4 0 0 1 -3.983 -3.635 l-0.567 -6.182 M0 0 h24 v24 H0 z";
				case IconKind.MasksTheater:
					return "M6 12 c0.764 -0.51 1.528 -0.63 2.291 -0.36 M9 8 h0.01 M6 8 h0.01 M8.632 15.982 a4.037 4.037 0 0 1 -0.382 0.018 h-1.5 a4 4 0 0 1 -3.983 -3.635 l-0.567 -6.182 a2 2 0 0 1 1.992 -2.183 h6.616 a2 2 0 0 1 2 2 M15 16.5 c1 0.667 2 0.667 3 0 M18 13 h0.01 M15 13 h0.01 M13.192 9 h6.616 a2 2 0 0 1 1.992 2.183 l-0.567 6.182 a4 4 0 0 1 -3.983 3.635 h-1.5 a4 4 0 0 1 -3.983 -3.635 l-0.567 -6.182 a2 2 0 0 1 1.992 -2.183 z M0 0 h24 v24 H0 z";
				case IconKind.Massage:
					return "M8 14 l3 -2 l1 -4 c3 1 3 4 3 6 M11 20 h9 M4 22 l4 -2 v-3 h12 M9 5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M4 17 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.Matchstick:
					return "M17 3 l3.62 7.29 a4.007 4.007 0 0 1 -0.764 4.51 a4 4 0 0 1 -6.493 -4.464 l3.637 -7.336 z M17 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M3 21 l14 -9 M0 0 h24 v24 H0 z";
				case IconKind.Math1Divide2:
					return "M10 5 l2 -2 v6 M10 15 h3 a1 1 0 0 1 1 1 v1 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 0 -1 1 v1 a1 1 0 0 0 1 1 h3 M5 12 h14 M0 0 h24 v24 H0 z";
				case IconKind.Math1Divide3:
					return "M10 5 l2 -2 v6 M5 12 h14 M10 15.5 a0.5 0.5 0 0 1 0.5 -0.5 h2 a1.5 1.5 0 0 1 0 3 h-1.167 h1.167 a1.5 1.5 0 0 1 0 3 h-2 a0.5 0.5 0 0 1 -0.5 -0.5 M0 0 h24 v24 H0 z";
				case IconKind.MathAvg:
					return "M12 12 m-8 0 a8 8 0 1 0 16 0 a8 8 0 1 0 -16 0 M3 21 l18 -18 M0 0 h24 v24 H0 z";
				case IconKind.MathEqualGreater:
					return "M5 14 l14 -4 l-14 -4 M5 18 l14 -4 M0 0 h24 v24 H0 z";
				case IconKind.MathEqualLower:
					return "M19 14 l-14 -4 l14 -4 M19 18 l-14 -4 M0 0 h24 v24 H0 z";
				case IconKind.MathFunctionOff:
					return "M3 3 l18 18 M5 12 h6 M3 19 c0 1.5 0.5 2 2 2 s2 -4 3 -9 c0.237 -1.186 0.446 -2.317 0.647 -3.35 m0.727 -3.248 c0.423 -1.492 0.91 -2.402 1.626 -2.402 c1.5 0 2 0.5 2 2 M13 17 c0.864 0 1.727 -0.663 2.495 -1.512 m1.717 -2.302 c0.993 -1.45 2.39 -3.186 3.788 -3.186 M14 10 h1 c0.882 0 0.986 0.777 1.694 2.692 M0 0 h24 v24 H0 z";
				case IconKind.MathFunctionY:
					return "M21 12 l-4.8 9 M15 12 l3 5.063 M5 12 h6 M3 19 a2 2 0 0 0 2 2 c2 0 2 -4 3 -9 s1 -9 3 -9 a2 2 0 0 1 2 2 M0 0 h24 v24 H0 z";
				case IconKind.MathFunction:
					return "M15 18 l6 -6 M15 12 l6 6 M5 12 h6 M3 19 a2 2 0 0 0 2 2 c2 0 2 -4 3 -9 s1 -9 3 -9 a2 2 0 0 1 2 2 M0 0 h24 v24 H0 z";
				case IconKind.MathGreater:
					return "M5 18 l14 -6 l-14 -6 M0 0 h24 v24 H0 z";
				case IconKind.MathIntegralX:
					return "M14 18 l6 -6 M14 12 l6 6 M3 19 a2 2 0 0 0 2 2 c2 0 2 -4 3 -9 s1 -9 3 -9 a2 2 0 0 1 2 2 M0 0 h24 v24 H0 z";
				case IconKind.MathIntegral:
					return "M7 19 a2 2 0 0 0 2 2 c2 0 2 -4 3 -9 s1 -9 3 -9 a2 2 0 0 1 2 2 M0 0 h24 v24 H0 z";
				case IconKind.MathIntegrals:
					return "M11 19 a2 2 0 0 0 2 2 c2 0 2 -4 3 -9 s1 -9 3 -9 a2 2 0 0 1 2 2 M3 19 a2 2 0 0 0 2 2 c2 0 2 -4 3 -9 s1 -9 3 -9 a2 2 0 0 1 2 2 M0 0 h24 v24 H0 z";
				case IconKind.MathLower:
					return "M19 18 l-14 -6 l14 -6 M0 0 h24 v24 H0 z";
				case IconKind.MathMax:
					return "M3 20 c0 -8.75 4 -14 7 -14.5 m4 0 c3 0.5 7 5.75 7 14.5 M12 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.MathMin:
					return "M14 18.5 c3 -0.5 7 -5.75 7 -14.5 M3 4 c0 8.75 4 14 7 14.5 M12 17 a2 2 0 1 1 0 4 a2 2 0 0 1 0 -4 z M0 0 h24 v24 H0 z";
				case IconKind.MathNot:
					return "M5 12 h14 v4 M0 0 h24 v24 H0 z";
				case IconKind.MathOff:
					return "M10.448 10.431 l-2.448 8.569 l-3 -6 h-2 M19 5 h-7 l-0.646 2.262 M3 3 l18 18 M18.5 14.5 l1.5 -1.5 M14 19 l2.5 -2.5 M0 0 h24 v24 H0 z";
				case IconKind.MathPiDivide2:
					return "M15 3 h-6 M14 3 v6 M10 9 v-6 M5 12 h14 M10 15 h3 a1 1 0 0 1 1 1 v1 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 0 -1 1 v1 a1 1 0 0 0 1 1 h3 M0 0 h24 v24 H0 z";
				case IconKind.MathPi:
					return "M20 4 h-16 M17 4 v16 M7 20 v-16 M0 0 h24 v24 H0 z";
				case IconKind.MathSymbols:
					return "M4 18 l4 0 M18 20 l0.01 0 M18 16 l0.01 0 M4 6 l4 0 M6 4 l0 4 M19.5 4.5 l-3 3 M16.5 4.5 l3 3 M12 3 l0 18 M3 12 l18 0 M0 0 h24 v24 H0 z";
				case IconKind.MathXDivide2:
					return "M9 9 l6 -6 M9 3 l6 6 M5 12 h14 M10 15 h3 a1 1 0 0 1 1 1 v1 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 0 -1 1 v1 a1 1 0 0 0 1 1 h3 M0 0 h24 v24 H0 z";
				case IconKind.MathXDivideY2:
					return "M3 10 l6 -6 M3 4 l6 6 M21 14 l-4.5 7 M15 14 l3 4.5 M3 21 l18 -18 M0 0 h24 v24 H0 z";
				case IconKind.MathXDivideY:
					return "M5 12 h14 M15 15 l-4.5 7 M9 15 l3 4.5 M9 9 l6 -6 M9 3 l6 6 M0 0 h24 v24 H0 z";
				case IconKind.MathXMinusX:
					return "M10 12 h4 M16 15 l6 -6 M16 9 l6 6 M2 15 l6 -6 M2 9 l6 6 M0 0 h24 v24 H0 z";
				case IconKind.MathXMinusY:
					return "M10 12 h4 M22 9 l-4.8 9 M16 9 l3 5.063 M2 15 l6 -6 M2 9 l6 6 M0 0 h24 v24 H0 z";
				case IconKind.MathXPlusX:
					return "M12 10 v4 M10 12 h4 M16 15 l6 -6 M16 9 l6 6 M2 15 l6 -6 M2 9 l6 6 M0 0 h24 v24 H0 z";
				case IconKind.MathXPlusY:
					return "M12 10 v4 M10 12 h4 M22 9 l-4.8 9 M2 15 l6 -6 M2 9 l6 6 M16 9 l3 5.063 M0 0 h24 v24 H0 z";
				case IconKind.MathXy:
					return "M20 9 l-4.8 9 M4 15 l6 -6 M4 9 l6 6 M14 9 l3 5.063 M0 0 h24 v24 H0 z";
				case IconKind.MathYMinusY:
					return "M10 12 h4 M22 9 l-4.8 9 M16 9 l3 5.063 M8 9 l-4.8 9 M2 9 l3 5.063 M0 0 h24 v24 H0 z";
				case IconKind.MathYPlusY:
					return "M12 10 v4 M10 12 h4 M22 9 l-4.8 9 M16 9 l3 5.063 M8 9 l-4.8 9 M2 9 l3 5.063 M0 0 h24 v24 H0 z";
				case IconKind.Math:
					return "M14 19 l6 -6 M14 13 l6 6 M19 5 h-7 l-4 14 l-3 -6 h-2 M0 0 h24 v24 H0 z";
				case IconKind.MaximizeOff:
					return "M3 3 l18 18 M16 20 h2 c0.545 0 1.04 -0.218 1.4 -0.572 M16 4 h2 a2 2 0 0 1 2 2 v2 M4 16 v2 a2 2 0 0 0 2 2 h2 M4 8 v-2 c0 -0.551 0.223 -1.05 0.584 -1.412 M0 0 h24 v24 H0 z";
				case IconKind.Maximize:
					return "M16 20 h2 a2 2 0 0 0 2 -2 v-2 M16 4 h2 a2 2 0 0 1 2 2 v2 M4 16 v2 a2 2 0 0 0 2 2 h2 M4 8 v-2 a2 2 0 0 1 2 -2 h2 M0 0 h24 v24 H0 z";
				case IconKind.MeatOff:
					return "M3 3 l18 18 M8.274 8.284 c-1.792 0.563 -3.616 1.66 -5.198 3.242 M16.6 12.6 c-0.16 -1.238 -0.653 -2.345 -1.504 -3.195 c-0.85 -0.85 -1.955 -1.344 -3.192 -1.503 M12.975 21.425 c1.582 -1.582 2.679 -3.407 3.242 -5.2 M7.5 16 l1 1 M5.904 18.596 c2.733 2.734 5.9 4 7.07 2.829 c1.172 -1.172 -0.094 -4.338 -2.828 -7.071 c-2.733 -2.734 -5.9 -4 -7.07 -2.829 c-1.172 1.172 0.094 4.338 2.828 7.071 z M13.62 8.382 l1.966 -1.967 a2 2 0 1 1 3.414 -1.415 a2 2 0 1 1 -1.413 3.414 l-1.82 1.821 M0 0 h24 v24 H0 z";
				case IconKind.Meat:
					return "M12.975 21.425 c3.905 -3.906 4.855 -9.288 2.121 -12.021 c-2.733 -2.734 -8.115 -1.784 -12.02 2.121 M7.5 16 l1 1 M5.904 18.596 c2.733 2.734 5.9 4 7.07 2.829 c1.172 -1.172 -0.094 -4.338 -2.828 -7.071 c-2.733 -2.734 -5.9 -4 -7.07 -2.829 c-1.172 1.172 0.094 4.338 2.828 7.071 z M13.62 8.382 l1.966 -1.967 a2 2 0 1 1 3.414 -1.415 a2 2 0 1 1 -1.413 3.414 l-1.82 1.821 M0 0 h24 v24 H0 z";
				case IconKind.Medal2:
					return "M12 19.5 l-3 1.5 l0.5 -3.5 l-2 -2 l3 -0.5 l1.5 -3 l1.5 3 l3 0.5 l-2 2 l0.5 3.5 z M15 11 l-3 -8 M12 12 l-3 -9 M9 3 h6 l3 7 l-6 2 l-6 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Medal:
					return "M12 18.5 l-3 1.5 l0.5 -3.5 l-2 -2 l3 -0.5 l1.5 -3 l1.5 3 l3 0.5 l-2 2 l0.5 3.5 z M12 4 v3 m-4 -3 v6 m8 -6 v6 M0 0 h24 v24 H0 z";
				case IconKind.MedicalCrossFilled:
					return "M13 3 a1 1 0 0 1 1 1 v4.535 l3.928 -2.267 a1 1 0 0 1 1.366 0.366 l1 1.732 a1 1 0 0 1 -0.366 1.366 l-3.927 2.268 l3.927 2.269 a1 1 0 0 1 0.366 1.366 l-1 1.732 a1 1 0 0 1 -1.366 0.366 l-3.928 -2.269 v4.536 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 v-4.536 l-3.928 2.268 a1 1 0 0 1 -1.366 -0.366 l-1 -1.732 a1 1 0 0 1 0.366 -1.366 l3.927 -2.268 l-3.927 -2.268 a1 1 0 0 1 -0.366 -1.366 l1 -1.732 a1 1 0 0 1 1.366 -0.366 l3.928 2.267 v-4.535 a1 1 0 0 1 1 -1 h2 z M0 0 h24 v24 H0 z";
				case IconKind.MedicalCrossOff:
					return "M3 3 l18 18 M17.928 17.733 l-0.574 -0.331 l-3.354 -1.938 v4.536 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 v-4.536 l-3.928 2.268 a1 1 0 0 1 -1.366 -0.366 l-1 -1.732 a1 1 0 0 1 0.366 -1.366 l3.927 -2.268 l-3.927 -2.268 a1 1 0 0 1 -0.366 -1.366 l1 -1.732 a1 1 0 0 1 1.366 -0.366 l0.333 0.192 m3.595 -0.46 v-2 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v4.535 l3.928 -2.267 a1 1 0 0 1 1.366 0.366 l1 1.732 a1 1 0 0 1 -0.366 1.366 l-3.927 2.268 l3.927 2.269 a1 1 0 0 1 0.366 1.366 l-0.24 0.416 M0 0 h24 v24 H0 z";
				case IconKind.MedicalCross:
					return "M13 3 a1 1 0 0 1 1 1 v4.535 l3.928 -2.267 a1 1 0 0 1 1.366 0.366 l1 1.732 a1 1 0 0 1 -0.366 1.366 l-3.927 2.268 l3.927 2.269 a1 1 0 0 1 0.366 1.366 l-1 1.732 a1 1 0 0 1 -1.366 0.366 l-3.928 -2.269 v4.536 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 v-4.536 l-3.928 2.268 a1 1 0 0 1 -1.366 -0.366 l-1 -1.732 a1 1 0 0 1 0.366 -1.366 l3.927 -2.268 l-3.927 -2.268 a1 1 0 0 1 -0.366 -1.366 l1 -1.732 a1 1 0 0 1 1.366 -0.366 l3.928 2.267 v-4.535 a1 1 0 0 1 1 -1 h2 z M0 0 h24 v24 H0 z";
				case IconKind.MedicineSyrup:
					return "M10 7 v-3 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v3 M12 12 v4 M10 14 h4 M8 21 h8 a1 1 0 0 0 1 -1 v-10 a3 3 0 0 0 -3 -3 h-4 a3 3 0 0 0 -3 3 v10 a1 1 0 0 0 1 1 z M0 0 h24 v24 H0 z";
				case IconKind.Meeple:
					return "M9 20 h-5 a1 1 0 0 1 -1 -1 c0 -2 3.378 -4.907 4 -6 c-1 0 -4 -0.5 -4 -2 c0 -2 4 -3.5 6 -4 c0 -1.5 0.5 -4 3 -4 s3 2.5 3 4 c2 0.5 6 2 6 4 c0 1.5 -3 2 -4 2 c0.622 1.093 4 4 4 6 a1 1 0 0 1 -1 1 h-5 c-1 0 -2 -4 -3 -4 s-2 4 -3 4 z M0 0 h24 v24 H0 z";
				case IconKind.Menorah:
					return "M10 20 h4 M4 4 v2 a8 8 0 1 0 16 0 v-2 M8 4 v2 a4 4 0 1 0 8 0 v-2 M12 4 v16 M0 0 h24 v24 H0 z";
				case IconKind.Menu2:
					return "M4 18 l16 0 M4 12 l16 0 M4 6 l16 0 M0 0 h24 v24 H0 z";
				case IconKind.MenuOrder:
					return "M9 6 l3 -3 l3 3 M9 18 l3 3 l3 -3 M4 14 h16 M4 10 h16 M0 0 h24 v24 H0 z";
				case IconKind.Menu:
					return "M4 16 l16 0 M4 8 l16 0 M0 0 h24 v24 H0 z";
				case IconKind.Message2Code:
					return "M14 9 l2 2 l-2 2 M10 9 l-2 2 l2 2 M12 20 l-3 -3 h-2 a3 3 0 0 1 -3 -3 v-6 a3 3 0 0 1 3 -3 h10 a3 3 0 0 1 3 3 v6 a3 3 0 0 1 -3 3 h-2 l-3 3 M0 0 h24 v24 H0 z";
				case IconKind.Message2Off:
					return "M3 3 l18 18 M8 13 h5 M8 9 h1 m4 0 h3 M9 5 h8 a3 3 0 0 1 3 3 v6 a2.97 2.97 0 0 1 -0.44 1.563 m-2.56 1.437 h-2 l-3 3 l-3 -3 h-2 a3 3 0 0 1 -3 -3 v-6 c0 -1.092 0.584 -2.049 1.457 -2.573 M0 0 h24 v24 H0 z";
				case IconKind.Message2Share:
					return "M16 9 l5 -5 M20 11 v3 a3 3 0 0 1 -3 3 h-2 l-3 3 l-3 -3 h-2 a3 3 0 0 1 -3 -3 v-6 a3 3 0 0 1 3 -3 h7 M17 4 h4 v4 M0 0 h24 v24 H0 z";
				case IconKind.Message2:
					return "M8 13 l6 0 M8 9 l8 0 M12 20 l-3 -3 h-2 a3 3 0 0 1 -3 -3 v-6 a3 3 0 0 1 3 -3 h10 a3 3 0 0 1 3 3 v6 a3 3 0 0 1 -3 3 h-2 l-3 3 M0 0 h24 v24 H0 z";
				case IconKind.MessageChatbot:
					return "M9.5 13 a3.5 3.5 0 0 0 5 0 M14.5 9 h0.01 M9.5 9 h0.01 M4 21 v-13 a3 3 0 0 1 3 -3 h10 a3 3 0 0 1 3 3 v6 a3 3 0 0 1 -3 3 h-9 l-4 4 M0 0 h24 v24 H0 z";
				case IconKind.MessageCircle2Filled:
					return "M3 20 l1.3 -3.9 a9 8 0 1 1 3.4 2.9 l-4.7 1 M0 0 h24 v24 H0 z";
				case IconKind.MessageCircle2:
					return "M3 20 l1.3 -3.9 a9 8 0 1 1 3.4 2.9 l-4.7 1 M0 0 h24 v24 H0 z";
				case IconKind.MessageCircleOff:
					return "M8.585 4.581 c3.225 -1.181 7.032 -0.616 9.66 1.626 c2.983 2.543 3.602 6.525 1.634 9.662 m-1.908 2.108 c-2.786 2.19 -6.89 2.665 -10.271 1.023 l-4.7 1 l1.3 -3.9 c-2.237 -3.308 -1.489 -7.54 1.714 -10.084 M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.MessageCircle:
					return "M16 12 l0 0.01 M8 12 l0 0.01 M12 12 l0 0.01 M3 20 l1.3 -3.9 a9 8 0 1 1 3.4 2.9 l-4.7 1 M0 0 h24 v24 H0 z";
				case IconKind.MessageCode:
					return "M14 9 l2 2 l-2 2 M10 9 l-2 2 l2 2 M4 21 v-13 a3 3 0 0 1 3 -3 h10 a3 3 0 0 1 3 3 v6 a3 3 0 0 1 -3 3 h-9 l-4 4 M0 0 h24 v24 H0 z";
				case IconKind.MessageDots:
					return "M16 11 l0 0.01 M8 11 l0 0.01 M12 11 l0 0.01 M4 21 v-13 a3 3 0 0 1 3 -3 h10 a3 3 0 0 1 3 3 v6 a3 3 0 0 1 -3 3 h-9 l-4 4 M0 0 h24 v24 H0 z";
				case IconKind.MessageForward:
					return "M15 11 h-6 M13 9 l2 2 l-2 2 M4 21 v-13 a3 3 0 0 1 3 -3 h10 a3 3 0 0 1 3 3 v6 a3 3 0 0 1 -3 3 h-9 l-4 4 M0 0 h24 v24 H0 z";
				case IconKind.MessageLanguage:
					return "M14 12 h-4 M10 14 v-4 a2 2 0 1 1 4 0 v4 M4 21 v-13 a3 3 0 0 1 3 -3 h10 a3 3 0 0 1 3 3 v6 a3 3 0 0 1 -3 3 h-9 l-4 4 M0 0 h24 v24 H0 z";
				case IconKind.MessageOff:
					return "M17 17 h-9 l-4 4 v-13 c0 -1.086 0.577 -2.036 1.44 -2.563 m3.561 -0.437 h8 a3 3 0 0 1 3 3 v6 c0 0.575 -0.162 1.112 -0.442 1.568 M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.MessagePlus:
					return "M12 9 l0 4 M10 11 l4 0 M4 21 v-13 a3 3 0 0 1 3 -3 h10 a3 3 0 0 1 3 3 v6 a3 3 0 0 1 -3 3 h-9 l-4 4 M0 0 h24 v24 H0 z";
				case IconKind.MessageReport:
					return "M12 14 l0 0.01 M12 8 l0 3 M4 21 v-13 a3 3 0 0 1 3 -3 h10 a3 3 0 0 1 3 3 v6 a3 3 0 0 1 -3 3 h-9 l-4 4 M0 0 h24 v24 H0 z";
				case IconKind.MessageShare:
					return "M16 9 l5 -5 M17 4 h4 v4 M20 11 v3 a3 3 0 0 1 -3 3 h-9 l-4 4 v-13 a3 3 0 0 1 3 -3 h7 M0 0 h24 v24 H0 z";
				case IconKind.Message:
					return "M8 13 l6 0 M8 9 l8 0 M4 21 v-13 a3 3 0 0 1 3 -3 h10 a3 3 0 0 1 3 3 v6 a3 3 0 0 1 -3 3 h-9 l-4 4 M0 0 h24 v24 H0 z";
				case IconKind.MessagesOff:
					return "M14 15 v2 a1 1 0 0 1 -1 1 h-7 l-3 3 v-10 a1 1 0 0 1 1 -1 h2 M11 11 a1 1 0 0 1 -1 -1 m0 -3.968 v-2.032 a1 1 0 0 1 1 -1 h9 a1 1 0 0 1 1 1 v10 l-3 -3 h-3 M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.Messages:
					return "M14 15 v2 a1 1 0 0 1 -1 1 h-7 l-3 3 v-10 a1 1 0 0 1 1 -1 h2 M21 14 l-3 -3 h-7 a1 1 0 0 1 -1 -1 v-6 a1 1 0 0 1 1 -1 h9 a1 1 0 0 1 1 1 v10 M0 0 h24 v24 H0 z";
				case IconKind.MeteorOff:
					return "M3 3 l18 18 M9.5 14.5 m-2.5 0 a2.5 2.5 0 1 0 5 0 a2.5 2.5 0 1 0 -5 0 M9.75 5.761 l3.25 -2.761 l-1 5 l9 -5 l-5 9 h5 l-2.467 2.536 m-1.983 2.04 l-2.441 2.51 a6.5 6.5 0 1 1 -8.855 -9.506 l2.322 -1.972 M0 0 h24 v24 H0 z";
				case IconKind.Meteor:
					return "M9.5 14.5 m-2.5 0 a2.5 2.5 0 1 0 5 0 a2.5 2.5 0 1 0 -5 0 M21 3 l-5 9 h5 l-6.891 7.086 a6.5 6.5 0 1 1 -8.855 -9.506 l7.746 -6.58 l-1 5 l9 -5 z M0 0 h24 v24 H0 z";
				case IconKind.MickeyFilled:
					return "M5.5 3 a3.5 3.5 0 0 1 3.25 4.8 a7.017 7.017 0 0 0 -2.424 2.1 a3.5 3.5 0 1 1 -0.826 -6.9 z m13 0 a3.5 3.5 0 1 1 -0.826 6.902 a7.013 7.013 0 0 0 -2.424 -2.103 a3.5 3.5 0 0 1 3.25 -4.799 z m-6.5 11 m-7 0 a7 7 0 1 0 14 0 a7 7 0 1 0 -14 0 M0 0 h24 v24 H0 z";
				case IconKind.Mickey:
					return "M12 14 m-7 0 a7 7 0 1 0 14 0 a7 7 0 1 0 -14 0 M18.5 3 a3.5 3.5 0 1 1 -0.826 6.902 a7.013 7.013 0 0 0 -2.424 -2.103 a3.5 3.5 0 0 1 3.25 -4.799 z M5.5 3 a3.5 3.5 0 0 1 3.25 4.8 a7.017 7.017 0 0 0 -2.424 2.1 a3.5 3.5 0 1 1 -0.826 -6.9 z M0 0 h24 v24 H0 z";
				case IconKind.Microphone2Off:
					return "M3 3 l18 18 M10.116 10.125 l-6.529 7.46 a2 2 0 1 0 2.827 2.83 l7.461 -6.529 M16.908 12.917 a5 5 0 1 0 -5.827 -5.819 M0 0 h24 v24 H0 z";
				case IconKind.Microphone2:
					return "M15 12.9 l-3.902 -3.899 l-7.513 8.584 a2 2 0 1 0 2.827 2.83 l8.588 -7.515 z M15 12.9 a5 5 0 1 0 -3.902 -3.9 M0 0 h24 v24 H0 z";
				case IconKind.MicrophoneOff:
					return "M12 17 l0 4 M8 21 l8 0 M5 10 a7 7 0 0 0 10.846 5.85 m2 -2 a6.967 6.967 0 0 0 1.152 -3.85 M9 5 a3 3 0 0 1 6 0 v5 a3 3 0 0 1 -0.13 0.874 m-2 2 a3 3 0 0 1 -3.87 -2.872 v-1 M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.Microphone:
					return "M12 17 l0 4 M8 21 l8 0 M5 10 a7 7 0 0 0 14 0 M9 2 m0 3 a3 3 0 0 1 3 -3 h0 a3 3 0 0 1 3 3 v5 a3 3 0 0 1 -3 3 h0 a3 3 0 0 1 -3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.MicroscopeOff:
					return "M3 3 l18 18 M12 21 a6 6 0 0 0 5.457 -3.505 m0.441 -3.599 a6 6 0 0 0 -2.183 -3.608 M17 3 l3 3 M10.5 12.5 l-1.5 1.5 M10 10 l-1 1 l3 3 l1 -1 m2 -2 l3 -3 l-3 -3 l-3 3 M7 18 v3 M6 18 h2 M5 21 h14 M0 0 h24 v24 H0 z";
				case IconKind.Microscope:
					return "M12 21 a6 6 0 0 0 3.715 -10.712 M17 3 l3 3 M10.5 12.5 l-1.5 1.5 M9 11 l3 3 l6 -6 l-3 -3 z M7 18 v3 M6 18 h2 M5 21 h14 M0 0 h24 v24 H0 z";
				case IconKind.MicrowaveOff:
					return "M3 3 l18 18 M6.5 13.5 c1 -0.667 1.5 -0.667 2.5 0 c0.833 0.347 1.667 0.926 2.5 0 M6.5 10.5 c1 -0.667 1.5 -0.667 2.5 0 c0.636 0.265 1.272 0.665 1.907 0.428 M18 9 h0.01 M18 12 h0.01 M15 6 v5 m0 4 v3 M18 18 h-14 a1 1 0 0 1 -1 -1 v-10 a1 1 0 0 1 1 -1 h2 m4 0 h10 a1 1 0 0 1 1 1 v10 M0 0 h24 v24 H0 z";
				case IconKind.Microwave:
					return "M6.5 13.5 c1 -0.667 1.5 -0.667 2.5 0 c0.833 0.347 1.667 0.926 2.5 0 M6.5 10.5 c1 -0.667 1.5 -0.667 2.5 0 c0.833 0.347 1.667 0.926 2.5 0 M18 9 h0.01 M18 15 h0.01 M18 12 h0.01 M15 6 v12 M3 6 m0 1 a1 1 0 0 1 1 -1 h16 a1 1 0 0 1 1 1 v10 a1 1 0 0 1 -1 1 h-16 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.MilitaryAward:
					return "M15.5 10.5 l1 -2.5 h5.5 l-2.48 5.788 a2 2 0 0 1 -1.84 1.212 h-2.18 M8.5 10.5 l-1 -2.5 h-5.5 l2.48 5.788 a2 2 0 0 0 1.84 1.212 h2.18 M12 13 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M0 0 h24 v24 H0 z";
				case IconKind.MilitaryRank:
					return "M10 9 l2 -1 l2 1 M10 17 l2 -1 l2 1 M10 13 l2 -1 l2 1 M17 7 v13 h-10 v-13 l5 -3 z M0 0 h24 v24 H0 z";
				case IconKind.MilkOff:
					return "M3 3 l18 18 M12 16 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M16 6 l1.094 1.759 a6 6 0 0 1 0.906 3.17 v3.071 m0 4 v1 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 v-8.071 a6 6 0 0 1 0.906 -3.17 l0.327 -0.525 M10 6 h6 v-2 a1 1 0 0 0 -1 -1 h-6 a1 1 0 0 0 -1 1 M0 0 h24 v24 H0 z";
				case IconKind.Milk:
					return "M10 10 h4 M12 16 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M16 6 l1.094 1.759 a6 6 0 0 1 0.906 3.17 v8.071 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 v-8.071 a6 6 0 0 1 0.906 -3.17 l1.094 -1.759 M8 6 h8 v-2 a1 1 0 0 0 -1 -1 h-6 a1 1 0 0 0 -1 1 v2 z M0 0 h24 v24 H0 z";
				case IconKind.Milkshake:
					return "M12 5 v-2 M7 13 l1.81 7.243 a1 1 0 0 0 0.97 0.757 h4.44 a1 1 0 0 0 0.97 -0.757 l1.81 -7.243 M6 10 m0 1 a1 1 0 0 1 1 -1 h10 a1 1 0 0 1 1 1 v1 a1 1 0 0 1 -1 1 h-10 a1 1 0 0 1 -1 -1 z M17 10 a5 5 0 0 0 -10 0 M0 0 h24 v24 H0 z";
				case IconKind.Minimize:
					return "M5 9 h2 a2 2 0 0 0 2 -2 v-2 M5 15 h2 a2 2 0 0 1 2 2 v2 M15 5 v2 a2 2 0 0 0 2 2 h2 M15 19 v-2 a2 2 0 0 1 2 -2 h2 M0 0 h24 v24 H0 z";
				case IconKind.MinusVertical:
					return "M12 5 v14 M0 0 h24 v24 H0 z";
				case IconKind.Minus:
					return "M5 12 l14 0 M0 0 h24 v24 H0 z";
				case IconKind.MistOff:
					return "M3 3 l18 18 M3 20 h9 m4 0 h3 M14 15 h1 m4 0 h2 M5 15 h5 M18 10 h1 M3 10 h7 M12 5 h9 M0 0 h24 v24 H0 z";
				case IconKind.Mist:
					return "M3 20 h9 m4 0 h3 M5 15 h5 m4 0 h7 M3 10 h11 m4 0 h1 M5 5 h3 m4 0 h9 M0 0 h24 v24 H0 z";
				case IconKind.Moneybag:
					return "M4 17 v-1 a8 8 0 1 1 16 0 v1 a4 4 0 0 1 -4 4 h-8 a4 4 0 0 1 -4 -4 z M9.5 3 h5 a1.5 1.5 0 0 1 1.5 1.5 a3.5 3.5 0 0 1 -3.5 3.5 h-1 a3.5 3.5 0 0 1 -3.5 -3.5 a1.5 1.5 0 0 1 1.5 -1.5 z M0 0 h24 v24 H0 z";
				case IconKind.MoodAngry:
					return "M14.5 16.05 a3.5 3.5 0 0 0 -5 0 M16 9 l-2 1 M8 9 l2 1 M12 21 a9 9 0 1 1 0 -18 a9 9 0 0 1 0 18 z M0 0 h24 v24 H0 z";
				case IconKind.MoodAnnoyed2:
					return "M17 9.25 c-0.5 1 -2.5 1 -3 0 M10 9.25 c-0.5 1 -2.5 1 -3 0 M15 14 c-2 0 -3 1 -3.5 2.05 M12 21 a9 9 0 1 1 0 -18 a9 9 0 0 1 0 18 z M0 0 h24 v24 H0 z";
				case IconKind.MoodAnnoyed:
					return "M15 10 h-0.01 M9 10 h-0.01 M15 14 c-2 0 -3 1 -3.5 2.05 M12 21 a9 9 0 1 1 0 -18 a9 9 0 0 1 0 18 z M0 0 h24 v24 H0 z";
				case IconKind.MoodBoy:
					return "M15 12 l0.01 0 M9 12 l0.01 0 M12.5 2 c1.5 2 2 3.5 2 5 M8.5 2 c1.5 1 2.5 3.5 2.5 5 M9.5 16 a3.5 3.5 0 0 0 5 0 M17 4.5 a9 9 0 0 1 3.864 5.89 a2.5 2.5 0 0 1 -0.29 4.36 a9 9 0 0 1 -17.137 0 a2.5 2.5 0 0 1 -0.29 -4.36 a9 9 0 0 1 3.746 -5.81 M0 0 h24 v24 H0 z";
				case IconKind.MoodConfuzed:
					return "M9.5 16 a10 10 0 0 1 6 -1.5 M15 10 l0.01 0 M9 10 l0.01 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.MoodCrazyHappy:
					return "M9.5 15 a3.5 3.5 0 0 0 5 0 M14 11.5 l3 -3 M14 8.5 l3 3 M7 11.5 l3 -3 M7 8.5 l3 3 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.MoodCry:
					return "M20.865 13.517 a8.937 8.937 0 0 0 0.135 -1.517 a9 9 0 1 0 -9 9 c0.69 0 1.36 -0.076 2 -0.222 M17.566 17.606 a2 2 0 1 0 2.897 0.03 l-1.463 -1.636 l-1.434 1.606 z M9.5 15.25 a3.5 3.5 0 0 1 5 0 M15 10 l0.01 0 M9 10 l0.01 0 M0 0 h24 v24 H0 z";
				case IconKind.MoodEmpty:
					return "M9 15 l6 0 M15 10 l0.01 0 M9 10 l0.01 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.MoodHappy:
					return "M8 13 a4 4 0 1 0 8 0 h-8 M15 9 l0.01 0 M9 9 l0.01 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.MoodKid:
					return "M12 3 a2 2 0 0 0 0 4 M9.5 15 a3.5 3.5 0 0 0 5 0 M15 10 l0.01 0 M9 10 l0.01 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.MoodLookLeft:
					return "M4 15 h4 M9 9 h0.01 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.MoodLookRight:
					return "M20 15 h-4 M15 9 h-0.01 M12 21 a9 9 0 1 1 0 -18 a9 9 0 0 1 0 18 z M0 0 h24 v24 H0 z";
				case IconKind.MoodNerd:
					return "M10 9.5 c1.333 -1.333 2.667 -1.333 4 0 M18 9 h2.5 M3.5 9 h2.5 M9.5 15 a3.5 3.5 0 0 0 5 0 M16 10 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M8 10 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.MoodNervous:
					return "M8 16 l2 -2 l2 2 l2 -2 l2 2 M15 10 h0.01 M9 10 h0.01 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.MoodNeutral:
					return "M15 10 l0.01 0 M9 10 l0.01 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.MoodOff:
					return "M3 3 l18 18 M9.5 15 a3.5 3.5 0 0 0 5 0 M15 10 h0.01 M9 10 h0.01 M5.634 5.638 a9 9 0 0 0 12.732 12.724 m1.679 -2.322 a9 9 0 0 0 -12.08 -12.086 M0 0 h24 v24 H0 z";
				case IconKind.MoodSad2:
					return "M17 9.25 c-0.5 1 -2.5 1 -3 0 M10 9.25 c-0.5 1 -2.5 1 -3 0 M14.5 16.05 a3.5 3.5 0 0 0 -5 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.MoodSadDizzy:
					return "M16 9 l-2 2 M14 9 l2 2 M10 9 l-2 2 M8 9 l2 2 M14.5 16.05 a3.5 3.5 0 0 0 -5 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.MoodSadSquint:
					return "M15.5 11.5 l-1.5 -1.5 l1.5 -1.5 M8.5 11.5 l1.5 -1.5 l-1.5 -1.5 M14.5 16.05 a3.5 3.5 0 0 0 -5 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.MoodSad:
					return "M9.5 15.25 a3.5 3.5 0 0 1 5 0 M15 10 l0.01 0 M9 10 l0.01 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.MoodSick:
					return "M8 16 l1 -1 l1.5 1 l1.5 -1 l1.5 1 l1.5 -1 l1 1 M15 10 h-0.01 M9 10 h-0.01 M12 21 a9 9 0 1 1 0 -18 a9 9 0 0 1 0 18 z M0 0 h24 v24 H0 z";
				case IconKind.MoodSilence:
					return "M15 14 v2 M12 14 v2 M9 14 v2 M8 15 h8 M15 10 h-0.01 M9 10 h-0.01 M12 21 a9 9 0 1 1 0 -18 a9 9 0 0 1 0 18 z M0 0 h24 v24 H0 z";
				case IconKind.MoodSing:
					return "M15 15 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M15 9 h0.01 M9 9 h0.01 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.MoodSmileBeam:
					return "M14.5 15 a3.5 3.5 0 0 1 -5 0 M17 10 c-0.5 -1 -2.5 -1 -3 0 M10 10 c-0.5 -1 -2.5 -1 -3 0 M12 21 a9 9 0 1 1 0 -18 a9 9 0 0 1 0 18 z M0 0 h24 v24 H0 z";
				case IconKind.MoodSmileDizzy:
					return "M16 9 l-2 2 M14 9 l2 2 M10 9 l-2 2 M8 9 l2 2 M14.5 15 a3.5 3.5 0 0 1 -5 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.MoodSmile:
					return "M9.5 15 a3.5 3.5 0 0 0 5 0 M15 10 l0.01 0 M9 10 l0.01 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.MoodSuprised:
					return "M12 15 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M15 9 l0.01 0 M9 9 l0.01 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.MoodTongueWink2:
					return "M7 10 c0.5 -1 2.5 -1 3 0 M10 14 v2 a2 2 0 1 0 4 0 v-2 m1.5 0 h-7 M15 10 h-0.01 M12 21 a9 9 0 1 1 0 -18 a9 9 0 0 1 0 18 z M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.MoodTongueWink:
					return "M17 10 c-0.5 -1 -2.5 -1 -3 0 M15.5 14 h-7 M10 14 v2 a2 2 0 0 0 4 0 v-2 M9 10 h0.01 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M12 21 a9 9 0 1 1 0 -18 a9 9 0 0 1 0 18 z M0 0 h24 v24 H0 z";
				case IconKind.MoodTongue:
					return "M10 14 v2 a2 2 0 0 0 4 0 v-2 m1.5 0 h-7 M15 10 l0.01 0 M9 10 l0.01 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.MoodUnamused:
					return "M17 10 c-0.5 -1 -2.5 -1 -3 0 M10 10 c-0.5 -1 -2.5 -1 -3 0 M11 16 l4 -1.5 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.MoodWink2:
					return "M15.5 8.5 l-1.5 1.5 l1.5 1.5 M14.5 15 a3.5 3.5 0 0 1 -5 0 M9 10 h-0.01 M12 21 a9 9 0 1 1 0 -18 a9 9 0 0 1 0 18 z M0 0 h24 v24 H0 z";
				case IconKind.MoodWink:
					return "M8.5 8.5 l1.5 1.5 l-1.5 1.5 M9.5 15 a3.5 3.5 0 0 0 5 0 M15 10 h0.01 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.MoodWrrr:
					return "M15.5 11.5 l-1.5 -1.5 l1.5 -1.5 M8.5 11.5 l1.5 -1.5 l-1.5 -1.5 M8 16 l1 -1 l1.5 1 l1.5 -1 l1.5 1 l1.5 -1 l1 1 M12 21 a9 9 0 1 1 0 -18 a9 9 0 0 1 0 18 z M0 0 h24 v24 H0 z";
				case IconKind.MoodXd:
					return "M9 11 l6 -3 M9 8 l6 3 M9 14 h6 a3 3 0 1 1 -6 0 z M12 21 a9 9 0 1 1 0 -18 a9 9 0 0 1 0 18 z M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.Moon2:
					return "M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M16.418 4.157 a8 8 0 0 0 0 15.686 M0 0 h24 v24 H0 z";
				case IconKind.MoonFilled:
					return "M12 3 c0.132 0 0.263 0 0.393 0 a7.5 7.5 0 0 0 7.92 12.446 a9 9 0 1 1 -8.313 -12.454 z M0 0 h24 v24 H0 z";
				case IconKind.MoonOff:
					return "M3 3 l18 18 M7.962 3.949 a8.97 8.97 0 0 1 4.038 -0.957 v0.008 h0.393 a7.478 7.478 0 0 0 -2.07 3.308 m-0.141 3.84 c0.186 0.823 0.514 1.626 0.989 2.373 a7.49 7.49 0 0 0 4.586 3.268 m3.893 -0.11 c0.223 -0.067 0.444 -0.144 0.663 -0.233 a9.088 9.088 0 0 1 -0.274 0.597 m-1.695 2.337 a9 9 0 0 1 -12.71 -12.749 M0 0 h24 v24 H0 z";
				case IconKind.MoonStars:
					return "M19 11 h2 m-1 -1 v2 M17 4 a2 2 0 0 0 2 2 a2 2 0 0 0 -2 2 a2 2 0 0 0 -2 -2 a2 2 0 0 0 2 -2 M12 3 c0.132 0 0.263 0 0.393 0 a7.5 7.5 0 0 0 7.92 12.446 a9 9 0 1 1 -8.313 -12.454 z M0 0 h24 v24 H0 z";
				case IconKind.Moon:
					return "M12 3 c0.132 0 0.263 0 0.393 0 a7.5 7.5 0 0 0 7.92 12.446 a9 9 0 1 1 -8.313 -12.454 z M0 0 h24 v24 H0 z";
				case IconKind.Moped:
					return "M6 9 l3 0 M5 16 v1 a2 2 0 0 0 4 0 v-5 h-3 a3 3 0 0 0 -3 3 v1 h10 a6 6 0 0 1 5 -4 v-5 a2 2 0 0 0 -2 -2 h-1 M18 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Motorbike:
					return "M13 6 h2 l1.5 3 l2 4 M7.5 14 h5 l4 -4 h-10.5 m1.5 4 l4 -4 M19 16 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M5 16 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.MountainOff:
					return "M3 3 l18 18 M7.5 11 l2 2.5 l2 -2 M18.281 14.26 l-4.201 -8.872 a2.3 2.3 0 0 0 -4.158 0 l-0.165 0.349 m-1.289 2.719 l-5.468 11.544 h17 M0 0 h24 v24 H0 z";
				case IconKind.Mountain:
					return "M7.5 11 l2 2.5 l2.5 -2.5 l2 3 l2.5 -2 M3 20 h18 l-6.921 -14.612 a2.3 2.3 0 0 0 -4.158 0 l-6.921 14.612 z M0 0 h24 v24 H0 z";
				case IconKind.Mouse2:
					return "M6 10 h12 M12 3 v7 M6 3 m0 4 a4 4 0 0 1 4 -4 h4 a4 4 0 0 1 4 4 v10 a4 4 0 0 1 -4 4 h-4 a4 4 0 0 1 -4 -4 z M0 0 h24 v24 H0 z";
				case IconKind.MouseOff:
					return "M3 3 l18 18 M12 7 v1 M7.733 3.704 a3.982 3.982 0 0 1 2.267 -0.704 h4 a4 4 0 0 1 4 4 v7 m-0.1 3.895 a4 4 0 0 1 -3.9 3.105 h-4 a4 4 0 0 1 -4 -4 v-10 c0 -0.3 0.033 -0.593 0.096 -0.874 M0 0 h24 v24 H0 z";
				case IconKind.Mouse:
					return "M12 7 l0 4 M6 3 m0 4 a4 4 0 0 1 4 -4 h4 a4 4 0 0 1 4 4 v10 a4 4 0 0 1 -4 4 h-4 a4 4 0 0 1 -4 -4 z M0 0 h24 v24 H0 z";
				case IconKind.Moustache:
					return "M9 9 a3 3 0 0 0 -2.599 1.5 h0 c-0.933 1.333 -2.133 1.556 -3.126 1.556 l-0.291 0 l-0.77 -0.044 l-0.213 0 c0.963 1.926 3.163 2.925 6.6 3 l0.4 0 l0.165 0 a3 3 0 0 0 -0.165 -6 z M15 9 a3 3 0 0 1 2.599 1.5 h0 c0.933 1.333 2.133 1.556 3.126 1.556 l0.291 0 l0.77 -0.044 l0.213 0 c-0.963 1.926 -3.163 2.925 -6.6 3 l-0.4 0 l-0.165 0 a3 3 0 0 1 0.165 -6 z M0 0 h24 v24 H0 z";
				case IconKind.MovieOff:
					return "M3 3 l18 18 M16 8 h4 M4 12 h8 m4 0 h4 M4 16 h4 M4 8 h4 M16 4 v8 m0 4 v4 M8 8 v12 M8 4 h10 a2 2 0 0 1 2 2 v10 m-0.592 3.42 c-0.362 0.359 -0.859 0.58 -1.408 0.58 h-12 a2 2 0 0 1 -2 -2 v-12 c0 -0.539 0.213 -1.028 0.56 -1.388 M0 0 h24 v24 H0 z";
				case IconKind.Movie:
					return "M16 16 l4 0 M16 8 l4 0 M4 12 l16 0 M4 16 l4 0 M4 8 l4 0 M16 4 l0 16 M8 4 l0 16 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.MugOff:
					return "M3 3 l18 18 M16 8 h2.5 c1.38 0 2.5 1.045 2.5 2.333 v2.334 c0 1.148 -0.89 2.103 -2.06 2.297 M9 5 h5.917 a1.08 1.08 0 0 1 1.083 1.077 v5.923 m-0.167 3.88 a4.33 4.33 0 0 1 -4.166 3.12 h-4.334 c-2.393 0 -4.333 -1.929 -4.333 -4.308 v-8.615 a1.08 1.08 0 0 1 1.083 -1.077 h0.917 M0 0 h24 v24 H0 z";
				case IconKind.Mug:
					return "M16 8 h2.5 c1.38 0 2.5 1.045 2.5 2.333 v2.334 c0 1.288 -1.12 2.333 -2.5 2.333 h-2.5 M4.083 5 h10.834 a1.08 1.08 0 0 1 1.083 1.077 v8.615 c0 2.38 -1.94 4.308 -4.333 4.308 h-4.334 c-2.393 0 -4.333 -1.929 -4.333 -4.308 v-8.615 a1.08 1.08 0 0 1 1.083 -1.077 M0 0 h24 v24 H0 z";
				case IconKind.Multiplier05x:
					return "M19 16 l-4 -4 M15 16 l4 -4 M5 16 v0.01 M8 16 h2 a2 2 0 1 0 0 -4 h-2 v-4 h4 M0 0 h24 v24 H0 z";
				case IconKind.Multiplier15x:
					return "M21 16 l-4 -4 M17 16 l4 -4 M7 16 v0.01 M10 16 h2 a2 2 0 1 0 0 -4 h-2 v-4 h4 M4 16 v-8 l-2 2 M0 0 h24 v24 H0 z";
				case IconKind.Multiplier1x:
					return "M17 16 l-4 -4 M13 16 l4 -4 M9 16 v-8 l-2 2 M0 0 h24 v24 H0 z";
				case IconKind.Multiplier2x:
					return "M6 10 a2 2 0 1 1 4 0 c0 0.591 -0.417 1.318 -0.816 1.858 l-3.184 4.143 l4 0 M18 16 l-4 -4 M14 16 l4 -4 M0 0 h24 v24 H0 z";
				case IconKind.MushroomOff:
					return "M3 3 l18 18 M10 12 v7 a2 2 0 1 0 4 0 v-5 M5.874 5.89 a8.128 8.128 0 0 0 -1.874 5.21 a0.9 0.9 0 0 0 0.9 0.9 h7.1 m4 0 h3.1 a0.9 0.9 0 0 0 0.9 -0.9 c0 -4.474 -3.582 -8.1 -8 -8.1 c-1.43 0 -2.774 0.38 -3.936 1.047 M0 0 h24 v24 H0 z";
				case IconKind.Mushroom:
					return "M10 12 v7 a2 2 0 1 0 4 0 v-7 M20 11.1 c0 -4.474 -3.582 -8.1 -8 -8.1 s-8 3.626 -8 8.1 a0.9 0.9 0 0 0 0.9 0.9 h14.2 a0.9 0.9 0 0 0 0.9 -0.9 z M0 0 h24 v24 H0 z";
				case IconKind.MusicOff:
					return "M3 3 l18 18 M12 8 h7 M9 17 v-8 m0 -4 v-1 h10 v11 M14.42 14.45 a3 3 0 1 0 4.138 4.119 M6 17 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.Music:
					return "M9 8 l10 0 M9 17 l0 -13 l10 0 l0 13 M16 17 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M6 17 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.NavigationFilled:
					return "M12 18.5 l7.265 2.463 a0.535 0.535 0 0 0 0.57 -0.116 a0.548 0.548 0 0 0 0.134 -0.572 l-7.969 -17.275 l-7.97 17.275 a0.547 0.547 0 0 0 0.135 0.572 a0.535 0.535 0 0 0 0.57 0.116 l7.265 -2.463 M0 0 h24 v24 H0 z";
				case IconKind.NavigationOff:
					return "M3 3 l18 18 M16.28 12.28 c-0.95 -2.064 -2.377 -5.157 -4.28 -9.28 c-0.7 1.515 -1.223 2.652 -1.573 3.41 m-1.27 2.75 c-0.882 1.913 -2.59 5.618 -5.127 11.115 c-0.07 0.2 -0.017 0.424 0.135 0.572 c0.15 0.148 0.374 0.193 0.57 0.116 l7.265 -2.463 l7.265 2.463 c0.196 0.077 0.42 0.032 0.57 -0.116 a0.548 0.548 0 0 0 0.134 -0.572 l-0.26 -0.563 M0 0 h24 v24 H0 z";
				case IconKind.Navigation:
					return "M12 18.5 l7.265 2.463 a0.535 0.535 0 0 0 0.57 -0.116 a0.548 0.548 0 0 0 0.134 -0.572 l-7.969 -17.275 l-7.97 17.275 a0.547 0.547 0 0 0 0.135 0.572 a0.535 0.535 0 0 0 0.57 0.116 l7.265 -2.463 M0 0 h24 v24 H0 z";
				case IconKind.NeedleThread:
					return "M19.5 9.5 l1.5 1.5 M5.739 15.425 c-1.393 -0.565 -3.739 -1.925 -3.739 -3.425 M17 7 c-2.333 -2.667 -3.5 -4 -5 -4 s-2 1 -2 2 c0 4 8.161 8.406 6 11 c-1.056 1.268 -3.363 1.285 -5.75 0.808 M17.5 6.5 l-1 1 M3 21 c-0.667 -0.667 3.262 -6.236 11.785 -16.709 a3.5 3.5 0 1 1 5.078 4.791 c-10.575 8.612 -16.196 12.585 -16.863 11.918 z M0 0 h24 v24 H0 z";
				case IconKind.Needle:
					return "M17.5 6.5 l-1 1 M3 21 c-0.667 -0.667 3.262 -6.236 11.785 -16.709 a3.5 3.5 0 1 1 5.078 4.791 c-10.575 8.612 -16.196 12.585 -16.863 11.918 z M0 0 h24 v24 H0 z";
				case IconKind.NetworkOff:
					return "M3 3 l18 18 M12 15 v2 M12 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M14 19 h5 M3 19 h7 M6 9 h3 m4 0 h5 M12 3 c-0.938 0.234 -1.547 1.295 -1.825 3.182 m-0.156 3.837 c0.117 3.02 0.777 4.68 1.981 4.981 M12 3 c1.333 0.333 2 2.333 2 6 c0 0.348 0 0.681 -0.018 1 m-0.545 3.43 c-0.332 0.89 -0.811 1.414 -1.437 1.57 M6.537 6.516 a6 6 0 0 0 7.932 7.954 m2.246 -1.76 a6 6 0 0 0 -8.415 -8.433 M0 0 h24 v24 H0 z";
				case IconKind.Network:
					return "M12 15 v2 M12 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M14 19 h7 M3 19 h7 M6 9 h12 M12 3 c-1.333 0.333 -2 2.333 -2 6 s0.667 5.667 2 6 M12 3 c1.333 0.333 2 2.333 2 6 s-0.667 5.667 -2 6 M12 9 m-6 0 a6 6 0 1 0 12 0 a6 6 0 1 0 -12 0 M0 0 h24 v24 H0 z";
				case IconKind.NewSection:
					return "M4 6 v-1 a1 1 0 0 1 1 -1 h1 m5 0 h2 m5 0 h1 a1 1 0 0 1 1 1 v1 m0 5 v2 m0 5 v1 a1 1 0 0 1 -1 1 h-1 m-5 0 h-2 m-5 0 h-1 a1 1 0 0 1 -1 -1 v-1 m0 -5 v-2 m0 -5 M12 9 l0 6 M9 12 l6 0 M0 0 h24 v24 H0 z";
				case IconKind.NewsOff:
					return "M3 3 l18 18 M8 16 h4 M8 12 h4 M16 6 h3 a1 1 0 0 1 1 1 v9 m-0.606 3.435 a2 2 0 0 1 -3.394 -1.435 v-2 m0 -4 v-7 a1 1 0 0 0 -1 -1 h-7 m-3.735 0.321 a1 1 0 0 0 -0.265 0.679 v12 a3 3 0 0 0 3 3 h11 M0 0 h24 v24 H0 z";
				case IconKind.News:
					return "M8 16 l4 0 M8 12 l4 0 M8 8 l4 0 M16 6 h3 a1 1 0 0 1 1 1 v11 a2 2 0 0 1 -4 0 v-13 a1 1 0 0 0 -1 -1 h-10 a1 1 0 0 0 -1 1 v12 a3 3 0 0 0 3 3 h11 M0 0 h24 v24 H0 z";
				case IconKind.NfcOff:
					return "M3 3 l18 18 M8 4 h9 a3 3 0 0 1 3 3 v9 m-0.873 3.116 a2.99 2.99 0 0 1 -2.127 0.884 h-10 a3 3 0 0 1 -3 -3 v-10 c0 -0.83 0.337 -1.582 0.882 -2.125 M13 4 a3 3 0 0 1 3 3 v5 m0 4 v2 l-5 -5 M11 20 a3 3 0 0 1 -3 -3 v-9 M0 0 h24 v24 H0 z";
				case IconKind.Nfc:
					return "M4 4 m0 3 a3 3 0 0 1 3 -3 h10 a3 3 0 0 1 3 3 v10 a3 3 0 0 1 -3 3 h-10 a3 3 0 0 1 -3 -3 z M13 4 a3 3 0 0 1 3 3 v11 l-5 -5 M11 20 a3 3 0 0 1 -3 -3 v-11 l5 5 M0 0 h24 v24 H0 z";
				case IconKind.NoCopyright:
					return "M16.5 16.5 l1.5 1.5 M6 6 l1.5 1.5 M14 9.75 a3.016 3.016 0 0 0 -4.163 0.173 a2.993 2.993 0 0 0 0 4.154 a3.016 3.016 0 0 0 4.163 0.173 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.NoCreativeCommons:
					return "M16.5 16.5 l1.5 1.5 M6 6 l1.5 1.5 M16.5 10.5 c-0.847 -0.71 -2.132 -0.658 -2.914 0.116 a1.928 1.928 0 0 0 0 2.768 c0.782 0.774 2.067 0.825 2.914 0.116 M10.5 10.5 c-0.847 -0.71 -2.132 -0.658 -2.914 0.116 a1.928 1.928 0 0 0 0 2.768 c0.782 0.774 2.067 0.825 2.914 0.116 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.NoDerivatives:
					return "M9 14 h6 M9 10 h6 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.NorthStar:
					return "M7.5 16.5 l9 -9 M7.5 7.5 l9 9 M12 21 v-18 M3 12 h18 M0 0 h24 v24 H0 z";
				case IconKind.NoteOff:
					return "M3 3 l18 18 M17 13 h3 v-7 a2 2 0 0 0 -2 -2 h-10 m-3.427 0.6 c-0.355 0.36 -0.573 0.853 -0.573 1.4 v12 a2 2 0 0 0 2 2 h7 v-6 c0 -0.272 0.109 -0.519 0.285 -0.699 M13 20 l3.505 -3.505 m2 -2 l1.501 -1.501 M0 0 h24 v24 H0 z";
				case IconKind.Note:
					return "M13 20 v-6 a1 1 0 0 1 1 -1 h6 v-7 a2 2 0 0 0 -2 -2 h-12 a2 2 0 0 0 -2 2 v12 a2 2 0 0 0 2 2 h7 M13 20 l7 -7 M0 0 h24 v24 H0 z";
				case IconKind.NotebookOff:
					return "M3 3 l18 18 M13 8 h2 M8 4 h9 a2 2 0 0 1 2 2 v9 m-0.179 3.828 a2 2 0 0 1 -1.821 1.172 h-11 a1 1 0 0 1 -1 -1 v-14 m4 -1 v1 m0 4 v13 M0 0 h24 v24 H0 z";
				case IconKind.Notebook:
					return "M13 12 l2 0 M13 8 l2 0 M6 4 h11 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-11 a1 1 0 0 1 -1 -1 v-14 a1 1 0 0 1 1 -1 m3 0 v18 M0 0 h24 v24 H0 z";
				case IconKind.NotesOff:
					return "M3 3 l18 18 M9 15 h4 M9 11 h2 M11 7 h4 M7 3 h10 a2 2 0 0 1 2 2 v10 m0 4 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 v-14 M0 0 h24 v24 H0 z";
				case IconKind.Notes:
					return "M9 15 l4 0 M9 11 l6 0 M9 7 l6 0 M5 3 m0 2 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v14 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.NotificationOff:
					return "M3 3 l18 18 M17 7 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M6.154 6.187 a2 2 0 0 0 -1.154 1.813 v9 a2 2 0 0 0 2 2 h9 a2 2 0 0 0 1.811 -1.151 M0 0 h24 v24 H0 z";
				case IconKind.Notification:
					return "M17 7 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M10 6 h-3 a2 2 0 0 0 -2 2 v9 a2 2 0 0 0 2 2 h9 a2 2 0 0 0 2 -2 v-3 M0 0 h24 v24 H0 z";
				case IconKind.Number0:
					return "M12 20 a4 4 0 0 0 4 -4 v-8 a4 4 0 1 0 -8 0 v8 a4 4 0 0 0 4 4 z M16 16 v-8 M0 0 h24 v24 H0 z";
				case IconKind.Number1:
					return "M13 20 v-16 l-5 5 M0 0 h24 v24 H0 z";
				case IconKind.Number2:
					return "M8 8 a4 4 0 1 1 8 0 c0 1.098 -0.564 2.025 -1.159 2.815 l-6.841 9.185 h8 M0 0 h24 v24 H0 z";
				case IconKind.Number3:
					return "M8 16 a4 4 0 1 0 4 -4 M12 12 a4 4 0 1 0 -4 -4 M0 0 h24 v24 H0 z";
				case IconKind.Number4:
					return "M15 20 v-15 l-8 11 h10 M0 0 h24 v24 H0 z";
				case IconKind.Number5:
					return "M8 20 h4 a4 4 0 1 0 0 -8 h-4 v-8 h8 M0 0 h24 v24 H0 z";
				case IconKind.Number6:
					return "M16 8 a4 4 0 1 0 -8 0 v8 M8 16 a4 4 0 1 0 8 0 v-1 a4 4 0 1 0 -8 0 M0 0 h24 v24 H0 z";
				case IconKind.Number7:
					return "M8 4 h8 l-4 16 M0 0 h24 v24 H0 z";
				case IconKind.Number8:
					return "M12 16 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M12 8 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M0 0 h24 v24 H0 z";
				case IconKind.Number9:
					return "M8 16 a4 4 0 1 0 8 0 v-8 M16 8 a4 4 0 1 0 -8 0 v1 a4 4 0 1 0 8 0 M0 0 h24 v24 H0 z";
				case IconKind.Number:
					return "M17.5 10 m-2.5 0 a2.5 3 0 1 0 5 0 a2.5 3 0 1 0 -5 0 M15 17 h5 M4 17 v-10 l7 10 v-10 M0 0 h24 v24 H0 z";
				case IconKind.Numbers:
					return "M6.5 10 h3 M15 14 a2 2 0 1 0 2 -2 a2 2 0 1 0 -2 -2 M6 16 a2 2 0 1 1 4 0 c0 0.591 -0.601 1.46 -1 2 l-3 3 h4 M8 10 v-7 l-2 2 M0 0 h24 v24 H0 z";
				case IconKind.Nurse:
					return "M12 10 v4 M10 12 h4 M12 6 c2.941 0 5.685 0.847 8 2.31 l-2 9.69 h-12 l-2 -9.691 a14.93 14.93 0 0 1 8 -2.309 z M0 0 h24 v24 H0 z";
				case IconKind.OctagonFilled:
					return "M8.7 3 h6.6 c0.3 0 0.5 0.1 0.7 0.3 l4.7 4.7 c0.2 0.2 0.3 0.4 0.3 0.7 v6.6 c0 0.3 -0.1 0.5 -0.3 0.7 l-4.7 4.7 c-0.2 0.2 -0.4 0.3 -0.7 0.3 h-6.6 c-0.3 0 -0.5 -0.1 -0.7 -0.3 l-4.7 -4.7 c-0.2 -0.2 -0.3 -0.4 -0.3 -0.7 v-6.6 c0 -0.3 0.1 -0.5 0.3 -0.7 l4.7 -4.7 c0.2 -0.2 0.4 -0.3 0.7 -0.3 z M0 0 h24 v24 H0 z";
				case IconKind.OctagonOff:
					return "M3 3 l18 18 M7.647 3.653 l0.353 -0.353 c0.2 -0.2 0.4 -0.3 0.7 -0.3 h6.6 c0.3 0 0.5 0.1 0.7 0.3 l4.7 4.7 c0.2 0.2 0.3 0.4 0.3 0.7 v6.6 c0 0.3 -0.1 0.5 -0.3 0.7 l-0.35 0.35 m-2 2 l-2.353 2.353 c-0.2 0.2 -0.4 0.3 -0.7 0.3 h-6.6 c-0.3 0 -0.5 -0.1 -0.7 -0.3 l-4.7 -4.7 c-0.2 -0.2 -0.3 -0.4 -0.3 -0.7 v-6.6 c0 -0.3 0.1 -0.5 0.3 -0.7 l2.35 -2.35 M0 0 h24 v24 H0 z";
				case IconKind.Octagon:
					return "M8.7 3 h6.6 c0.3 0 0.5 0.1 0.7 0.3 l4.7 4.7 c0.2 0.2 0.3 0.4 0.3 0.7 v6.6 c0 0.3 -0.1 0.5 -0.3 0.7 l-4.7 4.7 c-0.2 0.2 -0.4 0.3 -0.7 0.3 h-6.6 c-0.3 0 -0.5 -0.1 -0.7 -0.3 l-4.7 -4.7 c-0.2 -0.2 -0.3 -0.4 -0.3 -0.7 v-6.6 c0 -0.3 0.1 -0.5 0.3 -0.7 l4.7 -4.7 c0.2 -0.2 0.4 -0.3 0.7 -0.3 z M0 0 h24 v24 H0 z";
				case IconKind.Old:
					return "M16 21 v-8.5 a1.5 1.5 0 0 1 3 0 v0.5 M7 17 l-2 4 M8 4 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M5 14 l-1 -3 l4 -3 l3 2 l3 0.5 M11 21 l-1 -4 l-2 -3 v-6 M0 0 h24 v24 H0 z";
				case IconKind.OlympicsOff:
					return "M3 3 l18 18 M12.878 12.88 a3 3 0 0 0 4.239 4.247 m0.586 -3.431 a3.012 3.012 0 0 0 -1.43 -1.414 M9 15 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M9 9 a3 3 0 0 0 3 3 m2.566 -1.445 a3 3 0 0 0 -4.135 -4.113 M18 9 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M6 6 a3 3 0 1 0 3 3 M0 0 h24 v24 H0 z";
				case IconKind.Olympics:
					return "M15 15 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M9 15 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M12 9 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M18 9 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M6 9 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.Om:
					return "M12 3 c1.667 3.667 4.667 5.333 9 5 M17 3 l2 2 M14.071 17.01 c0.327 2.277 1.739 3.99 3.429 3.99 c1.933 0 3.5 -2.239 3.5 -5 s-1.567 -5 -3.5 -5 c-0.96 0 -1.868 0.606 -2.5 1.5 c-0.717 1.049 -1.76 1.7 -2.936 1.7 c-0.92 0 -1.766 -0.406 -2.434 -1.087 M3.423 14.483 a4.944 4.944 0 0 0 -0.423 2.017 c0 2.485 1.79 4.5 4 4.5 s4 -2.015 4 -4.5 s-1.79 -4.5 -4 -4.5 M7 12 c2.21 0 4 -1.567 4 -3.5 s-1.79 -3.5 -4 -3.5 c-1.594 0 -2.97 0.816 -3.613 2 M0 0 h24 v24 H0 z";
				case IconKind.Omega:
					return "M4 19 h5 v-1 a7.35 7.35 0 1 1 6 0 v1 h5 M0 0 h24 v24 H0 z";
				case IconKind.Outbound:
					return "M11 9 h4 v4 M9 15 l6 -6 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.Outlet:
					return "M14.5,12a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M8.5,12a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.OvalFilled:
					return "M12 2 c3.972 0 7 4.542 7 10 s-3.028 10 -7 10 c-3.9 0 -6.89 -4.379 -6.997 -9.703 l-0.003 -0.297 l0.003 -0.297 c0.107 -5.323 3.097 -9.703 6.997 -9.703 z M0 0 h24 v24 H0 z";
				case IconKind.OvalVerticalFilled:
					return "M12 5 c-5.457 0 -10 3.028 -10 7 s4.543 7 10 7 s10 -3.028 10 -7 s-4.543 -7 -10 -7 z M0 0 h24 v24 H0 z";
				case IconKind.OvalVertical:
					return "M3 12 c0 -3.314 4.03 -6 9 -6 s9 2.686 9 6 s-4.03 6 -9 6 s-9 -2.686 -9 -6 z M0 0 h24 v24 H0 z";
				case IconKind.Oval:
					return "M12 12 m-6 0 a6 9 0 1 0 12 0 a6 9 0 1 0 -12 0 M0 0 h24 v24 H0 z";
				case IconKind.Overline:
					return "M5 5 h14 M7 9 v5 a5 5 0 0 0 10 0 v-5 M0 0 h24 v24 H0 z";
				case IconKind.PackageExport:
					return "M19 15 l3 3 l-3 3 M15 18 h7 M12 12 l-8 -4.5 M12 12 v9 M12 12 l8 -4.5 M12 21 l-8 -4.5 v-9 l8 -4.5 l8 4.5 v4.5 M0 0 h24 v24 H0 z";
				case IconKind.PackageImport:
					return "M18 15 l-3 3 l3 3 M22 18 h-7 M12 12 l-8 -4.5 M12 12 v9 M12 12 l8 -4.5 M12 21 l-8 -4.5 v-9 l8 -4.5 l8 4.5 v4.5 M0 0 h24 v24 H0 z";
				case IconKind.PackageOff:
					return "M3 3 l18 18 M16 5.25 l-4.35 2.447 m-2.564 1.442 l-1.086 0.611 M12 12 l-8 -4.5 M12 12 v9 M14.543 10.57 l5.457 -3.07 M8.812 4.793 l3.188 -1.793 l8 4.5 v8.5 m-2.282 1.784 l-5.718 3.216 l-8 -4.5 v-9 l2.223 -1.25 M0 0 h24 v24 H0 z";
				case IconKind.Package:
					return "M16 5.25 l-8 4.5 M12 12 l-8 -4.5 M12 12 l0 9 M12 12 l8 -4.5 M12 3 l8 4.5 l0 9 l-8 4.5 l-8 -4.5 l0 -9 l8 -4.5 M0 0 h24 v24 H0 z";
				case IconKind.Packages:
					return "M12 8 l5 -3 M7 5.03 v5.455 M12 13.5 v-5.5 l-5 -3 l5 -3 l5 3 v5.5 M17 16.5 l5 -3 M12 19 l5 3 M17 16.5 l-5 -3 l5 -3 l5 3 v5.5 l-5 3 z M7 16.545 l5 -3.03 M2 13.5 v5.5 l5 3 M7 16.5 l-5 -3 l5 -3 l5 3 v5.5 l-5 3 z M0 0 h24 v24 H0 z";
				case IconKind.Pacman:
					return "M10.5,7.5a1,1 0 1,0 2,0a1,1 0 1,0 -2,0 M5.636 5.636 a9 9 0 0 1 13.397 0.747 l-5.619 5.617 l5.619 5.617 a9 9 0 1 1 -13.397 -11.981 z M0 0 h24 v24 H0 z";
				case IconKind.PageBreak:
					return "M5 10 v-5 a2 2 0 0 1 2 -2 h7 l5 5 v2 M3 14 h3 m4.5 0 h3 m4.5 0 h3 M19 18 v1 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 v-1 M14 3 v4 a1 1 0 0 0 1 1 h4 M0 0 h24 v24 H0 z";
				case IconKind.PaintOff:
					return "M3 3 l18 18 M10 15 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M19 6 h1 a2 2 0 0 1 2 2 a5 5 0 0 1 -5 5 m-4 0 h-1 v2 M7 3 h10 a2 2 0 0 1 2 2 v2 a2 2 0 0 1 -2 2 h-4 m-4 0 h-2 a2 2 0 0 1 -2 -2 v-2 M0 0 h24 v24 H0 z";
				case IconKind.Paint:
					return "M10 15 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M19 6 h1 a2 2 0 0 1 2 2 a5 5 0 0 1 -5 5 l-5 0 v2 M5 3 m0 2 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v2 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.PaletteOff:
					return "M3 3 l18 18 M16.5 10.5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12.5 7.5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M8.5 10.5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M8 4 c1.236 -0.623 2.569 -1 4 -1 c4.97 0 9 3.582 9 8 c0 1.06 -0.474 2.078 -1.318 2.828 a4.516 4.516 0 0 1 -1.127 0.73 M15 15 h-1 a2 2 0 0 0 -1 3.75 a1.3 1.3 0 0 1 -1 2.25 a9 9 0 0 1 -6.372 -15.356 M0 0 h24 v24 H0 z";
				case IconKind.Palette:
					return "M16.5 10.5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12.5 7.5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M8.5 10.5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12 21 a9 9 0 0 1 0 -18 c4.97 0 9 3.582 9 8 c0 1.06 -0.474 2.078 -1.318 2.828 c-0.844 0.75 -1.989 1.172 -3.182 1.172 h-2.5 a2 2 0 0 0 -1 3.75 a1.3 1.3 0 0 1 -1 2.25 M0 0 h24 v24 H0 z";
				case IconKind.PanoramaHorizontalOff:
					return "M3 3 l18 18 M10.95 6.952 c2.901 0.15 5.803 -0.323 8.705 -1.42 a1 1 0 0 1 1.345 0.934 v10.534 m-3.212 0.806 c-4.483 -1.281 -8.966 -1.074 -13.449 0.622 a0.993 0.993 0 0 1 -1.339 -0.935 v-11.027 a1 1 0 0 1 1.338 -0.935 c0.588 0.221 1.176 0.418 1.764 0.59 M0 0 h24 v24 H0 z";
				case IconKind.PanoramaHorizontal:
					return "M4.338 5.53 c5.106 1.932 10.211 1.932 15.317 0 a1 1 0 0 1 1.345 0.934 v11 c0 0.692 -0.692 1.2 -1.34 0.962 c-5.107 -1.932 -10.214 -1.932 -15.321 0 c-0.648 0.246 -1.339 -0.242 -1.339 -0.935 v-11.027 a1 1 0 0 1 1.338 -0.935 z M0 0 h24 v24 H0 z";
				case IconKind.PanoramaVerticalOff:
					return "M3 3 l18 18 M7 3 h10.53 c0.693 0 1.18 0.691 0.935 1.338 c-1.098 2.898 -1.573 5.795 -1.425 8.692 m0.828 4.847 c0.172 0.592 0.37 1.185 0.595 1.778 a1 1 0 0 1 -0.934 1.345 h-11 c-0.692 0 -1.208 -0.692 -0.962 -1.34 c1.697 -4.486 1.903 -8.973 0.619 -13.46 M0 0 h24 v24 H0 z";
				case IconKind.PanoramaVertical:
					return "M18.463 4.338 c-1.932 5.106 -1.932 10.211 0 15.317 a1 1 0 0 1 -0.934 1.345 h-11 c-0.692 0 -1.208 -0.692 -0.962 -1.34 c1.932 -5.107 1.932 -10.214 0 -15.321 c-0.246 -0.648 0.243 -1.339 0.935 -1.339 h11.028 c0.693 0 1.18 0.691 0.935 1.338 z M0 0 h24 v24 H0 z";
				case IconKind.PaperBagOff:
					return "M3 3 l18 18 M11 7 h2 M6 21 a2 2 0 0 0 2 -2 v-5.82 a5 5 0 0 0 -0.528 -2.236 l-1.472 -2.944 M13.185 13.173 a2 2 0 1 0 2.64 2.647 M7.158 3.185 c0.256 -0.119 0.542 -0.185 0.842 -0.185 h8 a2 2 0 0 1 2 2 v1.82 a5 5 0 0 0 0.528 2.236 l0.944 1.888 a5 5 0 0 1 0.528 2.236 v2.82 m-0.177 3.824 a2 2 0 0 1 -1.823 1.176 h-12 a2 2 0 0 1 -2 -2 v-5.82 a5 5 0 0 1 0.528 -2.236 l1.472 -2.944 v-2 M0 0 h24 v24 H0 z";
				case IconKind.PaperBag:
					return "M11 7 h2 M6 21 a2 2 0 0 0 2 -2 v-5.82 a5 5 0 0 0 -0.528 -2.236 l-1.472 -2.944 M14 15 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M8 3 h8 a2 2 0 0 1 2 2 v1.82 a5 5 0 0 0 0.528 2.236 l0.944 1.888 a5 5 0 0 1 0.528 2.236 v5.82 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 v-5.82 a5 5 0 0 1 0.528 -2.236 l1.472 -2.944 v-3 a2 2 0 0 1 2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Paperclip:
					return "M15 7 l-6.5 6.5 a1.5 1.5 0 0 0 3 3 l6.5 -6.5 a3 3 0 0 0 -6 -6 l-6.5 6.5 a4.5 4.5 0 0 0 9 9 l6.5 -6.5 M0 0 h24 v24 H0 z";
				case IconKind.ParachuteOff:
					return "M3 3 l18 18 M14.582 14.624 l-2.582 7.376 l4.992 -4.992 m2.014 -2.014 l3 -3 M2 12 l10 10 l-3.5 -10 M22 12 c0 -1.66 -1.46 -3 -3.25 -3 c-1.63 0 -2.973 1.099 -3.212 2.54 m-0.097 -0.09 c-0.23 -1.067 -1.12 -1.935 -2.29 -2.284 m-3.445 0.568 c-0.739 0.55 -1.206 1.36 -1.206 2.266 c0 -1.66 -1.46 -3 -3.25 -3 c-1.8 0 -3.25 1.34 -3.25 3 M22 12 c0 -5.523 -4.477 -10 -10 -10 c-1.737 0 -3.37 0.443 -4.794 1.222 m-2.28 1.71 a9.969 9.969 0 0 0 -2.926 7.068 M0 0 h24 v24 H0 z";
				case IconKind.Parachute:
					return "M15.5 12 l-3.5 10 l10 -10 M2 12 l10 10 l-3.5 -10 M22 12 c0 -1.66 -1.46 -3 -3.25 -3 c-1.8 0 -3.25 1.34 -3.25 3 c0 -1.66 -1.57 -3 -3.5 -3 s-3.5 1.34 -3.5 3 c0 -1.66 -1.46 -3 -3.25 -3 c-1.8 0 -3.25 1.34 -3.25 3 M22 12 a10 10 0 1 0 -20 0 M0 0 h24 v24 H0 z";
				case IconKind.ParenthesesOff:
					return "M3 3 l18 18 M17 4 a12.25 12.25 0 0 1 2.474 11.467 m-1.22 2.794 a12.291 12.291 0 0 1 -1.254 1.739 M5.743 5.745 a12.253 12.253 0 0 0 1.257 14.255 M0 0 h24 v24 H0 z";
				case IconKind.Parentheses:
					return "M17 4 a12.25 12.25 0 0 1 0 16 M7 4 a12.25 12.25 0 0 0 0 16 M0 0 h24 v24 H0 z";
				case IconKind.ParkingOff:
					return "M3 3 l18 18 M9 16 v-7 m3 -1 h1 a2 2 0 0 1 1.817 2.836 m-2.817 1.164 h-3 M8 4 h10 a2 2 0 0 1 2 2 v10 m-0.582 3.41 c-0.362 0.365 -0.864 0.59 -1.418 0.59 h-12 a2 2 0 0 1 -2 -2 v-12 c0 -0.554 0.225 -1.056 0.59 -1.418 M0 0 h24 v24 H0 z";
				case IconKind.Parking:
					return "M9 16 v-8 h4 a2 2 0 0 1 0 4 h-4 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Password:
					return "M17 11 l4 2 M17 13 l4 -2 M19 10 v4 M3 11 l4 2 M3 13 l4 -2 M5 10 v4 M10 11 l4 2 M10 13 l4 -2 M12 10 v4 M0 0 h24 v24 H0 z";
				case IconKind.PawFilled:
					return "M5.69 12.918 c0.816 -0.352 1.054 -1.719 0.536 -3.052 c-0.436 -1.124 -1.271 -1.866 -2.009 -1.866 c-0.14 0 -0.277 0.027 -0.407 0.082 c-0.816 0.352 -1.054 1.719 -0.536 3.052 c0.436 1.124 1.271 1.866 2.009 1.866 c0.14 0 0.277 -0.027 0.407 -0.082 z M16.456 6.733 c0.214 -1.376 -0.375 -2.594 -1.32 -2.722 a1.164 1.164 0 0 0 -0.162 -0.011 c-0.885 0 -1.728 0.97 -1.93 2.267 c-0.214 1.376 0.375 2.594 1.32 2.722 c0.054 0.007 0.108 0.011 0.162 0.011 c0.885 0 1.73 -0.974 1.93 -2.267 z M9.474 9 c0.055 0 0.109 0 0.163 -0.011 c0.944 -0.128 1.533 -1.346 1.32 -2.722 c-0.203 -1.297 -1.047 -2.267 -1.932 -2.267 c-0.055 0 -0.109 0 -0.163 0.011 c-0.944 0.128 -1.533 1.346 -1.32 2.722 c0.204 1.293 1.048 2.267 1.933 2.267 z M20.188 8.082 a1.039 1.039 0 0 0 -0.406 -0.082 h-0.015 c-0.735 0.012 -1.56 0.75 -1.993 1.866 c-0.519 1.335 -0.28 2.7 0.538 3.052 c0.129 0.055 0.267 0.082 0.406 0.082 c0.739 0 1.575 -0.742 2.011 -1.866 c0.516 -1.335 0.273 -2.7 -0.54 -3.052 z M14.7 13.5 c-1.1 -2 -1.441 -2.5 -2.7 -2.5 c-1.259 0 -1.736 0.755 -2.836 2.747 c-0.942 1.703 -2.846 1.845 -3.321 3.291 c-0.097 0.265 -0.145 0.677 -0.143 0.962 c0 1.176 0.787 2 1.8 2 c1.259 0 3 -1 4.5 -1 s3.241 1 4.5 1 c1.013 0 1.8 -0.823 1.8 -2 c0 -0.285 -0.049 -0.697 -0.146 -0.962 c-0.475 -1.451 -2.512 -1.835 -3.454 -3.538 z M0 0 h24 v24 H0 z";
				case IconKind.PawOff:
					return "M3 3 l18 18 M5.69 12.918 c0.816 -0.352 1.054 -1.719 0.536 -3.052 c-0.436 -1.124 -1.271 -1.866 -2.009 -1.866 c-0.14 0 -0.277 0.027 -0.407 0.082 c-0.816 0.352 -1.054 1.719 -0.536 3.052 c0.436 1.124 1.271 1.866 2.009 1.866 c0.14 0 0.277 -0.027 0.407 -0.082 z M16.456 6.733 c0.214 -1.376 -0.375 -2.594 -1.32 -2.722 a1.164 1.164 0 0 0 -0.162 -0.011 c-0.885 0 -1.728 0.97 -1.93 2.267 c-0.214 1.376 0.375 2.594 1.32 2.722 c0.054 0.007 0.108 0.011 0.162 0.011 c0.885 0 1.73 -0.974 1.93 -2.267 z M11 6.992 a3.608 3.608 0 0 0 -0.04 -0.725 c-0.203 -1.297 -1.047 -2.267 -1.932 -2.267 a1.237 1.237 0 0 0 -0.758 0.265 M20.188 8.082 a1.039 1.039 0 0 0 -0.406 -0.082 h-0.015 c-0.735 0.012 -1.56 0.75 -1.993 1.866 c-0.519 1.335 -0.28 2.7 0.538 3.052 c0.129 0.055 0.267 0.082 0.406 0.082 c0.739 0 1.575 -0.742 2.011 -1.866 c0.516 -1.335 0.273 -2.7 -0.54 -3.052 h0 z M11.168 11.154 c-0.71 0.31 -1.184 1.107 -2 2.593 c-0.942 1.703 -2.846 1.845 -3.321 3.291 c-0.097 0.265 -0.145 0.677 -0.143 0.962 c0 1.176 0.787 2 1.8 2 c1.259 0 3 -1 4.5 -1 s3.241 1 4.5 1 c0.927 0 1.664 -0.689 1.783 -1.708 M0 0 h24 v24 H0 z";
				case IconKind.Paw:
					return "M5.69 12.918 c0.816 -0.352 1.054 -1.719 0.536 -3.052 c-0.436 -1.124 -1.271 -1.866 -2.009 -1.866 c-0.14 0 -0.277 0.027 -0.407 0.082 c-0.816 0.352 -1.054 1.719 -0.536 3.052 c0.436 1.124 1.271 1.866 2.009 1.866 c0.14 0 0.277 -0.027 0.407 -0.082 z M16.456 6.733 c0.214 -1.376 -0.375 -2.594 -1.32 -2.722 a1.164 1.164 0 0 0 -0.162 -0.011 c-0.885 0 -1.728 0.97 -1.93 2.267 c-0.214 1.376 0.375 2.594 1.32 2.722 c0.054 0.007 0.108 0.011 0.162 0.011 c0.885 0 1.73 -0.974 1.93 -2.267 z M9.474 9 c0.055 0 0.109 0 0.163 -0.011 c0.944 -0.128 1.533 -1.346 1.32 -2.722 c-0.203 -1.297 -1.047 -2.267 -1.932 -2.267 c-0.055 0 -0.109 0 -0.163 0.011 c-0.944 0.128 -1.533 1.346 -1.32 2.722 c0.204 1.293 1.048 2.267 1.933 2.267 z M20.188 8.082 a1.039 1.039 0 0 0 -0.406 -0.082 h-0.015 c-0.735 0.012 -1.56 0.75 -1.993 1.866 c-0.519 1.335 -0.28 2.7 0.538 3.052 c0.129 0.055 0.267 0.082 0.406 0.082 c0.739 0 1.575 -0.742 2.011 -1.866 c0.516 -1.335 0.273 -2.7 -0.54 -3.052 z M14.7 13.5 c-1.1 -2 -1.441 -2.5 -2.7 -2.5 c-1.259 0 -1.736 0.755 -2.836 2.747 c-0.942 1.703 -2.846 1.845 -3.321 3.291 c-0.097 0.265 -0.145 0.677 -0.143 0.962 c0 1.176 0.787 2 1.8 2 c1.259 0 3 -1 4.5 -1 s3.241 1 4.5 1 c1.013 0 1.8 -0.823 1.8 -2 c0 -0.285 -0.049 -0.697 -0.146 -0.962 c-0.475 -1.451 -2.512 -1.835 -3.454 -3.538 z M0 0 h24 v24 H0 z";
				case IconKind.Peace:
					return "M12 12 l-6.3 6.3 M12 12 l6.3 6.3 M12 3 l0 18 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.PencilMinus:
					return "M16 18 h4 M13.5 6.5 l4 4 M8 20 l10.5 -10.5 a2.828 2.828 0 1 0 -4 -4 l-10.5 10.5 v4 h4 z M0 0 h24 v24 H0 z";
				case IconKind.PencilOff:
					return "M3 3 l18 18 M13.5 6.5 l4 4 M10 10 l-6 6 v4 h4 l6 -6 m1.99 -1.99 l2.504 -2.504 a2.828 2.828 0 1 0 -4 -4 l-2.5 2.5 M0 0 h24 v24 H0 z";
				case IconKind.PencilPlus:
					return "M16 18 h4 m-2 -2 v4 M13.5 6.5 l4 4 M8 20 l10.5 -10.5 a2.828 2.828 0 1 0 -4 -4 l-10.5 10.5 v4 h4 z M0 0 h24 v24 H0 z";
				case IconKind.Pencil:
					return "M13.5 6.5 l4 4 M4 20 h4 l10.5 -10.5 a1.5 1.5 0 0 0 -4 -4 l-10.5 10.5 v4 M0 0 h24 v24 H0 z";
				case IconKind.Pennant2Filled:
					return "M14 4 l-9 4 l9 4 M14 21 v-18 M16 21 h-4 M0 0 h24 v24 H0 z";
				case IconKind.Pennant2:
					return "M14 4 l-9 4 l9 4 M14 21 v-18 M16 21 h-4 M0 0 h24 v24 H0 z";
				case IconKind.PennantFilled:
					return "M10 4 l9 4 l-9 4 M10 21 l0 -18 M8 21 l4 0 M0 0 h24 v24 H0 z";
				case IconKind.PennantOff:
					return "M3 3 l18 18 M10 4 l9 4 l-4.858 2.16 m-2.764 1.227 l-1.378 0.613 M10 21 v-11 m0 -4 v-3 M8 21 h4 M0 0 h24 v24 H0 z";
				case IconKind.Pennant:
					return "M10 4 l9 4 l-9 4 M10 21 l0 -18 M8 21 l4 0 M0 0 h24 v24 H0 z";
				case IconKind.PentagonFilled:
					return "M13.2 3.394 l7.033 5.237 a2 2 0 0 1 0.7 2.247 l-2.973 8.764 a2 2 0 0 1 -1.894 1.358 h-8.12 a2 2 0 0 1 -1.9 -1.373 l-2.896 -8.765 a2 2 0 0 1 0.696 -2.225 l6.958 -5.237 a2 2 0 0 1 2.397 0 h0 z M0 0 h24 v24 H0 z";
				case IconKind.PentagonOff:
					return "M3 3 l18 18 M8.868 4.857 l1.936 -1.457 a2 2 0 0 1 2.397 0 l7.032 5.237 a2 2 0 0 1 0.7 2.247 l-1.522 4.485 m-1.027 3.029 l-0.424 1.25 a2 2 0 0 1 -1.894 1.358 h-8.12 a2 2 0 0 1 -1.9 -1.373 l-2.896 -8.765 a2 2 0 0 1 0.696 -2.225 l2.736 -2.06 M0 0 h24 v24 H0 z";
				case IconKind.Pentagon:
					return "M13.2 3.394 l7.033 5.237 a2 2 0 0 1 0.7 2.247 l-2.973 8.764 a2 2 0 0 1 -1.894 1.358 h-8.12 a2 2 0 0 1 -1.9 -1.373 l-2.896 -8.765 a2 2 0 0 1 0.696 -2.225 l6.958 -5.237 a2 2 0 0 1 2.397 0 z M0 0 h24 v24 H0 z";
				case IconKind.Pentagram:
					return "M15.236 11 l5.264 4 h-6.5 l-2 6 l-2 -6 h-6.5 l5.276 -4 l-2.056 -6.28 l5.28 3.78 l5.28 -3.78 z M5.636 5.636 a9 9 0 1 1 12.728 12.728 a9 9 0 0 1 -12.728 -12.728 z M0 0 h24 v24 H0 z";
				case IconKind.PepperOff:
					return "M3 3 l18 18 M16 8 c0 -2 2 -4 4 -4 M12.59 12.59 c-0.77 1.418 -2.535 2.41 -4.59 2.41 c-2.761 0 -5 -1.79 -5 -4 a8 8 0 0 0 13.643 5.67 m1.64 -2.357 a7.97 7.97 0 0 0 0.717 -3.313 a3 3 0 0 0 -5.545 -1.59 M0 0 h24 v24 H0 z";
				case IconKind.Pepper:
					return "M16 8 c0 -2 2 -4 4 -4 M13 11 c0 2.21 -2.239 4 -5 4 s-5 -1.79 -5 -4 a8 8 0 1 0 16 0 a3 3 0 0 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.Percentage:
					return "M6 18 l12 -12 M7 7 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M17 17 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.Perfume:
					return "M9 3 h6 v3 h-6 z M12 15 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 9 m0 2 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 z M14 6 v3 M10 6 v3 M0 0 h24 v24 H0 z";
				case IconKind.PerspectiveOff:
					return "M3 3 l18 18 M8.511 4.502 l9.63 1.375 a1 1 0 0 1 0.859 0.99 v8.133 m-0.859 3.123 l-12 1.714 a1 1 0 0 1 -1.141 -0.99 v-13.694 a1 1 0 0 1 0.01 -0.137 M0 0 h24 v24 H0 z";
				case IconKind.Perspective:
					return "M6.141 4.163 l12 1.714 a1 1 0 0 1 0.859 0.99 v10.266 a1 1 0 0 1 -0.859 0.99 l-12 1.714 a1 1 0 0 1 -1.141 -0.99 v-13.694 a1 1 0 0 1 1.141 -0.99 z M0 0 h24 v24 H0 z";
				case IconKind.PhoneCall:
					return "M15 3 a6 6 0 0 1 6 6 M15 7 a2 2 0 0 1 2 2 M5 4 h4 l2 5 l-2.5 1.5 a11 11 0 0 0 5 5 l1.5 -2.5 l5 2 v4 a2 2 0 0 1 -2 2 a16 16 0 0 1 -15 -15 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.PhoneCalling:
					return "M21 7 l0 0.01 M18 7 l0 0.01 M15 7 l0 0.01 M5 4 h4 l2 5 l-2.5 1.5 a11 11 0 0 0 5 5 l1.5 -2.5 l5 2 v4 a2 2 0 0 1 -2 2 a16 16 0 0 1 -15 -15 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.PhoneCheck:
					return "M15 6 l2 2 l4 -4 M5 4 h4 l2 5 l-2.5 1.5 a11 11 0 0 0 5 5 l1.5 -2.5 l5 2 v4 a2 2 0 0 1 -2 2 a16 16 0 0 1 -15 -15 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.PhoneIncoming:
					return "M15 5 l0 4 l4 0 M15 9 l5 -5 M5 4 h4 l2 5 l-2.5 1.5 a11 11 0 0 0 5 5 l1.5 -2.5 l5 2 v4 a2 2 0 0 1 -2 2 a16 16 0 0 1 -15 -15 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.PhoneOff:
					return "M5.831 14.161 a15.946 15.946 0 0 1 -2.831 -8.161 a2 2 0 0 1 2 -2 h4 l2 5 l-2.5 1.5 c0.108 0.22 0.223 0.435 0.345 0.645 m1.751 2.277 c0.843 0.84 1.822 1.544 2.904 2.078 l1.5 -2.5 l5 2 v4 a2 2 0 0 1 -2 2 a15.963 15.963 0 0 1 -10.344 -4.657 M3 21 l18 -18 M0 0 h24 v24 H0 z";
				case IconKind.PhoneOutgoing:
					return "M16 4 l4 0 l0 4 M15 9 l5 -5 M5 4 h4 l2 5 l-2.5 1.5 a11 11 0 0 0 5 5 l1.5 -2.5 l5 2 v4 a2 2 0 0 1 -2 2 a16 16 0 0 1 -15 -15 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.PhonePause:
					return "M16 3 l0 4 M20 3 l0 4 M5 4 h4 l2 5 l-2.5 1.5 a11 11 0 0 0 5 5 l1.5 -2.5 l5 2 v4 a2 2 0 0 1 -2 2 a16 16 0 0 1 -15 -15 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.PhonePlus:
					return "M15 6 h6 m-3 -3 v6 M5 4 h4 l2 5 l-2.5 1.5 a11 11 0 0 0 5 5 l1.5 -2.5 l5 2 v4 a2 2 0 0 1 -2 2 a16 16 0 0 1 -15 -15 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.PhoneX:
					return "M16 4 l4 4 m0 -4 l-4 4 M5 4 h4 l2 5 l-2.5 1.5 a11 11 0 0 0 5 5 l1.5 -2.5 l5 2 v4 a2 2 0 0 1 -2 2 a16 16 0 0 1 -15 -15 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.Phone:
					return "M5 4 h4 l2 5 l-2.5 1.5 a11 11 0 0 0 5 5 l1.5 -2.5 l5 2 v4 a2 2 0 0 1 -2 2 a16 16 0 0 1 -15 -15 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.PhotoCancel:
					return "M17 21 l4 -4 M19 19 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M14 14 l1 -1 c0.553 -0.532 1.182 -0.747 1.796 -0.645 M4 15 l4 -4 c0.928 -0.893 2.072 -0.893 3 0 l3 3 M12 20 h-5 a3 3 0 0 1 -3 -3 v-10 a3 3 0 0 1 3 -3 h10 a3 3 0 0 1 3 3 v5 M15 8 h0.01 M0 0 h24 v24 H0 z";
				case IconKind.PhotoCheck:
					return "M15 19 l2 2 l4 -4 M14 14 l1 -1 c0.928 -0.893 2.072 -0.893 3 0 M4 15 l4 -4 c0.928 -0.893 2.072 -0.893 3 0 l4 4 M11 20 h-4 a3 3 0 0 1 -3 -3 v-10 a3 3 0 0 1 3 -3 h10 a3 3 0 0 1 3 3 v6 M15 8 h0.01 M0 0 h24 v24 H0 z";
				case IconKind.PhotoDown:
					return "M22 19 l-3 3 l-3 -3 M19 16 v6 M14 14 l1 -1 c0.617 -0.593 1.328 -0.793 2.009 -0.598 M4 15 l4 -4 c0.928 -0.893 2.072 -0.893 3 0 l4 4 M12 20 h-5 a3 3 0 0 1 -3 -3 v-10 a3 3 0 0 1 3 -3 h10 a3 3 0 0 1 3 3 v5 M15 8 h0.01 M0 0 h24 v24 H0 z";
				case IconKind.PhotoEdit:
					return "M18.42 15.61 a2.1 2.1 0 0 1 2.97 2.97 l-3.39 3.42 h-3 v-3 l3.42 -3.39 z M14 14 l1 -1 c0.31 -0.298 0.644 -0.497 0.987 -0.596 M4 15 l4 -4 c0.928 -0.893 2.072 -0.893 3 0 l3 3 M11 20 h-4 a3 3 0 0 1 -3 -3 v-10 a3 3 0 0 1 3 -3 h10 a3 3 0 0 1 3 3 v4 M15 8 h0.01 M0 0 h24 v24 H0 z";
				case IconKind.PhotoHeart:
					return "M19 21.5 l2.518 -2.58 a1.74 1.74 0 0 0 0 -2.413 a1.627 1.627 0 0 0 -2.346 0 l-0.168 0.172 l-0.168 -0.172 a1.627 1.627 0 0 0 -2.346 0 a1.74 1.74 0 0 0 0 2.412 l2.51 2.59 z M4 15 l4 -4 c0.928 -0.893 2.072 -0.893 3 0 l2.5 2.5 M12.5 20 h-5.5 a3 3 0 0 1 -3 -3 v-10 a3 3 0 0 1 3 -3 h10 a3 3 0 0 1 3 3 v5 M15 8 h0.01 M0 0 h24 v24 H0 z";
				case IconKind.PhotoMinus:
					return "M16 19 h6 M14 14 l1 -1 c0.928 -0.893 2.072 -0.893 3 0 l2 2 M4 15 l4 -4 c0.928 -0.893 2.072 -0.893 3 0 l4 4 M12 20 h-5 a3 3 0 0 1 -3 -3 v-10 a3 3 0 0 1 3 -3 h10 a3 3 0 0 1 3 3 v8 M15 8 h0.01 M0 0 h24 v24 H0 z";
				case IconKind.PhotoOff:
					return "M16.32 12.34 c0.577 -0.059 1.162 0.162 1.68 0.66 l2 2 M4 15 l4 -4 c0.928 -0.893 2.072 -0.893 3 0 l5 5 M19.121 19.122 a3 3 0 0 1 -2.121 0.878 h-10 a3 3 0 0 1 -3 -3 v-10 c0 -0.833 0.34 -1.587 0.888 -2.131 m3.112 -0.869 h9 a3 3 0 0 1 3 3 v9 M15 8 l0.01 0 M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.PhotoPlus:
					return "M19 16 v6 M16 19 h6 M14 14 l1 -1 c0.617 -0.593 1.328 -0.793 2.009 -0.598 M4 15 l4 -4 c0.928 -0.893 2.072 -0.893 3 0 l4 4 M12 20 h-5 a3 3 0 0 1 -3 -3 v-10 a3 3 0 0 1 3 -3 h10 a3 3 0 0 1 3 3 v5 M15 8 h0.01 M0 0 h24 v24 H0 z";
				case IconKind.PhotoSearch:
					return "M20.2 20.2 l1.8 1.8 M18 18 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M4 15 l4 -4 c0.928 -0.893 2.072 -0.893 3 0 l2 2 M12 20 h-5 a3 3 0 0 1 -3 -3 v-10 a3 3 0 0 1 3 -3 h10 a3 3 0 0 1 3 3 v4.5 M15 8 h0.01 M0 0 h24 v24 H0 z";
				case IconKind.PhotoShield:
					return "M22 16 c0 4 -2.5 6 -3.5 6 s-3.5 -2 -3.5 -6 c1 0 2.5 -0.5 3.5 -1.5 c1 1 2.5 1.5 3.5 1.5 z M4 15 l4 -4 c0.928 -0.893 2.072 -0.893 3 0 l1.5 1.5 M11.5 20 h-4.5 a3 3 0 0 1 -3 -3 v-10 a3 3 0 0 1 3 -3 h10 a3 3 0 0 1 3 3 v4 M15 8 h0.01 M0 0 h24 v24 H0 z";
				case IconKind.PhotoStar:
					return "M17.8 20.817 l-2.172 1.138 a0.392 0.392 0 0 1 -0.568 -0.41 l0.415 -2.411 l-1.757 -1.707 a0.389 0.389 0 0 1 0.217 -0.665 l2.428 -0.352 l1.086 -2.193 a0.392 0.392 0 0 1 0.702 0 l1.086 2.193 l2.428 0.352 a0.39 0.39 0 0 1 0.217 0.665 l-1.757 1.707 l0.414 2.41 a0.39 0.39 0 0 1 -0.567 0.411 l-2.172 -1.138 z M4 15 l4 -4 c0.928 -0.893 2.072 -0.893 3 0 l2 2 M11 20 h-4 a3 3 0 0 1 -3 -3 v-10 a3 3 0 0 1 3 -3 h10 a3 3 0 0 1 3 3 v3.5 M15 8 h0.01 M0 0 h24 v24 H0 z";
				case IconKind.PhotoUp:
					return "M22 19 l-3 -3 l-3 3 M19 22 v-6 M14 14 l1 -1 c0.617 -0.593 1.328 -0.793 2.009 -0.598 M4 15 l4 -4 c0.928 -0.893 2.072 -0.893 3 0 l4 4 M12 20 h-5 a3 3 0 0 1 -3 -3 v-10 a3 3 0 0 1 3 -3 h10 a3 3 0 0 1 3 3 v5 M15 8 h0.01 M0 0 h24 v24 H0 z";
				case IconKind.PhotoX:
					return "M16.5 21.5 l5 -5 M21.5 21.5 l-5 -5 M4 15 l4 -4 c0.928 -0.893 2.072 -0.893 3 0 l2.5 2.5 M13 20 h-6 a3 3 0 0 1 -3 -3 v-10 a3 3 0 0 1 3 -3 h10 a3 3 0 0 1 3 3 v6 M15 8 h0.01 M0 0 h24 v24 H0 z";
				case IconKind.Photo:
					return "M14 14 l1 -1 a3 5 0 0 1 3 0 l2 2 M4 15 l4 -4 a3 5 0 0 1 3 0 l5 5 M4 4 m0 3 a3 3 0 0 1 3 -3 h10 a3 3 0 0 1 3 3 v10 a3 3 0 0 1 -3 3 h-10 a3 3 0 0 1 -3 -3 z M15 8 l0.01 0 M0 0 h24 v24 H0 z";
				case IconKind.Physotherapist:
					return "M18 20 h3 M8 20 h7 l1 -4 l4 -2 M12 17 v-7 M12 6 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M4 19 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M9 15 l-1 -3 l4 -2 l4 1 h3.5 M0 0 h24 v24 H0 z";
				case IconKind.PictureInPictureOff:
					return "M7 12 v-3 h3 M7 9 l4 4 M14 14 m0 1 a1 1 0 0 1 1 -1 h5 a1 1 0 0 1 1 1 v3 a1 1 0 0 1 -1 1 h-5 a1 1 0 0 1 -1 -1 z M11 19 h-6 a2 2 0 0 1 -2 -2 v-10 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v4 M0 0 h24 v24 H0 z";
				case IconKind.PictureInPictureOn:
					return "M8 13 h3 v-3 M7 9 l4 4 M14 14 m0 1 a1 1 0 0 1 1 -1 h5 a1 1 0 0 1 1 1 v3 a1 1 0 0 1 -1 1 h-5 a1 1 0 0 1 -1 -1 z M11 19 h-6 a2 2 0 0 1 -2 -2 v-10 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v4 M0 0 h24 v24 H0 z";
				case IconKind.PictureInPictureTop:
					return "M15 10 h5 a1 1 0 0 0 1 -1 v-3 a1 1 0 0 0 -1 -1 h-5 a1 1 0 0 0 -1 1 v3 a1 1 0 0 0 1 1 z M11 5 h-6 a2 2 0 0 0 -2 2 v10 a2 2 0 0 0 2 2 h14 a2 2 0 0 0 2 -2 v-4 M0 0 h24 v24 H0 z";
				case IconKind.PictureInPicture:
					return "M14 14 m0 1 a1 1 0 0 1 1 -1 h5 a1 1 0 0 1 1 1 v3 a1 1 0 0 1 -1 1 h-5 a1 1 0 0 1 -1 -1 z M11 19 h-6 a2 2 0 0 1 -2 -2 v-10 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v4 M0 0 h24 v24 H0 z";
				case IconKind.PigMoney:
					return "M16 4 v3.803 a6.019 6.019 0 0 1 2.658 3.197 h1.341 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-1.342 c-0.336 0.95 -0.907 1.8 -1.658 2.473 v2.027 a1.5 1.5 0 0 1 -3 0 v-0.583 a6.04 6.04 0 0 1 -1 0.083 h-4 a6.04 6.04 0 0 1 -1 -0.083 v0.583 a1.5 1.5 0 0 1 -3 0 v-2 l0 -0.027 a6 6 0 0 1 4 -10.473 h2.5 l4.5 -3 h0 z M5.173 8.378 a3 3 0 1 1 4.656 -1.377 M15 11 v0.01 M0 0 h24 v24 H0 z";
				case IconKind.PigOff:
					return "M3 3 l18 18 M10 6 h1.499 l4.5 -3 l0 3.803 a6.019 6.019 0 0 1 2.658 3.197 h1.341 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-1.342 c-0.057 0.16 -0.12 0.318 -0.19 0.472 m-1.467 2.528 v1.5 a1.5 1.5 0 0 1 -3 0 v-0.583 a6.04 6.04 0 0 1 -1 0.083 h-4 a6.04 6.04 0 0 1 -1 -0.083 v0.583 a1.5 1.5 0 0 1 -3 0 v-2 l0 -0.027 a6 6 0 0 1 1.5 -9.928 M15 11 v0.01 M0 0 h24 v24 H0 z";
				case IconKind.Pig:
					return "M16 3 l0 3.803 a6.019 6.019 0 0 1 2.658 3.197 h1.341 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-1.342 a6.008 6.008 0 0 1 -1.658 2.473 v2.027 a1.5 1.5 0 0 1 -3 0 v-0.583 a6.04 6.04 0 0 1 -1 0.083 h-4 a6.04 6.04 0 0 1 -1 -0.083 v0.583 a1.5 1.5 0 0 1 -3 0 v-2 l0 -0.027 a6 6 0 0 1 4 -10.473 h2.5 l4.5 -3 z M15 11 v0.01 M0 0 h24 v24 H0 z";
				case IconKind.Pilcrow:
					return "M19 4 h-9.5 a4.5 4.5 0 0 0 0 9 h3.5 M17 4 v16 M13 4 v16 M0 0 h24 v24 H0 z";
				case IconKind.PillOff:
					return "M3 3 l18 18 M8.5 8.5 l7 7 M10.495 6.505 l2 -2 a4.95 4.95 0 0 1 7 7 l-2 2 m-2 2 l-4 4 a4.95 4.95 0 0 1 -7 -7 l4 -4 M0 0 h24 v24 H0 z";
				case IconKind.Pill:
					return "M8.5 8.5 l7 7 M4.5 12.5 l8 -8 a4.94 4.94 0 0 1 7 7 l-8 8 a4.94 4.94 0 0 1 -7 -7 M0 0 h24 v24 H0 z";
				case IconKind.Pills:
					return "M19.5 14.5 l-5 5 M4.5 4.5 l7 7 M17 17 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M8 8 m-5 0 a5 5 0 1 0 10 0 a5 5 0 1 0 -10 0 M0 0 h24 v24 H0 z";
				case IconKind.PinFilled:
					return "M14.5 4 l5.5 5.5 M9 15 l-4.5 4.5 M15 4.5 l-4 4 l-4 1.5 l-1.5 1.5 l7 7 l1.5 -1.5 l1.5 -4 l4 -4 M0 0 h24 v24 H0 z";
				case IconKind.Pin:
					return "M14.5 4 l5.5 5.5 M9 15 l-4.5 4.5 M15 4.5 l-4 4 l-4 1.5 l-1.5 1.5 l7 7 l1.5 -1.5 l1.5 -4 l4 -4 M0 0 h24 v24 H0 z";
				case IconKind.PingPong:
					return "M9.3 5.3 l9.4 9.4 M14 18 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M12.718 20.713 a7.64 7.64 0 0 1 -7.48 -12.755 l0.72 -0.72 a7.643 7.643 0 0 1 9.105 -1.283 l2.387 -2.345 a2.08 2.08 0 0 1 3.057 2.815 l-0.116 0.126 l-2.346 2.387 a7.644 7.644 0 0 1 -1.052 8.864 M0 0 h24 v24 H0 z";
				case IconKind.PinnedFilled:
					return "M8 4 l8 0 M12 16 l0 5 M9 4 v6 l-2 4 v2 h10 v-2 l-2 -4 v-6 M0 0 h24 v24 H0 z";
				case IconKind.PinnedOff:
					return "M14.5 4 l5.5 5.5 M9 15 l-4.5 4.5 M15 4.5 l-3.249 3.249 m-2.57 1.433 l-2.181 0.818 l-1.5 1.5 l7 7 l1.5 -1.5 l0.82 -2.186 m1.43 -2.563 l3.25 -3.251 M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.Pinned:
					return "M8 4 l8 0 M12 16 l0 5 M9 4 v6 l-2 4 v2 h10 v-2 l-2 -4 v-6 M0 0 h24 v24 H0 z";
				case IconKind.PizzaOff:
					return "M3 3 l18 18 M11 14 v-0.01 M5.38 15.866 a14.94 14.94 0 0 0 6.815 1.634 c1.56 0 3.105 -0.24 4.582 -0.713 M10.313 6.277 l1.687 -3.277 l5.34 10.376 m2.477 6.463 a19.093 19.093 0 0 1 -7.817 1.661 c-3.04 0 -5.952 -0.714 -8.5 -1.983 l5.434 -10.559 M0 0 h24 v24 H0 z";
				case IconKind.Pizza:
					return "M11 14 v-0.01 M13 11.01 v-0.01 M5.38 15.866 a14.94 14.94 0 0 0 6.815 1.634 a14.944 14.944 0 0 0 6.502 -1.479 M12 21.5 c-3.04 0 -5.952 -0.714 -8.5 -1.983 l8.5 -16.517 l8.5 16.517 a19.09 19.09 0 0 1 -8.5 1.983 z M0 0 h24 v24 H0 z";
				case IconKind.Placeholder:
					return "M7 17 l4 -4 l-4 -4 l-4 4 z M13 8 l-3 -3 l3 -3 M10 20.415 a8 8 0 1 0 3 -15.415 h-3 M0 0 h24 v24 H0 z";
				case IconKind.PlaneArrival:
					return "M3 21 h18 M15.157 11.81 l4.83 1.295 a2 2 0 1 1 -1.036 3.863 l-14.489 -3.882 l-1.345 -6.572 l2.898 0.776 l1.414 2.45 l2.898 0.776 l-0.12 -7.279 l2.898 0.777 l2.052 7.797 z M0 0 h24 v24 H0 z";
				case IconKind.PlaneDeparture:
					return "M3 21 h18 M14.639 10.258 l4.83 -1.294 a2 2 0 1 1 1.035 3.863 l-14.489 3.883 l-4.45 -5.02 l2.897 -0.776 l2.45 1.414 l2.897 -0.776 l-3.743 -6.244 l2.898 -0.777 l5.675 5.727 z M0 0 h24 v24 H0 z";
				case IconKind.PlaneInflight:
					return "M3 21 h18 M15 11.085 h5 a2 2 0 1 1 0 4 h-15 l-3 -6 h3 l2 2 h3 l-2 -7 h3 l4 7 z M0 0 h24 v24 H0 z";
				case IconKind.PlaneOff:
					return "M3 3 l18 18 M9.788 5.758 l-0.788 -2.758 h3 l4 7 h4 a2 2 0 1 1 0 4 h-2 m-2.718 1.256 l-3.282 5.744 h-3 l2 -7 h-4 l-2 2 h-3 l2 -4 l-2 -4 h3 l2 2 h3 M0 0 h24 v24 H0 z";
				case IconKind.PlaneTilt:
					return "M14.5 6.5 l3 -2.9 a2.05 2.05 0 0 1 2.9 2.9 l-2.9 3 l2.5 7.5 l-2.5 2.55 l-3.5 -6.55 l-3 3 v3 l-2 2 l-1.5 -4.5 l-4.5 -1.5 l2 -2 h3 l3 -3 l-6.5 -3.5 l2.5 -2.5 l7.5 2.5 z M0 0 h24 v24 H0 z";
				case IconKind.Plane:
					return "M16 10 h4 a2 2 0 0 1 0 4 h-4 l-4 7 h-3 l2 -7 h-4 l-2 2 h-3 l2 -4 l-2 -4 h3 l2 2 h4 l-2 -7 h3 z M0 0 h24 v24 H0 z";
				case IconKind.PlanetOff:
					return "M3 3 l18 18 M7.042 7.059 a7 7 0 0 0 9.908 9.89 m1.581 -2.425 a7 7 0 0 0 -9.057 -9.054 M18.816 13.58 c1.956 1.825 3.157 3.449 3.184 4.445 m-3.428 0.593 c-2.098 -0.634 -4.944 -2.03 -7.919 -3.976 c-5.47 -3.579 -9.304 -7.664 -8.56 -9.123 c0.32 -0.628 1.591 -0.6 3.294 -0.113 M0 0 h24 v24 H0 z";
				case IconKind.Planet:
					return "M12 12 m-7 0 a7 7 0 1 0 14 0 a7 7 0 1 0 -14 0 M18.816 13.58 c2.292 2.138 3.546 4 3.092 4.9 c-0.745 1.46 -5.783 -0.259 -11.255 -3.838 c-5.47 -3.579 -9.304 -7.664 -8.56 -9.123 c0.464 -0.91 2.926 -0.444 5.803 0.805 M0 0 h24 v24 H0 z";
				case IconKind.Plant2Off:
					return "M3 3 l18 18 M9.01 11.5 a9.696 9.696 0 0 1 0.163 -2.318 m1.082 -2.942 a9.696 9.696 0 0 1 1.745 -2.24 M12 4 a9.7 9.7 0 0 1 3 7.013 M2 9 a10 10 0 0 1 10 10 M12 19 c0 -1.988 0.58 -3.84 1.58 -5.397 m1.878 -2.167 a9.961 9.961 0 0 1 6.542 -2.436 M2 9 c0 5.523 4.477 10 10 10 a9.953 9.953 0 0 0 5.418 -1.593 m2.137 -1.855 a9.961 9.961 0 0 0 2.445 -6.552 M0 0 h24 v24 H0 z";
				case IconKind.Plant2:
					return "M9.01 11.5 a9.7 9.7 0 0 1 2.99 -7.5 M12 4 a9.7 9.7 0 0 1 2.99 7.5 M2 9 a10 10 0 0 1 10 10 M12 19 a10 10 0 0 1 10 -10 M2 9 a10 10 0 1 0 20 0 M0 0 h24 v24 H0 z";
				case IconKind.PlantOff:
					return "M3 3 l18 18 M12 15 v-3 M12.531 8.528 a6 6 0 0 1 5.469 -3.528 h3 v1 a6 6 0 0 1 -5.037 5.923 M11.9 7.908 a6 6 0 0 0 -4.79 -4.806 m-4.11 -0.102 v2 a6 6 0 0 0 6 6 h2 M17 17 v2 a2 2 0 0 1 -2 2 h-6 a2 2 0 0 1 -2 -2 v-4 h8 M0 0 h24 v24 H0 z";
				case IconKind.Plant:
					return "M12 15 l0 -6 M12 11 a6 6 0 0 1 6 -6 h3 v1 a6 6 0 0 1 -6 6 h-3 M12 9 a6 6 0 0 0 -6 -6 h-3 v2 a6 6 0 0 0 6 6 h3 M7 15 h10 v4 a2 2 0 0 1 -2 2 h-6 a2 2 0 0 1 -2 -2 v-4 z M0 0 h24 v24 H0 z";
				case IconKind.PlayCardOff:
					return "M3 3 l18 18 M13.716 13.712 l-1.716 2.288 l-3 -4 l1.29 -1.72 M16 18 h0.01 M7 3 h10 a2 2 0 0 1 2 2 v10 m0 4 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 v-14 M0 0 h24 v24 H0 z";
				case IconKind.PlayCard:
					return "M12 16 l-3 -4 l3 -4 l3 4 z M16 18 h0.01 M8 6 h0.01 M19 5 v14 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 v-14 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 z M0 0 h24 v24 H0 z";
				case IconKind.PlayerEjectFilled:
					return "M5 16 m0 1 a1 1 0 0 1 1 -1 h12 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-12 a1 1 0 0 1 -1 -1 z M5 12 h14 l-7 -8 z M0 0 h24 v24 H0 z";
				case IconKind.PlayerEject:
					return "M5 16 m0 1 a1 1 0 0 1 1 -1 h12 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-12 a1 1 0 0 1 -1 -1 z M5 12 h14 l-7 -8 z M0 0 h24 v24 H0 z";
				case IconKind.PlayerPauseFilled:
					return "M14 5 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v12 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M6 5 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v12 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.PlayerPause:
					return "M14 5 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v12 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M6 5 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v12 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.PlayerPlayFilled:
					return "M7 4 v16 l13 -8 z M0 0 h24 v24 H0 z";
				case IconKind.PlayerPlay:
					return "M7 4 v16 l13 -8 z M0 0 h24 v24 H0 z";
				case IconKind.PlayerRecordFilled:
					return "M12 12 m-7 0 a7 7 0 1 0 14 0 a7 7 0 1 0 -14 0 M0 0 h24 v24 H0 z";
				case IconKind.PlayerRecord:
					return "M12 12 m-7 0 a7 7 0 1 0 14 0 a7 7 0 1 0 -14 0 M0 0 h24 v24 H0 z";
				case IconKind.PlayerSkipBackFilled:
					return "M4 5 l0 14 M20 5 v14 l-12 -7 z M0 0 h24 v24 H0 z";
				case IconKind.PlayerSkipBack:
					return "M4 5 l0 14 M20 5 v14 l-12 -7 z M0 0 h24 v24 H0 z";
				case IconKind.PlayerSkipForwardFilled:
					return "M20 5 l0 14 M4 5 v14 l12 -7 z M0 0 h24 v24 H0 z";
				case IconKind.PlayerSkipForward:
					return "M20 5 l0 14 M4 5 v14 l12 -7 z M0 0 h24 v24 H0 z";
				case IconKind.PlayerStopFilled:
					return "M5 5 m0 2 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.PlayerStop:
					return "M5 5 m0 2 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.PlayerTrackNextFilled:
					return "M14 5 v14 l8 -7 z M3 5 v14 l8 -7 z M0 0 h24 v24 H0 z";
				case IconKind.PlayerTrackNext:
					return "M14 5 v14 l8 -7 z M3 5 v14 l8 -7 z M0 0 h24 v24 H0 z";
				case IconKind.PlayerTrackPrevFilled:
					return "M10 5 v14 l-8 -7 z M21 5 v14 l-8 -7 z M0 0 h24 v24 H0 z";
				case IconKind.PlayerTrackPrev:
					return "M10 5 v14 l-8 -7 z M21 5 v14 l-8 -7 z M0 0 h24 v24 H0 z";
				case IconKind.PlaylistAdd:
					return "M18 13 v6 M15 16 h6 M11 16 h-6 M5 12 h9 M19 8 h-14 M0 0 h24 v24 H0 z";
				case IconKind.PlaylistOff:
					return "M3 3 l18 18 M9 13 h-6 M3 9 h6 M13 5 h-4 m-4 0 h-2 M17 13 v-9 h4 M14 14 a3 3 0 1 0 3 3 M0 0 h24 v24 H0 z";
				case IconKind.PlaylistX:
					return "M20 14 l-4 4 M16 14 l4 4 M12 16 h-7 M5 12 h7 M19 8 h-14 M0 0 h24 v24 H0 z";
				case IconKind.Playlist:
					return "M9 13 h-6 M3 9 l10 0 M13 5 h-10 M17 17 v-13 h4 M14 17 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.PlaystationCircle:
					return "M12 12 m-4.5 0 a4.5 4.5 0 1 0 9 0 a4.5 4.5 0 1 0 -9 0 M12 21 a9 9 0 0 0 9 -9 a9 9 0 0 0 -9 -9 a9 9 0 0 0 -9 9 a9 9 0 0 0 9 9 z M0 0 h24 v24 H0 z";
				case IconKind.PlaystationSquare:
					return "M8 8 m0 1 a1 1 0 0 1 1 -1 h6 a1 1 0 0 1 1 1 v6 a1 1 0 0 1 -1 1 h-6 a1 1 0 0 1 -1 -1 z M12 21 a9 9 0 0 0 9 -9 a9 9 0 0 0 -9 -9 a9 9 0 0 0 -9 9 a9 9 0 0 0 9 9 z M0 0 h24 v24 H0 z";
				case IconKind.PlaystationTriangle:
					return "M7.5 15 h9 l-4.5 -8 z M12 21 a9 9 0 0 0 9 -9 a9 9 0 0 0 -9 -9 a9 9 0 0 0 -9 9 a9 9 0 0 0 9 9 z M0 0 h24 v24 H0 z";
				case IconKind.PlaystationX:
					return "M8.5 15.5 l7 -7 M8.5 8.5 l7 7 M12 21 a9 9 0 0 0 9 -9 a9 9 0 0 0 -9 -9 a9 9 0 0 0 -9 9 a9 9 0 0 0 9 9 z M0 0 h24 v24 H0 z";
				case IconKind.PlugConnectedX:
					return "M16 16 l4 4 M13 14 l-2 2 M10 11 l-2 2 M18.5 5.5 l2.5 -2.5 M3 21 l2.5 -2.5 M17 12 l-5 -5 l1.5 -1.5 a3.536 3.536 0 1 1 5 5 l-1.5 1.5 z M7 12 l5 5 l-1.5 1.5 a3.536 3.536 0 1 1 -5 -5 l1.5 -1.5 z M20 16 l-4 4 M0 0 h24 v24 H0 z";
				case IconKind.PlugConnected:
					return "M13 14 l-2 2 M10 11 l-2 2 M18.5 5.5 l2.5 -2.5 M3 21 l2.5 -2.5 M17 12 l-5 -5 l1.5 -1.5 a3.536 3.536 0 1 1 5 5 l-1.5 1.5 z M7 12 l5 5 l-1.5 1.5 a3.536 3.536 0 1 1 -5 -5 l1.5 -1.5 z M0 0 h24 v24 H0 z";
				case IconKind.PlugOff:
					return "M3 3 l18 18 M20 9 l-3.5 3.5 M15 4 l-3.5 3.5 M4 20 l3.5 -3.5 M16.123 16.092 l-0.177 0.177 a5.81 5.81 0 1 1 -8.215 -8.215 l0.159 -0.159 M0 0 h24 v24 H0 z";
				case IconKind.PlugX:
					return "M20 16 l-4 4 M16 16 l4 4 M20 9 l-3.5 3.5 M15 4 l-3.5 3.5 M4 20 l3.5 -3.5 M13.55 17.733 a5.806 5.806 0 0 1 -7.356 -4.052 a5.81 5.81 0 0 1 1.537 -5.627 l2.054 -2.054 l7.165 7.165 M0 0 h24 v24 H0 z";
				case IconKind.Plug:
					return "M20 9 l-3.5 3.5 M15 4 l-3.5 3.5 M4 20 l3.5 -3.5 M9.785 6 l8.215 8.215 l-2.054 2.054 a5.81 5.81 0 1 1 -8.215 -8.215 l2.054 -2.054 z M0 0 h24 v24 H0 z";
				case IconKind.Plus:
					return "M5 12 l14 0 M12 5 l0 14 M0 0 h24 v24 H0 z";
				case IconKind.Png:
					return "M10 16 v-8 l4 8 v-8 M3 16 v-8 h2 a2 2 0 1 1 0 4 h-2 M21 8 h-2 a2 2 0 0 0 -2 2 v4 a2 2 0 0 0 2 2 h2 v-4 h-1 M0 0 h24 v24 H0 z";
				case IconKind.PodiumOff:
					return "M3 3 l18 18 M7 21 h10 M15.599 15.613 l-0.599 5.387 M8 12 l1 9 M7 8 v-1 m0.864 -3.106 a2.99 2.99 0 0 1 2.136 -0.894 M12 8 h7 l-0.621 2.485 a2 2 0 0 1 -1.94 1.515 h-0.439 m-4 0 h-4.439 a2 2 0 0 1 -1.94 -1.515 l-0.621 -2.485 h3 M0 0 h24 v24 H0 z";
				case IconKind.Podium:
					return "M7 21 h10 M16 12 l-1 9 M8 12 l1 9 M7 8 v-2 a3 3 0 0 1 3 -3 M5 8 h14 l-0.621 2.485 a2 2 0 0 1 -1.94 1.515 h-8.878 a2 2 0 0 1 -1.94 -1.515 l-0.621 -2.485 z M0 0 h24 v24 H0 z";
				case IconKind.PointFilled:
					return "M12 12 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M0 0 h24 v24 H0 z";
				case IconKind.PointOff:
					return "M3 3 l18 18 M9.15 9.194 a4 4 0 0 0 5.697 5.617 m1.153 -2.811 a4 4 0 0 0 -4 -4 M0 0 h24 v24 H0 z";
				case IconKind.Point:
					return "M12 12 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M0 0 h24 v24 H0 z";
				case IconKind.Pointer:
					return "M7.904 17.563 a1.2 1.2 0 0 0 2.228 0.308 l2.09 -3.093 l4.907 4.907 a1.067 1.067 0 0 0 1.509 0 l1.047 -1.047 a1.067 1.067 0 0 0 0 -1.509 l-4.907 -4.907 l3.113 -2.09 a1.2 1.2 0 0 0 -0.309 -2.228 l-13.582 -3.904 l3.904 13.563 z M0 0 h24 v24 H0 z";
				case IconKind.PokeballOff:
					return "M3 3 l18 18 M3 12 h6 m7 0 h5 M9.884 9.874 a3 3 0 1 0 4.24 4.246 m0.57 -3.441 a3.012 3.012 0 0 0 -1.41 -1.39 M20.04 16.048 a9 9 0 0 0 -12.083 -12.09 m-2.32 1.678 a9 9 0 1 0 12.737 12.719 M0 0 h24 v24 H0 z";
				case IconKind.Pokeball:
					return "M15 12 h6 M3 12 h6 M12 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.PokerChip:
					return "M15.536 15.536 l2.828 2.828 M5.636 5.636 l2.828 2.828 M8.464 15.536 l-2.828 2.828 M18.364 5.636 l-2.828 2.828 M17 12 h4 M3 12 h4 M12 17 v4 M12 3 v4 M12 12 m-5 0 a5 5 0 1 0 10 0 a5 5 0 1 0 -10 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.Polaroid:
					return "M14 7 l0.01 0 M13 12 l2 -2 c0.928 -0.893 2.072 -0.893 3 0 l2 2 M4 12 l3 -3 c0.928 -0.893 2.072 -0.893 3 0 l4 4 M4 16 l16 0 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.PolygonOff:
					return "M3 3 l18 18 M13.5 17.5 l-7 -5 M18.5 10 l-1.185 3.318 m-1.062 2.972 l-0.253 0.71 M14 5.5 l3 1.5 M6.5 9.5 l1.546 -1.311 M15 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 11 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M19 8 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M12 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Polygon:
					return "M13.5 17.5 l-7 -5 M18.5 10 l-2.5 7 M14 5.5 l3 1.5 M6.5 9.5 l3.5 -3 M15 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 11 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M19 8 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M12 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Poo:
					return "M11 4 c2 0 3.5 1.5 3.5 4 l0.164 0 a2.5 2.5 0 0 1 2.196 3.32 a3 3 0 0 1 1.615 3.063 a3 3 0 0 1 -1.299 5.607 l-0.176 0 h-10 a3 3 0 0 1 -1.474 -5.613 a3 3 0 0 1 1.615 -3.062 a2.5 2.5 0 0 1 2.195 -3.32 l0.164 0 c1.5 0 2.5 -2 1.5 -4 z M10 16 a3.5 3.5 0 0 0 4 0 M14 12 h0.01 M10 12 h0.01 M0 0 h24 v24 H0 z";
				case IconKind.PoolOff:
					return "M3 3 l18 18 M9 10 h1 m4 0 h1 M15 5 h-6 M9 12 v-3 m0 -4 v-0.5 a1.5 1.5 0 0 0 -1.936 -1.436 M15 11 v-6.5 a1.5 1.5 0 0 1 3 0 M2 16 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 a2.4 2.4 0 0 1 2 -1 a2.4 2.4 0 0 1 2 1 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 a2.4 2.4 0 0 1 1.13 -0.856 m5.727 1.717 a2.4 2.4 0 0 0 1.143 -0.861 M2 20 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 a2.4 2.4 0 0 1 2 -1 a2.4 2.4 0 0 1 2 1 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 a2.4 2.4 0 0 1 2 -1 a2.4 2.4 0 0 1 2 1 a2.4 2.4 0 0 0 2 1 c0.303 0 0.6 -0.045 0.876 -0.146 M0 0 h24 v24 H0 z";
				case IconKind.Pool:
					return "M9 10 l6 0 M15 5 l-6 0 M9 12 v-7.5 a1.5 1.5 0 0 0 -3 0 M15 12 v-7.5 a1.5 1.5 0 0 1 3 0 M2 16 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 a2.4 2.4 0 0 1 2 -1 a2.4 2.4 0 0 1 2 1 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 a2.4 2.4 0 0 1 2 -1 a2.4 2.4 0 0 1 2 1 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 M2 20 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 a2.4 2.4 0 0 1 2 -1 a2.4 2.4 0 0 1 2 1 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 a2.4 2.4 0 0 1 2 -1 a2.4 2.4 0 0 1 2 1 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 M0 0 h24 v24 H0 z";
				case IconKind.Power:
					return "M12 4 l0 8 M7 6 a7.75 7.75 0 1 0 10 0 M0 0 h24 v24 H0 z";
				case IconKind.Pray:
					return "M7 20 h8 l-4 -4 v-7 l4 3 l2 -2 M12 5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.PremiumRights:
					return "M12 15 v2 M12 7 v2 M13.867 9.75 c-0.246 -0.48 -0.708 -0.769 -1.2 -0.75 h-1.334 c-0.736 0 -1.333 0.67 -1.333 1.5 c0 0.827 0.597 1.499 1.333 1.499 h1.334 c0.736 0 1.333 0.671 1.333 1.5 c0 0.828 -0.597 1.499 -1.333 1.499 h-1.334 c-0.492 0.019 -0.954 -0.27 -1.2 -0.75 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.Prescription:
					return "M13 21 l6 -6 M19 21 l-9 -9 M6 19 v-16 h4.5 a4.5 4.5 0 1 1 0 9 h-4.5 M0 0 h24 v24 H0 z";
				case IconKind.PresentationAnalytics:
					return "M9 20 h6 M12 16 v4 M4 4 v10 a2 2 0 0 0 2 2 h12 a2 2 0 0 0 2 -2 v-10 M3 4 h18 M12 12 v-1 M15 12 v-2 M9 12 v-4 M0 0 h24 v24 H0 z";
				case IconKind.PresentationOff:
					return "M3 3 l18 18 M8 12 l2 -2 m4 0 l2 -2 M9 20 h6 M12 16 v4 M4 4 v10 a2 2 0 0 0 2 2 h10 m3.42 -0.592 c0.359 -0.362 0.58 -0.859 0.58 -1.408 v-10 M3 4 h1 m4 0 h13 M0 0 h24 v24 H0 z";
				case IconKind.Presentation:
					return "M8 12 l3 -3 l2 2 l3 -3 M9 20 l6 0 M12 16 l0 4 M4 4 v10 a2 2 0 0 0 2 2 h12 a2 2 0 0 0 2 -2 v-10 M3 4 l18 0 M0 0 h24 v24 H0 z";
				case IconKind.PrinterOff:
					return "M3 3 l18 18 M17 17 v2 a2 2 0 0 1 -2 2 h-6 a2 2 0 0 1 -2 -2 v-4 a2 2 0 0 1 2 -2 h4 M17 9 v-4 a2 2 0 0 0 -2 -2 h-6 c-0.551 0 -1.05 0.223 -1.412 0.584 m-0.588 3.416 v2 M20.412 16.416 c0.363 -0.362 0.588 -0.863 0.588 -1.416 v-4 a2 2 0 0 0 -2 -2 h-6 m-4 0 h-4 a2 2 0 0 0 -2 2 v4 a2 2 0 0 0 2 2 h2 M0 0 h24 v24 H0 z";
				case IconKind.Printer:
					return "M7 13 m0 2 a2 2 0 0 1 2 -2 h6 a2 2 0 0 1 2 2 v4 a2 2 0 0 1 -2 2 h-6 a2 2 0 0 1 -2 -2 z M17 9 v-4 a2 2 0 0 0 -2 -2 h-6 a2 2 0 0 0 -2 2 v4 M17 17 h2 a2 2 0 0 0 2 -2 v-4 a2 2 0 0 0 -2 -2 h-14 a2 2 0 0 0 -2 2 v4 a2 2 0 0 0 2 2 h2 M0 0 h24 v24 H0 z";
				case IconKind.Prison:
					return "M8 12 h-0.01 M10 15 v5 M11 9 h-6 v6 h6 z M10 4 v5 M6 15 v5 M6 4 v5 M14 4 v16 M18 4 v16 M0 0 h24 v24 H0 z";
				case IconKind.Prompt:
					return "M13 17 l6 0 M5 7 l5 5 l-5 5 M0 0 h24 v24 H0 z";
				case IconKind.PropellerOff:
					return "M3 3 l18 18 M8.664 13 c-1.693 0.143 -3.213 0.52 -4.56 1.128 c-1.522 0.623 -2.206 2.153 -0.852 4.498 s3.02 2.517 4.321 1.512 c1.2 -0.863 2.287 -1.991 3.258 -3.386 M13.169 16.751 c0.97 1.395 2.057 2.523 3.257 3.386 c1.02 0.789 2.265 0.853 3.408 -0.288 m1.479 -2.493 c0.492 -1.634 -0.19 -2.726 -1.416 -3.229 c-0.82 -0.37 -1.703 -0.654 -2.65 -0.852 M14.272 10.272 c0.66 -1.459 1.058 -2.888 1.198 -4.286 c0.22 -1.63 -0.762 -2.986 -3.47 -2.986 c-1.94 0 -3 0.696 -3.355 1.69 m0.697 4.653 c0.145 0.384 0.309 0.77 0.491 1.157 M10.448 10.432 a3 3 0 1 0 4.106 4.143 M0 0 h24 v24 H0 z";
				case IconKind.Propeller:
					return "M8.664 13 c-1.693 0.143 -3.213 0.52 -4.56 1.128 c-1.522 0.623 -2.206 2.153 -0.852 4.498 s3.02 2.517 4.321 1.512 c1.2 -0.863 2.287 -1.991 3.258 -3.386 M13.169 16.751 c0.97 1.395 2.057 2.523 3.257 3.386 c1.3 1 2.967 0.833 4.321 -1.512 c1.354 -2.345 0.67 -3.874 -0.85 -4.498 c-1.348 -0.608 -2.868 -0.985 -4.562 -1.128 M14.167 10.5 c0.722 -1.538 1.156 -3.043 1.303 -4.514 c0.22 -1.63 -0.762 -2.986 -3.47 -2.986 s-3.69 1.357 -3.47 2.986 c0.147 1.471 0.581 2.976 1.303 4.514 M12 13 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.PumpkinScary:
					return "M12 6 c0 -1.226 0.693 -2.346 1.789 -2.894 l0.211 -0.106 M17 6.082 c2.609 0.588 3.627 4.162 2.723 7.983 c-0.903 3.82 -2.75 6.44 -5.359 5.853 a3.355 3.355 0 0 1 -0.774 -0.279 a3.728 3.728 0 0 1 -1.59 0.361 c-0.556 0 -1.09 -0.127 -1.59 -0.362 a3.296 3.296 0 0 1 -0.774 0.28 c-2.609 0.588 -4.456 -2.033 -5.36 -5.853 c-0.903 -3.82 0.115 -7.395 2.724 -7.983 c1.085 -0.244 1.575 0.066 2.585 0.787 c0.716 -0.554 1.54 -0.869 2.415 -0.869 c0.876 0 1.699 0.315 2.415 0.87 c1.01 -0.722 1.5 -1.032 2.585 -0.788 z M14 11 h0.01 M10 11 h0.01 M9 15 l1.5 1 l1.5 -1 l1.5 1 l1.5 -1 M0 0 h24 v24 H0 z";
				case IconKind.Puzzle2:
					return "M12 12 h-1.5 a0.5 0.5 0 0 0 -0.5 0.5 a1.5 1.5 0 0 1 -3 0 a0.5 0.5 0 0 0 -0.5 -0.5 h-2.5 M20 12 h-2.5 a0.5 0.5 0 0 1 -0.5 -0.5 a1.5 1.5 0 0 0 -3 0 a0.5 0.5 0 0 1 -0.5 0.5 h-1.5 M12 12 v1.5 a0.5 0.5 0 0 0 0.5 0.5 a1.5 1.5 0 0 1 0 3 a0.5 0.5 0 0 0 -0.5 0.5 v2.5 M12 4 v2.5 a0.5 0.5 0 0 1 -0.5 0.5 a1.5 1.5 0 0 0 0 3 a0.5 0.5 0 0 1 0.5 0.5 v1.5 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.PuzzleFilled:
					return "M4 7 h3 a1 1 0 0 0 1 -1 v-1 a2 2 0 1 1 4 0 v1 a1 1 0 0 0 1 1 h3 a1 1 0 0 1 1 1 v3 a1 1 0 0 0 1 1 h1 a2 2 0 1 1 0 4 h-1 a1 1 0 0 0 -1 1 v3 a1 1 0 0 1 -1 1 h-3 a1 1 0 0 1 -1 -1 v-1 a2 2 0 1 0 -4 0 v1 a1 1 0 0 1 -1 1 h-3 a1 1 0 0 1 -1 -1 v-3 a1 1 0 0 1 1 -1 h1 a2 2 0 1 0 0 -4 h-1 a1 1 0 0 1 -1 -1 v-3 a1 1 0 0 1 1 -1 M0 0 h24 v24 H0 z";
				case IconKind.PuzzleOff:
					return "M3 3 l18 18 M8.18 4.171 a2 2 0 0 1 3.82 0.829 v1 a1 1 0 0 0 1 1 h3 a1 1 0 0 1 1 1 v3 a1 1 0 0 0 1 1 h1 a2 2 0 0 1 0.819 3.825 m-2.819 1.175 v3 a1 1 0 0 1 -1 1 h-3 a1 1 0 0 1 -1 -1 v-1 a2 2 0 1 0 -4 0 v1 a1 1 0 0 1 -1 1 h-3 a1 1 0 0 1 -1 -1 v-3 a1 1 0 0 1 1 -1 h1 a2 2 0 1 0 0 -4 h-1 a1 1 0 0 1 -1 -1 v-3 a1 1 0 0 1 1 -1 h3 M0 0 h24 v24 H0 z";
				case IconKind.Puzzle:
					return "M4 7 h3 a1 1 0 0 0 1 -1 v-1 a2 2 0 0 1 4 0 v1 a1 1 0 0 0 1 1 h3 a1 1 0 0 1 1 1 v3 a1 1 0 0 0 1 1 h1 a2 2 0 0 1 0 4 h-1 a1 1 0 0 0 -1 1 v3 a1 1 0 0 1 -1 1 h-3 a1 1 0 0 1 -1 -1 v-1 a2 2 0 0 0 -4 0 v1 a1 1 0 0 1 -1 1 h-3 a1 1 0 0 1 -1 -1 v-3 a1 1 0 0 1 1 -1 h1 a2 2 0 0 0 0 -4 h-1 a1 1 0 0 1 -1 -1 v-3 a1 1 0 0 1 1 -1 M0 0 h24 v24 H0 z";
				case IconKind.PyramidOff:
					return "M3 3 l18 18 M12 3 v5 m0 4 v9 M8.483 8.471 l-5.483 8.529 l9 4 l6.22 -2.764 m2.78 -1.236 l-9 -14 l-1.937 3.014 M0 0 h24 v24 H0 z";
				case IconKind.Pyramid:
					return "M12 3 v18 M3 17 l9 4 l9 -4 l-9 -14 z M0 0 h24 v24 H0 z";
				case IconKind.QrcodeOff:
					return "M3 3 l18 18 M14 20 h3 M14 14 v3 M20 14 v0.01 M17 7 v0.01 M4 14 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M7 7 v0.01 M14 4 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M7 17 v0.01 M8 4 h1 a1 1 0 0 1 1 1 v1 m-0.297 3.711 a1 1 0 0 1 -0.703 0.289 h-4 a1 1 0 0 1 -1 -1 v-4 c0 -0.275 0.11 -0.524 0.29 -0.705 M0 0 h24 v24 H0 z";
				case IconKind.Qrcode:
					return "M20 17 l0 3 M17 17 l3 0 M14 20 l3 0 M14 14 l0 3 M20 14 l0 0.01 M14 14 l3 0 M17 7 l0 0.01 M4 14 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M7 7 l0 0.01 M14 4 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M7 17 l0 0.01 M4 4 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.QuestionCircle:
					return "M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M12 13 a2 2 0 0 0 0.914 -3.782 a1.98 1.98 0 0 0 -2.414 0.483 M12 16 v0.01 M0 0 h24 v24 H0 z";
				case IconKind.QuestionMark:
					return "M12 19 l0 0.01 M8 8 a3.5 3 0 0 1 3.5 -3 h1 a3.5 3 0 0 1 3.5 3 a3 3 0 0 1 -2 3 a3 4 0 0 0 -2 4 M0 0 h24 v24 H0 z";
				case IconKind.QuoteOff:
					return "M3 3 l18 18 M19 11 h-4 m-1 -1 v-3 a1 1 0 0 1 1 -1 h3 a1 1 0 0 1 1 1 v6 c0 0.66 -0.082 1.26 -0.245 1.798 m-1.653 2.29 c-0.571 0.4 -1.272 0.704 -2.102 0.912 M10 11 h-4 a1 1 0 0 1 -1 -1 v-3 a1 1 0 0 1 1 -1 m4 4 v3 c0 2.667 -1.333 4.333 -4 5 M0 0 h24 v24 H0 z";
				case IconKind.Quote:
					return "M19 11 h-4 a1 1 0 0 1 -1 -1 v-3 a1 1 0 0 1 1 -1 h3 a1 1 0 0 1 1 1 v6 c0 2.667 -1.333 4.333 -4 5 M10 11 h-4 a1 1 0 0 1 -1 -1 v-3 a1 1 0 0 1 1 -1 h3 a1 1 0 0 1 1 1 v6 c0 2.667 -1.333 4.333 -4 5 M0 0 h24 v24 H0 z";
				case IconKind.Radar2:
					return "M12 12 v9 M18.832 17.86 a9 9 0 1 0 -6.832 3.14 M15.51 15.56 a5 5 0 1 0 -3.51 1.44 M12 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.RadarOff:
					return "M3 3 l18 18 M20.486 9 a9 9 0 0 0 -12.525 -5.032 m-2.317 1.675 a9 9 0 0 0 3.36 14.852 M16 9 a5 5 0 0 0 -5.063 -1.88 m-2.466 1.347 a5 5 0 0 0 0.53 7.535 M11.291 11.295 a1 1 0 0 0 0.709 1.705 v8 c2.488 0 4.74 -1.01 6.37 -2.642 m1.675 -2.319 a8.962 8.962 0 0 0 0.955 -4.039 h-5 M0 0 h24 v24 H0 z";
				case IconKind.Radar:
					return "M20.486 9 a9 9 0 1 0 -11.482 11.495 M16 9 a5 5 0 1 0 -7 7 M21 12 h-8 a1 1 0 1 0 -1 1 v8 a9 9 0 0 0 9 -9 M0 0 h24 v24 H0 z";
				case IconKind.RadioOff:
					return "M3 3 l18 18 M13 16 v0.01 M7 12 v-2 M4 12 h8 m4 0 h4 M14 3 l-4.986 2 m-2.875 1.15 l-1.51 0.604 a1 1 0 0 0 -0.629 0.928 v11.323 a1 1 0 0 0 1 1 h14 a1 1 0 0 0 0.708 -0.294 m0.292 -3.706 v-8 a1 1 0 0 0 -1 -1 h-8 m-4 0 h-2.5 M0 0 h24 v24 H0 z";
				case IconKind.Radio:
					return "M13 16 v0.01 M17 16 v0.01 M7 12 v-2 M4 12 h16 M14 3 l-9.371 3.749 a1 1 0 0 0 -0.629 0.928 v11.323 a1 1 0 0 0 1 1 h14 a1 1 0 0 0 1 -1 v-11 a1 1 0 0 0 -1 -1 h-14.5 M0 0 h24 v24 H0 z";
				case IconKind.RadioactiveOff:
					return "M3 3 l18 18 M10.5 14.6 l-3 5.19 a9 9 0 0 1 -4.5 -7.79 h6 a3 3 0 0 0 1.5 2.6 M13.5 9.4 l3 -5.19 a9 9 0 0 0 -8.536 -0.25 M14.118 14.127 c-0.182 0.181 -0.39 0.341 -0.618 0.473 l3 5.19 a9 9 0 0 0 1.856 -1.423 m1.68 -2.32 a8.993 8.993 0 0 0 0.964 -4.047 h-5 M0 0 h24 v24 H0 z";
				case IconKind.Radioactive:
					return "M10.5 14.6 l-3 5.19 a9 9 0 0 1 -4.5 -7.79 h6 a3 3 0 0 0 1.5 2.6 M13.5 9.4 l3 -5.19 a9 9 0 0 0 -9 0 l3 5.19 a3 3 0 0 1 3 0 M13.5 14.6 l3 5.19 a9 9 0 0 0 4.5 -7.79 h-6 a3 3 0 0 1 -1.5 2.6 M0 0 h24 v24 H0 z";
				case IconKind.RadiusBottomLeft:
					return "M19 19 h-6 a8 8 0 0 1 -8 -8 v-6 M0 0 h24 v24 H0 z";
				case IconKind.RadiusBottomRight:
					return "M19 5 v6 a8 8 0 0 1 -8 8 h-6 M0 0 h24 v24 H0 z";
				case IconKind.RadiusTopLeft:
					return "M5 19 v-6 a8 8 0 0 1 8 -8 h6 M0 0 h24 v24 H0 z";
				case IconKind.RadiusTopRight:
					return "M5 5 h6 a8 8 0 0 1 8 8 v6 M0 0 h24 v24 H0 z";
				case IconKind.RainbowOff:
					return "M3 3 l18 18 M14 17 a2 2 0 1 0 -4 0 M11.088 11.069 a6 6 0 0 0 -5.088 5.931 M22 17 c0 -5.523 -4.477 -10 -10 -10 c-0.308 0 -0.613 0.014 -0.914 0.041 m-3.208 0.845 a10 10 0 0 0 -5.878 9.114 M0 0 h24 v24 H0 z";
				case IconKind.Rainbow:
					return "M14 17 a2 2 0 1 0 -4 0 M18 17 a6 6 0 1 0 -12 0 M22 17 c0 -5.523 -4.477 -10 -10 -10 s-10 4.477 -10 10 M0 0 h24 v24 H0 z";
				case IconKind.Rating12Plus:
					return "M10 10.5 a1.5 1.5 0 0 1 3 0 c0 0.443 -0.313 0.989 -0.612 1.393 l-2.388 3.107 h3 M17 10.5 v3 M15.5 12 h3 M7 15 v-6 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.Rating14Plus:
					return "M12.5 15 v-6 m-2.5 0 v4 h3 M17 10.5 v3 M15.5 12 h3 M7 15 v-6 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.Rating16Plus:
					return "M10 13.5 v-3 a1.5 1.5 0 0 1 1.5 -1.5 h1 M17 10.5 v3 M15.5 12 h3 M7 15 v-6 M11.5 13.5 m-1.5 0 a1.5 1.5 0 1 0 3 0 a1.5 1.5 0 1 0 -3 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.Rating18Plus:
					return "M17 10.5 v3 M15.5 12 h3 M7 15 v-6 M11.5 13.5 m-1.5 0 a1.5 1.5 0 1 0 3 0 a1.5 1.5 0 1 0 -3 0 M11.5 10.5 m-1.5 0 a1.5 1.5 0 1 0 3 0 a1.5 1.5 0 1 0 -3 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.Rating21Plus:
					return "M7 10.5 a1.5 1.5 0 0 1 3 0 c0 0.443 -0.313 0.989 -0.612 1.393 l-2.388 3.107 h3 M17 10.5 v3 M15.5 12 h3 M13 15 v-6 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.RazorElectric:
					return "M12 17 v1 M8 5 h8 l-1 4 h-6 z M9 12 v6 a3 3 0 0 0 6 0 v-6 h-6 z M16 3 v2 M12 3 v2 M8 3 v2 M0 0 h24 v24 H0 z";
				case IconKind.Razor:
					return "M12 11 a2 2 0 0 1 2 2 v6 a2 2 0 1 1 -4 0 v-6 a2 2 0 0 1 2 -2 z M12 7 v4 M7 3 h10 v4 h-10 z M0 0 h24 v24 H0 z";
				case IconKind.Receipt2:
					return "M14 8 h-2.5 a1.5 1.5 0 0 0 0 3 h1 a1.5 1.5 0 0 1 0 3 h-2.5 m2 0 v1.5 m0 -9 v1.5 M5 21 v-16 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v16 l-3 -2 l-2 2 l-2 -2 l-2 2 l-2 -2 l-3 2 M0 0 h24 v24 H0 z";
				case IconKind.ReceiptOff:
					return "M3 3 l18 18 M15 11 l0 0.01 M13 15 l2 0 M9 11 l2 0 M11 7 l4 0 M5 21 v-16 m2 -2 h10 a2 2 0 0 1 2 2 v10 m0 4.01 v1.99 l-3 -2 l-2 2 l-2 -2 l-2 2 l-2 -2 l-3 2 M0 0 h24 v24 H0 z";
				case IconKind.ReceiptRefund:
					return "M15 14 v-2 a2 2 0 0 0 -2 -2 h-4 l2 -2 m0 4 l-2 -2 M5 21 v-16 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v16 l-3 -2 l-2 2 l-2 -2 l-2 2 l-2 -2 l-3 2 M0 0 h24 v24 H0 z";
				case IconKind.ReceiptTax:
					return "M5 21 v-16 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v16 l-3 -2 l-2 2 l-2 -2 l-2 2 l-2 -2 l-3 2 M14,13.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M9,8.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M9 14 l6 -6 M0 0 h24 v24 H0 z";
				case IconKind.Receipt:
					return "M5 21 v-16 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v16 l-3 -2 l-2 2 l-2 -2 l-2 2 l-2 -2 l-3 2 m4 -14 h6 m-6 4 h6 m-2 4 h2 M0 0 h24 v24 H0 z";
				case IconKind.Recharging:
					return "M12 21 a9 9 0 0 0 0 -18 M12 8 l-2 4 h4 l-2 4 M13.791 3.186 a9 9 0 0 0 -3.508 -0.02 M19.5 7.038 a9 9 0 0 0 -2.47 -2.495 M20.814 13.791 a9 9 0 0 0 0 -3.508 M16.962 19.5 a9 9 0 0 0 2.495 -2.47 M10.209 20.814 a9 9 0 0 0 3.5 0 M4.5 16.962 a9 9 0 0 0 2.47 2.495 M3.186 10.209 a9 9 0 0 0 0 3.508 M7.038 4.5 a9 9 0 0 0 -2.495 2.47 M0 0 h24 v24 H0 z";
				case IconKind.RecordMailOff:
					return "M3 3 l18 18 M7 15 h8 M18.569 14.557 a3 3 0 1 0 -4.113 -4.149 M7 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.RecordMail:
					return "M7 15 l10 0 M17 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M7 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.RectangleFilled:
					return "M3 5 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.RectangleVerticalFilled:
					return "M5 3 m0 2 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v14 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.RectangleVertical:
					return "M5 3 m0 2 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v14 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Rectangle:
					return "M3 5 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.RecycleOff:
					return "M3 3 l18 18 M15.464 11 l2.732 0.732 l0.732 -2.732 m-0.732 2.732 l-4.5 -7.794 a2 2 0 0 0 -3.256 -0.14 l-0.591 0.976 M8.536 11 l-0.732 -2.732 l-2.732 0.732 m2.732 -0.732 l-4.5 7.794 a2 2 0 0 0 1.506 2.89 l1.141 0.024 M12 17 l-2 2 l2 2 m-2 -2 h9 m1.896 -2.071 a2 2 0 0 0 -0.146 -0.679 l-0.55 -1 M0 0 h24 v24 H0 z";
				case IconKind.Recycle:
					return "M18.196 11.732 l-4.5 -7.794 a2 2 0 0 0 -3.256 -0.14 l-0.591 0.976 M15.464 11 l2.732 0.732 l0.732 -2.732 M7.804 8.268 l-4.5 7.794 a2 2 0 0 0 1.506 2.89 l1.141 0.024 M8.536 11 l-0.732 -2.732 l-2.732 0.732 M10 19 h9 a2 2 0 0 0 1.75 -2.75 l-0.55 -1 M12 17 l-2 2 l2 2 M0 0 h24 v24 H0 z";
				case IconKind.RefreshAlert:
					return "M12 15 l0.01 0 M12 9 l0 3 M4 13 a8.1 8.1 0 0 0 15.5 2 m0.5 4 v-4 h-4 M20 11 a8.1 8.1 0 0 0 -15.5 -2 m-0.5 -4 v4 h4 M0 0 h24 v24 H0 z";
				case IconKind.RefreshDot:
					return "M12 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M4 13 a8.1 8.1 0 0 0 15.5 2 m0.5 4 v-4 h-4 M20 11 a8.1 8.1 0 0 0 -15.5 -2 m-0.5 -4 v4 h4 M0 0 h24 v24 H0 z";
				case IconKind.RefreshOff:
					return "M3 3 l18 18 M4 13 a8.1 8.1 0 0 0 13.671 4.691 m2.329 -1.691 v-1 h-1 M20 11 a8.1 8.1 0 0 0 -11.271 -6.305 m-2.41 1.624 a8.083 8.083 0 0 0 -1.819 2.681 m-0.5 -4 v4 h4 M0 0 h24 v24 H0 z";
				case IconKind.Refresh:
					return "M4 13 a8.1 8.1 0 0 0 15.5 2 m0.5 4 v-4 h-4 M20 11 a8.1 8.1 0 0 0 -15.5 -2 m-0.5 -4 v4 h4 M0 0 h24 v24 H0 z";
				case IconKind.RegexOff:
					return "M3 3 l18 18 M17 7.875 l-3 1.688 M17 4.5 v3.375 M17 7.875 l3 1.688 M17 7.875 l-3 -1.687 M17 7.875 v3.375 M17 7.875 l3 -1.687 M6.5 15 a2.5 2.5 0 1 1 0 5 a2.5 2.5 0 0 1 0 -5 z M0 0 h24 v24 H0 z";
				case IconKind.Regex:
					return "M17 7.875 l-3 1.688 M17 4.5 v3.375 M17 7.875 l3 1.688 M17 7.875 l-3 -1.687 M17 7.875 v3.375 M17 7.875 l3 -1.687 M6.5 15 a2.5 2.5 0 1 1 0 5 a2.5 2.5 0 0 1 0 -5 z M0 0 h24 v24 H0 z";
				case IconKind.Registered:
					return "M14 15 l-2 -2 M10 15 v-6 h2 a2 2 0 1 1 0 4 h-2 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.RelationManyToMany:
					return "M12 13.5 l0 0.01 M12 10.5 l0 0.01 M6 14 v-4 l3 4 v-4 M15 14 v-4 l3 4 v-4 M3 5 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.RelationOneToMany:
					return "M11 13.5 l0 0.01 M11 10.5 l0 0.01 M14 14 v-4 l3 4 v-4 M7 10 h1 v4 M3 5 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.RelationOneToOne:
					return "M12 13.5 l0 0.01 M12 10.5 l0 0.01 M15 10 h1 v4 M8 10 h1 v4 M3 5 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Reload:
					return "M20 4 v5 h-5 M19.933 13.041 a8 8 0 1 1 -9.925 -8.788 c3.899 -1 7.935 1.007 9.425 4.747 M0 0 h24 v24 H0 z";
				case IconKind.RepeatOff:
					return "M3 3 l18 18 M20 12 v3 a3 3 0 0 1 -0.133 0.886 m-1.99 1.984 a3 3 0 0 1 -0.877 0.13 h-13 m3 3 l-3 -3 l3 -3 M4 12 v-3 c0 -1.336 0.873 -2.468 2.08 -2.856 m3.92 -0.144 h10 m-3 -3 l3 3 l-3 3 M0 0 h24 v24 H0 z";
				case IconKind.RepeatOnce:
					return "M11 11 l1 -1 v4 M20 12 v3 a3 3 0 0 1 -3 3 h-13 m3 3 l-3 -3 l3 -3 M4 12 v-3 a3 3 0 0 1 3 -3 h13 m-3 -3 l3 3 l-3 3 M0 0 h24 v24 H0 z";
				case IconKind.Repeat:
					return "M20 12 v3 a3 3 0 0 1 -3 3 h-13 m3 3 l-3 -3 l3 -3 M4 12 v-3 a3 3 0 0 1 3 -3 h13 m-3 -3 l3 3 l-3 3 M0 0 h24 v24 H0 z";
				case IconKind.ReplaceFilled:
					return "M3 13 v3 a2 2 0 0 0 2 2 h6 l-3 -3 m0 6 l3 -3 M21 11 v-3 a2 2 0 0 0 -2 -2 h-6 l3 3 m0 -6 l-3 3 M15 15 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M3 3 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.ReplaceOff:
					return "M3 3 l18 18 M3 13 v3 a2 2 0 0 0 2 2 h6 l-3 -3 m0 6 l3 -3 M21 11 v-3 a2 2 0 0 0 -2 -2 h-6 l3 3 m0 -6 l-3 3 M19 15 h1 a1 1 0 0 1 1 1 v1 m-0.303 3.717 a1 1 0 0 1 -0.697 0.283 h-4 a1 1 0 0 1 -1 -1 v-4 c0 -0.28 0.115 -0.532 0.3 -0.714 M7 3 h1 a1 1 0 0 1 1 1 v1 m-0.303 3.717 a1 1 0 0 1 -0.697 0.283 h-4 a1 1 0 0 1 -1 -1 v-4 c0 -0.28 0.115 -0.532 0.3 -0.714 M0 0 h24 v24 H0 z";
				case IconKind.Replace:
					return "M3 13 v3 a2 2 0 0 0 2 2 h6 l-3 -3 m0 6 l3 -3 M21 11 v-3 a2 2 0 0 0 -2 -2 h-6 l3 3 m0 -6 l-3 3 M15 15 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M3 3 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.ReportAnalytics:
					return "M15 17 v-3 M12 17 v-1 M9 17 v-5 M9 3 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v0 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M9 5 h-2 a2 2 0 0 0 -2 2 v12 a2 2 0 0 0 2 2 h10 a2 2 0 0 0 2 -2 v-12 a2 2 0 0 0 -2 -2 h-2 M0 0 h24 v24 H0 z";
				case IconKind.ReportMedical:
					return "M12 12 l0 4 M10 14 l4 0 M9 3 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v0 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M9 5 h-2 a2 2 0 0 0 -2 2 v12 a2 2 0 0 0 2 2 h10 a2 2 0 0 0 2 -2 v-12 a2 2 0 0 0 -2 -2 h-2 M0 0 h24 v24 H0 z";
				case IconKind.ReportMoney:
					return "M12 17 v1 m0 -8 v1 M14 11 h-2.5 a1.5 1.5 0 0 0 0 3 h1 a1.5 1.5 0 0 1 0 3 h-2.5 M9 3 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v0 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M9 5 h-2 a2 2 0 0 0 -2 2 v12 a2 2 0 0 0 2 2 h10 a2 2 0 0 0 2 -2 v-12 a2 2 0 0 0 -2 -2 h-2 M0 0 h24 v24 H0 z";
				case IconKind.ReportOff:
					return "M3 3 l18 18 M9 5 a2 2 0 0 1 2 -2 h2 a2 2 0 1 1 0 4 h-2 M5.576 5.595 a2 2 0 0 0 -0.576 1.405 v12 a2 2 0 0 0 2 2 h10 a2 2 0 0 0 2 -2 m0 -4 v-8 a2 2 0 0 0 -2 -2 h-2 M0 0 h24 v24 H0 z";
				case IconKind.ReportSearch:
					return "M18.5 19.5 l2.5 2.5 M16.5 17.5 m-2.5 0 a2.5 2.5 0 1 0 5 0 a2.5 2.5 0 1 0 -5 0 M8 15 h3 M8 11 h4 M8 3 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v0 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M18 12 v-5 a2 2 0 0 0 -2 -2 h-2 M8 5 h-2 a2 2 0 0 0 -2 2 v12 a2 2 0 0 0 2 2 h5.697 M0 0 h24 v24 H0 z";
				case IconKind.Report:
					return "M8 15 h3 M8 11 h4 M18 18 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M8 3 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v0 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M18 11 v-4 a2 2 0 0 0 -2 -2 h-2 M18 14 v4 h4 M8 5 h-2 a2 2 0 0 0 -2 2 v12 a2 2 0 0 0 2 2 h5.697 M0 0 h24 v24 H0 z";
				case IconKind.Resize:
					return "M4 12 h7 a1 1 0 0 1 1 1 v7 M4 11 v8 a1 1 0 0 0 1 1 h8 m-9 -14 v-1 a1 1 0 0 1 1 -1 h1 m5 0 h2 m5 0 h1 a1 1 0 0 1 1 1 v1 m0 5 v2 m0 5 v1 a1 1 0 0 1 -1 1 h-1 M0 0 h24 v24 H0 z";
				case IconKind.RibbonHealth:
					return "M7 21 s9.286 -9.841 9.286 -13.841 a3.864 3.864 0 0 0 -1.182 -3.008 a4.13 4.13 0 0 0 -3.104 -1.144 a4.13 4.13 0 0 0 -3.104 1.143 a3.864 3.864 0 0 0 -1.182 3.01 c0 4 9.286 13.84 9.286 13.84 M0 0 h24 v24 H0 z";
				case IconKind.RippleOff:
					return "M3 3 l18 18 M3 12 c3 -2 6 -2 9 0 m5.482 1.429 c1.173 -0.171 2.345 -0.647 3.518 -1.429 M3 17 c3 -2 6 -2 9 0 c2.092 1.395 4.184 1.817 6.276 1.266 M3 7 c0.915 -0.61 1.83 -1.034 2.746 -1.272 m4.212 0.22 c0.68 0.247 1.361 0.598 2.042 1.052 c3 2 6 2 9 0 M0 0 h24 v24 H0 z";
				case IconKind.Ripple:
					return "M3 12 c3 -2 6 -2 9 0 s6 2 9 0 M3 17 c3 -2 6 -2 9 0 s6 2 9 0 M3 7 c3 -2 6 -2 9 0 s6 2 9 0 M0 0 h24 v24 H0 z";
				case IconKind.RoadOff:
					return "M3 3 l18 18 M12 18 v-2 M12 13 v-1 M12 8 v-2 M16 5 l2.806 9.823 M4 19 l3.332 -11.661 M0 0 h24 v24 H0 z";
				case IconKind.RoadSign:
					return "M13 9 l2 2 l-2 2 M9 14 v-2 c0 -0.59 0.414 -1 1 -1 h5 M10.5 20.4 l-6.9 -6.9 c-0.781 -0.781 -0.781 -2.219 0 -3 l6.9 -6.9 c0.781 -0.781 2.219 -0.781 3 0 l6.9 6.9 c0.781 0.781 0.781 2.219 0 3 l-6.9 6.9 c-0.781 0.781 -2.219 0.781 -3 0 z M0 0 h24 v24 H0 z";
				case IconKind.Road:
					return "M12 18 v-2 M12 13 v-2 M12 8 v-2 M16 5 l4 14 M4 19 l4 -14 M0 0 h24 v24 H0 z";
				case IconKind.RobotOff:
					return "M3 3 l18 18 M15 7 l1 -4 M8.336 4.343 l-0.336 -1.343 M15.854 11.853 a0.498 0.498 0 0 0 -0.354 -0.853 a0.498 0.498 0 0 0 -0.356 0.149 M8.5 11.5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M10 16 h4 M11 7 h6 a2 2 0 0 1 2 2 v1 l1 1 v3 l-1 1 m-0.171 3.811 a2 2 0 0 1 -1.829 1.189 h-10 a2 2 0 0 1 -2 -2 v-3 l-1 -1 v-3 l1 -1 v-1 a2 2 0 0 1 2 -2 M0 0 h24 v24 H0 z";
				case IconKind.Robot:
					return "M15 7 l1 -4 M9 7 l-1 -4 M15,11.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M8,11.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M10 16 h4 M7 7 h10 a2 2 0 0 1 2 2 v1 l1 1 v3 l-1 1 v3 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 v-3 l-1 -1 v-3 l1 -1 v-1 a2 2 0 0 1 2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.RocketOff:
					return "M3 3 l18 18 M15 9 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M7 14 a6 6 0 0 0 -3 6 a6 6 0 0 0 6 -3 M9.29 9.275 a9.03 9.03 0 0 0 -0.29 0.725 a6 6 0 0 0 -5 3 a8 8 0 0 1 7 7 a6 6 0 0 0 3 -5 c0.241 -0.085 0.478 -0.18 0.708 -0.283 m2.428 -1.61 a9 9 0 0 0 2.864 -6.107 a3 3 0 0 0 -3 -3 a9 9 0 0 0 -6.107 2.864 M0 0 h24 v24 H0 z";
				case IconKind.Rocket:
					return "M15 9 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M7 14 a6 6 0 0 0 -3 6 a6 6 0 0 0 6 -3 M4 13 a8 8 0 0 1 7 7 a6 6 0 0 0 3 -5 a9 9 0 0 0 6 -8 a3 3 0 0 0 -3 -3 a9 9 0 0 0 -8 6 a6 6 0 0 0 -5 3 M0 0 h24 v24 H0 z";
				case IconKind.RollerSkating:
					return "M16 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M8 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5.905 5 h3.418 a1 1 0 0 1 0.928 0.629 l1.143 2.856 a3 3 0 0 0 2.207 1.83 l4.717 0.926 a2.084 2.084 0 0 1 1.682 2.045 v0.714 a1 1 0 0 1 -1 1 h-13.895 a1 1 0 0 1 -1 -1.1 l0.8 -8 a1 1 0 0 1 1 -0.9 z M0 0 h24 v24 H0 z";
				case IconKind.RollercoasterOff:
					return "M3 3 l18 18 M9.446 5.415 l0.554 -0.415 l2 2.5 l-0.285 0.213 m-2.268 1.702 l-1.447 1.085 l-1.8 -0.5 l-0.2 -2 l1.139 -0.854 M15 3 h5 v3 h-5 z M16 9.5 v2.5 m0 4 v5 M12 21 v-9 M8 21 v-3 M20 9 v7 m0 4 v1 M3 21 a5.55 5.55 0 0 0 5.265 -3.795 l0.735 -2.205 a8.759 8.759 0 0 1 2.35 -3.652 m2.403 -1.589 a8.76 8.76 0 0 1 3.572 -0.759 h3.675 M0 0 h24 v24 H0 z";
				case IconKind.Rollercoaster:
					return "M6 8 l4 -3 l2 2.5 l-4 3 l-1.8 -0.5 z M15 3 h5 v3 h-5 z M16 9.5 v11.5 M12 21 v-10 M8 21 v-3 M20 9 v12 M3 21 a5.55 5.55 0 0 0 5.265 -3.795 l0.735 -2.205 a8.775 8.775 0 0 1 8.325 -6 h3.675 M0 0 h24 v24 H0 z";
				case IconKind.RosetteFilled:
					return "M5 7.2 a2.2 2.2 0 0 1 2.2 -2.2 h1 a2.2 2.2 0 0 0 1.55 -0.64 l0.7 -0.7 a2.2 2.2 0 0 1 3.12 0 l0.7 0.7 c0.412 0.41 0.97 0.64 1.55 0.64 h1 a2.2 2.2 0 0 1 2.2 2.2 v1 c0 0.58 0.23 1.138 0.64 1.55 l0.7 0.7 a2.2 2.2 0 0 1 0 3.12 l-0.7 0.7 a2.2 2.2 0 0 0 -0.64 1.55 v1 a2.2 2.2 0 0 1 -2.2 2.2 h-1 a2.2 2.2 0 0 0 -1.55 0.64 l-0.7 0.7 a2.2 2.2 0 0 1 -3.12 0 l-0.7 -0.7 a2.2 2.2 0 0 0 -1.55 -0.64 h-1 a2.2 2.2 0 0 1 -2.2 -2.2 v-1 a2.2 2.2 0 0 0 -0.64 -1.55 l-0.7 -0.7 a2.2 2.2 0 0 1 0 -3.12 l0.7 -0.7 a2.2 2.2 0 0 0 0.64 -1.55 v-1 M0 0 h24 v24 H0 z";
				case IconKind.RosetteNumber0:
					return "M5 7.2 a2.2 2.2 0 0 1 2.2 -2.2 h1 a2.2 2.2 0 0 0 1.55 -0.64 l0.7 -0.7 a2.2 2.2 0 0 1 3.12 0 l0.7 0.7 c0.412 0.41 0.97 0.64 1.55 0.64 h1 a2.2 2.2 0 0 1 2.2 2.2 v1 c0 0.58 0.23 1.138 0.64 1.55 l0.7 0.7 a2.2 2.2 0 0 1 0 3.12 l-0.7 0.7 a2.2 2.2 0 0 0 -0.64 1.55 v1 a2.2 2.2 0 0 1 -2.2 2.2 h-1 a2.2 2.2 0 0 0 -1.55 0.64 l-0.7 0.7 a2.2 2.2 0 0 1 -3.12 0 l-0.7 -0.7 a2.2 2.2 0 0 0 -1.55 -0.64 h-1 a2.2 2.2 0 0 1 -2.2 -2.2 v-1 a2.2 2.2 0 0 0 -0.64 -1.55 l-0.7 -0.7 a2.2 2.2 0 0 1 0 -3.12 l0.7 -0.7 a2.2 2.2 0 0 0 0.64 -1.55 v-1 M10 10 v4 a2 2 0 1 0 4 0 v-4 a2 2 0 1 0 -4 0 z M0 0 h24 v24 H0 z";
				case IconKind.RosetteNumber1:
					return "M5 7.2 a2.2 2.2 0 0 1 2.2 -2.2 h1 a2.2 2.2 0 0 0 1.55 -0.64 l0.7 -0.7 a2.2 2.2 0 0 1 3.12 0 l0.7 0.7 c0.412 0.41 0.97 0.64 1.55 0.64 h1 a2.2 2.2 0 0 1 2.2 2.2 v1 c0 0.58 0.23 1.138 0.64 1.55 l0.7 0.7 a2.2 2.2 0 0 1 0 3.12 l-0.7 0.7 a2.2 2.2 0 0 0 -0.64 1.55 v1 a2.2 2.2 0 0 1 -2.2 2.2 h-1 a2.2 2.2 0 0 0 -1.55 0.64 l-0.7 0.7 a2.2 2.2 0 0 1 -3.12 0 l-0.7 -0.7 a2.2 2.2 0 0 0 -1.55 -0.64 h-1 a2.2 2.2 0 0 1 -2.2 -2.2 v-1 a2.2 2.2 0 0 0 -0.64 -1.55 l-0.7 -0.7 a2.2 2.2 0 0 1 0 -3.12 l0.7 -0.7 a2.2 2.2 0 0 0 0.64 -1.55 v-1 M10 10 l2 -2 v8 M0 0 h24 v24 H0 z";
				case IconKind.RosetteNumber2:
					return "M5 7.2 a2.2 2.2 0 0 1 2.2 -2.2 h1 a2.2 2.2 0 0 0 1.55 -0.64 l0.7 -0.7 a2.2 2.2 0 0 1 3.12 0 l0.7 0.7 c0.412 0.41 0.97 0.64 1.55 0.64 h1 a2.2 2.2 0 0 1 2.2 2.2 v1 c0 0.58 0.23 1.138 0.64 1.55 l0.7 0.7 a2.2 2.2 0 0 1 0 3.12 l-0.7 0.7 a2.2 2.2 0 0 0 -0.64 1.55 v1 a2.2 2.2 0 0 1 -2.2 2.2 h-1 a2.2 2.2 0 0 0 -1.55 0.64 l-0.7 0.7 a2.2 2.2 0 0 1 -3.12 0 l-0.7 -0.7 a2.2 2.2 0 0 0 -1.55 -0.64 h-1 a2.2 2.2 0 0 1 -2.2 -2.2 v-1 a2.2 2.2 0 0 0 -0.64 -1.55 l-0.7 -0.7 a2.2 2.2 0 0 1 0 -3.12 l0.7 -0.7 a2.2 2.2 0 0 0 0.64 -1.55 v-1 M10 8 h3 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 0 -1 1 v2 a1 1 0 0 0 1 1 h3 M0 0 h24 v24 H0 z";
				case IconKind.RosetteNumber3:
					return "M5 7.2 a2.2 2.2 0 0 1 2.2 -2.2 h1 a2.2 2.2 0 0 0 1.55 -0.64 l0.7 -0.7 a2.2 2.2 0 0 1 3.12 0 l0.7 0.7 c0.412 0.41 0.97 0.64 1.55 0.64 h1 a2.2 2.2 0 0 1 2.2 2.2 v1 c0 0.58 0.23 1.138 0.64 1.55 l0.7 0.7 a2.2 2.2 0 0 1 0 3.12 l-0.7 0.7 a2.2 2.2 0 0 0 -0.64 1.55 v1 a2.2 2.2 0 0 1 -2.2 2.2 h-1 a2.2 2.2 0 0 0 -1.55 0.64 l-0.7 0.7 a2.2 2.2 0 0 1 -3.12 0 l-0.7 -0.7 a2.2 2.2 0 0 0 -1.55 -0.64 h-1 a2.2 2.2 0 0 1 -2.2 -2.2 v-1 a2.2 2.2 0 0 0 -0.64 -1.55 l-0.7 -0.7 a2.2 2.2 0 0 1 0 -3.12 l0.7 -0.7 a2.2 2.2 0 0 0 0.64 -1.55 v-1 M10 9 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 M0 0 h24 v24 H0 z";
				case IconKind.RosetteNumber4:
					return "M5 7.2 a2.2 2.2 0 0 1 2.2 -2.2 h1 a2.2 2.2 0 0 0 1.55 -0.64 l0.7 -0.7 a2.2 2.2 0 0 1 3.12 0 l0.7 0.7 c0.412 0.41 0.97 0.64 1.55 0.64 h1 a2.2 2.2 0 0 1 2.2 2.2 v1 c0 0.58 0.23 1.138 0.64 1.55 l0.7 0.7 a2.2 2.2 0 0 1 0 3.12 l-0.7 0.7 a2.2 2.2 0 0 0 -0.64 1.55 v1 a2.2 2.2 0 0 1 -2.2 2.2 h-1 a2.2 2.2 0 0 0 -1.55 0.64 l-0.7 0.7 a2.2 2.2 0 0 1 -3.12 0 l-0.7 -0.7 a2.2 2.2 0 0 0 -1.55 -0.64 h-1 a2.2 2.2 0 0 1 -2.2 -2.2 v-1 a2.2 2.2 0 0 0 -0.64 -1.55 l-0.7 -0.7 a2.2 2.2 0 0 1 0 -3.12 l0.7 -0.7 a2.2 2.2 0 0 0 0.64 -1.55 v-1 M14 8 v8 M10 8 v3 a1 1 0 0 0 1 1 h3 M0 0 h24 v24 H0 z";
				case IconKind.RosetteNumber5:
					return "M5 7.2 a2.2 2.2 0 0 1 2.2 -2.2 h1 a2.2 2.2 0 0 0 1.55 -0.64 l0.7 -0.7 a2.2 2.2 0 0 1 3.12 0 l0.7 0.7 c0.412 0.41 0.97 0.64 1.55 0.64 h1 a2.2 2.2 0 0 1 2.2 2.2 v1 c0 0.58 0.23 1.138 0.64 1.55 l0.7 0.7 a2.2 2.2 0 0 1 0 3.12 l-0.7 0.7 a2.2 2.2 0 0 0 -0.64 1.55 v1 a2.2 2.2 0 0 1 -2.2 2.2 h-1 a2.2 2.2 0 0 0 -1.55 0.64 l-0.7 0.7 a2.2 2.2 0 0 1 -3.12 0 l-0.7 -0.7 a2.2 2.2 0 0 0 -1.55 -0.64 h-1 a2.2 2.2 0 0 1 -2.2 -2.2 v-1 a2.2 2.2 0 0 0 -0.64 -1.55 l-0.7 -0.7 a2.2 2.2 0 0 1 0 -3.12 l0.7 -0.7 a2.2 2.2 0 0 0 0.64 -1.55 v-1 M10 15 a1 1 0 0 0 1 1 h2 a1 1 0 0 0 1 -1 v-2 a1 1 0 0 0 -1 -1 h-3 v-4 h4 M0 0 h24 v24 H0 z";
				case IconKind.RosetteNumber6:
					return "M5 7.2 a2.2 2.2 0 0 1 2.2 -2.2 h1 a2.2 2.2 0 0 0 1.55 -0.64 l0.7 -0.7 a2.2 2.2 0 0 1 3.12 0 l0.7 0.7 c0.412 0.41 0.97 0.64 1.55 0.64 h1 a2.2 2.2 0 0 1 2.2 2.2 v1 c0 0.58 0.23 1.138 0.64 1.55 l0.7 0.7 a2.2 2.2 0 0 1 0 3.12 l-0.7 0.7 a2.2 2.2 0 0 0 -0.64 1.55 v1 a2.2 2.2 0 0 1 -2.2 2.2 h-1 a2.2 2.2 0 0 0 -1.55 0.64 l-0.7 0.7 a2.2 2.2 0 0 1 -3.12 0 l-0.7 -0.7 a2.2 2.2 0 0 0 -1.55 -0.64 h-1 a2.2 2.2 0 0 1 -2.2 -2.2 v-1 a2.2 2.2 0 0 0 -0.64 -1.55 l-0.7 -0.7 a2.2 2.2 0 0 1 0 -3.12 l0.7 -0.7 a2.2 2.2 0 0 0 0.64 -1.55 v-1 M14 9 a1 1 0 0 0 -1 -1 h-2 a1 1 0 0 0 -1 1 v6 a1 1 0 0 0 1 1 h2 a1 1 0 0 0 1 -1 v-2 a1 1 0 0 0 -1 -1 h-3 M0 0 h24 v24 H0 z";
				case IconKind.RosetteNumber7:
					return "M5 7.2 a2.2 2.2 0 0 1 2.2 -2.2 h1 a2.2 2.2 0 0 0 1.55 -0.64 l0.7 -0.7 a2.2 2.2 0 0 1 3.12 0 l0.7 0.7 c0.412 0.41 0.97 0.64 1.55 0.64 h1 a2.2 2.2 0 0 1 2.2 2.2 v1 c0 0.58 0.23 1.138 0.64 1.55 l0.7 0.7 a2.2 2.2 0 0 1 0 3.12 l-0.7 0.7 a2.2 2.2 0 0 0 -0.64 1.55 v1 a2.2 2.2 0 0 1 -2.2 2.2 h-1 a2.2 2.2 0 0 0 -1.55 0.64 l-0.7 0.7 a2.2 2.2 0 0 1 -3.12 0 l-0.7 -0.7 a2.2 2.2 0 0 0 -1.55 -0.64 h-1 a2.2 2.2 0 0 1 -2.2 -2.2 v-1 a2.2 2.2 0 0 0 -0.64 -1.55 l-0.7 -0.7 a2.2 2.2 0 0 1 0 -3.12 l0.7 -0.7 a2.2 2.2 0 0 0 0.64 -1.55 v-1 M10 8 h4 l-2 8 M0 0 h24 v24 H0 z";
				case IconKind.RosetteNumber8:
					return "M5 7.2 a2.2 2.2 0 0 1 2.2 -2.2 h1 a2.2 2.2 0 0 0 1.55 -0.64 l0.7 -0.7 a2.2 2.2 0 0 1 3.12 0 l0.7 0.7 c0.412 0.41 0.97 0.64 1.55 0.64 h1 a2.2 2.2 0 0 1 2.2 2.2 v1 c0 0.58 0.23 1.138 0.64 1.55 l0.7 0.7 a2.2 2.2 0 0 1 0 3.12 l-0.7 0.7 a2.2 2.2 0 0 0 -0.64 1.55 v1 a2.2 2.2 0 0 1 -2.2 2.2 h-1 a2.2 2.2 0 0 0 -1.55 0.64 l-0.7 0.7 a2.2 2.2 0 0 1 -3.12 0 l-0.7 -0.7 a2.2 2.2 0 0 0 -1.55 -0.64 h-1 a2.2 2.2 0 0 1 -2.2 -2.2 v-1 a2.2 2.2 0 0 0 -0.64 -1.55 l-0.7 -0.7 a2.2 2.2 0 0 1 0 -3.12 l0.7 -0.7 a2.2 2.2 0 0 0 0.64 -1.55 v-1 M12 12 h-1 a1 1 0 0 1 -1 -1 v-2 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 0 -1 1 v2 a1 1 0 0 0 1 1 h2 a1 1 0 0 0 1 -1 v-2 a1 1 0 0 0 -1 -1 M0 0 h24 v24 H0 z";
				case IconKind.RosetteNumber9:
					return "M5 7.2 a2.2 2.2 0 0 1 2.2 -2.2 h1 a2.2 2.2 0 0 0 1.55 -0.64 l0.7 -0.7 a2.2 2.2 0 0 1 3.12 0 l0.7 0.7 c0.412 0.41 0.97 0.64 1.55 0.64 h1 a2.2 2.2 0 0 1 2.2 2.2 v1 c0 0.58 0.23 1.138 0.64 1.55 l0.7 0.7 a2.2 2.2 0 0 1 0 3.12 l-0.7 0.7 a2.2 2.2 0 0 0 -0.64 1.55 v1 a2.2 2.2 0 0 1 -2.2 2.2 h-1 a2.2 2.2 0 0 0 -1.55 0.64 l-0.7 0.7 a2.2 2.2 0 0 1 -3.12 0 l-0.7 -0.7 a2.2 2.2 0 0 0 -1.55 -0.64 h-1 a2.2 2.2 0 0 1 -2.2 -2.2 v-1 a2.2 2.2 0 0 0 -0.64 -1.55 l-0.7 -0.7 a2.2 2.2 0 0 1 0 -3.12 l0.7 -0.7 a2.2 2.2 0 0 0 0.64 -1.55 v-1 M10 15 a1 1 0 0 0 1 1 h2 a1 1 0 0 0 1 -1 v-6 a1 1 0 0 0 -1 -1 h-2 a1 1 0 0 0 -1 1 v2 a1 1 0 0 0 1 1 h3 M0 0 h24 v24 H0 z";
				case IconKind.Rosette:
					return "M5 7.2 a2.2 2.2 0 0 1 2.2 -2.2 h1 a2.2 2.2 0 0 0 1.55 -0.64 l0.7 -0.7 a2.2 2.2 0 0 1 3.12 0 l0.7 0.7 c0.412 0.41 0.97 0.64 1.55 0.64 h1 a2.2 2.2 0 0 1 2.2 2.2 v1 c0 0.58 0.23 1.138 0.64 1.55 l0.7 0.7 a2.2 2.2 0 0 1 0 3.12 l-0.7 0.7 a2.2 2.2 0 0 0 -0.64 1.55 v1 a2.2 2.2 0 0 1 -2.2 2.2 h-1 a2.2 2.2 0 0 0 -1.55 0.64 l-0.7 0.7 a2.2 2.2 0 0 1 -3.12 0 l-0.7 -0.7 a2.2 2.2 0 0 0 -1.55 -0.64 h-1 a2.2 2.2 0 0 1 -2.2 -2.2 v-1 a2.2 2.2 0 0 0 -0.64 -1.55 l-0.7 -0.7 a2.2 2.2 0 0 1 0 -3.12 l0.7 -0.7 a2.2 2.2 0 0 0 0.64 -1.55 v-1 M0 0 h24 v24 H0 z";
				case IconKind.Rotate2:
					return "M19.94 11 l0 0.01 M19.37 15.1 l0 0.01 M16.84 18.37 l0 0.01 M13 19.94 l0 0.01 M18.37 7.16 l0 0.01 M15 4.55 a8 8 0 0 0 -6 14.9 m0 -4.45 v5 h-5 M0 0 h24 v24 H0 z";
				case IconKind.Rotate360:
					return "M19.458 11.042 c0.86 -2.366 0.722 -4.58 -0.6 -5.9 c-2.272 -2.274 -7.185 -1.045 -10.973 2.743 c-3.788 3.788 -5.017 8.701 -2.744 10.974 c2.227 2.226 6.987 1.093 10.74 -2.515 M12 16 h4 v4 M0 0 h24 v24 H0 z";
				case IconKind.RotateClockwise2:
					return "M11 19.94 l0 0.01 M7.16 18.37 l0 0.01 M4.63 15.1 l0 0.01 M4.06 11 l0 0.01 M5.63 7.16 l0 0.01 M9 4.55 a8 8 0 0 1 6 14.9 m0 -4.45 v5 h5 M0 0 h24 v24 H0 z";
				case IconKind.RotateClockwise:
					return "M4.05 11 a8 8 0 1 1 0.5 4 m-0.5 5 v-5 h5 M0 0 h24 v24 H0 z";
				case IconKind.RotateDot:
					return "M12 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M19.95 11 a8 8 0 1 0 -0.5 4 m0.5 5 v-5 h-5 M0 0 h24 v24 H0 z";
				case IconKind.RotateRectangle:
					return "M7.05 11.038 v-3.988 M10.09 4.01 l0.496 -0.495 a2 2 0 0 1 2.828 0 l7.071 7.07 a2 2 0 0 1 0 2.83 l-7.07 7.07 a2 2 0 0 1 -2.83 0 l-7.07 -7.07 a2 2 0 0 1 0 -2.83 l3.535 -3.535 h-3.988 M0 0 h24 v24 H0 z";
				case IconKind.Rotate:
					return "M19.95 11 a8 8 0 1 0 -0.5 4 m0.5 5 v-5 h-5 M0 0 h24 v24 H0 z";
				case IconKind.Route2:
					return "M14 5 a2 2 0 0 0 -2 2 v10 a2 2 0 0 1 -2 2 M21 3 l-4 4 M17 3 l4 4 M7 17 l-4 4 M3 17 l4 4 M0 0 h24 v24 H0 z";
				case IconKind.RouteOff:
					return "M3 3 l18 18 M12 19 h4.5 c0.71 0 1.372 -0.212 1.924 -0.576 m1.545 -2.459 a3.5 3.5 0 0 0 -3.469 -3.965 h-0.499 m-4 0 h-3.501 a3.5 3.5 0 0 1 -2.477 -5.972 m2.477 -1.028 h3.5 M18 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Route:
					return "M12 19 h4.5 a3.5 3.5 0 0 0 0 -7 h-8 a3.5 3.5 0 0 1 0 -7 h3.5 M18 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.RouterOff:
					return "M3 3 l18 18 M9.445 5.407 a8 8 0 0 1 12.055 1.093 M12.226 8.2 a4 4 0 0 1 6.024 0.55 M13 17 v0.01 M17 17 v0.01 M17 13 h2 a2 2 0 0 1 2 2 v2 m-0.588 3.417 c-0.362 0.36 -0.861 0.583 -1.412 0.583 h-14 a2 2 0 0 1 -2 -2 v-4 a2 2 0 0 1 2 -2 h8 M0 0 h24 v24 H0 z";
				case IconKind.Router:
					return "M8.5 6.5 a8 8 0 0 1 13 0 M11.75 8.75 a4 4 0 0 1 6.5 0 M15 13 l0 -2 M13 17 l0 0.01 M17 17 l0 0.01 M3 13 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v4 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.RowInsertBottom:
					return "M14 17 l-4 0 M12 15 l0 4 M20 6 v4 a1 1 0 0 1 -1 1 h-14 a1 1 0 0 1 -1 -1 v-4 a1 1 0 0 1 1 -1 h14 a1 1 0 0 1 1 1 z M0 0 h24 v24 H0 z";
				case IconKind.RowInsertTop:
					return "M10 7 l4 0 M12 9 v-4 M4 18 v-4 a1 1 0 0 1 1 -1 h14 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-14 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.Rss:
					return "M4 11 a9 9 0 0 1 9 9 M4 4 a16 16 0 0 1 16 16 M5 19 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.RubberStampOff:
					return "M8.712 4.722 a3.99 3.99 0 0 1 3.288 -1.722 a4 4 0 0 1 4 4 c0 0.992 -0.806 2.464 -1.223 3.785 m6.198 6.196 c-0.182 -2.883 -1.332 -3.153 -3.172 -3.178 M3 3 l18 18 M5 21 h14 M8.273 8.273 c0.805 2.341 2.857 5.527 -1.484 5.527 c-2.368 0 -3.789 0 -3.789 4.05 h14.85 M0 0 h24 v24 H0 z";
				case IconKind.RubberStamp:
					return "M5 21 h14 M21 17.85 h-18 c0 -4.05 1.421 -4.05 3.79 -4.05 c5.21 0 1.21 -4.59 1.21 -6.8 a4 4 0 1 1 8 0 c0 2.21 -4 6.8 1.21 6.8 c2.369 0 3.79 0 3.79 4.05 z M0 0 h24 v24 H0 z";
				case IconKind.Ruler2Off:
					return "M3 3 l18 18 M7 16 l-1.5 -1.5 M10 13 l-1.5 -1.5 M16 7 l-1.5 -1.5 M12.03 7.97 l4.97 -4.97 l4 4 l-5 5 m-2 2 l-7 7 l-4 -4 l7 -7 M0 0 h24 v24 H0 z";
				case IconKind.Ruler2:
					return "M7 16 l-1.5 -1.5 M10 13 l-1.5 -1.5 M13 10 l-1.5 -1.5 M16 7 l-1.5 -1.5 M17 3 l4 4 l-14 14 l-4 -4 z M0 0 h24 v24 H0 z";
				case IconKind.Ruler3:
					return "M15 8 v2 M18 8 v3 M12 8 v3 M6 8 v3 M9 8 v2 M19.875 8 c0.621 0 1.125 0.512 1.125 1.143 v5.714 c0 0.631 -0.504 1.143 -1.125 1.143 h-15.875 a1 1 0 0 1 -1 -1 v-5.857 c0 -0.631 0.504 -1.143 1.125 -1.143 h15.75 z M0 0 h24 v24 H0 z";
				case IconKind.RulerMeasure:
					return "M21 3 v4 M3 5 h18 M3 3 v4 M15 12 v2 M18 12 v3 M12 12 v3 M6 12 v3 M9 12 v2 M19.875 12 c0.621 0 1.125 0.512 1.125 1.143 v5.714 c0 0.631 -0.504 1.143 -1.125 1.143 h-15.875 a1 1 0 0 1 -1 -1 v-5.857 c0 -0.631 0.504 -1.143 1.125 -1.143 h15.75 z M0 0 h24 v24 H0 z";
				case IconKind.RulerOff:
					return "M3 3 l18 18 M16 4 v2 M12 4 v3 M4 16 h2 M4 12 h3 M4 8 h2 M8 4 h11 a1 1 0 0 1 1 1 v5 a1 1 0 0 1 -1 1 h-4 m-3.713 0.299 a1 1 0 0 0 -0.287 0.701 v7 a1 1 0 0 1 -1 1 h-5 a1 1 0 0 1 -1 -1 v-14 c0 -0.284 0.118 -0.54 0.308 -0.722 M0 0 h24 v24 H0 z";
				case IconKind.Ruler:
					return "M16 4 l0 2 M12 4 l0 3 M8 4 l0 2 M4 16 l2 0 M4 12 l3 0 M4 8 l2 0 M5 4 h14 a1 1 0 0 1 1 1 v5 a1 1 0 0 1 -1 1 h-7 a1 1 0 0 0 -1 1 v7 a1 1 0 0 1 -1 1 h-5 a1 1 0 0 1 -1 -1 v-14 a1 1 0 0 1 1 -1 M0 0 h24 v24 H0 z";
				case IconKind.Run:
					return "M7 12 l0 -3 l5 -1 l3 3 l3 1 M15 21 l0 -4 l-4 -3 l1 -6 M4 17 l5 1 l0.75 -1.5 M13 4 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.STurnDown:
					return "M16 18 l3 3 l3 -3 M5 7 v9.5 a3.5 3.5 0 0 0 7 0 v-9 a3.5 3.5 0 0 1 7 0 v13.5 M7 5 a2 2 0 1 1 -4 0 a2 2 0 0 1 4 0 z M0 0 h24 v24 H0 z";
				case IconKind.STurnLeft:
					return "M6 16 l-3 3 l3 3 M17 5 h-9.5 a3.5 3.5 0 0 0 0 7 h9 a3.5 3.5 0 0 1 0 7 h-13.5 M19 7 a2 2 0 1 1 0 -4 a2 2 0 0 1 0 4 z M0 0 h24 v24 H0 z";
				case IconKind.STurnRight:
					return "M18 16 l3 3 l-3 3 M7 5 h9.5 a3.5 3.5 0 0 1 0 7 h-9 a3.5 3.5 0 0 0 0 7 h13.5 M5 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.STurnUp:
					return "M16 6 l3 -3 l3 3 M5 17 v-9.5 a3.5 3.5 0 0 1 7 0 v9 a3.5 3.5 0 0 0 7 0 v-13.5 M7 19 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M0 0 h24 v24 H0 z";
				case IconKind.Sailboat2:
					return "M6 3 h12 M7 3 c1.333 2.667 1.333 5.333 0 8 h10 c1.333 -2.667 1.333 -5.333 0 -8 M12 11 v4 M4 18 l-1 -3 h18 l-1 3 M2 20 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 a2.4 2.4 0 0 1 2 -1 a2.4 2.4 0 0 1 2 1 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 a2.4 2.4 0 0 1 2 -1 a2.4 2.4 0 0 1 2 1 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 M0 0 h24 v24 H0 z";
				case IconKind.SailboatOff:
					return "M3 3 l18 18 M7.713 7.718 l-1.713 4.282 M11 11 v1 h1 m4 0 h2 l-7 -9 v4 M4 18 l-1 -3 h12 m4 0 h2 l-0.506 1.517 M2 20 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 a2.4 2.4 0 0 1 2 -1 a2.4 2.4 0 0 1 2 1 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 a2.4 2.4 0 0 1 2 -1 a2.4 2.4 0 0 1 2 1 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 M0 0 h24 v24 H0 z";
				case IconKind.Sailboat:
					return "M8 7 l-2 5 M11 12 h7 l-7 -9 v9 M4 18 l-1 -3 h18 l-1 3 M2 20 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 a2.4 2.4 0 0 1 2 -1 a2.4 2.4 0 0 1 2 1 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 a2.4 2.4 0 0 1 2 -1 a2.4 2.4 0 0 1 2 1 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 M0 0 h24 v24 H0 z";
				case IconKind.Salad:
					return "M13 11 v-0.5 a2.5 2.5 0 1 0 -5 0 v0.5 M8 8 l1 -4 l4 2.5 M5.255 11.008 a12.204 12.204 0 0 1 -0.255 -2.008 v-1 h1.755 c0.98 0 1.801 0.124 2.479 0.35 M18.5 11 c0.351 -1.017 0.426 -2.236 0.5 -3.714 v-1.286 h-2.256 c-2.83 0 -4.616 0.804 -5.64 2.076 M4 11 h16 a1 1 0 0 1 1 1 v0.5 c0 1.5 -2.517 5.573 -4 6.5 v1 a1 1 0 0 1 -1 1 h-8 a1 1 0 0 1 -1 -1 v-1 c-1.687 -1.054 -4 -5 -4 -6.5 v-0.5 a1 1 0 0 1 1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.Salt:
					return "M7.5 8 l-1.612 9.671 a2 2 0 0 0 1.973 2.329 h8.278 a2 2 0 0 0 1.973 -2.329 l-1.612 -9.671 M7.5 8 h9 l-0.281 -2.248 a2 2 0 0 0 -1.985 -1.752 h-4.468 a2 2 0 0 0 -1.986 1.752 l-0.28 2.248 z M14 16 v0.01 M10 16 v0.01 M12 13 v0.01 M0 0 h24 v24 H0 z";
				case IconKind.SatelliteOff:
					return "M3 3 l18 18 M15 21 c1.654 0 3.151 -0.67 4.237 -1.752 m1.507 -2.507 a6 6 0 0 0 0.256 -1.741 M14.5 17 c0.69 0 1.316 -0.28 1.769 -0.733 M12 12 l1.5 1.5 M10 6 l3 -3 l3 3 l-3 3 M6 10 l-3 3 l3 3 l3 -3 M7.707 3.707 l5.586 5.586 m-1.293 2.707 l-1.293 1.293 a1 1 0 0 1 -1.414 0 l-5.586 -5.586 a1 1 0 0 1 0 -1.414 l1.293 -1.293 M0 0 h24 v24 H0 z";
				case IconKind.Satellite:
					return "M15 21 a6 6 0 0 0 6 -6 M14.5 17 a2.5 2.5 0 0 0 2.5 -2.5 M12 12 l1.5 1.5 M10 6 l3 -3 l3 3 l-3 3 M6 10 l-3 3 l3 3 l3 -3 M3.707 6.293 l2.586 -2.586 a1 1 0 0 1 1.414 0 l5.586 5.586 a1 1 0 0 1 0 1.414 l-2.586 2.586 a1 1 0 0 1 -1.414 0 l-5.586 -5.586 a1 1 0 0 1 0 -1.414 z M0 0 h24 v24 H0 z";
				case IconKind.Sausage:
					return "M18.482 18.225 l1.989 -1.243 a1 1 0 0 1 1.53 0.848 v1.392 a1 1 0 0 1 -1.53 0.848 l-1.991 -1.245 M5.195 5.519 l-1.243 -1.989 a1 1 0 0 1 0.848 -1.53 h1.392 a1 1 0 0 1 0.848 1.53 l-1.245 1.99 M5.5 5.5 a2.5 2.5 0 0 0 -2.5 2.5 c0 7.18 5.82 13 13 13 a2.5 2.5 0 1 0 0 -5 a8 8 0 0 1 -8 -8 a2.5 2.5 0 0 0 -2.5 -2.5 z M0 0 h24 v24 H0 z";
				case IconKind.ScaleOff:
					return "M3 3 l18 18 M18.873 14.871 a3 3 0 0 0 2.127 -2.871 l-3 -6 l-2.677 5.355 M9 12 l-3 -6 l-3 6 a3 3 0 0 0 6 0 M12 3 v5 m0 4 v8 M9.452 5.425 l2.548 -0.425 l6 1 M7 20 h10 M0 0 h24 v24 H0 z";
				case IconKind.ScaleOutlineOff:
					return "M3 3 l18 18 M11.062 7.062 c0.31 -0.041 0.622 -0.062 0.938 -0.062 c1.956 0 3.724 0.802 5 2.095 a142.85 142.85 0 0 0 -2 1.905 m-3.723 0.288 a3 3 0 0 0 -1.315 0.71 l-2.956 -2.903 a6.977 6.977 0 0 1 1.142 -0.942 M7 3 h10 a4 4 0 0 1 4 4 v10 m-1.173 2.83 a3.987 3.987 0 0 1 -2.827 1.17 h-10 a4 4 0 0 1 -4 -4 v-10 c0 -1.104 0.447 -2.103 1.17 -2.827 M0 0 h24 v24 H0 z";
				case IconKind.ScaleOutline:
					return "M12 7 c1.956 0 3.724 0.802 5 2.095 l-2.956 2.904 a3 3 0 0 0 -2.038 -0.799 a3 3 0 0 0 -2.038 0.798 l-2.956 -2.903 a6.979 6.979 0 0 1 5 -2.095 z M3 3 m0 4 a4 4 0 0 1 4 -4 h10 a4 4 0 0 1 4 4 v10 a4 4 0 0 1 -4 4 h-10 a4 4 0 0 1 -4 -4 z M0 0 h24 v24 H0 z";
				case IconKind.Scale:
					return "M21 12 l-3 -6 l-3 6 a3 3 0 0 0 6 0 M9 12 l-3 -6 l-3 6 a3 3 0 0 0 6 0 M12 3 l0 17 M6 6 l6 -1 l6 1 M7 20 l10 0 M0 0 h24 v24 H0 z";
				case IconKind.ScanEye:
					return "M12 12 h-0.01 M7 12 c3.333 4.667 6.667 4.667 10 0 M7 12 c3.333 -4.667 6.667 -4.667 10 0 M16 20 h2 a2 2 0 0 0 2 -2 v-2 M16 4 h2 a2 2 0 0 1 2 2 v2 M4 16 v2 a2 2 0 0 0 2 2 h2 M4 8 v-2 a2 2 0 0 1 2 -2 h2 M0 0 h24 v24 H0 z";
				case IconKind.Scan:
					return "M5 12 l14 0 M16 20 h2 a2 2 0 0 0 2 -2 v-1 M16 4 h2 a2 2 0 0 1 2 2 v1 M4 17 v1 a2 2 0 0 0 2 2 h2 M4 7 v-1 a2 2 0 0 1 2 -2 h2 M0 0 h24 v24 H0 z";
				case IconKind.SchemaOff:
					return "M3 3 l18 18 M7.5 14 v4 M7.5 7.5 v2.5 M10 12 h2 M5 10 h5 v4 h-5 z M5 18 h5 v4 h-5 z M15 11 v-1 h5 v4 h-2 M6 2 h4 v4 m-4 0 h-1 v-1 M0 0 h24 v24 H0 z";
				case IconKind.Schema:
					return "M7.5 14 v4 M7.5 6 v4 M10 12 h5 M5 10 h5 v4 h-5 z M5 18 h5 v4 h-5 z M15 10 h5 v4 h-5 z M5 2 h5 v4 h-5 z M0 0 h24 v24 H0 z";
				case IconKind.SchoolBell:
					return "M16.505 7.495 a5.105 5.105 0 0 1 0.176 7.035 l-0.176 0.184 l-1.867 1.867 a3.48 3.48 0 0 0 -1.013 2.234 l-0.008 0.23 v0.934 c0 0.327 -0.13 0.64 -0.36 0.871 a0.51 0.51 0 0 1 -0.652 0.06 l-0.07 -0.06 l-9.385 -9.384 a0.51 0.51 0 0 1 0 -0.722 c0.198 -0.198 0.456 -0.322 0.732 -0.353 l0.139 -0.008 h0.933 c0.848 0 1.663 -0.309 2.297 -0.864 l0.168 -0.157 l1.867 -1.867 l0.16 -0.153 a5.105 5.105 0 0 1 7.059 0.153 z M14.805 6.37 l2.783 -2.784 a2 2 0 1 1 2.829 2.828 l-2.784 2.786 M4 17 a3 3 0 0 0 3 3 M0 0 h24 v24 H0 z";
				case IconKind.SchoolOff:
					return "M3 3 l18 18 M6 10.6 v5.4 c0 1.657 2.686 3 6 3 c2.334 0 4.357 -0.666 5.35 -1.64 m0.65 -3.36 v-3.4 M22 9 l-10 -4 l-2.136 0.854 m-2.864 1.146 l-5 2 l10 4 l0.697 -0.279 m2.878 -1.151 l6.425 -2.57 v6 M0 0 h24 v24 H0 z";
				case IconKind.School:
					return "M6 10.6 v5.4 a6 3 0 0 0 12 0 v-5.4 M22 9 l-10 -4 l-10 4 l10 4 l10 -4 v6 M0 0 h24 v24 H0 z";
				case IconKind.ScissorsOff:
					return "M3 3 l18 18 M8.6 15.4 l3.4 -3.4 m2 -2 l5 -5 M6 17 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M4.432 4.442 a3 3 0 1 0 4.114 4.146 M0 0 h24 v24 H0 z";
				case IconKind.Scissors:
					return "M8.6 15.4 l10.4 -10.4 M8.6 8.6 l10.4 10.4 M6 17 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M6 7 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.ScooterElectric:
					return "M10 4 l-2 4 h3 l-2 4 M8 17 h5 a6 6 0 0 1 5 -5 v-5 a2 2 0 0 0 -2 -2 h-1 M6 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M18 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Scooter:
					return "M8 17 h5 a6 6 0 0 1 5 -5 v-5 a2 2 0 0 0 -2 -2 h-1 M6 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M18 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.ScreenShareOff:
					return "M17 8 l4 -4 m-4 0 l4 4 M15 16 l0 4 M9 16 l0 4 M7 20 l10 0 M21 12 v3 a1 1 0 0 1 -1 1 h-16 a1 1 0 0 1 -1 -1 v-10 a1 1 0 0 1 1 -1 h9 M0 0 h24 v24 H0 z";
				case IconKind.ScreenShare:
					return "M16 9 l5 -5 M17 4 h4 v4 M15 16 l0 4 M9 16 l0 4 M7 20 l10 0 M21 12 v3 a1 1 0 0 1 -1 1 h-16 a1 1 0 0 1 -1 -1 v-10 a1 1 0 0 1 1 -1 h9 M0 0 h24 v24 H0 z";
				case IconKind.Screenshot:
					return "M13 19 h-2 M21 19 h-4 M19 17 v4 M19 11 v2 M17 5 a2 2 0 0 1 2 2 M11 5 h2 M5 7 a2 2 0 0 1 2 -2 M5 13 v-2 M7 19 a2 2 0 0 1 -2 -2 M0 0 h24 v24 H0 z";
				case IconKind.ScribbleOff:
					return "M3 3 l18 18 M3 15 c2 3 4 4 7 4 c1.95 0 4.324 -1.268 5.746 -3.256 m1.181 -2.812 a5.97 5.97 0 0 0 0.073 -0.932 c0 -4 -3 -7 -6 -7 c-0.642 0 -1.239 0.069 -1.78 0.201 m-2.492 1.515 c-0.47 0.617 -0.728 1.386 -0.728 2.284 c0 2.5 2 5 6 5 c0.597 0 1.203 -0.055 1.808 -0.156 m3.102 -0.921 c2.235 -0.953 4.152 -2.423 5.09 -3.923 M0 0 h24 v24 H0 z";
				case IconKind.Scribble:
					return "M3 15 c2 3 4 4 7 4 s7 -3 7 -7 s-3 -7 -6 -7 s-5 1.5 -5 4 s2 5 6 5 s8.408 -2.453 10 -5 M0 0 h24 v24 H0 z";
				case IconKind.ScriptMinus:
					return "M14 20 h-8 a3 3 0 0 1 0 -6 h11 a3 3 0 0 0 -3 3 m7 -2 v-9 a2 2 0 0 0 -2 -2 h-10 a2 2 0 0 0 -2 2 v8 M17 19 h4 M0 0 h24 v24 H0 z";
				case IconKind.ScriptPlus:
					return "M19 17 v4 M14 20 h-8 a3 3 0 0 1 0 -6 h11 a3 3 0 0 0 -3 3 m7 -3 v-8 a2 2 0 0 0 -2 -2 h-10 a2 2 0 0 0 -2 2 v8 M17 19 h4 M0 0 h24 v24 H0 z";
				case IconKind.ScriptX:
					return "M17 17 l4 4 m0 -4 l-4 4 M14 20 h-8 a3 3 0 0 1 0 -6 h11 a3 3 0 0 0 -3 3 m7 -3 v-8 a2 2 0 0 0 -2 -2 h-10 a2 2 0 0 0 -2 2 v8 M0 0 h24 v24 H0 z";
				case IconKind.Script:
					return "M17 20 h-11 a3 3 0 0 1 0 -6 h11 a3 3 0 0 0 0 6 h1 a3 3 0 0 0 3 -3 v-11 a2 2 0 0 0 -2 -2 h-10 a2 2 0 0 0 -2 2 v8 M0 0 h24 v24 H0 z";
				case IconKind.ScubaMaskOff:
					return "M3 3 l18 18 M10 17 a2 2 0 0 0 2 2 h3.5 a5.475 5.475 0 0 0 2.765 -0.744 m2 -2 c0.47 -0.81 0.739 -1.752 0.739 -2.756 v-9.5 M11 7 h5 a1 1 0 0 1 1 1 v4.5 c0 0.154 -0.014 0.304 -0.04 0.45 m-2 2.007 c-0.15 0.028 -0.305 0.043 -0.463 0.043 h-0.5 a2 2 0 0 1 -2 -2 a2 2 0 1 0 -4 0 a2 2 0 0 1 -2 2 h-0.5 a2.5 2.5 0 0 1 -2.5 -2.5 v-4.5 a1 1 0 0 1 1 -1 h3 M0 0 h24 v24 H0 z";
				case IconKind.ScubaMask:
					return "M10 17 a2 2 0 0 0 2 2 h3.5 a5.5 5.5 0 0 0 5.5 -5.5 v-9.5 M4 7 h12 a1 1 0 0 1 1 1 v4.5 a2.5 2.5 0 0 1 -2.5 2.5 h-0.5 a2 2 0 0 1 -2 -2 a2 2 0 1 0 -4 0 a2 2 0 0 1 -2 2 h-0.5 a2.5 2.5 0 0 1 -2.5 -2.5 v-4.5 a1 1 0 0 1 1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.Sdk:
					return "M10 8 v8 h2 a2 2 0 0 0 2 -2 v-4 a2 2 0 0 0 -2 -2 h-2 z M17 12 h1 M21 8 l-3 4 l3 4 M17 8 v8 M7 8 h-3 a1 1 0 0 0 -1 1 v2 a1 1 0 0 0 1 1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-3 M0 0 h24 v24 H0 z";
				case IconKind.SearchOff:
					return "M3 3 l18 18 M5.039 5.062 a7 7 0 0 0 9.91 9.89 m1.584 -2.434 a7 7 0 0 0 -9.038 -9.057 M0 0 h24 v24 H0 z";
				case IconKind.Search:
					return "M21 21 l-6 -6 M10 10 m-7 0 a7 7 0 1 0 14 0 a7 7 0 1 0 -14 0 M0 0 h24 v24 H0 z";
				case IconKind.SectionSign:
					return "M12 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M14.83 5 a3 3 0 1 0 -2.83 4 M9.172 19 a3 3 0 1 0 2.828 -4 M0 0 h24 v24 H0 z";
				case IconKind.Section:
					return "M4 8 m0 1 a1 1 0 0 1 1 -1 h14 a1 1 0 0 1 1 1 v6 a1 1 0 0 1 -1 1 h-14 a1 1 0 0 1 -1 -1 z M16 4 l0 0 M12 4 h0.01 M8 4 h0.01 M4 4 h0.01 M20 4 h0.01 M16 20 h0.01 M12 20 h0.01 M8 20 h0.01 M4 20 h0.01 M20 20 h0.01 M0 0 h24 v24 H0 z";
				case IconKind.SeedingOff:
					return "M3 3 l18 18 M12 20 v-8 M12 14 a6 6 0 0 1 0.255 -1.736 m1.51 -2.514 a5.981 5.981 0 0 1 4.235 -1.75 h3 v1 c0 2.158 -1.14 4.05 -2.85 5.107 m-3.15 0.893 h-3 M11.412 7.407 a6.025 6.025 0 0 0 -2.82 -2.82 m-4.592 -0.587 h-1 v2 a6 6 0 0 0 6 6 h3 M0 0 h24 v24 H0 z";
				case IconKind.Seeding:
					return "M12 20 l0 -10 M12 14 a6 6 0 0 1 6 -6 h3 v1 a6 6 0 0 1 -6 6 h-3 M12 10 a6 6 0 0 0 -6 -6 h-3 v2 a6 6 0 0 0 6 6 h3 M0 0 h24 v24 H0 z";
				case IconKind.Select:
					return "M9 11 l3 3 l3 -3 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Selector:
					return "M16 15 l-4 4 l-4 -4 M8 9 l4 -4 l4 4 M0 0 h24 v24 H0 z";
				case IconKind.SendOff:
					return "M3 3 l18 18 M10.718 6.713 l10.282 -3.713 l-3.715 10.289 m-1.063 2.941 l-1.722 4.77 a0.55 0.55 0 0 1 -1 0 l-3.5 -7 l-7 -3.5 a0.55 0.55 0 0 1 0 -1 l4.772 -1.723 M10 14 l2 -2 m2 -2 l7 -7 M0 0 h24 v24 H0 z";
				case IconKind.Send:
					return "M21 3 l-6.5 18 a0.55 0.55 0 0 1 -1 0 l-3.5 -7 l-7 -3.5 a0.55 0.55 0 0 1 0 -1 l18 -6.5 M10 14 l11 -11 M0 0 h24 v24 H0 z";
				case IconKind.Seo:
					return "M17 8 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v6 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M11 12 h2 M14 16 h-4 v-8 h4 M7 8 h-3 a1 1 0 0 0 -1 1 v2 a1 1 0 0 0 1 1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-3 M0 0 h24 v24 H0 z";
				case IconKind.SeparatorHorizontal:
					return "M16 16 l-4 4 l-4 -4 M8 8 l4 -4 l4 4 M4 12 l16 0 M0 0 h24 v24 H0 z";
				case IconKind.SeparatorVertical:
					return "M16 16 l4 -4 l-4 -4 M8 8 l-4 4 l4 4 M12 4 l0 16 M0 0 h24 v24 H0 z";
				case IconKind.Separator:
					return "M21 12 l0 0.01 M7 12 l10 0 M3 12 l0 0.01 M0 0 h24 v24 H0 z";
				case IconKind.Server2:
					return "M11 16 h6 M11 8 h6 M7 16 l0 0.01 M7 8 l0 0.01 M3 12 m0 3 a3 3 0 0 1 3 -3 h12 a3 3 0 0 1 3 3 v2 a3 3 0 0 1 -3 3 h-12 a3 3 0 0 1 -3 -3 z M3 4 m0 3 a3 3 0 0 1 3 -3 h12 a3 3 0 0 1 3 3 v2 a3 3 0 0 1 -3 3 h-12 a3 3 0 0 1 -3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.ServerBolt:
					return "M20 15 l-2 3 h3 l-2 3 M7 16 v0.01 M7 8 v0.01 M15 20 h-9 a3 3 0 0 1 -3 -3 v-2 a3 3 0 0 1 3 -3 h12 M3 4 m0 3 a3 3 0 0 1 3 -3 h12 a3 3 0 0 1 3 3 v2 a3 3 0 0 1 -3 3 h-12 a3 3 0 0 1 -3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.ServerCog:
					return "M7 16 v0.01 M7 8 v0.01 M19.733 19 l1.3 0.75 M14.97 16.25 l1.3 0.75 M16.27 19 l-1.3 0.75 M21.032 16.25 l-1.299 0.75 M18 20 v1.5 M18 14.5 v1.5 M18 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M12 20 h-6 a3 3 0 0 1 -3 -3 v-2 a3 3 0 0 1 3 -3 h10.5 M3 4 m0 3 a3 3 0 0 1 3 -3 h12 a3 3 0 0 1 3 3 v2 a3 3 0 0 1 -3 3 h-12 a3 3 0 0 1 -3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.ServerOff:
					return "M3 3 l18 18 M7 16 v0.01 M7 8 v0.01 M16 12 h2 a3 3 0 0 1 3 3 v2 m-1.448 2.568 a2.986 2.986 0 0 1 -1.552 0.432 h-12 a3 3 0 0 1 -3 -3 v-2 a3 3 0 0 1 3 -3 h6 M12 12 h-6 a3 3 0 0 1 -3 -3 v-2 c0 -1.083 0.574 -2.033 1.435 -2.56 m3.565 -0.44 h10 a3 3 0 0 1 3 3 v2 a3 3 0 0 1 -3 3 h-2 M0 0 h24 v24 H0 z";
				case IconKind.Server:
					return "M7 16 l0 0.01 M7 8 l0 0.01 M3 12 m0 3 a3 3 0 0 1 3 -3 h12 a3 3 0 0 1 3 3 v2 a3 3 0 0 1 -3 3 h-12 a3 3 0 0 1 -3 -3 z M3 4 m0 3 a3 3 0 0 1 3 -3 h12 a3 3 0 0 1 3 3 v2 a3 3 0 0 1 -3 3 h-12 a3 3 0 0 1 -3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.Servicemark:
					return "M13 15 v-6 l3 4 l3 -4 v6 M9 9 h-2.5 a1.5 1.5 0 0 0 0 3 h1 a1.5 1.5 0 0 1 0 3 h-2.5 M0 0 h24 v24 H0 z";
				case IconKind.Settings2:
					return "M12 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M19 6.873 a2 2 0 0 1 1 1.747 v6.536 a2 2 0 0 1 -1.029 1.748 l-6 3.833 a2 2 0 0 1 -1.942 0 l-6 -3.833 a2 2 0 0 1 -1.029 -1.747 v-6.537 a2 2 0 0 1 1.029 -1.748 l6 -3.572 a2.056 2.056 0 0 1 2 0 l6 3.573 h-0.029 z M0 0 h24 v24 H0 z";
				case IconKind.SettingsAutomation:
					return "M10 9 v6 l5 -3 z M10.325 4.317 c0.426 -1.756 2.924 -1.756 3.35 0 a1.724 1.724 0 0 0 2.573 1.066 c1.543 -0.94 3.31 0.826 2.37 2.37 a1.724 1.724 0 0 0 1.065 2.572 c1.756 0.426 1.756 2.924 0 3.35 a1.724 1.724 0 0 0 -1.066 2.573 c0.94 1.543 -0.826 3.31 -2.37 2.37 a1.724 1.724 0 0 0 -2.572 1.065 c-0.426 1.756 -2.924 1.756 -3.35 0 a1.724 1.724 0 0 0 -2.573 -1.066 c-1.543 0.94 -3.31 -0.826 -2.37 -2.37 a1.724 1.724 0 0 0 -1.065 -2.572 c-1.756 -0.426 -1.756 -2.924 0 -3.35 a1.724 1.724 0 0 0 1.066 -2.573 c-0.94 -1.543 0.826 -3.31 2.37 -2.37 c1 0.608 2.296 0.07 2.572 -1.065 z M0 0 h24 v24 H0 z";
				case IconKind.SettingsFilled:
					return "M13.675 4.317 a1.724 1.724 0 0 0 2.573 1.066 c1.543 -0.94 3.31 0.826 2.37 2.37 a1.724 1.724 0 0 0 1.065 2.572 c1.756 0.426 1.756 2.924 0 3.35 a1.724 1.724 0 0 0 -1.066 2.573 c0.94 1.543 -0.826 3.31 -2.37 2.37 a1.724 1.724 0 0 0 -2.572 1.065 c-0.426 1.756 -2.924 1.756 -3.35 0 a1.724 1.724 0 0 0 -2.573 -1.066 c-1.543 0.94 -3.31 -0.826 -2.37 -2.37 a1.724 1.724 0 0 0 -1.065 -2.572 c-1.756 -0.426 -1.756 -2.924 0 -3.35 a1.724 1.724 0 0 0 1.066 -2.573 c-0.94 -1.543 0.826 -3.31 2.37 -2.37 c1 0.608 2.296 0.07 2.572 -1.065 c0.426 -1.756 2.924 -1.756 3.35 0 m-4.675 7.683 a3 3 0 0 0 6 0 a3 3 0 0 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.SettingsOff:
					return "M3 3 l18 18 M9.879 9.878 a3 3 0 1 0 4.256 4.23 m0.552 -3.444 a3.012 3.012 0 0 0 -1.412 -1.38 M9.456 5.435 c0.416 -0.22 0.745 -0.609 0.869 -1.118 c0.426 -1.756 2.924 -1.756 3.35 0 a1.724 1.724 0 0 0 2.573 1.066 c1.543 -0.94 3.31 0.826 2.37 2.37 a1.724 1.724 0 0 0 1.065 2.572 c1.756 0.426 1.756 2.924 0 3.35 a1.724 1.724 0 0 0 -1.187 1.016 m-0.126 3.666 c-0.516 0.522 -1.348 0.733 -2.123 0.261 a1.724 1.724 0 0 0 -2.572 1.065 c-0.426 1.756 -2.924 1.756 -3.35 0 a1.724 1.724 0 0 0 -2.573 -1.066 c-1.543 0.94 -3.31 -0.826 -2.37 -2.37 a1.724 1.724 0 0 0 -1.065 -2.572 c-1.756 -0.426 -1.756 -2.924 0 -3.35 a1.724 1.724 0 0 0 1.066 -2.573 c-0.468 -0.768 -0.266 -1.59 0.246 -2.108 M0 0 h24 v24 H0 z";
				case IconKind.Settings:
					return "M12 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M10.325 4.317 c0.426 -1.756 2.924 -1.756 3.35 0 a1.724 1.724 0 0 0 2.573 1.066 c1.543 -0.94 3.31 0.826 2.37 2.37 a1.724 1.724 0 0 0 1.065 2.572 c1.756 0.426 1.756 2.924 0 3.35 a1.724 1.724 0 0 0 -1.066 2.573 c0.94 1.543 -0.826 3.31 -2.37 2.37 a1.724 1.724 0 0 0 -2.572 1.065 c-0.426 1.756 -2.924 1.756 -3.35 0 a1.724 1.724 0 0 0 -2.573 -1.066 c-1.543 0.94 -3.31 -0.826 -2.37 -2.37 a1.724 1.724 0 0 0 -1.065 -2.572 c-1.756 -0.426 -1.756 -2.924 0 -3.35 a1.724 1.724 0 0 0 1.066 -2.573 c-0.94 -1.543 0.826 -3.31 2.37 -2.37 c1 0.608 2.296 0.07 2.572 -1.065 z M0 0 h24 v24 H0 z";
				case IconKind.ShadowOff:
					return "M3 3 l18 18 M13 6 h1 M13 9 h4 M13 18 h1 M13 15 h2 M16 12 h2 M5.634 5.638 a9 9 0 0 0 12.728 12.727 m1.68 -2.32 a9 9 0 0 0 -12.086 -12.088 M0 0 h24 v24 H0 z";
				case IconKind.Shadow:
					return "M13 6 h1 M13 9 h4 M13 18 h1 M13 15 h4 M13 12 h5 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.Shape2:
					return "M6.5 17.5 l11 -11 m-12.5 0.5 v10 m14 -10 v10 M5 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M19 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M19 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Shape3:
					return "M7 5 h10 m-12 2 v10 m14 -10 v10 M5 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M19 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M19 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.ShapeOff:
					return "M3 3 l18 18 M19 7 v8 M7 19 h10 M9 5 h8 M5 7 v10 M17.574 17.598 a2 2 0 0 0 2.826 2.83 M5 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M19 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M3.575 3.597 a2 2 0 0 0 2.849 2.808 M0 0 h24 v24 H0 z";
				case IconKind.Shape:
					return "M19 7 l0 10 M7 19 l10 0 M7 5 l10 0 M5 7 l0 10 M19 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M19 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.ShareOff:
					return "M3 3 l18 18 M8.7 13.3 l6.6 3.4 M8.7 10.7 l1.336 -0.688 m2.624 -1.352 l2.64 -1.36 M15.861 15.896 a3 3 0 0 0 4.265 4.22 m0.578 -3.417 a3.012 3.012 0 0 0 -1.507 -1.45 M18 6 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M6 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.Share:
					return "M8.7 13.3 l6.6 3.4 M8.7 10.7 l6.6 -3.4 M18 18 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M18 6 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M6 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.ShieldCheck:
					return "M12 3 a12 12 0 0 0 8.5 3 a12 12 0 0 1 -8.5 15 a12 12 0 0 1 -8.5 -15 a12 12 0 0 0 8.5 -3 M9 12 l2 2 l4 -4 M0 0 h24 v24 H0 z";
				case IconKind.ShieldCheckered:
					return "M3.5 12 h17 M12 3 v18 M12 3 a12 12 0 0 0 8.5 3 a12 12 0 0 1 -8.5 15 a12 12 0 0 1 -8.5 -15 a12 12 0 0 0 8.5 -3 M0 0 h24 v24 H0 z";
				case IconKind.ShieldChevron:
					return "M4 14 l8 -3 l8 3 M12 3 a12 12 0 0 0 8.5 3 a12 12 0 0 1 -8.5 15 a12 12 0 0 1 -8.5 -15 a12 12 0 0 0 8.5 -3 M0 0 h24 v24 H0 z";
				case IconKind.ShieldFilled:
					return "M12 3 a12 12 0 0 0 8.5 3 a12 12 0 0 1 -8.5 15 a12 12 0 0 1 -8.5 -15 a12 12 0 0 0 8.5 -3 M0 0 h24 v24 H0 z";
				case IconKind.ShieldHalfFilled:
					return "M12 14 h8 M12 17 h6.2 M12 5 h3.1 M12 8 h8.9 M12 11 h8.9 M12 3 v18 M12 3 a12 12 0 0 0 8.5 3 a12 12 0 0 1 -8.5 15 a12 12 0 0 1 -8.5 -15 a12 12 0 0 0 8.5 -3 M0 0 h24 v24 H0 z";
				case IconKind.ShieldHalf:
					return "M12 3 v18 M12 3 a12 12 0 0 0 8.5 3 a12 12 0 0 1 -8.5 15 a12 12 0 0 1 -8.5 -15 a12 12 0 0 0 8.5 -3 M0 0 h24 v24 H0 z";
				case IconKind.ShieldLock:
					return "M12 12 l0 2.5 M12 11 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12 3 a12 12 0 0 0 8.5 3 a12 12 0 0 1 -8.5 15 a12 12 0 0 1 -8.5 -15 a12 12 0 0 0 8.5 -3 M0 0 h24 v24 H0 z";
				case IconKind.ShieldOff:
					return "M17.669 17.669 a12 12 0 0 1 -5.669 3.331 a12 12 0 0 1 -8.5 -15 c0.797 0.036 1.589 0 2.366 -0.126 m3.092 -0.912 a12 12 0 0 0 3.042 -1.962 a12 12 0 0 0 8.5 3 a12 12 0 0 1 -1.117 9.379 M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.ShieldX:
					return "M10 10 l4 4 m0 -4 l-4 4 M12 3 a12 12 0 0 0 8.5 3 a12 12 0 0 1 -8.5 15 a12 12 0 0 1 -8.5 -15 a12 12 0 0 0 8.5 -3 M0 0 h24 v24 H0 z";
				case IconKind.Shield:
					return "M12 3 a12 12 0 0 0 8.5 3 a12 12 0 0 1 -8.5 15 a12 12 0 0 1 -8.5 -15 a12 12 0 0 0 8.5 -3 M0 0 h24 v24 H0 z";
				case IconKind.ShipOff:
					return "M3 3 l18 18 M5 13 v-6 h2 m4 0 h2 l4 6 M4 18 l-1 -5 h10 m4 0 h4 l-1.334 2.668 M2 20 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 a2.4 2.4 0 0 1 2 -1 a2.4 2.4 0 0 1 2 1 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 a2.4 2.4 0 0 1 2 -1 a2.4 2.4 0 0 1 2 1 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 M0 0 h24 v24 H0 z";
				case IconKind.Ship:
					return "M7 7 v-4 h-1 M5 13 v-6 h8 l4 6 M4 18 l-1 -5 h18 l-2 4 M2 20 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 a2.4 2.4 0 0 1 2 -1 a2.4 2.4 0 0 1 2 1 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 a2.4 2.4 0 0 1 2 -1 a2.4 2.4 0 0 1 2 1 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 M0 0 h24 v24 H0 z";
				case IconKind.ShirtFilled:
					return "M15 4 l6 2 v5 h-3 v8 a1 1 0 0 1 -1 1 h-10 a1 1 0 0 1 -1 -1 v-8 h-3 v-5 l6 -2 a3 3 0 0 0 6 0 M0 0 h24 v24 H0 z";
				case IconKind.ShirtOff:
					return "M3 3 l18 18 M8.243 4.252 l0.757 -0.252 c0 0.43 0.09 0.837 0.252 1.206 m1.395 1.472 a3 3 0 0 0 4.353 -2.678 l6 2 v5 h-3 v3 m0 4 v1 a1 1 0 0 1 -1 1 h-10 a1 1 0 0 1 -1 -1 v-8 h-3 v-5 l2.26 -0.753 M0 0 h24 v24 H0 z";
				case IconKind.ShirtSport:
					return "M10.5 11 h2.5 l-1.5 5 M15 4 l6 2 v5 h-3 v8 a1 1 0 0 1 -1 1 h-10 a1 1 0 0 1 -1 -1 v-8 h-3 v-5 l6 -2 a3 3 0 0 0 6 0 M0 0 h24 v24 H0 z";
				case IconKind.Shirt:
					return "M15 4 l6 2 v5 h-3 v8 a1 1 0 0 1 -1 1 h-10 a1 1 0 0 1 -1 -1 v-8 h-3 v-5 l6 -2 a3 3 0 0 0 6 0 M0 0 h24 v24 H0 z";
				case IconKind.ShoeOff:
					return "M3 3 l18 18 M10 12 l0.663 -1.327 M8 18 v-1 a4 4 0 0 0 -4 -4 h-1 M13.846 9.868 l4.08 0.972 a4 4 0 0 1 3.074 3.89 v2.27 m-3 1 h-14 a1 1 0 0 1 -1 -1 v-10 a1 1 0 0 1 1 -1 h2 M0 0 h24 v24 H0 z";
				case IconKind.Shoe:
					return "M10 12 l1.5 -3 M8 18 v-1 a4 4 0 0 0 -4 -4 h-1 M14 13 l1 -2 M4 6 h5.426 a1 1 0 0 1 0.863 0.496 l1.064 1.823 a3 3 0 0 0 1.896 1.407 l4.677 1.114 a4 4 0 0 1 3.074 3.89 v2.27 a1 1 0 0 1 -1 1 h-16 a1 1 0 0 1 -1 -1 v-10 a1 1 0 0 1 1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.ShoppingBag:
					return "M9 11 v-5 a3 3 0 0 1 6 0 v5 M6.331 8 h11.339 a2 2 0 0 1 1.977 2.304 l-1.255 8.152 a3 3 0 0 1 -2.966 2.544 h-6.852 a3 3 0 0 1 -2.965 -2.544 l-1.255 -8.152 a2 2 0 0 1 1.977 -2.304 z M0 0 h24 v24 H0 z";
				case IconKind.ShoppingCartDiscount:
					return "M15.5 9.5 m-0.5 0 a0.5 0.5 0 1 0 1 0 a0.5 0.5 0 1 0 -1 0 M10.5 4.5 m-0.5 0 a0.5 0.5 0 1 0 1 0 a0.5 0.5 0 1 0 -1 0 M10 10 l6 -6 M20 6 l-1 7 h-13 M17 17 h-11 v-14 h-2 M17 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.ShoppingCartOff:
					return "M3 3 l18 18 M9.239 5.231 l10.761 0.769 l-1 7 h-2 m-4 0 h-7 M17 17 h-11 v-11 M17 17 a2 2 0 1 0 2 2 M6 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.ShoppingCartPlus:
					return "M15 6 h6 m-3 -3 v6 M6 5 l6 0.429 m7.138 6.573 l-0.143 1 h-13 M17 17 h-11 v-14 h-2 M17 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.ShoppingCartX:
					return "M21 3 l-4 4 M17 3 l4 4 M6 5 l8 0.571 m5.43 4.43 l-0.429 3 h-13 M17 17 h-11 v-14 h-2 M17 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.ShoppingCart:
					return "M6 5 l14 1 l-1 7 h-13 M17 17 h-11 v-14 h-2 M17 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Shovel:
					return "M8.276 11.284 l4.44 4.44 a0.968 0.968 0 0 1 0 1.369 l-2.704 2.704 a4.108 4.108 0 0 1 -5.809 -5.81 l2.704 -2.703 a0.968 0.968 0 0 1 1.37 0 z M18.5 5.5 l-8 8 M17 4 l3 3 M0 0 h24 v24 H0 z";
				case IconKind.Shredder:
					return "M17 10 v-4 a2 2 0 0 0 -2 -2 h-6 a2 2 0 0 0 -2 2 v4 m5 5 v5 m4 -5 v2 m-8 -2 v3 M4 10 m0 1 a1 1 0 0 1 1 -1 h14 a1 1 0 0 1 1 1 v3 a1 1 0 0 1 -1 1 h-14 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.SignLeftFilled:
					return "M18 6 h-10 l-2 2.5 l2 2.5 h10 z M14 6 v-3 M14 21 v-10 M16 21 h-4 M0 0 h24 v24 H0 z";
				case IconKind.SignLeft:
					return "M18 6 h-10 l-2 2.5 l2 2.5 h10 z M14 6 v-3 M14 21 v-10 M16 21 h-4 M0 0 h24 v24 H0 z";
				case IconKind.SignRightFilled:
					return "M6 6 h10 l2 2.5 l-2 2.5 h-10 z M10 6 v-3 M10 21 v-10 M8 21 h4 M0 0 h24 v24 H0 z";
				case IconKind.SignRight:
					return "M6 6 h10 l2 2.5 l-2 2.5 h-10 z M10 6 v-3 M10 21 v-10 M8 21 h4 M0 0 h24 v24 H0 z";
				case IconKind.Signal3g:
					return "M8 12 a2 2 0 1 1 0 4 h-3 M19 8 h-3 a2 2 0 0 0 -2 2 v4 a2 2 0 0 0 2 2 h3 v-4 h-1 M5 8 h3 a2 2 0 1 1 0 4 h-3 M0 0 h24 v24 H0 z";
				case IconKind.Signal4gPlus:
					return "M20 10 v4 M18 12 h4 M15 8 h-2 a2 2 0 0 0 -2 2 v4 a2 2 0 0 0 2 2 h2 v-4 h-1 M7 8 v8 M3 8 v5 h5 M0 0 h24 v24 H0 z";
				case IconKind.Signal4g:
					return "M19 8 h-3 a2 2 0 0 0 -2 2 v4 a2 2 0 0 0 2 2 h3 v-4 h-1 M9 8 v8 M5 8 v5 h5 M0 0 h24 v24 H0 z";
				case IconKind.Signal5g:
					return "M19 8 h-3 a2 2 0 0 0 -2 2 v4 a2 2 0 0 0 2 2 h3 v-4 h-1 M10 8 h-5 v4 h3 a2 2 0 1 1 0 4 h-3 M0 0 h24 v24 H0 z";
				case IconKind.SignatureOff:
					return "M3 3 l18 18 M3 17 c3.333 -3.333 5 -6 5 -8 c0 -0.394 -0.017 -0.735 -0.05 -1.033 m-1.95 -1.967 c-1 0 -2.032 1.085 -2 3 c0.034 2.048 1.658 4.877 2.5 6 c1.5 2 2.5 2.5 3.5 1 l2 -3 c0.333 2.667 1.333 4 3 4 c0.219 0 0.708 -0.341 1.231 -0.742 m3.769 -0.258 c0.303 0.245 0.64 0.677 1 1 M0 0 h24 v24 H0 z";
				case IconKind.Signature:
					return "M3 17 c3.333 -3.333 5 -6 5 -8 c0 -3 -1 -3 -2 -3 s-2.032 1.085 -2 3 c0.034 2.048 1.658 4.877 2.5 6 c1.5 2 2.5 2.5 3.5 1 l2 -3 c0.333 2.667 1.333 4 3 4 c0.53 0 2.639 -2 3 -2 c0.517 0 1.517 0.667 3 2 M0 0 h24 v24 H0 z";
				case IconKind.SitemapOff:
					return "M3 3 l18 18 M6 15 v-1 a2 2 0 0 1 2 -2 h4 m4 0 a2 2 0 0 1 2 2 M9 5 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v2 a2 2 0 0 1 -2 2 M19 15 a2 2 0 0 1 2 2 m-0.591 3.42 c-0.362 0.358 -0.86 0.58 -1.409 0.58 h-2 a2 2 0 0 1 -2 -2 v-2 c0 -0.549 0.221 -1.046 0.579 -1.407 M3 15 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v2 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Sitemap:
					return "M12 9 l0 3 M6 15 v-1 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v1 M9 3 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v2 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M15 15 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v2 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M3 15 m0 2 a2 2 0 0 1 2 -2 h2 a2 2 0 0 1 2 2 v2 a2 2 0 0 1 -2 2 h-2 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SkateboardOff:
					return "M3 3 l18 18 M3 9 c0 0.552 0.895 1 2 1 h5 m4 0 h5 c1.105 0 2 -0.448 2 -1 M15 15 a2 2 0 0 0 2 2 m2 -2 a2 2 0 0 0 -2 -2 M7 15 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Skateboard:
					return "M3 9 a2 1 0 0 0 2 1 h14 a2 1 0 0 0 2 -1 M17 15 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M7 15 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Skull:
					return "M15 11 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M9 11 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M14 17 v3 M10 17 v3 M12 4 c4.418 0 8 3.358 8 7.5 c0 1.901 -0.755 3.637 -2 4.96 l0 2.54 a1 1 0 0 1 -1 1 h-10 a1 1 0 0 1 -1 -1 v-2.54 c-1.245 -1.322 -2 -3.058 -2 -4.96 c0 -4.142 3.582 -7.5 8 -7.5 z M0 0 h24 v24 H0 z";
				case IconKind.Slash:
					return "M17 5 l-10 14 M0 0 h24 v24 H0 z";
				case IconKind.Slashes:
					return "M20 5 l-10 14 M14 5 l-10 14 M0 0 h24 v24 H0 z";
				case IconKind.Sleigh:
					return "M7 15 v4 M15 15 v4 M16 15 h-9 a4 4 0 0 1 -4 -4 v-6 l1.243 1.243 a6 6 0 0 0 4.242 1.757 h3.515 v2 a2 2 0 0 0 2 2 h0.5 a1.5 1.5 0 0 0 1.5 -1.5 a1.5 1.5 0 0 1 3 0 v1.5 a3 3 0 0 1 -3 3 z M3 19 h15 a4 4 0 0 0 4 -4 M0 0 h24 v24 H0 z";
				case IconKind.Slice:
					return "M3 19 l15 -15 l3 3 l-6 6 l2 2 a14 14 0 0 1 -14 4 M0 0 h24 v24 H0 z";
				case IconKind.Slideshow:
					return "M16 21 l0.01 0 M12 21 l0.01 0 M8 21 l0.01 0 M13 12 l2 -2 a3 5 0 0 1 3 0 l3 3 M3 13 l4 -4 a3 5 0 0 1 3 0 l4 4 M3 3 m0 3 a3 3 0 0 1 3 -3 h12 a3 3 0 0 1 3 3 v8 a3 3 0 0 1 -3 3 h-12 a3 3 0 0 1 -3 -3 z M15 6 l0.01 0 M0 0 h24 v24 H0 z";
				case IconKind.SmartHomeOff:
					return "M3 3 l18 18 M15.332 15.345 c-2.213 0.976 -5.335 0.86 -7.332 -0.345 M7.097 7.125 l-2.037 1.585 a2.665 2.665 0 0 0 -1.029 2.105 v7.2 a2 2 0 0 0 2 2 h12 c0.559 0 1.064 -0.229 1.427 -0.598 m0.572 -3.417 v-5.185 c0 -0.823 -0.38 -1.6 -1.03 -2.105 l-5.333 -4.148 a2.666 2.666 0 0 0 -3.274 0 l-1.029 0.8 M0 0 h24 v24 H0 z";
				case IconKind.SmartHome:
					return "M16 15 c-2.21 1.333 -5.792 1.333 -8 0 M19 8.71 l-5.333 -4.148 a2.666 2.666 0 0 0 -3.274 0 l-5.334 4.148 a2.665 2.665 0 0 0 -1.029 2.105 v7.2 a2 2 0 0 0 2 2 h12 a2 2 0 0 0 2 -2 v-7.2 c0 -0.823 -0.38 -1.6 -1.03 -2.105 M0 0 h24 v24 H0 z";
				case IconKind.SmokingNo:
					return "M17 13 h3 a1 1 0 0 1 1 1 v2 c0 0.28 -0.115 0.533 -0.3 0.714 m-3.7 0.286 h-13 a1 1 0 0 1 -1 -1 v-2 a1 1 0 0 1 1 -1 h9 M3 3 l18 18 M16 5 v0.5 a2 2 0 0 0 2 2 a2 2 0 0 1 2 2 v0.5 M8 13 l0 4 M0 0 h24 v24 H0 z";
				case IconKind.Smoking:
					return "M16 5 v0.5 a2 2 0 0 0 2 2 a2 2 0 0 1 2 2 v0.5 M8 13 l0 4 M3 13 m0 1 a1 1 0 0 1 1 -1 h16 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-16 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.SnowflakeOff:
					return "M3 3 l18 18 M3.34 7 l5.629 3.25 l0.802 -0.466 M4.072 9.732 l1.866 -1.232 l0.134 -2.232 M3.34 17 l5.629 -3.25 l-0.01 -3.458 M6.072 17.732 l-0.134 -2.232 l-1.866 -1.232 M12 22 v-6.5 l-3 -1.72 M14 20 l-2 -1 l-2 1 M14.212 14.226 l-2.171 1.262 M19.928 14.268 l-1.015 0.67 M20.66 7 l-5.629 3.25 l-0.031 0.75 M17.928 6.268 l0.134 2.232 l1.866 1.232 M12 2 v6 m1.196 1.186 l1.804 1.034 M10 4 l2 1 l2 -1 M0 0 h24 v24 H0 z";
				case IconKind.Snowflake:
					return "M3.34 7 l5.629 3.25 l2.99 -1.738 M4.072 9.732 l1.866 -1.232 l0.134 -2.232 M3.34 17 l5.629 -3.25 l-0.01 -3.458 M6.072 17.732 l-0.134 -2.232 l-1.866 -1.232 M12 22 v-6.5 l-3 -1.72 M14 20 l-2 -1 l-2 1 M20.66 17 l-5.629 -3.25 l-2.99 1.738 M19.928 14.268 l-1.866 1.232 l-0.134 2.232 M20.66 7 l-5.629 3.25 l0.01 3.458 M17.928 6.268 l0.134 2.232 l1.866 1.232 M12 2 v6.5 l3 1.72 M10 4 l2 1 l2 -1 M0 0 h24 v24 H0 z";
				case IconKind.Snowman:
					return "M12 16 h0.01 M12 13 h0.01 M6.5 11.5 l-2.5 -1.5 M17.5 11.5 l2.5 -1.5 M12 3 a4 4 0 0 1 2.906 6.75 a6 6 0 1 1 -5.81 0 a4 4 0 0 1 2.904 -6.75 z M0 0 h24 v24 H0 z";
				case IconKind.SoccerField:
					return "M12 5 l0 14 M3 5 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M18 9 h3 v6 h-3 z M3 9 h3 v6 h-3 z M12 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.SocialOff:
					return "M3 3 l18 18 M17.3 17.8 l-2.8 -2 M6.7 17.8 l2.8 -2 M12 7 v1 M11.113 11.133 a3 3 0 1 0 3.765 3.715 M17.57 17.602 a2 2 0 0 0 2.83 2.827 M5 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M12 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Social:
					return "M17.3 17.8 l-2.8 -2 M6.7 17.8 l2.8 -2 M12 7 l0 4 M12 14 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M19 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M12 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Sock:
					return "M7.895 15.768 c0.708 -0.721 1.105 -1.677 1.105 -2.768 a4 4 0 0 0 -4 -4 M13 3 v6 l4.798 5.142 a4 4 0 0 1 -5.441 5.86 l-6.736 -6.41 a2 2 0 0 1 -0.621 -1.451 v-9.141 h8 z M0 0 h24 v24 H0 z";
				case IconKind.SofaOff:
					return "M3 3 l18 18 M12 5 v3 m0 4 v2 M4 11 v-3 c0 -1.082 0.573 -2.03 1.432 -2.558 m3.568 -0.442 h8 a3 3 0 0 1 3 3 v3 M18 14 v-1 a2 2 0 1 1 4 0 v5 m-3 1 h-16 a1 1 0 0 1 -1 -1 v-5 a2 2 0 1 1 4 0 v1 h8 M0 0 h24 v24 H0 z";
				case IconKind.Sofa:
					return "M12 5 v9 M4 11 v-3 a3 3 0 0 1 3 -3 h10 a3 3 0 0 1 3 3 v3 M4 11 a2 2 0 0 1 2 2 v1 h12 v-1 a2 2 0 1 1 4 0 v5 a1 1 0 0 1 -1 1 h-18 a1 1 0 0 1 -1 -1 v-5 a2 2 0 0 1 2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Sort09:
					return "M16 15 a1 1 0 0 0 1 1 h2 a1 1 0 0 0 1 -1 v-6 a1 1 0 0 0 -1 -1 h-2 a1 1 0 0 0 -1 1 v2 a1 1 0 0 0 1 1 h3 M4 10 v4 a2 2 0 1 0 4 0 v-4 a2 2 0 1 0 -4 0 z M11 12 h2 M0 0 h24 v24 H0 z";
				case IconKind.Sort90:
					return "M11 12 h2 M16 10 v4 a2 2 0 1 0 4 0 v-4 a2 2 0 1 0 -4 0 z M4 15 a1 1 0 0 0 1 1 h2 a1 1 0 0 0 1 -1 v-6 a1 1 0 0 0 -1 -1 h-2 a1 1 0 0 0 -1 1 v2 a1 1 0 0 0 1 1 h3 M0 0 h24 v24 H0 z";
				case IconKind.SortAZ:
					return "M11 12 h2 M4 13 h4 M4 16 v-6 a2 2 0 1 1 4 0 v6 M16 8 h4 l-4 8 h4 M0 0 h24 v24 H0 z";
				case IconKind.SortAscending2:
					return "M17 6 v12 M5 14 m0 0.5 a0.5 0.5 0 0 1 0.5 -0.5 h4 a0.5 0.5 0 0 1 0.5 0.5 v4 a0.5 0.5 0 0 1 -0.5 0.5 h-4 a0.5 0.5 0 0 1 -0.5 -0.5 z M5 5 m0 0.5 a0.5 0.5 0 0 1 0.5 -0.5 h4 a0.5 0.5 0 0 1 0.5 0.5 v4 a0.5 0.5 0 0 1 -0.5 0.5 h-4 a0.5 0.5 0 0 1 -0.5 -0.5 z M14 9 l3 -3 l3 3 M0 0 h24 v24 H0 z";
				case IconKind.SortAscendingLetters:
					return "M7 6 v12 M4 15 l3 3 l3 -3 M19 21 h-4 l4 -7 h-4 M15 10 v-5 c0 -1.38 0.62 -2 2 -2 s2 0.62 2 2 v5 m0 -3 h-4 M0 0 h24 v24 H0 z";
				case IconKind.SortAscendingNumbers:
					return "M19 16 v3 a2 2 0 0 1 -2 2 h-1.5 M17 16 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M17 3 a2 2 0 0 1 2 2 v3 a2 2 0 1 1 -4 0 v-3 a2 2 0 0 1 2 -2 z M7 6 v12 M4 15 l3 3 l3 -3 M0 0 h24 v24 H0 z";
				case IconKind.SortAscending:
					return "M18 6 l0 12 M15 9 l3 -3 l3 3 M4 18 l9 0 M4 12 l7 0 M4 6 l7 0 M0 0 h24 v24 H0 z";
				case IconKind.SortDescending2:
					return "M17 18 v-12 M14 15 l3 3 l3 -3 M5 14 m0 0.5 a0.5 0.5 0 0 1 0.5 -0.5 h4 a0.5 0.5 0 0 1 0.5 0.5 v4 a0.5 0.5 0 0 1 -0.5 0.5 h-4 a0.5 0.5 0 0 1 -0.5 -0.5 z M5 5 m0 0.5 a0.5 0.5 0 0 1 0.5 -0.5 h4 a0.5 0.5 0 0 1 0.5 0.5 v4 a0.5 0.5 0 0 1 -0.5 0.5 h-4 a0.5 0.5 0 0 1 -0.5 -0.5 z M0 0 h24 v24 H0 z";
				case IconKind.SortDescendingLetters:
					return "M7 6 v12 M4 15 l3 3 l3 -3 M19 10 h-4 l4 -7 h-4 M15 21 v-5 c0 -1.38 0.62 -2 2 -2 s2 0.62 2 2 v5 m0 -3 h-4 M0 0 h24 v24 H0 z";
				case IconKind.SortDescendingNumbers:
					return "M19 5 v3 a2 2 0 0 1 -2 2 h-1.5 M17 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M17 14 a2 2 0 0 1 2 2 v3 a2 2 0 1 1 -4 0 v-3 a2 2 0 0 1 2 -2 z M7 6 v12 M4 15 l3 3 l3 -3 M0 0 h24 v24 H0 z";
				case IconKind.SortDescending:
					return "M18 6 l0 12 M15 15 l3 3 l3 -3 M4 18 l7 0 M4 12 l7 0 M4 6 l9 0 M0 0 h24 v24 H0 z";
				case IconKind.SortZA:
					return "M11 12 h2 M16 13 h4 M16 16 v-6 a2 2 0 1 1 4 0 v6 M4 8 h4 l-4 8 h4 M0 0 h24 v24 H0 z";
				case IconKind.Sos:
					return "M17 16 h3 a1 1 0 0 0 1 -1 v-2 a1 1 0 0 0 -1 -1 h-2 a1 1 0 0 1 -1 -1 v-2 a1 1 0 0 1 1 -1 h3 M10 8 h4 v8 h-4 z M7 8 h-3 a1 1 0 0 0 -1 1 v2 a1 1 0 0 0 1 1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-3 M0 0 h24 v24 H0 z";
				case IconKind.SoupOff:
					return "M3 3 l18 18 M15 5 v3 M12 5 v3 M15 11 h6 c0 1.691 -0.525 3.26 -1.42 4.552 m-2.034 2.032 a7.963 7.963 0 0 1 -4.546 1.416 h-2 a8 8 0 0 1 -8 -8 h8 M3 19 h16 M0 0 h24 v24 H0 z";
				case IconKind.Soup:
					return "M8 4 a2.4 2.4 0 0 0 -1 2 a2.4 2.4 0 0 0 1 2 M16 4 a2.4 2.4 0 0 0 -1 2 a2.4 2.4 0 0 0 1 2 M12 4 a2.4 2.4 0 0 0 -1 2 a2.4 2.4 0 0 0 1 2 M4 11 h16 a1 1 0 0 1 1 1 v0.5 c0 1.5 -2.517 5.573 -4 6.5 v1 a1 1 0 0 1 -1 1 h-8 a1 1 0 0 1 -1 -1 v-1 c-1.687 -1.054 -4 -5 -4 -6.5 v-0.5 a1 1 0 0 1 1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.SourceCode:
					return "M10 9 l2 -2 l-2 -2 M6 5 l-2 2 l2 2 M14.5 4 h2.5 a3 3 0 0 1 3 3 v10 a3 3 0 0 1 -3 3 h-10 a3 3 0 0 1 -3 -3 v-5 M0 0 h24 v24 H0 z";
				case IconKind.SpaceOff:
					return "M3 3 l18 18 M4 10 v3 a1 1 0 0 0 1 1 h9 m4 0 h1 a1 1 0 0 0 1 -1 v-3 M0 0 h24 v24 H0 z";
				case IconKind.Space:
					return "M4 10 v3 a1 1 0 0 0 1 1 h14 a1 1 0 0 0 1 -1 v-3 M0 0 h24 v24 H0 z";
				case IconKind.SpacingHorizontal:
					return "M12 8 v8 M4 20 h2 a2 2 0 0 0 2 -2 v-12 a2 2 0 0 0 -2 -2 h-2 M20 20 h-2 a2 2 0 0 1 -2 -2 v-12 a2 2 0 0 1 2 -2 h2 M0 0 h24 v24 H0 z";
				case IconKind.SpacingVertical:
					return "M16 12 h-8 M4 4 v2 a2 2 0 0 0 2 2 h12 a2 2 0 0 0 2 -2 v-2 M4 20 v-2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v2 M0 0 h24 v24 H0 z";
				case IconKind.SpadeFilled:
					return "M12 3 l4.919 4.5 c0.61 0.587 1.177 1.177 1.703 1.771 a5.527 5.527 0 0 1 0.264 6.979 c-1.18 1.56 -3.338 1.92 -4.886 0.75 v1 l1 3 h-6 l1 -3 v-1 c-1.54 1.07 -3.735 0.772 -4.886 -0.75 a5.527 5.527 0 0 1 0.264 -6.979 a30.883 30.883 0 0 1 1.703 -1.771 a1394.07 1394.07 0 0 1 4.919 -4.5 z M0 0 h24 v24 H0 z";
				case IconKind.Spade:
					return "M12 3 l4.919 4.5 c0.61 0.587 1.177 1.177 1.703 1.771 a5.527 5.527 0 0 1 0.264 6.979 c-1.18 1.56 -3.338 1.92 -4.886 0.75 v1 l1 3 h-6 l1 -3 v-1 c-1.54 1.07 -3.735 0.772 -4.886 -0.75 a5.527 5.527 0 0 1 0.264 -6.979 a30.883 30.883 0 0 1 1.703 -1.771 a1541.72 1541.72 0 0 1 4.919 -4.5 z M0 0 h24 v24 H0 z";
				case IconKind.Sparkles:
					return "M16 18 a2 2 0 0 1 2 2 a2 2 0 0 1 2 -2 a2 2 0 0 1 -2 -2 a2 2 0 0 1 -2 2 z m0 -12 a2 2 0 0 1 2 2 a2 2 0 0 1 2 -2 a2 2 0 0 1 -2 -2 a2 2 0 0 1 -2 2 z m-7 12 a6 6 0 0 1 6 -6 a6 6 0 0 1 -6 -6 a6 6 0 0 1 -6 6 a6 6 0 0 1 6 6 z M0 0 h24 v24 H0 z";
				case IconKind.Speakerphone:
					return "M12 8 h0 l4.524 -3.77 a0.9 0.9 0 0 1 1.476 0.692 v12.156 a0.9 0.9 0 0 1 -1.476 0.692 l-4.524 -3.77 h-8 a1 1 0 0 1 -1 -1 v-4 a1 1 0 0 1 1 -1 h8 M10 8 v11 a1 1 0 0 1 -1 1 h-1 a1 1 0 0 1 -1 -1 v-5 M18 8 a3 3 0 0 1 0 6 M0 0 h24 v24 H0 z";
				case IconKind.Speedboat:
					return "M6 8 h8 l2 3 M6 13 l1.5 -5 M3 17 h13.4 a3 3 0 0 0 2.5 -1.34 l3.1 -4.66 h0 h-6.23 a4 4 0 0 0 -1.49 0.29 l-3.56 1.42 a4 4 0 0 1 -1.49 0.29 h-3.73 h0 h-1 l-1.5 4 z M0 0 h24 v24 H0 z";
				case IconKind.Spider:
					return "M12 9 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M12 15 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M20 19 v-2 l-6 -6 M21.5 9.5 l-1.5 1.5 h-6 M19 4 v2 l-5 5 M4 19 v-2 l6 -6 M2.5 9.5 l1.5 1.5 h6 M5 4 v2 l5 5 M0 0 h24 v24 H0 z";
				case IconKind.SpiralOff:
					return "M3 3 l18 18 M10 12.057 a1.9 1.9 0 0 0 0.614 0.743 c0.682 0.459 1.509 0.374 2.164 -0.02 m1.103 -2.92 a3.298 3.298 0 0 0 -1.749 -2.059 a3.6 3.6 0 0 0 -0.507 -0.195 m-3.385 0.634 a4.154 4.154 0 0 0 -1.347 1.646 c-1.095 2.432 0.29 5.248 2.71 6.246 c1.955 0.806 4.097 0.35 5.65 -0.884 m1.745 -2.268 l0.043 -0.103 c1.36 -3.343 -0.557 -7.134 -3.896 -8.41 c-1.593 -0.61 -3.27 -0.599 -4.79 -0.113 m-2.579 1.408 a7.574 7.574 0 0 0 -2.268 3.128 c-1.63 4.253 0.823 9.024 5.082 10.576 c3.211 1.17 6.676 0.342 9.124 -1.738 m1.869 -2.149 a9.354 9.354 0 0 0 1.417 -4.516 M0 0 h24 v24 H0 z";
				case IconKind.Spiral:
					return "M10 12.057 a1.9 1.9 0 0 0 0.614 0.743 c1.06 0.713 2.472 0.112 3.043 -0.919 c0.839 -1.513 -0.022 -3.368 -1.525 -4.08 c-2 -0.95 -4.371 0.154 -5.24 2.086 c-1.095 2.432 0.29 5.248 2.71 6.246 c2.931 1.208 6.283 -0.418 7.438 -3.255 c1.36 -3.343 -0.557 -7.134 -3.896 -8.41 c-3.855 -1.474 -8.2 0.68 -9.636 4.422 c-1.63 4.253 0.823 9.024 5.082 10.576 c4.778 1.74 10.118 -0.941 11.833 -5.59 a9.354 9.354 0 0 0 0.577 -2.813 M0 0 h24 v24 H0 z";
				case IconKind.SportBillard:
					return "M12 12 m-8 0 a8 8 0 1 0 16 0 a8 8 0 1 0 -16 0 M12 14 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M12 10 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Spray:
					return "M10 7 h1 M21 11 h0.01 M21 7 h0.01 M21 3 h0.01 M18 5 h0.01 M18 9 h0.01 M15 7 h0.01 M6 10 v-4 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v4 M4 10 m0 2 a2 2 0 0 1 2 -2 h4 a2 2 0 0 1 2 2 v7 a2 2 0 0 1 -2 2 h-4 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SpyOff:
					return "M3 3 l18 18 M10 17 h4 M14.88 14.877 a3 3 0 1 0 4.239 4.247 m0.59 -3.414 a3.012 3.012 0 0 0 -1.425 -1.422 M7 17 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M5 11 v-4 c0 -0.571 0.16 -1.105 0.437 -1.56 m2.563 -1.44 h8 a3 3 0 0 1 3 3 v4 M3 11 h8 m4 0 h6 M0 0 h24 v24 H0 z";
				case IconKind.Spy:
					return "M10 17 h4 M17 17 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M7 17 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M5 11 v-4 a3 3 0 0 1 3 -3 h8 a3 3 0 0 1 3 3 v4 M3 11 h18 M0 0 h24 v24 H0 z";
				case IconKind.SquareArrowDown:
					return "M6.667 4 h10.666 a2.667 2.667 0 0 1 2.667 2.667 v10.666 a2.667 2.667 0 0 1 -2.667 2.667 h-10.666 a2.667 2.667 0 0 1 -2.667 -2.667 v-10.666 a2.667 2.667 0 0 1 2.667 -2.667 z M12 8 v8 M8 12 l4 4 l4 -4 M0 0 h24 v24 H0 z";
				case IconKind.SquareArrowLeft:
					return "M20 6.667 v10.666 a2.667 2.667 0 0 1 -2.667 2.667 h-10.666 a2.667 2.667 0 0 1 -2.667 -2.667 v-10.666 a2.667 2.667 0 0 1 2.667 -2.667 h10.666 a2.667 2.667 0 0 1 2.667 2.667 z M16 12 h-8 M12 8 l-4 4 l4 4 M0 0 h24 v24 H0 z";
				case IconKind.SquareArrowRight:
					return "M4 17.333 v-10.666 a2.667 2.667 0 0 1 2.667 -2.667 h10.666 a2.667 2.667 0 0 1 2.667 2.667 v10.666 a2.667 2.667 0 0 1 -2.667 2.667 h-10.666 a2.667 2.667 0 0 1 -2.667 -2.667 z M8 12 h8 M12 16 l4 -4 l-4 -4 M0 0 h24 v24 H0 z";
				case IconKind.SquareArrowUp:
					return "M17.333 20 h-10.666 a2.667 2.667 0 0 1 -2.667 -2.667 v-10.666 a2.667 2.667 0 0 1 2.667 -2.667 h10.666 a2.667 2.667 0 0 1 2.667 2.667 v10.666 a2.667 2.667 0 0 1 -2.667 2.667 z M12 16 v-8 M16 12 l-4 -4 l-4 4 M0 0 h24 v24 H0 z";
				case IconKind.SquareAsterisk:
					return "M9 14 l6 -4 M9 10 l6 4 M12 8.5 v7 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareCheck:
					return "M9 12 l2 2 l4 -4 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareChevronDown:
					return "M20 6.667 v10.666 a2.667 2.667 0 0 1 -2.667 2.667 h-10.666 a2.667 2.667 0 0 1 -2.667 -2.667 v-10.666 a2.667 2.667 0 0 1 2.667 -2.667 h10.666 a2.667 2.667 0 0 1 2.667 2.667 z M15 11 l-3 3 l-3 -3 M0 0 h24 v24 H0 z";
				case IconKind.SquareChevronLeft:
					return "M20 6.667 v10.666 a2.667 2.667 0 0 1 -2.667 2.667 h-10.666 a2.667 2.667 0 0 1 -2.667 -2.667 v-10.666 a2.667 2.667 0 0 1 2.667 -2.667 h10.666 a2.667 2.667 0 0 1 2.667 2.667 z M13 15 l-3 -3 l3 -3 M0 0 h24 v24 H0 z";
				case IconKind.SquareChevronRight:
					return "M20 6.667 v10.666 a2.667 2.667 0 0 1 -2.667 2.667 h-10.666 a2.667 2.667 0 0 1 -2.667 -2.667 v-10.666 a2.667 2.667 0 0 1 2.667 -2.667 h10.666 a2.667 2.667 0 0 1 2.667 2.667 z M11 9 l3 3 l-3 3 M0 0 h24 v24 H0 z";
				case IconKind.SquareChevronUp:
					return "M9 13 l3 -3 l3 3 M20 6.667 v10.666 a2.667 2.667 0 0 1 -2.667 2.667 h-10.666 a2.667 2.667 0 0 1 -2.667 -2.667 v-10.666 a2.667 2.667 0 0 1 2.667 -2.667 h10.666 a2.667 2.667 0 0 1 2.667 2.667 z M0 0 h24 v24 H0 z";
				case IconKind.SquareChevronsDown:
					return "M20 6.667 v10.666 a2.667 2.667 0 0 1 -2.667 2.667 h-10.666 a2.667 2.667 0 0 1 -2.667 -2.667 v-10.666 a2.667 2.667 0 0 1 2.667 -2.667 h10.666 a2.667 2.667 0 0 1 2.667 2.667 z M15 13 l-3 3 l-3 -3 M15 9 l-3 3 l-3 -3 M0 0 h24 v24 H0 z";
				case IconKind.SquareChevronsLeft:
					return "M20 6.667 v10.666 a2.667 2.667 0 0 1 -2.667 2.667 h-10.666 a2.667 2.667 0 0 1 -2.667 -2.667 v-10.666 a2.667 2.667 0 0 1 2.667 -2.667 h10.666 a2.667 2.667 0 0 1 2.667 2.667 z M11 15 l-3 -3 l3 -3 M15 15 l-3 -3 l3 -3 M0 0 h24 v24 H0 z";
				case IconKind.SquareChevronsRight:
					return "M20 6.667 v10.666 a2.667 2.667 0 0 1 -2.667 2.667 h-10.666 a2.667 2.667 0 0 1 -2.667 -2.667 v-10.666 a2.667 2.667 0 0 1 2.667 -2.667 h10.666 a2.667 2.667 0 0 1 2.667 2.667 z M13 9 l3 3 l-3 3 M9 9 l3 3 l-3 3 M0 0 h24 v24 H0 z";
				case IconKind.SquareChevronsUp:
					return "M20 6.667 v10.666 a2.667 2.667 0 0 1 -2.667 2.667 h-10.666 a2.667 2.667 0 0 1 -2.667 -2.667 v-10.666 a2.667 2.667 0 0 1 2.667 -2.667 h10.666 a2.667 2.667 0 0 1 2.667 2.667 z M9 11 l3 -3 l3 3 M9 15 l3 -3 l3 3 M0 0 h24 v24 H0 z";
				case IconKind.SquareDot:
					return "M12 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareF0:
					return "M10 9 h-2 v6 M8 12 h2 M13 10.5 v3 a1.5 1.5 0 0 0 3 0 v-3 a1.5 1.5 0 0 0 -3 0 z M20 6.667 v10.666 a2.667 2.667 0 0 1 -2.667 2.667 h-10.666 a2.667 2.667 0 0 1 -2.667 -2.667 v-10.666 a2.667 2.667 0 0 1 2.667 -2.667 h10.666 a2.667 2.667 0 0 1 2.667 2.667 z M0 0 h24 v24 H0 z";
				case IconKind.SquareF1:
					return "M10 9 h-2 v6 M8 12 h2 M13 11 l2 -2 v6 M20 6.667 v10.666 a2.667 2.667 0 0 1 -2.667 2.667 h-10.666 a2.667 2.667 0 0 1 -2.667 -2.667 v-10.666 a2.667 2.667 0 0 1 2.667 -2.667 h10.666 a2.667 2.667 0 0 1 2.667 2.667 z M0 0 h24 v24 H0 z";
				case IconKind.SquareF2:
					return "M10 9 h-2 v6 M8 12 h2 M13 9 h2 a1 1 0 0 1 1 1 v1 a1 1 0 0 1 -1 1 h-1 a1 1 0 0 0 -1 1 v1 a1 1 0 0 0 1 1 h2 M20 6.667 v10.666 a2.667 2.667 0 0 1 -2.667 2.667 h-10.666 a2.667 2.667 0 0 1 -2.667 -2.667 v-10.666 a2.667 2.667 0 0 1 2.667 -2.667 h10.666 a2.667 2.667 0 0 1 2.667 2.667 z M0 0 h24 v24 H0 z";
				case IconKind.SquareF3:
					return "M10 9 h-2 v6 M8 12 h2 M13 9.5 a0.5 0.5 0 0 1 0.5 -0.5 h1 a1.5 1.5 0 0 1 0 3 h-0.5 h0.5 a1.5 1.5 0 0 1 0 3 h-1 a0.5 0.5 0 0 1 -0.5 -0.5 M20 6.667 v10.666 a2.667 2.667 0 0 1 -2.667 2.667 h-10.666 a2.667 2.667 0 0 1 -2.667 -2.667 v-10.666 a2.667 2.667 0 0 1 2.667 -2.667 h10.666 a2.667 2.667 0 0 1 2.667 2.667 z M0 0 h24 v24 H0 z";
				case IconKind.SquareF4:
					return "M10 9 h-2 v6 M8 12 h2 M16 9 v6 M13 9 v2 a1 1 0 0 0 1 1 h1 M20 6.667 v10.666 a2.667 2.667 0 0 1 -2.667 2.667 h-10.666 a2.667 2.667 0 0 1 -2.667 -2.667 v-10.666 a2.667 2.667 0 0 1 2.667 -2.667 h10.666 a2.667 2.667 0 0 1 2.667 2.667 z M0 0 h24 v24 H0 z";
				case IconKind.SquareF5:
					return "M10 9 h-2 v6 M8 12 h2 M13 14.25 c0 0.414 0.336 0.75 0.75 0.75 h1.25 a1 1 0 0 0 1 -1 v-1 a1 1 0 0 0 -1 -1 h-2 v-3 h3 M20 6.667 v10.666 a2.667 2.667 0 0 1 -2.667 2.667 h-10.666 a2.667 2.667 0 0 1 -2.667 -2.667 v-10.666 a2.667 2.667 0 0 1 2.667 -2.667 h10.666 a2.667 2.667 0 0 1 2.667 2.667 z M0 0 h24 v24 H0 z";
				case IconKind.SquareF6:
					return "M10 9 h-2 v6 M8 12 h2 M16 9.75 a0.75 0.75 0 0 0 -0.75 -0.75 h-1.25 a1 1 0 0 0 -1 1 v4 a1 1 0 0 0 1 1 h1 a1 1 0 0 0 1 -1 v-1 a1 1 0 0 0 -1 -1 h-2 M20 6.667 v10.666 a2.667 2.667 0 0 1 -2.667 2.667 h-10.666 a2.667 2.667 0 0 1 -2.667 -2.667 v-10.666 a2.667 2.667 0 0 1 2.667 -2.667 h10.666 a2.667 2.667 0 0 1 2.667 2.667 z M0 0 h24 v24 H0 z";
				case IconKind.SquareF7:
					return "M10 9 h-2 v6 M8 12 h2 M13 9 h3 l-1.5 6 M20 6.667 v10.666 a2.667 2.667 0 0 1 -2.667 2.667 h-10.666 a2.667 2.667 0 0 1 -2.667 -2.667 v-10.666 a2.667 2.667 0 0 1 2.667 -2.667 h10.666 a2.667 2.667 0 0 1 2.667 2.667 z M0 0 h24 v24 H0 z";
				case IconKind.SquareF8:
					return "M10 9 h-2 v6 M8 12 h2 M14.5 12 h-0.5 a1 1 0 0 1 -1 -1 v-1 a1 1 0 0 1 1 -1 h1 a1 1 0 0 1 1 1 v1 a1 1 0 0 1 -1 1 h-1 a1 1 0 0 0 -1 1 v1 a1 1 0 0 0 1 1 h1 a1 1 0 0 0 1 -1 v-1 a1 1 0 0 0 -1 -1 M20 6.667 v10.666 a2.667 2.667 0 0 1 -2.667 2.667 h-10.666 a2.667 2.667 0 0 1 -2.667 -2.667 v-10.666 a2.667 2.667 0 0 1 2.667 -2.667 h10.666 a2.667 2.667 0 0 1 2.667 2.667 z M0 0 h24 v24 H0 z";
				case IconKind.SquareF9:
					return "M10 9 h-2 v6 M8 12 h2 M13 14.25 c0 0.414 0.336 0.75 0.75 0.75 h1.5 a0.75 0.75 0 0 0 0.75 -0.75 v-4.5 a0.75 0.75 0 0 0 -0.75 -0.75 h-1.5 a0.75 0.75 0 0 0 -0.75 0.75 v1.5 c0 0.414 0.336 0.75 0.75 0.75 h2.25 M20 6.667 v10.666 a2.667 2.667 0 0 1 -2.667 2.667 h-10.666 a2.667 2.667 0 0 1 -2.667 -2.667 v-10.666 a2.667 2.667 0 0 1 2.667 -2.667 h10.666 a2.667 2.667 0 0 1 2.667 2.667 z M0 0 h24 v24 H0 z";
				case IconKind.SquareForbid2:
					return "M9 15 l6 -6 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareForbid:
					return "M9 9 l6 6 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareHalf:
					return "M12 8 l4 -4 M15 20 l5 -5 M12 18 l8 -8 M12 13 l7.5 -7.5 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M12 4 v16 M0 0 h24 v24 H0 z";
				case IconKind.SquareKey:
					return "M20 6.667 v10.666 a2.667 2.667 0 0 1 -2.667 2.667 h-10.666 a2.667 2.667 0 0 1 -2.667 -2.667 v-10.666 a2.667 2.667 0 0 1 2.667 -2.667 h10.666 a2.667 2.667 0 0 1 2.667 2.667 z M12 15 l-1.5 -1.5 M12.5 11.5 l-4 4 l1.5 1.5 M14 10 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.SquareLetterA:
					return "M10 13 h4 M10 16 v-6 a2 2 0 1 1 4 0 v6 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareLetterB:
					return "M10 16 h2 a2 2 0 1 0 0 -4 h-2 h2 a2 2 0 1 0 0 -4 h-2 v8 z M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareLetterC:
					return "M14 10 a2 2 0 1 0 -4 0 v4 a2 2 0 1 0 4 0 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareLetterD:
					return "M10 8 v8 h2 a2 2 0 0 0 2 -2 v-4 a2 2 0 0 0 -2 -2 h-2 z M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareLetterE:
					return "M10 12 h2.5 M14 8 h-4 v8 h4 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareLetterF:
					return "M14 8 h-4 v8 M10 12 h3 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareLetterG:
					return "M14 8 h-2 a2 2 0 0 0 -2 2 v4 a2 2 0 0 0 2 2 h2 v-4 h-1 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareLetterH:
					return "M10 12 h4 M10 16 v-8 m4 0 v8 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareLetterI:
					return "M12 8 v8 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareLetterJ:
					return "M10 8 h4 v6 a2 2 0 1 1 -4 0 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareLetterK:
					return "M10 12 h1.5 M14 8 l-2.5 4 l2.5 4 M10 8 v8 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareLetterL:
					return "M10 8 v8 h4 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareLetterM:
					return "M9 16 v-8 l3 5 l3 -5 v8 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareLetterN:
					return "M10 16 v-8 l4 8 v-8 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareLetterO:
					return "M12 8 a2 2 0 0 1 2 2 v4 a2 2 0 1 1 -4 0 v-4 a2 2 0 0 1 2 -2 z M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareLetterP:
					return "M10 12 h2 a2 2 0 1 0 0 -4 h-2 v8 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareLetterQ:
					return "M13 15 l1 1 M12 8 a2 2 0 0 1 2 2 v4 a2 2 0 1 1 -4 0 v-4 a2 2 0 0 1 2 -2 z M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareLetterR:
					return "M10 12 h2 a2 2 0 1 0 0 -4 h-2 v8 m4 0 l-3 -4 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareLetterS:
					return "M10 15 a1 1 0 0 0 1 1 h2 a1 1 0 0 0 1 -1 v-2 a1 1 0 0 0 -1 -1 h-2 a1 1 0 0 1 -1 -1 v-2 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareLetterT:
					return "M12 8 v8 M10 8 h4 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareLetterU:
					return "M10 8 v6 a2 2 0 1 0 4 0 v-6 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareLetterV:
					return "M10 8 l2 8 l2 -8 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareLetterW:
					return "M9 8 l1 8 l2 -5 l2 5 l1 -8 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareLetterX:
					return "M10 16 l4 -8 M10 8 l4 8 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareLetterY:
					return "M12 16 v-3 M10 8 l2 5 l2 -5 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareLetterZ:
					return "M10 8 h4 l-4 8 h4 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareMinus:
					return "M9 12 l6 0 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareNumber0:
					return "M10 10 v4 a2 2 0 1 0 4 0 v-4 a2 2 0 1 0 -4 0 z M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareNumber1:
					return "M10 10 l2 -2 v8 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareNumber2:
					return "M10 8 h3 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 0 -1 1 v2 a1 1 0 0 0 1 1 h3 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareNumber3:
					return "M10 9 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareNumber4:
					return "M14 8 v8 M10 8 v3 a1 1 0 0 0 1 1 h3 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareNumber5:
					return "M10 15 a1 1 0 0 0 1 1 h2 a1 1 0 0 0 1 -1 v-2 a1 1 0 0 0 -1 -1 h-3 v-4 h4 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareNumber6:
					return "M14 9 a1 1 0 0 0 -1 -1 h-2 a1 1 0 0 0 -1 1 v6 a1 1 0 0 0 1 1 h2 a1 1 0 0 0 1 -1 v-2 a1 1 0 0 0 -1 -1 h-3 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareNumber7:
					return "M10 8 h4 l-2 8 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareNumber8:
					return "M12 12 h-1 a1 1 0 0 1 -1 -1 v-2 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 0 -1 1 v2 a1 1 0 0 0 1 1 h2 a1 1 0 0 0 1 -1 v-2 a1 1 0 0 0 -1 -1 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareNumber9:
					return "M10 15 a1 1 0 0 0 1 1 h2 a1 1 0 0 0 1 -1 v-6 a1 1 0 0 0 -1 -1 h-2 a1 1 0 0 0 -1 1 v2 a1 1 0 0 0 1 1 h3 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareOff:
					return "M3 3 l18 18 M8 4 h10 a2 2 0 0 1 2 2 v10 m-0.584 3.412 a2 2 0 0 1 -1.416 0.588 h-12 a2 2 0 0 1 -2 -2 v-12 c0 -0.552 0.224 -1.052 0.586 -1.414 M0 0 h24 v24 H0 z";
				case IconKind.SquarePlus:
					return "M12 9 l0 6 M9 12 l6 0 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareRoot2:
					return "M3 12 h1 l3 8 l3 -16 h10 M12 19 c1.5 0 3 -2 4 -3.5 s2.5 -3.5 4 -3.5 M13 12 h1 c1 0 1 1 2.016 3.527 c0.984 2.473 0.984 3.473 1.984 3.473 h1 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoot:
					return "M3 12 h2 l4 8 l4 -16 h8 M0 0 h24 v24 H0 z";
				case IconKind.SquareRotatedFilled:
					return "M10.5 20.4 l-6.9 -6.9 c-0.781 -0.781 -0.781 -2.219 0 -3 l6.9 -6.9 c0.781 -0.781 2.219 -0.781 3 0 l6.9 6.9 c0.781 0.781 0.781 2.219 0 3 l-6.9 6.9 c-0.781 0.781 -2.219 0.781 -3 0 z M0 0 h24 v24 H0 z";
				case IconKind.SquareRotatedForbid2:
					return "M9.5 9.5 l5 5 M10.5 20.4 l-6.9 -6.9 c-0.781 -0.781 -0.781 -2.219 0 -3 l6.9 -6.9 c0.781 -0.781 2.219 -0.781 3 0 l6.9 6.9 c0.781 0.781 0.781 2.219 0 3 l-6.9 6.9 c-0.781 0.781 -2.219 0.781 -3 0 z M0 0 h24 v24 H0 z";
				case IconKind.SquareRotatedForbid:
					return "M9.5 14.5 l5 -5 M10.5 20.4 l-6.9 -6.9 c-0.781 -0.781 -0.781 -2.219 0 -3 l6.9 -6.9 c0.781 -0.781 2.219 -0.781 3 0 l6.9 6.9 c0.781 0.781 0.781 2.219 0 3 l-6.9 6.9 c-0.781 0.781 -2.219 0.781 -3 0 z M0 0 h24 v24 H0 z";
				case IconKind.SquareRotatedOff:
					return "M3 3 l18 18 M16.964 16.952 l-3.462 3.461 c-0.782 0.783 -2.222 0.783 -3 0 l-6.911 -6.91 c-0.783 -0.783 -0.783 -2.223 0 -3 l3.455 -3.456 m2 -2 l1.453 -1.452 c0.782 -0.783 2.222 -0.783 3 0 l6.911 6.91 c0.783 0.783 0.783 2.223 0 3 l-1.448 1.45 M0 0 h24 v24 H0 z";
				case IconKind.SquareRotated:
					return "M10.5 20.4 l-6.9 -6.9 c-0.781 -0.781 -0.781 -2.219 0 -3 l6.9 -6.9 c0.781 -0.781 2.219 -0.781 3 0 l6.9 6.9 c0.781 0.781 0.781 2.219 0 3 l-6.9 6.9 c-0.781 0.781 -2.219 0.781 -3 0 z M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedArrowDownFilled:
					return "M12 2 c-0.218 0 -0.432 0.002 -0.642 0.005 l-0.616 0.017 l-0.299 0.013 l-0.579 0.034 l-0.553 0.046 c-4.785 0.464 -6.732 2.411 -7.196 7.196 l-0.046 0.553 l-0.034 0.579 c-0.005 0.098 -0.01 0.198 -0.013 0.299 l-0.017 0.616 l-0.004 0.318 l-0.001 0.324 c0 0.218 0.002 0.432 0.005 0.642 l0.017 0.616 l0.013 0.299 l0.034 0.579 l0.046 0.553 c0.464 4.785 2.411 6.732 7.196 7.196 l0.553 0.046 l0.579 0.034 c0.098 0.005 0.198 0.01 0.299 0.013 l0.616 0.017 l0.642 0.005 l0.642 -0.005 l0.616 -0.017 l0.299 -0.013 l0.579 -0.034 l0.553 -0.046 c4.785 -0.464 6.732 -2.411 7.196 -7.196 l0.046 -0.553 l0.034 -0.579 c0.005 -0.098 0.01 -0.198 0.013 -0.299 l0.017 -0.616 l0.005 -0.642 l-0.005 -0.642 l-0.017 -0.616 l-0.013 -0.299 l-0.034 -0.579 l-0.046 -0.553 c-0.464 -4.785 -2.411 -6.732 -7.196 -7.196 l-0.553 -0.046 l-0.579 -0.034 a28.058 28.058 0 0 0 -0.299 -0.013 l-0.616 -0.017 l-0.318 -0.004 l-0.324 -0.001 z m0 5 a1 1 0 0 1 0.993 0.883 l0.007 0.117 v5.585 l2.293 -2.292 a1 1 0 0 1 1.32 -0.083 l0.094 0.083 a1 1 0 0 1 0.083 1.32 l-0.083 0.094 l-4 4 a1.008 1.008 0 0 1 -0.112 0.097 l-0.11 0.071 l-0.114 0.054 l-0.105 0.035 l-0.149 0.03 l-0.117 0.006 l-0.075 -0.003 l-0.126 -0.017 l-0.111 -0.03 l-0.111 -0.044 l-0.098 -0.052 l-0.092 -0.064 l-0.094 -0.083 l-4 -4 a1 1 0 0 1 1.32 -1.497 l0.094 0.083 l2.293 2.292 v-5.585 a1 1 0 0 1 1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedArrowDown:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M12 8 v8 M8 12 l4 4 l4 -4 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedArrowLeftFilled:
					return "M12 2 l0.324 0.001 l0.318 0.004 l0.616 0.017 l0.299 0.013 l0.579 0.034 l0.553 0.046 c4.785 0.464 6.732 2.411 7.196 7.196 l0.046 0.553 l0.034 0.579 c0.005 0.098 0.01 0.198 0.013 0.299 l0.017 0.616 l0.005 0.642 l-0.005 0.642 l-0.017 0.616 l-0.013 0.299 l-0.034 0.579 l-0.046 0.553 c-0.464 4.785 -2.411 6.732 -7.196 7.196 l-0.553 0.046 l-0.579 0.034 c-0.098 0.005 -0.198 0.01 -0.299 0.013 l-0.616 0.017 l-0.642 0.005 l-0.642 -0.005 l-0.616 -0.017 l-0.299 -0.013 l-0.579 -0.034 l-0.553 -0.046 c-4.785 -0.464 -6.732 -2.411 -7.196 -7.196 l-0.046 -0.553 l-0.034 -0.579 a28.058 28.058 0 0 1 -0.013 -0.299 l-0.017 -0.616 c-0.003 -0.21 -0.005 -0.424 -0.005 -0.642 l0.001 -0.324 l0.004 -0.318 l0.017 -0.616 l0.013 -0.299 l0.034 -0.579 l0.046 -0.553 c0.464 -4.785 2.411 -6.732 7.196 -7.196 l0.553 -0.046 l0.579 -0.034 c0.098 -0.005 0.198 -0.01 0.299 -0.013 l0.616 -0.017 c0.21 -0.003 0.424 -0.005 0.642 -0.005 z m0.707 5.293 a1 1 0 0 0 -1.414 0 l-4 4 a1.037 1.037 0 0 0 -0.2 0.284 l-0.022 0.052 a0.95 0.95 0 0 0 -0.06 0.222 l-0.008 0.067 l-0.002 0.063 v-0.035 v0.073 a1.034 1.034 0 0 0 0.07 0.352 l0.023 0.052 l0.03 0.061 l0.022 0.037 a1.2 1.2 0 0 0 0.05 0.074 l0.024 0.03 l0.073 0.082 l4 4 l0.094 0.083 a1 1 0 0 0 1.32 -0.083 l0.083 -0.094 a1 1 0 0 0 -0.083 -1.32 l-2.292 -2.293 h5.585 l0.117 -0.007 a1 1 0 0 0 -0.117 -1.993 h-5.585 l2.292 -2.293 l0.083 -0.094 a1 1 0 0 0 -0.083 -1.32 z M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedArrowLeft:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M16 12 h-8 M12 8 l-4 4 l4 4 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedArrowRightFilled:
					return "M12 2 c-0.218 0 -0.432 0.002 -0.642 0.005 l-0.616 0.017 l-0.299 0.013 l-0.579 0.034 l-0.553 0.046 c-4.785 0.464 -6.732 2.411 -7.196 7.196 l-0.046 0.553 l-0.034 0.579 c-0.005 0.098 -0.01 0.198 -0.013 0.299 l-0.017 0.616 l-0.004 0.318 l-0.001 0.324 c0 0.218 0.002 0.432 0.005 0.642 l0.017 0.616 l0.013 0.299 l0.034 0.579 l0.046 0.553 c0.464 4.785 2.411 6.732 7.196 7.196 l0.553 0.046 l0.579 0.034 c0.098 0.005 0.198 0.01 0.299 0.013 l0.616 0.017 l0.642 0.005 l0.642 -0.005 l0.616 -0.017 l0.299 -0.013 l0.579 -0.034 l0.553 -0.046 c4.785 -0.464 6.732 -2.411 7.196 -7.196 l0.046 -0.553 l0.034 -0.579 c0.005 -0.098 0.01 -0.198 0.013 -0.299 l0.017 -0.616 l0.005 -0.642 l-0.005 -0.642 l-0.017 -0.616 l-0.013 -0.299 l-0.034 -0.579 l-0.046 -0.553 c-0.464 -4.785 -2.411 -6.732 -7.196 -7.196 l-0.553 -0.046 l-0.579 -0.034 a28.058 28.058 0 0 0 -0.299 -0.013 l-0.616 -0.017 l-0.318 -0.004 l-0.324 -0.001 z m0.613 5.21 l0.094 0.083 l4 4 a0.927 0.927 0 0 1 0.097 0.112 l0.071 0.11 l0.054 0.114 l0.035 0.105 l0.03 0.148 l0.006 0.118 l-0.003 0.075 l-0.017 0.126 l-0.03 0.111 l-0.044 0.111 l-0.052 0.098 l-0.074 0.104 l-0.073 0.082 l-4 4 a1 1 0 0 1 -1.497 -1.32 l0.083 -0.094 l2.292 -2.293 h-5.585 a1 1 0 0 1 -0.117 -1.993 l0.117 -0.007 h5.585 l-2.292 -2.293 a1 1 0 0 1 -0.083 -1.32 l0.083 -0.094 a1 1 0 0 1 1.32 -0.083 z M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedArrowRight:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M8 12 h8 M12 16 l4 -4 l-4 -4 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedArrowUpFilled:
					return "M12 2 c-0.218 0 -0.432 0.002 -0.642 0.005 l-0.616 0.017 l-0.299 0.013 l-0.579 0.034 l-0.553 0.046 c-4.785 0.464 -6.732 2.411 -7.196 7.196 l-0.046 0.553 l-0.034 0.579 c-0.005 0.098 -0.01 0.198 -0.013 0.299 l-0.017 0.616 l-0.004 0.318 l-0.001 0.324 c0 0.218 0.002 0.432 0.005 0.642 l0.017 0.616 l0.013 0.299 l0.034 0.579 l0.046 0.553 c0.464 4.785 2.411 6.732 7.196 7.196 l0.553 0.046 l0.579 0.034 c0.098 0.005 0.198 0.01 0.299 0.013 l0.616 0.017 l0.642 0.005 l0.642 -0.005 l0.616 -0.017 l0.299 -0.013 l0.579 -0.034 l0.553 -0.046 c4.785 -0.464 6.732 -2.411 7.196 -7.196 l0.046 -0.553 l0.034 -0.579 c0.005 -0.098 0.01 -0.198 0.013 -0.299 l0.017 -0.616 l0.005 -0.642 l-0.005 -0.642 l-0.017 -0.616 l-0.013 -0.299 l-0.034 -0.579 l-0.046 -0.553 c-0.464 -4.785 -2.411 -6.732 -7.196 -7.196 l-0.553 -0.046 l-0.579 -0.034 a28.058 28.058 0 0 0 -0.299 -0.013 l-0.616 -0.017 l-0.318 -0.004 l-0.324 -0.001 z m-0.148 5.011 l0.058 -0.007 l0.09 -0.004 l0.075 0.003 l0.126 0.017 l0.111 0.03 l0.111 0.044 l0.098 0.052 l0.104 0.074 l0.082 0.073 l4 4 a1 1 0 0 1 -1.32 1.497 l-0.094 -0.083 l-2.293 -2.292 v5.585 a1 1 0 0 1 -1.993 0.117 l-0.007 -0.117 v-5.585 l-2.293 2.292 a1 1 0 0 1 -1.32 0.083 l-0.094 -0.083 a1 1 0 0 1 -0.083 -1.32 l0.083 -0.094 l4 -4 a0.927 0.927 0 0 1 0.112 -0.097 l0.11 -0.071 l0.114 -0.054 l0.105 -0.035 l0.118 -0.025 z M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedArrowUp:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M12 16 v-8 M16 12 l-4 -4 l-4 4 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedCheckFilled:
					return "M12 2 c-0.218 0 -0.432 0.002 -0.642 0.005 l-0.616 0.017 l-0.299 0.013 l-0.579 0.034 l-0.553 0.046 c-4.785 0.464 -6.732 2.411 -7.196 7.196 l-0.046 0.553 l-0.034 0.579 c-0.005 0.098 -0.01 0.198 -0.013 0.299 l-0.017 0.616 l-0.004 0.318 l-0.001 0.324 c0 0.218 0.002 0.432 0.005 0.642 l0.017 0.616 l0.013 0.299 l0.034 0.579 l0.046 0.553 c0.464 4.785 2.411 6.732 7.196 7.196 l0.553 0.046 l0.579 0.034 c0.098 0.005 0.198 0.01 0.299 0.013 l0.616 0.017 l0.642 0.005 l0.642 -0.005 l0.616 -0.017 l0.299 -0.013 l0.579 -0.034 l0.553 -0.046 c4.785 -0.464 6.732 -2.411 7.196 -7.196 l0.046 -0.553 l0.034 -0.579 c0.005 -0.098 0.01 -0.198 0.013 -0.299 l0.017 -0.616 l0.005 -0.642 l-0.005 -0.642 l-0.017 -0.616 l-0.013 -0.299 l-0.034 -0.579 l-0.046 -0.553 c-0.464 -4.785 -2.411 -6.732 -7.196 -7.196 l-0.553 -0.046 l-0.579 -0.034 a28.058 28.058 0 0 0 -0.299 -0.013 l-0.616 -0.017 l-0.318 -0.004 l-0.324 -0.001 z m2.293 7.293 a1 1 0 0 1 1.497 1.32 l-0.083 0.094 l-4 4 a1 1 0 0 1 -1.32 0.083 l-0.094 -0.083 l-2 -2 a1 1 0 0 1 1.32 -1.497 l0.094 0.083 l1.293 1.292 l3.293 -3.292 z M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedCheck:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M9 12 l2 2 l4 -4 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedChevronDownFilled:
					return "M12 2 c-0.218 0 -0.432 0.002 -0.642 0.005 l-0.616 0.017 l-0.299 0.013 l-0.579 0.034 l-0.553 0.046 c-4.785 0.464 -6.732 2.411 -7.196 7.196 l-0.046 0.553 l-0.034 0.579 c-0.005 0.098 -0.01 0.198 -0.013 0.299 l-0.017 0.616 l-0.004 0.318 l-0.001 0.324 c0 0.218 0.002 0.432 0.005 0.642 l0.017 0.616 l0.013 0.299 l0.034 0.579 l0.046 0.553 c0.464 4.785 2.411 6.732 7.196 7.196 l0.553 0.046 l0.579 0.034 c0.098 0.005 0.198 0.01 0.299 0.013 l0.616 0.017 l0.642 0.005 l0.642 -0.005 l0.616 -0.017 l0.299 -0.013 l0.579 -0.034 l0.553 -0.046 c4.785 -0.464 6.732 -2.411 7.196 -7.196 l0.046 -0.553 l0.034 -0.579 c0.005 -0.098 0.01 -0.198 0.013 -0.299 l0.017 -0.616 l0.005 -0.642 l-0.005 -0.642 l-0.017 -0.616 l-0.013 -0.299 l-0.034 -0.579 l-0.046 -0.553 c-0.464 -4.785 -2.411 -6.732 -7.196 -7.196 l-0.553 -0.046 l-0.579 -0.034 a28.058 28.058 0 0 0 -0.299 -0.013 l-0.616 -0.017 l-0.318 -0.004 l-0.324 -0.001 z m-3.707 8.293 a1 1 0 0 1 1.32 -0.083 l0.094 0.083 l2.293 2.292 l2.293 -2.292 a1 1 0 0 1 1.32 -0.083 l0.094 0.083 a1 1 0 0 1 0.083 1.32 l-0.083 0.094 l-3 3 a1 1 0 0 1 -1.32 0.083 l-0.094 -0.083 l-3 -3 a1 1 0 0 1 0 -1.414 z M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedChevronDown:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M15 11 l-3 3 l-3 -3 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedChevronLeftFilled:
					return "M12 2 l0.324 0.001 l0.318 0.004 l0.616 0.017 l0.299 0.013 l0.579 0.034 l0.553 0.046 c4.785 0.464 6.732 2.411 7.196 7.196 l0.046 0.553 l0.034 0.579 c0.005 0.098 0.01 0.198 0.013 0.299 l0.017 0.616 l0.005 0.642 l-0.005 0.642 l-0.017 0.616 l-0.013 0.299 l-0.034 0.579 l-0.046 0.553 c-0.464 4.785 -2.411 6.732 -7.196 7.196 l-0.553 0.046 l-0.579 0.034 c-0.098 0.005 -0.198 0.01 -0.299 0.013 l-0.616 0.017 l-0.642 0.005 l-0.642 -0.005 l-0.616 -0.017 l-0.299 -0.013 l-0.579 -0.034 l-0.553 -0.046 c-4.785 -0.464 -6.732 -2.411 -7.196 -7.196 l-0.046 -0.553 l-0.034 -0.579 a28.058 28.058 0 0 1 -0.013 -0.299 l-0.017 -0.616 c-0.003 -0.21 -0.005 -0.424 -0.005 -0.642 l0.001 -0.324 l0.004 -0.318 l0.017 -0.616 l0.013 -0.299 l0.034 -0.579 l0.046 -0.553 c0.464 -4.785 2.411 -6.732 7.196 -7.196 l0.553 -0.046 l0.579 -0.034 c0.098 -0.005 0.198 -0.01 0.299 -0.013 l0.616 -0.017 c0.21 -0.003 0.424 -0.005 0.642 -0.005 z m1.707 6.293 a1 1 0 0 0 -1.414 0 l-3 3 l-0.083 0.094 a1 1 0 0 0 0.083 1.32 l3 3 l0.094 0.083 a1 1 0 0 0 1.32 -0.083 l0.083 -0.094 a1 1 0 0 0 -0.083 -1.32 l-2.292 -2.293 l2.292 -2.293 l0.083 -0.094 a1 1 0 0 0 -0.083 -1.32 z M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedChevronLeft:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M13 15 l-3 -3 l3 -3 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedChevronRightFilled:
					return "M12 2 c-0.218 0 -0.432 0.002 -0.642 0.005 l-0.616 0.017 l-0.299 0.013 l-0.579 0.034 l-0.553 0.046 c-4.785 0.464 -6.732 2.411 -7.196 7.196 l-0.046 0.553 l-0.034 0.579 c-0.005 0.098 -0.01 0.198 -0.013 0.299 l-0.017 0.616 l-0.004 0.318 l-0.001 0.324 c0 0.218 0.002 0.432 0.005 0.642 l0.017 0.616 l0.013 0.299 l0.034 0.579 l0.046 0.553 c0.464 4.785 2.411 6.732 7.196 7.196 l0.553 0.046 l0.579 0.034 c0.098 0.005 0.198 0.01 0.299 0.013 l0.616 0.017 l0.642 0.005 l0.642 -0.005 l0.616 -0.017 l0.299 -0.013 l0.579 -0.034 l0.553 -0.046 c4.785 -0.464 6.732 -2.411 7.196 -7.196 l0.046 -0.553 l0.034 -0.579 c0.005 -0.098 0.01 -0.198 0.013 -0.299 l0.017 -0.616 l0.005 -0.642 l-0.005 -0.642 l-0.017 -0.616 l-0.013 -0.299 l-0.034 -0.579 l-0.046 -0.553 c-0.464 -4.785 -2.411 -6.732 -7.196 -7.196 l-0.553 -0.046 l-0.579 -0.034 a28.058 28.058 0 0 0 -0.299 -0.013 l-0.616 -0.017 l-0.318 -0.004 l-0.324 -0.001 z m-1.707 6.293 a1 1 0 0 1 1.32 -0.083 l0.094 0.083 l3 3 a1 1 0 0 1 0.083 1.32 l-0.083 0.094 l-3 3 a1 1 0 0 1 -1.497 -1.32 l0.083 -0.094 l2.292 -2.293 l-2.292 -2.293 a1 1 0 0 1 -0.083 -1.32 l0.083 -0.094 z M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedChevronRight:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M11 9 l3 3 l-3 3 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedChevronUpFilled:
					return "M12 2 c-0.218 0 -0.432 0.002 -0.642 0.005 l-0.616 0.017 l-0.299 0.013 l-0.579 0.034 l-0.553 0.046 c-4.785 0.464 -6.732 2.411 -7.196 7.196 l-0.046 0.553 l-0.034 0.579 c-0.005 0.098 -0.01 0.198 -0.013 0.299 l-0.017 0.616 l-0.004 0.318 l-0.001 0.324 c0 0.218 0.002 0.432 0.005 0.642 l0.017 0.616 l0.013 0.299 l0.034 0.579 l0.046 0.553 c0.464 4.785 2.411 6.732 7.196 7.196 l0.553 0.046 l0.579 0.034 c0.098 0.005 0.198 0.01 0.299 0.013 l0.616 0.017 l0.642 0.005 l0.642 -0.005 l0.616 -0.017 l0.299 -0.013 l0.579 -0.034 l0.553 -0.046 c4.785 -0.464 6.732 -2.411 7.196 -7.196 l0.046 -0.553 l0.034 -0.579 c0.005 -0.098 0.01 -0.198 0.013 -0.299 l0.017 -0.616 l0.005 -0.642 l-0.005 -0.642 l-0.017 -0.616 l-0.013 -0.299 l-0.034 -0.579 l-0.046 -0.553 c-0.464 -4.785 -2.411 -6.732 -7.196 -7.196 l-0.553 -0.046 l-0.579 -0.034 a28.058 28.058 0 0 0 -0.299 -0.013 l-0.616 -0.017 l-0.318 -0.004 l-0.324 -0.001 z m-0.707 7.293 a1 1 0 0 1 1.32 -0.083 l0.094 0.083 l3 3 a1 1 0 0 1 -1.32 1.497 l-0.094 -0.083 l-2.293 -2.292 l-2.293 2.292 a1 1 0 0 1 -1.32 0.083 l-0.094 -0.083 a1 1 0 0 1 -0.083 -1.32 l0.083 -0.094 l3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedChevronUp:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M9 13 l3 -3 l3 3 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedChevronsDownFilled:
					return "M12 2 c-0.218 0 -0.432 0.002 -0.642 0.005 l-0.616 0.017 l-0.299 0.013 l-0.579 0.034 l-0.553 0.046 c-4.785 0.464 -6.732 2.411 -7.196 7.196 l-0.046 0.553 l-0.034 0.579 c-0.005 0.098 -0.01 0.198 -0.013 0.299 l-0.017 0.616 l-0.004 0.318 l-0.001 0.324 c0 0.218 0.002 0.432 0.005 0.642 l0.017 0.616 l0.013 0.299 l0.034 0.579 l0.046 0.553 c0.464 4.785 2.411 6.732 7.196 7.196 l0.553 0.046 l0.579 0.034 c0.098 0.005 0.198 0.01 0.299 0.013 l0.616 0.017 l0.642 0.005 l0.642 -0.005 l0.616 -0.017 l0.299 -0.013 l0.579 -0.034 l0.553 -0.046 c4.785 -0.464 6.732 -2.411 7.196 -7.196 l0.046 -0.553 l0.034 -0.579 c0.005 -0.098 0.01 -0.198 0.013 -0.299 l0.017 -0.616 l0.005 -0.642 l-0.005 -0.642 l-0.017 -0.616 l-0.013 -0.299 l-0.034 -0.579 l-0.046 -0.553 c-0.464 -4.785 -2.411 -6.732 -7.196 -7.196 l-0.553 -0.046 l-0.579 -0.034 a28.058 28.058 0 0 0 -0.299 -0.013 l-0.616 -0.017 l-0.318 -0.004 l-0.324 -0.001 z m-3.707 6.293 a1 1 0 0 1 1.32 -0.083 l0.094 0.083 l2.293 2.292 l2.293 -2.292 a1 1 0 0 1 1.32 -0.083 l0.094 0.083 a1 1 0 0 1 0.083 1.32 l-0.083 0.094 l-3 3 a1 1 0 0 1 -1.32 0.083 l-0.094 -0.083 l-3 -3 a1 1 0 0 1 0 -1.414 z m0 4 a1 1 0 0 1 1.32 -0.083 l0.094 0.083 l2.293 2.292 l2.293 -2.292 a1 1 0 0 1 1.32 -0.083 l0.094 0.083 a1 1 0 0 1 0.083 1.32 l-0.083 0.094 l-3 3 a1 1 0 0 1 -1.32 0.083 l-0.094 -0.083 l-3 -3 a1 1 0 0 1 0 -1.414 z M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedChevronsDown:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M15 13 l-3 3 l-3 -3 M15 9 l-3 3 l-3 -3 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedChevronsLeftFilled:
					return "M12 2 c-0.218 0 -0.432 0.002 -0.642 0.005 l-0.616 0.017 l-0.299 0.013 l-0.579 0.034 l-0.553 0.046 c-4.785 0.464 -6.732 2.411 -7.196 7.196 l-0.046 0.553 l-0.034 0.579 c-0.005 0.098 -0.01 0.198 -0.013 0.299 l-0.017 0.616 l-0.004 0.318 l-0.001 0.324 c0 0.218 0.002 0.432 0.005 0.642 l0.017 0.616 l0.013 0.299 l0.034 0.579 l0.046 0.553 c0.464 4.785 2.411 6.732 7.196 7.196 l0.553 0.046 l0.579 0.034 c0.098 0.005 0.198 0.01 0.299 0.013 l0.616 0.017 l0.642 0.005 l0.642 -0.005 l0.616 -0.017 l0.299 -0.013 l0.579 -0.034 l0.553 -0.046 c4.785 -0.464 6.732 -2.411 7.196 -7.196 l0.046 -0.553 l0.034 -0.579 c0.005 -0.098 0.01 -0.198 0.013 -0.299 l0.017 -0.616 l0.005 -0.642 l-0.005 -0.642 l-0.017 -0.616 l-0.013 -0.299 l-0.034 -0.579 l-0.046 -0.553 c-0.464 -4.785 -2.411 -6.732 -7.196 -7.196 l-0.553 -0.046 l-0.579 -0.034 a28.058 28.058 0 0 0 -0.299 -0.013 l-0.616 -0.017 l-0.318 -0.004 l-0.324 -0.001 z m2.293 6.293 a1 1 0 0 1 1.497 1.32 l-0.083 0.094 l-2.292 2.293 l2.292 2.293 a1 1 0 0 1 0.083 1.32 l-0.083 0.094 a1 1 0 0 1 -1.32 0.083 l-0.094 -0.083 l-3 -3 a1 1 0 0 1 -0.083 -1.32 l0.083 -0.094 l3 -3 z m-4 0 a1 1 0 0 1 1.497 1.32 l-0.083 0.094 l-2.292 2.293 l2.292 2.293 a1 1 0 0 1 0.083 1.32 l-0.083 0.094 a1 1 0 0 1 -1.32 0.083 l-0.094 -0.083 l-3 -3 a1 1 0 0 1 -0.083 -1.32 l0.083 -0.094 l3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedChevronsLeft:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M11 15 l-3 -3 l3 -3 M15 15 l-3 -3 l3 -3 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedChevronsRightFilled:
					return "M12 2 c-0.218 0 -0.432 0.002 -0.642 0.005 l-0.616 0.017 l-0.299 0.013 l-0.579 0.034 l-0.553 0.046 c-4.785 0.464 -6.732 2.411 -7.196 7.196 l-0.046 0.553 l-0.034 0.579 c-0.005 0.098 -0.01 0.198 -0.013 0.299 l-0.017 0.616 l-0.004 0.318 l-0.001 0.324 c0 0.218 0.002 0.432 0.005 0.642 l0.017 0.616 l0.013 0.299 l0.034 0.579 l0.046 0.553 c0.464 4.785 2.411 6.732 7.196 7.196 l0.553 0.046 l0.579 0.034 c0.098 0.005 0.198 0.01 0.299 0.013 l0.616 0.017 l0.642 0.005 l0.642 -0.005 l0.616 -0.017 l0.299 -0.013 l0.579 -0.034 l0.553 -0.046 c4.785 -0.464 6.732 -2.411 7.196 -7.196 l0.046 -0.553 l0.034 -0.579 c0.005 -0.098 0.01 -0.198 0.013 -0.299 l0.017 -0.616 l0.005 -0.642 l-0.005 -0.642 l-0.017 -0.616 l-0.013 -0.299 l-0.034 -0.579 l-0.046 -0.553 c-0.464 -4.785 -2.411 -6.732 -7.196 -7.196 l-0.553 -0.046 l-0.579 -0.034 a28.058 28.058 0 0 0 -0.299 -0.013 l-0.616 -0.017 l-0.318 -0.004 l-0.324 -0.001 z m-3.707 6.293 a1 1 0 0 1 1.32 -0.083 l0.094 0.083 l3 3 a1 1 0 0 1 0.083 1.32 l-0.083 0.094 l-3 3 a1 1 0 0 1 -1.497 -1.32 l0.083 -0.094 l2.292 -2.293 l-2.292 -2.293 a1 1 0 0 1 -0.083 -1.32 l0.083 -0.094 z m4 0 a1 1 0 0 1 1.32 -0.083 l0.094 0.083 l3 3 a1 1 0 0 1 0.083 1.32 l-0.083 0.094 l-3 3 a1 1 0 0 1 -1.497 -1.32 l0.083 -0.094 l2.292 -2.293 l-2.292 -2.293 a1 1 0 0 1 -0.083 -1.32 l0.083 -0.094 z M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedChevronsRight:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M13 9 l3 3 l-3 3 M9 9 l3 3 l-3 3 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedChevronsUpFilled:
					return "M12 2 c-0.218 0 -0.432 0.002 -0.642 0.005 l-0.616 0.017 l-0.299 0.013 l-0.579 0.034 l-0.553 0.046 c-4.785 0.464 -6.732 2.411 -7.196 7.196 l-0.046 0.553 l-0.034 0.579 c-0.005 0.098 -0.01 0.198 -0.013 0.299 l-0.017 0.616 l-0.004 0.318 l-0.001 0.324 c0 0.218 0.002 0.432 0.005 0.642 l0.017 0.616 l0.013 0.299 l0.034 0.579 l0.046 0.553 c0.464 4.785 2.411 6.732 7.196 7.196 l0.553 0.046 l0.579 0.034 c0.098 0.005 0.198 0.01 0.299 0.013 l0.616 0.017 l0.642 0.005 l0.642 -0.005 l0.616 -0.017 l0.299 -0.013 l0.579 -0.034 l0.553 -0.046 c4.785 -0.464 6.732 -2.411 7.196 -7.196 l0.046 -0.553 l0.034 -0.579 c0.005 -0.098 0.01 -0.198 0.013 -0.299 l0.017 -0.616 l0.005 -0.642 l-0.005 -0.642 l-0.017 -0.616 l-0.013 -0.299 l-0.034 -0.579 l-0.046 -0.553 c-0.464 -4.785 -2.411 -6.732 -7.196 -7.196 l-0.553 -0.046 l-0.579 -0.034 a28.058 28.058 0 0 0 -0.299 -0.013 l-0.616 -0.017 l-0.318 -0.004 l-0.324 -0.001 z m-0.707 9.293 a1 1 0 0 1 1.32 -0.083 l0.094 0.083 l3 3 a1 1 0 0 1 -1.32 1.497 l-0.094 -0.083 l-2.293 -2.292 l-2.293 2.292 a1 1 0 0 1 -1.32 0.083 l-0.094 -0.083 a1 1 0 0 1 -0.083 -1.32 l0.083 -0.094 l3 -3 z m0 -4 a1 1 0 0 1 1.32 -0.083 l0.094 0.083 l3 3 a1 1 0 0 1 -1.32 1.497 l-0.094 -0.083 l-2.293 -2.292 l-2.293 2.292 a1 1 0 0 1 -1.32 0.083 l-0.094 -0.083 a1 1 0 0 1 -0.083 -1.32 l0.083 -0.094 l3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedChevronsUp:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M9 11 l3 -3 l3 3 M9 15 l3 -3 l3 3 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedFilled:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedLetterA:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M10 13 h4 M10 16 v-6 a2 2 0 1 1 4 0 v6 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedLetterB:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M10 16 h2 a2 2 0 1 0 0 -4 h-2 h2 a2 2 0 1 0 0 -4 h-2 v8 z M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedLetterC:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M14 10 a2 2 0 1 0 -4 0 v4 a2 2 0 1 0 4 0 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedLetterD:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M10 8 v8 h2 a2 2 0 0 0 2 -2 v-4 a2 2 0 0 0 -2 -2 h-2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedLetterE:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M10 12 h2.5 M14 8 h-4 v8 h4 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedLetterF:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M14 8 h-4 v8 M10 12 h3 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedLetterG:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M14 8 h-2 a2 2 0 0 0 -2 2 v4 a2 2 0 0 0 2 2 h2 v-4 h-1 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedLetterH:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M10 12 h4 M10 16 v-8 m4 0 v8 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedLetterI:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M12 8 v8 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedLetterJ:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M10 8 h4 v6 a2 2 0 1 1 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedLetterK:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M10 12 h1.5 M14 8 l-2.5 4 l2.5 4 M10 8 v8 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedLetterL:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M10 8 v8 h4 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedLetterM:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M9 16 v-8 l3 5 l3 -5 v8 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedLetterN:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M10 16 v-8 l4 8 v-8 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedLetterO:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M12 8 a2 2 0 0 1 2 2 v4 a2 2 0 1 1 -4 0 v-4 a2 2 0 0 1 2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedLetterP:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M10 12 h2 a2 2 0 1 0 0 -4 h-2 v8 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedLetterQ:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M13 15 l1 1 M12 8 a2 2 0 0 1 2 2 v4 a2 2 0 1 1 -4 0 v-4 a2 2 0 0 1 2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedLetterR:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M10 12 h2 a2 2 0 1 0 0 -4 h-2 v8 m4 0 l-3 -4 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedLetterS:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M10 15 a1 1 0 0 0 1 1 h2 a1 1 0 0 0 1 -1 v-2 a1 1 0 0 0 -1 -1 h-2 a1 1 0 0 1 -1 -1 v-2 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedLetterT:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M12 8 v8 M10 8 h4 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedLetterU:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M10 8 v6 a2 2 0 1 0 4 0 v-6 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedLetterV:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M10 8 l2 8 l2 -8 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedLetterW:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M9 8 l1 8 l2 -5 l2 5 l1 -8 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedLetterX:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M10 16 l4 -8 M10 8 l4 8 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedLetterY:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M12 16 v-3 M10 8 l2 5 l2 -5 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedLetterZ:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M10 8 h4 l-4 8 h4 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedMinus:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M9 12 h6 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedNumber0:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M10 10 v4 a2 2 0 1 0 4 0 v-4 a2 2 0 1 0 -4 0 z M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedNumber1:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M10 10 l2 -2 v8 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedNumber2:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M10 8 h3 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 0 -1 1 v2 a1 1 0 0 0 1 1 h3 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedNumber3:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M10 9 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedNumber4:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M14 8 v8 M10 8 v3 a1 1 0 0 0 1 1 h3 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedNumber5:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M10 15 a1 1 0 0 0 1 1 h2 a1 1 0 0 0 1 -1 v-2 a1 1 0 0 0 -1 -1 h-3 v-4 h4 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedNumber6:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M14 9 a1 1 0 0 0 -1 -1 h-2 a1 1 0 0 0 -1 1 v6 a1 1 0 0 0 1 1 h2 a1 1 0 0 0 1 -1 v-2 a1 1 0 0 0 -1 -1 h-3 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedNumber7:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M10 8 h4 l-2 8 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedNumber8:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M12 12 h-1 a1 1 0 0 1 -1 -1 v-2 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 0 -1 1 v2 a1 1 0 0 0 1 1 h2 a1 1 0 0 0 1 -1 v-2 a1 1 0 0 0 -1 -1 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedNumber9:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M10 15 a1 1 0 0 0 1 1 h2 a1 1 0 0 0 1 -1 v-6 a1 1 0 0 0 -1 -1 h-2 a1 1 0 0 0 -1 1 v2 a1 1 0 0 0 1 1 h3 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedPlusFilled:
					return "M12 2 l0.324 0.001 l0.318 0.004 l0.616 0.017 l0.299 0.013 l0.579 0.034 l0.553 0.046 c4.785 0.464 6.732 2.411 7.196 7.196 l0.046 0.553 l0.034 0.579 c0.005 0.098 0.01 0.198 0.013 0.299 l0.017 0.616 l0.005 0.642 l-0.005 0.642 l-0.017 0.616 l-0.013 0.299 l-0.034 0.579 l-0.046 0.553 c-0.464 4.785 -2.411 6.732 -7.196 7.196 l-0.553 0.046 l-0.579 0.034 c-0.098 0.005 -0.198 0.01 -0.299 0.013 l-0.616 0.017 l-0.642 0.005 l-0.642 -0.005 l-0.616 -0.017 l-0.299 -0.013 l-0.579 -0.034 l-0.553 -0.046 c-4.785 -0.464 -6.732 -2.411 -7.196 -7.196 l-0.046 -0.553 l-0.034 -0.579 a28.058 28.058 0 0 1 -0.013 -0.299 l-0.017 -0.616 c-0.003 -0.21 -0.005 -0.424 -0.005 -0.642 l0.001 -0.324 l0.004 -0.318 l0.017 -0.616 l0.013 -0.299 l0.034 -0.579 l0.046 -0.553 c0.464 -4.785 2.411 -6.732 7.196 -7.196 l0.553 -0.046 l0.579 -0.034 c0.098 -0.005 0.198 -0.01 0.299 -0.013 l0.616 -0.017 c0.21 -0.003 0.424 -0.005 0.642 -0.005 z m0 6 a1 1 0 0 0 -1 1 v2 h-2 l-0.117 0.007 a1 1 0 0 0 0.117 1.993 h2 v2 l0.007 0.117 a1 1 0 0 0 1.993 -0.117 v-2 h2 l0.117 -0.007 a1 1 0 0 0 -0.117 -1.993 h-2 v-2 l-0.007 -0.117 a1 1 0 0 0 -0.993 -0.883 z M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedPlus:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M12 9 v6 M9 12 h6 M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedXFilled:
					return "M12 2 l0.324 0.001 l0.318 0.004 l0.616 0.017 l0.299 0.013 l0.579 0.034 l0.553 0.046 c4.785 0.464 6.732 2.411 7.196 7.196 l0.046 0.553 l0.034 0.579 c0.005 0.098 0.01 0.198 0.013 0.299 l0.017 0.616 l0.005 0.642 l-0.005 0.642 l-0.017 0.616 l-0.013 0.299 l-0.034 0.579 l-0.046 0.553 c-0.464 4.785 -2.411 6.732 -7.196 7.196 l-0.553 0.046 l-0.579 0.034 c-0.098 0.005 -0.198 0.01 -0.299 0.013 l-0.616 0.017 l-0.642 0.005 l-0.642 -0.005 l-0.616 -0.017 l-0.299 -0.013 l-0.579 -0.034 l-0.553 -0.046 c-4.785 -0.464 -6.732 -2.411 -7.196 -7.196 l-0.046 -0.553 l-0.034 -0.579 a28.058 28.058 0 0 1 -0.013 -0.299 l-0.017 -0.616 c-0.003 -0.21 -0.005 -0.424 -0.005 -0.642 l0.001 -0.324 l0.004 -0.318 l0.017 -0.616 l0.013 -0.299 l0.034 -0.579 l0.046 -0.553 c0.464 -4.785 2.411 -6.732 7.196 -7.196 l0.553 -0.046 l0.579 -0.034 c0.098 -0.005 0.198 -0.01 0.299 -0.013 l0.616 -0.017 c0.21 -0.003 0.424 -0.005 0.642 -0.005 z m-1.489 7.14 a1 1 0 0 0 -1.218 1.567 l1.292 1.293 l-1.292 1.293 l-0.083 0.094 a1 1 0 0 0 1.497 1.32 l1.293 -1.292 l1.293 1.292 l0.094 0.083 a1 1 0 0 0 1.32 -1.497 l-1.292 -1.293 l1.292 -1.293 l0.083 -0.094 a1 1 0 0 0 -1.497 -1.32 l-1.293 1.292 l-1.293 -1.292 l-0.094 -0.083 z M0 0 h24 v24 H0 z";
				case IconKind.SquareRoundedX:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M10 10 l4 4 m0 -4 l-4 4 M0 0 h24 v24 H0 z";
				case IconKind.SquareRounded:
					return "M12 3 c7.2 0 9 1.8 9 9 s-1.8 9 -9 9 s-9 -1.8 -9 -9 s1.8 -9 9 -9 z M0 0 h24 v24 H0 z";
				case IconKind.SquareToggleHorizontal:
					return "M14 20 l-4 0 M4 18 a2 2 0 0 0 2 2 M18 20 a2 2 0 0 0 2 -2 M4 14 v-8 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v8 M22 12 h-20 M0 0 h24 v24 H0 z";
				case IconKind.SquareToggle:
					return "M20 10 l0 4 M18 20 a2 2 0 0 0 2 -2 M20 6 a2 2 0 0 0 -2 -2 M14 20 h-8 a2 2 0 0 1 -2 -2 v-12 a2 2 0 0 1 2 -2 h8 M12 2 l0 20 M0 0 h24 v24 H0 z";
				case IconKind.SquareX:
					return "M10 10 l4 4 m0 -4 l-4 4 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Square:
					return "M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquaresDiagonal:
					return "M8.586 19.414 l10.827 -10.827 M16 8 v-2 a2 2 0 0 0 -2 -2 h-8 a2 2 0 0 0 -2 2 v8 a2 2 0 0 0 2 2 h2 M8 8 m0 2 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.SquaresFilled:
					return "M16 8 v-2 a2 2 0 0 0 -2 -2 h-8 a2 2 0 0 0 -2 2 v8 a2 2 0 0 0 2 2 h2 M8.586 19.414 l10.827 -10.827 M13.496 20 l6.504 -6.504 l-6.504 6.504 z M8 14.5 l6.492 -6.492 M8 8 m0 2 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Stack2:
					return "M4 16 l8 4 l8 -4 M4 12 l8 4 l8 -4 M12 4 l-8 4 l8 4 l8 -4 l-8 -4 M0 0 h24 v24 H0 z";
				case IconKind.Stack3:
					return "M4 14 l8 4 l8 -4 M4 18 l8 4 l8 -4 M4 10 l8 4 l8 -4 M12 2 l-8 4 l8 4 l8 -4 l-8 -4 M0 0 h24 v24 H0 z";
				case IconKind.StackPop:
					return "M9 7 l3 -3 l3 3 M12 11 v-7 M4 15 l8 4 l8 -4 M7 9.5 l-3 1.5 l8 4 l8 -4 l-3 -1.5 M0 0 h24 v24 H0 z";
				case IconKind.StackPush:
					return "M15 8 l-3 3 l-3 -3 M12 4 v7 M4 15 l8 4 l8 -4 M6 10 l-2 1 l8 4 l8 -4 l-2 -1 M0 0 h24 v24 H0 z";
				case IconKind.Stack:
					return "M4 14 l8 4 l8 -4 M12 6 l-8 4 l8 4 l8 -4 l-8 -4 M0 0 h24 v24 H0 z";
				case IconKind.StairsDown:
					return "M11 4 l-7 7 v-4 m4 4 h-4 M4 20 h4 v-4 h4 v-4 h4 v-4 h4 M0 0 h24 v24 H0 z";
				case IconKind.StairsUp:
					return "M4 11 l7 -7 v4 m-4 -4 h4 M4 20 h4 v-4 h4 v-4 h4 v-4 h4 M0 0 h24 v24 H0 z";
				case IconKind.Stairs:
					return "M4 18 h4 v-4 h4 v-4 h4 v-4 h4 M0 0 h24 v24 H0 z";
				case IconKind.StarFilled:
					return "M12 17.75 l-6.172 3.245 l1.179 -6.873 l-5 -4.867 l6.9 -1 l3.086 -6.253 l3.086 6.253 l6.9 1 l-5 4.867 l1.179 6.873 z M0 0 h24 v24 H0 z";
				case IconKind.StarHalfFilled:
					return "M12 17.75 l-6.172 3.245 l1.179 -6.873 l-5 -4.867 l6.9 -1 l3.086 -6.253 z M0 0 h24 v24 H0 z";
				case IconKind.StarHalf:
					return "M12 17.75 l-6.172 3.245 l1.179 -6.873 l-5 -4.867 l6.9 -1 l3.086 -6.253 z M0 0 h24 v24 H0 z";
				case IconKind.StarOff:
					return "M10.012 6.016 l1.981 -4.014 l3.086 6.253 l6.9 1 l-4.421 4.304 m0.012 4.01 l0.588 3.426 l-6.158 -3.245 l-6.172 3.245 l1.179 -6.873 l-5 -4.867 l6.327 -0.917 M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.Star:
					return "M12 17.75 l-6.172 3.245 l1.179 -6.873 l-5 -4.867 l6.9 -1 l3.086 -6.253 l3.086 6.253 l6.9 1 l-5 4.867 l1.179 6.873 z M0 0 h24 v24 H0 z";
				case IconKind.StarsFilled:
					return "M12 9.817 l-2.172 1.138 a0.392 0.392 0 0 1 -0.568 -0.41 l0.415 -2.411 l-1.757 -1.707 a0.389 0.389 0 0 1 0.217 -0.665 l2.428 -0.352 l1.086 -2.193 a0.392 0.392 0 0 1 0.702 0 l1.086 2.193 l2.428 0.352 a0.39 0.39 0 0 1 0.217 0.665 l-1.757 1.707 l0.414 2.41 a0.39 0.39 0 0 1 -0.567 0.411 l-2.172 -1.138 z M6.2 19.817 l-2.172 1.138 a0.392 0.392 0 0 1 -0.568 -0.41 l0.415 -2.411 l-1.757 -1.707 a0.389 0.389 0 0 1 0.217 -0.665 l2.428 -0.352 l1.086 -2.193 a0.392 0.392 0 0 1 0.702 0 l1.086 2.193 l2.428 0.352 a0.39 0.39 0 0 1 0.217 0.665 l-1.757 1.707 l0.414 2.41 a0.39 0.39 0 0 1 -0.567 0.411 l-2.172 -1.138 z M17.8 19.817 l-2.172 1.138 a0.392 0.392 0 0 1 -0.568 -0.41 l0.415 -2.411 l-1.757 -1.707 a0.389 0.389 0 0 1 0.217 -0.665 l2.428 -0.352 l1.086 -2.193 a0.392 0.392 0 0 1 0.702 0 l1.086 2.193 l2.428 0.352 a0.39 0.39 0 0 1 0.217 0.665 l-1.757 1.707 l0.414 2.41 a0.39 0.39 0 0 1 -0.567 0.411 l-2.172 -1.138 z M0 0 h24 v24 H0 z";
				case IconKind.StarsOff:
					return "M3 3 l18 18 M9.557 5.556 l1 -0.146 l1.086 -2.193 a0.392 0.392 0 0 1 0.702 0 l1.086 2.193 l2.428 0.352 a0.39 0.39 0 0 1 0.217 0.665 l-1.757 1.707 l0.414 2.41 a0.39 0.39 0 0 1 -0.014 0.187 m-4.153 -0.166 l-0.744 0.39 a0.392 0.392 0 0 1 -0.568 -0.41 l0.188 -1.093 M6.2 19.817 l-2.172 1.138 a0.392 0.392 0 0 1 -0.568 -0.41 l0.415 -2.411 l-1.757 -1.707 a0.389 0.389 0 0 1 0.217 -0.665 l2.428 -0.352 l1.086 -2.193 a0.392 0.392 0 0 1 0.702 0 l1.086 2.193 l2.428 0.352 a0.39 0.39 0 0 1 0.217 0.665 l-1.757 1.707 l0.414 2.41 a0.39 0.39 0 0 1 -0.567 0.411 l-2.172 -1.138 z M17.373 13.371 l0.076 -0.154 a0.392 0.392 0 0 1 0.702 0 l0.907 1.831 m0.367 0.39 c0.498 0.071 1.245 0.18 2.24 0.324 a0.39 0.39 0 0 1 0.217 0.665 c-0.326 0.316 -0.57 0.553 -0.732 0.712 m-0.611 3.405 a0.39 0.39 0 0 1 -0.567 0.411 l-2.172 -1.138 l-2.172 1.138 a0.392 0.392 0 0 1 -0.568 -0.41 l0.415 -2.411 l-1.757 -1.707 a0.389 0.389 0 0 1 0.217 -0.665 l1.601 -0.232 M0 0 h24 v24 H0 z";
				case IconKind.Stars:
					return "M12 9.817 l-2.172 1.138 a0.392 0.392 0 0 1 -0.568 -0.41 l0.415 -2.411 l-1.757 -1.707 a0.389 0.389 0 0 1 0.217 -0.665 l2.428 -0.352 l1.086 -2.193 a0.392 0.392 0 0 1 0.702 0 l1.086 2.193 l2.428 0.352 a0.39 0.39 0 0 1 0.217 0.665 l-1.757 1.707 l0.414 2.41 a0.39 0.39 0 0 1 -0.567 0.411 l-2.172 -1.138 z M6.2 19.817 l-2.172 1.138 a0.392 0.392 0 0 1 -0.568 -0.41 l0.415 -2.411 l-1.757 -1.707 a0.389 0.389 0 0 1 0.217 -0.665 l2.428 -0.352 l1.086 -2.193 a0.392 0.392 0 0 1 0.702 0 l1.086 2.193 l2.428 0.352 a0.39 0.39 0 0 1 0.217 0.665 l-1.757 1.707 l0.414 2.41 a0.39 0.39 0 0 1 -0.567 0.411 l-2.172 -1.138 z M17.8 19.817 l-2.172 1.138 a0.392 0.392 0 0 1 -0.568 -0.41 l0.415 -2.411 l-1.757 -1.707 a0.389 0.389 0 0 1 0.217 -0.665 l2.428 -0.352 l1.086 -2.193 a0.392 0.392 0 0 1 0.702 0 l1.086 2.193 l2.428 0.352 a0.39 0.39 0 0 1 0.217 0.665 l-1.757 1.707 l0.414 2.41 a0.39 0.39 0 0 1 -0.567 0.411 l-2.172 -1.138 z M0 0 h24 v24 H0 z";
				case IconKind.StatusChange:
					return "M15 9 l3 3 l3 -3 M6 12 v-2 a6 6 0 1 1 12 0 v2 M18 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Steam:
					return "M8.5 15.5 l-3 3 M18.5 5.5 l-3 3 M15.5 15.5 l3 3 M5.5 5.5 l3 3 M12 20 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M20 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M4 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12 4 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.SteeringWheelOff:
					return "M3 3 l18 18 M15.542 11.543 l5.208 -1.543 M10 12 l-6.75 -2 M12 14 v7 M10.595 10.576 a2 2 0 1 0 2.827 2.83 M20.04 16.048 a9 9 0 0 0 -12.083 -12.09 m-2.32 1.678 a9 9 0 1 0 12.737 12.719 M0 0 h24 v24 H0 z";
				case IconKind.SteeringWheel:
					return "M14 12 l6.75 -2 M10 12 l-6.75 -2 M12 14 l0 7 M12 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.StepInto:
					return "M12 20 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M8 11 l4 4 M16 11 l-4 4 M12 3 l0 12 M0 0 h24 v24 H0 z";
				case IconKind.StepOut:
					return "M12 20 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M8 7 l4 -4 M16 7 l-4 -4 M12 3 l0 12 M0 0 h24 v24 H0 z";
				case IconKind.StereoGlasses:
					return "M16 16 h1 M7 16 h1 M3 12 v7 a1 1 0 0 0 1 1 h4.586 a1 1 0 0 0 0.707 -0.293 l2 -2 a1 1 0 0 1 1.414 0 l2 2 a1 1 0 0 0 0.707 0.293 h4.586 a1 1 0 0 0 1 -1 v-7 h-18 z M16 3 h2 l3 9 M8 3 h-2 l-3 9 M0 0 h24 v24 H0 z";
				case IconKind.StethoscopeOff:
					return "M3 3 l18 18 M20 10 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M11 3 v2 M8 15 a6 6 0 0 0 10.714 3.712 m1.216 -2.798 c0.046 -0.3 0.07 -0.605 0.07 -0.914 v-3 M4.172 4.179 a2 2 0 0 0 -1.172 1.821 v3.5 a5.5 5.5 0 0 0 9.856 3.358 m1.144 -2.858 v-4 a2 2 0 0 0 -2 -2 h-1 M0 0 h24 v24 H0 z";
				case IconKind.Stethoscope:
					return "M20 10 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M6 3 v2 M11 3 v2 M8 15 a6 6 0 1 0 12 0 v-3 M6 4 h-1 a2 2 0 0 0 -2 2 v3.5 h0 a5.5 5.5 0 0 0 11 0 v-3.5 a2 2 0 0 0 -2 -2 h-1 M0 0 h24 v24 H0 z";
				case IconKind.Sticker:
					return "M20 12 a8 8 0 1 1 -8 -8 M20 12 l-2 0.5 a6 6 0 0 1 -6.5 -6.5 l0.5 -2 l8 8 M0 0 h24 v24 H0 z";
				case IconKind.StormOff:
					return "M3 3 l18 18 M18.63 9.76 a14.323 14.323 0 0 1 1.368 6.251 m-0.37 3.608 c-0.087 0.46 -0.187 0.92 -0.295 1.377 M5.369 14.236 c-1.605 -3.428 -1.597 -6.673 -1 -9.849 M7.037 7.063 a7 7 0 0 0 9.907 9.892 m1.585 -2.426 a7 7 0 0 0 -9.058 -9.059 M9.884 9.874 a3 3 0 1 0 4.24 4.246 m0.57 -3.441 a3.012 3.012 0 0 0 -1.41 -1.39 M0 0 h24 v24 H0 z";
				case IconKind.Storm:
					return "M18.63 9.76 c1.837 3.928 1.561 7.615 0.703 11.236 M5.369 14.236 c-1.839 -3.929 -1.561 -7.616 -0.704 -11.236 M12 12 m-7 0 a7 7 0 1 0 14 0 a7 7 0 1 0 -14 0 M12 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.Stretching:
					return "M18 20 v-5 h-5.5 l2.5 -6.5 l-5.5 1 l1.5 2 M5 20 l5 -0.5 l1 -2 M16 5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.Strikethrough:
					return "M16 6.5 a4 2 0 0 0 -4 -1.5 h-1 a3.5 3.5 0 0 0 0 7 h2 a3.5 3.5 0 0 1 0 7 h-1.5 a4 2 0 0 1 -4 -1.5 M5 12 l14 0 M0 0 h24 v24 H0 z";
				case IconKind.Submarine:
					return "M13 8 v-2 a1 1 0 0 1 1 -1 h1 M17 11 l-1 -3 h-5 l-1 3 M3 11 v6 h2 l1 -1.5 l3 1.5 h10 a3 3 0 0 0 0 -6 h-10 h0 l-3 1.5 l-1 -1.5 h-2 z M0 0 h24 v24 H0 z";
				case IconKind.Subscript:
					return "M21 20 h-4 l3.5 -4 a1.73 1.73 0 0 0 -3.5 -2 M5 7 l8 10 m-8 0 l8 -10 M0 0 h24 v24 H0 z";
				case IconKind.Subtask:
					return "M12 15 m0 1 a1 1 0 0 1 1 -1 h6 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-6 a1 1 0 0 1 -1 -1 z M12 7 m0 1 a1 1 0 0 1 1 -1 h6 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-6 a1 1 0 0 1 -1 -1 z M6 5 v11 a1 1 0 0 0 1 1 h5 M4 5 l4 0 M6 9 l6 0 M0 0 h24 v24 H0 z";
				case IconKind.SumOff:
					return "M3 3 l18 18 M18 18 a1 1 0 0 1 -1 1 h-11 l6 -7 m-3 -7 h8 a1 1 0 0 1 1 1 v2 M0 0 h24 v24 H0 z";
				case IconKind.Sum:
					return "M18 16 v2 a1 1 0 0 1 -1 1 h-11 l6 -7 l-6 -7 h11 a1 1 0 0 1 1 1 v2 M0 0 h24 v24 H0 z";
				case IconKind.SunFilled:
					return "M12 12 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M3 12 h1 m8 -9 v1 m8 8 h1 m-9 8 v1 m-6.4 -15.4 l0.7 0.7 m12.1 -0.7 l-0.7 0.7 m0 11.4 l0.7 0.7 m-12.1 -0.7 l-0.7 0.7 M0 0 h24 v24 H0 z";
				case IconKind.SunHigh:
					return "M12 20 v2 M20 12 h2 M12 4 v-2 M4 12 h-2 M17.657 17.657 l1.414 1.414 M17.657 6.343 l1.414 -1.414 M6.343 6.343 l-1.414 -1.414 M6.343 17.657 l-1.414 1.414 M14.828 14.828 a4 4 0 1 0 -5.656 -5.656 a4 4 0 0 0 5.656 5.656 z M0 0 h24 v24 H0 z";
				case IconKind.SunLow:
					return "M6.3 17.7 l0.01 0.01 M17.7 17.7 l0.01 0.01 M17.71 6.31 l-0.01 -0.01 M6.31 6.31 l-0.01 -0.01 M12 20 v0.01 M20 12 h0.01 M12 4 v0.01 M4 12 h0.01 M12 12 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M0 0 h24 v24 H0 z";
				case IconKind.SunMoon:
					return "M3 21 l18 -18 M5.6 5.6 l0.7 0.7 M12 3 v1 M3 12 h1 M11.294 12.707 l0.174 0.247 a7.5 7.5 0 0 0 8.845 2.492 a9 9 0 0 1 -14.671 2.914 M9.173 14.83 a4 4 0 1 1 5.657 -5.657 M0 0 h24 v24 H0 z";
				case IconKind.SunOff:
					return "M3 12 h1 m8 -9 v1 m8 8 h1 m-9 8 v1 m-6.4 -15.4 l0.7 0.7 m12.1 -0.7 l-0.7 0.7 m0 11.4 l0.7 0.7 m-12.1 -0.7 l-0.7 0.7 M16 12 a4 4 0 0 0 -4 -4 m-2.834 1.177 a4 4 0 0 0 5.66 5.654 M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.SunWind:
					return "M12 16 h5.714 l0.253 0 a2 2 0 0 1 2.033 2 a2 2 0 0 1 -2 2 h-0.286 M15 13 h5 a2 2 0 1 0 0 -4 M5.3 17.7 l-0.7 0.7 M17.4 5.6 l-0.7 0.7 M4.6 5.6 l0.7 0.7 M11 20 v1 M11 3 v1 M2 12 h1 M14.468 10 a4 4 0 1 0 -5.466 5.46 M0 0 h24 v24 H0 z";
				case IconKind.Sun:
					return "M3 12 h1 m8 -9 v1 m8 8 h1 m-9 8 v1 m-6.4 -15.4 l0.7 0.7 m12.1 -0.7 l-0.7 0.7 m0 11.4 l0.7 0.7 m-12.1 -0.7 l-0.7 0.7 M12 12 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M0 0 h24 v24 H0 z";
				case IconKind.Sunglasses:
					return "M15 14 l4.5 4.5 M4 14 l4.5 4.5 M10 16.5 a3.5 3.5 0 0 1 -7 0 v-2.5 h7 v2.5 M21 16.5 a3.5 3.5 0 0 1 -7 0 v-2.5 h7 v2.5 M10 16 h4 M16 4 h2 l3 10 M8 4 h-2 l-3 10 M0 0 h24 v24 H0 z";
				case IconKind.Sunrise:
					return "M12 9 v-6 l3 3 m-6 0 l3 -3 M3 21 l18 0 M3 17 h1 m16 0 h1 m-15.4 -6.4 l0.7 0.7 m12.1 -0.7 l-0.7 0.7 m-9.7 5.7 a4 4 0 0 1 8 0 M0 0 h24 v24 H0 z";
				case IconKind.Sunset2:
					return "M12 5 v-1 M16 20 h1 M7 20 h5 M3 17 h18 M8 13 a4 4 0 1 1 8 0 M18.4 6.6 l-0.7 0.7 M5.6 6.6 l0.7 0.7 M20 13 h1 M3 13 h1 M0 0 h24 v24 H0 z";
				case IconKind.Sunset:
					return "M12 3 v6 l3 -3 m-6 0 l3 3 M3 21 l18 0 M3 17 h1 m16 0 h1 m-15.4 -6.4 l0.7 0.7 m12.1 -0.7 l-0.7 0.7 m-9.7 5.7 a4 4 0 0 1 8 0 M0 0 h24 v24 H0 z";
				case IconKind.Superscript:
					return "M21 11 h-4 l3.5 -4 a1.73 1.73 0 0 0 -3.5 -2 M5 7 l8 10 m-8 0 l8 -10 M0 0 h24 v24 H0 z";
				case IconKind.Svg:
					return "M10 8 l1.5 8 h1 l1.5 -8 M7 8 h-3 a1 1 0 0 0 -1 1 v2 a1 1 0 0 0 1 1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-3 M21 8 h-2 a2 2 0 0 0 -2 2 v4 a2 2 0 0 0 2 2 h2 v-4 h-1 M0 0 h24 v24 H0 z";
				case IconKind.Swimming:
					return "M3 16.75 a2.4 2.4 0 0 0 1 0.25 a2.4 2.4 0 0 0 2 -1 a2.4 2.4 0 0 1 2 -1 a2.4 2.4 0 0 1 2 1 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 2 -1 a2.4 2.4 0 0 1 2 -1 a2.4 2.4 0 0 1 2 1 a2.4 2.4 0 0 0 2 1 a2.4 2.4 0 0 0 1 -0.25 M6 11 l4 -2 l3.5 3 l-1.5 2 M16 9 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.Swipe:
					return "M9.167 4.511 a2.04 2.04 0 0 1 2.496 -1.441 l7.826 2.097 a2.04 2.04 0 0 1 1.441 2.496 l-2.097 7.826 a2.04 2.04 0 0 1 -2.496 1.441 l-7.827 -2.097 a2.04 2.04 0 0 1 -1.441 -2.496 l2.098 -7.827 z M15 16.572 v2.42 a2.01 2.01 0 0 1 -2.009 2.008 h-7.981 a2.01 2.01 0 0 1 -2.01 -2.009 v-7.981 a2.01 2.01 0 0 1 2.009 -2.01 h2.954 M0 0 h24 v24 H0 z";
				case IconKind.Switch2:
					return "M18 20 l3 -3 l-3 -3 M3 7 h5 l7 10 h6 M18 4 l3 3 l-3 3 M3 17 h5 l1.67 -2.386 m3.66 -5.227 l1.67 -2.387 h6 M0 0 h24 v24 H0 z";
				case IconKind.Switch3:
					return "M18 20 l3 -3 l-3 -3 M3 7 h2.397 a5 5 0 0 1 4.096 2.133 l4.014 5.734 a5 5 0 0 0 4.096 2.133 h3.397 M18 4 l3 3 l-3 3 M3 17 h2.397 a5 5 0 0 0 4.096 -2.133 l0.177 -0.253 m3.66 -5.227 l0.177 -0.254 a5 5 0 0 1 4.096 -2.133 h3.397 M0 0 h24 v24 H0 z";
				case IconKind.SwitchHorizontal:
					return "M4 17 l9 0 M8 13 l-4 4 l4 4 M10 7 l10 0 M16 3 l4 4 l-4 4 M0 0 h24 v24 H0 z";
				case IconKind.SwitchVertical:
					return "M17 10 l0 10 M13 16 l4 4 l4 -4 M7 4 l0 9 M3 8 l4 -4 l4 4 M0 0 h24 v24 H0 z";
				case IconKind.Switch:
					return "M5 5 l14 14 M15 19 l4 0 l0 -4 M5 19 l4 -4 M14.75 9.25 l4.25 -5.25 M15 4 l4 0 l0 4 M0 0 h24 v24 H0 z";
				case IconKind.SwordOff:
					return "M3 3 l18 18 M6.5 11.5 l6 6 M11.938 7.937 l3.062 -3.937 h5 v5 l-3.928 3.055 m-2.259 1.757 l-2.813 2.188 l-4 4 l-3 -3 l4 -4 l2.19 -2.815 M0 0 h24 v24 H0 z";
				case IconKind.Sword:
					return "M6.5 11.5 l6 6 M20 4 v5 l-9 7 l-4 4 l-3 -3 l4 -4 l7 -9 z M0 0 h24 v24 H0 z";
				case IconKind.Swords:
					return "M10 5.5 l-2 -2.5 h-5 v5 l3 2.5 M14.32 17.32 l3.68 3.68 l3 -3 l-3.365 -3.365 M5 13 l6 6 M21 3 v5 l-11 9 l-4 4 l-3 -3 l4 -4 l9 -11 z M0 0 h24 v24 H0 z";
				case IconKind.TableAlias:
					return "M10 4 v8 M4 10 h16 M3 15 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M4 12 v-6 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-6 M0 0 h24 v24 H0 z";
				case IconKind.TableExport:
					return "M11.5 20 h-5.5 a2 2 0 0 1 -2 -2 v-12 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v7.5 m-16 -3.5 h16 m-10 -6 v16 m4 -1 h7 m-3 -3 l3 3 l-3 3 M0 0 h24 v24 H0 z";
				case IconKind.TableImport:
					return "M4 13.5 v-7.5 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-6 m-8 -10 h16 m-10 -6 v11.5 m-8 3.5 h7 m-3 -3 l3 3 l-3 3 M0 0 h24 v24 H0 z";
				case IconKind.TableOff:
					return "M3 3 l18 18 M10 4 v2 m0 4 v10 M4 10 h6 m4 0 h6 M8 4 h10 a2 2 0 0 1 2 2 v10 m-0.588 3.417 c-0.362 0.36 -0.86 0.583 -1.412 0.583 h-12 a2 2 0 0 1 -2 -2 v-12 c0 -0.552 0.224 -1.053 0.586 -1.414 M0 0 h24 v24 H0 z";
				case IconKind.TableOptions:
					return "M7.013 19.5 l1.3 0.75 M2.25 16.75 l1.3 0.75 M3.55 19.5 l-1.3 0.75 M8.312 16.75 l-1.299 0.75 M5.281 20.5 v1.5 M5.281 15 v1.5 M5.281 18.5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M10 4 v9 M4 10 h16 M4 12 v-6 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-6 M0 0 h24 v24 H0 z";
				case IconKind.TableShortcut:
					return "M4 15 h5 v5 M3 21 l6 -6 M10 4 v8 M4 10 h16 M4 12 v-6 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-6 M0 0 h24 v24 H0 z";
				case IconKind.Table:
					return "M10 4 l0 16 M4 10 l16 0 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.TagOff:
					return "M3 3 l18 18 M4.88 4.877 a2.99 2.99 0 0 0 -0.88 2.123 v3.859 c0 0.537 0.213 1.052 0.593 1.432 l8.116 8.116 a2.025 2.025 0 0 0 2.864 0 l2.416 -2.416 m2 -2 l0.416 -0.416 a2.025 2.025 0 0 0 0 -2.864 l-8.117 -8.116 a2.025 2.025 0 0 0 -1.431 -0.593 h-2.859 M7.792 7.793 a1 1 0 0 0 1.414 1.414 M0 0 h24 v24 H0 z";
				case IconKind.Tag:
					return "M4 7 v3.859 c0 0.537 0.213 1.052 0.593 1.432 l8.116 8.116 a2.025 2.025 0 0 0 2.864 0 l4.834 -4.834 a2.025 2.025 0 0 0 0 -2.864 l-8.117 -8.116 a2.025 2.025 0 0 0 -1.431 -0.593 h-3.859 a3 3 0 0 0 -3 3 z M7.5,8.5a1,1 0 1,0 2,0a1,1 0 1,0 -2,0 M0 0 h24 v24 H0 z";
				case IconKind.TagsOff:
					return "M3 3 l18 18 M6 9 h-0.01 M17.573 18.407 l0.418 -0.418 m2 -2 l0.419 -0.419 a2.025 2.025 0 0 0 0 -2.864 l-7.117 -7.116 M6 6 h-0.975 a2.025 2.025 0 0 0 -2.025 2.025 v2.834 c0 0.537 0.213 1.052 0.593 1.432 l6.116 6.116 a2.025 2.025 0 0 0 2.864 0 l2.834 -2.834 c0.028 -0.028 0.055 -0.056 0.08 -0.085 M0 0 h24 v24 H0 z";
				case IconKind.Tags:
					return "M6 9 h-0.01 M17.573 18.407 l2.834 -2.834 a2.025 2.025 0 0 0 0 -2.864 l-7.117 -7.116 M7.859 6 h-2.834 a2.025 2.025 0 0 0 -2.025 2.025 v2.834 c0 0.537 0.213 1.052 0.593 1.432 l6.116 6.116 a2.025 2.025 0 0 0 2.864 0 l2.834 -2.834 a2.025 2.025 0 0 0 0 -2.864 l-6.117 -6.116 a2.025 2.025 0 0 0 -1.431 -0.593 z M0 0 h24 v24 H0 z";
				case IconKind.Tallymark1:
					return "M12 5 l0 14 M0 0 h24 v24 H0 z";
				case IconKind.Tallymark2:
					return "M14 5 l0 14 M10 5 l0 14 M0 0 h24 v24 H0 z";
				case IconKind.Tallymark3:
					return "M16 5 l0 14 M12 5 l0 14 M8 5 l0 14 M0 0 h24 v24 H0 z";
				case IconKind.Tallymark4:
					return "M18 5 l0 14 M14 5 l0 14 M10 5 l0 14 M6 5 l0 14 M0 0 h24 v24 H0 z";
				case IconKind.Tallymarks:
					return "M3 17 l18 -10 M18 5 l0 14 M14 5 l0 14 M10 5 l0 14 M6 5 l0 14 M0 0 h24 v24 H0 z";
				case IconKind.Tank:
					return "M21 9 l-7.8 0 M6 12 l1 -5 h5 l3 5 M2 12 m0 3 a3 3 0 0 1 3 -3 h12 a3 3 0 0 1 3 3 v0 a3 3 0 0 1 -3 3 h-12 a3 3 0 0 1 -3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.TargetArrow:
					return "M15 9 l-3 3 M15 6 v3 h3 l3 -3 h-3 v-3 z M13 3.055 a9 9 0 1 0 7.941 7.945 M12 7 a5 5 0 1 0 5 5 M12 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.TargetOff:
					return "M3 3 l18 18 M5.649 5.623 a9 9 0 1 0 12.698 12.758 m1.683 -2.313 a9 9 0 0 0 -12.076 -12.11 M8.44 8.49 a5 5 0 0 0 7.098 7.044 m1.377 -2.611 a5 5 0 0 0 -5.846 -5.836 M11.286 11.3 a1 1 0 0 0 1.41 1.419 M0 0 h24 v24 H0 z";
				case IconKind.Target:
					return "M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M12 12 m-5 0 a5 5 0 1 0 10 0 a5 5 0 1 0 -10 0 M12 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.Teapot:
					return "M7 17 h10 M7.47 12.5 l-4.257 -5.019 a0.899 0.899 0 0 1 0.69 -1.481 h13.09 a3 3 0 0 1 3.007 3 v3 c0 1.657 -1.346 3 -3.007 3 M10.29 3 h3.42 a2 2 0 0 1 1.988 1.78 l1.555 14 a2 2 0 0 1 -1.988 2.22 h-6.53 a2 2 0 0 1 -1.988 -2.22 l1.555 -14 a2 2 0 0 1 1.988 -1.78 z M0 0 h24 v24 H0 z";
				case IconKind.TelescopeOff:
					return "M3 3 l18 18 M14 5 l3 5.5 M8.238 8.264 l-4.183 2.51 c-1.02 0.614 -1.357 1.898 -0.76 2.906 l0.165 0.28 c0.52 0.88 1.624 1.266 2.605 0.91 l6.457 -2.34 m2.907 -1.055 l4.878 -1.77 a1.023 1.023 0 0 0 0.565 -1.455 l-2.62 -4.705 a1.087 1.087 0 0 0 -1.447 -0.42 l-0.056 0.032 l-6.016 3.61 M12 13 v8 M6 21 l6 -5 l6 5 M0 0 h24 v24 H0 z";
				case IconKind.Telescope:
					return "M14 5 l3 5.5 M3.294 13.678 l0.166 0.281 c0.52 0.88 1.624 1.265 2.605 0.91 l14.242 -5.165 a1.023 1.023 0 0 0 0.565 -1.456 l-2.62 -4.705 a1.087 1.087 0 0 0 -1.447 -0.42 l-0.056 0.032 l-12.694 7.618 c-1.02 0.613 -1.357 1.897 -0.76 2.905 z M12 13 v8 M6 21 l6 -5 l6 5 M0 0 h24 v24 H0 z";
				case IconKind.TemperatureCelsius:
					return "M20 9 a3 3 0 0 0 -3 -3 h-1 a3 3 0 0 0 -3 3 v6 a3 3 0 0 0 3 3 h1 a3 3 0 0 0 3 -3 M6 8 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.TemperatureFahrenheit:
					return "M20 6 h-6 a1 1 0 0 0 -1 1 v11 M13 12 l5 0 M6 8 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.TemperatureMinus:
					return "M16 9 l6 0 M8 9 l4 0 M8 13.5 a4 4 0 1 0 4 0 v-8.5 a2 2 0 0 0 -4 0 v8.5 M0 0 h24 v24 H0 z";
				case IconKind.TemperatureOff:
					return "M3 3 l18 18 M13 9 h1 M10 10 v3.5 a4 4 0 1 0 5.836 2.33 m-1.836 -5.83 v-5 a2 2 0 1 0 -4 0 v1 M0 0 h24 v24 H0 z";
				case IconKind.TemperaturePlus:
					return "M19 6 l0 6 M16 9 l6 0 M8 9 l4 0 M8 13.5 a4 4 0 1 0 4 0 v-8.5 a2 2 0 0 0 -4 0 v8.5 M0 0 h24 v24 H0 z";
				case IconKind.Temperature:
					return "M10 9 l4 0 M10 13.5 a4 4 0 1 0 4 0 v-8.5 a2 2 0 0 0 -4 0 v8.5 M0 0 h24 v24 H0 z";
				case IconKind.TemplateOff:
					return "M3 3 l18 18 M14 20 h6 M14 16 h2 M16 12 h4 M4 12 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v6 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M8 4 h11 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-7 m-4 0 h-3 a1 1 0 0 1 -1 -1 v-2 c0 -0.271 0.108 -0.517 0.283 -0.697 M0 0 h24 v24 H0 z";
				case IconKind.Template:
					return "M14 20 l6 0 M14 16 l6 0 M14 12 l6 0 M4 12 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v6 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M4 4 m0 1 a1 1 0 0 1 1 -1 h14 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-14 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.TentOff:
					return "M3 3 l18 18 M11 14 l4 6 h5 m-2.863 -6.868 l-5.137 -9.132 l-1.44 2.559 m-1.44 2.563 l-6.12 10.878 h6 l4 -6 M0 0 h24 v24 H0 z";
				case IconKind.Tent:
					return "M11 14 l4 6 h6 l-9 -16 l-9 16 h6 l4 -6 M0 0 h24 v24 H0 z";
				case IconKind.Terminal2:
					return "M3 4 m0 2 a2 2 0 0 1 2 -2 h14 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 z M13 15 l3 0 M8 9 l3 3 l-3 3 M0 0 h24 v24 H0 z";
				case IconKind.Terminal:
					return "M12 19 l7 0 M5 7 l5 5 l-5 5 M0 0 h24 v24 H0 z";
				case IconKind.TestPipe2:
					return "M8 3 h8 M9 12 h6 M15 3 v15 a3 3 0 0 1 -6 0 v-15 M0 0 h24 v24 H0 z";
				case IconKind.TestPipeOff:
					return "M3 3 l18 18 M15 3 l6 6 M19 15 l1.5 1.6 m-0.74 3.173 a2 2 0 0 1 -2.612 -2.608 M7 13 h6 M20 8.04 a803.533 803.533 0 0 0 -4 3.96 m-2 2 c-1.085 1.085 -3.125 3.14 -6.122 6.164 a2.857 2.857 0 0 1 -4.041 -4.04 c3.018 -3 5.073 -5.037 6.163 -6.124 m2 -2 c0.872 -0.872 2.191 -2.205 3.959 -4 M0 0 h24 v24 H0 z";
				case IconKind.TestPipe:
					return "M15 3 l6 6 M19 15 l1.5 1.6 a2 2 0 1 1 -3 0 l1.5 -1.6 z M7 13 h8 M20 8.04 l-12.122 12.124 a2.857 2.857 0 1 1 -4.041 -4.04 l12.122 -12.124 M0 0 h24 v24 H0 z";
				case IconKind.Tex:
					return "M10 15 h3 M14 11 h-4 v8 h4 M16 15 l5 -8 M21 15 l-5 -8 M6 15 v-8 M9 8 v-1 h-6 v1 M0 0 h24 v24 H0 z";
				case IconKind.TextCaption:
					return "M4 20 h12 M4 4 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M4 15 h16 M0 0 h24 v24 H0 z";
				case IconKind.TextColor:
					return "M5 19 h14 M9 11 h6 M9 15 v-7 a3 3 0 0 1 6 0 v7 M0 0 h24 v24 H0 z";
				case IconKind.TextDecrease:
					return "M21 12 h-6 M4 13 h7 M4 19 v-10.5 a3.5 3.5 0 1 1 7 0 v10.5 M0 0 h24 v24 H0 z";
				case IconKind.TextDirectionLtr:
					return "M10 15 v-11 M14 15 v-11 M16 4 h-6.5 a3.5 3.5 0 0 0 0 7 h0.5 M17 21 l2 -2 l-2 -2 M5 19 h14 M0 0 h24 v24 H0 z";
				case IconKind.TextDirectionRtl:
					return "M7 21 l-2 -2 l2 -2 M5 19 h14 M10 15 v-11 M14 15 v-11 M16 4 h-6.5 a3.5 3.5 0 0 0 0 7 h0.5 M0 0 h24 v24 H0 z";
				case IconKind.TextIncrease:
					return "M21 12 h-6 M18 9 v6 M4 13 h7 M4 19 v-10.5 a3.5 3.5 0 1 1 7 0 v10.5 M0 0 h24 v24 H0 z";
				case IconKind.TextOrientation:
					return "M21 12 h-4 M21 12 v4 M21 12 l-9 9 M5.5 11.5 l5 -5 M9 15 l-5 -5 c-1.367 -1.367 -1.367 -3.633 0 -5 s3.633 -1.367 5 0 l5 5 M0 0 h24 v24 H0 z";
				case IconKind.TextPlus:
					return "M15 18 h6 M18 15 v6 M5 18 h6 M14 14 h-9 M5 6 h14 M19 10 h-14 M0 0 h24 v24 H0 z";
				case IconKind.TextRecognition:
					return "M9 9 h6 M12 16 v-7 M16 20 h2 a2 2 0 0 0 2 -2 v-2 M16 4 h2 a2 2 0 0 1 2 2 v2 M4 16 v2 a2 2 0 0 0 2 2 h2 M4 8 v-2 a2 2 0 0 1 2 -2 h2 M0 0 h24 v24 H0 z";
				case IconKind.TextResize:
					return "M12 14 v-4 M10 10 h4 M19 7 v10 M7 19 h10 M7 5 h10 M5 7 v10 M19 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M19 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 5 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.TextSize:
					return "M17 19 h2 M18 12 v7 M15 13 v-1 h6 v1 M12 19 h-4 M10 5 v14 M3 7 v-2 h13 v2 M0 0 h24 v24 H0 z";
				case IconKind.TextSpellcheck:
					return "M10 18 l3 3 l7 -7 M5 10 h7 M5 15 v-7.5 a3.5 3.5 0 0 1 7 0 v7.5 M0 0 h24 v24 H0 z";
				case IconKind.TextWrapDisabled:
					return "M4 12 h17 l-3 -3 m0 6 l3 -3 M4 18 l10 0 M4 6 l10 0 M0 0 h24 v24 H0 z";
				case IconKind.TextWrap:
					return "M4 12 h13 a3 3 0 0 1 0 6 h-4 l2 -2 m0 4 l-2 -2 M4 18 l5 0 M4 6 l16 0 M0 0 h24 v24 H0 z";
				case IconKind.Texture:
					return "M21 13 l-8 8 M21 8 l-13 13 M21 3 l-18 18 M16 3 l-13 13 M11 3 l-8 8 M21 18 l-3 3 M6 3 l-3 3 M0 0 h24 v24 H0 z";
				case IconKind.Thermometer:
					return "M7 17 l-3 3 M10 13 l-1.5 -1.5 M13 10 l-1.5 -1.5 M16 7 l-1.5 -1.5 M19 5 a2.828 2.828 0 0 1 0 4 l-8 8 h-4 v-4 l8 -8 a2.828 2.828 0 0 1 4 0 z M0 0 h24 v24 H0 z";
				case IconKind.ThumbDownFilled:
					return "M7 13 v-8 a1 1 0 0 0 -1 -1 h-2 a1 1 0 0 0 -1 1 v7 a1 1 0 0 0 1 1 h3 a4 4 0 0 1 4 4 v1 a2 2 0 0 0 4 0 v-5 h3 a2 2 0 0 0 2 -2 l-1 -5 a2 3 0 0 0 -2 -2 h-7 a3 3 0 0 0 -3 3 M0 0 h24 v24 H0 z";
				case IconKind.ThumbDownOff:
					return "M3 3 l18 18 M7 13 v-6 m-3 -3 a1 1 0 0 0 -1 1 v7 a1 1 0 0 0 1 1 h3 a4 4 0 0 1 4 4 v1 a2 2 0 1 0 4 0 v-3 m2 -2 h1 a2 2 0 0 0 2 -2 l-1 -5 c-0.295 -1.26 -1.11 -2.076 -2 -2 h-7 c-0.57 0 -1.102 0.159 -1.556 0.434 M0 0 h24 v24 H0 z";
				case IconKind.ThumbDown:
					return "M7 13 v-8 a1 1 0 0 0 -1 -1 h-2 a1 1 0 0 0 -1 1 v7 a1 1 0 0 0 1 1 h3 a4 4 0 0 1 4 4 v1 a2 2 0 0 0 4 0 v-5 h3 a2 2 0 0 0 2 -2 l-1 -5 a2 3 0 0 0 -2 -2 h-7 a3 3 0 0 0 -3 3 M0 0 h24 v24 H0 z";
				case IconKind.ThumbUpFilled:
					return "M7 11 v8 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 v-7 a1 1 0 0 1 1 -1 h3 a4 4 0 0 0 4 -4 v-1 a2 2 0 0 1 4 0 v5 h3 a2 2 0 0 1 2 2 l-1 5 a2 3 0 0 1 -2 2 h-7 a3 3 0 0 1 -3 -3 M0 0 h24 v24 H0 z";
				case IconKind.ThumbUpOff:
					return "M3 3 l18 18 M7 11 v8 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 v-7 a1 1 0 0 1 1 -1 h3 a3.987 3.987 0 0 0 2.828 -1.172 m1.172 -2.828 v-1 a2 2 0 1 1 4 0 v5 h3 a2 2 0 0 1 2 2 c-0.222 1.112 -0.39 1.947 -0.5 2.503 m-0.758 3.244 c-0.392 0.823 -1.044 1.312 -1.742 1.253 h-7 a3 3 0 0 1 -3 -3 M0 0 h24 v24 H0 z";
				case IconKind.ThumbUp:
					return "M7 11 v8 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 v-7 a1 1 0 0 1 1 -1 h3 a4 4 0 0 0 4 -4 v-1 a2 2 0 0 1 4 0 v5 h3 a2 2 0 0 1 2 2 l-1 5 a2 3 0 0 1 -2 2 h-7 a3 3 0 0 1 -3 -3 M0 0 h24 v24 H0 z";
				case IconKind.TicTac:
					return "M18 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M16 8 l4 -4 M16 4 l4 4 M4 20 l4 -4 M4 16 l4 4 M12 3 v18 M3 12 h18 M6 6 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.TicketOff:
					return "M3 3 l18 18 M9 5 h10 a2 2 0 0 1 2 2 v3 a2 2 0 1 0 0 4 v3 m-2 2 h-14 a2 2 0 0 1 -2 -2 v-3 a2 2 0 1 0 0 -4 v-3 a2 2 0 0 1 2 -2 M15 17 v2 M15 5 v2 M0 0 h24 v24 H0 z";
				case IconKind.Ticket:
					return "M5 5 h14 a2 2 0 0 1 2 2 v3 a2 2 0 0 0 0 4 v3 a2 2 0 0 1 -2 2 h-14 a2 2 0 0 1 -2 -2 v-3 a2 2 0 0 0 0 -4 v-3 a2 2 0 0 1 2 -2 M15 17 l0 2 M15 11 l0 2 M15 5 l0 2 M0 0 h24 v24 H0 z";
				case IconKind.Tie:
					return "M10.5 7 h3 l5 5.5 M12 22 l4 -4 l-2.5 -11 l0.993 -2.649 a1 1 0 0 0 -0.936 -1.351 h-3.114 a1 1 0 0 0 -0.936 1.351 l0.993 2.649 l-2.5 11 l4 4 z M0 0 h24 v24 H0 z";
				case IconKind.Tilde:
					return "M4 12 c0 -1.657 1.592 -3 3.556 -3 c1.963 0 3.11 1.5 4.444 3 c1.333 1.5 2.48 3 4.444 3 s3.556 -1.343 3.556 -3 M0 0 h24 v24 H0 z";
				case IconKind.TiltShiftOff:
					return "M3 3 l18 18 M10.57 10.602 a2 2 0 0 0 2.862 2.795 M15.44 3.69 a9 9 0 0 0 -3.44 -0.69 M20.31 8.56 a9 9 0 0 0 -1.95 -2.92 M20.31 15.44 a9 9 0 0 0 0.69 -3.44 M15.44 20.31 a9 9 0 0 0 2.92 -1.95 M8.56 20.31 a9 9 0 0 0 3.44 0.69 M3.69 15.44 a9 9 0 0 0 1.95 2.92 M3.69 8.56 a9 9 0 0 0 -0.69 3.44 M8.56 3.69 a9 9 0 0 0 -0.577 0.263 M0 0 h24 v24 H0 z";
				case IconKind.TiltShift:
					return "M12 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M15.44 3.69 a9 9 0 0 0 -3.44 -0.69 M20.31 8.56 a9 9 0 0 0 -1.95 -2.92 M20.31 15.44 a9 9 0 0 0 0.69 -3.44 M15.44 20.31 a9 9 0 0 0 2.92 -1.95 M8.56 20.31 a9 9 0 0 0 3.44 0.69 M3.69 15.44 a9 9 0 0 0 1.95 2.92 M3.69 8.56 a9 9 0 0 0 -0.69 3.44 M8.56 3.69 a9 9 0 0 0 -2.92 1.95 M0 0 h24 v24 H0 z";
				case IconKind.TimelineEventExclamation:
					return "M12 11 v0.01 M12 6 v2 M12 15 l-2 -2 h-3 a1 1 0 0 1 -1 -1 v-8 a1 1 0 0 1 1 -1 h10 a1 1 0 0 1 1 1 v8 a1 1 0 0 1 -1 1 h-3 l-2 2 z M14 20 h6 M10 20 h-6 M12 20 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.TimelineEventMinus:
					return "M10 8 h4 M12 15 l-2 -2 h-3 a1 1 0 0 1 -1 -1 v-8 a1 1 0 0 1 1 -1 h10 a1 1 0 0 1 1 1 v8 a1 1 0 0 1 -1 1 h-3 l-2 2 z M14 20 h6 M10 20 h-6 M12 20 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.TimelineEventPlus:
					return "M12 6 v4 M10 8 h4 M12 15 l-2 -2 h-3 a1 1 0 0 1 -1 -1 v-8 a1 1 0 0 1 1 -1 h10 a1 1 0 0 1 1 1 v8 a1 1 0 0 1 -1 1 h-3 l-2 2 z M14 20 h6 M10 20 h-6 M12 20 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.TimelineEventText:
					return "M9 9 h3 M9 6 h6 M12 15 l-2 -2 h-3 a1 1 0 0 1 -1 -1 v-8 a1 1 0 0 1 1 -1 h10 a1 1 0 0 1 1 1 v8 a1 1 0 0 1 -1 1 h-3 l-2 2 z M14 20 h6 M10 20 h-6 M12 20 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.TimelineEventX:
					return "M10.5 9.5 l3 -3 M13.5 9.5 l-3 -3 M12 15 l-2 -2 h-3 a1 1 0 0 1 -1 -1 v-8 a1 1 0 0 1 1 -1 h10 a1 1 0 0 1 1 1 v8 a1 1 0 0 1 -1 1 h-3 l-2 2 z M14 20 h6 M10 20 h-6 M12 20 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.TimelineEvent:
					return "M12 15 l-2 -2 h-3 a1 1 0 0 1 -1 -1 v-8 a1 1 0 0 1 1 -1 h10 a1 1 0 0 1 1 1 v8 a1 1 0 0 1 -1 1 h-3 l-2 2 z M14 20 h6 M10 20 h-6 M12 20 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Timeline:
					return "M20 8 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M4 16 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M10 9 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M15 14 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M4 16 l6 -7 l5 5 l5 -6 M0 0 h24 v24 H0 z";
				case IconKind.Tir:
					return "M3 17 l0 -5 l9 0 M12 18 v-13 h3 M7 18 h8 m4 0 h2 v-6 a5 7 0 0 0 -5 -7 h-1 l1.5 7 h4.5 M17 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.ToggleLeft:
					return "M2 6 m0 6 a6 6 0 0 1 6 -6 h8 a6 6 0 0 1 6 6 v0 a6 6 0 0 1 -6 6 h-8 a6 6 0 0 1 -6 -6 z M8 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.ToggleRight:
					return "M2 6 m0 6 a6 6 0 0 1 6 -6 h8 a6 6 0 0 1 6 6 v0 a6 6 0 0 1 -6 6 h-8 a6 6 0 0 1 -6 -6 z M16 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.ToiletPaperOff:
					return "M3 3 l18 18 M6 10 h0.01 M21 10 v7 m-1.513 2.496 l-1.487 -0.496 l-3 2 l-3 -3 l-3 2 v-10 M7 3 h11 M21 10 c0 -3.866 -1.343 -7 -3 -7 M4.27 4.28 c-0.768 1.27 -1.27 3.359 -1.27 5.72 c0 3.866 1.343 7 3 7 s3 -3.134 3 -7 c0 -0.34 -0.01 -0.672 -0.03 -1 M0 0 h24 v24 H0 z";
				case IconKind.ToiletPaper:
					return "M6 10 h0.01 M21 10 v10 l-3 -1 l-3 2 l-3 -3 l-3 2 v-10 M6 3 h12 M21 10 c0 -3.866 -1.343 -7 -3 -7 M6 10 m-3 0 a3 7 0 1 0 6 0 a3 7 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.Tool:
					return "M7 10 h3 v-3 l-3.5 -3.5 a6 6 0 0 1 8 8 l6 6 a2 2 0 0 1 -3 3 l-6 -6 a6 6 0 0 1 -8 -8 l3.5 3.5 M0 0 h24 v24 H0 z";
				case IconKind.ToolsKitchen2Off:
					return "M3 3 l18 18 M5 5 v2 a3 3 0 0 0 4.546 2.572 m1.454 -2.572 v-3 M8 8 v13 M19 19 v2 h-1 v-3 M14.386 10.409 c0.53 -2.28 1.766 -4.692 4.614 -7.409 v12 m-4 0 h-1 c0 -0.313 0 -0.627 0 -0.941 M0 0 h24 v24 H0 z";
				case IconKind.ToolsKitchen2:
					return "M19 3 v12 h-5 c-0.023 -3.681 0.184 -7.406 5 -12 z m0 12 v6 h-1 v-3 m-10 -14 v17 m-3 -17 v3 a3 3 0 1 0 6 0 v-3 M0 0 h24 v24 H0 z";
				case IconKind.ToolsKitchenOff:
					return "M3 3 l18 18 M8 12 v6 M20 15 v1 m0 4 v1 h-1 v-2 M15.225 11.216 c0.42 -2.518 1.589 -5.177 4.775 -8.216 v12 h-1 M7 18 h2 v3 h-2 z M7 3 h5 l-0.5 4.5 m-0.4 3.595 l-0.1 0.905 h-6 l-0.875 -7.874 M0 0 h24 v24 H0 z";
				case IconKind.ToolsKitchen:
					return "M8 12 l0 6 M20 15 v6 h-1 v-3 M20 3 v12 h-5 c-0.023 -3.681 0.184 -7.406 5 -12 z M7 18 h2 v3 h-2 z M4 3 h8 l-1 9 h-6 z M0 0 h24 v24 H0 z";
				case IconKind.ToolsOff:
					return "M3 3 l18 18 M16 17 l-1.5 1.5 M16 12 l5 5 m-2 2 l-2 2 l-5 -5 M7 8 l-1.5 1.5 M12 8 l-5 -5 m-2 2 l-2 2 l5 5 M14.5 5.5 l4 4 M16 12 l4 -4 a2.828 2.828 0 1 0 -4 -4 l-4 4 m-2 2 l-7 7 v4 h4 l7 -7 M0 0 h24 v24 H0 z";
				case IconKind.Tools:
					return "M16 17 l-1.5 1.5 M16 12 l5 5 l-4 4 l-5 -5 M7 8 l-1.5 1.5 M12 8 l-5 -5 l-4 4 l5 5 M14.5 5.5 l4 4 M3 21 h4 l13 -13 a1.5 1.5 0 0 0 -4 -4 l-13 13 v4 M0 0 h24 v24 H0 z";
				case IconKind.Tooltip:
					return "M12 13 l-1.707 -1.707 a1 1 0 0 0 -0.707 -0.293 h-2.586 a2 2 0 0 1 -2 -2 v-3 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v3 a2 2 0 0 1 -2 2 h-2.586 a1 1 0 0 0 -0.707 0.293 l-1.707 1.707 z M12 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.TopologyBus:
					return "M20 12 v4 M12 12 v4 M4 12 v4 M2 16 h20 M22 10 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M6 10 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M14 10 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M0 0 h24 v24 H0 z";
				case IconKind.TopologyComplex:
					return "M16 18 h-8 M8 6 h8 M18 16 v-8 M6 8 v8 M7.5 7.5 l3 3 M14 12 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M20 6 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M8 6 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M8 18 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M20 18 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M0 0 h24 v24 H0 z";
				case IconKind.TopologyFullHierarchy:
					return "M10.5 13.5 l-3 3 M16.5 7.5 l-3 3 M13.5 13.5 l3 3 M7.5 7.5 l3 3 M16 18 h-8 M8 6 h8 M18 16 v-8 M6 8 v8 M14 12 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M20 6 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M8 6 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M8 18 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M20 18 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M0 0 h24 v24 H0 z";
				case IconKind.TopologyFull:
					return "M7.5 16.5 l9 -9 M7.5 7.5 l9 9 M16 18 h-8 M8 6 h8 M18 16 v-8 M6 8 v8 M20 6 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M8 6 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M8 18 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M20 18 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M0 0 h24 v24 H0 z";
				case IconKind.TopologyRing2:
					return "M11 8 l-5 8 M18 16 l-5 -8 M7 18 h10 M21 18 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M7 18 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M14 6 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M0 0 h24 v24 H0 z";
				case IconKind.TopologyRing3:
					return "M16 18 h-8 M8 6 h8 M18 16 v-8 M6 8 v8 M8 6 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M20 6 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M20 18 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M8 18 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M0 0 h24 v24 H0 z";
				case IconKind.TopologyRing:
					return "M10.5 5.5 l-5 5 M13.5 18.5 l5 -5 M5.5 13.5 l5 5 M13.5 5.5 l5 5 M22 12 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M6 12 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M14 4 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M14 20 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M0 0 h24 v24 H0 z";
				case IconKind.TopologyStar2:
					return "M12 14 v4 M12 6 v4 M14 12 h4 M6 12 h4 M14 12 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M22 12 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M6 12 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M14 4 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M14 20 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M0 0 h24 v24 H0 z";
				case IconKind.TopologyStar3:
					return "M13 14 l2 3 M11 14 l-2 3 M9 7 l2 3 M15 7 l-2 3 M14 12 h4 M6 12 h4 M22 12 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M14 12 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M18 19 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M6 12 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M10 5 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M18 5 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M10 19 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M0 0 h24 v24 H0 z";
				case IconKind.TopologyStarRing2:
					return "M10.5 18.5 l-5 -5 M18.5 13.5 l-5 5 M13.5 5.5 l5 5 M5.5 10.5 l5 -5 M12 14 v4 M12 6 v4 M14 12 h4 M6 12 h4 M14 12 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M22 12 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M6 12 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M14 4 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M14 20 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M0 0 h24 v24 H0 z";
				case IconKind.TopologyStarRing3:
					return "M5 14 l2 3 M7 7 l-2 3 M19 10 l-2 -3 M17 17 l2 -3 M10 19 h4 M10 5 h4 M13 14 l2 3 M11 14 l-2 3 M9 7 l2 3 M15 7 l-2 3 M14 12 h4 M6 12 h4 M22 12 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M14 12 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M18 19 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M6 12 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M10 5 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M18 5 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M10 19 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M0 0 h24 v24 H0 z";
				case IconKind.TopologyStarRing:
					return "M12 14 v4 M12 6 v4 M10.5 5.5 l-5 5 M13.5 18.5 l5 -5 M5.5 13.5 l5 5 M13.5 5.5 l5 5 M14 12 h4 M6 12 h4 M14 12 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M22 12 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M6 12 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M14 4 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M14 20 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M0 0 h24 v24 H0 z";
				case IconKind.TopologyStar:
					return "M16.5 7.5 l-3 3 M13.5 13.5 l3 3 M7.5 16.5 l3 -3 M7.5 7.5 l3 3 M14 12 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M20 18 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M8 6 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M20 6 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M8 18 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M0 0 h24 v24 H0 z";
				case IconKind.Torii:
					return "M6 4.5 v15.5 M18 4.5 v15.5 M12 5 v3 M4 8 h16 M4 4 c5.333 1.333 10.667 1.333 16 0 M0 0 h24 v24 H0 z";
				case IconKind.Tornado:
					return "M4 12 l12 0 M6 8 l14 0 M11 20 l4 0 M13 16 l-6 0 M21 4 l-18 0 M0 0 h24 v24 H0 z";
				case IconKind.Tournament:
					return "M14 10 h4 M6 4 h7 a1 1 0 0 1 1 1 v10 a1 1 0 0 1 -1 1 h-2 M6 12 h3 a1 1 0 0 1 1 1 v6 a1 1 0 0 1 -1 1 h-3 M4 20 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M4 12 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M20 10 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M4 4 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.TowerOff:
					return "M3 3 l18 18 M10 21 v-5 a2 2 0 1 1 4 0 v5 M10 6 v-2 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 h3 v-2 a1 1 0 0 1 1 -1 h1 a1 1 0 0 1 1 1 v4.394 a2 2 0 0 1 -0.336 1.11 l-1.328 1.992 a2 2 0 0 0 -0.336 1.11 v1.394 m0 4 v2 a1 1 0 0 1 -1 1 h-10 a1 1 0 0 1 -1 -1 v-7.394 a2 2 0 0 0 -0.336 -1.11 l-1.328 -1.992 a2 2 0 0 1 -0.336 -1.11 v-4.394 M0 0 h24 v24 H0 z";
				case IconKind.Tower:
					return "M10 21 v-5 a2 2 0 1 1 4 0 v5 M5 3 h1 a1 1 0 0 1 1 1 v2 h3 v-2 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 h3 v-2 a1 1 0 0 1 1 -1 h1 a1 1 0 0 1 1 1 v4.394 a2 2 0 0 1 -0.336 1.11 l-1.328 1.992 a2 2 0 0 0 -0.336 1.11 v7.394 a1 1 0 0 1 -1 1 h-10 a1 1 0 0 1 -1 -1 v-7.394 a2 2 0 0 0 -0.336 -1.11 l-1.328 -1.992 a2 2 0 0 1 -0.336 -1.11 v-4.394 a1 1 0 0 1 1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.Track:
					return "M4 15 l11 -11 m5 5 l-11 11 m-4 -8 l7 7 m-3.5 -10.5 l7 7 m-3.5 -10.5 l7 7 M0 0 h24 v24 H0 z";
				case IconKind.Tractor:
					return "M18 5 h-1 a1 1 0 0 0 -1 1 v4 M20 15.2 v-4.2 a1 1 0 0 0 -1 -1 h-6 l-2 -5 h-6 v6.5 M10.5 17 l6.5 0 M19 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M7 15 l0 0.01 M7 15 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M0 0 h24 v24 H0 z";
				case IconKind.Trademark:
					return "M13 15 v-6 l3 4 l3 -4 v6 M4.5 9 h5 m-2.5 0 v6 M0 0 h24 v24 H0 z";
				case IconKind.TrafficConeOff:
					return "M3 3 l18 18 M10.5 6.5 l0.5 -1.5 h2 l2 6 m2 6 l1 3 M6 20 l3.5 -10.5 M7.8 15 h7.2 M9.4 10 h0.6 m4 0 h0.6 M4 20 h16 M0 0 h24 v24 H0 z";
				case IconKind.TrafficCone:
					return "M6 20 l5 -15 h2 l5 15 M7.8 15 l8.4 0 M9.4 10 l5.2 0 M4 20 l16 0 M0 0 h24 v24 H0 z";
				case IconKind.TrafficLightsOff:
					return "M3 3 l18 18 M12 17 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M11.291 11.295 a1 1 0 0 0 1.418 1.41 M12 8 a1 1 0 1 0 -1 -1 M8 4 c0.912 -1.219 2.36 -2 4 -2 a5 5 0 0 1 5 5 v6 m0 4 a5 5 0 0 1 -10 0 v-10 M0 0 h24 v24 H0 z";
				case IconKind.TrafficLights:
					return "M12 17 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12 7 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M7 2 m0 5 a5 5 0 0 1 5 -5 h0 a5 5 0 0 1 5 5 v10 a5 5 0 0 1 -5 5 h0 a5 5 0 0 1 -5 -5 z M0 0 h24 v24 H0 z";
				case IconKind.Train:
					return "M3 19 l18 0 M13 11 l0 -4.5 M8 11 l0 -5 M3 10 l0 4 M3 6 v5 h17.5 M3 15 h16 a2 2 0 0 0 2 -2 M21 13 c0 -3.87 -3.37 -7 -10 -7 h-8 M0 0 h24 v24 H0 z";
				case IconKind.TransferIn:
					return "M10 11 l3 3 l-3 3 M4 14 h9 M4 18 v3 h16 v-14 l-8 -4 l-8 4 v3 M0 0 h24 v24 H0 z";
				case IconKind.TransferOut:
					return "M7 11 l-3 3 l3 3 M13 14 h-9 M4 19 v2 h16 v-14 l-8 -4 l-8 4 v2 M0 0 h24 v24 H0 z";
				case IconKind.TransformFilled:
					return "M18 18 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M6 6 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M3 15 l2 -2 l2 2 M18 10 v-0.875 c0 -3.383 -2.686 -6.125 -6 -6.125 M16 9 l2 2 l2 -2 M5 13 v0.875 c0 3.383 2.686 6.125 6 6.125 M0 0 h24 v24 H0 z";
				case IconKind.Transform:
					return "M3 15 l2 -2 l2 2 M18 10 v-0.875 c0 -3.383 -2.686 -6.125 -6 -6.125 M16 9 l2 2 l2 -2 M18 18 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M6 6 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M5 13 v0.875 c0 3.383 2.686 6.125 6 6.125 M0 0 h24 v24 H0 z";
				case IconKind.TransitionBottom:
					return "M9 14 l3 3 l3 -3 M12 9 v8 M3 3 m0 3 a3 3 0 0 1 3 -3 h12 a3 3 0 0 1 3 3 v0 a3 3 0 0 1 -3 3 h-12 a3 3 0 0 1 -3 -3 z M21 18 a3 3 0 0 1 -3 3 h-12 a3 3 0 0 1 -3 -3 M0 0 h24 v24 H0 z";
				case IconKind.TransitionLeft:
					return "M10 9 l-3 3 l3 3 M15 12 h-8 M21 6 v12 a3 3 0 0 1 -6 0 v-12 a3 3 0 0 1 6 0 z M6 21 a3 3 0 0 1 -3 -3 v-12 a3 3 0 0 1 3 -3 M0 0 h24 v24 H0 z";
				case IconKind.TransitionRight:
					return "M14 15 l3 -3 l-3 -3 M9 12 h8 M3 18 v-12 a3 3 0 1 1 6 0 v12 a3 3 0 0 1 -6 0 z M18 3 a3 3 0 0 1 3 3 v12 a3 3 0 0 1 -3 3 M0 0 h24 v24 H0 z";
				case IconKind.TransitionTop:
					return "M9 10 l3 -3 l3 3 M12 15 v-8 M6 21 h12 a3 3 0 0 0 0 -6 h-12 a3 3 0 0 0 0 6 z M21 6 a3 3 0 0 0 -3 -3 h-12 a3 3 0 0 0 -3 3 M0 0 h24 v24 H0 z";
				case IconKind.TrashOff:
					return "M9 5 v-1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v3 M18.384 14.373 l0.616 -7.373 M5 7 l1 12 a2 2 0 0 0 2 2 h8 a2 2 0 0 0 2 -2 l0.077 -0.923 M14 14 l0 3 M10 11 l0 6 M4 7 h3 m4 0 h9 M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.TrashX:
					return "M10 12 l4 4 m0 -4 l-4 4 M9 7 v-3 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v3 M5 7 l1 12 a2 2 0 0 0 2 2 h8 a2 2 0 0 0 2 -2 l1 -12 M4 7 h16 M0 0 h24 v24 H0 z";
				case IconKind.Trash:
					return "M9 7 v-3 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v3 M5 7 l1 12 a2 2 0 0 0 2 2 h8 a2 2 0 0 0 2 -2 l1 -12 M14 11 l0 6 M10 11 l0 6 M4 7 l16 0 M0 0 h24 v24 H0 z";
				case IconKind.Tree:
					return "M9.824 16 a3 3 0 0 1 -2.743 -3.69 a3 3 0 0 1 0.304 -4.833 a3 3 0 0 1 4.615 -3.707 a3 3 0 0 1 4.614 3.707 a3 3 0 0 1 0.305 4.833 a3 3 0 0 1 -2.919 3.695 h-4 z M12 21 v-13 M12 12 l2 -2 M12 13 l-2 -2 M0 0 h24 v24 H0 z";
				case IconKind.Trees:
					return "M5.824 16 a3 3 0 0 1 -2.743 -3.69 a3 3 0 0 1 0.304 -4.833 a3 3 0 0 1 4.615 -3.707 a3 3 0 0 1 4.614 3.707 a3 3 0 0 1 0.305 4.833 a3 3 0 0 1 -2.919 3.695 h-4 z M8 21 v-13 M8 12 l2 -2 M8 13 l-2 -2 M15 21 l0 -3 M16 5 l3 3 l-2 1 l4 4 l-3 1 l4 4 h-9 M0 0 h24 v24 H0 z";
				case IconKind.Trekking:
					return "M16 20 h2 M17 12 v9 M10 14 l-1.827 -1.218 a2 2 0 0 1 -0.831 -2.15 l0.28 -1.117 a2 2 0 0 1 1.939 -1.515 h1.439 l4 1 l3 -2 M13 21 v-4 l-3 -3 l1 -6 l3 4 l3 2 M7 21 l2 -4 M12 4 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.TrendingDown2:
					return "M18 19 l3 -3 l-3 -3 M3 6 h5 l7 10 h6 M0 0 h24 v24 H0 z";
				case IconKind.TrendingDown3:
					return "M18 19 l3 -3 l-3 -3 M3 6 h2.397 a5 5 0 0 1 4.096 2.133 l4.014 5.734 a5 5 0 0 0 4.096 2.133 h3.397 M0 0 h24 v24 H0 z";
				case IconKind.TrendingDown:
					return "M21 10 l0 7 l-7 0 M3 7 l6 6 l4 -4 l8 8 M0 0 h24 v24 H0 z";
				case IconKind.TrendingUp2:
					return "M3 18 h5 l7 -10 h6 M18 5 l3 3 l-3 3 M0 0 h24 v24 H0 z";
				case IconKind.TrendingUp3:
					return "M3 18 h2.397 a5 5 0 0 0 4.096 -2.133 l4.014 -5.734 a5 5 0 0 1 4.096 -2.133 h3.397 M18 5 l3 3 l-3 3 M0 0 h24 v24 H0 z";
				case IconKind.TrendingUp:
					return "M14 7 l7 0 l0 7 M3 17 l6 -6 l4 4 l8 -8 M0 0 h24 v24 H0 z";
				case IconKind.TriangleFilled:
					return "M5 19 h14 a2 2 0 0 0 1.84 -2.75 l-7.1 -12.25 a2 2 0 0 0 -3.5 0 l-7.1 12.25 a2 2 0 0 0 1.75 2.75 M0 0 h24 v24 H0 z";
				case IconKind.TriangleInvertedFilled:
					return "M5 4 h14 a2 2 0 0 1 1.84 2.75 l-7.1 12.25 a2 2 0 0 1 -3.5 0 l-7.1 -12.25 a2 2 0 0 1 1.75 -2.75 M0 0 h24 v24 H0 z";
				case IconKind.TriangleInverted:
					return "M5 4 h14 a2 2 0 0 1 1.84 2.75 l-7.1 12.25 a2 2 0 0 1 -3.5 0 l-7.1 -12.25 a2 2 0 0 1 1.75 -2.75 M0 0 h24 v24 H0 z";
				case IconKind.TriangleOff:
					return "M3 3 l18 18 M5 19 h14 m1.986 -2.014 a2 2 0 0 0 -0.146 -0.736 l-7.1 -12.25 a2 2 0 0 0 -3.5 0 l-0.825 1.424 m-1.467 2.53 l-4.808 8.296 a2 2 0 0 0 1.75 2.75 M0 0 h24 v24 H0 z";
				case IconKind.TriangleSquareCircle:
					return "M4 14 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v4 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M17 17 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M12 3 l-4 7 h8 z M0 0 h24 v24 H0 z";
				case IconKind.Triangle:
					return "M5 19 h14 a2 2 0 0 0 1.84 -2.75 l-7.1 -12.25 a2 2 0 0 0 -3.5 0 l-7.1 12.25 a2 2 0 0 0 1.75 2.75 M0 0 h24 v24 H0 z";
				case IconKind.Triangles:
					return "M4.98 16 h14.04 c0.542 0 0.98 -0.443 0.98 -0.989 a1 1 0 0 0 -0.156 -0.534 l-7.02 -11.023 a0.974 0.974 0 0 0 -1.648 0 l-7.02 11.023 a1 1 0 0 0 0.294 1.366 a0.973 0.973 0 0 0 0.53 0.157 z M9.974 21 h8.052 a0.975 0.975 0 0 0 0.81 -1.517 l-4.025 -6.048 a0.973 0.973 0 0 0 -1.622 0 l-4.025 6.048 a0.977 0.977 0 0 0 0.81 1.517 z M0 0 h24 v24 H0 z";
				case IconKind.Trident:
					return "M12 21 v-18 l-2 2 m4 0 l-2 -2 M3 6 l2 -2 v3 a7 7 0 0 0 14 0 v-3 l2 2 M0 0 h24 v24 H0 z";
				case IconKind.Trolley:
					return "M9.592 4.695 l3.306 2.104 a1.3 1.3 0 0 1 0.396 1.8 l-3.094 4.811 a1.3 1.3 0 0 1 -1.792 0.394 l-3.306 -2.104 a1.3 1.3 0 0 1 -0.396 -1.8 l3.094 -4.81 a1.3 1.3 0 0 1 1.792 -0.394 z M17 10 l2 1 M12 17 l8 -12 M6 16 l3 2 M11 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.TrophyFilled:
					return "M19 9 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 9 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M17 4 v8 a5 5 0 0 1 -10 0 v-8 M7 4 l10 0 M12 17 l0 4 M8 21 l8 0 M0 0 h24 v24 H0 z";
				case IconKind.TrophyOff:
					return "M3 3 l18 18 M19 9 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 9 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M17 4 v8 c0 0.31 -0.028 0.612 -0.082 0.905 m-1.384 2.632 a5 5 0 0 1 -8.534 -3.537 v-5 M8 4 h9 M12 17 v4 M8 21 h8 M0 0 h24 v24 H0 z";
				case IconKind.Trophy:
					return "M19 9 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M5 9 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M17 4 v8 a5 5 0 0 1 -10 0 v-8 M7 4 l10 0 M12 17 l0 4 M8 21 l8 0 M0 0 h24 v24 H0 z";
				case IconKind.Trowel:
					return "M19.347 16.575 l1.08 1.079 a1.96 1.96 0 0 1 -2.773 2.772 l-1.08 -1.079 a1.96 1.96 0 0 1 2.773 -2.772 z M10 10 l6.5 6.5 M14.42 9.058 l-5.362 5.363 a1.978 1.978 0 0 1 -3.275 -0.773 l-2.682 -8.044 a1.978 1.978 0 0 1 2.502 -2.502 l8.045 2.682 a1.978 1.978 0 0 1 0.773 3.274 z M0 0 h24 v24 H0 z";
				case IconKind.TruckDelivery:
					return "M3 9 l4 0 M5 17 h-2 v-4 m-1 -8 h11 v12 m-4 0 h6 m4 0 h2 v-6 h-8 m0 -5 h5 l3 5 M17 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M7 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.TruckLoading:
					return "M18 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M9 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M9 6 m0 3 a3 3 0 0 1 3 -3 h4 a3 3 0 0 1 3 3 v2 a3 3 0 0 1 -3 3 h-4 a3 3 0 0 1 -3 -3 z M2 3 h1 a2 2 0 0 1 2 2 v10 a2 2 0 0 0 2 2 h15 M0 0 h24 v24 H0 z";
				case IconKind.TruckOff:
					return "M3 3 l18 18 M5 17 h-2 v-11 a1 1 0 0 1 1 -1 h1 m3.96 0 h4.04 v4 m0 4 v4 m-4 0 h6 m6 0 v-6 h-6 m-2 -5 h5 l3 5 M15.585 15.586 a2 2 0 0 0 2.826 2.831 M7 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.TruckReturn:
					return "M13 6 h5 l3 5 v6 h-2 M9 17 l6 0 M5 17 h-2 v-11 a1 1 0 0 1 1 -1 h9 v6 h-5 l2 2 m0 -4 l-2 2 M17 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M7 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Truck:
					return "M5 17 h-2 v-11 a1 1 0 0 1 1 -1 h9 v12 m-4 0 h6 m4 0 h2 v-6 h-8 m0 -5 h5 l3 5 M17 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M7 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.Txt:
					return "M10 16 l4 -8 M10 8 l4 8 M19 8 v8 M17 8 h4 M5 8 v8 M3 8 h4 M0 0 h24 v24 H0 z";
				case IconKind.TypographyOff:
					return "M3 3 l18 18 M10.181 6.183 l0.819 -2.183 h2 l3.904 8.924 M5 20 l4.09 -10.906 M13 13 l3 7 M6.9 15 h6.9 M14 20 h6 M4 20 h3 M0 0 h24 v24 H0 z";
				case IconKind.Typography:
					return "M5 20 l6 -16 l2 0 l7 16 M10.2 6.3 l5.8 13.7 M6.9 15 l6.9 0 M14 20 l7 0 M4 20 l3 0 M0 0 h24 v24 H0 z";
				case IconKind.UfoOff:
					return "M3 3 l18 18 M17 13 h0.01 M7 13 h0.01 M12 14 h0.01 M8.5 17 l-1.5 3 M15 17 l2 3 M14.69 10.686 c1.388 -0.355 2.31 -0.976 2.31 -1.686 v-0.035 c0 -2.742 -2.239 -4.965 -5 -4.965 c-1.125 0 -2.164 0.37 -3 0.992 m-1.707 2.297 a4.925 4.925 0 0 0 -0.293 1.676 v0.035 c0 0.961 1.696 1.764 3.956 1.956 M16.95 9.01 c3.02 0.739 5.05 2.123 5.05 3.714 c0 1.08 -0.931 2.063 -2.468 2.814 m-3 1 c-1.36 0.295 -2.9 0.462 -4.531 0.462 c-5.52 0 -10 -1.909 -10 -4.276 c0 -1.59 2.04 -2.985 5.07 -3.724 M0 0 h24 v24 H0 z";
				case IconKind.Ufo:
					return "M17 13 h0.01 M7 13 h0.01 M12 14 h0.01 M8.5 17 l-1.5 3 M15 17 l2 3 M7 9 c0 1.105 2.239 2 5 2 s5 -0.895 5 -2 v-0.035 c0 -2.742 -2.239 -4.965 -5 -4.965 s-5 2.223 -5 4.965 v0.035 M16.95 9.01 c3.02 0.739 5.05 2.123 5.05 3.714 c0 2.367 -4.48 4.276 -10 4.276 s-10 -1.909 -10 -4.276 c0 -1.59 2.04 -2.985 5.07 -3.724 M0 0 h24 v24 H0 z";
				case IconKind.UmbrellaFilled:
					return "M12 12 v6 a2 2 0 0 0 4 0 M4 12 a8 8 0 0 1 16 0 z M0 0 h24 v24 H0 z";
				case IconKind.UmbrellaOff:
					return "M3 3 l18 18 M12 12 v6 a2 2 0 1 0 4 0 M12 12 h-8 c0 -2.209 0.895 -4.208 2.342 -5.656 m2.382 -1.645 a8 8 0 0 1 11.276 7.301 l-4 0 M0 0 h24 v24 H0 z";
				case IconKind.Umbrella:
					return "M12 12 v6 a2 2 0 0 0 4 0 M4 12 a8 8 0 0 1 16 0 z M0 0 h24 v24 H0 z";
				case IconKind.Underline:
					return "M5 19 h14 M7 5 v5 a5 5 0 0 0 10 0 v-5 M0 0 h24 v24 H0 z";
				case IconKind.Unlink:
					return "M8 3 l0 2 M3 8 l2 0 M19 16 l2 0 M16 21 l0 -2 M14 10 a3.5 3.5 0 0 0 -5 0 l-4 4 a3.5 3.5 0 0 0 5 5 l0.5 -0.5 M10 14 a3.5 3.5 0 0 0 5 0 l4 -4 a3.5 3.5 0 0 0 -5 -5 l-0.5 0.5 M0 0 h24 v24 H0 z";
				case IconKind.Upload:
					return "M12 4 l0 12 M7 9 l5 -5 l5 5 M4 17 v2 a2 2 0 0 0 2 2 h12 a2 2 0 0 0 2 -2 v-2 M0 0 h24 v24 H0 z";
				case IconKind.Urgent:
					return "M6 16 m0 1 a1 1 0 0 1 1 -1 h10 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-10 a1 1 0 0 1 -1 -1 z M3 12 h1 m8 -9 v1 m8 8 h1 m-15.4 -6.4 l0.7 0.7 m12.1 -0.7 l-0.7 0.7 M8 16 v-4 a4 4 0 0 1 8 0 v4 M0 0 h24 v24 H0 z";
				case IconKind.Usb:
					return "M10 5.5 h4 l-2 -2.5 z M7 9 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M16 10 h2 v-2 h-2 z M12 14.5 l5 -2 v-2.5 M7 10 v3 l5 3 M12 17 v-11.5 M12 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.UserCheck:
					return "M16 11 l2 2 l4 -4 M3 21 v-2 a4 4 0 0 1 4 -4 h4 a4 4 0 0 1 4 4 v2 M9 7 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M0 0 h24 v24 H0 z";
				case IconKind.UserCircle:
					return "M6.168 18.849 a4 4 0 0 1 3.832 -2.849 h4 a4 4 0 0 1 3.834 2.855 M12 10 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.UserExclamation:
					return "M19 14 l0 0.01 M19 7 l0 3 M3 21 v-2 a4 4 0 0 1 4 -4 h4 a4 4 0 0 1 4 4 v2 M9 7 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M0 0 h24 v24 H0 z";
				case IconKind.UserMinus:
					return "M16 11 l6 0 M3 21 v-2 a4 4 0 0 1 4 -4 h4 a4 4 0 0 1 4 4 v2 M9 7 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M0 0 h24 v24 H0 z";
				case IconKind.UserOff:
					return "M3 3 l18 18 M6 21 v-2 a4 4 0 0 1 4 -4 h4 a4 4 0 0 1 1.147 0.167 m2.685 2.681 a4 4 0 0 1 0.168 1.152 v2 M14.274 10.291 a4 4 0 1 0 -5.554 -5.58 m-0.548 3.453 a4.01 4.01 0 0 0 2.62 2.65 M0 0 h24 v24 H0 z";
				case IconKind.UserPlus:
					return "M16 11 h6 m-3 -3 v6 M3 21 v-2 a4 4 0 0 1 4 -4 h4 a4 4 0 0 1 4 4 v2 M9 7 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M0 0 h24 v24 H0 z";
				case IconKind.UserSearch:
					return "M18.5 19.5 l2.5 2.5 M16.5 17.5 m-2.5 0 a2.5 2.5 0 1 0 5 0 a2.5 2.5 0 1 0 -5 0 M6 21 v-2 a4 4 0 0 1 4 -4 h1 M12 7 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M0 0 h24 v24 H0 z";
				case IconKind.UserX:
					return "M17 9 l4 4 m0 -4 l-4 4 M3 21 v-2 a4 4 0 0 1 4 -4 h4 a4 4 0 0 1 4 4 v2 M9 7 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M0 0 h24 v24 H0 z";
				case IconKind.User:
					return "M6 21 v-2 a4 4 0 0 1 4 -4 h4 a4 4 0 0 1 4 4 v2 M12 7 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M0 0 h24 v24 H0 z";
				case IconKind.Users:
					return "M21 21 v-2 a4 4 0 0 0 -3 -3.85 M16 3.13 a4 4 0 0 1 0 7.75 M3 21 v-2 a4 4 0 0 1 4 -4 h4 a4 4 0 0 1 4 4 v2 M9 7 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M0 0 h24 v24 H0 z";
				case IconKind.UvIndex:
					return "M6 16 v3 a2 2 0 1 0 4 0 v-3 M13 16 l2 5 h1 l2 -5 M12 4 v-1 M3 12 h1 m16 0 h1 m-15.4 -6.4 l0.7 0.7 m12.1 -0.7 l-0.7 0.7 m-9.7 5.7 a4 4 0 1 1 8 0 M0 0 h24 v24 H0 z";
				case IconKind.UxCircle:
					return "M14 14 l3 -4 M14 10 l3 4 M7 10 v2 a2 2 0 1 0 4 0 v-2 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.VaccineBottleOff:
					return "M3 3 l18 18 M11 15 h2 M7 18 h10 M7 12 h5 m4 0 h1 M8.7 8.705 a1.806 1.806 0 0 1 -0.2 0.045 c-0.866 0.144 -1.5 0.893 -1.5 1.77 v8.48 a2 2 0 0 0 2 2 h6 a2 2 0 0 0 2 -2 v-2 m0 -4 v-2.48 c0 -0.877 -0.634 -1.626 -1.5 -1.77 a1.795 1.795 0 0 1 -1.5 -1.77 v-0.98 M9 5 v-1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v1 a1 1 0 0 1 -1 1 h-4 M0 0 h24 v24 H0 z";
				case IconKind.VaccineBottle:
					return "M11 15 h2 M7 18 h10 M7 12 h10 M10 6 v0.98 c0 0.877 -0.634 1.626 -1.5 1.77 c-0.866 0.144 -1.5 0.893 -1.5 1.77 v8.48 a2 2 0 0 0 2 2 h6 a2 2 0 0 0 2 -2 v-8.48 c0 -0.877 -0.634 -1.626 -1.5 -1.77 a1.795 1.795 0 0 1 -1.5 -1.77 v-0.98 M9 3 m0 1 a1 1 0 0 1 1 -1 h4 a1 1 0 0 1 1 1 v1 a1 1 0 0 1 -1 1 h-4 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.VaccineOff:
					return "M3 3 l18 18 M3 21 l3 -3 M7.5 12.5 l1.5 1.5 M16.5 11.5 l-0.5 0.5 m-2 2 l-4 4 h-4 v-4 l4 -4 m2 -2 l0.5 -0.5 M11.5 6.5 l6 6 M19 5 l-4.5 4.5 M17 3 l4 4 M0 0 h24 v24 H0 z";
				case IconKind.Vaccine:
					return "M3 21 l3 -3 M10.5 9.5 l1.5 1.5 M7.5 12.5 l1.5 1.5 M16.5 11.5 l-6.5 6.5 h-4 v-4 l6.5 -6.5 M11.5 6.5 l6 6 M19 5 l-4.5 4.5 M17 3 l4 4 M0 0 h24 v24 H0 z";
				case IconKind.VacuumCleaner:
					return "M12 16 h0.01 M14 9 a2 2 0 1 1 -4 0 a2 2 0 0 1 4 0 z M21 12 a9 9 0 1 1 -18 0 a9 9 0 0 1 18 0 z M0 0 h24 v24 H0 z";
				case IconKind.VariableMinus:
					return "M16 19 h6 M8 16 c1.5 0 3 -2 4 -3.5 s2.5 -3.5 4 -3.5 M5 4 c-2.5 5 -2.5 10 0 16 m14 -16 c1.775 3.55 2.29 7.102 1.544 11.01 m-11.544 -6.01 h1 c1 0 1 1 2.016 3.527 c0.782 1.966 0.943 3 1.478 3.343 M8 16 c1.5 0 3 -2 4 -3.5 s2.5 -3.5 4 -3.5 M0 0 h24 v24 H0 z";
				case IconKind.VariableOff:
					return "M3 3 l18 18 M8 16 c1.5 0 3 -2 4 -3.5 m2.022 -2.514 c0.629 -0.582 1.304 -0.986 1.978 -0.986 M11.696 11.696 c0.095 0.257 0.2 0.533 0.32 0.831 c0.984 2.473 0.984 3.473 1.984 3.473 h1 M19 4 c1.959 3.917 2.383 7.834 1.272 12.232 m-0.983 3.051 c-0.093 0.238 -0.189 0.477 -0.289 0.717 M4.675 4.68 c-2.17 4.776 -2.062 9.592 0.325 15.32 M0 0 h24 v24 H0 z";
				case IconKind.VariablePlus:
					return "M19 16 v6 M16 19 h6 M8 16 c1.5 0 3 -2 4 -3.5 s2.5 -3.5 4 -3.5 M5 4 c-2.5 5 -2.5 10 0 16 m14 -16 c1.38 2.76 2 5.52 1.855 8.448 m-11.855 -3.448 h1 c1 0 1 1 2.016 3.527 c0.785 1.972 0.944 3.008 1.483 3.346 M0 0 h24 v24 H0 z";
				case IconKind.Variable:
					return "M8 16 c1.5 0 3 -2 4 -3.5 s2.5 -3.5 4 -3.5 M5 4 c-2.5 5 -2.5 10 0 16 m14 -16 c2.5 5 2.5 10 0 16 m-10 -11 h1 c1 0 1 1 2.016 3.527 c0.984 2.473 0.984 3.473 1.984 3.473 h1 M0 0 h24 v24 H0 z";
				case IconKind.VectorBezier2:
					return "M7 5.5 a5 6.5 0 0 1 5 6.5 a5 6.5 0 0 0 5 6.5 M15 5 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M9 19 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M10 19 l7 0 M7 5 l7 0 M17 17 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M3 3 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.VectorBezierArc:
					return "M5 10 a5 5 0 0 1 5 -5 M5 14 a5 5 0 0 0 5 5 M19 10 a5 5 0 0 0 -5 -5 M10 17 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M10 3 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M17 10 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M3 10 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.VectorBezierCircle:
					return "M5 10 a5 5 0 0 1 5 -5 M5 14 a5 5 0 0 0 5 5 M19 14 a5 5 0 0 1 -5 5 M19 10 a5 5 0 0 0 -5 -5 M10 17 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M10 3 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M17 10 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M3 10 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.VectorBezier:
					return "M21 8 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M3 8 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M20 8 l-6 0 M10 8 l-6 0 M14 8.5 a6 6 0 0 1 5 5.5 M10 8.5 a6 6 0 0 0 -5 5.5 M10 6 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M17 14 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M3 14 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.VectorOff:
					return "M3 3 l18 18 M7 19 h10 M9 5 h8 M19 7 v8 M5 7 v10 M3 17 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M20.72 20.693 a1 1 0 0 1 -0.72 0.307 h-2 a1 1 0 0 1 -1 -1 v-2 c0 -0.282 0.116 -0.536 0.304 -0.718 M17 3 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M6.68 6.733 a1 1 0 0 1 -0.68 0.267 h-2 a1 1 0 0 1 -1 -1 v-2 c0 -0.276 0.112 -0.527 0.293 -0.708 M0 0 h24 v24 H0 z";
				case IconKind.VectorSpline:
					return "M17 5 c-6.627 0 -12 5.373 -12 12 M3 17 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M17 3 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.VectorTriangleOff:
					return "M3 3 l18 18 M7 19 h10 M13.158 9.197 l-0.658 -1.197 M6.5 17.1 l3.749 -6.823 M20.705 20.709 a1 1 0 0 1 -0.705 0.291 h-2 a1 1 0 0 1 -1 -1 v-2 c0 -0.28 0.115 -0.532 0.3 -0.714 M3 17 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M10 6 v-1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-1 M0 0 h24 v24 H0 z";
				case IconKind.VectorTriangle:
					return "M7 19 l10 0 M17.5 17.1 l-5 -9.1 M6.5 17.1 l5 -9.1 M17 17 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M3 17 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M10 4 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.Vector:
					return "M7 19 l10 0 M7 5 l10 0 M19 7 l0 10 M5 7 l0 10 M3 17 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M17 17 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M17 3 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M3 3 m0 1 a1 1 0 0 1 1 -1 h2 a1 1 0 0 1 1 1 v2 a1 1 0 0 1 -1 1 h-2 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.Venus:
					return "M9 18 l6 0 M12 14 l0 7 M12 9 m-5 0 a5 5 0 1 0 10 0 a5 5 0 1 0 -10 0 M0 0 h24 v24 H0 z";
				case IconKind.VersionsFilled:
					return "M4 8 l0 8 M7 7 l0 10 M10 5 m0 2 a2 2 0 0 1 2 -2 h6 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-6 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.VersionsOff:
					return "M3 3 l18 18 M4 8 v8 M7 7 v10 M10.184 6.162 a2 2 0 0 1 1.816 -1.162 h6 a2 2 0 0 1 2 2 v9 m-1.185 2.827 a1.993 1.993 0 0 1 -0.815 0.173 h-6 a2 2 0 0 1 -2 -2 v-7 M0 0 h24 v24 H0 z";
				case IconKind.Versions:
					return "M4 8 l0 8 M7 7 l0 10 M10 5 m0 2 a2 2 0 0 1 2 -2 h6 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-6 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.VideoMinus:
					return "M7 12 l4 0 M3 6 m0 2 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 z M15 10 l4.553 -2.276 a1 1 0 0 1 1.447 0.894 v6.764 a1 1 0 0 1 -1.447 0.894 l-4.553 -2.276 v-4 z M0 0 h24 v24 H0 z";
				case IconKind.VideoOff:
					return "M10 6 h3 a2 2 0 0 1 2 2 v3 m0 4 v1 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 v-8 a2 2 0 0 1 2 -2 h1 M15 11 v-1 l4.553 -2.276 a1 1 0 0 1 1.447 0.894 v6.764 a1 1 0 0 1 -0.675 0.946 M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.VideoPlus:
					return "M9 10 l0 4 M7 12 l4 0 M3 6 m0 2 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 z M15 10 l4.553 -2.276 a1 1 0 0 1 1.447 0.894 v6.764 a1 1 0 0 1 -1.447 0.894 l-4.553 -2.276 v-4 z M0 0 h24 v24 H0 z";
				case IconKind.Video:
					return "M3 6 m0 2 a2 2 0 0 1 2 -2 h8 a2 2 0 0 1 2 2 v8 a2 2 0 0 1 -2 2 h-8 a2 2 0 0 1 -2 -2 z M15 10 l4.553 -2.276 a1 1 0 0 1 1.447 0.894 v6.764 a1 1 0 0 1 -1.447 0.894 l-4.553 -2.276 v-4 z M0 0 h24 v24 H0 z";
				case IconKind.View360Off:
					return "M3 3 l18 18 M8.32 8.349 c-3.136 0.625 -5.32 2.025 -5.32 3.651 c0 2.21 4.03 4 9 4 c1.286 0 2.51 -0.12 3.616 -0.336 m3.059 -0.98 c1.445 -0.711 2.325 -1.653 2.325 -2.684 c0 -2.21 -4.03 -4 -9 -4 M5.65 5.623 a9 9 0 1 0 12.71 12.745 m1.684 -2.328 a9 9 0 0 0 -12.094 -12.08 M8.335 8.388 a19 19 0 0 0 -0.335 3.612 c0 4.97 1.79 9 4 9 c1.622 0 3.018 -2.172 3.646 -5.294 m0.354 -3.706 c0 -4.97 -1.79 -9 -4 -9 c-1.035 0 -1.979 0.885 -2.689 2.337 M0 0 h24 v24 H0 z";
				case IconKind.View360:
					return "M3 12 c0 2.21 4.03 4 9 4 s9 -1.79 9 -4 s-4.03 -4 -9 -4 s-9 1.79 -9 4 z M12 12 m-4 0 a4 9 0 1 0 8 0 a4 9 0 1 0 -8 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.ViewfinderOff:
					return "M3 3 l18 18 M12 12 v0.01 M21 12 h-3 M3 12 h4 M12 21 v-3 M12 3 v4 M5.65 5.623 a9 9 0 1 0 12.71 12.745 m1.684 -2.328 a9 9 0 0 0 -12.094 -12.08 M0 0 h24 v24 H0 z";
				case IconKind.Viewfinder:
					return "M12 12 l0 0.01 M21 12 l-3 0 M3 12 l4 0 M12 21 l0 -3 M12 3 l0 4 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.ViewportNarrow:
					return "M9 18 v3 h6 v-3 M9 6 v-3 h6 v3 M21 12 h-7 l3 -3 m0 6 l-3 -3 M3 12 h7 l-3 -3 m0 6 l3 -3 M0 0 h24 v24 H0 z";
				case IconKind.ViewportWide:
					return "M3 18 v3 h18 v-3 M3 6 v-3 h18 v3 M14 12 h7 l-3 -3 m0 6 l3 -3 M10 12 h-7 l3 -3 m0 6 l-3 -3 M0 0 h24 v24 H0 z";
				case IconKind.Vinyl:
					return "M20 4 l-3.5 10 l-2.5 2 M20 4 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M12 12 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M16 3.937 a9 9 0 1 0 5 8.063 M0 0 h24 v24 H0 z";
				case IconKind.VipOff:
					return "M3 3 l18 18 M16 12 v-3 h2 a2 2 0 1 1 0 4 h-1 M12 12 v3 M4 9 l2 6 h1 l2 -6 M3 19 h16 M3 5 h2 m4 0 h12 M0 0 h24 v24 H0 z";
				case IconKind.Vip:
					return "M16 15 v-6 h2 a2 2 0 1 1 0 4 h-2 M12 9 v6 M4 9 l2 6 h1 l2 -6 M3 19 h18 M3 5 h18 M0 0 h24 v24 H0 z";
				case IconKind.VirusOff:
					return "M5.636 5.637 l-0.707 0.707 M3 13 v-2 M7 12 h-4 M6.343 19.071 l-1.413 -1.414 M8.465 15.536 l-2.829 2.828 M13 21 h-2 M12 17 v4 M18.364 18.363 l-0.707 0.707 M21 11 v2 M17 12 h4 M17.657 4.929 l1.414 1.414 M15.536 8.464 l2.828 -2.828 M11 3 h2 M12 7 v-4 M16.913 12.936 a5 5 0 0 0 -5.826 -5.853 M8.469 8.46 a5 5 0 0 0 7.058 7.084 M3 3 l18 18 M0 0 h24 v24 H0 z";
				case IconKind.VirusSearch:
					return "M19.5 19.5 l2.5 2.5 M17.5 17.5 m-2.5 0 a2.5 2.5 0 1 0 5 0 a2.5 2.5 0 1 0 -5 0 M4.929 6.343 l1.414 -1.413 M8.464 8.464 l-2.828 -2.828 M3 13 v-2 M7 12 h-4 M6.343 19.071 l-1.413 -1.414 M8.465 15.536 l-2.829 2.828 M13 21 h-2 M12 17 v4 M21 11 v2 M17 12 h4 M17.657 4.929 l1.414 1.414 M15.536 8.464 l2.828 -2.828 M11 3 h2 M12 7 v-4 M17 12 a5 5 0 1 0 -5 5 M0 0 h24 v24 H0 z";
				case IconKind.Virus:
					return "M4.929 6.343 l1.414 -1.413 M8.464 8.464 l-2.828 -2.828 M3 13 v-2 M7 12 h-4 M6.343 19.071 l-1.413 -1.414 M8.465 15.536 l-2.829 2.828 M13 21 h-2 M12 17 v4 M19.071 17.657 l-1.414 1.414 M15.535 15.536 l2.829 2.828 M21 11 v2 M17 12 h4 M17.657 4.929 l1.414 1.414 M15.536 8.464 l2.828 -2.828 M11 3 h2 M12 7 v-4 M12 12 m-5 0 a5 5 0 1 0 10 0 a5 5 0 1 0 -10 0 M0 0 h24 v24 H0 z";
				case IconKind.VocabularyOff:
					return "M3 3 l18 18 M16 11 h1 M16 7 h1 M7 11 h1 M12 5 v3 m0 4 v9 M7 3 h3 a2 2 0 0 1 2 2 a2 2 0 0 1 2 -2 h6 a1 1 0 0 1 1 1 v13 m-2 2 h-5 a2 2 0 0 0 -2 2 a2 2 0 0 0 -2 -2 h-6 a1 1 0 0 1 -1 -1 v-14 c0 -0.279 0.114 -0.53 0.298 -0.712 M0 0 h24 v24 H0 z";
				case IconKind.Vocabulary:
					return "M16 15 h1 M16 11 h1 M16 7 h1 M7 11 h1 M7 7 h1 M12 5 v16 M10 19 h-6 a1 1 0 0 1 -1 -1 v-14 a1 1 0 0 1 1 -1 h6 a2 2 0 0 1 2 2 a2 2 0 0 1 2 -2 h6 a1 1 0 0 1 1 1 v14 a1 1 0 0 1 -1 1 h-6 a2 2 0 0 0 -2 2 a2 2 0 0 0 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.Volume2:
					return "M6 15 h-2 a1 1 0 0 1 -1 -1 v-4 a1 1 0 0 1 1 -1 h2 l3.5 -4.5 a0.8 0.8 0 0 1 1.5 0.5 v14 a0.8 0.8 0 0 1 -1.5 0.5 l-3.5 -4.5 M15 8 a5 5 0 0 1 0 8 M0 0 h24 v24 H0 z";
				case IconKind.Volume3:
					return "M16 10 l4 4 m0 -4 l-4 4 M6 15 h-2 a1 1 0 0 1 -1 -1 v-4 a1 1 0 0 1 1 -1 h2 l3.5 -4.5 a0.8 0.8 0 0 1 1.5 0.5 v14 a0.8 0.8 0 0 1 -1.5 0.5 l-3.5 -4.5 M0 0 h24 v24 H0 z";
				case IconKind.VolumeOff:
					return "M3 3 l18 18 M9.069 5.054 l0.431 -0.554 a0.8 0.8 0 0 1 1.5 0.5 v2 m0 4 v8 a0.8 0.8 0 0 1 -1.5 0.5 l-3.5 -4.5 h-2 a1 1 0 0 1 -1 -1 v-4 a1 1 0 0 1 1 -1 h2 l1.294 -1.664 M17.7 5 a9 9 0 0 1 2.362 11.086 m-1.676 2.299 a9 9 0 0 1 -0.686 0.615 M15 8 a5 5 0 0 1 1.912 4.934 m-1.377 2.602 a5 5 0 0 1 -0.535 0.464 M0 0 h24 v24 H0 z";
				case IconKind.Volume:
					return "M6 15 h-2 a1 1 0 0 1 -1 -1 v-4 a1 1 0 0 1 1 -1 h2 l3.5 -4.5 a0.8 0.8 0 0 1 1.5 0.5 v14 a0.8 0.8 0 0 1 -1.5 0.5 l-3.5 -4.5 M17.7 5 a9 9 0 0 1 0 14 M15 8 a5 5 0 0 1 0 8 M0 0 h24 v24 H0 z";
				case IconKind.Walk:
					return "M6 12 l2 -3 l4 -1 l3 3 l3 1 M16 21 l-2 -4 l-3 -3 l1 -6 M7 21 l3 -4 M13 4 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.WallOff:
					return "M3 3 l18 18 M11 16 v4 M8 12 v4 M14 8 v2 M9 4 v1 M4 16 h12 M20 12 h-4 m-4 0 h-8 M4 8 h4 m4 0 h8 M8 4 h10 a2 2 0 0 1 2 2 v10 m-0.589 3.417 c-0.361 0.36 -0.86 0.583 -1.411 0.583 h-12 a2 2 0 0 1 -2 -2 v-12 c0 -0.55 0.222 -1.047 0.58 -1.409 M0 0 h24 v24 H0 z";
				case IconKind.Wall:
					return "M11 16 v4 M16 12 v4 M8 12 v4 M14 8 v4 M9 4 v4 M4 16 h16 M20 12 h-16 M4 8 h16 M4 4 m0 2 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-12 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.WalletOff:
					return "M3 3 l18 18 M16 12 h4 v4 m-4 0 a2 2 0 0 1 -2 -2 M19 19 a1 1 0 0 1 -1 1 h-12 a2 2 0 0 1 -2 -2 v-12 M17 8 v-3 a1 1 0 0 0 -1 -1 h-8 m-3.413 0.584 a2 2 0 0 0 1.413 3.416 h2 m4 0 h6 a1 1 0 0 1 1 1 v3 M0 0 h24 v24 H0 z";
				case IconKind.Wallet:
					return "M20 12 v4 h-4 a2 2 0 0 1 0 -4 h4 M17 8 v-3 a1 1 0 0 0 -1 -1 h-10 a2 2 0 0 0 0 4 h12 a1 1 0 0 1 1 1 v3 m0 4 v3 a1 1 0 0 1 -1 1 h-12 a2 2 0 0 1 -2 -2 v-12 M0 0 h24 v24 H0 z";
				case IconKind.WallpaperOff:
					return "M3 3 l18 18 M8 18 v-10 m-3.427 -3.402 c-0.353 0.362 -0.573 0.856 -0.573 1.402 v12 M6 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M10 6 h8 a2 2 0 0 1 2 2 v8 m-0.58 3.409 a2 2 0 0 1 -1.42 0.591 h-12 M0 0 h24 v24 H0 z";
				case IconKind.Wallpaper:
					return "M8 18 v-12 a2 2 0 1 0 -4 0 v12 M6 18 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M8 6 h10 a2 2 0 0 1 2 2 v10 a2 2 0 0 1 -2 2 h-12 M0 0 h24 v24 H0 z";
				case IconKind.WandOff:
					return "M3 3 l18 18 M18.418 14.41 c0.36 -0.36 0.582 -0.86 0.582 -1.41 a2 2 0 0 0 2 2 c-0.555 0 -1.056 0.226 -1.419 0.59 M8.433 4.395 c0.35 -0.36 0.567 -0.852 0.567 -1.395 a2 2 0 0 0 2 2 c-0.554 0 -1.055 0.225 -1.417 0.589 M15 6 l3 3 M10.5 10.5 l-7.5 7.5 l3 3 l7.5 -7.5 m2 -2 l5.5 -5.5 l-3 -3 l-5.5 5.5 M0 0 h24 v24 H0 z";
				case IconKind.Wand:
					return "M19 13 a2 2 0 0 0 2 2 a2 2 0 0 0 -2 2 a2 2 0 0 0 -2 -2 a2 2 0 0 0 2 -2 M9 3 a2 2 0 0 0 2 2 a2 2 0 0 0 -2 2 a2 2 0 0 0 -2 -2 a2 2 0 0 0 2 -2 M15 6 l3 3 M6 21 l15 -15 l-3 -3 l-15 15 l3 3 M0 0 h24 v24 H0 z";
				case IconKind.WashDry1:
					return "M12 12 h0.01 M12 12 m-6 0 a6 6 0 1 0 12 0 a6 6 0 1 0 -12 0 M3 3 m0 3 a3 3 0 0 1 3 -3 h12 a3 3 0 0 1 3 3 v12 a3 3 0 0 1 -3 3 h-12 a3 3 0 0 1 -3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.WashDry2:
					return "M14 12 h0.01 M10 12 h0.01 M12 12 m-6 0 a6 6 0 1 0 12 0 a6 6 0 1 0 -12 0 M3 3 m0 3 a3 3 0 0 1 3 -3 h12 a3 3 0 0 1 3 3 v12 a3 3 0 0 1 -3 3 h-12 a3 3 0 0 1 -3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.WashDry3:
					return "M15 12 h0.01 M9 12 h0.01 M12 12 h0.01 M12 12 m-6 0 a6 6 0 1 0 12 0 a6 6 0 1 0 -12 0 M3 3 m0 3 a3 3 0 0 1 3 -3 h12 a3 3 0 0 1 3 3 v12 a3 3 0 0 1 -3 3 h-12 a3 3 0 0 1 -3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.WashDryA:
					return "M15 13 h-6 M9 16 v-4.8 c0 -1.657 1.343 -3.2 3 -3.2 s3 1.543 3 3.2 v4.8 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.WashDryDip:
					return "M8 7 v10 M16 7 v10 M12 7 v10 M3 3 m0 3 a3 3 0 0 1 3 -3 h12 a3 3 0 0 1 3 3 v12 a3 3 0 0 1 -3 3 h-12 a3 3 0 0 1 -3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.WashDryF:
					return "M13 12 h-3 M10 16 v-8 h4 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.WashDryHang:
					return "M4 4.01 c5.333 5.323 10.667 5.32 16 -0.01 M3 3 m0 3 a3 3 0 0 1 3 -3 h12 a3 3 0 0 1 3 3 v12 a3 3 0 0 1 -3 3 h-12 a3 3 0 0 1 -3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.WashDryOff:
					return "M3 3 l18 18 M20.116 20.127 a2.99 2.99 0 0 1 -2.116 0.873 h-12 a3 3 0 0 1 -3 -3 v-12 c0 -0.827 0.335 -1.576 0.877 -2.12 m3.123 -0.88 h11 a3 3 0 0 1 3 3 v11 M0 0 h24 v24 H0 z";
				case IconKind.WashDryP:
					return "M10 16 v-8 h2.5 a2.5 2.5 0 1 1 0 5 h-2.5 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.WashDryShade:
					return "M3 17 l14 -14 M3 11 l8 -8 M3 3 m0 3 a3 3 0 0 1 3 -3 h12 a3 3 0 0 1 3 3 v12 a3 3 0 0 1 -3 3 h-12 a3 3 0 0 1 -3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.WashDryW:
					return "M8 8 l1.5 8 h1 l1.5 -6 l1.5 6 h1 l1.5 -8 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.WashDry:
					return "M3 3 m0 3 a3 3 0 0 1 3 -3 h12 a3 3 0 0 1 3 3 v12 a3 3 0 0 1 -3 3 h-12 a3 3 0 0 1 -3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.WashDrycleanOff:
					return "M3 3 l18 18 M20.048 16.033 a9 9 0 0 0 -12.094 -12.075 m-2.321 1.682 a9 9 0 0 0 12.733 12.723 M0 0 h24 v24 H0 z";
				case IconKind.WashDryclean:
					return "M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.WashGentle:
					return "M5 21 h14 M5 18 h14 M3 3 l1.721 10.329 a2 2 0 0 0 1.973 1.671 h10.612 a2 2 0 0 0 1.973 -1.671 l1.721 -10.329 M3.486 5.965 c0.168 0.02 0.34 0.033 0.514 0.035 c0.79 0.009 1.539 -0.178 2 -0.5 c0.461 -0.32 1.21 -0.507 2 -0.5 c0.79 -0.007 1.539 0.18 2 0.5 c0.461 0.322 1.21 0.509 2 0.5 c0.79 0.009 1.539 -0.178 2 -0.5 c0.461 -0.32 1.21 -0.507 2 -0.5 c0.79 -0.007 1.539 0.18 2 0.5 c0.461 0.322 1.21 0.509 2 0.5 c0.17 0 0.339 -0.014 0.503 -0.034 M0 0 h24 v24 H0 z";
				case IconKind.WashMachine:
					return "M8 14 c1.333 -0.667 2.667 -0.667 4 0 c1.333 0.667 2.667 0.667 4 0 M14 6 h2 M11 6 h0.01 M8 6 h0.01 M12 14 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M5 3 m0 2 a2 2 0 0 1 2 -2 h10 a2 2 0 0 1 2 2 v14 a2 2 0 0 1 -2 2 h-10 a2 2 0 0 1 -2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.WashOff:
					return "M3 3 l18 18 M3.486 8.965 c0.168 0.02 0.34 0.033 0.514 0.035 c0.79 0.009 1.539 -0.178 2 -0.5 c0.461 -0.32 1.21 -0.507 2 -0.5 m4.92 0.919 c0.428 -0.083 0.805 -0.227 1.08 -0.418 c0.461 -0.322 1.21 -0.508 2 -0.5 c0.79 -0.008 1.539 0.178 2 0.5 c0.461 0.32 1.21 0.508 2 0.5 c0.17 0 0.339 -0.015 0.503 -0.035 M3 6 l1.721 10.329 a2 2 0 0 0 1.973 1.671 h10.612 c0.208 0 0.41 -0.032 0.6 -0.092 m1.521 -2.472 l1.573 -9.436 M0 0 h24 v24 H0 z";
				case IconKind.WashPress:
					return "M5 20 h14 M3 5 l1.721 10.329 a2 2 0 0 0 1.973 1.671 h10.612 a2 2 0 0 0 1.973 -1.671 l1.721 -10.329 M3.486 7.965 c0.168 0.02 0.34 0.033 0.514 0.035 c0.79 0.009 1.539 -0.178 2 -0.5 c0.461 -0.32 1.21 -0.507 2 -0.5 c0.79 -0.007 1.539 0.18 2 0.5 c0.461 0.322 1.21 0.509 2 0.5 c0.79 0.009 1.539 -0.178 2 -0.5 c0.461 -0.32 1.21 -0.507 2 -0.5 c0.79 -0.007 1.539 0.18 2 0.5 c0.461 0.322 1.21 0.509 2 0.5 c0.17 0 0.339 -0.014 0.503 -0.034 M0 0 h24 v24 H0 z";
				case IconKind.WashTemperature1:
					return "M12 13 h0.01 M3.486 8.965 c0.168 0.02 0.34 0.033 0.514 0.035 c0.79 0.009 1.539 -0.178 2 -0.5 c0.461 -0.32 1.21 -0.507 2 -0.5 c0.79 -0.007 1.539 0.18 2 0.5 c0.461 0.322 1.21 0.509 2 0.5 c0.79 0.009 1.539 -0.178 2 -0.5 c0.461 -0.32 1.21 -0.507 2 -0.5 c0.79 -0.007 1.539 0.18 2 0.5 c0.461 0.322 1.21 0.509 2 0.5 c0.17 0 0.339 -0.014 0.503 -0.034 M3 6 l1.721 10.329 a2 2 0 0 0 1.973 1.671 h10.612 a2 2 0 0 0 1.973 -1.671 l1.721 -10.329 M0 0 h24 v24 H0 z";
				case IconKind.WashTemperature2:
					return "M10 13 h0.01 M14 13 h0.01 M3 6 l1.721 10.329 a2 2 0 0 0 1.973 1.671 h10.612 a2 2 0 0 0 1.973 -1.671 l1.721 -10.329 M3.486 8.965 c0.168 0.02 0.34 0.033 0.514 0.035 c0.79 0.009 1.539 -0.178 2 -0.5 c0.461 -0.32 1.21 -0.507 2 -0.5 c0.79 -0.007 1.539 0.18 2 0.5 c0.461 0.322 1.21 0.509 2 0.5 c0.79 0.009 1.539 -0.178 2 -0.5 c0.461 -0.32 1.21 -0.507 2 -0.5 c0.79 -0.007 1.539 0.18 2 0.5 c0.461 0.322 1.21 0.509 2 0.5 c0.17 0 0.339 -0.014 0.503 -0.034 M0 0 h24 v24 H0 z";
				case IconKind.WashTemperature3:
					return "M9 13 h0.01 M15 13 h0.01 M12 13 h0.01 M3 6 l1.721 10.329 a2 2 0 0 0 1.973 1.671 h10.612 a2 2 0 0 0 1.973 -1.671 l1.721 -10.329 M3.486 8.965 c0.168 0.02 0.34 0.033 0.514 0.035 c0.79 0.009 1.539 -0.178 2 -0.5 c0.461 -0.32 1.21 -0.507 2 -0.5 c0.79 -0.007 1.539 0.18 2 0.5 c0.461 0.322 1.21 0.509 2 0.5 c0.79 0.009 1.539 -0.178 2 -0.5 c0.461 -0.32 1.21 -0.507 2 -0.5 c0.79 -0.007 1.539 0.18 2 0.5 c0.461 0.322 1.21 0.509 2 0.5 c0.17 0 0.339 -0.014 0.503 -0.034 M0 0 h24 v24 H0 z";
				case IconKind.WashTemperature4:
					return "M10 12 h0.01 M14 12 h0.01 M14 15 h0.01 M10 15 h0.01 M3 6 l1.721 10.329 a2 2 0 0 0 1.973 1.671 h10.612 a2 2 0 0 0 1.973 -1.671 l1.721 -10.329 M3.486 8.965 c0.168 0.02 0.34 0.033 0.514 0.035 c0.79 0.009 1.539 -0.178 2 -0.5 c0.461 -0.32 1.21 -0.507 2 -0.5 c0.79 -0.007 1.539 0.18 2 0.5 c0.461 0.322 1.21 0.509 2 0.5 c0.79 0.009 1.539 -0.178 2 -0.5 c0.461 -0.32 1.21 -0.507 2 -0.5 c0.79 -0.007 1.539 0.18 2 0.5 c0.461 0.322 1.21 0.509 2 0.5 c0.17 0 0.339 -0.014 0.503 -0.034 M0 0 h24 v24 H0 z";
				case IconKind.WashTemperature5:
					return "M3.486 8.965 c0.168 0.02 0.34 0.033 0.514 0.035 c0.79 0.009 1.539 -0.178 2 -0.5 c0.461 -0.32 1.21 -0.507 2 -0.5 c0.79 -0.007 1.539 0.18 2 0.5 c0.461 0.322 1.21 0.509 2 0.5 c0.79 0.009 1.539 -0.178 2 -0.5 c0.461 -0.32 1.21 -0.507 2 -0.5 c0.79 -0.007 1.539 0.18 2 0.5 c0.461 0.322 1.21 0.509 2 0.5 c0.17 0 0.339 -0.014 0.503 -0.034 M9 12 h0.01 M12 12 h0.01 M15 12 h0.01 M14 15 h0.01 M3 6 l1.721 10.329 a2 2 0 0 0 1.973 1.671 h10.612 a2 2 0 0 0 1.973 -1.671 l1.721 -10.329 M10 15 h0.01 M0 0 h24 v24 H0 z";
				case IconKind.WashTemperature6:
					return "M3.486 8.965 c0.168 0.02 0.34 0.033 0.514 0.035 c0.79 0.009 1.539 -0.178 2 -0.5 c0.461 -0.32 1.21 -0.507 2 -0.5 c0.79 -0.007 1.539 0.18 2 0.5 c0.461 0.322 1.21 0.509 2 0.5 c0.79 0.009 1.539 -0.178 2 -0.5 c0.461 -0.32 1.21 -0.507 2 -0.5 c0.79 -0.007 1.539 0.18 2 0.5 c0.461 0.322 1.21 0.509 2 0.5 c0.17 0 0.339 -0.014 0.503 -0.034 M9 12 h0.01 M12 12 h0.01 M15 12 h0.01 M15 15 h0.01 M12 15 h0.01 M3 6 l1.721 10.329 a2 2 0 0 0 1.973 1.671 h10.612 a2 2 0 0 0 1.973 -1.671 l1.721 -10.329 M9 15 h0.01 M0 0 h24 v24 H0 z";
				case IconKind.WashTumbleDry:
					return "M12 12 m-6 0 a6 6 0 1 0 12 0 a6 6 0 1 0 -12 0 M3 3 m0 3 a3 3 0 0 1 3 -3 h12 a3 3 0 0 1 3 3 v12 a3 3 0 0 1 -3 3 h-12 a3 3 0 0 1 -3 -3 z M0 0 h24 v24 H0 z";
				case IconKind.WashTumbleOff:
					return "M3 3 l18 18 M17.744 13.74 a6 6 0 0 0 -7.486 -7.482 m-2.499 1.497 a6 6 0 1 0 8.48 8.49 M20.116 20.127 a2.99 2.99 0 0 1 -2.116 0.873 h-12 a3 3 0 0 1 -3 -3 v-12 c0 -0.827 0.335 -1.576 0.877 -2.12 m3.123 -0.88 h11 a3 3 0 0 1 3 3 v11 M0 0 h24 v24 H0 z";
				case IconKind.Wash:
					return "M3 6 l1.721 10.329 a2 2 0 0 0 1.973 1.671 h10.612 a2 2 0 0 0 1.973 -1.671 l1.721 -10.329 M3.486 8.965 c0.168 0.02 0.34 0.033 0.514 0.035 c0.79 0.009 1.539 -0.178 2 -0.5 c0.461 -0.32 1.21 -0.507 2 -0.5 c0.79 -0.007 1.539 0.18 2 0.5 c0.461 0.322 1.21 0.509 2 0.5 c0.79 0.009 1.539 -0.178 2 -0.5 c0.461 -0.32 1.21 -0.507 2 -0.5 c0.79 -0.007 1.539 0.18 2 0.5 c0.461 0.322 1.21 0.509 2 0.5 c0.17 0 0.339 -0.014 0.503 -0.034 M0 0 h24 v24 H0 z";
				case IconKind.WaveSawTool:
					return "M3 12 h5 l4 8 v-16 l4 8 h5 M0 0 h24 v24 H0 z";
				case IconKind.WaveSine:
					return "M21 12 h-2 c-0.894 0 -1.662 -0.857 -1.761 -2 c-0.296 -3.45 -0.749 -6 -2.749 -6 s-2.5 3.582 -2.5 8 s-0.5 8 -2.5 8 s-2.452 -2.547 -2.749 -6 c-0.1 -1.147 -0.867 -2 -1.763 -2 h-2 M0 0 h24 v24 H0 z";
				case IconKind.WaveSquare:
					return "M3 12 h5 v8 h4 v-16 h4 v8 h5 M0 0 h24 v24 H0 z";
				case IconKind.WebhookOff:
					return "M3 3 l18 18 M16 8 a4 4 0 0 0 -6.824 -2.833 m-1.176 2.833 c0 1.506 0.77 2.818 2 3.5 l-3 5.5 M15.066 20.502 a4 4 0 0 0 4.763 -0.675 m1.171 -2.827 a4 4 0 0 0 -4 -4 M4.876 13.61 a4 4 0 1 0 6.124 3.39 h6 M0 0 h24 v24 H0 z";
				case IconKind.Webhook:
					return "M16 8 a4 4 0 1 0 -8 0 c0 1.506 0.77 2.818 2 3.5 l-3 5.5 M15.066 20.502 a4 4 0 1 0 1.934 -7.502 c-0.706 0 -1.424 0.179 -2 0.5 l-3 -5.5 M4.876 13.61 a4 4 0 1 0 6.124 3.39 h6 M0 0 h24 v24 H0 z";
				case IconKind.Weight:
					return "M6.835 9 h10.33 a1 1 0 0 1 0.984 0.821 l1.637 9 a1 1 0 0 1 -0.984 1.179 h-13.604 a1 1 0 0 1 -0.984 -1.179 l1.637 -9 a1 1 0 0 1 0.984 -0.821 z M12 6 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.WheelchairOff:
					return "M3 3 l18 18 M15 8 v3 M6 8 h2 m4 0 h5 M6 6 v5 M14 14 h-1.4 M17.582 17.59 a2 2 0 0 0 2.833 2.824 M8 16 m-5 0 a5 5 0 1 0 10 0 a5 5 0 1 0 -10 0 M0 0 h24 v24 H0 z";
				case IconKind.Wheelchair:
					return "M15 8 v6 M6 8 h11 M3 3 h1 a2 2 0 0 1 2 2 v6 M19 17 a3 3 0 0 0 -3 -3 h-3.4 M19 19 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M8 16 m-5 0 a5 5 0 1 0 10 0 a5 5 0 1 0 -10 0 M0 0 h24 v24 H0 z";
				case IconKind.Whirl:
					return "M14 12 c0 -3.314 -2.462 -6 -5.5 -6 s-5.5 2.686 -5.5 6 M12 14 c3.314 0 6 -2.462 6 -5.5 s-2.686 -5.5 -6 -5.5 M21 12 c0 3.314 -2.462 6 -5.5 6 s-5.5 -2.686 -5.5 -6 M12 21 c-3.314 0 -6 -2.462 -6 -5.5 s2.686 -5.5 6 -5.5 M14 12 a2 2 0 1 0 -4 0 a2 2 0 0 0 4 0 z M0 0 h24 v24 H0 z";
				case IconKind.Wifi0:
					return "M12 18 l0.01 0 M0 0 h24 v24 H0 z";
				case IconKind.Wifi1:
					return "M9.172 15.172 a4 4 0 0 1 5.656 0 M12 18 l0.01 0 M0 0 h24 v24 H0 z";
				case IconKind.Wifi2:
					return "M6.343 12.343 a8 8 0 0 1 11.314 0 M9.172 15.172 a4 4 0 0 1 5.656 0 M12 18 l0.01 0 M0 0 h24 v24 H0 z";
				case IconKind.WifiOff:
					return "M3 3 l18 18 M3.515 9.515 a12 12 0 0 1 3.544 -2.455 m3.101 -0.92 a12 12 0 0 1 10.325 3.374 M6.343 12.343 a7.963 7.963 0 0 1 3.864 -2.14 m4.163 0.155 a7.965 7.965 0 0 1 3.287 2 M9.172 15.172 a4 4 0 0 1 5.656 0 M12 18 l0.01 0 M0 0 h24 v24 H0 z";
				case IconKind.Wifi:
					return "M3.515 9.515 c4.686 -4.687 12.284 -4.687 17 0 M6.343 12.343 a8 8 0 0 1 11.314 0 M9.172 15.172 a4 4 0 0 1 5.656 0 M12 18 l0.01 0 M0 0 h24 v24 H0 z";
				case IconKind.WindOff:
					return "M3 3 l18 18 M4 16 h5.5 a2.5 2.5 0 1 1 -2.34 3.24 M16 12 h2.5 a2.5 2.5 0 0 1 1.801 4.282 M3 12 h9 M5 8 h3 m4 0 h1.5 a2.5 2.5 0 1 0 -2.34 -3.24 M0 0 h24 v24 H0 z";
				case IconKind.Wind:
					return "M4 16 h5.5 a2.5 2.5 0 1 1 -2.34 3.24 M3 12 h15.5 a2.5 2.5 0 1 1 -2.34 3.24 M5 8 h8.5 a2.5 2.5 0 1 0 -2.34 -3.24 M0 0 h24 v24 H0 z";
				case IconKind.WindmillFilled:
					return "M12 12 c0 -2.76 -2.01 -5 -4.5 -5 s-4.5 2.24 -4.5 5 h9 z M12 12 c-2.76 0 -5 2.01 -5 4.5 s2.24 4.5 5 4.5 v-9 z M12 12 c0 2.76 2.01 5 4.5 5 s4.5 -2.24 4.5 -5 h-9 z M12 12 c2.76 0 5 -2.01 5 -4.5 s-2.24 -4.5 -5 -4.5 v9 z M0 0 h24 v24 H0 z";
				case IconKind.WindmillOff:
					return "M3 3 l18 18 M6.981 7.033 c-2.244 0.285 -3.981 2.402 -3.981 4.967 h9 M12 12 c-2.76 0 -5 2.01 -5 4.5 s2.24 4.5 5 4.5 v-9 z M12 12 c0 2.76 2.01 5 4.5 5 c0.166 0 0.33 -0.01 0.49 -0.03 m2.624 -1.36 c0.856 -0.91 1.386 -2.19 1.386 -3.61 h-5 M15.061 11.06 c1.18 -0.824 1.939 -2.11 1.939 -3.56 c0 -2.49 -2.24 -4.5 -5 -4.5 v5 M0 0 h24 v24 H0 z";
				case IconKind.Windmill:
					return "M12 12 c0 -2.76 -2.01 -5 -4.5 -5 s-4.5 2.24 -4.5 5 h9 z M12 12 c-2.76 0 -5 2.01 -5 4.5 s2.24 4.5 5 4.5 v-9 z M12 12 c0 2.76 2.01 5 4.5 5 s4.5 -2.24 4.5 -5 h-9 z M12 12 c2.76 0 5 -2.01 5 -4.5 s-2.24 -4.5 -5 -4.5 v9 z M0 0 h24 v24 H0 z";
				case IconKind.WindowMaximize:
					return "M16 8 l-5 5 M12 8 h4 v4 M4 12 v-6 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-6 M3 16 m0 1 a1 1 0 0 1 1 -1 h3 a1 1 0 0 1 1 1 v3 a1 1 0 0 1 -1 1 h-3 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.WindowMinimize:
					return "M11 13 l5 -5 M15 13 h-4 v-4 M4 12 v-6 a2 2 0 0 1 2 -2 h12 a2 2 0 0 1 2 2 v12 a2 2 0 0 1 -2 2 h-6 M3 16 m0 1 a1 1 0 0 1 1 -1 h3 a1 1 0 0 1 1 1 v3 a1 1 0 0 1 -1 1 h-3 a1 1 0 0 1 -1 -1 z M0 0 h24 v24 H0 z";
				case IconKind.WindowOff:
					return "M3 3 l18 18 M12 3 v5 m0 4 v9 M5 13 h8 m4 0 h2 M6.166 6.19 a6.903 6.903 0 0 0 -1.166 3.81 v10 a1 1 0 0 0 1 1 h12 a1 1 0 0 0 1 -1 v-1 m0 -4 v-5 c0 -3.728 -3.134 -7 -7 -7 a6.86 6.86 0 0 0 -3.804 1.158 M0 0 h24 v24 H0 z";
				case IconKind.Window:
					return "M12 3 l0 18 M5 13 l14 0 M12 3 c-3.866 0 -7 3.272 -7 7 v10 a1 1 0 0 0 1 1 h12 a1 1 0 0 0 1 -1 v-10 c0 -3.728 -3.134 -7 -7 -7 z M0 0 h24 v24 H0 z";
				case IconKind.Windsock:
					return "M4 21 h4 M14 6 v4 M10 5.5 v5 M6 11 l12 -1 v-4 l-12 -1 M6 3 v18 M0 0 h24 v24 H0 z";
				case IconKind.WiperWash:
					return "M20 6 a4 4 0 0 0 -0.4 -1.8 M15 2.1 a4 4 0 0 1 2 0 M12 6 a4 4 0 0 1 0.4 -1.8 M12 6 a4 4 0 0 0 -0.4 -1.8 M7 2.1 a4 4 0 0 1 2 0 M4 6 a4 4 0 0 1 0.4 -1.8 M12 20 l0 -14 M3 11 l5.5 5.5 a5 5 0 0 1 7 0 l5.5 -5.5 a12 12 0 0 0 -18 0 M12 20 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.Wiper:
					return "M12 18 l-2.2 -12.8 M3 9 l5.5 5.5 a5 5 0 0 1 7 0 l5.5 -5.5 a12 12 0 0 0 -18 0 M12 18 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.Woman:
					return "M12 4 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M19 11 c-1.667 -1.333 -3.333 -2 -5 -2 M5 11 c1.667 -1.333 3.333 -2 5 -2 M8 16 h8 l-2 -7 h-4 z M14 16 v5 M10 16 v5 M0 0 h24 v24 H0 z";
				case IconKind.Wood:
					return "M14 16 v1 M10 12.5 v1.5 M18 5.5 v4.626 a1.415 1.415 0 0 1 1.683 2.18 l-0.097 0.108 l-1.586 1.586 v4 c0 1.61 -2.54 2.925 -5.725 3 l-0.275 0 c-3.314 0 -6 -1.343 -6 -3 v-2 l-1.586 -1.586 a1.414 1.414 0 0 1 1.586 -2.287 v-6.627 M12 5.5 m-6 0 a6 2.5 0 1 0 12 0 a6 2.5 0 1 0 -12 0 M0 0 h24 v24 H0 z";
				case IconKind.WorldDownload:
					return "M18 14 v7 m-3 -3 l3 3 l3 -3 M12.5 3 c1.719 2.755 2.5 5.876 2.5 9 M11.578 3 a17 17 0 0 0 0 18 M3.6 15 h8.4 M3.6 9 h16.8 M21 12 a9 9 0 1 0 -9 9 M0 0 h24 v24 H0 z";
				case IconKind.WorldLatitude:
					return "M4.6 17 l14.8 0 M3 12 l18 0 M4.6 7 l14.8 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.WorldLongitude:
					return "M12 3 l0 18 M12.5 3 a11.2 11.2 0 0 1 0 18 M11.5 3 a11.2 11.2 0 0 0 0 18 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.WorldOff:
					return "M3 3 l18 18 M8.335 8.388 a19 19 0 0 0 -0.335 3.612 c0 4.97 1.79 9 4 9 c1.622 0 3.018 -2.172 3.646 -5.294 m0.354 -3.706 c0 -4.97 -1.79 -9 -4 -9 c-1.035 0 -1.979 0.885 -2.689 2.337 M3.6 15 h11.4 m4 0 h1.4 M5.65 5.623 a9 9 0 1 0 12.71 12.745 m1.684 -2.328 a9 9 0 0 0 -12.094 -12.08 M3.6 9 h5.4 m4 0 h7.4 M0 0 h24 v24 H0 z";
				case IconKind.WorldUpload:
					return "M18 21 v-7 m3 3 l-3 -3 l-3 3 M12.5 3 c1.719 2.755 2.5 5.876 2.5 9 M11.578 3 a17 17 0 0 0 0 18 M3.6 15 h8.4 M3.6 9 h16.8 M21 12 a9 9 0 1 0 -9 9 M0 0 h24 v24 H0 z";
				case IconKind.WorldWww:
					return "M9.5 10 l1 4 l1.5 -4 l1.5 4 l1 -4 M17 10 l1 4 l1.5 -4 l1.5 4 l1 -4 M2 10 l1 4 l1.5 -4 l1.5 4 l1 -4 M12.5 21 a16.989 16.989 0 0 0 1.828 -4 M11.5 21 a16.989 16.989 0 0 1 -1.826 -4 M19.5 17 a9 9 0 0 1 -7.5 4 a8.991 8.991 0 0 1 -7.484 -4 M12.5 3 a16.989 16.989 0 0 1 1.828 4 M11.5 3 a16.989 16.989 0 0 0 -1.826 4 M19.5 7 a9 9 0 0 0 -7.5 -4 a8.991 8.991 0 0 0 -7.484 4 M0 0 h24 v24 H0 z";
				case IconKind.World:
					return "M12.5 3 a17 17 0 0 1 0 18 M11.5 3 a17 17 0 0 0 0 18 M3.6 15 l16.8 0 M3.6 9 l16.8 0 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.WreckingBall:
					return "M19 11 v-7 l-6 7 M5 15 v-2 a1 1 0 0 1 1 -1 h7 M8 12 v-5 h2 a3 3 0 0 1 3 3 v5 M4 15 l9 0 M13 19 l-9 0 M13 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M4 17 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M19 13 m-2 0 a2 2 0 1 0 4 0 a2 2 0 1 0 -4 0 M0 0 h24 v24 H0 z";
				case IconKind.WritingOff:
					return "M3 3 l18 18 M18 19 h-13 a2 2 0 1 1 0 -4 h4 a2 2 0 1 0 0 -4 h-3 M16 16 v1 l2 2 l0.5 -0.5 m1.5 -2.5 v-11 c0 -1.121 -0.879 -2 -2 -2 s-2 0.879 -2 2 v7 M16 7 h4 M0 0 h24 v24 H0 z";
				case IconKind.WritingSignOff:
					return "M3 3 l18 18 M16 7 h4 M16 16 v1 l2 2 l0.5 -0.5 m1.5 -2.5 v-11 c0 -1.121 -0.879 -2 -2 -2 s-2 0.879 -2 2 v7 M3 19 c3.333 -2 5 -4 5 -6 c0 -3 -1 -3 -2 -3 s-2.032 1.085 -2 3 c0.034 2.048 1.658 2.877 2.5 4 c1.5 2 2.5 2.5 3.5 1 c0.667 -1 1.167 -1.833 1.5 -2.5 c1 2.333 2.333 3.5 4 3.5 h2.5 M0 0 h24 v24 H0 z";
				case IconKind.WritingSign:
					return "M16 7 h4 M20 17 v-12 c0 -1.121 -0.879 -2 -2 -2 s-2 0.879 -2 2 v12 l2 2 l2 -2 z M3 19 c3.333 -2 5 -4 5 -6 c0 -3 -1 -3 -2 -3 s-2.032 1.085 -2 3 c0.034 2.048 1.658 2.877 2.5 4 c1.5 2 2.5 2.5 3.5 1 c0.667 -1 1.167 -1.833 1.5 -2.5 c1 2.333 2.333 3.5 4 3.5 h2.5 M0 0 h24 v24 H0 z";
				case IconKind.Writing:
					return "M18 19 h-13 a2 2 0 1 1 0 -4 h4 a2 2 0 1 0 0 -4 h-3 M16 7 h4 M20 17 v-12 c0 -1.121 -0.879 -2 -2 -2 s-2 0.879 -2 2 v12 l2 2 l2 -2 z M0 0 h24 v24 H0 z";
				case IconKind.X:
					return "M6 6 l12 12 M18 6 l-12 12 M0 0 h24 v24 H0 z";
				case IconKind.XboxA:
					return "M14 14 h-4 M15 16 l-3 -8 l-3 8 M12 21 a9 9 0 0 0 9 -9 a9 9 0 0 0 -9 -9 a9 9 0 0 0 -9 9 a9 9 0 0 0 9 9 z M0 0 h24 v24 H0 z";
				case IconKind.XboxB:
					return "M13 12 a2 2 0 1 0 0 -4 h-3 v4 M13 12 h-3 M13 12 a2 2 0 1 1 0 4 h-3 v-4 M12 21 a9 9 0 0 0 9 -9 a9 9 0 0 0 -9 -9 a9 9 0 0 0 -9 9 a9 9 0 0 0 9 9 z M0 0 h24 v24 H0 z";
				case IconKind.XboxX:
					return "M15 8 l-6 8 M9 8 l6 8 M12 21 a9 9 0 0 0 9 -9 a9 9 0 0 0 -9 -9 a9 9 0 0 0 -9 9 a9 9 0 0 0 9 9 z M0 0 h24 v24 H0 z";
				case IconKind.XboxY:
					return "M15 8 l-2.988 3.984 l-0.012 4.016 M9 8 l3 4 M12 21 a9 9 0 0 0 9 -9 a9 9 0 0 0 -9 -9 a9 9 0 0 0 -9 9 a9 9 0 0 0 9 9 z M0 0 h24 v24 H0 z";
				case IconKind.YinYang:
					return "M11.5,16.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M11.5,7.5a0.5,0.5 0 1,0 1,0a0.5,0.5 0 1,0 -1,0 M12 3 a4.5 4.5 0 0 0 0 9 a4.5 4.5 0 0 1 0 9 M12 12 m-9 0 a9 9 0 1 0 18 0 a9 9 0 1 0 -18 0 M0 0 h24 v24 H0 z";
				case IconKind.Yoga:
					return "M4 10 l4 -1 l4 -1 l4 1.5 l4 1.5 M17 20 l-1 -5 h-5 l1 -7 M4 20 h4 l1.5 -3 M12 4 m-1 0 a1 1 0 1 0 2 0 a1 1 0 1 0 -2 0 M0 0 h24 v24 H0 z";
				case IconKind.ZeppelinOff:
					return "M3 3 l18 18 M10 15.5 v4.5 h6 v-4 M15.773 15.783 c-0.723 0.141 -1.486 0.217 -2.273 0.217 c-2.13 0 -4.584 -0.926 -7.364 -2.777 l-2.136 1.777 v-3.33 a46.07 46.07 0 0 1 -2 -1.67 a46.07 46.07 0 0 1 2 -1.67 v-3.33 l2.135 1.778 c0.13 -0.087 0.261 -0.172 0.39 -0.256 m2.564 -1.42 c1.601 -0.735 3.071 -1.102 4.411 -1.102 c4.694 0 8.5 2.686 8.5 6 c0 1.919 -1.276 3.627 -3.261 4.725 M0 0 h24 v24 H0 z";
				case IconKind.Zeppelin:
					return "M10 15.5 v4.5 h6 v-4 M13.5 4 c4.694 0 8.5 2.686 8.5 6 s-3.806 6 -8.5 6 c-2.13 0 -4.584 -0.926 -7.364 -2.777 l-2.136 1.777 v-3.33 a46.07 46.07 0 0 1 -2 -1.67 a46.07 46.07 0 0 1 2 -1.67 v-3.33 l2.135 1.778 c2.78 -1.852 5.235 -2.778 7.365 -2.778 z M0 0 h24 v24 H0 z";
				case IconKind.Zip:
					return "M4 8 h4 l-4 8 h4 M12 8 v8 M16 16 v-8 h2 a2 2 0 1 1 0 4 h-2 M0 0 h24 v24 H0 z";
				case IconKind.ZodiacAquarius:
					return "M3 17 l3 -3 l3 3 l3 -3 l3 3 l3 -3 l3 3 M3 10 l3 -3 l3 3 l3 -3 l3 3 l3 -3 l3 3 M0 0 h24 v24 H0 z";
				case IconKind.ZodiacAries:
					return "M12 21 l0 -16 M16 13 a5 5 0 1 0 -4 -8 M12 5 a5 5 0 1 0 -4 8 M0 0 h24 v24 H0 z";
				case IconKind.ZodiacCancer:
					return "M21 12 a10 6.5 0 0 1 -14 6.5 M3 12 a10 6.5 0 0 1 14 -6.5 M18 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M6 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.ZodiacCapricorn:
					return "M16 17 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M7 7 a3 3 0 0 1 6 0 v11 a3 3 0 0 1 -3 3 M4 4 a3 3 0 0 1 3 3 v9 M0 0 h24 v24 H0 z";
				case IconKind.ZodiacGemini:
					return "M17 4.5 l0 15 M7 4.5 l0 15 M3 21 a21 21 0 0 1 18 0 M3 3 a21 21 0 0 0 18 0 M0 0 h24 v24 H0 z";
				case IconKind.ZodiacLeo:
					return "M15 7 c0 4 -2 6 -2 10 M7 7 c0 3 2 5 2 9 M11 7 m-4 0 a4 4 0 1 0 8 0 a4 4 0 1 0 -8 0 M6 16 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M13 17 a4 4 0 1 0 8 0 M0 0 h24 v24 H0 z";
				case IconKind.ZodiacLibra:
					return "M5 17 h5 v-0.3 a7 7 0 1 1 4 0 v0.3 h5 M5 20 l14 0 M0 0 h24 v24 H0 z";
				case IconKind.ZodiacPisces:
					return "M5 12 l14 0 M19 3 a21 21 0 0 0 0 18 M5 3 a21 21 0 0 1 0 18 M0 0 h24 v24 H0 z";
				case IconKind.ZodiacSagittarius:
					return "M6.5 12.5 l5 5 M13 4 h7 v7 M4 20 l16 -16 M0 0 h24 v24 H0 z";
				case IconKind.ZodiacScorpio:
					return "M9 6 a2 2 0 0 1 4 0 v10 a3 3 0 0 0 3 3 h5 l-3 -3 m0 6 l3 -3 M5 6 a2 2 0 0 1 4 0 v9 M3 4 a2 2 0 0 1 2 2 v9 M0 0 h24 v24 H0 z";
				case IconKind.ZodiacTaurus:
					return "M12 15 m-6 0 a6 6 0 1 0 12 0 a6 6 0 1 0 -12 0 M6 3 a6 6 0 0 0 12 0 M0 0 h24 v24 H0 z";
				case IconKind.ZodiacVirgo:
					return "M12 21 a7 5 0 0 0 7 -5 v-2 a3 3 0 0 0 -6 0 M9 6 a2 2 0 0 1 4 0 v10 a7 5 0 0 0 7 5 M5 6 a2 2 0 0 1 4 0 v9 M3 4 a2 2 0 0 1 2 2 v9 M0 0 h24 v24 H0 z";
				case IconKind.ZoomCancel:
					return "M21 21 l-6 -6 M12 8 l-4 4 M8 8 l4 4 M10 10 m-7 0 a7 7 0 1 0 14 0 a7 7 0 1 0 -14 0 M0 0 h24 v24 H0 z";
				case IconKind.ZoomCheck:
					return "M7 10 l2 2 l4 -4 M21 21 l-6 -6 M10 10 m-7 0 a7 7 0 1 0 14 0 a7 7 0 1 0 -14 0 M0 0 h24 v24 H0 z";
				case IconKind.ZoomCode:
					return "M12 8 l2 2 l-2 2 M8 8 l-2 2 l2 2 M21 21 l-6 -6 M10 10 m-7 0 a7 7 0 1 0 14 0 a7 7 0 1 0 -14 0 M0 0 h24 v24 H0 z";
				case IconKind.ZoomExclamation:
					return "M10 7 v3 M10 13 v0.01 M21 21 l-6 -6 M10 10 m-7 0 a7 7 0 1 0 14 0 a7 7 0 1 0 -14 0 M0 0 h24 v24 H0 z";
				case IconKind.ZoomInArea:
					return "M15 3 h1 a2 2 0 0 1 2 2 v1 M10 3 h1 M3 6 v-1 a2 2 0 0 1 2 -2 h1 M3 11 v-1 M6 18 h-1 a2 2 0 0 1 -2 -2 v-1 M22 22 l-3 -3 M15 15 m-5 0 a5 5 0 1 0 10 0 a5 5 0 1 0 -10 0 M13 15 h4 M15 13 v4 M0 0 h24 v24 H0 z";
				case IconKind.ZoomIn:
					return "M21 21 l-6 -6 M10 7 l0 6 M7 10 l6 0 M10 10 m-7 0 a7 7 0 1 0 14 0 a7 7 0 1 0 -14 0 M0 0 h24 v24 H0 z";
				case IconKind.ZoomMoney:
					return "M10 13 v1 m0 -8 v1 M12 7 h-2.5 a1.5 1.5 0 0 0 0 3 h1 a1.5 1.5 0 0 1 0 3 h-2.5 M21 21 l-6 -6 M10 10 m-7 0 a7 7 0 1 0 14 0 a7 7 0 1 0 -14 0 M0 0 h24 v24 H0 z";
				case IconKind.ZoomOutArea:
					return "M15 3 h1 a2 2 0 0 1 2 2 v1 M10 3 h1 M3 6 v-1 a2 2 0 0 1 2 -2 h1 M3 11 v-1 M6 18 h-1 a2 2 0 0 1 -2 -2 v-1 M22 22 l-3 -3 M15 15 m-5 0 a5 5 0 1 0 10 0 a5 5 0 1 0 -10 0 M13 15 h4 M0 0 h24 v24 H0 z";
				case IconKind.ZoomOut:
					return "M21 21 l-6 -6 M7 10 l6 0 M10 10 m-7 0 a7 7 0 1 0 14 0 a7 7 0 1 0 -14 0 M0 0 h24 v24 H0 z";
				case IconKind.ZoomPan:
					return "M10 19 l2 2 l2 -2 M5 10 l-2 2 l2 2 M19 10 l2 2 l-2 2 M10 5 l2 -2 l2 2 M17 17 l-2.5 -2.5 M12 12 m-3 0 a3 3 0 1 0 6 0 a3 3 0 1 0 -6 0 M0 0 h24 v24 H0 z";
				case IconKind.ZoomQuestion:
					return "M10 10 a1.5 1.5 0 1 0 -1.14 -2.474 M10 13 l0 0.01 M21 21 l-6 -6 M10 10 m-7 0 a7 7 0 1 0 14 0 a7 7 0 1 0 -14 0 M0 0 h24 v24 H0 z";
				case IconKind.ZoomReplace:
					return "M3 16 v-4 h4 M16.705 12 a7 7 0 0 1 -5.074 4.798 a7.021 7.021 0 0 1 -8.241 -4.403 M17 4 v4 h-4 M3.291 8 a7 7 0 0 1 5.077 -4.806 a7.021 7.021 0 0 1 8.242 4.403 M21 21 l-6 -6 M0 0 h24 v24 H0 z";
				case IconKind.ZoomReset:
					return "M3 4 v4 h4 M3.268 12.043 a7.017 7.017 0 0 0 6.634 4.957 a7.012 7.012 0 0 0 7.043 -6.131 a7 7 0 0 0 -5.314 -7.672 a7.021 7.021 0 0 0 -8.241 4.403 M21 21 l-6 -6 M0 0 h24 v24 H0 z";
				case IconKind.ZzzOff:
					return "M3 3 l18 18 M14 4 h6 l-5.146 6.862 m1.146 1.138 h4 M4 12 h6 l-6 8 h6 M0 0 h24 v24 H0 z";
				case IconKind.Zzz:
					return "M14 4 h6 l-6 8 h6 M4 12 h6 l-6 8 h6 M0 0 h24 v24 H0 z";
				default:
					return string.Empty;
			}
		}
	}
}