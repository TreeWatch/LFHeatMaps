using CoreGraphics;
using Foundation;
using MapKit;
using UIKit;

namespace LFHeatMap
{
	// @interface LFHeatMap : NSObject
	[BaseType (typeof(NSObject))]
	interface LFHeatMap
	{
		// +(UIImage *)heatMapForMapView:(MKMapView *)mapView boost:(float)boost locations:(NSArray *)locations weights:(NSArray *)weights;
		[Static]
		[Export ("heatMapForMapView:boost:locations:weights:")]
        UIImage HeatMapForMapView (MKMapView mapView, float boost, NSObject[] locations, NSNumber[] weights);

		// +(UIImage *)heatMapWithRect:(CGRect)rect boost:(float)boost points:(NSArray *)points weights:(NSArray *)weights;
		[Static]
		[Export ("heatMapWithRect:boost:points:weights:")]
        UIImage HeatMapWithRect (CGRect rect, float boost, NSObject[] points, NSNumber[] weights);

		// +(UIImage *)heatMapWithRect:(CGRect)rect boost:(float)boost points:(NSArray *)points weights:(NSArray *)weights weightsAdjustmentEnabled:(BOOL)weightsAdjustmentEnabled groupingEnabled:(BOOL)groupingEnabled;
		[Static]
		[Export ("heatMapWithRect:boost:points:weights:weightsAdjustmentEnabled:groupingEnabled:")]
        UIImage HeatMapWithRect (CGRect rect, float boost, NSObject[] points, NSNumber[] weights, bool weightsAdjustmentEnabled, bool groupingEnabled);
	}
}
