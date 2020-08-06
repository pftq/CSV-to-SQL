CSV to SQL
by pftq
February 14, 2013

  This is a quick application for loading all rows in a CSV (with header columns) into an existing SQL table.
  
  This was created in C# for a few tasks I needed to get done, but perhaps others out there might also find it useful.
  
Updates
20140601: Updated to replace NaNs with 0s.
20140528: Added batch file loading.  Sped up performance using bulk inserts.