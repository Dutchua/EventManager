DROP TABLE attendeeDetails;

CREATE TABLE attendeeDetails (
	PersonID SERIAL PRIMARY KEY,
	name VARCHAR ( 120 ) NULL,
	surname VARCHAR ( 120 ) NULL,
	company VARCHAR ( 120 )  NULL,
	AccessNumber CHAR ( 36 ) NULL
);