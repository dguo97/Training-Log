-- Training Log: Access schema rebuilt from your design docs (2.1 screenshots, 1.4) and the VB code.
-- Access runs one statement at a time in SQL View, so paste and run each statement separately, in this order.

CREATE TABLE adminpassword (
  ID TEXT(255) PRIMARY KEY
);

CREATE TABLE persondetail (
  RunnerID COUNTER PRIMARY KEY,
  FirstName TEXT(255),
  SecondName TEXT(255),
  HouseNumber LONG,
  Postcode TEXT(255),
  PhoneNumber TEXT(255),
  DOB DATETIME,
  Weight LONG,
  Runnerusername TEXT(255),
  Runnerpassword TEXT(255)
);

CREATE TABLE traininginformation (
  RunnerID LONG,
  Runningtime SINGLE,
  RunningSpeed TEXT(255),
  Cyclingspeed TEXT(255),
  Cyclingtime SINGLE,
  Swimmingstyle TEXT(255),
  swimmingtime SINGLE,
  caloriesburned SINGLE,
  trainingNO COUNTER PRIMARY KEY,
  trainingdate DATETIME,
  CONSTRAINT fk_training_runner FOREIGN KEY (RunnerID) REFERENCES persondetail (RunnerID) ON DELETE CASCADE
);

CREATE TABLE ranking (
  RunnerID LONG PRIMARY KEY,
  runnerposition LONG,
  Totalcaloriesburned SINGLE,
  Rankingofcalories LONG,
  Totaltimeoftraining SINGLE,
  Rankingoftime LONG,
  Rankingofpoints LONG,
  points LONG,
  lastraceposition LONG,
  Averageranking DOUBLE,
  CONSTRAINT fk_ranking_runner FOREIGN KEY (RunnerID) REFERENCES persondetail (RunnerID) ON DELETE CASCADE
);
