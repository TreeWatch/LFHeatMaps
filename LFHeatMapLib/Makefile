XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
PROJECT_ROOT=./LFHeatMap/
PROJECT=$(PROJECT_ROOT)/LFHeatMap.xcodeproj
TARGET=LFHeatMap

all: libLFHeatMapSDK.a

libLFHeatMap-i386.a:
	    $(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
			-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@

libLFHeatMap-armv7.a:
	    $(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
			-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libLFHeatMap-armv7s.a:
			$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7s -configuration Release clean build
			-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libLFHeatMap-arm64.a:
			$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch arm64 -configuration Release clean build
			-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libLFHeatMapSDK.a: libLFHeatMap-i386.a libLFHeatMap-armv7.a libLFHeatMap-armv7s.a libLFHeatMap-arm64.a
			xcrun -sdk iphoneos lipo -create -output $@ $^

clean:
	    -rm -f *.a *.dll
