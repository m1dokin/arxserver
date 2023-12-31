﻿using System;

namespace MasterServer.GameRoomSystem
{
	// Token: 0x02000493 RID: 1171
	public enum GameRoomRetCode
	{
		// Token: 0x04000BD0 RID: 3024
		OK,
		// Token: 0x04000BD1 RID: 3025
		MISSION_EXPIRED,
		// Token: 0x04000BD2 RID: 3026
		BANNED,
		// Token: 0x04000BD3 RID: 3027
		NOT_READY,
		// Token: 0x04000BD4 RID: 3028
		FULL,
		// Token: 0x04000BD5 RID: 3029
		P2P_UNAVAILABLE,
		// Token: 0x04000BD6 RID: 3030
		TEAM_FULL,
		// Token: 0x04000BD7 RID: 3031
		ERROR,
		// Token: 0x04000BD8 RID: 3032
		PRIVATE,
		// Token: 0x04000BD9 RID: 3033
		BUILD_TYPE_MISMATCH,
		// Token: 0x04000BDA RID: 3034
		CLOSED,
		// Token: 0x04000BDB RID: 3035
		RANK_RESTRICTED,
		// Token: 0x04000BDC RID: 3036
		MISSION_RESTRICTED,
		// Token: 0x04000BDD RID: 3037
		NOT_IN_CLAN,
		// Token: 0x04000BDE RID: 3038
		NOT_PARTICIPATE_IN_CLAN_WAR,
		// Token: 0x04000BDF RID: 3039
		CLASS_RESTRICTED,
		// Token: 0x04000BE0 RID: 3040
		ROOMNAME_INVALID = 21,
		// Token: 0x04000BE1 RID: 3041
		ROOMNAME_RESERVED,
		// Token: 0x04000BE2 RID: 3042
		BUILD_VERSION_MISMATCH,
		// Token: 0x04000BE3 RID: 3043
		ITEM_NOT_AVAILABLE,
		// Token: 0x04000BE4 RID: 3044
		NOT_PARTICIPATE_IN_RATING_GAME,
		// Token: 0x04000BE5 RID: 3045
		NOT_ENOUGH_PLAYERS_FOR_RATING_GAME,
		// Token: 0x04000BE6 RID: 3046
		RATING_SEASON_NOT_STARTED,
		// Token: 0x04000BE7 RID: 3047
		RATING_GAME_BANNED
	}
}
