class PosisiKarakterGame
{
    enum State { BERDIRI, TERBUKA,
        TENGKURAP
    }
    public void posisi()
    {
        State state = State.BERDIRI;

        String[] screenName = { "BERDIRI", "TENGKURAP" };
        do
        {
            Console.WriteLine("KARAKTER " + screenName[(int)state]);
            Console.Write("Enter Command : ");
            String command = Console.ReadLine();
            switch (state)
            {
                case State.BERDIRI:
                    if (command == "posisi standby")
                    {
                        state = State.TENGKURAP;
                    }
                    break;
                case State.TENGKURAP:
                    if (command == "posisi istirahat")
                    {
                        state = State.BERDIRI;
                    }
                    break;


            }
        } while (state != State.BERDIRI);
    }
}