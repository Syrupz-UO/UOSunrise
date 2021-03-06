
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class SmallVendorBuilding1Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {310, -6, -5, 0}, {298, -7, -5, 0}, {342, -2, -5, 0}// 1	2	3	
			, {342, -3, -5, 0}, {310, -1, -5, 0}, {310, -5, -5, 0}// 4	5	6	
			, {307, -4, -5, 0}, {310, -6, 4, 0}, {311, -7, -4, 0}// 7	62	66	
			, {311, -7, 4, 0}, {309, -3, 5, 0}, {342, -4, 5, 0}// 67	68	69	
			, {307, -5, 5, 0}, {310, -2, 4, 0}, {298, -3, 4, 0}// 70	71	72	
			, {311, -6, 5, 0}, {343, -7, 1, 0}, {343, -7, 0, 0}// 73	74	75	
			, {343, -7, -1, 0}, {308, -7, -2, 0}, {311, -7, 2, 0}// 76	77	78	
			, {311, -7, 3, 0}, {311, -7, -3, 0}, {193, -3, 6, 0}// 79	80	81	
			, {194, -3, 6, 0}, {194, -6, 6, 0}, {193, -4, 6, 0}// 82	83	84	
			, {193, -5, 6, 0}, {3220, -3, 6, 0}, {3220, -5, 6, 0}// 85	86	87	
			, {3203, -4, 6, 0}, {8560, -2, 6, 20}, {8564, -5, 6, 20}// 88	89	90	
			, {8564, -5, 5, 20}, {8564, -4, 6, 23}, {8560, -3, 6, 23}// 91	92	93	
			, {8562, -6, 5, 20}, {8562, -4, 5, 20}, {8562, -3, 5, 20}// 94	95	96	
			, {8562, -2, 5, 20}, {8562, -1, 5, 20}, {8562, -6, 4, 23}// 97	98	99	
			, {8562, -5, 4, 23}, {8562, -4, 4, 23}, {8562, -3, 4, 23}// 100	101	102	
			, {8562, -2, 4, 23}, {8562, -1, 4, 23}, {8562, -5, 5, 20}// 103	104	105	
			, {8562, -6, 3, 26}, {8562, -5, 3, 26}, {8562, -4, 3, 26}// 106	107	108	
			, {8562, -3, 3, 26}, {8562, -2, 3, 26}, {8562, -1, 3, 26}// 109	110	111	
			, {8566, -6, -4, 20}, {8566, -5, -4, 20}, {8566, -4, -4, 20}// 112	113	114	
			, {8566, -3, -4, 20}, {8566, -2, -4, 20}, {8566, -1, -4, 20}// 115	116	117	
			, {8566, -6, -3, 23}, {8566, -5, -3, 23}, {8566, -4, -3, 23}// 118	119	120	
			, {8566, -3, -3, 23}, {8566, -2, -3, 23}, {8566, -1, -3, 23}// 121	122	123	
			, {8566, -6, -2, 26}, {8566, -5, -2, 26}, {8566, -4, -2, 26}// 124	125	126	
			, {8566, -3, -2, 26}, {8566, -2, -2, 26}, {8566, -1, -2, 26}// 127	128	129	
			, {8566, -6, -1, 29}, {8566, -5, -1, 29}, {8566, -4, -1, 29}// 130	131	132	
			, {8566, -3, -1, 29}, {8566, -2, -1, 29}, {8566, -1, -1, 29}// 133	134	135	
			, {8562, -6, 2, 29}, {8562, -5, 2, 29}, {8562, -4, 2, 29}// 136	137	138	
			, {8562, -3, 2, 29}, {8562, -2, 2, 29}, {8562, -1, 2, 29}// 139	140	141	
			, {8562, -6, 1, 32}, {8562, -5, 1, 32}, {8562, -4, 1, 32}// 142	143	144	
			, {8562, -3, 1, 32}, {8562, -2, 1, 32}, {8562, -1, 1, 32}// 145	146	147	
			, {8566, -6, 0, 32}, {8566, -5, 0, 32}, {8566, -4, 0, 32}// 148	149	150	
			, {8566, -3, 0, 32}, {8566, -2, 0, 32}, {8566, -1, 0, 32}// 151	152	153	
			, {310, 6, -5, 0}, {342, 3, -5, 0}, {342, 2, -5, 0}// 154	155	156	
			, {310, 4, -5, 0}, {310, 5, -5, 0}, {310, 0, -5, 0}// 157	158	159	
			, {307, 1, -5, 0}, {309, 6, 4, 0}, {311, 6, -4, 0}// 160	206	228	
			, {309, 4, 5, 0}, {342, 3, 5, 0}, {307, 2, 5, 0}// 229	230	231	
			, {310, 5, 4, 0}, {310, 1, 4, 0}, {311, 1, 5, 0}// 232	233	234	
			, {298, 4, 4, 0}, {343, 6, 0, 0}, {343, 6, -1, 0}// 235	236	237	
			, {343, 6, 1, 0}, {308, 6, -2, 0}, {311, 6, 2, 0}// 238	239	240	
			, {311, 6, 3, 0}, {311, 6, -3, 0}, {193, 4, 6, 0}// 241	242	243	
			, {193, 3, 6, 0}, {193, 2, 6, 0}, {194, 4, 6, 0}// 244	245	246	
			, {194, 1, 6, 0}, {3220, 4, 6, 0}, {3220, 2, 6, 0}// 247	248	249	
			, {3203, 3, 6, 0}, {8560, 5, 6, 20}, {8560, 4, 6, 23}// 250	251	252	
			, {8564, 2, 6, 20}, {8564, 3, 6, 23}, {8562, 7, 5, 20}// 253	254	255	
			, {8562, 0, 5, 20}, {8562, 1, 5, 20}, {8562, 2, 5, 20}// 256	257	258	
			, {8562, 3, 5, 20}, {8562, 4, 5, 20}, {8562, 6, 5, 20}// 259	260	261	
			, {8562, 7, 4, 23}, {8562, 0, 4, 23}, {8562, 1, 4, 23}// 262	263	264	
			, {8562, 2, 4, 23}, {8562, 3, 4, 23}, {8562, 4, 4, 23}// 265	266	267	
			, {8562, 5, 4, 23}, {8562, 6, 4, 23}, {8562, 5, 5, 20}// 268	269	270	
			, {8562, 7, 3, 26}, {8562, 0, 3, 26}, {8562, 1, 3, 26}// 271	272	273	
			, {8562, 2, 3, 26}, {8562, 3, 3, 26}, {8562, 4, 3, 26}// 274	275	276	
			, {8562, 5, 3, 26}, {8562, 6, 3, 26}, {8566, 7, -4, 20}// 277	278	279	
			, {8566, 0, -4, 20}, {8566, 1, -4, 20}, {8566, 2, -4, 20}// 280	281	282	
			, {8566, 3, -4, 20}, {8566, 4, -4, 20}, {8566, 5, -4, 20}// 283	284	285	
			, {8566, 6, -4, 20}, {8566, 7, -3, 23}, {8566, 0, -3, 23}// 286	287	288	
			, {8566, 1, -3, 23}, {8566, 2, -3, 23}, {8566, 3, -3, 23}// 289	290	291	
			, {8566, 4, -3, 23}, {8566, 5, -3, 23}, {8566, 6, -3, 23}// 292	293	294	
			, {8566, 7, -2, 26}, {8566, 0, -2, 26}, {8566, 1, -2, 26}// 295	296	297	
			, {8566, 2, -2, 26}, {8566, 3, -2, 26}, {8566, 4, -2, 26}// 298	299	300	
			, {8566, 5, -2, 26}, {8566, 6, -2, 26}, {8566, 7, -1, 29}// 301	302	303	
			, {8566, 0, -1, 29}, {8566, 1, -1, 29}, {8566, 2, -1, 29}// 304	305	306	
			, {8566, 3, -1, 29}, {8566, 4, -1, 29}, {8566, 5, -1, 29}// 307	308	309	
			, {8566, 6, -1, 29}, {8562, 7, 2, 29}, {8562, 0, 2, 29}// 310	311	312	
			, {8562, 1, 2, 29}, {8562, 2, 2, 29}, {8562, 3, 2, 29}// 313	314	315	
			, {8562, 4, 2, 29}, {8562, 5, 2, 29}, {8562, 6, 2, 29}// 316	317	318	
			, {8562, 7, 1, 32}, {8562, 0, 1, 32}, {8562, 1, 1, 32}// 319	320	321	
			, {8562, 2, 1, 32}, {8562, 3, 1, 32}, {8562, 4, 1, 32}// 322	323	324	
			, {8562, 5, 1, 32}, {8562, 6, 1, 32}, {8566, 7, 0, 32}// 325	326	327	
			, {8566, 0, 0, 32}, {8566, 1, 0, 32}, {8566, 2, 0, 32}// 328	329	330	
			, {8566, 3, 0, 32}, {8566, 4, 0, 32}, {8566, 5, 0, 32}// 331	332	333	
			, {8566, 6, 0, 32}, {184, 6, -1, 20}, {184, 6, 0, 20}// 334	335	336	
			, {184, 6, -2, 20}, {184, 6, 1, 20}, {190, 6, -3, 20}// 337	338	339	
			, {190, 6, 2, 20}// 340	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SmallVendorBuilding1AddonDeed();
			}
		}

		[ Constructable ]
		public SmallVendorBuilding1Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 9269, -6, -1, 0, 1052, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 9269, -6, 0, 0, 1052, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 9269, -6, 1, 0, 1052, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 9269, -5, -1, 0, 1052, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 9269, -5, 0, 0, 1052, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 9269, -5, 1, 0, 1052, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 9269, -4, -1, 0, 1052, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 9269, -4, 0, 0, 1052, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 9269, -4, 1, 0, 1052, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 9269, -3, -1, 0, 1052, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 9269, -3, 0, 0, 1052, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 9269, -3, 1, 0, 1052, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 9269, -2, -1, 0, 1052, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 9269, -2, 0, 0, 1052, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 9269, -2, 1, 0, 1052, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 9269, -1, -1, 0, 1052, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 9269, -1, 0, 0, 1052, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 9269, -1, 1, 0, 1052, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 9269, -6, -2, 0, 1052, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 9269, -5, -2, 0, 1052, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 9269, -4, -2, 0, 1052, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 9269, -3, -2, 0, 1052, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 9269, -2, -2, 0, 1052, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 9269, -1, -2, 0, 1052, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 9269, -6, -3, 0, 1052, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 9269, -5, -3, 0, 1052, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 9269, -4, -3, 0, 1052, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 9269, -3, -3, 0, 1052, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 9269, -2, -3, 0, 1052, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 9269, -1, -3, 0, 1052, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 9269, -6, 2, 0, 1052, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 9269, -5, 2, 0, 1052, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 9269, -4, 2, 0, 1052, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 9269, -3, 2, 0, 1052, -1, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 9269, -2, 2, 0, 1052, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 9269, -1, 2, 0, 1052, -1, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 9269, -6, 3, 0, 1052, -1, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 9269, -5, 3, 0, 1052, -1, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 9269, -4, 3, 0, 1052, -1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 9269, -3, 3, 0, 1052, -1, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 9269, -2, 3, 0, 1052, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 9269, -1, 3, 0, 1052, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 9269, -6, 4, 0, 1052, -1, "", 1);// 50
			AddComplexComponent( (BaseAddon) this, 9269, -5, 4, 0, 1052, -1, "", 1);// 51
			AddComplexComponent( (BaseAddon) this, 9269, -4, 4, 0, 1052, -1, "", 1);// 52
			AddComplexComponent( (BaseAddon) this, 9269, -3, 4, 0, 1052, -1, "", 1);// 53
			AddComplexComponent( (BaseAddon) this, 9269, -2, 4, 0, 1052, -1, "", 1);// 54
			AddComplexComponent( (BaseAddon) this, 9269, -1, 4, 0, 1052, -1, "", 1);// 55
			AddComplexComponent( (BaseAddon) this, 9269, -6, -4, 0, 1052, -1, "", 1);// 56
			AddComplexComponent( (BaseAddon) this, 9269, -5, -4, 0, 1052, -1, "", 1);// 57
			AddComplexComponent( (BaseAddon) this, 9269, -4, -4, 0, 1052, -1, "", 1);// 58
			AddComplexComponent( (BaseAddon) this, 9269, -3, -4, 0, 1052, -1, "", 1);// 59
			AddComplexComponent( (BaseAddon) this, 9269, -2, -4, 0, 1052, -1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 9269, -1, -4, 0, 1052, -1, "", 1);// 61
			AddComplexComponent( (BaseAddon) this, 9269, -5, 5, 0, 1052, -1, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 9269, -4, 5, 0, 1052, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 9269, -3, 5, 0, 1052, -1, "", 1);// 65
			AddComplexComponent( (BaseAddon) this, 9269, 0, -1, 0, 1052, -1, "", 1);// 161
			AddComplexComponent( (BaseAddon) this, 9269, 0, 0, 0, 1052, -1, "", 1);// 162
			AddComplexComponent( (BaseAddon) this, 9269, 0, 1, 0, 1052, -1, "", 1);// 163
			AddComplexComponent( (BaseAddon) this, 9269, 0, -2, 0, 1052, -1, "", 1);// 164
			AddComplexComponent( (BaseAddon) this, 9269, 0, -3, 0, 1052, -1, "", 1);// 165
			AddComplexComponent( (BaseAddon) this, 9269, 0, 2, 0, 1052, -1, "", 1);// 166
			AddComplexComponent( (BaseAddon) this, 9269, 1, -3, 0, 1052, -1, "", 1);// 167
			AddComplexComponent( (BaseAddon) this, 9269, 1, -2, 0, 1052, -1, "", 1);// 168
			AddComplexComponent( (BaseAddon) this, 9269, 1, -1, 0, 1052, -1, "", 1);// 169
			AddComplexComponent( (BaseAddon) this, 9269, 1, 0, 0, 1052, -1, "", 1);// 170
			AddComplexComponent( (BaseAddon) this, 9269, 1, 1, 0, 1052, -1, "", 1);// 171
			AddComplexComponent( (BaseAddon) this, 9269, 1, 2, 0, 1052, -1, "", 1);// 172
			AddComplexComponent( (BaseAddon) this, 9269, 0, 3, 0, 1052, -1, "", 1);// 173
			AddComplexComponent( (BaseAddon) this, 9269, 1, 3, 0, 1052, -1, "", 1);// 174
			AddComplexComponent( (BaseAddon) this, 9269, 2, -3, 0, 1052, -1, "", 1);// 175
			AddComplexComponent( (BaseAddon) this, 9269, 2, -2, 0, 1052, -1, "", 1);// 176
			AddComplexComponent( (BaseAddon) this, 9269, 2, -1, 0, 1052, -1, "", 1);// 177
			AddComplexComponent( (BaseAddon) this, 9269, 2, 0, 0, 1052, -1, "", 1);// 178
			AddComplexComponent( (BaseAddon) this, 9269, 2, 1, 0, 1052, -1, "", 1);// 179
			AddComplexComponent( (BaseAddon) this, 9269, 2, 2, 0, 1052, -1, "", 1);// 180
			AddComplexComponent( (BaseAddon) this, 9269, 2, 3, 0, 1052, -1, "", 1);// 181
			AddComplexComponent( (BaseAddon) this, 9269, 0, 4, 0, 1052, -1, "", 1);// 182
			AddComplexComponent( (BaseAddon) this, 9269, 1, 4, 0, 1052, -1, "", 1);// 183
			AddComplexComponent( (BaseAddon) this, 9269, 2, 4, 0, 1052, -1, "", 1);// 184
			AddComplexComponent( (BaseAddon) this, 9269, 3, -3, 0, 1052, -1, "", 1);// 185
			AddComplexComponent( (BaseAddon) this, 9269, 3, -2, 0, 1052, -1, "", 1);// 186
			AddComplexComponent( (BaseAddon) this, 9269, 3, -1, 0, 1052, -1, "", 1);// 187
			AddComplexComponent( (BaseAddon) this, 9269, 3, 0, 0, 1052, -1, "", 1);// 188
			AddComplexComponent( (BaseAddon) this, 9269, 3, 1, 0, 1052, -1, "", 1);// 189
			AddComplexComponent( (BaseAddon) this, 9269, 3, 2, 0, 1052, -1, "", 1);// 190
			AddComplexComponent( (BaseAddon) this, 9269, 3, 3, 0, 1052, -1, "", 1);// 191
			AddComplexComponent( (BaseAddon) this, 9269, 3, 4, 0, 1052, -1, "", 1);// 192
			AddComplexComponent( (BaseAddon) this, 9269, 4, -3, 0, 1052, -1, "", 1);// 193
			AddComplexComponent( (BaseAddon) this, 9269, 4, -2, 0, 1052, -1, "", 1);// 194
			AddComplexComponent( (BaseAddon) this, 9269, 4, -1, 0, 1052, -1, "", 1);// 195
			AddComplexComponent( (BaseAddon) this, 9269, 4, 0, 0, 1052, -1, "", 1);// 196
			AddComplexComponent( (BaseAddon) this, 9269, 4, 1, 0, 1052, -1, "", 1);// 197
			AddComplexComponent( (BaseAddon) this, 9269, 4, 2, 0, 1052, -1, "", 1);// 198
			AddComplexComponent( (BaseAddon) this, 9269, 4, 3, 0, 1052, -1, "", 1);// 199
			AddComplexComponent( (BaseAddon) this, 9269, 4, 4, 0, 1052, -1, "", 1);// 200
			AddComplexComponent( (BaseAddon) this, 9269, 0, -4, 0, 1052, -1, "", 1);// 201
			AddComplexComponent( (BaseAddon) this, 9269, 1, -4, 0, 1052, -1, "", 1);// 202
			AddComplexComponent( (BaseAddon) this, 9269, 2, -4, 0, 1052, -1, "", 1);// 203
			AddComplexComponent( (BaseAddon) this, 9269, 3, -4, 0, 1052, -1, "", 1);// 204
			AddComplexComponent( (BaseAddon) this, 9269, 4, -4, 0, 1052, -1, "", 1);// 205
			AddComplexComponent( (BaseAddon) this, 9269, 5, -4, 0, 1052, -1, "", 1);// 207
			AddComplexComponent( (BaseAddon) this, 9269, 5, -3, 0, 1052, -1, "", 1);// 208
			AddComplexComponent( (BaseAddon) this, 9269, 5, -2, 0, 1052, -1, "", 1);// 209
			AddComplexComponent( (BaseAddon) this, 9269, 5, -1, 0, 1052, -1, "", 1);// 210
			AddComplexComponent( (BaseAddon) this, 9269, 5, 0, 0, 1052, -1, "", 1);// 211
			AddComplexComponent( (BaseAddon) this, 9269, 5, 1, 0, 1052, -1, "", 1);// 212
			AddComplexComponent( (BaseAddon) this, 9269, 5, 2, 0, 1052, -1, "", 1);// 213
			AddComplexComponent( (BaseAddon) this, 9269, 5, 3, 0, 1052, -1, "", 1);// 214
			AddComplexComponent( (BaseAddon) this, 9269, 5, 4, 0, 1052, -1, "", 1);// 215
			AddComplexComponent( (BaseAddon) this, 9269, 2, 5, 0, 1052, -1, "", 1);// 216
			AddComplexComponent( (BaseAddon) this, 9269, 3, 5, 0, 1052, -1, "", 1);// 217
			AddComplexComponent( (BaseAddon) this, 9269, 6, -4, 0, 1052, -1, "", 1);// 218
			AddComplexComponent( (BaseAddon) this, 9269, 6, -3, 0, 1052, -1, "", 1);// 219
			AddComplexComponent( (BaseAddon) this, 9269, 6, -2, 0, 1052, -1, "", 1);// 220
			AddComplexComponent( (BaseAddon) this, 9269, 6, -1, 0, 1052, -1, "", 1);// 221
			AddComplexComponent( (BaseAddon) this, 9269, 6, 0, 0, 1052, -1, "", 1);// 222
			AddComplexComponent( (BaseAddon) this, 9269, 6, 1, 0, 1052, -1, "", 1);// 223
			AddComplexComponent( (BaseAddon) this, 9269, 6, 2, 0, 1052, -1, "", 1);// 224
			AddComplexComponent( (BaseAddon) this, 9269, 6, 3, 0, 1052, -1, "", 1);// 225
			AddComplexComponent( (BaseAddon) this, 9269, 6, 4, 0, 1052, -1, "", 1);// 226
			AddComplexComponent( (BaseAddon) this, 9269, 4, 5, 0, 1052, -1, "", 1);// 227

		}

		public SmallVendorBuilding1Addon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class SmallVendorBuilding1AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SmallVendorBuilding1Addon();
			}
		}

		[Constructable]
		public SmallVendorBuilding1AddonDeed()
		{
			Name = "SmallVendorBuilding1";
		}

		public SmallVendorBuilding1AddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}