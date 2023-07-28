﻿using System;

namespace MasterServer.GameLogic.StatsTracking
{
	// Token: 0x020005D0 RID: 1488
	public enum EStatsEvent
	{
		// Token: 0x04000F84 RID: 3972
		NON_MS_EVENT,
		// Token: 0x04000F85 RID: 3973
		MANUALLY_TRIGGERED,
		// Token: 0x04000F86 RID: 3974
		SESSION_END,
		// Token: 0x04000F87 RID: 3975
		RANK_CHANGED,
		// Token: 0x04000F88 RID: 3976
		MONEY_AWARDED,
		// Token: 0x04000F89 RID: 3977
		CRYMONEY_AWARDED,
		// Token: 0x04000F8A RID: 3978
		CROWN_COLLECTED,
		// Token: 0x04000F8B RID: 3979
		ADD_FRIEND,
		// Token: 0x04000F8C RID: 3980
		SPONSOR_PROGRESS,
		// Token: 0x04000F8D RID: 3981
		LEADER_BOARD_UPDATE,
		// Token: 0x04000F8E RID: 3982
		HIDDEN
	}
}