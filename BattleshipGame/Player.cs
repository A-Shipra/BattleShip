using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace BattleshipGame
{
    public class BoardTile
    {
        public int x { get; set; }
        public int y { get; set; }
        public TileStatus status { get; set; }
        public bool IsShotAlready { get; set; }
    }
    public enum TileStatus
    {
        Water,
        Ship,
        Hit
    }
    public class Player
    {
        public Random _random = new Random();
        const int _boradSize = 10;
        public List<BoardTile> _boardTiles;
        public readonly string _orientation;

        public Player(string orientation)
        {
            _orientation = orientation;

            InitialiseBoard();
            DebugMessages();
        }

        private void InitialiseBoard()
        {
            _boardTiles = new List<BoardTile>();
            for (int x = 0; x < _boradSize; x++)
            {
                for (int y = 0; y < _boradSize; y++)
                {
                    _boardTiles.Add(new BoardTile { status = TileStatus.Water, x = x, y = y });
                }
            }
        }

        public bool IsGameFinished()
        {
            if (!_boardTiles.Exists(a => a.status == TileStatus.Ship))
                return true;
            else
                return false;
        }

        public string ShootTile(int x, int y)
        {
            var tile = _boardTiles.Find(a => (a.x == x) && (a.y == y));
            if (tile.IsShotAlready)
            {
                return "Shot already";
            }
            tile.IsShotAlready = true;
            if (tile.status == TileStatus.Ship)
            {
                tile.status = TileStatus.Hit;
                return "Hit";
            }
            else
            {
                return "Miss";
            }

        }

        public void Addship(int size)
        {
            int xcoor;
            int ycoor;
            bool isSuccessful = false;
            do
            {
                xcoor = _random.Next(0, _boradSize);
                ycoor = _random.Next(0, _boradSize);
                isSuccessful = AddShipAtValidTiles(xcoor, ycoor, size);

            } while (!isSuccessful);

            DebugMessages();
        }

        private bool AddShipAtValidTiles(int xcoor, int ycoor, int shipSize)
        {
            List<BoardTile> _tempBoardTiles = new List<BoardTile>();

            if (_orientation == "Horizontal")
            {

                int startXLocation;
                if (shipSize < xcoor)
                {
                    startXLocation = xcoor;
                }
                else
                {
                    startXLocation = shipSize - 1;
                }

                for (int i = 0; i < shipSize; i++)
                {
                    int tileXLocation = startXLocation - i;
                    BoardTile tile = new BoardTile { x = tileXLocation, y = ycoor, status = TileStatus.Ship };
                    _tempBoardTiles.Add(tile);

                    if (_boardTiles.Exists(a => (a.x == tileXLocation) && (a.y == ycoor) && (a.status == TileStatus.Ship)))
                        return false;//Ship already at this location
                }
            }
            else
            {
                int startYLocation;
                if (shipSize < ycoor)
                {
                    startYLocation = ycoor;
                }
                else
                {
                    startYLocation = shipSize - 1;
                }

                for (int i = 0; i < shipSize; i++)
                {
                    int tileYLocation = startYLocation - i;
                    BoardTile tile = new BoardTile { x = xcoor, y = tileYLocation, status = TileStatus.Ship };
                    _tempBoardTiles.Add(tile);


                    if (_boardTiles.Exists(a => (a.x == xcoor) && (a.y == tileYLocation) && (a.status == TileStatus.Ship)))
                        return false;//Ship already at this location
                }
            }

            foreach (var newTile in _tempBoardTiles)
            {
                _boardTiles.Find(a => (a.x == newTile.x) && (a.y == newTile.y)).status = TileStatus.Ship;
            }
            return true;
        }

        public string DebugMessages()
        {
            StringBuilder sb = new StringBuilder();
            Debug.WriteLine("----start----");
            int i = 0;
            foreach (var item in _boardTiles)
            {

                sb.Append($"{item.x}{item.y}-{item.status.ToString()}    ");
                i++;
                if (i == _boradSize)
                {
                    sb.AppendLine();
                    i = 0;
                }
            }

            var s = sb.ToString();
            Debug.WriteLine(s);
            return s;
        }
    }
}
