namespace hw_1.InMemoryModel
{
    interface IModelChanger
    {
        public void NotifyChange(IModelChanger sender);
    }
}