Feature: Create, Edit and Delete TM Record

Scenario: Create a TM record
Given user logs into TurnUp portal
And user navigates to a Time and Material Page
When user create a new Time and material Record
Then TurnUp portal should save the new time and material record

Scenario: Edit a TM record
Given user logs into TurnUp portal
And user navigates to a Time and Material Page
When user Edits existing Time and material Record
Then TurnUp portal should save existing time and material record


Scenario: Delete a TM record
Given user logs into TurnUp portal
And user navigates to a Time and Material Page
When user Deletes existing Time and material Record
Then TurnUp portal should Delete existing time and material record