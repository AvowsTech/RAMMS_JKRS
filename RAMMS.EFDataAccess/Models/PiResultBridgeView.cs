﻿using System;
using System.Collections.Generic;

namespace RAMMS.EFDataAccess.Models
{
    public partial class PiResultBridgeView
    {
        public string SectionCode { get; set; }
        public string FeatureBound { get; set; }
        public string FeatureRoute { get; set; }
        public string BridgeName { get; set; }
        public double? BridgeKmlocation { get; set; }
        public double? BridgeLatitude { get; set; }
        public double? BridgeLongitude { get; set; }
        public string BridgeType { get; set; }
        public double? BridgeSpanCount { get; set; }
        public double? BridgeJointCount { get; set; }
        public double? BridgeLengthTotal { get; set; }
        public int Pk { get; set; }
        public int? PiSchedulePk { get; set; }
        public string GenInfoTypeOfInspection { get; set; }
        public string GenInfoSummary { get; set; }
        public string GenInfoTraffic { get; set; }
        public int? GenInfoSpanNo { get; set; }
        public string GenInfoRating { get; set; }
        public string DeckDrainageStructureCondition { get; set; }
        public string DeckDrainageStructureSeverity { get; set; }
        public string DeckDrainageStructureExtend { get; set; }
        public string DeckDrainageStructureRemarks { get; set; }
        public string DeckDrainageStructureRating { get; set; }
        public string DeckDrainageServiceCondition { get; set; }
        public string DeckDrainageServiceSeverity { get; set; }
        public string DeckDrainageServiceExtend { get; set; }
        public string DeckDrainageServiceRemarks { get; set; }
        public string DeckDrainageServiceRating { get; set; }
        public string DeckDrainageOtherRemarks { get; set; }
        public string ParapetImpactCondition { get; set; }
        public string ParapetImpactSeverity { get; set; }
        public string ParapetImpactExtend { get; set; }
        public string ParapetImpactRemarks { get; set; }
        public string ParapetImpactRating { get; set; }
        public string ParapetStabilityCondition { get; set; }
        public string ParapetStabilitySeverity { get; set; }
        public string ParapetStabilityExtend { get; set; }
        public string ParapetStabilityRemarks { get; set; }
        public string ParapetStabilityRating { get; set; }
        public string ParapetCorrosionCondition { get; set; }
        public string ParapetCorrosionSeverity { get; set; }
        public string ParapetCorrosionExtend { get; set; }
        public string ParapetCorrosionRemarks { get; set; }
        public string ParapetCorrosionRating { get; set; }
        public string ParapetCrackingCondition { get; set; }
        public string ParapetCrackingSeverity { get; set; }
        public string ParapetCrackingExtend { get; set; }
        public string ParapetCrackingRemarks { get; set; }
        public string ParapetCrackingRating { get; set; }
        public string ParapetSpallingCondition { get; set; }
        public string ParapetSpallingSeverity { get; set; }
        public string ParapetSpallingExtend { get; set; }
        public string ParapetSpallingRemarks { get; set; }
        public string ParapetSpallingRating { get; set; }
        public string ParapetOtherRemarks { get; set; }
        public string JointCracksCondition { get; set; }
        public string JointCracksSeverity { get; set; }
        public string JointCracksExtend { get; set; }
        public string JointCracksRemarks { get; set; }
        public string JointCracksRating { get; set; }
        public string JointFixityCondition { get; set; }
        public string JointFixitySeverity { get; set; }
        public string JointFixityExtend { get; set; }
        public string JointFixityRemarks { get; set; }
        public string JointFixityRating { get; set; }
        public string JointAlignmentCondition { get; set; }
        public string JointAlignmentSeverity { get; set; }
        public string JointAlignmentExtend { get; set; }
        public string JointAlignmentRemarks { get; set; }
        public string JointAlignmentRating { get; set; }
        public string JointLeakageCondition { get; set; }
        public string JointLeakageSeverity { get; set; }
        public string JointLeakageExtend { get; set; }
        public string JointLeakageRemarks { get; set; }
        public string JointLeakageRating { get; set; }
        public string JointOtherRemarks { get; set; }
        public string AbutmentPavementCondition { get; set; }
        public string AbutmentPavementSeverity { get; set; }
        public string AbutmentPavementExtend { get; set; }
        public string AbutmentPavementRemarks { get; set; }
        public string AbutmentPavementRating { get; set; }
        public string AbutmentOtherRemarks { get; set; }
        public string FurnitureHeightCondition { get; set; }
        public string FurnitureHeightSeverity { get; set; }
        public string FurnitureHeightExtend { get; set; }
        public string FurnitureHeightRemarks { get; set; }
        public string FurnitureHeightRating { get; set; }
        public string FurnitureOtherRemarks { get; set; }
        public string DeckTopVerticalCondition { get; set; }
        public string DeckTopVerticalSeverity { get; set; }
        public string DeckTopVerticalExtend { get; set; }
        public string DeckTopVerticalRemarks { get; set; }
        public string DeckTopVerticalRating { get; set; }
        public string DeckTopHorizontalCondition { get; set; }
        public string DeckTopHorizontalSeverity { get; set; }
        public string DeckTopHorizontalExtend { get; set; }
        public string DeckTopHorizontalRemarks { get; set; }
        public string DeckTopHorizontalRating { get; set; }
        public string DeckTopOtherRemarks { get; set; }
        public string DeckEdgeCrackingCondition { get; set; }
        public string DeckEdgeCrackingSeverity { get; set; }
        public string DeckEdgeCrackingExtend { get; set; }
        public string DeckEdgeCrackingRemarks { get; set; }
        public string DeckEdgeCrackingRating { get; set; }
        public string DeckEdgeSpallingCondition { get; set; }
        public string DeckEdgeSpallingSeverity { get; set; }
        public string DeckEdgeSpallingExtend { get; set; }
        public string DeckEdgeSpallingRemarks { get; set; }
        public string DeckEdgeSpallingRating { get; set; }
        public string DeckEdgeCorrosionCondition { get; set; }
        public string DeckEdgeCorrosionSeverity { get; set; }
        public string DeckEdgeCorrosionExtend { get; set; }
        public string DeckEdgeCorrosionRemarks { get; set; }
        public string DeckEdgeCorrosionRating { get; set; }
        public string DeckEdgeLeakageCondition { get; set; }
        public string DeckEdgeLeakageSeverity { get; set; }
        public string DeckEdgeLeakageExtend { get; set; }
        public string DeckEdgeLeakageRemarks { get; set; }
        public string DeckEdgeLeakageRating { get; set; }
        public string DeckEdgeStainCondition { get; set; }
        public string DeckEdgeStainSeverity { get; set; }
        public string DeckEdgeStainExtend { get; set; }
        public string DeckEdgeStainRemarks { get; set; }
        public string DeckEdgeStainRating { get; set; }
        public string DeckEdgeOtherRemarks { get; set; }
        public string GirderNoiseCondition { get; set; }
        public string GirderNoiseSeverity { get; set; }
        public string GirderNoiseExtend { get; set; }
        public string GirderNoiseRemarks { get; set; }
        public string GirderNoiseRating { get; set; }
        public string GirderCrackingCondition { get; set; }
        public string GirderCrackingSeverity { get; set; }
        public string GirderCrackingExtend { get; set; }
        public string GirderCrackingRemarks { get; set; }
        public string GirderCrackingRating { get; set; }
        public string GirderSpallingCondition { get; set; }
        public string GirderSpallingSeverity { get; set; }
        public string GirderSpallingExtend { get; set; }
        public string GirderSpallingRemarks { get; set; }
        public string GirderSpallingRating { get; set; }
        public string GirderCorrosionCondition { get; set; }
        public string GirderCorrosionSeverity { get; set; }
        public string GirderCorrosionExtend { get; set; }
        public string GirderCorrosionRemarks { get; set; }
        public string GirderCorrosionRating { get; set; }
        public string GirderLeakageCondition { get; set; }
        public string GirderLeakageSeverity { get; set; }
        public string GirderLeakageExtend { get; set; }
        public string GirderLeakageRemarks { get; set; }
        public string GirderLeakageRating { get; set; }
        public string GirderStainCondition { get; set; }
        public string GirderStainSeverity { get; set; }
        public string GirderStainExtend { get; set; }
        public string GirderStainRemarks { get; set; }
        public string GirderStainRating { get; set; }
        public string GirderOtherRemarks { get; set; }
        public string DiaphragmNoiseCondition { get; set; }
        public string DiaphragmNoiseSeverity { get; set; }
        public string DiaphragmNoiseExtend { get; set; }
        public string DiaphragmNoiseRemarks { get; set; }
        public string DiaphragmNoiseRating { get; set; }
        public string DiaphragmCrackingCondition { get; set; }
        public string DiaphragmCrackingSeverity { get; set; }
        public string DiaphragmCrackingExtend { get; set; }
        public string DiaphragmCrackingRemarks { get; set; }
        public string DiaphragmCrackingRating { get; set; }
        public string DiaphragmSpallingCondition { get; set; }
        public string DiaphragmSpallingSeverity { get; set; }
        public string DiaphragmSpallingExtend { get; set; }
        public string DiaphragmSpallingRemarks { get; set; }
        public string DiaphragmSpallingRating { get; set; }
        public string DiaphragmCorrosionCondition { get; set; }
        public string DiaphragmCorrosionSeverity { get; set; }
        public string DiaphragmCorrosionExtend { get; set; }
        public string DiaphragmCorrosionRemarks { get; set; }
        public string DiaphragmCorrosionRating { get; set; }
        public string DiaphragmOtherRemarks { get; set; }
        public string BearingDeformCondition { get; set; }
        public string BearingDeformSeverity { get; set; }
        public string BearingDeformExtend { get; set; }
        public string BearingDeformRemarks { get; set; }
        public string BearingDeformRating { get; set; }
        public string BearingCrackCondition { get; set; }
        public string BearingCrackSeverity { get; set; }
        public string BearingCrackExtend { get; set; }
        public string BearingCrackRemarks { get; set; }
        public string BearingCrackRating { get; set; }
        public string BearingSurfaceCondition { get; set; }
        public string BearingSurfaceSeverity { get; set; }
        public string BearingSurfaceExtend { get; set; }
        public string BearingSurfaceRemarks { get; set; }
        public string BearingSurfaceRating { get; set; }
        public string BearingAlignmentCondition { get; set; }
        public string BearingAlignmentSeverity { get; set; }
        public string BearingAlignmentExtend { get; set; }
        public string BearingAlignmentRemarks { get; set; }
        public string BearingAlignmentRating { get; set; }
        public string BearingSpallingCondition { get; set; }
        public string BearingSpallingSeverity { get; set; }
        public string BearingSpallingExtend { get; set; }
        public string BearingSpallingRemarks { get; set; }
        public string BearingSpallingRating { get; set; }
        public string BearingOtherRemarks { get; set; }
        public string PilecapSoilCondition { get; set; }
        public string PilecapSoilSeverity { get; set; }
        public string PilecapSoilExtend { get; set; }
        public string PilecapSoilRemarks { get; set; }
        public string PilecapSoilRating { get; set; }
        public string PilecapDisplacementCondition { get; set; }
        public string PilecapDisplacementSeverity { get; set; }
        public string PilecapDisplacementExtend { get; set; }
        public string PilecapDisplacementRemarks { get; set; }
        public string PilecapDisplacementRating { get; set; }
        public string PilecapCrackCondition { get; set; }
        public string PilecapCrackSeverity { get; set; }
        public string PilecapCrackExtend { get; set; }
        public string PilecapCrackRemarks { get; set; }
        public string PilecapCrackRating { get; set; }
        public string PilecapSpallingCondition { get; set; }
        public string PilecapSpallingSeverity { get; set; }
        public string PilecapSpallingExtend { get; set; }
        public string PilecapSpallingRemarks { get; set; }
        public string PilecapSpallingRating { get; set; }
        public string PilecapCorrosionCondition { get; set; }
        public string PilecapCorrosionSeverity { get; set; }
        public string PilecapCorrosionExtend { get; set; }
        public string PilecapCorrosionRemarks { get; set; }
        public string PilecapCorrosionRating { get; set; }
        public string PilecapDegradeCondition { get; set; }
        public string PilecapDegradeSeverity { get; set; }
        public string PilecapDegradeExtend { get; set; }
        public string PilecapDegradeRemarks { get; set; }
        public string PilecapDegradeRating { get; set; }
        public string PilecapOtherRemarks { get; set; }
        public string WingwallDisplacementCondition { get; set; }
        public string WingwallDisplacementSeverity { get; set; }
        public string WingwallDisplacementExtend { get; set; }
        public string WingwallDisplacementRemarks { get; set; }
        public string WingwallDisplacementRating { get; set; }
        public string WingwallCrackCondition { get; set; }
        public string WingwallCrackSeverity { get; set; }
        public string WingwallCrackExtend { get; set; }
        public string WingwallCrackRemarks { get; set; }
        public string WingwallCrackRating { get; set; }
        public string WingwallSpallingCondition { get; set; }
        public string WingwallSpallingSeverity { get; set; }
        public string WingwallSpallingExtend { get; set; }
        public string WingwallSpallingRemarks { get; set; }
        public string WingwallSpallingRating { get; set; }
        public string WingwallCorrosionCondition { get; set; }
        public string WingwallCorrosionSeverity { get; set; }
        public string WingwallCorrosionExtend { get; set; }
        public string WingwallCorrosionRemarks { get; set; }
        public string WingwallCorrosionRating { get; set; }
        public string WingwallDegradeCondition { get; set; }
        public string WingwallDegradeSeverity { get; set; }
        public string WingwallDegradeExtend { get; set; }
        public string WingwallDegradeRemarks { get; set; }
        public string WingwallDegradeRating { get; set; }
        public string WingwallWeepholeCondition { get; set; }
        public string WingwallWeepholeSeverity { get; set; }
        public string WingwallWeepholeExtend { get; set; }
        public string WingwallWeepholeRemarks { get; set; }
        public string WingwallWeepholeRating { get; set; }
        public string WingwallOtherRemarks { get; set; }
        public string PierFdSoilCondition { get; set; }
        public string PierFdSoilSeverity { get; set; }
        public string PierFdSoilExtend { get; set; }
        public string PierFdSoilRemarks { get; set; }
        public string PierFdSoilRating { get; set; }
        public string PierFdDisplacementCondition { get; set; }
        public string PierFdDisplacementSeverity { get; set; }
        public string PierFdDisplacementExtend { get; set; }
        public string PierFdDisplacementRemarks { get; set; }
        public string PierFdDisplacementRating { get; set; }
        public string PierFdCrackCondition { get; set; }
        public string PierFdCrackSeverity { get; set; }
        public string PierFdCrackExtend { get; set; }
        public string PierFdCrackRemarks { get; set; }
        public string PierFdCrackRating { get; set; }
        public string PierFdSpallingCondition { get; set; }
        public string PierFdSpallingSeverity { get; set; }
        public string PierFdSpallingExtend { get; set; }
        public string PierFdSpallingRemarks { get; set; }
        public string PierFdSpallingRating { get; set; }
        public string PierFdCorrosionCondition { get; set; }
        public string PierFdCorrosionSeverity { get; set; }
        public string PierFdCorrosionExtend { get; set; }
        public string PierFdCorrosionRemarks { get; set; }
        public string PierFdCorrosionRating { get; set; }
        public string PierFdDegradeCondition { get; set; }
        public string PierFdDegradeSeverity { get; set; }
        public string PierFdDegradeExtend { get; set; }
        public string PierFdDegradeRemarks { get; set; }
        public string PierFdDegradeRating { get; set; }
        public string PierFdOtherRemarks { get; set; }
        public string PierDisplacementCondition { get; set; }
        public string PierDisplacementSeverity { get; set; }
        public string PierDisplacementExtend { get; set; }
        public string PierDisplacementRemarks { get; set; }
        public string PierDisplacementRating { get; set; }
        public string PierCrackCondition { get; set; }
        public string PierCrackSeverity { get; set; }
        public string PierCrackExtend { get; set; }
        public string PierCrackRemarks { get; set; }
        public string PierCrackRating { get; set; }
        public string PierSpallingCondition { get; set; }
        public string PierSpallingSeverity { get; set; }
        public string PierSpallingExtend { get; set; }
        public string PierSpallingRemarks { get; set; }
        public string PierSpallingRating { get; set; }
        public string PierCorrosionCondition { get; set; }
        public string PierCorrosionSeverity { get; set; }
        public string PierCorrosionExtend { get; set; }
        public string PierCorrosionRemarks { get; set; }
        public string PierCorrosionRating { get; set; }
        public string PierDegradeCondition { get; set; }
        public string PierDegradeSeverity { get; set; }
        public string PierDegradeExtend { get; set; }
        public string PierDegradeRemarks { get; set; }
        public string PierDegradeRating { get; set; }
        public string PierOtherRemarks { get; set; }
        public string RiverPierScouringCondition { get; set; }
        public string RiverPierScouringSeverity { get; set; }
        public string RiverPierScouringExtend { get; set; }
        public string RiverPierScouringRemarks { get; set; }
        public string RiverPierScouringRating { get; set; }
        public string RiverPierDebrisCondition { get; set; }
        public string RiverPierDebrisSeverity { get; set; }
        public string RiverPierDebrisExtend { get; set; }
        public string RiverPierDebrisRemarks { get; set; }
        public string RiverPierDebrisRating { get; set; }
        public string RiverPierCrackCondition { get; set; }
        public string RiverPierCrackSeverity { get; set; }
        public string RiverPierCrackExtend { get; set; }
        public string RiverPierCrackRemarks { get; set; }
        public string RiverPierCrackRating { get; set; }
        public string RiverPierSpallingCondition { get; set; }
        public string RiverPierSpallingSeverity { get; set; }
        public string RiverPierSpallingExtend { get; set; }
        public string RiverPierSpallingRemarks { get; set; }
        public string RiverPierSpallingRating { get; set; }
        public string RiverPierCorrosionCondition { get; set; }
        public string RiverPierCorrosionSeverity { get; set; }
        public string RiverPierCorrosionExtend { get; set; }
        public string RiverPierCorrosionRemarks { get; set; }
        public string RiverPierCorrosionRating { get; set; }
        public string RiverPierDegradeCondition { get; set; }
        public string RiverPierDegradeSeverity { get; set; }
        public string RiverPierDegradeExtend { get; set; }
        public string RiverPierDegradeRemarks { get; set; }
        public string RiverPierDegradeRating { get; set; }
        public string RiverPierOtherRemarks { get; set; }
        public string SlopeDisintegrateCondition { get; set; }
        public string SlopeDisintegrateSeverity { get; set; }
        public string SlopeDisintegrateExtend { get; set; }
        public string SlopeDisintegrateRemarks { get; set; }
        public string SlopeDisintegrateRating { get; set; }
        public string SlopeScouringCondition { get; set; }
        public string SlopeScouringSeverity { get; set; }
        public string SlopeScouringExtend { get; set; }
        public string SlopeScouringRemarks { get; set; }
        public string SlopeScouringRating { get; set; }
        public string SlopeErosionCondition { get; set; }
        public string SlopeErosionSeverity { get; set; }
        public string SlopeErosionExtend { get; set; }
        public string SlopeErosionRemarks { get; set; }
        public string SlopeErosionRating { get; set; }
        public string SlopeOtherRemarks { get; set; }
        public string SlopePierCrackCondition { get; set; }
        public string SlopePierCrackSeverity { get; set; }
        public string SlopePierCrackExtend { get; set; }
        public string SlopePierCrackRemarks { get; set; }
        public string SlopePierCrackRating { get; set; }
        public string SlopePierSpallingCondition { get; set; }
        public string SlopePierSpallingSeverity { get; set; }
        public string SlopePierSpallingExtend { get; set; }
        public string SlopePierSpallingRemarks { get; set; }
        public string SlopePierSpallingRating { get; set; }
        public string SlopePierCorrosionCondition { get; set; }
        public string SlopePierCorrosionSeverity { get; set; }
        public string SlopePierCorrosionExtend { get; set; }
        public string SlopePierCorrosionRemarks { get; set; }
        public string SlopePierCorrosionRating { get; set; }
        public string SlopePierOtherRemarks { get; set; }
        public string ChannelBlockageCondition { get; set; }
        public string ChannelBlockageSeverity { get; set; }
        public string ChannelBlockageExtend { get; set; }
        public string ChannelBlockageRemarks { get; set; }
        public string ChannelBlockageRating { get; set; }
        public string ChannelOtherRemarks { get; set; }
        public string UtilitiesCondition { get; set; }
        public string UtilitiesRemarks { get; set; }
        public string DeckDrainageOverallRating { get; set; }
        public string ParapetOverallRating { get; set; }
        public string JointOverallRating { get; set; }
        public string AbutmentOverallRating { get; set; }
        public string FurnitureOverallRating { get; set; }
        public string DeckTopOverallRating { get; set; }
        public string DeckEdgeOverallRating { get; set; }
        public string GirderOverallRating { get; set; }
        public string DiaphragmOverallRating { get; set; }
        public string BearingOverallRating { get; set; }
        public string PilecapOverallRating { get; set; }
        public string WingwallOverallRating { get; set; }
        public string PierFdOverallRating { get; set; }
        public string PierOverallRating { get; set; }
        public string RiverPierOverallRating { get; set; }
        public string SlopeOverallRating { get; set; }
        public string SlopePierOverallRating { get; set; }
        public string ChannelOverallRating { get; set; }
    }
}