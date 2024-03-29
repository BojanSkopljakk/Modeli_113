using System;
using System.Collections.Generic;
using System.Text;

namespace FTN.Common
{
	
	public enum DMSType : short
	{		
		MASK_TYPE							= unchecked((short)0xFFFF),

		CONNECTNODE							= 0x0001,
		PERLENGTHSEQIMP						= 0x0002,
		SERIES_COMP							= 0x0003,
		DCLINESEG							= 0x0004,
		ACLINESEG							= 0x0005,
		TERMINAL							= 0x0006,
	}

    [Flags]
	public enum ModelCode : long
	{
		IDOBJ								= 0x1000000000000000,
		IDOBJ_GID							= 0x1000000000000104,
		IDOBJ_MRID							= 0x1000000000000207,
		IDOBJ_NAME							= 0x1000000000000307,
		IDOBJ_ALIAS							= 0x1000000000000407,

		PSR									= 0x1100000000000000,

		EQUIPMENT							= 0x1110000000000000,

		CONDEQ								= 0x1111000000000000,
		CONDEQ_TERMINALS					= 0x1111000000000119,

		COND								= 0x1111100000000000,
		COND_LENGTH							= 0x1111100000000105,

		SERIES_COMP							= 0x1111200000030000,
		SERIES_COMP_R						= 0x1111200000030105,
		SERIES_COMP_R0						= 0x1111200000030205,
		SERIES_COMP_X						= 0x1111200000030305,
		SERIES_COMP_X0						= 0x1111200000030405,

		ACLINESEG							= 0x1111110000050000,
		ACLINESEG_B0CH						= 0x1111110000050105,
		ACLINESEG_BCH						= 0x1111110000050205,
		ACLINESEG_G0CH						= 0x1111110000050305,
		ACLINESEG_GCH						= 0x1111110000050405,
		ACLINESEG_R							= 0x1111110000050505,
		ACLINESEG_R0						= 0x1111110000050605,
		ACLINESEG_X							= 0x1111110000050705,
		ACLINESEG_X0						= 0x1111110000050805,
		ACLINESEG_PERLENGTHIMP				= 0x1111110000050909,

		DCLINESEG							= 0x1111120000040000,

		PERLENGTHIMP						= 0x1200000000000000,
		PERLENGTHIMP_ACLINESEGS				= 0x1200000000000119,

		PERLENGTHSEQIMP						= 0x1210000000020000,
		PERLENGTHSEQIMP_B0CH				= 0x1210000000020105,
		PERLENGTHSEQIMP_BCH					= 0x1210000000020205,
		PERLENGTHSEQIMP_G0CH				= 0x1210000000020305,
		PERLENGTHSEQIMP_GCH					= 0x1210000000020405,
		PERLENGTHSEQIMP_R					= 0x1210000000020505,
		PERLENGTHSEQIMP_R0					= 0x1210000000020605,
		PERLENGTHSEQIMP_X					= 0x1210000000020705,
		PERLENGTHSEQIMP_X0					= 0x1210000000020805,

		TERMINAL							= 0x1300000000060000,
		TERMINAL_CONDEQ						= 0x1300000000060109,
		TERMINAL_CONNECTNODE				= 0x1300000000060209,

		CONNECTNODE							= 0x1400000000010000,
		CONNECTNODE_DESC					= 0x1400000000010107,
		CONNECTNODE_TERMINALS				= 0x1400000000010219,


	}

    [Flags]
	public enum ModelCodeMask : long
	{
		MASK_TYPE			 = 0x00000000ffff0000,
		MASK_ATTRIBUTE_INDEX = 0x000000000000ff00,
		MASK_ATTRIBUTE_TYPE	 = 0x00000000000000ff,

		MASK_INHERITANCE_ONLY = unchecked((long)0xffffffff00000000),
		MASK_FIRSTNBL		  = unchecked((long)0xf000000000000000),
		MASK_DELFROMNBL8	  = unchecked((long)0xfffffff000000000),		
	}																		
}


