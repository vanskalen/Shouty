Feature: Hear Shout

  Shouts have a range of approximately 1000m

Background:
    Given Lucy is at 0, 0

Scenario: Multiple shouts from one person 
    #Given Lucy is at 0, 0
    Given Sean is at 0, 500
    When Sean shouts
    And Sean shouts
    Then Lucy should hear 2 shouts from Sean

Scenario: Shouter should not hear their own shouts
    When Lucy shouts
    Then Lucy should not hear Lucy

Scenario: Multiple Shouters One Heard
    Given people are located at
        | name | x  | y |
        | Lucy | 0  | 0 |
        | Sean | 0  | 500 |
        | Oscar | 1100 | 0 |
    When Sean shouts
    And Oscar shouts
    Then Lucy should not hear Oscar
    But Lucy should hear Sean
    
 Scenario: Multiple Shouters All Heard
    #Given Lucy is at 0, 0
    Given Sean is at 0, 500
    And Oscar is at 300, 400
    When Sean shouts
    And Oscar shouts
    Then Lucy should hear Oscar
    But Lucy should hear Sean

Scenario Outline: only hear in-range shouts
    #Given Lucy is at 100000, 0
    Given Sean is at <Seans-location>
    When Sean shouts
    Then Lucy should hear <what-Lucy-hears>
    
Examples: some simple examples
        | id | Seans-location | what-Lucy-hears |
        | 01 | 0, 900         | Sean            |
        | 02 | 800, 800       | nothing         |

Examples: some additional examples
        | id | Seans-location | what-Lucy-hears |
        | 03 | 900, 900       | nothing            |
        | 04 | 800, 800       | nothing         |
