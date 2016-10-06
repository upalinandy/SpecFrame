Feature: GoogleGeoCode
	To test the latitude and longgitude for location


Scenario: Verify Latitude and Longitude 
	Given Google api that takes address and returns latitude and longitude
	When The client Gets response by "1600+Amphitheatre+Parkway,+Mountain+View,+CA"
	Then The "37.4223329" and "-122.0844192" returned should be as expected
