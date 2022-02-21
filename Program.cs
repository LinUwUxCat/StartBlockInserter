using System;
using System.Runtime.InteropServices;
using GBX.NET;
using GBX.NET.LZO;
using GBX.NET.Engines.Game;


namespace SBI
{
    class Program
    {   


        static string[][] list = new string[][]{new string[] {"StadiumGrassClip","1-1-1"},
            new string[] {"StadiumDirt","1-1-2"},
            new string[] {"StadiumDirtBorder","1-1-2"},
            new string[] {"StadiumWater","1-1-3"},
            new string[] {"StadiumPool","1-1-3"},
            new string[] {"StadiumRoadMain","2-1-1"},
            new string[] {"StadiumRoadMainGTCurve2","2-1-2"},
            new string[] {"StadiumRoadMainGTCurve3","2-1-3"},
            new string[] {"StadiumRoadMainGTCurve4","2-1-4"},
            new string[] {"StadiumRoadMainGTCurve5","2-1-5"},
            new string[] {"StadiumLoopLeft","2-1-6"},
            new string[] {"StadiumLoopRight","2-1-7"},
            new string[] {"StadiumRoadMainCheckpoint","2-2-1"},
            new string[] {"StadiumRoadMainStartLine","2-2-2"},
            new string[] {"StadiumRoadMainFinishLine","2-2-3"},
            new string[] {"StadiumRoadMainStartFinishLine","2-2-4"},
            new string[] {"StadiumRoadMainTurbo","2-2-5"},
            new string[] {"StadiumRoadMainTurboRoulette","2-2-6"},
            new string[] {"StadiumRoadMainFW","2-2-7"},
            new string[] {"StadiumGrassCheckpoint","2-2-8"},
            new string[] {"StadiumHolePillar","2-3-1"},
            new string[] {"StadiumHolePillar2Front","2-3-2"},
            new string[] {"StadiumHolePillar2Line","2-3-3"},
            new string[] {"StadiumHolePillar3","2-3-4"},
            new string[] {"StadiumHole","2-3-5"},
            new string[] {"StadiumRoadStretch","2-3-6"},
            new string[] {"StadiumBump1","2-3-7"},
            new string[] {"StadiumRamp","2-3-8"},
            new string[] {"StadiumRampLow","2-3-9"},
            new string[] {"StadiumRoadMainGTDiag2x2","2-4-1"},
            new string[] {"StadiumRoadMainGTDiag2x2Mirror","2-4-2"},
            new string[] {"StadiumRoadMainGTDiag3x2","2-4-3"},
            new string[] {"StadiumRoadMainGTDiag3x2Mirror","2-4-4"},
            new string[] {"StadiumRoadMainGTDiag4x3","2-4-5"},
            new string[] {"StadiumRoadMainGTDiag4x3Mirror","2-4-6"},
            new string[] {"StadiumRoadMainYShapedDiag2","2-4-7"},
            new string[] {"StadiumRoadMainYShapedCurve2","2-4-8"},
            new string[] {"StadiumRoadMainSlopeBase2","3-1-1"},
            new string[] {"StadiumRoadMainSlopeBase","3-1-2"},
            new string[] {"StadiumRoadMainSlopeStraight","3-1-3"},
            new string[] {"StadiumRoadMainBiSlopeStart","3-1-4"},
            new string[] {"StadiumRoadMainBiSlopeEnd","3-1-5"},
            new string[] {"StadiumRoadMainSlopeUTop","3-1-6"},
            new string[] {"StadiumRoadMainSlopeUBottom","3-1-7"},
            new string[] {"StadiumRoadMainCheckpointUp","3-2-1"},
            new string[] {"StadiumRoadMainCheckpointDown","3-2-2"},
            new string[] {"StadiumRoadMainTurboUp","3-2-3"},
            new string[] {"StadiumRoadMainTurboDown","3-2-4"},
            new string[] {"StadiumRoadMainTurboRouletteDown","3-2-5"},
            new string[] {"StadiumRoadMainTurboRouletteUp","3-2-6"},
            new string[] {"StadiumHolePillarSlope","3-3-1"},
            new string[] {"StadiumHoleSlope","3-3-2"},
            new string[] {"StadiumRoadStretchSlope","3-3-3"},
            new string[] {"StadiumBump1Slope","3-3-4"},
            new string[] {"StadiumRoadMainGTDiag2x2Slope","3-4-1"},
            new string[] {"StadiumRoadMainGTDiag2x2SlopeMirror","3-4-2"},
            new string[] {"StadiumRoadMainGTDiag3x2Slope","3-4-3"},
            new string[] {"StadiumRoadMainGTDiag3x2SlopeMirror","3-4-4"},
            new string[] {"StadiumRoadMainGTDiag4x3Slope","3-4-5"},
            new string[] {"StadiumRoadMainYShapedDiag2SlopeUp","3-4-6"},
            new string[] {"StadiumRoadMainYShapedDiag2SlopeDown","3-4-7"},
            new string[] {"StadiumRoadMainGTDiag4x3SlopeMirror","3-4-8"},
            new string[] {"StadiumRoadTiltStraight","4-1-1"},
            new string[] {"StadiumRoadTiltTransition1Left","4-1-2"},
            new string[] {"StadiumRoadTiltTransition1Right","4-1-3"},
            new string[] {"StadiumRoadTiltTransition2Left","4-1-4"},
            new string[] {"StadiumRoadTiltTransition2Right","4-1-5"},
            new string[] {"StadiumRoadTiltTransition2CurveLeft","4-1-6"},
            new string[] {"StadiumRoadTiltTransition2CurveRight","4-1-7"},
            new string[] {"StadiumRoadTiltTransition2DiagLeft","4-1-8"},
            new string[] {"StadiumRoadTiltTransition2DiagRight","4-1-9"},
            new string[] {"StadiumRoadMainCheckpointLeft","4-2-1"},
            new string[] {"StadiumRoadMainCheckpointRight","4-2-2"},
            new string[] {"StadiumRoadMainTurboLeft","4-2-3"},
            new string[] {"StadiumRoadMainTurboRight","4-2-4"},
            new string[] {"StadiumRoadMainTurboRouletteLeft","4-2-5"},
            new string[] {"StadiumRoadMainTurboRouletteRight","4-2-6"},
            new string[] {"StadiumRoadTiltCorner","4-3-1"},
            new string[] {"StadiumRoadTiltGTCurve2","4-3-2"},
            new string[] {"StadiumRoadTiltGTCurve3","4-3-3"},
            new string[] {"StadiumRoadTiltGTCurve4","4-3-4"},
            new string[] {"StadiumRoadMainGTDiag2x2Tilt","4-3-5"},
            new string[] {"StadiumRoadMainGTDiag2x2TiltMirror","4-3-6"},
            new string[] {"StadiumRoadMainGTDiag3x2Tilt","4-3-7"},
            new string[] {"StadiumRoadMainGTDiag3x2TiltMirror","4-3-8"},
            new string[] {"StadiumRoadTiltCornerDownLeft","4-4-1"},
            new string[] {"StadiumRoadTiltCornerDownRight","4-4-2"},
            new string[] {"StadiumRoadTiltCornerUpLeft","4-4-3"},
            new string[] {"StadiumRoadTiltCornerUpRight","4-4-4"},
            new string[] {"StadiumRoadTiltGTCurve2DownLeft","4-4-5"},
            new string[] {"StadiumRoadTiltGTCurve2DownRight","4-4-6"},
            new string[] {"StadiumRoadTiltGTCurve2UpLeft","4-4-7"},
            new string[] {"StadiumRoadTiltGTCurve2UpRight","4-4-8"},
            new string[] {"StadiumHolePillarTilt","4-5-1"},
            new string[] {"StadiumHoleTilt","4-5-2"},
            new string[] {"StadiumStretchTilt","4-5-3"},
            new string[] {"StadiumBump1Tilt","4-5-4"},
            new string[] {"StadiumPlatformLoopStart","5-1-1"},
            new string[] {"StadiumPlatformLoopEnd","5-1-2"},
            new string[] {"StadiumPlatformWallBorder","5-1-3"},
            new string[] {"StadiumPlatformWall1","5-1-4"},
            new string[] {"StadiumPlatformWall2","5-1-5"},
            new string[] {"StadiumPlatformWall4","5-1-6"},
            new string[] {"StadiumPlatformWallPub2","5-1-7"},
            new string[] {"StadiumPlatformRoad","5-2-1"},
            new string[] {"StadiumPlatformSlope2Straight","5-2-2"},
            new string[] {"StadiumPlatformBiSlope2Start","5-2-3"},
            new string[] {"StadiumPlatformBiSlope2End","5-2-4"},
            new string[] {"StadiumPlatformTurbo","5-2-5"},
            new string[] {"StadiumPlatformTurboDown","5-2-6"},
            new string[] {"StadiumPlatformTurboLeft","5-2-7"},
            new string[] {"StadiumPlatformTurboRight","5-2-8"},
            new string[] {"StadiumPlatformTurboUp","5-2-9"},
            new string[] {"StadiumCheckpointRingV","5-3-1"},
            new string[] {"StadiumCheckpointRingHRoad","5-3-2"},
            new string[] {"StadiumPlatformCheckpoint","5-3-3"},
            new string[] {"StadiumPlatformCheckpointDown","5-3-4"},
            new string[] {"StadiumPlatformCheckpointLeft","5-3-5"},
            new string[] {"StadiumPlatformCheckpointRight","5-3-6"},
            new string[] {"StadiumPlatformCheckpointUp","5-3-7"},
            new string[] {"StadiumPlatformGTCurve2Wall1","5-4-1"},
            new string[] {"StadiumPlatformGTCurve2Wall2","5-4-2"},
            new string[] {"StadiumPlatformGTCurve2Wall4","5-4-3"},
            new string[] {"StadiumPlatformGTCurve3Wall1","5-4-4"},
            new string[] {"StadiumPlatformGTCurve3Wall2","5-4-5"},
            new string[] {"StadiumPlatformGTCurve3Wall4","5-4-6"},
            new string[] {"StadiumPlatformToRoad","5-5-1"},
            new string[] {"StadiumPlatformToRoad2","5-5-2"},
            new string[] {"StadiumPlatformToRoad2Mirror","5-5-3"},
            new string[] {"StadiumPlatformToRoadMain","5-5-4"},
            new string[] {"StadiumCircuitBorderStraight","6-1-1"},
            new string[] {"StadiumCircuitBorderDiagIn","6-1-2"},
            new string[] {"StadiumCircuitBorderDiagOut","6-1-3"},
            new string[] {"StadiumCircuitBorderCornerIn","6-1-4"},
            new string[] {"StadiumCircuitBorderCornerOut","6-1-5"},
            new string[] {"StadiumCircuitBase","6-2-1"},
            new string[] {"StadiumCircuitSlopeStart","6-2-2"},
            new string[] {"StadiumCircuitSlopeStraight","6-2-3"},
            new string[] {"StadiumCircuitSlopeEnd","6-2-4"},
            new string[] {"StadiumCircuitTurbo","6-2-5"},
            new string[] {"StadiumCircuitTurboLeft","6-2-6"},
            new string[] {"StadiumCircuitTurboUp","6-2-7"},
            new string[] {"StadiumCircuitTurboRight","6-2-8"},
            new string[] {"StadiumCircuitTurboDown","6-2-9"},
            new string[] {"StadiumCircuitBorderGTCurve2In","6-3-1"},
            new string[] {"StadiumCircuitBorderGTCurve3In","6-3-2"},
            new string[] {"StadiumCircuitBorderGTCurve4In","6-3-3"},
            new string[] {"StadiumCircuitBorderGTCurve2Out","6-3-4"},
            new string[] {"StadiumCircuitBorderGTCurve3Out","6-3-5"},
            new string[] {"StadiumCircuitBorderGTCurve4Out","6-3-6"},
            new string[] {"StadiumCircuitBorderSlopeStartLeft","6-4-1"},
            new string[] {"StadiumCircuitBorderSlopeStartRight","6-4-2"},
            new string[] {"StadiumCircuitBorderSlopeStraightLeft","6-4-3"},
            new string[] {"StadiumCircuitBorderSlopeStraightRight","6-4-4"},
            new string[] {"StadiumCircuitBorderSlopeStraightBottom","6-4-5"},
            new string[] {"StadiumCircuitBorderSlopeStraightTop","6-4-6"},
            new string[] {"StadiumCircuitBorderSlopeEndLeft","6-4-7"},
            new string[] {"StadiumCircuitBorderSlopeEndRight","6-4-8"},
            new string[] {"StadiumCircuitBorderSlopeCornerInLeftBottom","6-5-1"},
            new string[] {"StadiumCircuitBorderSlopeCornerInLeftTop","6-5-2"},
            new string[] {"StadiumCircuitBorderSlopeCornerInRightTop","6-5-3"},
            new string[] {"StadiumCircuitBorderSlopeCornerInRightBottom","6-5-4"},
            new string[] {"StadiumCircuitSlopeCornerInLeftBottom","6-5-5"},
            new string[] {"StadiumCircuitBorderSlopeCornerOutLeftTop","6-5-6"},
            new string[] {"StadiumCircuitBorderSlopeCornerOutRightTop","6-5-7"},
            new string[] {"StadiumCircuitBorderSlopeCornerOutRightBottom","6-5-8"},
            new string[] {"StadiumCircuitBorderSlopeGTCurve2InLeftBottom","6-6-1"},
            new string[] {"StadiumCircuitBorderSlopeGTCurve2InLeftTop","6-6-2"},
            new string[] {"StadiumCircuitBorderSlopeGTCurve2InRightTop","6-6-3"},
            new string[] {"StadiumCircuitBorderSlopeGTCurve2InRightBottom","6-6-4"},
            new string[] {"StadiumCircuitBorderSlopeGTCurve2OutLeftBottom","6-6-5"},
            new string[] {"StadiumCircuitBorderSlopeGTCurve2OutLeftTop","6-6-6"},
            new string[] {"StadiumCircuitBorderSlopeGTCurve2OutRightTop","6-6-7"},
            new string[] {"StadiumCircuitBorderSlopeGTCurve2OutRightBottom","6-6-8"},
            new string[] {"StadiumCircuitBorderSlopeDiagInLeftBottom","6-7-1"},
            new string[] {"StadiumCircuitBorderSlopeDiagInLeftTop","6-7-2"},
            new string[] {"StadiumCircuitBorderSlopeDiagInRightTop","6-7-3"},
            new string[] {"StadiumCircuitBorderSlopeDiagInRightBottom","6-7-4"},
            new string[] {"StadiumCircuitBorderSlopeDiagOutLeftBottom","6-7-5"},
            new string[] {"StadiumCircuitBorderSlopeDiagOutLeftTop","6-7-6"},
            new string[] {"StadiumCircuitBorderSlopeDiagOutRightTop","6-7-7"},
            new string[] {"StadiumCircuitBorderSlopeDiagOutRightBottom","6-7-8"},
            new string[] {"StadiumCircuitLoopStart","6-8-1"},
            new string[] {"StadiumCircuitRampBig","6-8-2"},
            new string[] {"StadiumCircuitRampSmall1x05","6-8-3"},
            new string[] {"StadiumCircuitRampSmall1x1","6-8-4"},
            new string[] {"StadiumCircuitHole","6-9-1"},
            new string[] {"StadiumCircuitBumpUp","6-9-2"},
            new string[] {"StadiumCircuitBumpUp2","6-9-3"},
            new string[] {"StadiumCircuitPillar1","6-9-4"},
            new string[] {"StadiumCircuitPillar2","6-9-5"},
            new string[] {"StadiumCircuitPillar3","6-9-6"},
            new string[] {"StadiumCircuitPillar5","6-9-7"},
            new string[] {"StadiumCircuitPillar6","6-9-8"},
            new string[] {"StadiumCircuitPillar7","6-9-9"},
            new string[] {"StadiumRoadDirtFenceStraight","7-1-1"},
            new string[] {"StadiumRoadDirtFenceCorner","7-1-2"},
            new string[] {"StadiumRoadDirt","7-1-3"},
            new string[] {"StadiumRoadDirtTurbo","7-1-4"},
            new string[] {"StadiumRoadDirtCheckpoint","7-1-5"},
            new string[] {"StadiumRoadDirtGTCurve2","7-1-6"},
            new string[] {"StadiumRoadDirtGTCurve3","7-1-7"},
            new string[] {"StadiumRoadDirtDiagonaleRight","7-1-8"},
            new string[] {"StadiumRoadDirtDiagonaleLeft","7-1-9"},
            new string[] {"StadiumRoadDirtHighFenceStraight","7-2-1"},
            new string[] {"StadiumRoadDirtHighFenceCorner","7-2-2"},
            new string[] {"StadiumRoadDirtHigh","7-2-3"},
            new string[] {"StadiumRoadDirtHighCheckpoint","7-2-4"},
            new string[] {"StadiumRoadDirtHighGTCurve3","7-2-5"},
            new string[] {"BStadiumRoadDirtToRoadDirtHigh","7-3-1"},
            new string[] {"StadiumRoadDirtToRoadDirtHigh2","7-3-2"},
            new string[] {"StadiumRoadDirtToRoadDirtHighBridge","7-3-3"},
            new string[] {"StadiumRoadDirtToRoadDirtHighCross","7-3-4"},
            new string[] {"StadiumRoadDirtToRoadDirtHigh","7-3-5"},
            new string[] {"StadiumRoadDirtToRoad","7-3-6"},
            new string[] {"StadiumRoadDirtHillSlope2","7-4-1"},
            new string[] {"StadiumRoadDirtHillSlope","7-4-2"},
            new string[] {"StadiumRoadDirtHillWave","7-4-3"},
            new string[] {"StadiumRoadDirtHillSlopeGT2Bis","7-4-4"},
            new string[] {"StadiumRoadDirtHillSlopeGT2","7-4-5"},
            new string[] {"StadiumRoadDirtWave_x2","7-5-1"},
            new string[] {"StadiumRoadDirtWave_x1","7-5-2"},
            new string[] {"StadiumRoadDirtToRoadGrass","7-5-3"},
            new string[] {"StadiumDirtDeadendDoor","7-5-4"},
            new string[] {"StadiumDirtDeadendSpot","7-5-5"},
            new string[] {"StadiumDirtDeadendTent1","7-5-6"},
            new string[] {"StadiumRoadDirtHillTiltStraight","7-6-1"},
            new string[] {"StadiumRoadDirtHillTiltCornerIn","7-6-2"},
            new string[] {"StadiumRoadDirtHillTiltCornerOut","7-6-3"},
            new string[] {"StadiumRoadDirtHillTiltCornerLeft","7-6-4"},
            new string[] {"StadiumRoadDirtHillTiltCornerRight","7-6-5"},
            new string[] {"StadiumRoadDirtHillTiltToRoadLeft","7-6-6"},
            new string[] {"StadiumRoadDirtHillTiltToRoadRight","7-6-7"},
            new string[] {"StadiumSculptBridgeSuspendSlope2","8-1-1"},
            new string[] {"StadiumSculptBridgeSuspendSlope2Mirror","8-1-2"},
            new string[] {"StadiumSculptBridgeSuspendSlopeEnd","8-1-3"},
            new string[] {"StadiumSculptBridgeSuspendSlopeEndMirror","8-1-4"},
            new string[] {"StadiumSculptA","8-2-1"},
            new string[] {"StadiumSculptB","8-2-2"},
            new string[] {"StadiumSculptC","8-2-3"},
            new string[] {"StadiumSculptArchRingEnd","8-2-4"},
            new string[] {"StadiumSculptArchRingEndMirror","8-2-5"},
            new string[] {"StadiumSculptArchRingStart","8-2-6"},
            new string[] {"StadiumSculptArchRingStartMirror","8-2-7"},
            new string[] {"StadiumSculptBridgePillar","8-3-1"},
            new string[] {"StadiumSculptBridgePillarMirror","8-3-2"},
            new string[] {"StadiumSculptBridgeSlopeStart","8-3-3"},
            new string[] {"StadiumSculptBridgeSlopeStartMirror","8-3-4"},
            new string[] {"StadiumSculptBridgeSlopeEnd","8-3-5"},
            new string[] {"StadiumSculptBridgeSlopeEndMirror","8-3-6"},
            new string[] {"StadiumSculptBridgeStraight","8-3-7"},
            new string[] {"StadiumSculptBridgeStraightSmall","8-3-8"},
            new string[] {"StadiumTubePillarCap","8-4-1"},
            new string[] {"StadiumTubeV1","8-4-2"},
            new string[] {"StadiumTubeV4","8-4-3"},
            new string[] {"StadiumTubeV8","8-4-4"},
            new string[] {"StadiumTube","8-4-5"},
            new string[] {"StadiumTubePillar","8-4-5"},
            new string[] {"StadiumTubePillarBranch","8-4-6"},
            new string[] {"StadiumTubeRoad","8-5-1"},
            new string[] {"StadiumTubeRoadDown","8-5-2"},
            new string[] {"StadiumTubeRoadUp","8-5-3"},
            new string[] {"StadiumTubeRoadCross","8-5-4"},
            new string[] {"StadiumControlRoadGlass","8-6-1"},
            new string[] {"StadiumControlRoadPub","8-6-2"},
            new string[] {"StadiumControlRoadCamera","8-6-3"},
            new string[] {"StadiumControlCameraPub","8-6-4"},
            new string[] {"StadiumControlLight","8-6-5"},
            new string[] {"StadiumControlLightBase","8-6-6"},
            new string[] {"StadiumTubeRoadLightSystem","8-6-7"},
            new string[] {"StadiumTubeRoadSoundSystem","8-6-8"},
            new string[] {"StadiumFabricStraight1x1","8-7-1"},
            new string[] {"StadiumFabricPillarAir","8-7-2"},
            new string[] {"StadiumFabricCornerIn","8-7-3"},
            new string[] {"StadiumFabricPillarCornerInAir","8-7-4"},
            new string[] {"StadiumFabricCornerOut","8-7-5"},
            new string[] {"StadiumFabricPillarCornerOut","8-7-6"},
            new string[] {"StadiumFabricCross1x1","8-8-1"},
            new string[] {"StadiumFabricCross3x3","8-8-2"},
            new string[] {"StadiumFabricCross3x3Screen","8-8-3"},
            new string[] {"StadiumFabricPillarAirScreen","8-8-4"},
            new string[] {"StadiumInflatableSupport","8-8-5"},
            new string[] {"StadiumInflatablePillar","8-8-5"},
            new string[] {"StadiumInflatableTube","8-8-6"},
            new string[] {"StadiumInflatableAdvert","8-8-7"},
            new string[] {"StadiumAirship","8-9-1"},
            new string[] {"StadiumInflatableCastle","8-9-2"},
            new string[] {"StadiumInflatableCastleDoor","8-9-3"},
            new string[] {"StadiumInflatableCastleBig","8-9-4"},
            new string[] {"StadiumInflatableCactus","8-9-5"},
            new string[] {"StadiumInflatableSnowTree","8-9-6"},
            new string[] {"StadiumInflatablePalmTree","8-9-7"}
        };

