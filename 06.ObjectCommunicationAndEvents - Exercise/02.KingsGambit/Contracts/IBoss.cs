﻿using System.Collections.Generic;

public interface IBoss
{
    IReadOnlyCollection<ISubordinate> Subordinates { get; }

    void AddSubordinate(ISubordinate subordinate);
}