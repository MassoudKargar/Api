﻿namespace Api.Domain.CommandResult
{
    public class AddProductResult
    {

        public AddProductResult(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