        static string GetBlock(string path){
            foreach(var a in list){
                if (a[1] == path){
                    return a[0];
                } 
            }
            return "-1";
        }

        static void Main(string[] args)
        {   

            GBX.NET.Lzo.SetLzo(typeof(GBX.NET.LZO.MiniLZO));
            if (args.Length < 1 || args[0] == "-h" || args[0] == "--help"){
                Console.WriteLine("StartBlockInserter (SBI) v0.1\nUsage : \n./SBI FileName BlockToRemove\nOR\n./SBI FileName PathTotheBlock\n\nBlockToRemove is the block's name, and PathToTheBlock is the path to the block in-game, with the folders.\n\nExamples : \n./SBI SuperMap.Challenge.Gbx StadiumRamp\nOR\n./SBI SuperMap.Challenge.Gbx 2-3-8");
                return;
            }
            var filename = args[0];
            string txtblock;
            if (args.Length == 1){
                Console.WriteLine("Enter the path to your block");
                txtblock = Console.ReadLine();
            } else {
                txtblock = args[1];
            }
            string block = GetBlock(txtblock);
            //Console.WriteLine(block);
            if (block == "-1"){
                block = args[1];
            }
            //Console.WriteLine(block);
            var fname = filename.Remove(filename.Length - 14) + "StartBlock";
            var node = GameBox.ParseNode(filename);
            var count = 0;
            if (node is CGameCtnChallenge challenge){
                foreach (var i in challenge.Blocks){
                    //Console.WriteLine(i);
                    if (i.Name == block){
                        i.Name = "StadiumRoadMainStartLine";
                        count++;
                        //Console.WriteLine(i.Name);
                    } 
                }
                if (count != 0){
                    Console.WriteLine("Replaced " + count.ToString() + " blocks and saved under " + fname + ".Challenge.Gbx");
                    challenge.Save(fname + ".Challenge.Gbx");
                } else {
                    Console.WriteLine("No blocks replaced - map was not saved.");
                }
            }
            if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.Windows)){
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey(true);
            }
        }
    }
}