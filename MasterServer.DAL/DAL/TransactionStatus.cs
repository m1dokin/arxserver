﻿using System;

namespace MasterServer.DAL
{
	// Token: 0x02000057 RID: 87
	public enum TransactionStatus
	{
		// Token: 0x040000E0 RID: 224
		OK,
		// Token: 0x040000E1 RID: 225
		NOT_ENOUGH_MONEY,
		// Token: 0x040000E2 RID: 226
		INVALID_REQUEST,
		// Token: 0x040000E3 RID: 227
		OUT_OF_STORE,
		// Token: 0x040000E4 RID: 228
		LIMIT_REACHED,
		// Token: 0x040000E5 RID: 229
		INTERNAL_ERROR,
		// Token: 0x040000E6 RID: 230
		RESTRICTED_BY_TAG,
		// Token: 0x040000E7 RID: 231
		DELETED,
		// Token: 0x040000E8 RID: 232
		KEY_TIME_OUT,
		// Token: 0x040000E9 RID: 233
		HASH_MISMATCH,
		// Token: 0x040000EA RID: 234
		GIVE_MONEY_TRANSACTION_COLLISION
	}
}
