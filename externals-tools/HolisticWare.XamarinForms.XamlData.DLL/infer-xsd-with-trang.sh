#!/bin/sh

java \
	-jar trang.jar \
	-I xml \
	./xaml-data/conceptdev-xamarin-forms-samples/ServiceList.xaml \
	./xaml-data/conceptdev-xamarin-forms-samples/BugSweeperPage.xaml \
	./xaml-data/conceptdev-xamarin-forms-samples/CharacteristicDetail\ \(2\).xaml \
	./xaml-data/conceptdev-xamarin-forms-samples/CharacteristicDetail.xaml \
	./xaml-data/conceptdev-xamarin-forms-samples/CharacteristicDetail_Hrm.xaml \
	./xaml-data/conceptdev-xamarin-forms-samples/CharacteristicDetail_TISensor.xaml \
	./xaml-data/conceptdev-xamarin-forms-samples/CharacteristicDetail_TISwitch.xaml \
	./xaml-data/conceptdev-xamarin-forms-samples/CharacteristicList\ \(2\).xaml \
	./xaml-data/conceptdev-xamarin-forms-samples/CharacteristicList.xaml \
	./xaml-data/conceptdev-xamarin-forms-samples/DeviceList\ \(2\).xaml \
	./xaml-data/conceptdev-xamarin-forms-samples/DeviceList.xaml \
	./xaml-data/conceptdev-xamarin-forms-samples/EmployeeListXaml.xaml \
	./xaml-data/conceptdev-xamarin-forms-samples/EmployeeXaml.xaml \
	./xaml-data/conceptdev-xamarin-forms-samples/LoginXaml.xaml \
	./xaml-data/conceptdev-xamarin-forms-samples/MagicBallPage.xaml \
 	inferred-with_trang.xsd
