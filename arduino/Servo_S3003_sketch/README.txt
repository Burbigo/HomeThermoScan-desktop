Write in serial port: direction + angle (without spaces or arithmetic chars).

Where:
  - direction is a single char 'v' or 'h', which means vertical or horizontal servo moving in accordance;
  - angle is a single integer number between 0..179 degrees, which say on which angle servo have to sweep;

Examples:
    v180
      vertical sweep from forward position to 180° position;
    h47
      horizontal sweep from forward position to 47° position;