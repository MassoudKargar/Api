﻿namespace Api.Domain.CommandResult
{
    public class UpdateProductResult
    {

        public UpdateProductResult(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
