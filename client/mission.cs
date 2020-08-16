// -----------------------------------------------------------------------------
//  Torque Game Engine
//  Copyright (C) GarageGames.com, Inc.
// -----------------------------------------------------------------------------

// ----------------------------------------------------------------------------
//  Mission start / end events sent from the server
// ----------------------------------------------------------------------------


function clientCmdMissionStart ( %seq )
{
	// The client receives a mission start right before
	// being dropped into the game.

	ClearPhysicsCache ();
}

function clientCmdMissionEnd ( %seq )
{
	// Received when the current mission is ended.
	alxStopAll ();

	// Disable mission lighting if it's going, this is here
	// in case the mission ends while we are in the process
	// of loading it.
	$lightingMission = false;
	$sceneLighting::terminateLighting = true;
}
